using System;
using System.IO;
using System.Text;

namespace Lesson09
{
    class MainClass
    {
        static void WriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("Enter the data to write to the file:");
                string writeText = Console.ReadLine();

                sw.WriteLine(writeText);
                foreach(var item in writeText)
                {
                    sw.Write(item+" ");
                }
                Console.WriteLine("\nData recorded!");
            }
        }
        static string ReaDFile(string path  )
        {
            using (StreamReader sr = File.OpenText(path))
            {
                return sr.ReadToEnd();
            }
        }
        public static void Main(string[] args)
        {
            string path=@"/Users/anatolyshandov/Documents/Test";
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Date and time of catalog creation: {Directory.GetCreationTime(path)}");

                Console.WriteLine("Subdirectiories in the specified directory:");
                foreach (string item in Directory.GetDirectories(path))
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine("\nLogical devices of this computer:");
                foreach (string item in Directory.GetLogicalDrives())
                {
                    Console.WriteLine($"\t {item}");
                }

                Directory.Delete(path, true);
            }
                if(!Directory.Exists(path))
                {
                    Console.WriteLine("\nSpecified directory doesn't exist");

                }
            
            //try
            //{
            //    WriteFile(path);
            //    Console.WriteLine("\nData from the file:");
            //    Console.WriteLine(ReaDFile(path));
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine();
            //if (!directoryInfo.Exists)
            //{
            //    directoryInfo.Create();
            //}
            //Console.WriteLine($"Last access to the directory:{directoryInfo.LastAccessTime}");
            //DirectoryInfo directoryInfo1 = directoryInfo.CreateSubdirectory("SubDir");
            //Console.WriteLine($"Full path to the directory;{directoryInfo1.FullName}");
            //FileInfo fileInfo = new FileInfo(directoryInfo1 + @"/Test.bin");
            //WriteFile(fileInfo);
            //Console.WriteLine(ReaDFile(fileInfo));
            //Console.WriteLine("\nOnly files with .bin extension");
            //FileInfo[] binFiles = directoryInfo1.GetFiles("*.bin");
            //foreach(FileInfo file in binFiles)
            //{
            //    Console.WriteLine(file.Name);
            //}
            //Console.WriteLine(directoryInfo1); 
            //Console.WriteLine(ReaDFile(directoryInfo1));
            //Console.WriteLine($"Full path to the directory: {directoryInfo.FullName}");
            //Console.WriteLine($"Time of creation: {directoryInfo.CreationTime}");
            //Console.WriteLine($"All directory files:");
            //FileInfo [] fi = directoryInfo.GetFiles();
            //foreach(FileInfo file in fi)
            //{
            //    Console.WriteLine(file.Name);
            //}
            //    string filePath = "test.txt";

            //    using (FileStream fs = new FileStream(filePath, FileMode.Create))
            //    {
            //        using (BinaryWriter bw = new  BinaryWriter(fs, Encoding.Unicode))
            //        {
            //            string s = "I love u, dear Kris";
            //            string sq = "Я тебя люблю, Крис";
            //            double d = 5.43;
            //            int i= 54;

            //            bw.Write(sq);
            //            bw.Write(d);
            //            bw.Write(i);
            //        }

            //    }
            //    {
            //        using (FileStream fs1 = new FileStream(filePath, FileMode.Open))
            //        {
            //            using (BinaryReader br = new BinaryReader(fs1, Encoding.Unicode))
            //            {

            //                Console.WriteLine($"\nString data from the file: {br.ReadString()}");
            //                Console.WriteLine($"\nString data from the file: {br.ReadDouble()}");
            //                Console.WriteLine($"\nString data from the file: {br.ReadInt32()}");
            //            }
            //        }
            //    }
            //}
        }
    }
}
