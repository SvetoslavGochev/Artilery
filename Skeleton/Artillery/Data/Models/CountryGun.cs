namespace Artillery.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CountryGun
    {
        [ForeignKey(nameof(Country)), Required]
        public Country Country { get; set; }
        public int CountryId { get; set; }


        [ForeignKey(nameof(Gun)), Required]
        public Gun Gun { get; set; }
        public int GunId { get; set; }
    }
}