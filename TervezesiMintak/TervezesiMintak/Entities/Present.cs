using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TervezesiMintak.Abstractions;

namespace TervezesiMintak.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get;private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color boxColor, Color ribbonColor)
        {

        }

        protected override void DrawImage(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
