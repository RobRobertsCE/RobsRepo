Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data

    <Table("Restaurant_OpenTabsDetail")>
    Public Class RestaurantOpenTabsDetailModel

#Region " properties "
        
        <Key(), ForeignKey("RestaurantOpenTabsModel"), Column(Order:=0)>
        Public Property RecNo As Integer

        <Key(), Column(Order:=1)>
        Public Property SeqNo As Integer

        <Required()>
        Public Property InvNo As Integer

        <Required()>
        Public Property Quantity As Integer

        <Required()>
        Public Property HeadCount As Integer

        <Required()>
        Public Property Price As Decimal

        <Required()>
        Public Property Linked As Boolean = False

        <Required()>
        Public Property Split As Boolean = False

        <Required()>
        Public Property SplitMaster As Boolean = False

        Public Property ModifierInfo As Integer? = 0

        <Required()>
        Public Property EmpNo As Integer

        Public Property LockItem As Boolean = False

        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property AddDateTime As DateTime

        Public Property NoteIdent As Boolean?

        Public Property Note As String

        <DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property SeqId As Guid

        Public Property Half As Integer
        
        <StringLength(10)>
        Public Property SeatNo As String

        Public Property Stopped As Boolean = False

        <ForeignKey("RecNo")>
        Public Property RestaurantOpenTabs As RestaurantOpenTabsModel
        
#End Region

#Region " ctor "

        Public Sub New()

        End Sub
        
        Public Sub New(ByVal recNo As Integer, ByVal seqNo As Integer, ByVal invNo As Integer, ByVal quantity As Integer, ByVal headCount As Integer, ByVal price As Decimal, ByVal linked As Boolean, ByVal split As Boolean, ByVal splitMaster As Boolean, ByVal modifierInfo As Integer?, ByVal empNo As Integer, ByVal lockItem As Boolean, ByVal addDateTime As Date, ByVal noteIdent As Boolean?, ByVal note As String, ByVal seqId As Guid, ByVal half As Integer, ByVal seatNo As String, ByVal stopped As Boolean)
            Me.RecNo = recNo
            Me.SeqNo = seqNo
            Me.InvNo = invNo
            Me.Quantity = quantity
            Me.HeadCount = headCount
            Me.Price = price
            Me.Linked = linked
            Me.Split = split
            Me.SplitMaster = splitMaster
            Me.ModifierInfo = modifierInfo
            Me.EmpNo = empNo
            Me.LockItem = lockItem
            Me.AddDateTime = addDateTime
            Me.NoteIdent = noteIdent
            Me.Note = note
            Me.SeqId = seqId
            Me.Half = half
            Me.SeatNo = seatNo
            Me.Stopped = stopped
        End Sub

#End Region

    End Class

End Namespace