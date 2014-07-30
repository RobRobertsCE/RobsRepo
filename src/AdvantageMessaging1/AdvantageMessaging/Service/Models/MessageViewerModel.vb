Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    ''' <summary>
    ''' API Model for a message viewer (employee) item.
    ''' </summary>
    ''' <remarks></remarks>
    <DataContract()>
    Public Class MessageViewerModel
        Inherits ApiBaseModel

#Region " properties "

        ''' <summary>
        ''' The unique number for the employee.
        ''' </summary>
        <DataMember()>
        Public Property empNo As Integer

        ''' <summary>
        ''' The name of the employee.
        ''' </summary>
        <DataMember()>
        Public Property empName As String

        ''' <summary>
        ''' The timestamp when the user viewed the message.
        ''' </summary>
        <DataMember()>
        Public Property viewed As DateTime

#End Region

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageViewerModel
        ''' </summary>
        Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' ctor for MessageViewerModel
        ''' </summary>
        ''' <param name="employeeNumber">The unique hash for the location.</param>
        ''' <param name="employeeName">The list of users who have viewed the message.</param>
        ''' <param name="viewed">The list of users who have viewed the message.</param>
        Sub New(employeeNumber As String, employeeName As String, viewed As DateTime)
            Me.New()

            Me.empNo = employeeNumber
            Me.empName = employeeName
            Me.viewed = viewed

        End Sub

#End Region

    End Class

End Namespace

