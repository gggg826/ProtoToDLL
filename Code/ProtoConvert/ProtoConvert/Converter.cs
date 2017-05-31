using System;
using System.IO;
using System.Text;

namespace ProtoConvert
{
    public class Converter
	{
		/// <summary>
		/// 存放.proto文件的目录，这个路径应该由外部传进来
		/// </summary>
		public string ProtoFilesPath
		{
			get
			{
				return m_ProtoFilesPath;
			}

			set
			{
				m_ProtoFilesPath = value;
			}
		}
		private string m_ProtoFilesPath;

		/// <summary>
		/// 存放要生成的.cs文件的目录，这个路径应该由外部传进来
		/// </summary>
		public string CSharpFilesPath
		{
			get
			{
				return m_CSharpFilesPath;
			}

			set
			{
				m_CSharpFilesPath = value;
			}
		}
		private string m_CSharpFilesPath;

		/// <summary>
		/// 存放.dll文件的目录，这个路径应该由外部传进来
		/// </summary>
		public string DLLFilesPath
		{
			get
			{
				return m_DLLFilesPath;
			}

			set
			{
				m_DLLFilesPath = value;
			}
		}
		private string m_DLLFilesPath;

		/// <summary>
		/// 编译.dll文件名字
		/// </summary>
		public string DLLName
		{
			get
			{
				return m_DLLName;
			}

			set
			{
				m_DLLName = value;
			}
		}
		private string m_DLLName;

		private const string DESCRIPTION_PROTO_FILE_NAME = "descriptor.proto";
		
		/// <summary>
		/// 程序的根目录，如果已发布则是包含.exe的目录，如果是Debug则是Debug目录，release同理
		/// </summary>
		private static string AppRootPath;

		/// <summary>
		/// protocolbuf-net.dll文件所在的路径
		/// </summary>
		private static string Protobuf_net_Full_Name;

		/// <summary>
		/// protoGen.exe文件所在的路径
		/// </summary>
		private static string ProtoGen_exe_Full_Name;

		/// <summary>
		/// Precomplie.exe文件所在的路径
		/// </summary>
		private static string Precomplie_exe_Full_Name;

		/// <summary>
		/// 编译dll所用csc.exe所在路径
		/// </summary>
		private static string Csc_exe_Full_Name;

		/// <summary>
		/// 编译dll所用system.dll所在路径
		/// </summary>
		private static string System_dll_Full_Name;

		/// <summary>
		/// 编译dll所用core.dll所在路径
		/// </summary>
		private static string Core_dll_Full_Name;
		

		/// <summary>
		/// 旧的.dll文件名字，用于与新的.dll对比差异
		/// </summary>
		private string m_OldDLLName;

		/// <summary>
		/// 包含所有.proto文件路径的数组
		/// </summary>
		private string[] m_ProtoFiles;
		
		
		public Converter()
        {
			AppRootPath = AppDomain.CurrentDomain.BaseDirectory;
			Protobuf_net_Full_Name = string.Format("{0}..\\Core\\protobuf-net.dll", AppRootPath);
			ProtoGen_exe_Full_Name = string.Format("{0}..\\ProtoGen\\protogen.exe", AppRootPath);
			Precomplie_exe_Full_Name = string.Format("{0}..\\Precompile\\precompile.exe", AppRootPath);
			Csc_exe_Full_Name = "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\csc.exe";
			System_dll_Full_Name = "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\System.dll";
			Core_dll_Full_Name = "C:\\Program Files\\Reference Assemblies\\Microsoft\\Framework\\v3.5\\System.Core.dll";
		}

		/// <summary>
		/// 读取.proto文件，并将其转换成.cs文件，最终编译为.dll文件
		/// TODO:新旧dll文件差异校检与结果保存
		/// </summary>
        public void Convert()
        {
			Console.WriteLine(AppRootPath);
			Console.WriteLine();
			Console.WriteLine(string.Format("Generate flie name : {0}", m_DLLName));
            Console.WriteLine("\n>>>>>>>>> Convert Protos......\n");

			CheckFolder(m_ProtoFilesPath);
			DeleteFolder(m_CSharpFilesPath);
			CheckFolder(m_CSharpFilesPath);
			m_ProtoFiles = Directory.GetFiles(m_ProtoFilesPath, "*.proto", SearchOption.AllDirectories);
			Directory.SetCurrentDirectory(m_ProtoFilesPath);
			for (int i = 0; i < m_ProtoFiles.Length; i++)
            {
                if (m_ProtoFiles[i].EndsWith(DESCRIPTION_PROTO_FILE_NAME))
                    continue;

                ConvertProtoFileToCSharp(m_ProtoFiles[i]);
            }


			CheckFolder(m_DLLFilesPath);
			Directory.SetCurrentDirectory(m_DLLFilesPath);
			Console.WriteLine("\n>>>>>>>>> Complie DLL......\n");
            ComplieDLL();
			Console.WriteLine(">>>>>>>>> Complie DLL Done......\n");

			Console.WriteLine("\n>>>>>>>>> Complie PreCompileDLL......\n");
			PreComplieSerializeDLL();
			Console.WriteLine(">>>>>>>>> Complie PreCompileDLL Done......\n");

			Directory.SetCurrentDirectory(AppRootPath);

			SaveChangeLog();

			CopyFile(Protobuf_net_Full_Name, m_DLLFilesPath);

            Console.WriteLine("\n\nAll Done......");
            //Console.ReadKey();
        }

		/// <summary>
		/// 编译.dll文件
		/// </summary>
        private void ComplieDLL()
        {
			//备份上一次生成的DLL 
			m_OldDLLName = m_DLLName + ".old";
            if(File.Exists(m_DLLName))
            {
                if (File.Exists(m_OldDLLName))
                    File.Delete(m_OldDLLName);
                File.Move(m_DLLName, m_OldDLLName);
            }

            StringBuilder cmd = new StringBuilder();
            cmd.Append(string.Format("/noconfig \"/out:{0}\" ", m_DLLName));
            cmd.Append(string.Format("\"/r:{0}\" ", System_dll_Full_Name));
            cmd.Append(string.Format("\"/r:{0}\" ", Protobuf_net_Full_Name));
            cmd.Append(string.Format("\"/r:{0}\" ", Core_dll_Full_Name));
            cmd.Append(" /nologo /warn:4 /optimize- /t:library ");

            string[] csharps = Directory.GetFiles(m_CSharpFilesPath, "*.cs", SearchOption.AllDirectories);
            for (int i = 0; i < csharps.Length; i++)
            {
                cmd.Append(string.Format("\"{0}\" ", csharps[i]));
            }
            cmd.Append(" /fullpaths /utf8output");
			
            System.Diagnostics.Process csc = new System.Diagnostics.Process();
            csc.StartInfo.FileName = Csc_exe_Full_Name;
            csc.StartInfo.Arguments = cmd.ToString();
            csc.StartInfo.RedirectStandardOutput = true;
            csc.StartInfo.UseShellExecute = false;
            csc.Start();

            Console.WriteLine(csc.StandardOutput.ReadToEnd().Trim());

        }

		/// <summary>
		/// 预编译序列化库
		/// </summary>
		private void PreComplieSerializeDLL()
        {
			string dllNameWithoutExtension = m_DLLName.TrimEnd(new char[] { '.', 'd', 'l' });
			System.Diagnostics.Process preComplile = new System.Diagnostics.Process();
			preComplile.StartInfo.FileName = Precomplie_exe_Full_Name;
			preComplile.StartInfo.Arguments = string.Format("{0} -o:{1} -t:{2} {3}"
														   , m_DLLName
														   , string.Format(".\\{0}_{1}.dll", dllNameWithoutExtension, "Precompiled")
														   , dllNameWithoutExtension
														   , Protobuf_net_Full_Name);
			preComplile.StartInfo.RedirectStandardOutput = true;
			preComplile.StartInfo.UseShellExecute = false;
			preComplile.Start();

			Console.WriteLine(string.Format(preComplile.StandardOutput.ReadToEnd().Trim()));
		}
        
		/// <summary>
		/// 将.proto文件转换为.cs文件
		/// </summary>
		/// <param name="protoFilePath"></param>
        private void ConvertProtoFileToCSharp(string protoFilePath)
        {
            string protoName = Path.GetFileName(protoFilePath);
            string csharpName = Path.GetFileNameWithoutExtension(protoFilePath);

            System.Diagnostics.Process protoc = new System.Diagnostics.Process();
            protoc.StartInfo.FileName = ProtoGen_exe_Full_Name;
            protoc.StartInfo.Arguments = string.Format("-i:{0} -o:{1}\\{2}.cs", protoName, m_CSharpFilesPath, csharpName);
            protoc.StartInfo.RedirectStandardOutput = true;
            protoc.StartInfo.UseShellExecute = false;
            protoc.Start();

            Console.WriteLine(string.Format("{0} - {1}", protoc.StandardOutput.ReadToEnd().Trim(), protoName));
        }
        
		private void CopyFile(string file, string targetFolder, bool overwrite = false)
		{
			string targetFile = targetFolder + "\\" + Path.GetFileName(file);
			if (overwrite || !File.Exists(targetFile))
				File.Copy(file, targetFile, overwrite);
		}

        private void CheckFolder(string folder)
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
        }

        private void DeleteFolder(string folder)
        {
            if (Directory.Exists(folder))
                Directory.Delete(folder, true);
        }
        
        private void GetDLLInfo()
        {
            // TODO implement here
        }
        
        private void SaveChangeLog()
        {
            // TODO implement here
        }
    }
}
