﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoStory.Controllers.Mvc {

	[Authorize]
	public class HomeController : BaseController {

		[HttpGet]
		[AllowAnonymous]
		public ActionResult Index() {
			return View();
		}
	}
}
