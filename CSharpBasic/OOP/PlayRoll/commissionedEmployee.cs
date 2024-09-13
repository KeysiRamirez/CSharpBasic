using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.PlayRoll
{
    public class commissionedEmployee : Employee
    {
        #region "Atributes"
        private decimal grossSales;
        private decimal commissionedAmount;
        #endregion

        #region "Constructors"
        public commissionedEmployee(string name, string lastname, string ssn, decimal sales, decimal amount) : base (name, lastname, ssn)
        {
            GrossSales = sales;
            CommissionedAmount = amount;
        }
        #endregion

        #region "Properties"
        public decimal CommissionedAmount
        {
            get 
            {
                return commissionedAmount;
            }

            set
            { 
                commissionedAmount = (value > 0 && value < 1) ? value : 0;
            }
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }

            set
            {
                grossSales = (value >= 0) ? value : 0;
            }
            
        }

        #endregion

        #region "Getting the Incoming Method"
        public override decimal Incoming()
        {
            return commissionedAmount * grossSales;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}",
             "Employee per Commission", base.ToString(), "Gross Sales", GrossSales, "Commissioned Amount", commissionedAmount);
        }
        #endregion
    }
}
