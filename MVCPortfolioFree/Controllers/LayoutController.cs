using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.Controllers;
public class LayoutController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
