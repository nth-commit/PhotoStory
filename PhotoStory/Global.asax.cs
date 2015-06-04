﻿using PhotoStory.Data.Relational;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;

namespace PhotoStory {
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();

			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			Database.SetInitializer<PhotoStoryContext>(null);
			try {
				using (
					var context = new PhotoStoryContext()) {
					if (!context.Database.Exists()) {
						// Create the SimpleMembership database without Entity Framework migration schema
						((IObjectContextAdapter)context).ObjectContext.CreateDatabase();
					}
				}

				WebSecurity.InitializeDatabaseConnection("DefaultConnection", "User", "UserId", "UserName", autoCreateTables: true);
			} catch (Exception ex) {
				throw new InvalidOperationException("The ASP.NET Simple Membership database could not be initialized. For more information, please see http://go.microsoft.com/fwlink/?LinkId=256588", ex);
			}
		}
	}
}