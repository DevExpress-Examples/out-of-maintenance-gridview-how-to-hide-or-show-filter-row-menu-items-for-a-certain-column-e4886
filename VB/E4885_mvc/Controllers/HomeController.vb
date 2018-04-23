Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace E4885_mvc.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Dim model = Enumerable.Range(0, 10).Select(Function(i) New With {Key .Col1 = i, Key .Col2 = i * 2})
			Return PartialView(model)
		End Function
	End Class
End Namespace