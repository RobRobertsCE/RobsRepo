Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    ''' <summary>
    ''' API Model for a message list response item.
    ''' </summary>
    ''' <remarks></remarks>
    <DataContract()>
    Public Class MessageListResponseModel
        Inherits ApiBaseModel

#Region " properties "

        ''' <summary>
        ''' The unique id for the message.
        ''' </summary>
        <DataMember()>
        Public Property messageId As Guid

        ''' <summary>
        ''' The unique id for the message schedule.
        ''' </summary>
        <DataMember()>
        Public Property messageScheduleId As Guid

        ''' <summary>
        ''' The subject of this message.
        ''' </summary>
        <DataMember()>
        Public Property subject As String


        ''' <summary>
        ''' The timestamp of the last update of this message.
        ''' </summary>
        <DataMember()>
        Public Property lastUpdate As DateTime


        ''' <summary>
        ''' The expiration timestamp of this message.
        ''' </summary>
        <DataMember()>
        Public Property expires As DateTime

#End Region

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageListResponseModel
        ''' </summary>
        ''' <remarks></remarks>
        Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' ctor for MessageListResponseModel
        ''' </summary>
        ''' <param name="messageId">The unique id for the message.</param>
        ''' <param name="messageScheduleId">The unique id for the message schedule.</param>
        ''' <param name="subject">The subject of this message.</param>
        ''' <param name="lastUpdate">The timestamp of the last update of this message.</param>
        ''' <param name="expires">The expiration timestamp of this message.</param>
        ''' <remarks></remarks>
        Sub New(messageId As Guid, messageScheduleId As Guid, subject As String, lastUpdate As DateTime, expires As DateTime)
            Me.New()

            Me.messageId = messageId
            Me.messageScheduleId = messageScheduleId
            Me.subject = subject
            Me.lastUpdate = lastUpdate
            Me.expires = expires

        End Sub

#End Region

    End Class

End Namespace
