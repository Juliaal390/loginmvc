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

        <HttpGet>
        Function ChangePassword() As ActionResult
            ' Verifica se há um usuário logado
            If Session("userID") IsNot Nothing Then
                Return View()
            Else
                ' Se não houver usuário logado, redireciona para a página de login
                Return RedirectToAction("Index")
            End If
        End Function

        <HttpPost>
        Function ChangePassword(model As ChangePasswordModel) As ActionResult
            ' Verifica se há um usuário logado
            If Session("userID") IsNot Nothing Then
                Dim userId As Integer = Convert.ToInt32(Session("userID"))

                Using db As New LoginDataBaseEntities()
                    Dim user = db.Users.FirstOrDefault(Function(u) u.UserID = userId)

                    If user IsNot Nothing Then
                        ' Atualiza a senha do usuário
                        user.Password = model.NewPassword
                        db.SaveChanges()

                        TempData("ChangePasswordSuccessMessage") = "Senha alterada com sucesso!"
                    End If
                End Using
            End If

            ' Redireciona de volta para a página inicial
            Return RedirectToAction("Index", "Home")
        End Function







        <HttpGet>
        Function Register() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Register(model As RegisterViewModel) As ActionResult
            If ModelState.IsValid Then
                Using db As New LoginDataBaseEntities()
                    ' Verifique se o nome de usuário já existe
                    If db.Users.Any(Function(u) u.UserName = model.UserName) Then
                        ModelState.AddModelError("UserName", "Nome de usuário já existe.")
                        Return View(model)
                    End If

                    ' Criar um novo usuário com os dados do modelo
                    Dim newUser As New User With {
                         .UserName = model.UserName,
                           .Password = model.Password
                         }
                    db.Users.Add(newUser)
                    db.SaveChanges()

                    Return RedirectToAction("Index", "Login")
                End Using
            End If
            Return View(model)
        End Function
    End Class
End Namespace
