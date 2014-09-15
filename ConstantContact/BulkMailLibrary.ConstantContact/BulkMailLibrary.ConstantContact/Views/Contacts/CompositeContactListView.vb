Namespace Views

    Public Class CompositeContactListView
        Inherits ConstantContaceViewBase

#Region " ctor "

        Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region

#Region " OnPropertyChanged support "

        Protected Friend Overrides Sub OnPropertyChanged(propertyName As String)
            If (propertyName = AccountInfoProperty) Then
                Me.ContactListsView1.AccountInfo = (Me.AccountInfo)
                Me.ContactListView1.AccountInfo = (Me.AccountInfo)

            Else
                MyBase.OnPropertyChanged(propertyName)

            End If
        End Sub

#End Region

#Region " SelectedContactListChanged handler "

        Private Sub ContactListsView1_SelectedContactListChanged(sender As Object, list As CTCT.Components.Contacts.ContactList) Handles ContactListsView1.SelectedContactListChanged
            Me.ContactListView1.ContactList = list

        End Sub

#End Region
       
    End Class

End Namespace