using MaximumNumGenerics;
using NUnit.Framework;
using System;

namespace MaximumNumGenericsTest
{
    public class MaxCheck
    {
       
        //Assign
        //Act
        //Assert

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int[] intValues = { 300, 200, 100, 250 };
            Maxnumber<int> maxnumberint = new Maxnumber<int>(intValues);
            int actualMax= maxnumberint.Maxnum(intValues);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int[] intValues = { 300, 200, 100, 250 };
            Maxnumber<int> maxnumberint = new Maxnumber<int>(intValues);
            int actualMax = maxnumberint.Maxnum(intValues);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
           int[] intValues = { 300, 200, 100, 250 };
            Maxnumber<int> maxnumberint = new Maxnumber<int>(intValues);
            int actualMax= maxnumberint.Maxnum(intValues);
            Assert.AreEqual(300, actualMax);
        }
        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double[] doubleValues = { 300.33, 200.22, 100, 250.55 };
            Maxnumber<double> maxnumberdouble = new Maxnumber<double>(doubleValues);
            double actualMax=maxnumberdouble.Maxnum(doubleValues);
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double[] doubleValues = { 300.33, 200.22, 100, 250.55 };
            Maxnumber<double> maxnumberdouble = new Maxnumber<double>(doubleValues);
            double actualMax = maxnumberdouble.Maxnum(doubleValues);
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double[] doubleValues = { 300.33, 200.22, 100, 250.55 };
            Maxnumber<double> maxnumberdouble = new Maxnumber<double>(doubleValues);
            double actualMax = maxnumberdouble.Maxnum(doubleValues);
            Assert.AreEqual(300.33, actualMax);
        }
        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string[] stringValues = { "Peach", "Apple", "Banana", "Guava" };
            Maxnumber<string> maxnumberstring = new Maxnumber<string>(stringValues);
            string actualMax=maxnumberstring.Maxnum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }
        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string[] stringValues = { "Peach", "Apple", "Banana", "Guava" };
            Maxnumber<string> maxnumberstring = new Maxnumber<string>(stringValues);
            string actualMax = maxnumberstring.Maxnum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string[] stringValues = { "Peach", "Apple", "Banana", "Guava" };
            Maxnumber<string> maxnumberstring = new Maxnumber<string>(stringValues);
            string actualMax = maxnumberstring.Maxnum(stringValues);
            Assert.AreEqual("Peach", actualMax);
        }
    }
}

    
    