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
        BindingList<string> currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();

            cbxValuta.DataSource = currencies;
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            string result = response.GetCurrenciesResult;
            XmlDocument vxml = new XmlDocument();
            vxml.LoadXml(result);
            foreach (XmlElement item in vxml.DocumentElement.FirstChild.ChildNodes)
            {
                currencies.Add(item.InnerText);
            }

            RefreshData();
        }

        private void RefreshData()
        {
            if (cbxValuta.SelectedItem == null) return;
            Rates.Clear();
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
                if (child == null) continue;    
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
            request.currencyNames = cbxValuta.SelectedItem.ToString();          //"EUR"
            request.startDate = TolPicker.Value.ToString("yyyy-MM-dd");          //"2020-01-01"
            request.endDate = IgPicker.Value.ToString("yyyy-MM-dd");            //"2020-06-30"
            // Ebben az esetben a "var" a GetExchangeRates visszatérési értékéből kapja a típusát.  Ezért a response változó valójában GetExchangeRatesResponseBody típusú.
            var response = mnbService.GetExchangeRates(request);
            // Ebben az esetben a "var" a GetExchangeRatesResult property alapján kapja a típusát. Ezért a result változó valójában string típusú.
            string result = response.GetExchangeRatesResult;
            return result;
        }

        private void filterChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
