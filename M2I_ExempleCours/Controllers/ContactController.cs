using M2I_ExempleCours.Models;
using Microsoft.AspNetCore.Mvc;

namespace M2I_ExempleCours.Controllers;

public class ContactController : Controller
{
	private static List<Contact> _contacts = [];

	// GET
	public IActionResult Index()
	{
		return View(_contacts);
	}

	public IActionResult AddContact(string name, string email, string phoneNumber)
	{
		if (ModelState.IsValid
		    && !(string.IsNullOrEmpty(name) && string.IsNullOrWhiteSpace(name))
		    && !(string.IsNullOrEmpty(email) && string.IsNullOrWhiteSpace(email))
		    && !(string.IsNullOrEmpty(phoneNumber) && string.IsNullOrWhiteSpace(phoneNumber))
		   )
		{
			Contact c = new Contact { Id = _contacts.Count + 1, Name = name, Email = email, PhoneNumber = phoneNumber };
			_contacts.Add(c);
			foreach (var contact in _contacts)
			{
				Console.WriteLine(contact);
			}
		}

		return RedirectToAction("Index");
	}
}