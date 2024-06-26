@ModelType RegisterViewModel

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Registrar</title>
</head>
<body>
    <div>
        <h2>Registrar</h2>

        @Using Html.BeginForm("Register", "Login", FormMethod.Post)
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            @<div Class="form-group">
                @Html.LabelFor(Function(model) model.UserName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div Class="col-md-10">
                    @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
                </div>
            </div>

            @<div Class="form-group">
                @Html.LabelFor(Function(model) model.Password, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div Class="col-md-10">
                    @Html.EditorFor(Function(model) model.Password, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Password, "", New With {.class = "text-danger"})
                </div>
            </div>

            @<div Class="form-group">
                @Html.LabelFor(Function(model) model.ConfirmPassword, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div Class="col-md-10">
                    @Html.EditorFor(Function(model) model.ConfirmPassword, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.ConfirmPassword, "", New With {.class = "text-danger"})
                </div>
            </div>

            @<div Class="form-group">
                <div Class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Registrar" Class="btn btn-default" />
                </div>
            </div>
        End Using
    </div>
</body>
</html>
