Imports AdvantageMessaging.Service.Exceptions
Imports AdvantageMessaging.Service.Models

Namespace Service

    Public Class MessageBodyService
        Inherits MessageServiceBase
        Implements IMessageBodyService

#Region " properties "
        ''' <summary>
        ''' Service-specific API endpoint address.
        ''' </summary>
        Public Overrides ReadOnly Property Endpoint As String
            Get
                Return "/api/messagebody/"
            End Get
        End Property

#End Region

#Region " ctor "
        ''' <summary>
        ''' Default ctor for MessageBodyService.
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " IMessageBodyService implementation "
        ''' <summary>
        ''' Gets the message body for the given messageId.
        ''' </summary>
        ''' <param name="messageId">The messageId value to get the message body for.</param>
        Public Overridable Function GetMessageBody(messageId As Guid) As String Implements IMessageBodyService.GetMessageBody
            Dim messageBody As String = String.Empty

            Try
                If (Guid.Empty.Equals(messageId)) Then
                    Throw New ArgumentNullException("messageId")
                End If

                Dim response As MessageApiBaseModel(Of MessageBodyResponseModel) = GetResponse(messageId)

                If (response Is Nothing) Then
                    LogException(New MessageServiceException("Failed to acquire a response from a call to MessageBody API."))
                End If

                If Not (response.error Is Nothing) Then
                    LogMessage(response.error.errorMessage)
                End If

                If (response.count <= 0) Then
                    LogException(New MessageServiceException(String.Format("Failed to acquire a body for messageId {0}.", messageId.ToString())))
                End If

                messageBody = response.results(0).body

            Catch ex As Exception
#If DEBUG Then
                Console.WriteLine(ex.ToString())
#Else
                LogException(ex)
#End If

            End Try

            Return messageBody

        End Function

#End Region

#Region " protected methods "
        Protected Overridable Function GetResponse(messageId As Guid) As MessageApiBaseModel(Of MessageBodyResponseModel)
            Return MyBase.GetResponseModel(Of MessageApiBaseModel(Of MessageBodyResponseModel))(messageId)
        End Function

#End Region

    End Class

End Namespace