
@Code
    Layout = Nothing
    If (Session("userID") = Nothing) Then
        Response.Redirect("~/Login/Index")
    End If
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Home</title>
</head>
<body>
    <div> 
        <h2>Seja bem vindo(a)!</h2>
        <a href="@Url.Action("Logout", "Login")">Sair</a>
        <a href="@Url.Action("ChangePassword", "Login")">Alterar Senha</a>
    </div>
</body>
</html>
