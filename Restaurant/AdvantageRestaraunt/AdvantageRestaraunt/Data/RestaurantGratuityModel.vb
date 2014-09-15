Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data

    <Table("Restaurant_Gratuity")>
    Public Class RestaurantGratuityModel

#Region " properties "

        <Key(), Column(Order:=0)>
        Public Property ShiftDate As DateTime

        <Key(), Column(Order:=1)>
        Public Property DivNo As Integer

        <Key(), Column(Order:=2)>
        Public Property TillId As Integer

        Public Property Amount As Decimal?

#End Region

#Region " ctor "

        Sub New()

        End Sub

        Sub New(shiftDate As DateTime, divNo As Integer, tillId As Integer, amount As Decimal?)
            Me.ShiftDate = shiftDate
            Me.DivNo = divNo
            Me.TillId = tillId
            Me.Amount = amount
        End Sub

#End Region

    End Class

End Namespace