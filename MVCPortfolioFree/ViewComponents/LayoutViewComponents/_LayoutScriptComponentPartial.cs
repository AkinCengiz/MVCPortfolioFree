using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents.LayoutViewComponents;

public class _LayoutScriptComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
