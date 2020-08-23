using System;
using System.IO;

namespace _01.数据类型 {
    class Program {
        static void Main (string[] args) {
            FileStream F = new FileStream ("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string filePath = @"./test.dat";
            string dirPath = @"./";

            for (int i = 1; i <= 22; i++) {
                F.WriteByte ((byte) i);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++) {
                Console.Write (F.ReadByte () + " ");
            }
            F.Close ();
            
            Console.WriteLine();
            //获得当前路径
            Console.WriteLine (Environment.CurrentDirectory);
            //文件或文件夹所在目录
            Console.WriteLine (Path.GetDirectoryName (filePath));
            Console.WriteLine (Path.GetDirectoryName (dirPath));
            //文件扩展名
            Console.WriteLine (Path.GetExtension (filePath));
            //文件名
            Console.WriteLine (Path.GetFileName (filePath));
            Console.WriteLine (Path.GetFileName (dirPath));
            Console.WriteLine (Path.GetFileNameWithoutExtension (filePath));
            //绝对路径
            Console.WriteLine (Path.GetFullPath (filePath));
            Console.WriteLine (Path.GetFullPath (dirPath));
            //更改扩展名
            Console.WriteLine (Path.ChangeExtension (filePath, ".jpg"));
            //根目录
            Console.WriteLine (Path.GetPathRoot (dirPath));
            //生成路径
            Console.WriteLine (Path.Combine (new string[] { @"D:\", "BaseDir", "SubDir", "TestFile.txt" }));

            Console.ReadKey ();
        }
    }
}
