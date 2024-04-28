using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents.LayoutViewComponents;

public class _LayoutMainHeaderComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
