using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.Controllers;
public class FeatureController : Controller
{
	private readonly MvcPortfolioFreeContext _context;

	public FeatureController(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult Index()
	{
		var feature = _context.Features.FirstOrDefault();
		return View(feature);
	}

	[HttpGet]
	public IActionResult UpdateFeature()
	{
		var feature = _context.Features.FirstOrDefault();
		return View(feature);
	}

	[HttpPost]
	public IActionResult UpdateFeature(Feature feature)
	{
		_context.Features.Update(feature);
		_context.SaveChanges();
		return RedirectToAction("Index");
	}
}
