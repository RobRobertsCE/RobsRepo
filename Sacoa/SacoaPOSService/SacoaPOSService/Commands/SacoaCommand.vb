Imports System.Text

Namespace Commands

    Public MustInherit Class SacoaCommand
        Implements ISacoaCommand

#Region " Properties "

        Private ReadOnly _posId As String = String.Empty
        Public ReadOnly Property PosId As String Implements ISacoaCommand.PosId
            Get
                Return _posId
            End Get
        End Property

        Private ReadOnly _empId As String = String.Empty
        Public ReadOnly Property EmpId As String Implements ISacoaCommand.EmpId
            Get
                Return _empId
            End Get
        End Property

        Public MustOverride ReadOnly Property CommandName As String Implements ISacoaCommand.CommandName

#End Region

#Region " Constructor "

        Protected Friend Sub New(posId As String, empId As String)
            _posId = posId
            _empId = empId
        End Sub

#End Region

#Region " Public Methods "

        Public Overridable Function BuildCommand() As String Implements ISacoaCommand.BuildCommand
            Return FormatCommand()
        End Function

#End Region

#Region " Protected Methods "

        Protected Friend Overridable Function FormatCommand(ParamArray commandData()) As String
            Dim sb As New StringBuilder()
            sb.AppendFormat("{0}, {1}, ", PosId, CommandName)
            For Each item As String In commandData
                sb.AppendFormat("{0}, ", item)
            Next
            sb.AppendFormat("{0}", EmpId)
            Return sb.ToString()
        End Function

#End Region

    End Class

End Namespace
