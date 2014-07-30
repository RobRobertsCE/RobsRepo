Imports AdvantageMessaging.Service.Exceptions
Imports AdvantageMessaging.Service.Models

Namespace Service

    Public Class MessageService
        Inherits MessageServiceBase
        Implements IMessageService

#Region " properties "
        ''' <summary>
        ''' Service-specific API endpoint address.
        ''' </summary>
        Public Overrides ReadOnly Property Endpoint As String
            Get
                Return "/api/message/"
            End Get
        End Property

#End Region

#Region " ctor "
        ''' <summary>
        ''' Default ctor for MessageService.
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " IMessageService implementation "
        ''' <summary>
        ''' Returns a list of messages for the given location.
        ''' </summary>
        ''' <param name="locationHash">A unique hash identifying the location.</param>
        Public Overridable Function GetMessages(locationHash As String) As IList(Of MessageListResponseModel) Implements IMessageService.GetMessages

            Dim messageList As New List(Of MessageListResponseModel)

            Try
                If (String.IsNullOrEmpty(locationHash)) Then
                    Throw New ArgumentNullException("locationHash")
                End If

                Dim response As MessageApiBaseModel(Of MessageListResponseModel) = GetResponse(locationHash)

                If (response Is Nothing) Then
                    LogException(New MessageServiceException("Failed to acquire a response from a call to GetMessages API."))
                End If

                If Not (response.error Is Nothing) Then
                    LogApiError(response.error)
                End If

                messageList.AddRange(response.results.ToList())

            Catch ex As Exception
                LogException(ex)

            End Try

            Return messageList

        End Function

#End Region

#Region " protected methods "
        Protected Overridable Function GetResponse(locationHash As String) As MessageApiBaseModel(Of MessageListResponseModel)
            Return MyBase.GetResponseModel(Of MessageApiBaseModel(Of MessageListResponseModel), String)(locationHash)
        End Function

#End Region

    End Class

End Namespace