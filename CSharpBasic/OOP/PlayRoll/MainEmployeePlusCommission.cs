using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.PlayRoll
{
    public class MainEmployeePlusCommission : commissionedEmployee
    {
        #region "Atributes"
        private decimal baseSalary;
        #endregion

        #region "Constructors"
        public MainEmployeePlusCommission(string name, string lastname, string ssn, decimal sales, decimal amount, decimal salary) : base (name, lastname, ssn, sales, amount)
        {
            BaseSalary = salary;
        }
        #endregion

        #region "Properties"

        public decimal BaseSalary 
        { 
            get 
            { 
                return baseSalary; 
            }
            
            set 
            {
                baseSalary = (value >= 0) ? value : 0; 
            }
        }

        #endregion

        #region "Getting Incoming Method"
        public override decimal Incoming()
        {
            return BaseSalary + base.Incoming();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}; {2}: {3:C}", 
              "Base salary +",  base.ToString(), "Base Salary", BaseSalary);
        }
        #endregion
    }
}
