using Microsoft.AspNetCore.Mvc;

namespace MVCPortfolioFree.ViewComponents;

public class _PhotoswipeComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
