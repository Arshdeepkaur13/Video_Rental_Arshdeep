using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Arshdeep
{
    public class myUnitTest
    {
        public int Additions(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                return -1;
            }
            return num1 + num2;
        }
    }
}
