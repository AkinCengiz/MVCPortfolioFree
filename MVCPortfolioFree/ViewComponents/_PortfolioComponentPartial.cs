using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;

namespace MVCPortfolioFree.ViewComponents;

public class _PortfolioComponentPartial : ViewComponent
{
	private readonly MvcPortfolioFreeContext _context;

	public _PortfolioComponentPartial(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	public IViewComponentResult Invoke()
	{
		var portfolios = _context.Portfolios.ToList();
        return View(portfolios);
    }
}
