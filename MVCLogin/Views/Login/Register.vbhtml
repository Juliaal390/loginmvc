@ModelType RegisterViewModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Registrar</title>
    <style>
        *, :root{
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
       body{
            background-color: #0D2E43;
            color: #0D2E43;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            font-weight: bold;
        }
       #register-div{
            background-color: #ffffff;
            padding: 4rem 2rem;
            margin: auto;
            width: 30rem;
       }
       h2{
            font-size: 2.5rem;
        }
        a{
           color: #0D2E43;
           padding: 2rem 0;     
           font-weight: normal;
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
            margin-top: 1rem;
        }
        .sectionForm{
            margin: 0.5rem 0;
        }
        .error{
            color: red;
        }
    </style>
</head>
<body>
    <div id="register-div">
        <h2>Registrar</h2>

        @Using Html.BeginForm("Register", "Login", FormMethod.Post)
            @Html.ValidationSummary(True, "")

            @<div class="sectionForm">
                @Html.LabelFor(Function(model) model.UserName)
                <div>
                    @Html.EditorFor(Function(model) model.UserName)
                    <p class="error">@Html.ValidationMessageFor(Function(model) model.UserName, "")</p>
                </div>
            </div>

            @<div class="sectionForm">
                @Html.LabelFor(Function(model) model.Password)
                <div>
                    @Html.EditorFor(Function(model) model.Password)
                    <p class="error">@Html.ValidationMessageFor(Function(model) model.Password, "")</p>
                </div>
            </div>

            @<div class="sectionForm">
                @Html.LabelFor(Function(model) model.ConfirmPassword)
                <div>
                    @Html.EditorFor(Function(model) model.ConfirmPassword)
                    <p class="error">@Html.ValidationMessageFor(Function(model) model.ConfirmPassword, "")</p>
                </div>
            </div>

            @<div>
                <div>
                    <input type="submit" value="Registrar" />
                </div>
            </div>
            @<a href = "@Url.Action("Index", "Login")">Já possuo uma conta</a>
        End Using
    </div>
</body>
</html>
