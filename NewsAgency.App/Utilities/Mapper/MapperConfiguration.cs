using AutoMapper;
using New.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NewsAgency.App.Models;
using NewsAgency.App.Models.DisplayModels.Articles;
using NewsAgency.App.Models.DisplayModels.Authors;
using NewsAgency.App.Models.DisplayModels.Categories;
using NewsAgency.App.Models.InputModels.Articles;
using NewsAgency.App.Models.InputModels.Categories;

namespace NewsAgency.App.Utilities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleDetailsViewModel>()
                .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes.Count))
                .ReverseMap();

            CreateMap<Article, ArticleAdminViewModel>()
                .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes.Count))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Username))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn.ToString("dd-MM-yyyy")))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src =>
                    src.Content.Substring(0, Math.Min(300, src.Content.Length)) + "..."))
                .ReverseMap();

            CreateMap<Article, EditArticleInputModel>().ReverseMap();

            CreateMap<Article, ArticleDeleteViewModel>().ReverseMap();

            CreateMap<Author, AuthorViewModel>().ReverseMap();

            CreateMap<Article, ArticleHomeViewModel>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ReverseMap();

            CreateMap<Category, CategoryViewModel>()
                .ForMember(dest => dest.NumberOfArticles, opt => opt.MapFrom(src => src.Articles.Count))
                .ReverseMap();

            CreateMap<Category, EditCategoryInputModel>().ReverseMap();

            CreateMap<Category, CategoryDeleteViewModel>().ReverseMap();


            //CreateMap<SupplierDto, Supplier>().ReverseMap();
            //CreateMap<PartDto, Part>().ReverseMap();
            //CreateMap<CarDto, Car>().ReverseMap();
            //CreateMap<CustomerDto, Customer>().ReverseMap();
        }
    }
}