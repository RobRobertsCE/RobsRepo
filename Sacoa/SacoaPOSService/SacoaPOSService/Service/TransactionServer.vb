Imports System.Threading
Imports SacoaPOSService.Commands
Imports SacoaPOSService.Responses
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text



Namespace Service

    Public MustInherit Class SecoaTransactionServer
        Implements ISecoaTransactionServer, IDisposable

#Region " Constructor "

        ''' <summary>
        ''' Protected friend ctor for SecoaTransactionServer
        ''' </summary>
        Protected Friend Sub New()

        End Sub

#End Region

#Region " Public SendCommand/SendCommandAsync "

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="command"></param>
        ''' <param name="callback"></param>
        ''' <remarks></remarks>
        Public Overridable Sub SendCommandAsync(command As ISecoaCommand, callback As SecoaResponseDelegate) Implements ISecoaTransactionServer.SendCommandAsync
            Try
                Dim commandThread As New Thread(Sub() SendAsync(command, callback))
                commandThread.Start()
            Catch ex As Exception
                Throw New Exception("Error sending command: " & ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="command"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function SendCommand(command As ISecoaCommand) As ISecoaResponse Implements ISecoaTransactionServer.SendCommand
            Try
                Return Send(command)
            Catch ex As Exception
                Throw New Exception("Error sending command: " & ex.Message)
            End Try
        End Function

#End Region

#Region " Send/SendAsync "

        Protected Friend Overridable Sub SendAsync(command As ISecoaCommand, callback As SecoaResponseDelegate)
            Dim response = Send(command)
            callback.Invoke(response)
        End Sub

        Protected Friend Overridable Function Send(command As ISecoaCommand) As ISecoaResponse
            Dim commandString As String = GetCommandString(command)
            Dim responseString = SendSecoaCommand(commandString)
            Return SecoaResponseFactory.GetResponse(responseString)
        End Function

#End Region

#Region " Protected Friend Methods "

        Protected Friend Overridable Function GetCommandString(command As ISecoaCommand) As String
            Return command.BuildCommand()
        End Function

        Protected Friend MustOverride Function SendSecoaCommand(commandString As String) As String

#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace