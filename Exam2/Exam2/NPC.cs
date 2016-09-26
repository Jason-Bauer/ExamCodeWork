using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Threading;


namespace Exam2
{
    class NPC : INonPlayerCharacter
    {
       public  Vector2 currentPosition;
        Queue<Movement> thequeue = new Queue<Movement>();
        //gets position
        public Vector2 Position
        {
            get
            {
                return currentPosition;
            }
        }
        //adds new movement
        public void addMove(Movement move)
        {
            thequeue.Enqueue(move);
        }

        public void Update()
        {
            Movement hold;
            if (thequeue.Count == 0) { }
            else
            {
                //looks at the movement
             hold = thequeue.Peek();
               
                //updates movement
                    Vector2 toadd = hold.getOneStep();
                    currentPosition+= toadd;
                //checks if movement is done
                if (hold.Isdone)
                {
                    thequeue.Dequeue();
                }
                //this is just a personal thing to slow the program down a bit
                  Thread.Sleep(10);
            }
           
               
        }
        //constructor
        public NPC(Vector2 position)
        {
            currentPosition = position;
        }
    }
}
