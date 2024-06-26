@ModelType User

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Login</title>
    <style>
        *, :root{
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        body{
            background-color: #082639;
            color: #929194;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-weight: bold;
        }
        #login-div{
            background-color: #ffffff;
            padding: 4rem 2rem;
            margin: auto;
        }
        .formulario{
                display: flex;
                flex-direction: column;
        }
        .error{
            color: red;
            
        }
        h2, label, a{
            color: #0D2E43;
        }
        h2{
            font-size: 2.5rem;
        }
        .sectionForm{
            margin: 0.5rem 0;
        }
        .sectionHeader{
            margin-bottom: 1rem;
        }
        input{
            width: 100%;
            padding: 0.8rem 0.2rem;
            border: 1px solid #929194;
            outline: none;
            
        }
        input[type="submit"]{
            color:#929194;
            border: #929194;
            cursor: pointer;
        }
        a{
            font-weight: normal;
            margin-top: 2.5rem;
        }
    </style>
</head>
<body>
    <div id="login-div">
        @Using (Html.BeginForm("Autherize", "Login", FormMethod.Post)) ' obs.: o método já é POST por padrão / função, controller onde fica
    @<div class="sectionHeader">
        <h2>Login</h2>
        <p>Digite os seus dados de acesso no campo abaixo</p>
    </div>
    @<section Class="formulario">
        <div class="sectionForm">
            <label>@Html.LabelFor(Function(m) m.UserName)</label>
            <p>@Html.EditorFor(Function(m) m.UserName)</p>

            <p class="error">@Html.ValidationMessageFor(Function(m) m.UserName)</p>
        </div>

        <div class="sectionForm">
            <label>@Html.LabelFor(Function(m) m.Password)</label>
            <p>@Html.EditorFor(Function(m) m.Password)</p>

            <p class="error">@Html.ValidationMessageFor(Function(m) m.Password)</p>
        </div>
        <p class="error">
            @If ViewData.ContainsKey("LoginErrorMessage") Then
                @ViewData("LoginErrorMessage") 'login ou senha incorretos
            End If
        </p>

        <input type="submit" name="name" value="Entrar" />

         <a href="@Url.Action("Register", "Login")">Não possuo uma conta</a>

    </section>
        End Using
    </div>
</body>
</html>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/jquery.validate/1.19.3/jquery.validate.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js"></script>
