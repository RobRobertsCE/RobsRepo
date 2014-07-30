Namespace Logic

    Public Interface IMessageDisplay
#Region " properties "

        ''' <summary>
        ''' The unique Message and Schedule Id.
        ''' </summary>
        ReadOnly Property MessageScheduleId As Guid

        ''' <summary>
        ''' The unique Message Id.
        ''' </summary>
        ReadOnly Property MessageId As Guid

        ''' <summary>
        ''' The subject of the message.
        ''' </summary>
        ReadOnly Property Subject As String

        ''' <summary>
        ''' The body of the message.
        ''' </summary>
        ReadOnly Property Body As String

        ''' <summary>
        ''' Flag indiciating whether or not the message body has been acquired.
        ''' </summary>
        ReadOnly Property HasBody As Boolean

        ''' <summary>
        ''' Flag indiciating whether or not the message body has been displayed to the user.
        ''' </summary>
        ReadOnly Property IsViewed As Boolean

        ''' <summary>
        ''' Flag indiciating whether or not the message status has been updated to read.
        ''' </summary>
        ReadOnly Property IsRead As Boolean

        ''' <summary>
        ''' The timestamp that the message was received by the local system.
        ''' </summary>
        ReadOnly Property Received As DateTime

#End Region

    End Interface

End Namespace