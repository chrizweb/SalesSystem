using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.AppWeb.Controllers {
	public class ProductoController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}
