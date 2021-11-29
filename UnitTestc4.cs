using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNc
{
    public class IsbnValidator
    {
        public bool VISBN10(string isbn)
        {
            int num, digito, suma = 0;
            char last;

            num = isbn.Length;

            if (num != 10)
                return false;

            for (int i = 0; i < 9; i++)
            {
                digito = isbn[i] - '0';
                if (digito < 0 || digito > 9)
                {
                    return false;
                }
                suma += (digito * (10 - i));
            }
            last = isbn[9];
            if (last != 'X' && (last < '0' || last > '9'))
                return false;

            suma += ((last == 'X') ? 10 : (last - '0'));

            return (suma % 11 == 0);
        }
        public bool VISBN13(string isbn)
        {
            int num, digito, suma = 0;
            num = isbn.Length;

            if (num != 13)
                return false;

            for (int i = 0; i < 13; i++)
            {
                digito = isbn[i] - '0';
                if (digito < 0 || digito > 13)
                {
                    return false;
                }
                suma += (digito * (13 - i));
            }
            if (suma % 13 == 0)
            {
                return true;
            }
            return true;
        }
    }
}