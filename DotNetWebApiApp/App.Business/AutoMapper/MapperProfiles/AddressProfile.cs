using AutoMapper;
using App.DomainModels;
using System;

namespace App.Business
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressItem>()
                .ForMember(x => x.AddressLines,
                            m => m.MapFrom(a => string.Join(",", a.Building, a.Street, a.Place)));
            CreateMap<AddressItem, Address>()
                .ForMember(x => x.Building, m => m.MapFrom(a => a.AddressLines.Split(',')[0]))
                .ForMember(x => x.Street, m => m.MapFrom(a => a.AddressLines.Split(',')[1]))
                .ForMember(x => x.Place, m => m.MapFrom(a => a.AddressLines.Split(',')[2]));

        }
    }
}
