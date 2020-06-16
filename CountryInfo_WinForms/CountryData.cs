using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CountryInfo_WinForms
{
    class CountryData
    {
        public Region region { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public CountriesDBContext dBContext { get; set; }

        public CountryData(Dictionary<string, object> json)
        {
            dBContext = new CountriesDBContext();
            region = Region.FromJson(json);
            city = City.FromJson(json);
            country = Country.FromJson(json, city, region);
        }

        public void SaveDataToDB()
        {

            City dbCity = dBContext.Cities.FirstOrDefault(x => x.Name.Equals(city.Name));
            if (dbCity == null)
            {
                dBContext.Cities.Add(city);
                dBContext.SaveChanges();
                country.Capital = city.Id;
            }
            else
            {
                country.CapitalNavigation = dbCity;
            }
            Region dbRegion = dBContext.Regions.FirstOrDefault(x => x.Name.Equals(region.Name));
            if (dbRegion == null)
            {
                dBContext.Regions.Add(region);
                dBContext.SaveChanges();
                country.Region = region.Id;
            }
            else
            {
                country.RegionNavigation = dbRegion;
            }
            Country dbCountry = dBContext.Countries.FirstOrDefault(x => x.Code == country.Code);
            if (dbCountry == null)
            {
                dBContext.Countries.Add(country);
                dBContext.SaveChanges();
            }
            else
            {
                country = dbCountry;
                dBContext.SaveChanges();
            }
        }
    }
}


