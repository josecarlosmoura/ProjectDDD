using AutoMapper;
using DDDApplication.Domain.Entites;
using DDDApplication.MVC.ViewModels;

namespace DDDApplication.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Customer, CustomerViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}