Namespace Logic

    Friend Interface IMessageDisplayState

        ''' <summary>
        ''' The unique Message Id.
        ''' </summary>
        ReadOnly Property MessageId As Guid

        ''' <summary>
        ''' Updates the IsViewed property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageHandler.</remarks>
        Sub MarkViewed()

        ''' <summary>
        ''' Updates the IsRead property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageHandler.</remarks>
        Sub MarkRead()

        ''' <summary>
        ''' Updates the Body property of this instance.
        ''' </summary>
        ''' <remarks>Only accessible from MessageDisplayCollection.</remarks>
        Sub SetBody(body As String)

    End Interface

End Namespace