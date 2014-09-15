Imports CTCT.Components.Contacts
Imports System.Collections.ObjectModel

Namespace Business
    
    Public Class ContactDisplayModel

#Region " properties "

        Public Property Id As String

        Public Property FirstName As String

        Public Property LastName As String

        Public Property EMailAddress As String

        Public Property Status As String

        Public Property DateCreated As DateTime

        Public Property DateModified As DateTime

        Public Property CustomerKey As String

        Public Property CustomFields As New Dictionary(Of String, String)

        Public Property ContactListIds As New List(Of String)

#End Region

#Region " ctor "

        Public Sub New(contact As Contact)

            Id = contact.Id
            FirstName = contact.FirstName
            LastName = contact.LastName
            Status = contact.Status
            DateCreated = contact.DateCreated
            DateModified = contact.DateModified

            If contact.EmailAddresses.Count > 0 Then
                EMailAddress = contact.EmailAddresses(0).EmailAddr
            End If

            If contact.CustomFields.Count > 0 Then
                CustomerKey = contact.CustomFields(0).Value
            End If

            For Each customField As CustomField In contact.CustomFields
                CustomFields.Add(customField.Name, customField.Value)
            Next

            For Each contactList As ContactList In contact.Lists
                ContactListIds.Add(contactList.Id)
            Next

        End Sub

#End Region

    End Class

End Namespace