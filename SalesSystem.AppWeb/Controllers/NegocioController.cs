﻿using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.AppWeb.Controllers {
	public class NegocioController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}