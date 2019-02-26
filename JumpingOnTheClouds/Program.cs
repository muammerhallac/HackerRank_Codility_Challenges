using System;
using System.Collections.Generic;
using System.Linq;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            var cloudArray = new int[] { 0, 0, 0, 1, 0, 0 };
            var jumpableClouds = Functions.CalculateJumpableClouds(cloudArray);
        }
    }
}
