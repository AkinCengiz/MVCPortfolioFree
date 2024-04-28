using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.Controllers;
public class ExperienceController : Controller
{
	public IActionResult ExperienceList()
	{
		return View();
	}
}
