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
        'TODO: Load the body 
        message.SetBody("")
    End Sub

End Class
