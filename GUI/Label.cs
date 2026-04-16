    using Raylib_cs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Numerics;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    using static GUI.GUI;
    using static Raylib_cs.Raylib;
    using static Raylib_cs.Raymath;
    

    namespace GUI
    {
        public class Label
        {
            public Vector2 Pos { get; set; }
            public Vector2 Size { get; set; }
            public string Text { get; set; } = string.Empty;
            public LabelConfig Active { get; set; }
            
            public virtual void Draw(Vector2 offset = new Vector2())
            {
                DrawConfig(Active, offset);
            }


            public void DrawConfig(LabelConfig config, Vector2 offset)
            {
            if (config != null)
            {


                Vector2 mainPos = Pos + offset;

                config.Border?.Draw(mainPos, Size);
                config.Background?.Draw(mainPos, Size);


                if (!string.IsNullOrEmpty(Text))
                {
                    if (config.Wrap)
                    {
                        string[] words = Text.Split(' ');
                        Vector2 tsize = new Vector2(Size.X - config.TextMargin * 2, Size.Y - config.TextMargin * 2);
                        float x = 0;
                        float y = 0;

                        foreach (var word in words)
                        {
                            Vector2 ts = MeasureTextEx(MainFont, word + " ", FontSize, FontSpacing);
                            float width = ts[0];
                            float height = ts[1];
                            if (x + width > tsize.X)
                            {
                                y += height + 2;
                                x = 0;
                                if (y > tsize.Y)
                                    break;
                            }


                            DrawTextEx(MainFont, word, new Vector2(x + config.TextMargin, y + config.TextMargin) + Pos + offset, FontSize, FontSpacing, config.TextColor);
                            x += width;

                        }
                    }
                    else
                    {
                        Vector2 ts = MeasureTextEx(MainFont, Text, FontSize, FontSpacing);
                        Vector2 tpos = (Size - ts) / 2 + Pos + offset;
                        DrawTextEx(MainFont, Text, tpos, FontSize, FontSpacing, config.TextColor);
                    }
                }

            }
            }

            public bool Collision(Vector2 pos, Vector2 offset = new Vector2())
            {
                return CheckCollisionPointRec(pos, new Rectangle(Pos + offset, Size));
            }
        }
    }
