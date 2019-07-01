using AutoMapper;

namespace DDDApplication.MVC.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}