﻿using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Index2()
        {
            return View();
        }
    }
}
