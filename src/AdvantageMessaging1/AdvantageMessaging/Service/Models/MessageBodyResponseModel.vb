Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    ''' <summary>
    ''' API Model for a message body response item.
    ''' </summary>
    ''' <remarks></remarks>
    <DataContract()>
    Public Class MessageBodyResponseModel
        Inherits ApiBaseModel

#Region " properties "

        ''' <summary>
        ''' The unique id for the message.
        ''' </summary>
        <DataMember()>
        Public Property messageId As Guid

        ''' <summary>
        ''' The body of this message.
        ''' </summary>
        <DataMember()>
        Public Property body As String

#End Region

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageBodyResponseModel
        ''' </summary>
        ''' <remarks></remarks>
        Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' ctor for MessageBodyResponseModel
        ''' </summary>
        ''' <param name="messageId">The unique id for the message.</param>
        ''' <param name="body">The body of this message.</param>
        ''' <remarks></remarks>
        Sub New(messageId As Guid, body As String)
            Me.New()

            Me.messageId = messageId
            Me.body = body

        End Sub

#End Region

    End Class

End Namespace