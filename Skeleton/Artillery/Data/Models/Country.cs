namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Country
    {
        
        public int Id { get; set; }

        [MinLength(4),MaxLength(60)]
        [Required]
        public string countryName { get; set; }

        [Required]
        public int armySize { get; set; }

        public ICollection<CountryGun> CountriesGuns { get; set; } = new List<CountryGun>();


    }
}
