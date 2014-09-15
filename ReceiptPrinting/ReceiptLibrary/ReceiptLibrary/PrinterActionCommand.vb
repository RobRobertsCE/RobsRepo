Public Class PrinterActionCommand
    Implements IPrinterActionCommand
    
    Private ReadOnly _isPrintedLine As Boolean = False
    Public ReadOnly Property IsPrintedLine As Boolean Implements IReceiptCommand.IsPrintedLine
        Get
            Return _isPrintedLine
        End Get
    End Property
    
    Private ReadOnly _printerAction As String = String.Empty
    Public ReadOnly Property PrinterAction As String Implements IPrinterActionCommand.PrinterAction
        Get
            Return _printerAction
        End Get
    End Property

    Sub New(printerAction As String)
        _printerAction = printerAction
    End Sub

    Public Overrides Function ToString() As String
        Return _printerAction
    End Function

End Class
