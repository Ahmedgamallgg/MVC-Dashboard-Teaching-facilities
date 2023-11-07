using AutoMapper;
using DataAccessLayer.Entities;
using E_Commerce_MVC_Project.Models;

namespace E_Commerce_MVC_Project.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Course, CourseViewModel>();
            CreateMap<CourseViewModel, Course>();
            CreateMap<Trainer, TrainerViewModel>();
            CreateMap<TrainerViewModel, Trainer>();
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();

        }
    }
}
