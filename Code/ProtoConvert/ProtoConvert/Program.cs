using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string protoPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\ProtoFiles";
            string csharpPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\CSharpFiles";
            string dllPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\DLLFiles";
            Converter converter = new Converter(protoPath, csharpPath, dllPath);
            converter.Convert();
        }
    }
}
