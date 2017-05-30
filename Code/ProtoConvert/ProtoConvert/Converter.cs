using System;
using System.IO;
using System.Text;

namespace ProtoConvert
{
    public class Converter
    {
        private string m_ProtoFilesPath;
        private string m_CSharpFilesPath;
        private string m_DLLFilesPath;
        private string[] m_ProtoFiles;

        private string m_DLLName;
        private string m_OldDLLName;

        public Converter(string protoInPath, string csharpOutPath, string dllOutPath)
        {
            m_ProtoFilesPath = protoInPath;
            m_CSharpFilesPath = csharpOutPath;
            m_DLLFilesPath = dllOutPath;
            m_ProtoFiles = Directory.GetFiles(m_ProtoFilesPath, "*.proto", SearchOption.AllDirectories);
            //for (int i = 0; i < m_ProtoFiles.Length; i++)
            //{
            //    m_ProtoFiles[i] = m_ProtoFiles[i].Replace(m_ProtoFilePath, "\\");
            //}

            m_DLLName = GetDLLName();
            m_OldDLLName = m_DLLName + ".old";
        }

        public void Convert()
        {
            Console.WriteLine(string.Format("Generate flie name : {0}", m_DLLName));

            DeleteCSharpFolder();
            CheckCSharpFolder();

            Console.WriteLine("\n>>>>>>>>> Convert Protos......\n");

            for (int i = 0; i < m_ProtoFiles.Length; i++)
            {
                if (m_ProtoFiles[i].EndsWith("descriptor.proto"))
                    continue;

                ConvertProtoFileToCSharp(m_ProtoFiles[i]);
            }

            Console.WriteLine("\n>>>>>>>>> Complie DLL......\n");
            ComplieDLL();

            SaveChangeLog();

            Console.WriteLine("All Done......");
            Console.ReadKey();
        }

        private void ComplieDLL()
        {
            if(File.Exists(m_DLLName))
            {
                if (File.Exists(m_OldDLLName))
                    File.Delete(m_OldDLLName);
                File.Move(m_DLLName, m_OldDLLName);
            }

            StringBuilder cmd = new StringBuilder();
            cmd.Append(string.Format("/noconfig \"/out:{0}\" ", m_DLLName));
            cmd.Append("\"/r:C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\System.dll\" ");
            cmd.Append(string.Format("\"/r:{0}\\..\\Core\\protobuf-net.dll\" ", AppDomain.CurrentDomain.BaseDirectory));
            cmd.Append("\"/r:C:\\Program Files\\Reference Assemblies\\Microsoft\\Framework\\v3.5\\System.Core.dll\" ");
            cmd.Append(" /nologo /warn:4 /optimize- /t:library ");

            string[] csharps = Directory.GetFiles(m_CSharpFilesPath, "*.cs", SearchOption.AllDirectories);
            for (int i = 0; i < csharps.Length; i++)
            {
                cmd.Append(string.Format("\"{0}\" ", csharps[i]));
            }

            cmd.Append(" /fullpaths /utf8output");

            string cscPath = "C:\\WINDOWS\\Microsoft.NET\\Framework\\v2.0.50727\\csc.exe";
            System.Diagnostics.Process csc = new System.Diagnostics.Process();
            csc.StartInfo.FileName = cscPath;
            csc.StartInfo.Arguments = cmd.ToString();
            csc.StartInfo.RedirectStandardOutput = true;
            csc.StartInfo.UseShellExecute = false;
            csc.Start();

            Console.WriteLine(csc.StandardOutput.ReadToEnd().Trim());

        }
        
        private void PreComplieSerializeDLL()
        {
            // TODO implement here
        }
        
        private void ConvertProtoFileToCSharp(string protoFilePath)
        {
            Directory.SetCurrentDirectory(m_ProtoFilesPath);

            string protoName = Path.GetFileName(protoFilePath);
            string csharpName = Path.GetFileNameWithoutExtension(protoFilePath);
            string protoGen = "../bin/ProtoGen/protogen.exe";
            System.Diagnostics.Process protoc = new System.Diagnostics.Process();
            protoc.StartInfo.FileName = protoGen;
            protoc.StartInfo.Arguments = string.Format("-i:{0} -o:{1}\\{2}.cs", protoName, m_CSharpFilesPath, csharpName);
            protoc.StartInfo.RedirectStandardOutput = true;
            protoc.StartInfo.UseShellExecute = false;
            protoc.Start();

            Console.WriteLine(string.Format("{0} - {1}", protoc.StandardOutput.ReadToEnd().Trim(), protoName));
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }
        
        private void CheckCSharpFolder()
        {
            if (!Directory.Exists(m_CSharpFilesPath))
                Directory.CreateDirectory(m_CSharpFilesPath);
        }

        private void DeleteCSharpFolder()
        {
            if (Directory.Exists(m_CSharpFilesPath))
                Directory.Delete(m_CSharpFilesPath, true);
        }
        
        private void GetDLLInfo()
        {
            // TODO implement here
        }
        
        private string GetDLLName()
        {
            string dllName = string.Empty;
            string config = ".../Config.txt";
            if (Directory.Exists(config))
            {
                StreamReader sr = new StreamReader(config);
                string str = sr.ReadToEnd().Trim();
                sr.Close();

                string[] lines = str.Split('\n');
                string[] nameConfig = lines[0].Split('=');
                dllName = nameConfig[1];
            }
            else
                dllName = "PROTO_CLIENT";

            if (!dllName.ToLower().EndsWith(".dll"))
                dllName += ".dll";

            return dllName;
        }
        
        private void SaveChangeLog()
        {
            // TODO implement here
        }
    }
}
