using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TervezesiMintak.Entities;

namespace TervezesiMintak
{
    public partial class Form1 : Form
    {
        private List<Ball> _balls = new List<Ball>();


        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {

        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
