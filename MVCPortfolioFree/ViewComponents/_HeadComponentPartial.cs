using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _HeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
