Imports AdvantageMessaging.Logic

Public Class MessageDisplayCollection
    Inherits List(Of IMessageDisplay)

    ''' <summary>
    ''' Overridden Item property of the internal list. 
    ''' </summary>
    ''' <param name="index"></param>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>Loads the body of the message if it has not been loaded already.</remarks>
    Public Shadows Property Item(index As Integer) As IMessageDisplay
        Get
            If Not MyBase.Item(index).HasBody Then
                LoadMessageBody(MyBase.Item(index))
            End If
            Return MyBase.Item(index)
        End Get
        Set(value As IMessageDisplay)
            MyBase.Item(index) = value
        End Set
    End Property

    ''' <summary>
    ''' Loads the body of the message
    ''' </summary>
    ''' <param name="message">The message to load the body for.</param>
    Private Sub LoadMessageBody(message As IMessageDisplayState)
        Dim messageBody As String = String.Empty

        Using handler As New CoreServiceMessageHandler()
            messageBody = handler.GetMessageBody(message.MessageId)
        End Using

        message.SetBody(messageBody)
    End Sub

End Class
