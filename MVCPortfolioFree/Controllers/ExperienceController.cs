using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.Controllers;
public class ExperienceController : Controller
{
	private readonly MvcPortfolioFreeContext _context;

	public ExperienceController(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult ExperienceList()
	{
		var experiences = _context.Experiences.ToList();
		return View(experiences);
	}

	[HttpGet]
	public IActionResult CreateExperience()
	{
		return View();
	}

	[HttpPost]
	public IActionResult CreateExperience(Experience experience)
	{
		_context.Experiences.Add(experience);
		_context.SaveChanges();
		return RedirectToAction("ExperienceList");
	}

	[HttpGet]
	public IActionResult DeleteExperience(int id)
	{
		var experience = _context.Experiences.Find(id);
		_context.Experiences.Remove(experience);
		_context.SaveChanges();
		return RedirectToAction("ExperienceList");
	}

	[HttpGet]
	public IActionResult UpdateExperience(int id)
	{
		var experience = _context.Experiences.Find(id);
		return View(experience);
	}

	[HttpPost]
	public IActionResult UpdateExperience(Experience experience)
	{
		_context.Experiences.Update(experience);
		_context.SaveChanges();
		return RedirectToAction("ExperienceList");
	}
}
