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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindCountryButton_Click(object sender, EventArgs e)
        {
            CountryForm countryForm = new CountryForm();
            countryForm.CountryToFind = CountryTextBox.Text;
            countryForm.Show();
        }

        private void ShowFromDBButton_Click(object sender, EventArgs e)
        {
            CountryData.Rows.Clear();
            using (CountriesDBContext dBContext = new CountriesDBContext())
            {
                foreach(Country country in dBContext.Countries)
                {
                    CountryData.Rows.Add(country.Name,
                                         country.Code.ToString(),
                                         country.City.Name,
                                         country.Area.ToString(),
                                         country.Population.ToString(),
                                         country.Region1.Name);
                }
            }
        }
    }
}
