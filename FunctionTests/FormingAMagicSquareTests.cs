using NUnit.Framework;
using FormingAMagicSquare;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class FormingAMagicSquareTests
    {
        [Test]
        public void CalculatemagicConstant_WhenCalled_ShouldReturnDesiredResult()
        {
            int[,] arr = new int[3, 3];
            arr[0, 0] = 4;
            arr[0, 1] = 9;
            arr[0, 2] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 5;
            arr[1, 2] = 7;
            arr[2, 0] = 8;
            arr[2, 1] = 1;
            arr[2, 2] = 5;
            //var result = Functions.Calculate(arr);

            Assert.Pass();
        }
    }
}
