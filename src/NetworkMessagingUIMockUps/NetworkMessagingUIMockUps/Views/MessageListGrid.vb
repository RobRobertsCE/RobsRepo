Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class MessageListGrid

    Public Event MessageSelected(sender As Object, e As EventArgs)

    Private Enum GridColumns
        Id = 0
        Timestamp
        Subject
        IsUnread
    End Enum

    Private Const MessageIsUnread As Boolean = True
    Private Const MessageIsNotUnread As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MessageGrid_InitializeRow(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles MessageGrid.InitializeRow
        If (e.Row.Cells(GridColumns.IsUnread).Value = MessageIsUnread) Then
            e.Row.Appearance.FontData.Bold = DefaultableBoolean.True
        Else
            e.Row.Appearance.FontData.Bold = DefaultableBoolean.False
        End If
    End Sub

    Private Sub MessageGrid_BeforeRowActivate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles MessageGrid.BeforeRowActivate
        SetRowState(e.Row)
    End Sub

    Private Sub SetRowState(row As UltraGridRow)
        If (row.Cells(GridColumns.IsUnread).Value = MessageIsUnread) Then

            row.Cells(GridColumns.IsUnread).Value = MessageIsNotUnread

            row.Appearance.FontData.Bold = DefaultableBoolean.False

            RaiseEvent MessageSelected(row.Cells(GridColumns.Id).Value, EventArgs.Empty)

        Else
            row.Appearance.FontData.Bold = DefaultableBoolean.False

        End If
    End Sub

    Private Sub MessageGrid_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles MessageGrid.AfterSelectChange
        If (MessageGrid.Selected.Rows.Count < 1) Then Return

        RaiseEvent MessageSelected(MessageGrid.Selected.Rows(0).Cells(GridColumns.Id).Value, EventArgs.Empty)

    End Sub
End Class
