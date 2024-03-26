using System.Net.NetworkInformation;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Data;
using WebAPITutorial.Model;
using WebAPITutorial.Model.DTOs;
using WebAPITutorial.Repositories;

namespace WebAPITutorial.Controllers;

public class CategoryController : APIBaseController
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly IMapper _mapper;
	public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
	{
		_mapper = mapper;
		_categoryRepository = categoryRepository;
	}

	[HttpGet]
	public IActionResult GetAllCategory()
	{
		//DTO (Data Transfer Object)
		List<Category> categories = _categoryRepository.GetAll().ToList();
		// List<CategoryDTO> categoriesRespond = new();
		// foreach(var category in categories)
		// {
		// 	categoriesRespond.Add(new CategoryDTO
		// 	{
		// 		CategoryName = category.CategoryName,
		// 		Description = category.Description
		// 	});
		// }
		List<CategoryDTO> categoriesRespond = _mapper.Map<List<CategoryDTO>>(categories);
		return Ok(categoriesRespond);
	}
	[HttpGet("{id}")]
	public IActionResult GetCategory(int id)
	{
		var category = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();
		if (category == null)
		{
			return NotFound();
		}
		return Ok(category);
	}
	[HttpPost]
	public IActionResult AddCategory([FromBody]CategoryDTO? categoryRequest) 
	{
		if(categoryRequest is null) 
		{
			return NotFound();
		}
		Category category = _mapper.Map<Category>(categoryRequest);
		_categoryRepository.Add(category);
		_categoryRepository.Save();
		return Ok(category);
	}
	[HttpPut]
	[Route("{id}")]
	public IActionResult UpdateCategory([FromRoute]int id, [FromBody]CategoryDTO category) 
	{
		if(category is null) 
		{
			return NotFound("Category not found!");
		}
		var existingCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();
		if(existingCategory is null) 
		{
			return NotFound(
				$"Category with id {id} not found!"
			);
		}
		if(category.CategoryName != null)
		{
			existingCategory.CategoryName = category.CategoryName;
		}
		if(category.Description != null)
		{
			existingCategory.Description = category.Description;
		}
		_categoryRepository.Save();
		return Ok(existingCategory);
	}
}
