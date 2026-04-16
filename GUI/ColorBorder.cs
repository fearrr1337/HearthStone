using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Raymath;

namespace GUI
{
    public class ColorBorder : ColorField
    {
        public float Thikness { get; set; } = 1.0f;

        public override void Draw(Vector2 pos, Vector2 size)
        {
            if (Color.A > 0 && Thikness > 0)
            {
                DrawRectangleRoundedLinesEx(
                        new Rectangle(pos, size),
                        Clamp(Radius,0,1),
                        10,
                        Thikness,
                        Color
                );
            }
        }
    }
}
