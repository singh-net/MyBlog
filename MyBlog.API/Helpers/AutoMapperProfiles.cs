using System.Linq;
using AutoMapper;
using MyBlog.API.Dtos;
using MyBlog.API.Models;

namespace MyBlog.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, 
                    opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(dest => dest.Age, 
                    opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDetailDto>()
              .ForMember(dest => dest.PhotoUrl, 
                    opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
              .ForMember(dest => dest.Age, 
                    opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotosForDetailDto>(); 

            
            CreateMap<BlogPost, BlogPostsForListDto>();               
            
            CreateMap<Category, CategoriesForListDto>()
                    .ForMember(dest => dest.Id, 
                    opt => opt.MapFrom(src => src.Id)
                    )

                   .ForMember(dest => dest.Name, 
                    opt => opt.MapFrom(src => src.Name)
                    );

            CreateMap<UserForUpdateDto, User>();

                 
                    
        }
    }
}