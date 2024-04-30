using Microsoft.AspNetCore.Mvc;
using MVCPortfolioFree.DataAccess.Contexts;
using MVCPortfolioFree.DataAccess.Entities;

namespace MVCPortfolioFree.Controllers;
public class ContactController : Controller
{
	private readonly MvcPortfolioFreeContext _context;

	public ContactController(MvcPortfolioFreeContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult Contact()
	{
		var contact = _context.Contacts.FirstOrDefault();
		return View(contact);
	}

	[HttpGet]
	public IActionResult UpdateContact()
	{
		var contact = _context.Contacts.FirstOrDefault();
		return View(contact);
	}

	[HttpPost]
	public IActionResult UpdateContact(Contact contact)
	{
		_context.Contacts.Update(contact);
		_context.SaveChanges();
		return RedirectToAction("Contact");
	}
}
