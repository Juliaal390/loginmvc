Imports System
Imports System.Collections.Generic
Imports System.ComponentModel 'namespace que cont�m displayname
Imports System.ComponentModel.DataAnnotations 'namespace que cont�m datatype

Partial Public Class User
    Public Property UserID As Integer

    <Required(ErrorMessage:="Campo obrigat�rio")>
    <DisplayName("Usu�rio")> 'displayname � aplicado ACIMA da propriedade
    Public Property UserName As String

    <Required(ErrorMessage:="Campo obrigat�rio")>
    <DisplayName("Senha")>
    <DataType(DataType.Password)>
    Public Property Password As String

End Class
