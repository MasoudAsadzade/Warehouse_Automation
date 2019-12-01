using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    class clsUnicodeConvertor
    {
        public string Convert_ArabicCharacters_To_Persian(string str)
        {
            char ch1 = 'ي';
            char ch2 = 'ی';

            str = str.Replace(ch1, ch2);

            return str;
        }
    }
}
