Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Data

    <Table("Messages")>
    Public Class MessageModel
        ''' <summary>
        ''' The unique key for this Message instance.
        ''' </summary>
        <Key()>
        Public Property MessageId As Guid

        ''' <summary>
        ''' The subject for this Message instance.
        ''' </summary>
        <MaxLength(100)>
        Public Property Subject As String

        ''' <summary>
        ''' The body of this Message instance.
        ''' </summary>
        <MaxLength(65536)>
        Public Property Body As String

        ''' <summary>
        ''' Timestamp indicating the last time the body of this Message instance was edited.
        ''' </summary>
        Public Property LastUpdate As DateTime

    End Class

End Namespace