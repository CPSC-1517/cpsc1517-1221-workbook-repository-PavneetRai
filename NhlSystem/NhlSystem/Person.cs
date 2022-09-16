using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
   public class Person
    {
        //define a fulling-implemented property for FullName with a private set
        
        private string _fullName = string.Empty;// <- this  is a feild //define a backing feild for the FullName property

        public string FullName
        {
            get { return _fullName; }
            //get => _fullName;   //< short syntax for above. only used for single use 
            private set 
            {
                //validate new value is not null or empty string or whitespace only 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FullName value is required");

                }
                // validate new value that contains at minimum 3 or more characters 
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("FullName must contain 3 or more characters");

                }
                _fullName = value.Trim();  //Remove leading and trailing whitespaces with .Trim()
            }  
        }
        // creating a greedy contructor with a parameter for the fullname 
        public Person(string fullName)
        {
            FullName = fullName;
        }
       
    }
}
