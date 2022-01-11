namespace Artillery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Shell
    {
        public int Id { get; set; }

        public double ShellWeight  { get; set; }

        public string Caliber { get; set; }

        public ICollection<Gun> Guns { get; set;}
    }
}
