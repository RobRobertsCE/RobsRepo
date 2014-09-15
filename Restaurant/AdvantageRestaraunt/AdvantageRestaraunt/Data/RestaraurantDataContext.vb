Imports System.Data.Entity

Namespace Data

    Public Class RestaraurantDbContext
        Inherits DbContext
        'Inherits AdvantageDbContext

        Public Overridable Property RestaurantDefaults As DbSet(Of RestaurantDefaultsModel)
        Public Overridable Property RestaurantGratuities As DbSet(Of RestaurantGratuityModel)
        Public Overridable Property RestaurantOpenTabs As DbSet(Of RestaurantOpenTabsModel)
        Public Overridable Property RestaurantOpenTabsDetails As DbSet(Of RestaurantOpenTabsDetailModel)
        Public Overridable Property RestaurantOpenTabsDiscounts As DbSet(Of RestaurantOpenTabsDiscountModel)

#Region "Constructors"

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(cn As ConnectionInfo)
            MyBase.New(cn)
        End Sub

#End Region

        Public Class ConnectionInfo
            'REMOVE THIS CLASS FOR PRODUCTION
            Public cn As New System.Data.SqlClient.SqlConnection

            Public Shared Narrowing Operator CType(ByVal cn As ConnectionInfo) As System.Data.SqlClient.SqlConnection
                Return cn.cn
            End Operator
            Public Shared Narrowing Operator CType(ByVal cn As ConnectionInfo) As String
                Return cn.cn.ToString()
            End Operator
        End Class


    End Class

End Namespace