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
        Random rng = new Random(1234);          // lehet csak pár random számmal tesztelni

        List<Person> Population = null;
        List<BirthProbability> BirthProbabilities = null;
        List<DeathProbability> DeathProbabilities = null;
        public Form1()
        {
            InitializeComponent();
            // bemenet, hol találom a fájlt
            BirthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");
            //Population = GetPopulation(@"C:\Temp\nép-teszt.csv");
        }

        private void StartSimulation(int endYear, string csvPath)
        {
            Population = GetPopulation(csvPath);
            for (int year = 2005; year <= endYear; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                    SimStep(year, Population[i]);

                int nbrOfMales = (from x in Population                  //férfiak száma
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                txtMain.Text += (string.Format(
                    "Szimulációsév:{0}\n\tFiúk:{1}\n\tLányok:{2}\n",
                    year,
                    nbrOfMales,
                    nbrOfFemales));
            }
        }

        private void SimStep(int year, Person person)
        {
            //Ha halott akkor kihagyjuk, ugrunk a ciklus következő lépésére
            if (!person.IsAlive) return;

            // Letároljuk az életkort, hogy ne kelljen mindenhol újraszámolni
            byte age = (byte)(year - person.BirthYear);

            // Halál kezelése
            // Halálozási valószínűség kikeresése
            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();
            // Meghal a személy?
            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;

            //Születés kezelése - csak az élő nők szülnek
            if (person.IsAlive && person.Gender == Gender.Female)
            {
                //Szülési valószínűség kikeresése
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();
                //Születik gyermek?
                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person();
                    újszülött.BirthYear = year;
                    újszülött.NbrOfChildren = 0;
                    újszülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újszülött);
                }
            }
        }

        public List<Person> GetPopulation(string csvPath)
        {            //üres lista, kinyitom ,belepakolom a személyeket
            List<Person> population = new List<Person>();

            using (var sr = new StreamReader(csvPath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');  //!!!fontos különben vételen ciklus
                    //var p = new Person()
                    //{
                    //    BirthYear = int.Parse(line[0]),
                    //    Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                    //    NbrOfChildren = int.Parse(line[2])
                    //};
                    //population.Add(p);
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }
            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvPath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();

            using (var sr = new StreamReader(csvPath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = byte.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }
            return birthProbabilities;
        }

        public List<DeathProbability> GetDeathProbabilities(string csvPath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();

            using (var sr = new StreamReader(csvPath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');

                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = byte.Parse(line[1]),
                        P = double.Parse(line[2])       //vesző pontra kicserélése, de én gépemen nem kellett .Replace(",",".")
                    });
                }
            }
            return deathProbabilities;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            StartSimulation((int)nudYear.Value, txtPath.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK) return;

            txtPath.Text = ofd.FileName;
        }
    }
}
