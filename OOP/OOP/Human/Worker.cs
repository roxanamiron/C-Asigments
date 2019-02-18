using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Human
{
    public class Worker : Human
    {
        private double salary = 0;
        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public int HoursWorked { get; set; }
        public Worker(string firstName, string lastName,double workSalary=0,int hourseWorked=0) : base(firstName, lastName)
        {
            this.Salary = workSalary;
            this.HoursWorked = hourseWorked;
        }
        public double SalaryPerHour()
        {
            return this.HoursWorked != 0 ? Math.Round(this.Salary / this.HoursWorked, 2) : 0;
        }
        public override string ToString()
        {
            return string.Format("Worker: {0} {1}, Salary: {2}, Hours per day: {3}, Money per hour: {4}",

            this.FirstName, this.LAstName, this.Salary, this.HoursWorked, this.SalaryPerHour());
        }
    }
}
