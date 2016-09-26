using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2
{
    interface INonPlayerCharacter
    {
        Vector2 Position { get; }
        void addMove(Movement move);
        void Update();


    }
}
