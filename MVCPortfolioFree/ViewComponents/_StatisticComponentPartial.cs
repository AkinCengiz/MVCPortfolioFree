using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _StatisticComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
