using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;

using static GUI.GUI;
using GUI;
using System.Numerics;
using Core;


namespace HearthStone
{
    internal class Game
    {

        public static void Start()
        {
            InitWindow(800, 800, "HearthStone");
            SetTargetFPS(60);
        }

        public static void Run()
        {
            GUI.Label l1 = new GUI.Label
            {
                Text = "Label1",
                Pos = new Vector2(20, 20),
                Size = new Vector2(200, 40),
                Active = new LabelConfig
                {
                    Background = new ColorField { Radius = 0, Color = Color.Beige },
                    Border = new ColorBorder { Radius = 0, Color = Color.DarkPurple, Thikness = 6 },
                    TextColor = Color.DarkBlue,
                    Wrap = false,
                    TextMargin = 10
                }
            };

            GUI.Label l2 = new GUI.Label
            {
                Text = "Hello world by by heloo? very important What?",
                Pos = new Vector2(20, 80),
                Size = new Vector2(300, 200),
                Active = new LabelConfig
                {
                    Background = null,
                    Border = new ColorBorder { Radius = 0, Color = Color.DarkPurple, Thikness = 6 },
                    TextColor = Color.DarkBlue,
                    Wrap = true,
                    TextMargin = 10
                }
            };

            GUI.Button b1 = new GUI.Button
            {
                Text = "Hello world",
                Pos = new Vector2(20, 300),
                Size = new Vector2(200, 100),
                Enabled = true,
                Active = new LabelConfig
                {
                    Background = new ColorField { Radius = 0.2f, Color = Color.Beige },
                    Border = new ColorBorder { Radius = 0.2f, Color = Color.DarkPurple, Thikness = 3 },
                    TextColor = Color.DarkBlue,
                    Wrap = false,
                    TextMargin = 19
                },
                Disabled = new LabelConfig
                {
                    Background = new ColorField { Radius = 0.5f, Color = Color.Gray },
                    Border = new ColorBorder { Radius = 0.5f, Color = Color.Black, Thikness = 3 },
                    TextColor = Color.DarkBlue,
                    Wrap = false,
                    TextMargin = 10
                },
                Hover = new LabelConfig
                {
                    Background = new ColorField { Radius = 0.8f, Color = Color.LightGray },
                    Border = new ColorBorder { Radius = 0.8f, Color = Color.DarkPurple, Thikness = 6 },
                    TextColor = Color.DarkBlue,
                    Wrap = false,
                    TextMargin = 18
                },
                Clicked = new LabelConfig
                {
                    Background = new ColorField { Radius = 0.8f, Color = Color.SkyBlue },
                    Border = new ColorBorder { Radius = 0.8f, Color = Color.DarkPurple, Thikness = 6 },
                    TextColor = Color.DarkBlue,
                    Wrap = false,
                    TextMargin = 10
                }
            };

            Card c1 = Card.CardConstructor("Phoenix", "Deathrattle: Resurrects with full health after 2 turns.");
            Card c2 = Card.CardConstructor("Chronogogr", "Battlecry: Rewinds the last action taken this turn.");



            while (!WindowShouldClose())
            {
                BeginDrawing();

                ClearBackground(Color.RayWhite);
                l1.Draw(new Vector2(0, 0));
                l2.Draw(new Vector2(0, 0));
                if (b1.IsClicked())
                {
                    b1.Enabled = !b1.Enabled;
                }
                b1.Draw();
                c1.Draw(new Vector2(400,400));
                c2.Draw(new Vector2(100, 450));
                DrawFPS(0, 0);

                EndDrawing();
            }
        }

        public static void End()
        {
            CloseWindow();
        }

    }
}
