using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;
using static Raylib_cs.Raylib;

namespace GUI
{
    public class ColorField : DrawField
    {
        public Color Color { get; set; } = new Color(0, 0, 0, 0);

        public override void Draw(Vector2 pos, Vector2 size)
        {
            if (Color.A > 0)
            {
                DrawRectangleRounded(new Rectangle(pos, size), Radius, 10, Color);
            }
        }
    }
}
