using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    
    public class Uni
    {
        //primary key 
        public int TEACHER_ID { get; set; }
        public int STUDENT_ID { get; set; }
        public int COURSE_ID { get; set; }
    }
        public class Teacher : Uni
        {
            //public int TEACHER_ID { get; set; }
            public String TEACHER_NAME { get; set; }
            public int AGE { get; set; }
        }

        public class Student : Teacher
        {
            //public int STUDENT_ID { get; set; }
            public String STUDENT_NAME { get; set; }
            public int MARKS { get; set; }

        }

        public class Course : Uni
        {
            //public int COURSE_ID { get; set; }
            public String COURSE_CODE { get; set; }
            public string COURSE_NAME { get; set; }
        }

        public class Studentcourse : Uni
        {
            // public int STUDENT_ID { get; set; }
            //public int COURSE_ID { get; set; }
        }

        public class Teachercourse : Uni
        {
            //public int TEACHER_ID { get; set; }
            //public int COURSE_ID { get; set; }
        }
    }


