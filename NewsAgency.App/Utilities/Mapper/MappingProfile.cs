using AutoMapper;
using New.Models;
using NewsAgency.App.Models.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAgency.App.Utilities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDetailsViewModel>().ReverseMap();

            //CreateMap<SupplierDto, Supplier>().ReverseMap();
            //CreateMap<PartDto, Part>().ReverseMap();
            //CreateMap<CarDto, Car>().ReverseMap();
            //CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}
