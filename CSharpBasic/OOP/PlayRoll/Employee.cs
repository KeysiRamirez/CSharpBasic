using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.OOP.PlayRoll
{
    public abstract class Employee
    {
        #region "Variables"
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string SSN { get; set; }
        #endregion

        #region "Constructor"
        public Employee (string name, string lastname, string ssn)
        {
            Name = name;
            Lastname = lastname;
            SSN = ssn;

        }
        #endregion

        #region "Properties"
        public string FirstName
        {
            get { return Name; }
        
        }

        public string LastName
        {
            get { return Lastname; }
        }

        public string SocialSecurityNumber
        {
            get { return SSN; }
        }

        #endregion

        #region "Overiding the class"
        public override string ToString()
        {
            return string.Format("{0} {1}\n Social Security Number: {2}", FirstName, LastName, SocialSecurityNumber);
        }
        #endregion

        public abstract decimal Incoming();

    }
}
