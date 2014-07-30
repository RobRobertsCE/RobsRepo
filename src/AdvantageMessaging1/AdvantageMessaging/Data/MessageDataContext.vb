Imports AdvantageDataLayer
Imports AdvantageShared
Imports System.Data.Entity

Namespace Data

    ''' <summary>
    ''' Data access layer for the messaging system
    ''' </summary>
    ''' <remarks>Designed to handle SiteInfo to Location messages and Ads.</remarks>
    Public Class MessageDataContext
        Inherits AdvantageDbContext

        ''' <summary>
        ''' The collection of messages associated with this data source.
        ''' </summary>
        Public Overridable Property Messages As DbSet(Of MessageModel)

        ''' <summary>
        ''' The collection of message schedules associated with this data store.
        ''' </summary>
        Public Overridable Property MessageSchedules As DbSet(Of MessageScheduleModel)

        ''' <summary>
        ''' The collection of scheduled message views associated with this data store.
        ''' </summary>
        Public Overridable Property MessageEmployees As DbSet(Of MessageEmployeeModel)

#Region " ctor "

        ''' <summary>
        ''' Default ctor for MessageDataContext
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            MyBase.New()
        End Sub

        ''' <summary>
        ''' ctor for MessageDataContext
        ''' </summary>
        ''' <param name="cn">The ConnectionInfo instance to use in connecting to the data store.</param>
        ''' <remarks></remarks>
        Public Sub New(cn As ConnectionInfo)
            MyBase.New(cn)
        End Sub

#End Region

    End Class

End Namespace