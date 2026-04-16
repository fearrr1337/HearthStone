using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;

namespace GUI
{
    public class LabelConfig
    {
        public ColorField Background { get; set; }
        public ColorBorder Border { get; set; }
        public Color TextColor { get; set; }
        public bool Wrap { get; set; }
        public float TextMargin { get; set; }
    }
}
