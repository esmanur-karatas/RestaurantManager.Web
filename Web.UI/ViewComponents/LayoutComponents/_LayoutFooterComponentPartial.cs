﻿using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.LayoutComponents
{
	public class _LayoutFooterComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
