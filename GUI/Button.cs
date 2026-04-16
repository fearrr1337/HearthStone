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
    public class Button : Label
    {
        public bool Enabled = true;
        public LabelConfig Disabled {  get; set; }
        public LabelConfig Hover { get; set; }
        public LabelConfig Clicked { get; set; }

        public override void Draw(Vector2 offset = new Vector2())
        {
            if (!Enabled)
            {
                DrawConfig(Disabled, offset);
            } else
            {
                if (IsClicked(offset))
                {
                    DrawConfig(Clicked, offset);
                }
                else if (IsHover(offset))
                {
                    DrawConfig(Hover, offset);
                } 
                else
                {
                    DrawConfig(Active, offset);
                }
            }
        }

        public bool IsHover(Vector2 offset = new Vector2())
        {
            return Collision(GetMousePosition(), offset);
        }

        public bool IsClicked(Vector2 offset = new Vector2())
        {
            return IsHover(offset) && IsMouseButtonPressed(MouseButton.Left);
        }

    }
}
