namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        [MinLength(4), MaxLength(40),Required]
        public string ManufacturerName  { get; set; }


        [MinLength(10), MaxLength(100), Required]
        public string Founded   { get; set; }
 

        public ICollection<Gun> Guns { get; set; }  = new List<Gun>();


    }
}
