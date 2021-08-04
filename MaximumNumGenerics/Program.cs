using MaximumNumGenerics;
using System;
namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Maxnumber maxnumber = new Maxnumber();
            maxnumber.GetmaxInt(300, 200, 100);
            maxnumber.GetmaxFloat(300.33, 200.22, 100.11);
            maxnumber.GetmaxString("Apple","Peach","Banana");
        }
    }
}

