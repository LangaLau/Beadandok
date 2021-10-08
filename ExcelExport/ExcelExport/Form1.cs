using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();      //ORM példányosítása
        List<Flat> lakasok;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.DataSource = lakasok;
        }

        public void LoadData()
        {
            lakasok = context.Flats.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realEstateDataSet.Flat' table. You can move, or remove it, as needed.
            this.flatTableAdapter.Fill(this.realEstateDataSet.Flat);

        }
    }
}
