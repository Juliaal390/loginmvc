Imports System.ComponentModel.DataAnnotations

Public Class RegisterViewModel
    <Required(ErrorMessage:="Campo obrigatório")>
    <Display(Name:="Usuário")>
    Public Property UserName As String

    <Required(ErrorMessage:="Campo obrigatório")>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <Required(ErrorMessage:="Campo obrigatório")>
    <DataType(DataType.Password)>
    <Display(Name:="Confirmar Senha")>
    <Compare("Password", ErrorMessage:="As senhas não coincidem.")>
    Public Property ConfirmPassword As String
End Class

