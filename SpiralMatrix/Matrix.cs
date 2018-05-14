using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    public class Matrix
    {
        public int[,] Calculate(int size)
        {
            var spiral = new SpiralTraverser();
            return spiral.GetMatrix(size);

        }
    }
}
