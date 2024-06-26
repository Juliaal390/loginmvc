@ModelType ChangePasswordModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Alterar Senha</title>
    <style>
        body{
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            background-color: #082639;
            color: #0D2E43;
            height: 100vh;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-weight: bold;
        }
        a {
            margin-top: 2rem;
            color: #ffffc7;
        }
        #changepassword-div{
            background-color: #ffffff;
            padding: 2rem 4rem;
        }
        input {
            border: none;
            border-bottom: 2px solid black;
            outline: none;
            margin: 1rem 0;
        }
        .btnSubmit{
            border: none;
            padding: 1rem;
            cursor: pointer;
        }
   
    </style>
</head>
<body>
    <div id="changepassword-div">
        <h2>Alterar Senha</h2>

        @Using Html.BeginForm("ChangePassword", "Login", FormMethod.Post)
            @Html.ValidationSummary(True, "")
    @<div Class="form-group">
            @Html.LabelFor(Function(model) model.NewPassword)
                <div>
                @Html.EditorFor(Function(model) model.NewPassword)
                @Html.ValidationMessageFor(Function(model) model.NewPassword, "")
                </div>
            </div>

            @<div Class="form-group">
                <div>
                    <input type = "submit" value="Alterar Senha" class="btnSubmit" />
                </div>
            </div>
        End Using
    </div>
    <a href="@Url.Action("Index", "Home")">Voltar</a>
</body>
</html>






