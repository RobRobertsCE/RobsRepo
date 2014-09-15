Public Class Receipt
    Implements IReceipt
    
    Private ReadOnly _commands As IList(Of IReceiptCommand) = Nothing

    Friend ReadOnly Property CommandList As List(Of IReceiptCommand) Implements IReceipt.CommandList
        Get
            Return _commands
        End Get
    End Property

    Public Sub New()
        _commands = New List(Of IReceiptCommand)
    End Sub

    Public Sub AddAction(newAction As IPrinterActionCommand) Implements IReceipt.AddAction
        _commands.Add(newAction)
    End Sub

    Public Sub AddLine(newLine As IPrintLineCommand) Implements IReceipt.AddLine
        _commands.Add(newLine)
    End Sub

End Class
