using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _FooterSocialAccountComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
