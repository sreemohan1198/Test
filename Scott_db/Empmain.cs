using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Dept;
using static ClassLibrary1.Bonus;
using static ClassLibrary1.State;
using static ClassLibrary1.Address;

namespace ClassLibrary1
{
    internal class EmpMain
    {
        public static void Main(string[] args)
        {


        //-----------READING DATA FROM DEPARTMENT TABLE---------------------//////


            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT [DEPTNO],[DNAME],[LOC] FROM [dbo].[DEPT]";
            // cmd.CommandText = "Select [ENAME],[DNAME] FROM [dbo].[DEPT] as d join [EMP] as e on d.DEPTNO=e.DEPTNO";
            // cmd.CommandText = "Select [ENAME],[JOB],[SAL] from [dbo].[BONUS]";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dept dept = new Dept();
                dept.DEPTNO = reader[0].GetHashCode();
                dept.DNAME = reader[1].ToString();
                dept.LOC = reader[2].ToString();

                string row = reader.GetValue(0) + " - " + reader.GetValue(1);
                Console.WriteLine(row);
            }
            conn.Close();
            Console.Read();




        //---------INSERT VALUES TO BOUNUS TABLE-----------------//


            //public void Insert(Bonus bonus)
            //{
            //    String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            //    SqlConnection conn = new SqlConnection(connString);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandText = @"INSERT INTO[dbo].[BONUS] ([ENAME],[JOB],[SAL],[COMM])
            //                    VALUES(@EName,@JOB,@SAL,@COMM)";
            //    Bonus bonus = new Bonus();

            //    //Pass values to Parameters
            //    //cmd.Parameters.AddWithValue()
            //    cmd.Parameters.AddWithValue("@ENAME", "roy");
            //    cmd.Parameters.AddWithValue("@JOB", "admin");
            //    cmd.Parameters.AddWithValue("@SAL", 40000);
            //    cmd.Parameters.AddWithValue("@COMM", 300);
            //    cmd.Parameters.AddWithValue("@LastModifedDate", "$20");

            //    Exception Handling
            //try
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
            //    Console.Read();

                
         //-----------------UPDATE STATE TABLE---------------------//

                //cmd.CommandText = @"UPDATE [dbo].[STATE]
                //                       SET [STATEID] = @STATEID
                //                          ,[CODE] = @CODE
                //                          ,[STATE_NAME] = @STATE_NAME
                //                     WHERE STATEID=@STATEID"; 

                //State state = new State();

                //cmd.Parameters.AddWithValue("@STATEID", "5");
                //cmd.Parameters.AddWithValue("@CODE", "75036");
                //cmd.Parameters.AddWithValue("@STATE_NAME", "Arizona");

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
                //Console.Read();


        ///-----------------DELETE RECORD IN ADDRESS TABLE------------------///

                cmd.CommandText = @"DELETE FROM [dbo].[ADDRESS] WHERE ADDRESS_ID=@ADDRESS_ID";
            Address address = new Address();

            cmd.Parameters.AddWithValue("@ADDRESS_ID","5");
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

        }
    }
}  