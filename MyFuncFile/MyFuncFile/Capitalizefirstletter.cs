using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFuncFile
{
    public class Capitalizefirstletter
    {
        public string CapitalizeFirstLetter(string input)
        {
            // Check for empty string
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            // Capitalize the first letter
            char firstChar = char.ToUpper(input[0]);
            string capitalizedString = firstChar + input.Substring(1);

            return capitalizedString;
        }
    }
}
