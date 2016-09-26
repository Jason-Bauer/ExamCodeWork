using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Exam2
{
    
    class Movement : IMovement
    {
        int X;
        int Y;
        int duration;
        bool isDone;

        //checks if movement is done
        public bool Isdone
        {
            get
            {
                if (duration <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //lowers duration and returns a new vecotr 
        public Vector2 getOneStep()
        {
            duration -= 1;
            return new Vector2(X, Y);
        }

        //constructor
        public Movement(int x, int y, int D)
        {
            X = x;
            Y = y;
            duration = D;
        }
    }
}
