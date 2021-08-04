using MaximumNumGenerics;
using System;
namespace MaximumValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Maxnumber<int> maxnumberint = new Maxnumber<int>(300,200,1005);
            maxnumberint.Getmax();
            Maxnumber<double> maxnumberdouble = new Maxnumber<double>(300.33,200.22,100);
            maxnumberint.Getmax();
            Maxnumber<string> maxnumberstring = new Maxnumber<string>("Apple", "Peach", "Banana"); ;
            maxnumberint.Getmax();
        }
    }
}

