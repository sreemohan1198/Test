using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using static ClassLibrary2.Student;
using static ClassLibrary2.Course;

namespace Sql_Storedprocedures
{
    public class Stored
    {
        public void Retrivesp()
        {
            String connString = "Data Source=.;Initial Catalog=TEACHER_STUDENT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            //cmd.CommandText = "INSERT INTO [dbo].[TEACHER](TEACHER_ID,TEACHER_NAME,AGE)\r\n VALUES (@TEACHER_ID,@TEACHER_NAME,@AGE)";
            //cmd.Parameters.AddWithValue("@TEACHER_ID", teach.TEACHER_ID);
            //cmd.Parameters.AddWithValue("@TEACHER_NAME", teach.TEACHER_NAME);
            //cmd.Parameters.AddWithValue("@AGE", teach.AGE);

            cmd.CommandText = "spGetStudentnameCoursename";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            //cmd.Parameters.AddWithValue("@STUDENT_NAME", student.STUDENT_NAME);
            //cmd.Parameters.AddWithValue("@COURSE_NAME", course.COURSE_NAME);
            while (reader.Read())
            {
                Student student = new Student();
                Course course = new Course();
                student.STUDENT_NAME = reader[0].ToString();
                course.COURSE_NAME = reader[1].ToString();
                Console.WriteLine(reader[0].ToString() + " - " + reader[1].ToString());

            }
        }


        //------------STORED PROCEDURE INSERTION----------------------//
        public void Insertsp(Teacher teach)
        {
            String connString = "Data Source=.;Initial Catalog=TEACHER_STUDENT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
           // conn.Open();
            cmd.CommandText = "sdteach";
            cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataReader reader = cmd.ExecuteReader();
           /* cmd.CommandText = @"INSERT INTO[dbo].[sdteach] ([TEACHER_ID],[TEACHER_NAME],[AGE])
                                VALUES(@TEACHER_ID,@TEACHER_NAME,@AGE)"; */
            cmd.Parameters.AddWithValue("@TEACHER_ID", teach.TEACHER_ID );
            cmd.Parameters.AddWithValue("@TEACHER_NAME",teach.TEACHER_NAME);
            cmd.Parameters.AddWithValue("@AGE",teach.AGE);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.Read();
            }
            Console.Read();
            //while (reader.Read())
            //{
            //    Teacher teacher = new Teacher();
            //    teacher.TEACHER_ID = reader[0].GetHashCode();
            //    teacher.TEACHER_NAME = reader[1].ToString();
            //    teacher.AGE= reader[2].GetHashCode();

            //}
            // conn.Close();
            // Console.ReadLine();
        }

        //------------------STORED PROCEDURE UPDATE------------------------//

        //public void Updatesp()
        //{
        //    String connString = "Data Source=.;Initial Catalog=TEACHER_STUDENT;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    conn.Open();
        //    cmd.CommandText = " ";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    cmd.CommandText = " ";
        //    //cmd.Parameters.AddWithValue("@T", 8);
          
        //    while (reader.Read())
        //    {
               

        //    }
        //    conn.Close();
        //    Console.ReadLine();
        //}

    }





}






//Course c = new Course();
//c.COURSE_NAME = reader[1].ToString();
//    try
//    {
//        conn.Open();
//        cmd.ExecuteNonQuery();
//    }
//    catch (Exception e)
//    {

//        Console.WriteLine("Error Generated. Details: " + e.ToString());
//    }
//    finally
//    {
//        conn.Close();
//        Console.Read();
//    }
//Console.ReadLine();