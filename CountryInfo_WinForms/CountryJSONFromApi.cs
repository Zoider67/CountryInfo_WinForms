using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfo_WinForms
{
    class CountryJSONFromApi
    {
        //"https://restcountries.eu/rest/v2/name/"
        public Dictionary<string, object> Json { get; set; }
        public string URL { get; set; }
        public string countryName { get; set; }
        public CountryJSONFromApi(string _URL, string _countryName)
        {
            URL = _URL;
            countryName = _countryName;
        }

        private string GetContentFromApi()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + countryName);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return content;
        }
        public CountryData GetCountryJSON()
        {
            string content = GetContentFromApi();
            var list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(content);
            Json = list.First();
            return new CountryData(Json);

        }

        
    }
}
