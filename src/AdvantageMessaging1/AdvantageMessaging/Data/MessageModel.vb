Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Data

    <Table("Message")>
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

        ''' <summary>
        ''' The list of all of the schedules of this message.
        ''' </summary>
        Public Overridable Property MessageSchedules As IList(Of MessageScheduleModel)

    End Class

End Namespace