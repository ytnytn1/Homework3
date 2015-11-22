using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class IntHelper
    {
        public static bool IsEven(this int newNumber)
        {
            if (newNumber % 2 == 0)
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
