Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    ''' <summary>
    ''' API Model for a message status update item.
    ''' </summary>
    ''' <remarks></remarks>
    <DataContract()>
    Public Class MessageStatRequestModel
        Inherits ApiBaseModel

#Region " properties "

        ''' <summary>
        ''' The list of locations to update the stats for the message.
        ''' </summary>
        <DataMember()>
        Public Property locations As IList(Of MessageLocationModel)

#End Region

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageStatRequestModel
        ''' </summary>
        ''' <remarks></remarks>
        Sub New()
            MyBase.New()

            locations = New List(Of MessageLocationModel)

        End Sub

        ''' <summary>
        ''' ctor for MessageStatRequestModel
        ''' </summary>
        ''' <param name="locations">The list of locations to update the stats for the message.</param>
        ''' <remarks></remarks>
        Sub New(locations As IList(Of MessageLocationModel))
            Me.New()

            Me.locations = locations

        End Sub

        ''' <summary>
        ''' ctor for MessageStatRequestModel
        ''' </summary>
        ''' <param name="location">The location to update the stats for the message.</param>
        ''' <remarks></remarks>
        Sub New(location As MessageLocationModel)
            Me.New()

            Me.locations = locations

        End Sub

#End Region

    End Class

End Namespace

