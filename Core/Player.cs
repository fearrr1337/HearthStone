using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Player : Card
    {
        public Dictionary<string, IntLimit> Resources = new Dictionary<string, IntLimit>();
        public Creature[] Creatures = new Creature[8];
        public Building[] Buildings = new Building[8];

        public List<Card> Hand = new List<Card>();
        public List<Card> Deck = new List<Card>();
    }
}
