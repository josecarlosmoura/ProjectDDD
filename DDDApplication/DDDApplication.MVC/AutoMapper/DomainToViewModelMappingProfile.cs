using AutoMapper;
using DDDApplication.Domain.Entites;
using DDDApplication.MVC.ViewModels;

namespace DDDApplication.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CustomerViewModel, Customer>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
    }
}