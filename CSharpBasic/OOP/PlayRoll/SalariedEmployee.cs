using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.PlayRoll
{
    public class SalariedEmployee : Employee
    {
        #region "Atribute"

        private decimal weekSalary;
        #endregion

        #region "Constructor"
        public SalariedEmployee (string name, string lastname, string ssn, decimal salary) : base (name, lastname, ssn)
        {
            WeekSalary = salary;
        }

        #endregion

        #region "Properties"
        public decimal WeekSalary
        {
            get 
            { 
                return weekSalary; 
            }

            set 
            { 
                weekSalary = ((value >= 0) ? value : 0); 
            }
        }
        #endregion

        #region "Get Incoming Method"
        public override decimal Incoming()
        {
            return WeekSalary;
        }

        public override string ToString()
        {
            return string.Format ("Salaried Employee: {0}\n{1}: {2:C}", 
                base.ToString(), "Week Salary", WeekSalary);
        }
        #endregion
    }
}
