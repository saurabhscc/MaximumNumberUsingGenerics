using MaximumNumGenerics;
using NUnit.Framework;
using System;

namespace MaximumNumGenericsTest
{
    public class MaxCheck
    {
        Maxnumber check = new Maxnumber();
        //Assign
        //Act
        //Assert

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.GetmaxInt(300, 200, 220);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.GetmaxInt(200, 300, 100);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxIntegerNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.GetmaxInt(100, 200, 300);
            Assert.AreEqual(300, actualMax);
        }
        /// <summary>
        /// TestCase 2.1
        /// </summary>
        [Test]
        public void GivenMaxFloatNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double actualMax = check.GetmaxFloat(300.33, 200.22, 220.11);
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.2
        /// </summary>
        [Test]
        public void GivenMaxFloatNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double actualMax = check.GetmaxFloat(200.22, 300.33, 100.11);
            Assert.AreEqual(300.33, actualMax);
        }

        /// <summary>
        /// TestCase 2.3
        /// </summary>
        [Test]
        public void GivenMaxFloatNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            double actualMax = check.GetmaxFloat(100.11, 200.22, 300.33);
            Assert.AreEqual(300.33, actualMax);
        }
        /// <summary>
        /// TestCase 3.1
        /// </summary>
        [Test]
        public void GivenMaxStringFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string actualMax = check.GetmaxString("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.2
        /// </summary>
        [Test]
        public void GivenMaxStringSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string actualMax = check.GetmaxString("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// TestCase 3.3
        /// </summary>
        [Test]
        public void GivenMaxStringThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            string actualMax = check.GetmaxString("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", actualMax);
        }
    }
}

    
    