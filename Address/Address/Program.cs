using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 获取程序的基目录。
            //System.AppDomain.CurrentDomain.BaseDirectory

            //// 获取模块的完整路径。
            //System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName

            //// 获取和设置当前目录(该进程从中启动的目录)的完全限定目录。
            //System.Environment.CurrentDirectory

            //// 获取应用程序的当前工作目录。
            //System.IO.Directory.GetCurrentDirectory()

            //// 获取和设置包括该应用程序的目录的名称。
            //System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase

            //// 获取启动了应用程序的可执行文件的路径。
            //System.Windows.Forms.Application.StartupPath

            //// 获取启动了应用程序的可执行文件的路径及文件名
            //System.Windows.Forms.Application.ExecutablePath

            //获取目录
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);



            //获取当前程序的 装配
            var ass = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in ass)
            {
                Console.WriteLine(a.FullName);
            }

            //反射
            var assm = Assembly.Load("TestLibrary");
            Type type = assm.GetType("TestLibrary.Class1");


            var f = typeof(TestLibrary.Class1);
            var d = Activator.CreateInstance(f);

            //2种实例化
            //var d=  Activator.CreateInstance(type); 
            //var d = assm.CreateInstance("TestLibrary.Class1");

            //调用
            Class1 p =d as Class1;
            p.Test();

            Console.ReadKey();
        }




    }
}
