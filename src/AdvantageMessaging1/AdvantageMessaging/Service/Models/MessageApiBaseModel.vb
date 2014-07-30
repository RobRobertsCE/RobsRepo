Imports AdvantageApi
Imports System.Runtime.Serialization

Namespace Service.Models

    <DataContract()>
    Public Class MessageApiBaseModel(Of T As Class)
        Inherits ApiListModel(Of T)

#Region " properties "

        <DataMember(EmitDefaultValue:=False)>
        Public Property nextUrl As String = String.Empty

        <DataMember(EmitDefaultValue:=False)>
        Public Property prevUrl As String = String.Empty

#End Region

#Region " ctor "
        ''' <summary>
        ''' Default ctor for InvBarcodeModel
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()
            MyBase.New()
        End Sub
#End Region

    End Class

End Namespace