using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using static ClassLibrary2.Course;
using static ClassLibrary2.Student;

namespace Sql_Storedprocedures
{
    public class TeacherMain
    {
        static void Main(string[] args)
        {

           Stored stored = new Stored();
            Teacher teacher = new Teacher();
            teacher.TEACHER_ID = 14;
            teacher.TEACHER_NAME = "jack";
                teacher.AGE = 36;
            stored.Insertsp(teacher);
            //stored.Retrivesp();
            //stored.Insertsp();

           

            







            //List<Teacher> t = new List<Teacher>();
            //Crud_oper crud = new Crud_oper();
            //Teacher teacher = new Teacher();
            //t.TEACHER_ID = 7;
            //t.TEACHER_NAME = 'Mahesh';
            //t.AGE = 26;
            //Crud.Insert(t);

            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Error Generated. Details: " + e.ToString());
            //}
            //finally
            //{
            //    conn.Close();
            //    Console.Read();
            //}




        }

    }
}
