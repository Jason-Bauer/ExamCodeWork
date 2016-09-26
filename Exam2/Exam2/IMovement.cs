using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2
{
    interface IMovement
    {
        bool Isdone { get; }
        Vector2 getOneStep();
    }
}
