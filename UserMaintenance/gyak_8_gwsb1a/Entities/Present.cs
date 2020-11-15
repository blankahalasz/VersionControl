using gyak_8_gwsb1a.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_8_gwsb1a.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color color_r, Color color_b)
        {
            BoxColor = new SolidBrush(color_b);
            RibbonColor = new SolidBrush(color_r);
        }

       protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
        }
    }
}
