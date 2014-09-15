Public Class PrintLineCommand
    Implements IPrintLineCommand

    Private ReadOnly _isPrintedLine As Boolean = True
    Public ReadOnly Property IsPrintedLine As Boolean Implements IReceiptCommand.IsPrintedLine
        Get
            Return _isPrintedLine
        End Get
    End Property

    Private ReadOnly _lineText As String = String.Empty
    Public ReadOnly Property LineText As String Implements IPrintLineCommand.LineText
        Get
            Return _lineText
        End Get
    End Property
    
    Sub New(lineText As String)
        _lineText = lineText
    End Sub

    Public Overrides Function ToString() As String
        Return _lineText
    End Function

End Class
