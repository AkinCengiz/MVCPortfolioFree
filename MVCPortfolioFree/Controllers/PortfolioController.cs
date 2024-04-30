using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.Controllers;
public class PortfolioController : Controller
{
	private readonly MvcPortfolioFreeContext _context;

	public PortfolioController(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult PortfolioList()
	{
		var portfolios = _context.Portfolios.ToList();
		return View(portfolios);
	}

	[HttpGet]
	public IActionResult CreatePortfolio()
	{
		return View();
	}

	[HttpPost]
	public IActionResult CreatePortfolio(Portfolio portfolio)
	{
		_context.Portfolios.Add(portfolio);
		_context.SaveChanges();
		return RedirectToAction("PortfolioList");
	}

	[HttpGet]
	public IActionResult DeletePortfolio(int id)
	{
		var portfolio = _context.Portfolios.Find(id);
		_context.Portfolios.Remove(portfolio);
		_context.SaveChanges();
		return RedirectToAction("PortfolioList");
	}

	[HttpGet]
	public IActionResult UpdatePortfolio(int id)
	{
		var portfolio = _context.Portfolios.Find(id);
		return View(portfolio);
	}

	[HttpPost]
	public IActionResult UpdatePortfolio(Portfolio portfolio)
	{
		_context.Portfolios.Update(portfolio);
		_context.SaveChanges();
		return RedirectToAction("PortfolioList");
	}
}
