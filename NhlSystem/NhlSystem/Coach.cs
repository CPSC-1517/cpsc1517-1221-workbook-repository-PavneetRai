using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{

    //define a class name Coach that inherits from the base class PErson 
    public class Coach : Person //<- this is inheritance. coaach will in herit all propteries from person class 
    {
        //Define a auto-implenmented property for HireDate 
        public DateTime HireDate { get; set; }

        //define contructor that passes FullName to the Person base class 

        public Coach(string fullName, DateTime hireDate) : base(fullName)
        {
            HireDate = hireDate;    
        }
    }
}
