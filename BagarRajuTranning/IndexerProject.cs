using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagarRajuTranning
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;

        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return Eno;
                else if (index == 2)
                    return Ename;
                else if (index == 3)
                    return Job;
                else if (index == 4)
                    return Salary;
                else if (index == 5)
                    return Dname;
                else if (index == 6)
                    return Location;
                return null;
            }

            set
            {
                if (index == 1)
                    Eno = (int)value;
                else if (index == 2)
                    Ename = (string)value;
                else if (index == 3)
                    Job = (string)value;
                else if (index == 4)
                    Salary = (double)value;
                else if (index == 5)
                    Dname = (string)value;
                else if (index == 6)
                    Location = (string)value;
            }
        }

        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return Eno;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                return null;
            }

            set
            {
                if (name.ToUpper() == "ENO")
                    Eno = (int)value;
                else if (name.ToUpper() == "ENAME")
                    Ename = (string)value;
                else if (name.ToUpper() == "JOB")
                    Job = (string)value;
                else if (name.ToUpper() == "SALARY")
                    Salary = (double)value;
                else if (name.ToUpper() == "DNAME")
                    Dname = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    Location = (string)value;
            }
        }
    }
}
