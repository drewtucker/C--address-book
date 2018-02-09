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

    [HttpPost("/contacts")]
    public ActionResult AddContact()
    {
      Address newAddress = new Address(Request.Form["addressStreet"], Request.Form["addressCity"], Request.Form["addressState"], int.Parse(Request.Form["addressZipCode"]));
      Contact newContact = new Contact(Request.Form["contactName"], Request.Form["contactNumber"], newAddress);
    }
  }
}
