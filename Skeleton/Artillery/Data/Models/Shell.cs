namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Shell
    {
        [Key]
        public int Id { get; set; }

        [Range(2, 1680), Required]
        public double ShellWeight  { get; set; }

        [MinLength(4), MaxLength(30), Required]
        public string Caliber { get; set; }

        public ICollection<Gun> Guns { get; set;} = new List<Gun>();    
    }
}
