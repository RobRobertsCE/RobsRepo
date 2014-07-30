Imports AdvCommon.AdvCommonCtrls
Imports AdvantageMessaging
Imports AdvantageMessaging.Data
Imports AdvantageMessaging.Logic

Public Class MessagesTestApp

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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

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
            sch.EmployeeNo = GetEmployeeNumber()

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
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
            sch.Viewed = DateTime.Now.AddHours(-1)
            sch.EmployeeNo = GetEmployeeNumber()

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
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
            sch.Viewed = DateTime.Now.AddHours(-1)
            sch.EmployeeNo = GetEmployeeNumber()

            Using ctx As New MessageDataContext()
                ctx.Messages.Add(msg)
                ctx.MessageSchedules.Add(sch)
                ctx.SaveChanges()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.WriteLine(ex.ToString())

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

End Class
