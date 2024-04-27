using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.Controllers;
public class DefaultController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
