Imports System.Data
Imports System.Data.SqlClient
Imports PFSConnectLibrary
Imports System.IO
Imports System.Text
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class LocationHashView

#Region " locals "
    Protected Structure LocationHashStruct
        Public Property LocationName As String
        Public Property Address1 As String
        Public Property City As String
        Public Property State As String
        Public Property ZipCode As String
    End Structure

    Private _locations As BindingList(Of LocationHashStruct) = Nothing

#End Region

#Region " load / init "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadLocations()

            locationComboBox.DisplayMember = "LocationName"
            locationComboBox.DataSource = _locations

        Catch ex As Exception
            MessageBox.Show(ex.ToString())

        End Try
    End Sub

    Private Sub LoadLocations()
        Dim builder As New StringBuilder()

        _locations = New BindingList(Of LocationHashStruct)

        Dim sql As String = "SELECT LocationName, Address1, City, State, ZipCode FROM LocationBase"

        Dim dbModel As New DatabaseModel("ceserver", "siteinfo", "sa", "sql")

        Dim cnStr = ConnectionStringFactory.GetSqlConnectionString(dbModel)

        Using cn As New SqlConnection(cnStr)
            cn.Open()

            Using cmd As New SqlCommand(sql, cn)
                Using dr = cmd.ExecuteReader()
                    While dr.Read
                        Dim location As New LocationHashStruct()

                        location.LocationName = dr(0).ToString()
                        location.Address1 = dr(1).ToString()
                        location.City = dr(2).ToString()
                        location.State = dr(3).ToString()
                        location.ZipCode = dr(4).ToString()

                        _locations.Add(location)

                    End While
                End Using
            End Using
        End Using
    End Sub

#End Region

#Region " control event handlers "
    Private Sub locationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles locationComboBox.SelectedIndexChanged
        Me.getHashButton.Enabled = Not (locationComboBox.SelectedItem Is Nothing)
    End Sub

    Private Sub getHashButton_Click(sender As Object, e As EventArgs) Handles getHashButton.Click

        If (locationComboBox.SelectedItem Is Nothing) Then Return

        TextBox1.Text = GetLocationHash(locationComboBox.SelectedItem)

        copyHashButton.Enabled = Not (String.IsNullOrEmpty(TextBox1.Text))

    End Sub

    Private Sub copyHashButton_Click(sender As Object, e As EventArgs) Handles copyHashButton.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

#End Region

#Region " location hash methods "

    Private Function GetLocationHash(location As LocationHashStruct) As String

        Dim builder As New StringBuilder()

        builder.Append(location.LocationName.Trim())
        builder.Append("~"c)
        builder.Append(location.Address1.Trim())
        builder.Append("~"c)
        builder.Append(location.City.Trim())
        builder.Append("~"c)
        builder.Append(location.State.Trim())
        builder.Append("~"c)
        builder.Append(location.ZipCode.Trim())

        Dim bytes() As Byte = Encoding.UTF8.GetBytes(builder.ToString())

        Dim hash As New System.Security.Cryptography.MD5CryptoServiceProvider()
        bytes = hash.ComputeHash(bytes)

        builder = New StringBuilder()

        For Each b As Byte In bytes
            builder.Append(b.ToString("x").PadLeft(2, "0"c))
        Next

        Return builder.ToString()

    End Function

#End Region

End Class
