
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            var shellsId = context.Shels
                .Where(x => x.ShellWeight > shellWeight )
                .Select(x => x.Id)
                .ToList();


            var guns = context.Guns.ToList();

            foreach (var shellId in shellsId)
            {

                guns.Where(x => x.Id == shellId)
                    .Select(new )
            }




            foreach (var shell in shellsId)
            {
                if (true)
                {

                }
            }




            return null;
        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            throw new NotImplementedException();
        }
    }
}
