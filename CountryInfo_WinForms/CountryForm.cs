using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            CountryJSONFromApi countryJSON = new CountryJSONFromApi("https://restcountries.eu/rest/v2/name/", countryName);
            countryData = countryJSON.GetCountryJSON();
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
