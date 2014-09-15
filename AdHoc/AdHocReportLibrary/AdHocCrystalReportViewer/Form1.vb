Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim rtp As New AdHocReportLibrary.ReportClass()


        Me.CrystalReportViewer1.ReportSource = ""

    End Sub
End Class
