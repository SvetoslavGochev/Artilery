
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {





            //var gunsDto = context.Guns.
            //    Where(g => g.Shell.ShellWeight > shellWeight
            //    && g.GunType.ToString() == "AntiAircraftGun")
            //    .OrderByDescending(g => g.GunWeight)
            //    .Select(g => new ExportGunDto
            //    {
            //        GunType = g.GunType.ToString(),
            //        GunWeight = g.GunWeight,
            //        BarelLength = g.BarrelLength,
            //        Range = g.Range
            //    })
            //    .ToList();

            var shellsDto = context.Shels
                .Where(s => s.ShellWeight > shellWeight)
                .OrderBy(s => shellWeight)
                .Select(s => new ExportShellsDto
                {
                    ShellWeight = s.ShellWeight,
                    Caliber = s.Caliber,
                    Guns = context.Guns.
                           Where(g => g.Shell.ShellWeight > shellWeight
                           && g.GunType.ToString() == "AntiAircraftGun")
                          .OrderByDescending(g => g.GunWeight)
                          .Select(g => new ExportGunDto
                          {
                              GunType = g.GunType.ToString(),
                              GunWeight = g.GunWeight,
                              BarelLength = g.BarrelLength,
                              Range = g.Range
                          })
                          .ToList()
                })
                .ToList();







            var json = JsonConvert.SerializeObject(shellsDto, Formatting.Indented);

            return json;


        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {



            throw new NotImplementedException();
        }
    }
}
