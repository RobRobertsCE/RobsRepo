Imports CTCT
Imports CTCT.Components.AccountService

Namespace Views.AccountServices
    
    Public Class AccountServicesView

#Region " consts "

        Protected Friend Const AccountSummaryInfoProperty As String = "AccountSummaryInfo"

#End Region

#Region " properties "
        
        Private _accountSummaryInfo As AccountSummaryInformation
        Public Property AccountSummaryInfo() As AccountSummaryInformation
            Get
                Return _accountSummaryInfo
            End Get
            Private Set(ByVal value As AccountSummaryInformation)
                _accountSummaryInfo = value

                OnPropertyChanged(AccountSummaryInfoProperty)

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

        Private Function LoadAccountSummary(accountInfo As IConstantContactAccountInfo) As AccountSummaryInformation

            Dim account As AccountSummaryInformation = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(accountInfo.ApiKey, accountInfo.AccessToken)

                account = _constantContact.GetAccountSummaryInformation()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                _constantContact = Nothing

            End Try

            Return account

        End Function

#End Region

#Region " display "

        Private Sub DisplayAccountSummary(accountSummaryInfo As AccountSummaryInformation)
            AccountSummaryInformationBindingSource.DataSource = accountSummaryInfo
            ApiKeyTextBox.Text = Me.AccountInfo.ApiKey
        End Sub

#End Region

#Region " save "

        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
            SaveAccountSummary()
        End Sub

        Private Sub SaveAccountSummary()

            Dim account As AccountSummaryInformation = Nothing

            Try
                _constantContact = New CTCT.ConstantContact(AccountInfo.ApiKey, AccountInfo.AccessToken)

                _constantContact.PutAccountSummaryInformation(Me.AccountSummaryInfo)

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
                Me.AccountSummaryInfo = LoadAccountSummary(Me.AccountInfo)

            ElseIf propertyName = AccountSummaryInfoProperty Then
                Me.DisplayAccountSummary(Me.AccountSummaryInfo)

            Else
                MyBase.OnPropertyChanged(propertyName)

            End If
        End Sub

#End Region

    End Class

End Namespace