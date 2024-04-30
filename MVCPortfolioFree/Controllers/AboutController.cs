using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.Controllers;
public class AboutController : Controller
{
	private readonly MvcPortfolioFreeContext _context;

	public AboutController(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult About()
	{
		var about = _context.Abouts.FirstOrDefault();
		return View(about);
	}

	[HttpGet]
	public IActionResult UpdateAbout()
	{
		var about = _context.Abouts.FirstOrDefault();
		return View(about);
	}

	[HttpPost]
	public IActionResult UpdateAbout(About about)
	{
		_context.Abouts.Update(about);
		_context.SaveChanges();
		return RedirectToAction("About");
	}
}
