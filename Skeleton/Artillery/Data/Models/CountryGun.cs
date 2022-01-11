﻿namespace Artillery.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CountryGun
    {
        [ForeignKey(nameof(Country)), Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }


        [ForeignKey(nameof(Gun)), Required]
        public int GunId { get; set; }
        public Gun Gun { get; set; }
    }
}