using System;
using System.IO;

namespace ProtoConvert
{
    class Program
    {
		private static string AppRootPath = AppDomain.CurrentDomain.BaseDirectory;
		//TODO:把配置文件改为config.json，并把以下的文件夹路径配置在config中
		private static string ProtoPath = string.Format("{0}..\\..\\ProtoFiles", AppRootPath);
		private static string CSharpPath = string.Format("{0}..\\..\\CSharpFiles", AppRootPath);
		private static string DLLPath = string.Format("{0}..\\..\\DLLFiles", AppRootPath);
		private static string ConfigPath = string.Format("{0}..\\..\\Config.txt", AppRootPath);

		private static string GetDLLName()
		{
			string dllName = string.Empty;
			if (Directory.Exists(ConfigPath))
			{
				StreamReader sr = new StreamReader(ConfigPath);
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

		static void Main(string[] args)
        {
            Converter converter = new Converter();
			converter.ProtoFilesPath = ProtoPath;
			converter.CSharpFilesPath = CSharpPath;
			converter.DLLFilesPath = DLLPath;
			converter.DLLName = GetDLLName();
            converter.Convert();
        }
    }
}
