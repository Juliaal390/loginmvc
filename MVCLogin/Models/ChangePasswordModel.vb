Imports System.ComponentModel 'namespace que contém displayname
Imports System.ComponentModel.DataAnnotations 'namespace que contém datatype

Public Class ChangePasswordModel
    <DisplayName("Nova senha:")>
    <DataType(DataType.Password)>
    Public Property NewPassword As String
End Class

