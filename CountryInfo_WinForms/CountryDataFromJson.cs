using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CountryInfo_WinForms
{
    class CountryDataFromJson
    {
        public Region region { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public CountriesDBContext dBContext { get; set; }

        public CountryDataFromJson(Dictionary<string, object> json)
        {
            dBContext = new CountriesDBContext();
            region = new Region { Name = (string)json["region"] };
            city = new City { Name = (string)json["capital"] };
            country = new Country
            {
                Name = (string)json["name"],
                Code = Int32.Parse((string)json["numericCode"]),
                City = city,
                Area = float.Parse(((double)json["area"]).ToString()),
                Population = Convert.ToInt32((Int64)json["population"]),
                Region1 = region
            };

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
                country.City = dbCity;
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
                country.Region1 = dbRegion;
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


