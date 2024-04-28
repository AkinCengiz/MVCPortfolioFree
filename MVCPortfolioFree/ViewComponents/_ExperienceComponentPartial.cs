using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;

namespace MVCPortfolioFree.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
	private readonly MvcPortfolioFreeContext _context;

	public _ExperienceComponentPartial(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	public IViewComponentResult Invoke()
	{
		var experiences = _context.Experiences.ToList();
        return View(experiences);
    }
}
