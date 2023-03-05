using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFuncFile
{
    public class NameCapitalization
    {
        //Data Fields



        //Constructor



        //Functions
        public string CapitalizeNames(string firstName, string LastName)
        {

            // Capitalize first letter of first name
            char firstChar = char.ToUpper(firstName[0]);
            string capitalizedFirstName = firstChar + firstName.Substring(1);

            // Capitalize first letter of last name
            firstChar = char.ToUpper(LastName[0]);
            string capitalizedLastName = firstChar + LastName.Substring(1);

            // Concatenate capitalized first and last names
            string FullName = capitalizedFirstName + " " + capitalizedLastName;

            return FullName;
        }
        
    }
}
