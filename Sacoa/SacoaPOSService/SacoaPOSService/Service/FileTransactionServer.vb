Imports SacoaService.Request
Imports SacoaService.Responses
Imports System
Imports System.IO
Imports System.Text

Namespace Service

    Public Class FileTransactionServer
        Inherits SacoaTransactionServer
        Implements ISacoaTransactionServer

#Region " Constants "

        Private Const CommandFileExtension As String = ".Cmd"
        Private Const RequestFileExtension As String = ".Req"
        Private Const ResponseFileExtension As String = ".Ack"
        Private Const MaxResponseWaitCount As Integer = 10
        Private Const ResponseSleepMilliseconds As Integer = 1000

#End Region

#Region " Properties "

        Private ReadOnly _SacoaCommandDirectory As String
        Public ReadOnly Property SacoaCommandDirectory() As String
            Get
                Return _SacoaCommandDirectory
            End Get
        End Property

        Private _nowFunc As Func(Of DateTime) = Function() DateTime.Now
        Protected Friend Overridable Property GetNowFunc() As Func(Of DateTime)
            Get
                Return _nowFunc
            End Get
            Set(value As Func(Of DateTime))
                _nowFunc = value
            End Set
        End Property

#End Region

#Region " Constructor "

        Protected Friend Sub New(commandDirectory As String)
            _SacoaCommandDirectory = commandDirectory
        End Sub

#End Region

#Region " GetCommandString "

        Protected Friend Overrides Function GetRequestString(request As ISacoaRequest) As String
            Return request.BuildRequest() & Environment.NewLine
        End Function

#End Region

#Region " SendSacoaCommand "

        Protected Friend Overrides Function SendSacoaRequest(cmd As String) As String
            Dim commandFileTitle As String = GetCommandFileTitle()
            CreateCommandFile(commandFileTitle, cmd)
            RenameCommandFile(commandFileTitle)

            Dim response As String = GetResponse(commandFileTitle)
            DeleteResponseFile(commandFileTitle)

            Return response
        End Function

#End Region

#Region " File Read/Write "

        Protected Friend Overridable Function GetCommandFileTitle() As String
            Dim timestamp As DateTime = GetNowFunc.Invoke()
            Dim fileTitle As String = String.Format("POS_{0}", timestamp.ToString("MMddyy_hhmmsstt"))
            Return fileTitle
        End Function

        Protected Friend Overridable Function GetCommandFileName(commandFileTitle As String) As String
            Dim fileName As String = commandFileTitle & CommandFileExtension
            Dim fileFullName As String = System.IO.Path.Combine(SacoaCommandDirectory, fileName)
            Return fileFullName
        End Function
        Protected Friend Overridable Function GetRequestFileName(commandFileTitle As String) As String
            Dim fileName As String = commandFileTitle & RequestFileExtension
            Dim fileFullName As String = System.IO.Path.Combine(SacoaCommandDirectory, fileName)
            Return fileFullName
        End Function
        Protected Friend Overridable Function GetResponseFileName(commandFileTitle As String) As String
            Dim fileName As String = commandFileTitle & ResponseFileExtension
            Dim fileFullName As String = System.IO.Path.Combine(SacoaCommandDirectory, fileName)
            Return fileFullName
        End Function

        Protected Friend Overridable Sub CreateCommandFile(commandFileTitle As String, command As String)
            Dim commandFileName As String = GetCommandFileName(commandFileTitle)
            File.WriteAllText(commandFileName, command)
        End Sub

        Protected Friend Overridable Sub DeleteResponseFile(commandFileTitle As String)
            Dim responseFileName As String = GetResponseFileName(commandFileTitle)
            If File.Exists(responseFileName) Then
                File.Delete(responseFileName)
            End If
        End Sub

        Protected Friend Overridable Sub RenameCommandFile(commandFileTitle As String)
            Dim commandFileName As String = GetCommandFileName(commandFileTitle)
            Dim requestFileName As String = GetRequestFileName(commandFileTitle)
            My.Computer.FileSystem.RenameFile(commandFileName, requestFileName)
        End Sub

        Protected Friend Overridable Function GetResponse(commandFileTitle As String) As String
            Dim responseFileName As String = GetResponseFileName(commandFileTitle)
            Dim responseString As String = String.Empty
            Dim counter As Integer = 0
            While (counter < MaxResponseWaitCount)
                System.Threading.Thread.Sleep(ResponseSleepMilliseconds)
                If File.Exists(responseFileName) Then
                    Try
                        responseString = File.ReadAllText(responseFileName)
                        Exit While
                    Catch
                        Try
                            'We'll retry it once...
                            System.Threading.Thread.Sleep(ResponseSleepMilliseconds)
                            responseString = File.ReadAllText(responseFileName)
                            Exit While
                        Catch ex As Exception
                            Throw ex
                        End Try
                    End Try
                End If
                counter += 1
            End While
            Return responseString
        End Function

#End Region

    End Class

End Namespace