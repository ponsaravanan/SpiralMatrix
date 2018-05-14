using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralTraverser
    {
        private enum TraverseMode
        {
            GoForthX,
            GoForthY,
            GoReverseX,
            GoReverseY

        }

        private int x;
        private int y;
        private int i;
        private TraverseMode movement;
        private int[,] output;
        public int[,] GetMatrix(int size)
        {
            output = new int[size, size];
            while (i < (size * size))
            {
                i++;
                output[x, y] = i;
                FollowMe(size);
            }
            return output;
        }

        private void FollowMe(int size)
        {
            switch (movement)
            {
                case TraverseMode.GoForthX:
                    if (HitWallX(size)) TakeTurnY(); else x++;
                    break;
                case TraverseMode.GoForthY:
                    if (HitWallY(size)) TakeTurnReverseX(); else y++;
                    break;
                case TraverseMode.GoReverseX:
                    if (HitWallReverseX()) TakeTurnReverseY(); else x--;
                    break;
                case TraverseMode.GoReverseY:
                    if (HitWallReverseY()) TakeTurnX(); else y--;
                    break;
            }

        }

        private bool HitWallReverseY() => y <= 0 || output[x, y - 1] > 0;

        private bool HitWallReverseX() => x <= 0 || output[x - 1, y] > 0;

        private bool HitWallY(int size)=> y >= size - 1 || output[x, y + 1] > 0;
        
        private bool HitWallX(int size) => x >= size - 1 || output[x + 1, y] > 0;        

        private void TakeTurnX()
        {
            movement = TraverseMode.GoForthX;
            x++;
        }

        private void TakeTurnReverseY()
        {
            movement = TraverseMode.GoReverseY;
            y--;
        }

        private void TakeTurnReverseX()
        {
            movement = TraverseMode.GoReverseX;
            x--;
        }

        private void TakeTurnY()
        {
            movement = TraverseMode.GoForthY;
            y++;

        }
    }
}
