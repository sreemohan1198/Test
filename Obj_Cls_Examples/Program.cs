using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Obj_Cls_Examples.Student;

namespace Obj_Cls_Examples
{
    internal class Program
    {
        //    static void Main(string[] args)
        //    {
        //        Execution p=new Execution();
        //        p.acceptdetails();            
        //        Console.ReadLine();
        //    }
        //}

        //    {
        //        //example prog for inheritance
        //        static void Main(string[] args)
        //        {
        //            Dog pug = new Dog();//create a obj named pug to Dog class 
        //            pug.name = "Marley";//assign vale to name property which is in parent class
        //            pug.dogName();//calling a created obj with method defined in parent class


        //            pug.getName();//accessing method from own class
        //            Console.ReadLine();
        //        }

        //    }
        //}
        //{
        //static void Main(string[] args)
        //{
        //    Student std = new Student();
        //    std.firstname = "Sri";
        //    std.secondname = "devi";
        //    std.age = 20;
        //    std.course = "CSE";
        //    std.details();

        //    Courses cd = new Courses();
        //    cd.coursedetails();
        //    Console.ReadLine();

        //}

        //}



        //static void Main(string[] args)
        //{

        //    Person p1 = new Person();
        //    p1.Fname = "sri";
        //    p1.Lname = "lakshmi";
        //    p1.Id = 1;


        //    Employee emp = new Employee();
        //    emp.Fname = "Sree";
        //    emp.Lname = "Mohan";
        //    emp.Id = 10;
        //    emp.Dept = "Developer";
        //    emp.Salary = 50000;

        //    Console.Read();

        //}




        public static void Main(string[] args)
        {

            Security[] sgreet = new Security[4];
            sgreet[0] = new Security();
            sgreet[1] = new Boss();
            sgreet[2] = new Employee();
            sgreet[3] = new Customer();

            //Security sgreet = new Security();
            //sgreet.Boss=Sguard();
            ////Boss sb = new Boss();
            //sgreet.Sguard();
            //sb.Sguard();
            //sgreet.Employee = new Employee();
            // sgreet.Customer = new Customer();


            foreach (Security s in sgreet)
            {
                sgreet.Sguard();
            }
            Console.Read();
        }

    }
}


