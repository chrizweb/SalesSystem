using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.AppWeb.Controllers {
	public class DashBoardController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}
