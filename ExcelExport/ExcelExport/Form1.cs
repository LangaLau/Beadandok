using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       //Lehet = nevet adni
using System.Reflection;

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();      //ORM példányosítása
        List<Flat> lakasok;
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül


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

        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();            //megnyitjuk az applikációt
                xlWB = xlApp.Workbooks.Add(Missing.Value);  //létrehoz munkafüzet
                xlSheet = xlWB.ActiveSheet;                 //munka lap kiválaszt

                CreateTable();

                xlApp.Visible = true;                       //látvány átadás 
                xlApp.UserControl = true;                      //vezérlés felhasználonak
            }
            catch (Exception ex)
            {
                string hiba = string.Format("Error: {0}\nLine: {1}",ex.Message, ex.Source);
                MessageBox.Show(hiba, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();       //teljesen le kell zárni
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            throw new NotImplementedException();
        }

       // private void

        private void Form1_Load(object sender, EventArgs e)
        { }
    }
}
