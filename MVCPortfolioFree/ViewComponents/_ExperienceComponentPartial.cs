using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
