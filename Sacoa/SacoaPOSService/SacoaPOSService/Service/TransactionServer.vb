Imports SacoaInterface.My.Resources
Imports SacoaInterface.Response
Imports SacoaInterface.Request
Imports System.Threading

Namespace Service


    Public MustInherit Class SacoaTransactionServer
        Implements ISacoaTransactionServer, IDisposable

#Region " Constructor "

        ''' <summary>
        ''' Protected friend ctor for SacoaTransactionServer
        ''' </summary>
        Protected Friend Sub New()

        End Sub

#End Region

#Region " Public SendCommand/SendRequestAsync "

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="request"></param>
        ''' <param name="callback"></param>
        ''' <remarks></remarks>
        Public Overridable Sub SendRequestAsync(request As ISacoaRequest, callback As SacoaResponseDelegate) Implements ISacoaTransactionServer.SendRequestAsync
            Try
                Dim commandThread As New Thread(Sub() SendAsync(request, callback))
                commandThread.Start()
            Catch ex As Exception
                Throw New Exception(String.Format(Error_sending_request___0_, ex.Message))
            End Try
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="request"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Function SendRequest(request As ISacoaRequest) As ISacoaResponse Implements ISacoaTransactionServer.SendRequest
            Try
                Return Send(request)
            Catch ex As Exception
                Throw New Exception(String.Format(Error_sending_request___0_, ex.Message))
            End Try
        End Function

#End Region

#Region " Send/SendAsync "

        Protected Friend Overridable Sub SendAsync(request As ISacoaRequest, callback As SacoaResponseDelegate)
            Dim response = Send(request)
            callback.Invoke(response)
        End Sub

        Protected Friend Overridable Function Send(request As ISacoaRequest) As ISacoaResponse
            Dim requestString As String = GetRequestString(request)
            Dim responseString = SendSacoaRequest(requestString)
            Return SacoaResponseFactory.GetResponse(responseString)
        End Function

#End Region

#Region " Protected Friend Methods "

        Protected Friend Overridable Function GetRequestString(request As ISacoaRequest) As String
            Return request.BuildRequest()
        End Function

        Protected Friend MustOverride Function SendSacoaRequest(requestString As String) As String

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