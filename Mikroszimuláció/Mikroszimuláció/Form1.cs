using Mikroszimuláció.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroszimuláció
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Person> Population = new List<Person>();
            List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
            List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        }
    }
}
