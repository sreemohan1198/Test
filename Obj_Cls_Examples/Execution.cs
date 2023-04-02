using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj_Cls_Examples
{
    //    internal class Execution
    //    {
    //        String name, city;
    //        int age;
    //        public void acceptdetails()
    //        {
    //            Console.WriteLine("Enter Name :" +name);
    //            Console.ReadLine();

    //            Console.WriteLine("Enter city : "+city);
    //            Console.ReadLine();

    //            Console.WriteLine("Enter age :"+age);
    //            Console.ReadLine();
    //        }

    //    }

    //class Animal //base class or parent class
    //{
    //    public string name;
    //    public void dogName()  //method is created for parent class
    //    {
    //        Console.WriteLine("Golden Retriever!");
    //    }
    //}

    //class Dog : Animal  //derived class or child class
    //{
    //    public void getName()//new method is created to Dog class 
    //    {
    //        Console.WriteLine("This is a Dog :" + name);//inherits name property from parent class
    //    }
    //}

    //public class Student
    //{
    //    public string firstname;
    //    public string secondname;
    //    public int age;
    //    public string course;

    //    public void details()
    //    {
    //        Console.WriteLine("First name :" + firstname);
    //        Console.WriteLine("Second name :" + secondname);
    //        Console.WriteLine("Age:" + age);
    //        Console.WriteLine("Course:" + course);
    //    }
    //}
    //public class Courses : Student
    //{
    //    public void coursedetails()
    //    {
    //        Console.WriteLine("Student courses:" + course);
    //    }
    //}


    //public class Person
    //{
    //    public string Fname { get; set; }
    //    public string Lname { get; set; }
    //    public int Id { get; set; }
    //}

    //public class Employee:Person
    //    {
    //        public string EName { get; set; }
    //        public string Dept { get; set; }
    //        public int Salary { get; set; }
    //    }


    public class Security
    {
        public String Boss="Good Morning Sir...";
        public String Employee="Welcome Sir";
        public String Customer="Id please";

        public virtual void Sguard()
        {
            Console.WriteLine("Hello!!" + Boss);
            Console.WriteLine("Good Morning" + Employee);
            Console.WriteLine("Show Me your" + Customer);
        }
    }
    public class Boss : Security
    {
        public override void Sguard()
        {
            Console.WriteLine("Have a Nice day");
            //Console.WriteLine("Welcome sir!" + Employee);
            //Console.WriteLine("Show Me you ID" + Customer);
        }
    }

    public class Employee : Security
    {
        public override void Sguard()
        {
            //Console.WriteLine("Good Morning ,Sir!!" + Boss);
            Console.WriteLine("Have a Good day");
            //Console.WriteLine("Show Me you ID" + Customer);
        }
    }

    public class Customer : Security
    {
        public override void Sguard()
        {
            //Console.WriteLine("Good Morning ,Sir!!" + Boss);
            //Console.WriteLine("Welcome sir!" + Employee);
            Console.WriteLine("You may go..");
        }
    }

}






