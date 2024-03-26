using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITutorial.Controllers;

public class CategoryController : APIBaseController
{
	[HttpGet]
	public IActionResult Get()
	{
		return Ok("Get all categories");
	}
}
