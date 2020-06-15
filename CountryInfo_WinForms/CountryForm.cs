using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryInfo_WinForms
{
    public partial class CountryForm : Form
    {

        public string CountryToFind;
        private CountryDataFromJson countryData;

        public CountryForm()
        {
            InitializeComponent();
        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetCountryDataFromAPI(CountryToFind);
                SetCountryInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }            
        }

        private void GetCountryDataFromAPI(string countryName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://restcountries.eu/rest/v2/name/" + countryName);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Dictionary<string, object> CountryAtrrsDict;
            var json = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(content);
            CountryAtrrsDict = json.First();
            countryData = new CountryDataFromJson(CountryAtrrsDict);

        }

        private void SetCountryInfo()
        {
            NameLabel.Text = countryData.country.Name;
            CodeLabel.Text = countryData.country.Code.ToString();
            CapitalLabel.Text = countryData.city.Name;
            AreaLabel.Text = countryData.country.Area.ToString();
            PopulationLabel.Text = countryData.country.Population.ToString();
            RegionLabel.Text = countryData.region.Name;
            this.Text = "Информация о стране " + NameLabel.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            countryData.SaveDataToDB();
            Close();
        }
    }
}
