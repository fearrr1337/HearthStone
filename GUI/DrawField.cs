using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using Raylib_cs;
using static Raylib_cs.Raylib;



namespace GUI
{
    public abstract class DrawField
    {
        public float Radius { get; set; } = 0;
        public abstract void Draw(Vector2 pos, Vector2 size);
    }
}
