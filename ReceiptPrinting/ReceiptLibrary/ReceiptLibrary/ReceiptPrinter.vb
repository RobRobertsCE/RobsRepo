Imports System.Text

Public Class ReceiptPrinter
    Implements IDisposable

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private ReadOnly AnsiEncoding As Encoding = Encoding.GetEncoding(1252)
    
    Private _printer As IPrinter
    Public Property Printer() As IPrinter
        Get
            Return _printer
        End Get
        Set(ByVal value As IPrinter)
            _printer = value
        End Set
    End Property

    Private _receipt As IReceipt
    Public Property Receipt() As IReceipt
        Get
            Return _receipt
        End Get
        Set(ByVal value As IReceipt)
            _receipt = value
        End Set
    End Property

    Sub New(printer As IPrinter, receipt As IReceipt)
        Me.Printer = printer
        Me.Receipt = receipt
    End Sub

    Public Overridable Sub PrintReceipt(printerMutex As System.Threading.Mutex)

        'If printerMutex.WaitOne(5000, False) Then

        '    Try
        '        Dim printerName As String = Trim(WindowsPrintName)

        '        If Printers.Contains(printerName) Then
        '            CType(Printers(printerName), PrintThread).AddToQueue(bytes)
        '        Else
        '            Dim printThread As New PrintThread(printerName, bytes)
        '            Printers.Add(printerName, printThread)
        '            printThread.Start()
        '        End If

        '    Finally
        '        PrinterMutex.ReleaseMutex()

        '    End Try
        'Else
        '    MessageHandler(res_PrintError_UnableToAcquirePrinter)
        'End If

    End Sub

    Public Overridable Function GetReceiptBytes() As Byte()

        Dim newLineBytes As Byte() = AnsiEncoding.GetBytes(Environment.NewLine)
        Dim lineBytes As Byte()
        Dim receiptBytes As Byte()

        Using stream As New System.IO.MemoryStream()

            _printer.InitializePrintStream(stream)

            For Each command As IReceiptCommand In _receipt.CommandList
                lineBytes = AnsiEncoding.GetBytes(command.ToString())

                stream.Write(lineBytes, 0, lineBytes.Length)

                If TypeOf (command) Is IPrintLineCommand Then
                    stream.Write(newLineBytes, 0, newLineBytes.Length)

                End If

            Next

            _printer.FinalizePrintStream(stream)

            receiptBytes = stream.ToArray()

        End Using

        Return receiptBytes

    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                Me.Printer = Nothing
                Me.Receipt = Nothing
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
