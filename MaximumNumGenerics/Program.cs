using MaximumNumGenerics;
using System;
namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intValues = { 300, 200, 100, 250 };
            Maxnumber<int> maxnumberint = new Maxnumber<int>(intValues);
            maxnumberint.Maxnum(intValues);

            double[] doubleValues = { 300.33, 200.22, 100, 250.55 };
            Maxnumber<double> maxnumberdouble = new Maxnumber<double>(doubleValues);
            maxnumberdouble.Maxnum(doubleValues);

            string[] stringValues = { "Peach", "Apple", "Banana", "Guava" };
            Maxnumber<string> maxnumberstring = new Maxnumber<string>(stringValues) ;
            maxnumberstring.Maxnum(stringValues);
        }
    }
}


