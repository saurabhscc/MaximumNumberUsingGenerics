using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumGenerics
{
    public class Maxnumber<T> where T : IComparable
    {
        /// <summary>
        /// Generic Class for finding Maximum value Int Or Float Or String (With Constructor)
        /// </summary>
        public T num1, num2, num3;
        public Maxnumber(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2; 
            this.num3 = num3;
        }
        public T Getmax()
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            throw new Exception("3 values are Equal");
        }
        public T GetmaxFloat()
        {
          if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
                return num3;
            throw new Exception("3 values are Equal");
        }
        public T GetmaxString()
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3)>= 0)
                return num1;
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
                return num2;
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0  || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
                return num3;
            throw new Exception("3 values are Equal");
        }
    }
}
