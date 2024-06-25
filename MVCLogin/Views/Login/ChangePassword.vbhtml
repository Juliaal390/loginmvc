@ModelType ChangePasswordModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Alterar Senha</title>
</head>
<body>
    <div>
        <h2>Alterar Senha</h2>

        @Using Html.BeginForm("ChangePassword", "Login", FormMethod.Post)
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    @<div Class="form-group">
            @Html.LabelFor(Function(model) model.NewPassword, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div Class="col-md-10">
                @Html.EditorFor(Function(model) model.NewPassword, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.NewPassword, "", New With {.class = "text-danger"})
                </div>
            </div>

            @<div Class="form-group">
                <div Class="col-md-offset-2 col-md-10">
                    <input type = "submit" value="Alterar Senha" Class="btn btn-default" />
                </div>
            </div>
        End Using
    </div>
</body>
</html>






