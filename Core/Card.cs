using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using static GUI.GUI;

namespace Core
{
    public class Card
    {
        public Dictionary<string, IntLimit> Attributes { get; set; } = new Dictionary<string, IntLimit>();
        public Dictionary<string, int> Cost { get; set; } = new Dictionary<string, int>();
        public Button Body { get; set; } = new Button()
        {
            Size = CardBodySize,
            Active = ActiveCard,
            Hover = HoverCard,
            Disabled = DisabledCard,
        };
        public Label Name { get; set; }
        public Label Picture { get; set; }
        public Label Description { get; set; }
        public Dictionary<string, List<Effect>> Effects { get; set; } = new Dictionary<string, List<Effect>>();

        public virtual void Draw(Vector2 offset = new Vector2())
        {
            Body.Draw(offset);
            Name.Draw(offset);
            Picture.Draw(offset);
            Description.Draw(offset);
        }

        public static Card CardConstructor(string name, string description)
        {
            return new Card
            {
                Name = new GUI.Label
                {
                    Text = name,
                    Active = CardNameActive,
                    Pos = CardNamePos,
                    Size = CardNameSize,
                },
                Picture = new GUI.Label()
                {
                    Active = CardPictureActive,
                    Pos = CardPicturePos,
                    Size = CardPictureSize
                },
                Description = new GUI.Label()
                {
                    Text = description,
                    Active = CardDescriptionActive,
                    Pos = CardDescriptionPos,
                    Size = CardDescriptionSize
                }
            };

        }


    }
}
