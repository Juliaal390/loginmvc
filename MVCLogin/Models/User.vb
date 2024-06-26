Imports System
Imports System.Collections.Generic
Imports System.ComponentModel 'namespace que contém displayname
Imports System.ComponentModel.DataAnnotations 'namespace que contém datatype

Partial Public Class User
    Public Property UserID As Integer

    <Required(ErrorMessage:="Campo obrigatório")>
    <DisplayName("Usuário")> 'displayname é aplicado ACIMA da propriedade
    Public Property UserName As String

    <Required(ErrorMessage:="Campo obrigatório")>
    <DisplayName("Senha")>
    <DataType(DataType.Password)>
    Public Property Password As String

End Class
