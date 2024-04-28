using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;

namespace MVCPortfolioFree.ViewComponents;

public class _SkillsComponentPartial : ViewComponent
{
    private readonly MvcPortfolioFreeContext _context;

    public _SkillsComponentPartial(MvcPortfolioFreeContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var skills = _context.Skills.ToList();
        return View(skills);
    }
}
