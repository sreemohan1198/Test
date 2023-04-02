using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Employee
    {
        //all primary keys are declared here so that we can inherit this class acc to tables
        public int ADDRESS_ID { get; set; }
        public int DEPTNO { get; set; }
        public int STATEID { get; set; }
        public string ENAME { get; set; }


        public class Address
        {
            //public int ADDRESS_ID { get; set; }
            public string STREET { get; set; }
            public string CITY { get; set; }
            public int STATEID { get; set; }
            public string ZIPCODE { get; set; }
            public int EMPNO { get; set; }
        }


        public class Bonus
        {
            //public string ENAME { get; set; }
            public String JOB { get; set; }
            public int SAL { get; set; }
            public int COMM { get; set; }
        }


        public class Dept:Employee
        {
            //public int DEPTNO { get; set; }
            public String DNAME { get; set; }
            public String LOC { get; set; }
        }

        public class Salgrade
        {
            public int GRADE { get; set; }
            public int LOSAL { get; set; }
            public int HISAL { get; set; }
        }

        public class State:Employee
        {
            //public int STATEID { get; set; }
            public String CODE { get; set; }
            public String STATE_NAME { get; set; }
        }

    }

}