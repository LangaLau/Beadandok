using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TervezesiMintak.Abstractions;
using TervezesiMintak.Entities;

namespace TervezesiMintak
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();

        private BallFactory _IToyFactory;
        public BallFactory IToyFactory
        {
            get { return _IToyFactory; }
            set { _IToyFactory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            IToyFactory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = IToyFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }
    }
}
