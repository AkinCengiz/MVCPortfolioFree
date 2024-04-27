using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;

namespace MVCPortfolioFree.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
	private readonly MvcPortfolioFreeContext _context;

	public _AboutComponentPartial(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	public IViewComponentResult Invoke()
	{
		var about = _context.Abouts.FirstOrDefault();
		ViewBag.aboutTitle = about.Title;
		ViewBag.aboutDescription = about.Description;
		ViewBag.aboutDetail = about.Detail;
        return View();
    }
}
