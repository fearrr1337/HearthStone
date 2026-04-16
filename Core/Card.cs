using GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Card
    {
        public Dictionary<string, IntLimit> Attributes { get; set; } = new Dictionary<string, IntLimit>();
        public Dictionary<string, int> Cost { get; set; } = new Dictionary<string, int>();
        public Button Body { get; set; } = new Button();
        public Label Name { get; set; } = new Label();
        public Label Picture { get; set; } = new Label();
        public Label Description { get; set; } = new Label();
        public Dictionary<string, List<Effect>> Effects { get; set; } = new Dictionary<string, List<Effect>>();



    }
}
