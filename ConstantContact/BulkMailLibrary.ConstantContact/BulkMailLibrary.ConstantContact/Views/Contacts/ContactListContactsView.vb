Imports BulkMailLibrary.ConstantContact.Views
Imports BulkMailLibrary.ConstantContact.Business
Imports CTCT.Components.Contacts
Imports System.Collections.ObjectModel

Namespace Views.Contacts
    
    Public Class ContactListContactsView
        Inherits ConstantContaceViewBase

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        Public Sub New(contacts As IList(Of Contact))

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            ContactDisplayModelBindingSource.DataSource = contacts.Select(Function(c) New ContactDisplayModel(c))

        End Sub

    End Class

End Namespace