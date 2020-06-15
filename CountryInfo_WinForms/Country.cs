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

        public virtual City City { get; set; }

        public virtual Region Region1 { get; set; }
    }
}
