Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Data

    <Table("MessageSchedule")>
    Public Class MessageScheduleModel
        ''' <summary>
        ''' Unique key for this MessageSchedule instance.
        ''' </summary>
        <Key()>
        Public Property MessageScheduleId As Guid

        ''' <summary>
        ''' Unique Key for the Message associated with this MessageSchedule instance.
        ''' </summary>
        <ForeignKey("Message")>
        Public Property MessageId As Guid

        ''' <summary>
        ''' Timestamp at which this message automatically marks itself as Not New.
        ''' </summary>
        Public Property Expires As DateTime

        ''' <summary>
        ''' Timestamp at which this message was received at the local system.
        ''' </summary>
        Public Property Received As DateTime

        ''' <summary>
        ''' The MessageModel instance associated with this MessageSchedule instance.
        ''' </summary>
        Public Property Message As MessageModel

        ''' <summary>
        ''' The list of all of the views of this scheduled message.
        ''' </summary>
        Public Overridable Property MessageEmployees As IList(Of MessageEmployeeModel)

    End Class

End Namespace
