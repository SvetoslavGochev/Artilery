namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MinLength(4),MaxLength(60), Required]
       
        public string CountryName { get; set; }

        [Range(50000, 10000000),Required]
        public int ArmySize { get; set; }

        public ICollection<CountryGun> CountriesGuns { get; set; } = new List<CountryGun>();


    }
}
