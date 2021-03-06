﻿Namespace Logic

    Public Class SecoaCardHistory
        '<OpDate_YYYYMMDDHHNNSS>;
        '<OpName_ASCIIHex>;
        '<OpQty>;
        '<OpConcept_ASCIIHex>;
        '<OpCounter_ASCIIHex>;
        '<OpAmount>;
        '<OpType>;
        '<OpTransID>;
        '<OpStoreID>

        Private Enum Fields
            OpDate = 0
            OpName
            OpQty
            OpConcept
            OpCounter
            OpAmount
            OpType
            OpTransId
            OpStoreId
        End Enum

        Public Property OpDate As String
        Public Property OpName As String
        Public Property OpQty As Integer
        Public Property OpConcept As String
        Public Property OpCounter As String
        Public Property OpAmount As Decimal
        Public Property OpType As Integer
        Public Property OpTransId As Integer
        Public Property OpStoreId As Integer

        Public Sub New(responseString As String)
            Dim responseValues As String() = responseString.Split(";"c)
            OpDate = responseValues(Fields.OpDate)
            OpName = responseValues(Fields.OpName).FromAsciiHex()
            OpQty = responseValues(Fields.OpQty)
            OpConcept = responseValues(Fields.OpConcept).FromAsciiHex()
            OpCounter = responseValues(Fields.OpCounter).FromAsciiHex()
            OpAmount = responseValues(Fields.OpAmount)
            OpType = responseValues(Fields.OpType)
            OpTransId = responseValues(Fields.OpTransId)
            OpStoreId = responseValues(Fields.OpStoreId)
        End Sub

    End Class

End Namespace