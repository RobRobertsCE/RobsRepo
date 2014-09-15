Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data

    <Table("Restaurant_OpenTabsDiscount")>
    Public Class RestaurantOpenTabsDiscountModel

#Region " properties "

        <Key(), ForeignKey("RestaurantOpenTabsModel"), Column(Order:=0)>
        Public Property RecNo As Integer

        <Key(), Column(Order:=1)>
        Public Property SeqNo As Integer

        <Required()>
        Public Property DiscountId As Guid

        <Required()>
        Public Property Quantity As Integer
        
        Public Property OpenAmount As Decimal?

        <Required()>
        Public Property Amount As Decimal

        <Required()>
        Public Property EmpNo As Integer

        Public Property UsedByEmpNo As Integer?
        
        <StringLength(20)>
        Public Property SourceCode As String

        Public Property UniqueId As Integer?
        
        <StringLength(10)>
        Public Property SeatNo As String

        <ForeignKey("RecNo")>
        Public Overridable Property RestaurantOpenTabs As RestaurantOpenTabsModel

#End Region

#Region " ctor "

        Public Sub New()

        End Sub
        
        Public Sub New(ByVal seatNo As String, ByVal uniqueId As Integer?, ByVal sourceCode As String, ByVal usedByEmpNo As Integer?, ByVal recNo As Integer, ByVal seqNo As Integer, ByVal discountId As Guid, ByVal quantity As Decimal, ByVal openAmount As Decimal?, ByVal amount As Decimal, ByVal empNo As Integer)
            Me.SeatNo = seatNo
            Me.UniqueId = uniqueId
            Me.SourceCode = sourceCode
            Me.UsedByEmpNo = usedByEmpNo
            Me.RecNo = recNo
            Me.SeqNo = seqNo
            Me.DiscountId = discountId
            Me.Quantity = quantity
            Me.OpenAmount = openAmount
            Me.Amount = amount
            Me.EmpNo = empNo
        End Sub

#End Region

    End Class

End Namespace
