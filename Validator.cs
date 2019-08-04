using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Validator
    {
        public static bool IsValidInt(string input)
        {
          
            bool isValid = int.TryParse(input, out int result);

            if (isValid == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
