namespace CountryInfo_WinForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Code { get; set; }

        public int Capital { get; set; }

        public double Area { get; set; }

        public int Population { get; set; }

        public int Region { get; set; }

        public virtual City CapitalNavigation { get; set; }

        public virtual Region RegionNavigation { get; set; }

        public static Country FromJson(Dictionary<string, object> Json, City city, Region region)
        {
            return new Country
            {
                Name = (string)Json["name"],
                Code = Int32.Parse((string)Json["numericCode"]),
                CapitalNavigation = city,
                Area = float.Parse(((double)Json["area"]).ToString()),
                Population = Convert.ToInt32((Int64)Json["population"]),
                RegionNavigation = region
            };
        }
    }
}
