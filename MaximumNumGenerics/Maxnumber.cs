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
        public T[] value;
        public Maxnumber(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
             Array.Sort(values);
             return values;
        }
         public T Maxnum(T[] values)
         {
              var maxValue = Sort(values);
              return maxValue[^1];    //^1 is the first Index from End, So it gives sorted Max Value from End of Array
         }
          /// <summary>
        /// Maximum Method to Find Maximim Value
        /// </summary>
        public void PrintMax()
        {
            var print = Maxnum(this.value);
            Console.WriteLine("Maximum Value is: " + print);
        }
     }
}

