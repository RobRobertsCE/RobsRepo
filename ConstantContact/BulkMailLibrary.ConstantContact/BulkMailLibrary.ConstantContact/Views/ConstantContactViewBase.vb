Imports System.ComponentModel

Namespace Views

    Public Class ConstantContaceViewBase
        Implements INotifyPropertyChanged

#Region " event signatures "

        Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

#End Region

#Region " consts "

        Protected Friend Const AccountInfoProperty As String = "AccountInfo"

#End Region

#Region " fields "

        Protected _constantContact As CTCT.ConstantContact = Nothing

#End Region

#Region " properties "

        Private _accountInfo As IConstantContactAccountInfo
        Public Property AccountInfo() As IConstantContactAccountInfo
            Get
                Return _accountInfo
            End Get
            Set(ByVal value As IConstantContactAccountInfo)
                _accountInfo = value
                OnPropertyChanged(AccountInfoProperty)
            End Set
        End Property

#End Region

#Region " ctor "
        Protected Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region

#Region " INotifyPropertyChanged support "

        Protected Friend Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub


#End Region

    End Class

End Namespace