Imports BulkMailLibrary.ConstantContact.Views
Imports CTCT.Components.Activities

Namespace Views.Activities

    Public Class ActivityView
        Inherits ConstantContaceViewBase

#Region " consts "

        Protected Friend Const ActivityListProperty As String = "ActivityList"

#End Region

#Region " properties "

        Private _activityList As IList(Of Activity)
        Public Property ActivityList() As IList(Of Activity)
            Get
                Return _activityList
            End Get
            Set(ByVal value As IList(Of Activity))
                _activityList = value

                OnPropertyChanged(ActivityListProperty)

            End Set
        End Property

#End Region

#Region " ctor "

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region

#Region " load "

        Private Function LoadActivityList(accountInfo As IConstantContactAccountInfo) As IList(Of Activity)
            Dim activityList As IList(Of Activity) = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(accountInfo.ApiKey, accountInfo.AccessToken)

                activityList = _constantContact.GetActivities()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                _constantContact = Nothing

            End Try

            Return activityList

        End Function

#End Region

#Region " display "

        Private Sub DisplayActivityList(activityList As IList(Of Activity))
            ActivityBindingSource.DataSource = activityList

        End Sub

#End Region

#Region " OnPropertyChanged support "

        Protected Friend Overrides Sub OnPropertyChanged(propertyName As String)
            If (propertyName = AccountInfoProperty) Then
                Me.ActivityList = LoadActivityList(Me.AccountInfo)

            ElseIf propertyName = ActivityListProperty Then
                Me.DisplayActivityList(Me.ActivityList)

            Else
                MyBase.OnPropertyChanged(propertyName)

            End If
        End Sub

#End Region

        Private Sub ActivityDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ActivityDataGridView.SelectionChanged

            If (ActivityDataGridView.SelectedRows.Count < 1) Then Return



        End Sub
    End Class

End Namespace