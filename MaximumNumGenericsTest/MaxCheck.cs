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
            Maxnumber<int>check = new Maxnumber<int>(300, 200, 220);
            int actualMax = check.Getmax();
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<int> check = new Maxnumber<int>(200, 300, 100);
            int actualMax = check.Getmax(); 
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<int> check = new Maxnumber<int>(100, 200, 300);
            int actualMax = check.Getmax();
            Assert.AreEqual(300, actualMax);
        }
        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<double> check = new Maxnumber<double>(300.33, 200.22, 220.11);
            double actualMax = check.GetmaxFloat();
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<double> check = new Maxnumber<double>(200.22, 300.33, 100.11);
            double actualMax = check.GetmaxFloat();
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<double> check = new Maxnumber<double>(100.11, 200.22, 300.33);
            double actualMax = check.GetmaxFloat();
            Assert.AreEqual(300.33, actualMax);
        }
        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<string> check = new Maxnumber<string>("Apple", "Peach", "Banana");
            string actualMax = check.GetmaxString();
            Assert.AreEqual("Peach", actualMax);
        }
        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<string> check = new Maxnumber<string>( "Peach", "Apple","Banana");
            string actualMax = check.GetmaxString();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            Maxnumber<string> check = new Maxnumber<string>("Banana", "Peach", "Apple");
            string actualMax = check.GetmaxString();
            Assert.AreEqual("Peach", actualMax);
        }
    }
}

    
    