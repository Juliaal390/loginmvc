Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        Function LogOut() As ActionResult
            Session.Abandon()
            Return RedirectToAction("Index", "Login")
        End Function

        <HttpPost>
        Function Autherize(userModel As User) As ActionResult
            Using db As New LoginDataBaseEntities()
                Dim userDetails = db.Users.Where(Function(x) x.UserName = userModel.UserName AndAlso x.Password = userModel.Password).FirstOrDefault()
                If userDetails Is Nothing Then
                    ViewData("LoginErrorMessage") = "Email ou senha incorretos"
                    Return View("Index", userModel)
                Else
                    Session("userID") = userDetails.UserID
                    Return RedirectToAction("Index", "Home")
                End If
            End Using
        End Function
    End Class
End Namespace