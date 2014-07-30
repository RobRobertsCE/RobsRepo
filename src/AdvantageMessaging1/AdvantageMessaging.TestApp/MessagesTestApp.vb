Imports AdvCommon.AdvCommonCtrls
Imports AdvantageMessaging
Imports AdvantageMessaging.Data
Imports AdvantageMessaging.Logic
Imports AdvantageMessaging.Service
Imports AdvantageMessaging.Service.Models

Public Class MessagesTestApp

#Region " form load / close "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim AdvCommonObj As AdvCommon.AdvCommonCtrls = Nothing

        Try
            AdvCommonObj = New AdvCommon.AdvCommonCtrls("AdvantageMessages TestApp", False, True)
            Get_ApplicationInfo()
            Get_Station(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region " load message lists "
    ''' <summary>
    ''' Example for loading the INBOX message list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LoadAllMessagesButton_Click(sender As Object, e As EventArgs) Handles LoadAllMessagesButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim inboxMessageList As MessageDisplayCollection = Nothing

            Using handler As MessageHandler = MessageHandler.CreateNewHandler(GetEmployeeNumber())
                inboxMessageList = handler.GetMessages()
            End Using

            'Set font to BOLD for messages where IsRead = False 
            DisplayMessages(inboxMessageList)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub

    ''' <summary>
    ''' Example for loading the SPLASH SCREEN message list.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LoadNewMessagesButton_Click(sender As Object, e As EventArgs) Handles LoadNewMessagesButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim splashScreenMessageList As MessageDisplayCollection = Nothing

            Using handler As MessageHandler = MessageHandler.CreateNewHandler(GetEmployeeNumber())
                splashScreenMessageList = handler.GetNewMessages()
            End Using

            DisplayMessages(splashScreenMessageList)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub

    Private Sub DisplayMessages(messageList As MessageDisplayCollection)
        Try
            BodyTextBox.Clear()

            If Not (MessageListBox.DataSource Is Nothing) Then MessageListBox.DataSource.Clear()

            MessageListBox.DisplayMember = "Subject"

            MessageListBox.DataSource = messageList

            'For INBOX...
            'For Each message As IMessageDisplay In messageList
            '    If Not message.IsRead Then
            '        'Font should be BOLD 
            '    Else
            '        'Font should be REGULAR 
            '    End If
            'Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        End Try

    End Sub

    Private Sub MessageListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MessageListBox.SelectedIndexChanged
        Try
            DisplayBody(MessageListBox.SelectedItem.Body)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        End Try

    End Sub

    Private Sub DisplayBody(body As String)
        BodyTextBox.Text = body
    End Sub

    Private Function GetEmployeeNumber() As Integer
        Return CInt(EmployeeNumberTextBox.Text)
    End Function

#End Region

#Region " message handler methods "
    Private Sub NewMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewMessageToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim msg As New MessageModel
            msg.LastUpdate = DateTime.Now.AddDays(-2)
            msg.MessageId = Guid.NewGuid()
            msg.Subject = "New Message Subject " & DateTime.Now.ToString()
            msg.Body = "<html><Body>Hello World! " & DateTime.Now.ToString() & "</Body></html>"""

            Dim sch As New MessageScheduleModel
            sch.MessageId = msg.MessageId
            sch.MessageScheduleId = Guid.NewGuid
            sch.Received = DateTime.Now.AddDays(-1)
            sch.Expires = DateTime.Now.AddDays(1)

            Dim messageViewer As New MessageEmployeeModel() With {
                 .MessageEmployeeId = Guid.NewGuid(),
                 .MessageScheduleId = sch.MessageScheduleId,
                 .EmployeeNo = GetEmployeeNumber(),
                 .IsRead = False,
                 .IsStatUpdated = False}

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
                ctx.MessageEmployees.Add(messageViewer)
                ctx.SaveChanges()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub AddReadMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddReadMessageToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim msg As New MessageModel
            msg.LastUpdate = DateTime.Now.AddDays(-2)
            msg.MessageId = Guid.NewGuid()
            msg.Subject = "Read Message Subject " & DateTime.Now.ToString()
            msg.Body = "<html><Body>Hello World! " & DateTime.Now.ToString() & "</Body></html>"""

            Dim sch As New MessageScheduleModel
            sch.MessageId = msg.MessageId
            sch.MessageScheduleId = Guid.NewGuid
            sch.Received = DateTime.Now.AddDays(-1)
            sch.Expires = DateTime.Now.AddDays(1)

            Dim messageViewer As New MessageEmployeeModel() With {
                 .MessageEmployeeId = Guid.NewGuid(),
                 .MessageScheduleId = sch.MessageScheduleId,
                 .EmployeeNo = GetEmployeeNumber(),
                 .IsRead = False,
                 .IsStatUpdated = False,
                 .Viewed = DateTime.Now.AddDays(-1)}

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
                ctx.MessageEmployees.Add(messageViewer)
                ctx.SaveChanges()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub AddSavedMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSavedMessageToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim msg As New MessageModel
            msg.LastUpdate = DateTime.Now.AddDays(-2)
            msg.MessageId = Guid.NewGuid()
            msg.Subject = "Saved Message Subject " & DateTime.Now.ToString()
            msg.Body = "<html><Body>Hello World! " & DateTime.Now.ToString() & "</Body></html>"""

            Dim sch As New MessageScheduleModel
            sch.MessageId = msg.MessageId
            sch.MessageScheduleId = Guid.NewGuid
            sch.Received = DateTime.Now.AddDays(-1)
            sch.Expires = DateTime.Now.AddDays(1)

            Dim messageViewer As New MessageEmployeeModel() With {
                 .MessageEmployeeId = Guid.NewGuid(),
                 .MessageScheduleId = sch.MessageScheduleId,
                 .EmployeeNo = GetEmployeeNumber(),
                 .IsRead = False,
                 .IsStatUpdated = False,
                 .Viewed = DateTime.Now.AddDays(-1)}

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
                ctx.MessageEmployees.Add(messageViewer)
                ctx.SaveChanges()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

#End Region

#Region " core service handler methods "
    Private Sub AddMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMessageToolStripMenuItem.Click
        Try
            Using coreHandler = New CoreHandlerTest
                Dim model As New AdvantageMessaging.Service.Models.MessageListResponseModel(Guid.NewGuid, Guid.NewGuid, "Testing123", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(7))

                Dim list As New List(Of AdvantageMessaging.Service.Models.MessageListResponseModel) From {model}

                coreHandler.LoadNewMessagesTest(list)

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        End Try

    End Sub

    Private Sub GetLocationHashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetLocationHashToolStripMenuItem.Click

        Try
            Using coreHandler = New CoreHandlerTest()
                Dim hash As String = coreHandler.GetHashTest()

                MessageBox.Show(hash)

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        End Try

    End Sub

    Public Class CoreHandlerTest
        Inherits AdvantageMessaging.CoreServiceMessageHandler

        Public Sub LoadNewMessagesTest(messageList As List(Of Service.Models.MessageListResponseModel))
            LoadNewMessages(messageList)
        End Sub

        Protected Overrides Sub LoadNewMessages(messageList As List(Of Service.Models.MessageListResponseModel))
            MyBase.LoadNewMessages(messageList)
        End Sub


        Public Function GetHashTest() As String
            Return GetLocationHash()
        End Function

        Protected Overrides Function GetLocationHash() As String
            Return MyBase.GetLocationHash()
        End Function

    End Class

#End Region

    Private Sub GetMessageBodyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetMessageBodyToolStripMenuItem.Click
        Try

            Using svc As New MessageBodyService()
                Dim response = svc.GetMessageBody(Guid.NewGuid())
                Console.WriteLine(response.ToString())

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())


        End Try
    End Sub

    Private Sub GetMessageListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetMessageListToolStripMenuItem.Click
        Try

            Using svc As New MessageService()
                Dim response = svc.GetMessages("HASHHASHHASH")
                Console.WriteLine(response.ToString())

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())


        End Try
    End Sub
End Class
