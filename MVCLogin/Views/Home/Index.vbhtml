
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
    <style>
        *, :root{
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
       body{
            background-color: #082639;
            color: #ffffc7;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-weight: bold;
        }
       a{
           color: #ffffff;
           padding: 2rem 0;
       }
       a:first-of-type{
           margin-right: 1rem;
       }
    </style>
</head>
<body>
    <div> 
        <h2>Seja bem vindo(a)!</h2>
        <a href="@Url.Action("Logout", "Login")">Sair</a>
        <a href="@Url.Action("ChangePassword", "Login")">Alterar Senha</a>
    </div>
</body>
</html>
