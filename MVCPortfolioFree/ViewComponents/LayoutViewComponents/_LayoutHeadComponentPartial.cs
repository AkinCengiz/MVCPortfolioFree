using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents.LayoutViewComponents;

public class _LayoutHeadComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
