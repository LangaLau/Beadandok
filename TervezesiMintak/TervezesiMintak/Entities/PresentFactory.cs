using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TervezesiMintak.Abstractions;

namespace TervezesiMintak.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color BoxColor { get; set; }
        public Color RibbonColor { get; set; }

        public Toy CreateNew()
        {
            return new Present(BoxColor, RibbonColor);
        }
    }
}
