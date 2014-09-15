Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports System.Data

Public Class ReportClass
    Private _report As ReportDocument
    Public Property Report() As ReportDocument
        Get
            Return _report
        End Get
        Set(ByVal value As ReportDocument)
            _report = value
        End Set
    End Property


    Sub New()
        _report = New ReportDocument()
        _report.Load("C:\PFSCommon\Reports\Custom Reports\Payroll Summary by Department - iPlay.rpt")

    End Sub
End Class
