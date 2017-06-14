using AutoMapper;

namespace App.Business
{
    public static class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<UserProfile>();
                cfg.AddProfile<AddressProfile>();
            });
        }
    }
}
