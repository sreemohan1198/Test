using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace Exception_Handling
{
    public class FileOperations
    {
        //public static void Main()
        //{
        //    StreamReader streamReader = null;
        //    try
        //    {
        //        streamReader = new StreamReader(@"C:\Users\sribh\csharpdemo\Filehandling.txt");
        //        Console.WriteLine(streamReader.ReadToEnd());
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        Console.WriteLine("Check if file {0} exists", ex.FileName);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    if (streamReader != null)
        //    {
        //        streamReader.Close();
        //    }

        //}

        public void FileExist()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            Console.ReadKey();
        }



        public void FileReadAlllines()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";

            if (File.Exists(path))
            {
                string[] lines;
                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            Console.ReadKey();

        }

        public void FileReadAllText()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";
            if (File.Exists(path))
            {
                string lines;
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            Console.ReadKey();
        }

        public void FileCopy()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";

            string copypath = @"C:\Users\sribh\csharpdemo\Filehandling1.txt";
            if (File.Exists(path))
            {
                File.Copy(path, copypath);
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }

            Console.ReadKey();
        }

        public void FileDelete()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            Console.ReadKey();

        }
    }
}
