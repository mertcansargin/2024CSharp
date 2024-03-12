using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Entity.Concrete;

namespace MaskApp.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			Person person = new Person();
			person.PersonName = "Test";
			person.PersonSurname = "TestSurname";
			

			return View(person);
		}
	}
}
