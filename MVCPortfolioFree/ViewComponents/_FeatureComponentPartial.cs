using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;

namespace MVCPortfolioFree.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
	private readonly MvcPortfolioFreeContext _context;

	public _FeatureComponentPartial(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	public IViewComponentResult Invoke()
	{
		var features = _context.Features.ToList();
        return View(features);
    }
}
