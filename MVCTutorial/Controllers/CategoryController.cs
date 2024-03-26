using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Data;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers;

public class CategoryController : Controller
{
	private readonly DataContext _context;

	public CategoryController(DataContext context)
	{
		_context = context;
	}

	public IActionResult Index()
	{
		var categories = _context.Categories;
		return View(categories);
	}
	public IActionResult Create() 
	{
		return View();
	}
	[HttpPost]
	public IActionResult Create(Category category) 
	{
		//input the ccategory to database
		_context.Categories.Add(category);
		_context.SaveChanges();
		TempData["success"] = "Category has been added successfully";
		return RedirectToAction("Index");
	}
	
	public IActionResult Update(int? id) 
	{
		if(id is null || id is 0) 
		{
			return RedirectToAction("Index");
		}
		var category = _context.Categories.Find(id);
		if(category is null) 
		{
			TempData["error"] = "Category not found";
			return RedirectToAction("Index");
		}
		return View(category);
	}
	[HttpPost]
	public IActionResult Update(Category category) 
	{
		_context.Categories.Update(category);
		_context.SaveChanges();
		TempData["success"] = "Category has been updated successfully";
		return RedirectToAction("Index");
	}
	public IActionResult Delete(int? id) {
		if(id is null || id is 0) 
		{
			return RedirectToAction("Index");
		}
		var category = _context.Categories.Find(id);
		if(category is null) 
		{
			return RedirectToAction("Index");
		}
		_context.Categories.Remove(category);
		_context.SaveChanges();
		return RedirectToAction("Index");
	}
}
