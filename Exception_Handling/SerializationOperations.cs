using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace Exception_Handling
{
    public class SerializationOperations
    {
        public void Serialization()
        {

            Teacher_DTO obj = new Teacher_DTO();
            obj.Teacher_id = 1;
            obj.Teacher_name = "sree";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\sribh\Documents\Serialization.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();
            Console.Read();
        }
        public void DeSerialization()
        {

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\sribh\Documents\Serialization.txt", FileMode.Open, FileAccess.Read);
            Teacher_DTO objnew = (Teacher_DTO)formatter.Deserialize(stream);
            Console.WriteLine(objnew.Teacher_id);
            Console.WriteLine(objnew.Teacher_name);

            Console.Read();
        }
    }
}
