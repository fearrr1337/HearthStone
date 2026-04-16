using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;

namespace GUI
{
    public static class GUI
    {
        public static Font MainFont = GetFontDefault();
        public static int FontSize = 20;
        public static int FontSpacing = 2;

        public static LabelConfig ActiveCard = new LabelConfig
        {
            Background = new ColorField { Radius = 0.2f, Color = new Color(245, 179, 66) },
            Border = new ColorBorder { Radius = 0.2f, Color = new Color(5, 72, 255), Thikness = 3 },
            TextColor = Color.Black,
        };


        // CARD BODY
        public static Vector2 CardBodySize = new Vector2(200, 300);
        public static LabelConfig HoverCard = ActiveCard;
        public static LabelConfig DisabledCard = ActiveCard;


        // CARD PICTURE
        public static LabelConfig CardPictureActive = new LabelConfig
        {
            Background = new ColorField { Radius = 0.2f, Color = new Color(245, 179, 66) },
            Border = new ColorBorder { Radius = 0.2f, Color = new Color(5, 72, 255), Thikness = 3 },
        };
        public static Vector2 CardPicturePos = new Vector2(0, 0);
        public static Vector2 CardPictureSize = new Vector2(200, 140);



        // CARD NAME
        public static LabelConfig CardNameActive = new LabelConfig {
            Background = new ColorField { Radius = 0.2f, Color = new Color(245, 179, 66) },
            Border = new ColorBorder { Radius = 0.2f, Color = new Color(5, 72, 255), Thikness = 3 },
            TextColor = Color.Black,
            Wrap = false,
        };
        public static Vector2 CardNamePos = new Vector2(0, 144);
        public static Vector2 CardNameSize = new Vector2(200, 42);


        // CARD DESCRIPTION
        public static LabelConfig CardDescriptionActive = new LabelConfig
        {
            Background = new ColorField { Radius = 0.2f, Color = new Color(245, 179, 66) },
            Border = new ColorBorder { Radius = 0.2f, Color = new Color(5, 72, 255), Thikness = 3 },
            TextColor = Color.Black,
            Wrap = true,
            TextMargin = 5,
        };
        public static Vector2 CardDescriptionPos = new Vector2(0, 190);
        public static Vector2 CardDescriptionSize = new Vector2(200, 110);

    }
}
