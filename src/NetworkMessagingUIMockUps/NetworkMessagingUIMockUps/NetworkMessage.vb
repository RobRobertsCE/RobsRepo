Public Class NetworkMessageList
    Inherits System.Collections.Generic.List(Of INetworkMessage)

End Class

Public Class NetworkMessage
    Implements INetworkMessage

    Public Property Body As String Implements INetworkMessage.Body

    Public Property ExpirationDate As Date Implements INetworkMessage.ExpirationDate

    Public Property MessageId As Guid Implements INetworkMessage.MessageId

    Public Property Subject As String Implements INetworkMessage.Subject

    Public Property IsUnread As Boolean Implements INetworkMessage.IsUnread

    Public Sub New(subject As String, body As String, expirationDate As DateTime)
        Me.New(Guid.NewGuid(), subject, body, expirationDate, True)
    End Sub

    Public Sub New(id As Guid, subject As String, body As String, expirationDate As DateTime, isUnread As Boolean)
        Me.MessageId = id
        Me.Subject = subject
        Me.Body = body
        Me.ExpirationDate = expirationDate
        Me.IsUnread = isUnread
    End Sub

End Class

Public Interface INetworkMessage
    Property MessageId As Guid
    Property Subject As String
    Property Body As String
    Property ExpirationDate As DateTime
    Property IsUnread As Boolean
End Interface
