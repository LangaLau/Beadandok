using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TervezesiMintak.Entities
{
    class Ball : Label
    {
        public int méret = 50;

        public Ball()
        {
            AutoSize = false;
            Width = méret;
            Height = méret;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.AliceBlue), 0, 0, Width, Height);
        }
        
    }
}
