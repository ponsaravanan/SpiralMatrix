using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpiralMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            var testMatrix = new SpiralMatrix.Matrix();
            var result = testMatrix.Calculate(3);

            Assert.AreEqual(result[0, 0], 1);
            Assert.AreEqual(result[0, 1], 8);
            Assert.AreEqual(result[0, 2], 7);
            Assert.AreEqual(result[1, 0], 2);
            Assert.AreEqual(result[1, 1], 9);
            Assert.AreEqual(result[1, 2], 6);
            Assert.AreEqual(result[2, 0], 3);
            Assert.AreEqual(result[2, 1], 4);
            Assert.AreEqual(result[2, 2], 5);

            
        }
    }
}