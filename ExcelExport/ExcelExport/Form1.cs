using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

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
           

        }
    }
}
