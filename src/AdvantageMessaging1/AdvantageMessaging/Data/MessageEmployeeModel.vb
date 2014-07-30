Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Namespace Data

    <Table("MessageEmployee")>
    Public Class MessageEmployeeModel
        ''' <summary>
        ''' Unique key for this MessageSchedule instance.
        ''' </summary>
        <Key()>
        Public Property MessageEmployeeId As Guid

        ''' <summary>
        ''' Unique key for this MessageSchedule instance.
        ''' </summary>      
        <ForeignKey("MessageSchedule")>
        Public Property MessageScheduleId As Guid

        ''' <summary>
        ''' The employee associated with this message in this schedule.
        ''' </summary>       
        Public Property EmployeeNo As Int32

        ''' <summary>
        ''' Flag indicating that this message is marked as having been read.
        ''' </summary>
        ''' <remarks>This value is not the same as 'Viewed'.</remarks>
        Public Property IsRead As Boolean = False

        ''' <summary>
        ''' Timestamp at which this message was viewed by the user.
        ''' </summary>
        Public Property Viewed As DateTime?

        ''' <summary>
        ''' Flag indicating that the stats for this message has been sent.
        ''' </summary>
        Public Property IsStatUpdated As Boolean = False

        ''' <summary>
        ''' The MessageModel instance associated with this MessageSchedule instance.
        ''' </summary>
        Public Property MessageSchedule As MessageScheduleModel

    End Class

End Namespace
