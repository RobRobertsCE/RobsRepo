Imports AdvantageApi
Imports AdvantageMessaging.Service.Exceptions
Imports AdvantageMessaging.Service.Models
Imports System.Net

Namespace Service

    Public Class MessageStatsService
        Inherits MessageServiceBase
        Implements IMessageStatsService

#Region " properties "
        ''' <summary>
        ''' Service-specific API endpoint address.
        ''' </summary>
        Public Overrides ReadOnly Property Endpoint As String
            Get
                Return "/api/messagestats/"
            End Get
        End Property

#End Region

#Region " ctor "
        ''' <summary>
        ''' Default ctor for MessageStatsService.
        ''' </summary>
        Public Sub New()
            MyBase.New()
        End Sub

#End Region

#Region " IMessageStatsService implementation "
        ''' <summary>
        ''' Updates the message stats for the given messageScheduleId.
        ''' </summary>
        ''' <param name="requestModel">The MessageStatRequestModel containing the information to update the remote data store with.</param>
        Public Overridable Sub UpdateMessageStats(id As Guid, requestModel As MessageStatRequestModel) Implements IMessageStatsService.UpdateMessageStats
            Try
                If (requestModel Is Nothing) Then
                    Throw New ArgumentNullException("requestModel")
                End If

                Dim response As HttpStatusCode = SendRequest(id, requestModel)

                If Not (response = HttpStatusCode.OK) Then
                    LogApiError(New ApiError() With {.errorMessage = String.Format("An error occurred updating message stats. API returned a status of {0}.", response)})
                End If

            Catch ex As Exception
                LogException(ex)

            End Try

        End Sub

#End Region

#Region " protected methods "
        Protected Overridable Function SendRequest(id As Guid, locations As MessageStatRequestModel) As HttpStatusCode
            MyBase.SendRequestModel(id, locations)
        End Function

#End Region

    End Class

End Namespace