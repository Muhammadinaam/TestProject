using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [TestFixture]
    class CalculateTest
    {
        [TestCase(1, 2, 3)]
        [TestCase(4, 2, 6)]
        [TestCase(10, 2, 12)]
        public void Sum_ParametersGiven_CheckBehaviour(int a, int b, int expectedResult)
        {
            // Arrange
            var testEntity = new Calculate();

            // Act
            var result = testEntity.Sum(a, b);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
