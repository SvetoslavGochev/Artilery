namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Manufacturer
    {

        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(40)]
        public string ManufacturerName  { get; set; }


        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Founded   { get; set; }

        public ICollection<Gun> Guns { get; set; }  = new List<Gun>();


    }
}
