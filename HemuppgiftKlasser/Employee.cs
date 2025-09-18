using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftKlasser
{
    internal class Employee
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        //Constructor
        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        //Methods
        public double GetAnnualSalary()
        {
            return Salary * 12;
        }

        public void GiveRaise(double percentage)
        {
            if (percentage > 0)
            {
                Salary += Salary * (percentage/100);
            }
        }
    }
}
