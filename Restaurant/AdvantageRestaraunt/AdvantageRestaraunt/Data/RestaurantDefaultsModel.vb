Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Data

    <Table("Restaurant_Defaults")>
    Public Class RestaurantDefaultsModel

#Region " properties "

        <Key(), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property KeyId As Integer

        <StringLength(10), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property ServersAreCalled As String

        <StringLength(10), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property TablesAreCalled As String
        
        <StringLength(10), DatabaseGenerated(DatabaseGeneratedOption.None)>
        Public Property GuestsAreCalled As String

        Public Property AutoDesc As Boolean?

#End Region

#Region " ctor "

        Sub New()

        End Sub

        Sub New(serversAreCalled As String, tablesAreCalled As String, guestsAreCalled As String, autoDesc As Boolean?)
            Me.ServersAreCalled = serversAreCalled
            Me.TablesAreCalled = tablesAreCalled
            Me.GuestsAreCalled = guestsAreCalled
            Me.AutoDesc = autoDesc
        End Sub

#End Region

    End Class

End Namespace