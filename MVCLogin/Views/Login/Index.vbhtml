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
        /*colocar o CSS AQUI*/
    </style>
</head>
<body>
    <div id="login-div">
        @Using (Html.BeginForm("Autherize", "Login", FormMethod.Post)) ' obs.: o método já é POST por padrão / função, controller onde fica
            @<table>
                <tr>
                    <td></td>
                    <td style="text-decoration: underline">AppName</td>
                </tr>
                <tr>
                    <td>@Html.LabelFor(Function(m) m.UserName)</td>
                    <td>@Html.EditorFor(Function(m) m.UserName)</td>
                </tr>
                <tr>
                    <td></td>
                    <td>@Html.ValidationMessageFor(Function(m) m.Password)</td>
                </tr>
                <tr>
                    <td>@Html.LabelFor(Function(m) m.Password)</td>
                    <td>@Html.EditorFor(Function(m) m.Password)</td>
                </tr>
                 <tr>
                     <td>
                         @If ViewData.ContainsKey("LoginErrorMessage") Then
                           @ViewData("LoginErrorMessage")
                         End If
                     </td>
                 </tr>
                 <tr>
                     <td></td>
                     <td>@Html.ValidationMessageFor(Function(m) m.Password)</td>
                 </tr>
                <tr>
                    <td></td>
                    <td>
                       <input type="submit" name="name" value="Login"/>
                    </td>
                </tr>
            </table>
        End Using
    </div>
</body>
</html>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/jquery.validate/1.19.3/jquery.validate.min.js"></script>
<script src="https://ajax.aspnetcdn.com/ajax/mvc/5.2.3/jquery.validate.unobtrusive.min.js"></script>
