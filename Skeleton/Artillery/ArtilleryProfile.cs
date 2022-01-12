namespace Artillery
{
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using AutoMapper;
    using System;

    class ArtilleryProfile : Profile
    {
        // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE THIS CLASS
        public ArtilleryProfile()
        {

            this.CreateMap<ImportGunsDto, Gun>()
                .ForMember(x => x.GunType, y => y.MapFrom(x => Enum.Parse(typeof(GunType), x.GunType)));

            // .ForMember(x => x.Genre, y => y.MapFrom(x => Enum.Parse(typeof(Genre), x.Genre)))

            this.CreateMap<ImportCountryDto, Country>();
            this.CreateMap<ImportManufacturersDto, Manufacturer>();
            this.CreateMap<ImportShellDto, Shell>();
        }
    }
}