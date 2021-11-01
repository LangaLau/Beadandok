using MNBSoap.Entities;
using MNBSoap.MNBServiceReference;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace MNBSoap
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            string xmlstring = Consume();
            LoadXml(xmlstring);
            dataGridView1.DataSource = Rates;
            Charting();
        }

        private void Charting()
        {
            chartRateData.DataSource = Rates;
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";       //x tengely dátumok
            series.YValueMembers = "Value";     //y tengely értékek
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];       //NO jelmagyarázat
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;      //grid vonalaktol megszabadul
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;      //nem 0val kezdőfik
        }

        private void LoadXml(string input)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(input);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData r = new RateData();
                r.Date = DateTime.Parse(item.GetAttribute("date"));
                XmlElement child = (XmlElement)item.FirstChild;
                r.Currency = child.GetAttribute("curr");
                r.Value = decimal.Parse(child.InnerText);
                int unit = int.Parse(child.GetAttribute("unit"));
                if (unit != 0)
                    r.Value = r.Value / unit;
                Rates.Add(r);
            }
        }

        string Consume()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";
            // Ebben az esetben a "var" a GetExchangeRates visszatérési értékéből kapja a típusát.
            // Ezért a response változó valójában GetExchangeRatesResponseBody típusú.
            var response = mnbService.GetExchangeRates(request);

            // Ebben az esetben a "var" a GetExchangeRatesResult property alapján kapja a típusát.
            // Ezért a result változó valójában string típusú.
            string result = response.GetExchangeRatesResult;
            //File.WriteAllText("export.xml", result);
            return result;
        }
    }
}
