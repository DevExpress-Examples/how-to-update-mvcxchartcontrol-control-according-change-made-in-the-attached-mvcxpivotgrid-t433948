﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Optimization
Imports System.Web.Routing

Namespace MvcApplication1
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			WebApiConfig.Register(GlobalConfiguration.Configuration)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)
			BundleConfig.RegisterBundles(BundleTable.Bundles)
		End Sub
	End Class
End Namespace