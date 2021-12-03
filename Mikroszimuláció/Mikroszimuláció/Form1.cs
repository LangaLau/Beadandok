using Mikroszimuláció.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroszimuláció
{
    public partial class Form1 : Form
    {
        List<Person> Population = null;
        List<BirthProbability> BirthProbabilities = null;
        List<DeathProbability> DeathProbabilities = null;
        public Form1()
        {
            InitializeComponent();
            Population = GetPopulation(@"C:\Temp\nép-teszt.csv"); // bemenet, hol találom a fájlt
        }

        public List<Person> GetPopulation(string csvPath)
        {            //üres lista, kinyitom ,belepakolom a személyeket
            List<Person> population = new List<Person>();

            using (var sr = new StreamReader(csvPath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');  //!!!fontos különben vételen ciklus
                    var p = new Person();
                    p.BirthYear = int.Parse(line[0]);
                    p.Gender =(Gender)Enum.Parse(typeof(Gender),line[1]);
                    p.NbrOfChildren = int.Parse(line[2]);
                    population.Add(p);
                }
            }

            return population;
        }
    }
}
