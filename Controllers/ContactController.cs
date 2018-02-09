using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/contacts/new")]
    public ActionResult Form()
    {
      return View("NewContactForm");
    }

    [HttpGet("/contacts")]
    public ActionResult ContactList()
    {
      return View();
    }

    [HttpPost("/contacts")]
    public ActionResult AddContact()
    {
      Address newAddress = new Address(Request.Form["addressStreet"], Request.Form["addressCity"], Request.Form["addressState"], int.Parse(Request.Form["addressZipCode"]));
      Contact newContact = new Contact(Request.Form["contactName"], int.Parse(Request.Form["contactNumber"]), newAddress);
      newContact.SaveContact();
      return View("ContactList", Contact.AllContacts());
    }

    [HttpPost("/contacts/delete")]
    public ActionResult DeleteAll()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
