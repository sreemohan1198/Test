using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using static ClassLibrary1.Employee;

namespace Scott_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String connString = "Data Source=.;Initial Catalog=Scottdb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand("Select STREET from ADDRESS",conn);
            //SqlCommand cmd = new SqlCommand("Select DEPTNo,DNAME,LOC from DEPT", conn);
            //SqlCommand cmd = new SqlCommand("Select ENAME,JOB,SAL,COMM from BONUS", conn);
            SqlCommand cmd = new SqlCommand("Select ENAME,DNAME from DEPT as d join EMP as e on d.DEPTNO=e.DEPTNO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Employee> Addr = new List<Employee>();


            //while (dr.Read())
            //{
            //    Employee details = new Employee();
            //    details.STREET = dr[0].ToString();
            //    Addr.Add(details);
            //}
            //foreach (Employee details in Addr)
            //{
            //    Console.WriteLine(details.STREET);
            //}


            //List<Dept> Dep = new List<Dept>();
            //while (dr.Read())
            //{
            //    Dept d = new Dept();
            //    d.DEPTNO = Convert.ToInt32(dr[0]);
            //    d.DNAME = dr[1].ToString();
            //    d.LOC = dr[2].ToString();
            //    Dep.Add(d);
            //}
            //foreach (Dept d in Dep)
            //{
            //    Console.WriteLine(d.DEPTNO + " - " + d.DNAME + " - " + d.LOC);
            //    //Console.Write(d.DNAME);
            //    //Console.Write(d.LOC);
            //}


            //List<Bonus> Bon = new List<Bonus>();
            //while (dr.Read())
            //{
            //    Bonus b = new Bonus();
            //    b.ENAME =dr[0].ToString();
            //    b.JOB = dr[1].ToString();
            //    b.SAL = Convert.ToInt32(dr[2]);
            //    b.COMM = Convert.ToInt32(dr[3]);
            //    Bon.Add(b);
            //}
            //foreach (Bonus b in Bon)
            //{
            //    Console.WriteLine(b.ENAME + " -" + b.JOB + " - " + b.SAL + " - "+ b.COMM);

            //}

            List<Dept> Dep = new List<Dept>();
            while (dr.Read())
            {
                Dept d = new Dept();
                d.ENAME = dr[0].ToString();
                d.DNAME = dr[1].ToString();
                Dep.Add(d);
            }
            foreach(Dept d in Dep)
            {
                Console.Write(d.ENAME + "-");
                Console.WriteLine(d.DNAME);
            }
            Console.ReadLine();
            conn.Close();
        }
    }
  }

