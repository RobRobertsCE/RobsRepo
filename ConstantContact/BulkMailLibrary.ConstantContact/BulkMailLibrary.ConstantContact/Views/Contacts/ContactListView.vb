Imports CTCT.Components.AccountService
Imports CTCT
Imports CTCT.Components.Contacts

Namespace Views.Contacts

    Public Class ContactListView
        Inherits ConstantContaceViewBase

#Region " consts "

        Protected Friend Const ContactListProperty As String = "ContactList"

#End Region

#Region " properties "

        Private _contactList As ContactList
        Public Property ContactList() As ContactList
            Get
                Return _contactList
            End Get
            Set(ByVal value As ContactList)
                _contactList = value

                OnPropertyChanged(ContactListProperty)

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

        Private Function LoadContactList(id As String, accountInfo As IConstantContactAccountInfo) As ContactList
            Dim contactList As ContactList = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(accountInfo.ApiKey, accountInfo.AccessToken)

                contactList = _constantContact.GetList(id)

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                _constantContact = Nothing

            End Try

            Return contactList

        End Function

#End Region

#Region " display "

        Private Sub DisplayContactList(contactList As ContactList)
            ContactListBindingSource.DataSource = contactList

        End Sub

#End Region

#Region " save "

        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
            SaveContactList()

        End Sub

        Protected Friend Overridable Sub SaveContactList()

            Dim account As AccountSummaryInformation = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(AccountInfo.ApiKey, AccountInfo.AccessToken)

                _constantContact.UpdateList(Me.ContactList)

                MessageBox.Show("Saved")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                _constantContact = Nothing

            End Try

        End Sub

#End Region

#Region " OnPropertyChanged support "

        Protected Friend Overrides Sub OnPropertyChanged(propertyName As String)
            If (propertyName = AccountInfoProperty) Then
              
            ElseIf propertyName = ContactListProperty Then
                Me.DisplayContactList(Me.ContactList)

            Else
                MyBase.OnPropertyChanged(propertyName)

            End If
        End Sub

#End Region

    End Class

End Namespace