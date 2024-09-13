using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.PlayRoll
{
    public class EmployeePerHour : Employee
    {
        #region "Atributes"
        private decimal salary;
        private decimal hours;
        #endregion

        #region "Constructor"
        public EmployeePerHour(string name, string lastname, string ssn, decimal salaryPerHour, decimal workedHours) : base (name, lastname, ssn) 
        {
            Salary = salaryPerHour;
            Hours = workedHours;

        }
        #endregion

        #region "Properties"
        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = ((value >= 0) ? value : 0);
            }
        }

        public decimal Hours
        {
            get 
            {
                return hours;
            }

            set 
            {
                hours = ((value >= 0) && (value <=168)) ? value : 0;
            }
        }
        #endregion

        #region "Getting Incoming Method"
        public override decimal Incoming()
        {
            if (Hours <= 40)
            {
                return Salary * Hours;
            }

            else 
            { 
                return (40 * Salary) + ((Hours - 40) * Salary * 1.5m);
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Employee per hour: {0}\n{1}: {2:C}; {3}: {4:F2}",
                base.ToString(), "Salary per hour", Salary, "Work hours", Hours);
        }

        #endregion
    }
}
