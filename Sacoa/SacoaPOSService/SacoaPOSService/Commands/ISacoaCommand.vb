﻿Namespace Commands

    Public Interface ISacoaCommand

        ReadOnly Property PosId As String
        ReadOnly Property CommandName As String
        ReadOnly Property EmpId As String

        Function BuildCommand() As String

    End Interface

End Namespace
