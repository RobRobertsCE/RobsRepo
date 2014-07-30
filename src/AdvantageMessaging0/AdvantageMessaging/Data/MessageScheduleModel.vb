Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Data

    <Table("MessageSchedules")>
    Public Class MessageScheduleModel
        ''' <summary>
        ''' Unique key for this MessageSchedule instance.
        ''' </summary>
        <Key()>
        <Column(Order:=0)>
        Public Property MessageScheduleId As Guid

        ''' <summary>
        ''' Unique Key for the Message associated with this MessageSchedule instance.
        ''' </summary>
        <Key()>
        <ForeignKey("Message")>
        <Column(Order:=1)>
        Public Property MessageId As Guid

        ''' <summary>
        ''' The employee associated with this message in this schedule.
        ''' </summary>
        <Key()>
        <Column(Order:=2)>
        Public Property EmployeeNo As Int32

        ''' <summary>
        ''' Flag indicating that this message is marked as having been read.
        ''' </summary>
        ''' <remarks>This value is not the same as 'Viewed'.</remarks>
        Public Property IsRead As Boolean = False

        ''' <summary>
        ''' Timestamp at which this message automatically marks itself as Not New.
        ''' </summary>
        Public Property Expires As DateTime

        ''' <summary>
        ''' Timestamp at which this message was received at the local system.
        ''' </summary>
        Public Property Received As DateTime

         ''' <summary>
        ''' Timestamp at which this message was viewed by the user.
        ''' </summary>
        Public Property Viewed As DateTime?

        ''' <summary>
        ''' The MessageModel instance associated with this MessageSchedule instance.
        ''' </summary>
        Public Property Message As MessageModel = Nothing

    End Class

End Namespace
