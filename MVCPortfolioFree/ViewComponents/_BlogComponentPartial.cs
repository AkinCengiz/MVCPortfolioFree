using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _BlogComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
