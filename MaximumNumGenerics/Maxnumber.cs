using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumGenerics
{
    public class Maxnumber
    {
        public int GetmaxInt(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            throw new Exception("3 values are Equal");
        }
        public double GetmaxFloat(double num1, double num2, double num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            throw new Exception("3 values are Equal");
        }

    }
}
