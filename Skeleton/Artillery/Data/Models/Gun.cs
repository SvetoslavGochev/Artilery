namespace Artillery.Data.Models
{
    using Artillery.Data.Models.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Gun
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Manufacturer)), Required]
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }


        [Range(100, 1350000), Required]
        public int GunWeight { get; set; }

        [Range(2.00, 35.00), Required]
        public double BarrelLength  { get; set; }

        public int NumberBuild   { get; set; }

        public int Range    { get; set; }

        [Required]
        public GunType GunType { get; set; }    
        

        [ForeignKey(nameof(Shell)), Required]
        public Shell Shell { get; set; }
        public int ShellId { get; set; }

        public ICollection CountriesGuns { get; set; } = new List<CountryGun>();

    }
}