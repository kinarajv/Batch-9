using AutoMapper;
using WebAPITutorial.Model.DTOs;
using WebAPITutorial.Model;
namespace WebAPITutorial.Map;

public class MyMapper : Profile
{
	public MyMapper()
	{
		//CreteMap<Destination, Source>
		CreateMap<CategoryDTO, Category>().ReverseMap();
		//CreateMap<Category, CategoryDTO>()
		//CreateMap<CategoryDTO, Category>()
	}
}
