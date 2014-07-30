Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    ''' <summary>
    ''' API Model for a message location item.
    ''' </summary>
    ''' <remarks></remarks>
    <DataContract()>
    Public Class MessageLocationModel
        Inherits ApiBaseModel

#Region " properties "

        ''' <summary>
        ''' The unique hash for the location.
        ''' </summary>
        <DataMember()>
        Public Property locationHash As String

        ''' <summary>
        ''' The list of users who have viewed the message.
        ''' </summary>
        <DataMember()>
        Public Property readBy As IList(Of MessageViewerModel)

#End Region

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageLocationModel
        ''' </summary>
        ''' <remarks></remarks>
        Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' ctor for MessageLocationModel
        ''' </summary>
        ''' <param name="locationHash">The unique hash for the location.</param>
        Sub New(locationHash As String)
            Me.New()

            Me.locationHash = locationHash
            Me.readBy = New List(Of MessageViewerModel)

        End Sub

        ''' <summary>
        ''' ctor for MessageLocationModel
        ''' </summary>
        ''' <param name="locationHash">The unique hash for the location.</param>
        ''' <param name="readByList">The list of users who have viewed the message.</param>
        Sub New(locationHash As String, readByList As IList(Of MessageViewerModel))
            Me.New(locationHash)

            Me.readBy = readByList

        End Sub

#End Region

    End Class

End Namespace