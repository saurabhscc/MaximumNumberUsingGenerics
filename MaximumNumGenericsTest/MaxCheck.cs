using MaximumNumGenerics;
using NUnit.Framework;
using System;

namespace MaximumNumGenericsTest
{
    public class Tests
    {
        Maxnumber check = new Maxnumber();
        //Assign
        //Act
        //Assert

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void GivenMaxNumFirstPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.Getmax(300, 200, 220);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void GivenMaxNumSecondPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.Getmax(200, 300, 100);
            Assert.AreEqual(300, actualMax);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void GivenMaxNumThirdPosition_WhenGetMaxNum_ShouldReturnsMaxFirst()
        {
            int actualMax = check.Getmax(100, 200, 300);
            Assert.AreEqual(300, actualMax);
        }
    }
}

    
    