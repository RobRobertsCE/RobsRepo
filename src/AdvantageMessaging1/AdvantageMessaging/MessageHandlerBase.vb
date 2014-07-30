Imports AdvCommon
Imports System.Text
Imports AdvantageMessaging.Data

''' <summary>
''' Base class for MessageHandler classes, implements common data and exception handling functionality.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class MessageHandlerBase
    Implements IDisposable

#Region " protected fields "
    ''' <summary>
    ''' The employee number of the employee associated with this instance of MessageHandler.
    ''' </summary>
    Protected ReadOnly EmployeeNumber As Integer = -1

#End Region

#Region " private fields "
    ''' <summary>
    ''' The DbContext instance used by this instance of MessageHandler.
    ''' </summary>
    Private _dbContext As MessageDataContext = Nothing

    ''' <summary>
    ''' Flag indicating that this instance owns the dbcontext instance.
    ''' </summary>
    ''' <remarks></remarks>
    Private _ownsContext As Boolean = False

#End Region

#Region " properties "
    ''' <summary>
    ''' The DbContext instance used by this instance of MessageHandler.
    ''' </summary>
    Protected Overridable ReadOnly Property DbContext As MessageDataContext
        Get
            If (_dbContext Is Nothing) Then
                _dbContext = New MessageDataContext()
                _ownsContext = True
            End If
            Return _dbContext
        End Get
    End Property

#End Region

#Region " ctor "
    ''' <summary>
    ''' Protected constructor for MessageHandler.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    Protected Sub New(employeeNumber As Integer)
        Me.EmployeeNumber = employeeNumber
    End Sub

    ''' <summary>
    ''' Protected constructor for MessageHandler.
    ''' </summary>
    Protected Sub New()

    End Sub

    ''' <summary>
    ''' Protected constructor for MessageHandlerBase.
    ''' </summary>
    ''' <param name="employeeNumber">The employee number of the employee associated with this instance of MessageHandler.</param>
    ''' <param name="dbContext">External MessageDataContext to use as the data store.</param>
    ''' <remarks></remarks>
    Protected Sub New(employeeNumber As Integer, dbContext As MessageDataContext)
        Me.New(employeeNumber)
        _dbContext = dbContext
        _ownsContext = False
    End Sub

#End Region

#Region " protected methods "
    ''' <summary>
    ''' Logs an exception to the data store.
    ''' </summary>
    ''' <param name="e">The exception to log.</param>
    ''' <remarks></remarks>
    Protected Overridable Sub LogException(e As Exception)
        Logger.LogException(e)
    End Sub

    ''' <summary>
    ''' Logs a message to the data store.
    ''' </summary>
    ''' <param name="message">The message to log.</param>
    ''' <remarks></remarks>
    Protected Overridable Sub LogMessage(message As String)
        Logger.LogMessage(message)
    End Sub

    ''' <summary>
    ''' Returns the Employee Name for the given EmployeeNumber.
    ''' </summary>
    ''' <param name="employeeNo">Unique number for an employee.</param>
    Protected Overridable Function GetEmployeeName(employeeNo As Integer) As String
        Return AdvCommonCtrls.Get_EmpName(employeeNo)
    End Function

#End Region

#Region " location hash methods "
    Protected Structure LocationHashStruct
        Public Property LocationName As String
        Public Property Address1 As String
        Public Property City As String
        Public Property State As String
        Public Property ZipCode As String
    End Structure

    Private Shared _locationHash As String = String.Empty

    Protected Overridable Function GetLocationHash() As String

        If String.IsNullOrEmpty(_locationHash) Then
            Dim location As LocationHashStruct
            Dim query As System.Data.Entity.Infrastructure.DbRawSqlQuery(Of LocationHashStruct)

            Dim sql As String = "SELECT LocName AS LocationName, Address1, City, State, ZipCode FROM ApplicationInfo"

            Using dbContext As New MessageDataContext()
                query = dbContext.Database.SqlQuery(Of LocationHashStruct)(sql)

                If (query Is Nothing) OrElse (query.Count = 0) Then
                    Throw New InvalidOperationException("Could not locate Location information in database.")
                End If

                location = query.First()

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

                _locationHash = builder.ToString()

            End Using

        End If

        Return _locationHash

    End Function

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If (_ownsContext) AndAlso Not _dbContext Is Nothing Then
                    _dbContext.Dispose()
                End If
            End If

        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
