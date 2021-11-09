using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TervezesiMintak.Abstractions;

namespace TervezesiMintak.Entities
{
    public class Ball : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.CornflowerBlue), 0, 0, Width, Height);
        }
        //public virtual void MoveBall()
        //{
        //    Left += 1;
        //}
    }
}
