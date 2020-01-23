Imports System.Web.Mvc

Namespace Controllers
    Public Class MYVIEWController
        Inherits Controller

        ' GET: MYVIEW
        Function Login_menu() As ActionResult
            Return View()
        End Function

        Function DETAIL_USER() As ActionResult
            Return View()
        End Function

    End Class
End Namespace