Imports CTCT
Imports CTCT.Components.Contacts

Namespace Views.Contacts

    Public Class ContactListsView
        Inherits ConstantContaceViewBase

#Region " event signatures "

        Public Event SelectedContactListChanged(sender As Object, list As ContactList)

#End Region

#Region " consts "

        Protected Friend Const ContactListsProperty As String = "ContactLists"

#End Region

#Region " properties "

        Private _contactLists As IList(Of ContactList)
        Public Property ContactLists() As IList(Of ContactList)
            Get
                Return _contactLists
            End Get
            Private Set(ByVal value As IList(Of ContactList))
                _contactLists = value

                OnPropertyChanged(ContactListsProperty)

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

        Private Function LoadContactLists(accountInfo As IConstantContactAccountInfo) As IList(Of ContactList)

            If (accountInfo Is Nothing) Then Return Nothing

            Dim contactLists As IList(Of ContactList) = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(accountInfo.ApiKey, accountInfo.AccessToken)

                contactLists = _constantContact.GetLists(Nothing)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                _constantContact = Nothing

            End Try

            Return contactLists

        End Function

#End Region

#Region " display "

        Private Sub DisplayContactLists(contactLists As IList(Of ContactList))
            ContactListBindingSource.DataSource = contactLists

        End Sub

#End Region

#Region " save "

        Protected Friend Overridable Sub SaveContactLists()

        End Sub

#End Region

#Region " OnPropertyChanged support "

        Protected Friend Overrides Sub OnPropertyChanged(propertyName As String)
            If (propertyName = AccountInfoProperty) Then
                Me.ContactLists = LoadContactLists(Me.AccountInfo)

            ElseIf propertyName = ContactListsProperty Then
                Me.DisplayContactLists(Me.ContactLists)

            Else
                MyBase.OnPropertyChanged(propertyName)

            End If
        End Sub

#End Region

#Region " OnSelectedContactListChanged support "

        Private Sub ContactListDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ContactListDataGridView.SelectionChanged
            If (Me.ContactListDataGridView.SelectedRows.Count < 1) Then Return

            OnSelectedContactListChanged(Me.ContactListDataGridView.SelectedRows(0).DataBoundItem)

        End Sub

        Protected Friend Overridable Sub OnSelectedContactListChanged(selectedList As ContactList)
            RaiseEvent SelectedContactListChanged(Me, selectedList)
        End Sub

#End Region

    End Class

End Namespace