using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LibraryOfUsefulFunctions
{
    class NumericalFunctions
    {
        private int ReverseNumber(int input)
        {
            int result = 0;
            while (input > 0)
            {
                int remainder = input % 10;
                result = (result * 10) + remainder;
                input = input / 10;
            }
            return result;
        }

        private int SumDigits(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                sum += input % 10;
                input = input / 10;
            }
            return sum;
        }

        private BigInteger ReverseNumber(BigInteger input)
        {
            BigInteger result = new BigInteger(0);
            while (input > 0)
            {
                BigInteger remainder;
                BigInteger.DivRem(input, 10, out remainder);
                result = (result * 10) + remainder;
                input = input / 10;
            }
            return result;
        }

        private BigInteger SumDigits(BigInteger input)
        {
            BigInteger sum = new BigInteger(0);
            while (input > 0)
            {
                BigInteger rem;
                BigInteger.DivRem(input, 10, out rem);
                sum += (int)rem;
                input = input / 10;
            }
            return sum;
        }
    }
}
