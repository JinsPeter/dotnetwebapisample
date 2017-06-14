using App.DomainModels;
using AutoMapper;

namespace App.Business
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDetail, UserDetailItem>();    
        }
    }
}
