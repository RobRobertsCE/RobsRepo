Public Interface IReceipt

    ReadOnly Property CommandList As List(Of IReceiptCommand)

    Sub AddLine(newLine As IPrintLineCommand)

    Sub AddAction(newAction As IPrinterActionCommand)

End Interface
