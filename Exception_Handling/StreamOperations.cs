using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class StreamOperations
    {
        public void StreamReader()
        {
            string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        public void StreamWriter()
        {
            {
                string path = @"C:\Users\sribh\csharpdemo\Filehandling.txt";

                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(" \n StreamWriter Operation Succesful");
                    sr.Close();

                    Console.WriteLine(File.ReadAllText(path));
                }
                Console.ReadKey();
            }
        }
    }
}
