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
            CreateExcel();          //!!!! meghívássss FONTOS
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
                xlApp.UserControl = true;                   //vezérlés felhasználonak
            }
            catch (Exception ex)
            {
                string hiba = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(hiba, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();       //teljesen le kell zárni
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                 "Kód",
                 "Eladó",
                 "Oldal",
                 "Kerület",
                 "Lift",
                 "Szobák száma",
                 "Alapterület (m2)",
                 "Ár (mFt)",
                 "Négyzetméter ár (Ft/m2)"
            };

            for (int i = 0; i < headers.Length; i++)
                xlSheet.Cells[1, i + 1] = headers[i];

            object[,] values = new object[lakasok.Count, headers.Length];

            int counter = 0;
            foreach (var lakas in lakasok)
            {
                values[counter, 0] = lakas.Code;
                counter++;
            }

            var range = xlSheet.get_Range(
                             GetCell(1, 1),
                             GetCell(100, 100));

            range.Value2 = values;       //V2 kell
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }



        private void Form1_Load(object sender, EventArgs e)
        { }
    }
}
