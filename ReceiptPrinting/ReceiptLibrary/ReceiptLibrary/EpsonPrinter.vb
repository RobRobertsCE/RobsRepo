Public Class EpsonPrinter
    Implements IPrinter
    
    ''' <summary>
    ''' CodePageSelector command for Epson printer
    ''' </summary>
    Private ReadOnly EpsonCodePageSelector As Byte() = New Byte() {27, 116, 0}

    Public Overridable Sub Initialize(stream As IO.Stream) Implements IPrinter.InitializePrintStream
        stream.Write(EpsonCodePageSelector, 0, EpsonCodePageSelector.Length)
    End Sub

    Public Overridable Sub FinalizePrintStream(stream As IO.Stream) Implements IPrinter.FinalizePrintStream
        ' fall through 
    End Sub

End Class
