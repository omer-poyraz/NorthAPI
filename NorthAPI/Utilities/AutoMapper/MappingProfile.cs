using AutoMapper;
using Entities.DataTransferObjects.BasketDto;
using Entities.DataTransferObjects.CategoryDto;
using Entities.DataTransferObjects.FavoriteDto;
using Entities.DataTransferObjects.FilesDto;
using Entities.DataTransferObjects.ProductDto;
using Entities.DataTransferObjects.UserDto;
using Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace NorthAPI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegisterDto, User>();

            CreateMap<CategoryDtoForUpdate, Category>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDtoForInsertion, Category>();

            CreateMap<UserDtoForUpdate, User>().ReverseMap();
            CreateMap<User, UserDto>();
            CreateMap<IdentityResult, UserDto>().ReverseMap();

            CreateMap<FilesDtoForUpdate, Files>().ReverseMap();
            CreateMap<Files, FilesDto>();
            CreateMap<FilesDtoForInsertion, Files>();

            CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDtoForInsertion, Product>();

            CreateMap<Favorite, FavoriteDto>();
            CreateMap<FavoriteDtoForInsertion, Favorite>();

            CreateMap<BasketDtoForUpdate, Basket>().ReverseMap();
            CreateMap<Basket, BasketDto>();
            CreateMap<BasketDtoForInsertion, Basket>();
        }
    }
}
