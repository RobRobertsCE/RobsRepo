Imports System.Text

Namespace Commands

    Public MustInherit Class SecoaCommand
        Implements ISecoaCommand

#Region " Properties "

        Private ReadOnly _posId As String = String.Empty
        Public ReadOnly Property PosId As String Implements ISecoaCommand.PosId
            Get
                Return _posId
            End Get
        End Property

        Private ReadOnly _empId As String = String.Empty
        Public ReadOnly Property EmpId As String Implements ISecoaCommand.EmpId
            Get
                Return _empId
            End Get
        End Property

        Public MustOverride ReadOnly Property CommandName As String Implements ISecoaCommand.CommandName

#End Region

#Region " Constructor "

        Protected Friend Sub New(posId As String, empId As String)
            _posId = posId
            _empId = empId
        End Sub

#End Region

#Region " Public Methods "

        Public Overridable Function BuildCommand() As String Implements ISecoaCommand.BuildCommand
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
