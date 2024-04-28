using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents.LayoutViewComponents;

public class _LayoutModalComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
