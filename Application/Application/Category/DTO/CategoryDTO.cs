using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application.Category.DTO;

public class CategoryDTO
{
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public List<CategoryDTO>? children { get; set; }
}
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Domain.Entities.Category, CategoryDTO>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.CategoryDescription, opt => opt.MapFrom(src => src.CategoryDescription))
            .ForMember(dest=>dest.children,otp=>otp.MapFrom(src=>src.ChildrenCategories !=null ? src.ChildrenCategories.OrderBy(x => x.NumOrder):null));
            ;
        CreateMap<CategoryDTO, Domain.Entities.Category>();
    }
}
