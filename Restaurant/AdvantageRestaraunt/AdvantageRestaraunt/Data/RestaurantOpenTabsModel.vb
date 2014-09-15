Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data

    <Table("Restaurant_OpenTabs")>
    Public Class RestaurantOpenTabsModel

#Region " properties "
        
        <Key(), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property RecNo As Integer

        <Required()>
        Public Property CreateDateTime As DateTime

        <Required()>
        Public Property EmpNo As Integer

        <Required()>
        Public Property TableNo As Integer

        <StringLength(50)>
        Public Property Description As String

        <Required()>
        Public Property NumberOfGuests As Integer

        <Required()>
        Public Property Amount As Decimal

        Public Property CheckClosed As Boolean = False

        <Required()>
        Public Property TillGUID As Guid

        Public Property OpenedAtStationNo As Integer?

        Public Property OpenedByEmpNo As Integer?

        <Required()>
        Public Property DivNo As Integer

        Public Property AutoGratuityPercent As Decimal = 0D

        Public Overridable Property Details As IList(Of RestaurantOpenTabsDetailModel)
        
        Public Overridable Property Discounts As IList(Of RestaurantOpenTabsDiscountModel)

#End Region

#Region " ctor "

        Public Sub New()

        End Sub
        
        Public Sub New(ByVal recNo As Integer, ByVal autoGratuityPercent As Decimal, ByVal divNo As Integer, ByVal openedByEmpNo As Integer?, ByVal openedAtStationNo As Integer?, ByVal tillGUID As Guid, ByVal checkClosed As Boolean, ByVal amount As Decimal, ByVal numberOfGuests As Integer, ByVal description As String, ByVal empNo As Integer, ByVal createDateTime As Date, ByVal tableNo As Integer)
            Me.RecNo = recNo
            Me.AutoGratuityPercent = autoGratuityPercent
            Me.DivNo = divNo
            Me.OpenedByEmpNo = openedByEmpNo
            Me.OpenedAtStationNo = openedAtStationNo
            Me.TillGUID = tillGUID
            Me.CheckClosed = checkClosed
            Me.Amount = amount
            Me.NumberOfGuests = numberOfGuests
            Me.Description = description
            Me.EmpNo = empNo
            Me.CreateDateTime = createDateTime
            Me.TableNo = tableNo
        End Sub

#End Region

    End Class

End Namespace
