using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfUsefulFunctions
{
    class StringFunctions
    {
        public string ReverseString(string input)
        {
            int len = input.Length - 1;
            string result = string.Empty;
            while (len >= 0)
            {
                result = result + input[len];
                len--;
            }
            return result;
        }
    }
}
