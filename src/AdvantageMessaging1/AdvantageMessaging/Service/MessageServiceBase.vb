Imports AdvantageApi
Imports AdvantageMessaging.Service.Exceptions
Imports AdvantageMessaging.Service.Models
Imports AdvCommon
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Runtime.Serialization.Json
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json

Namespace Service

    Public MustInherit Class MessageServiceBase
        Implements IDisposable

        Public Shared MessageApiServiceBaseURL As String = "http://localhost:52078"

        ''' <summary>
        ''' Service-specific API endpoint address.
        ''' </summary>
        Public MustOverride ReadOnly Property Endpoint As String

        ''' <summary>
        ''' Logs an exception to the data store.
        ''' </summary>
        ''' <param name="e">The exception to log.</param>
        ''' <remarks></remarks>
        Protected Overridable Sub LogException(e As Exception)
            Logger.LogException(e)
        End Sub

        Protected Overridable Sub LogApiError(e As ApiError)
            Logger.LogMessage(String.Format("API Error: {0} {1}", e.errorCode, e.errorMessage))
        End Sub

        ''' <summary>
        ''' Logs a message to the data store.
        ''' </summary>
        ''' <param name="message">The message to log.</param>
        ''' <remarks></remarks>
        Protected Overridable Sub LogMessage(message As String)
            Logger.LogMessage(message)
        End Sub

        Protected Overridable Function SendRequestModel(Of T As Class)(id As Guid, model As T) As HttpStatusCode
            Dim url = String.Format("{0}{1}", GetURL(), id.ToString())

            Dim request As WebRequest = WebRequest.Create(url)

            Using writeStream As New StreamWriter(request.GetRequestStream(), System.Text.Encoding.GetEncoding("utf-8"))
                Dim json As String = JsonConvert.SerializeObject(model)
                writeStream.Write(json)
                writeStream.Flush()
                writeStream.Close()
            End Using

            Dim response As HttpWebResponse = request.GetResponse()

            Return response.StatusCode

        End Function

        'TODO: Change from param to path 
        Protected Overridable Function GetResponseModel(Of T As Class)(id As Guid) As T
            Dim url = String.Format("{0}?id={1}", GetURL(), id.ToString())

            Dim request As WebRequest = WebRequest.Create(url)

            Using readStream As New StreamReader(request.GetResponse().GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8"))
                Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of T)(readStream.ReadToEnd())
            End Using

        End Function

        Protected Overridable Function GetResponseModel(Of T As Class, P)(queryParam As P) As T
            Dim url = String.Format("{0}?id={1}", GetURL(), queryParam.ToString())

            Dim request As WebRequest = WebRequest.Create(url)

            Using readStream As New StreamReader(request.GetResponse().GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8"))
                Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of T)(readStream.ReadToEnd())
            End Using

        End Function

        Private Function GetURL() As String
            Dim baseURL As String = MessageApiServiceBaseURL
            Dim url As String = String.Format("{0}{1}", baseURL, Endpoint)
            Return url

        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then

                End If

            End If
            Me.disposedValue = True
        End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace

