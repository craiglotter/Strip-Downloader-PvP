Imports System.IO
Imports System.Net

Public Class Main_Screen

    Private busyworking As Boolean = False
    Private AutoUpdate As Boolean = False

    Private precountDays As Long = 0
    Private countDays As Long = 0
    Private countFiles As Long = 0



    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ": " & ex.ToString
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ": " & ex.ToString)
                filewriter.WriteLine("")
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
            StatusLabel.Text = "Error Reported"
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error." & vbCrLf & vbCrLf & exc.ToString, MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Activity_Handler(ByVal message As String)
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & message)
            filewriter.WriteLine("")
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
            StatusLabel.Text = "Activity Logged"
        Catch ex As Exception
            Error_Handler(ex, "Activity Handler")
        End Try
    End Sub

   

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = My.Application.Info.ProductName & " (" & Format(My.Application.Info.Version.Major, "0000") & Format(My.Application.Info.Version.Minor, "00") & Format(My.Application.Info.Version.Build, "00") & "." & Format(My.Application.Info.Version.Revision, "00") & ")"
            loadSettings()
            StatusLabel.Text = "Application Loaded"
        Catch ex As Exception
            Error_Handler(ex, "Application Loading")
        End Try
    End Sub

    Private Sub loadSettings()
        Try

            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            If My.Computer.FileSystem.FileExists(configfile) Then
                Dim reader As StreamReader = New StreamReader(configfile)
                Dim lineread As String
                Dim variablevalue As String
                While reader.Peek <> -1
                    lineread = reader.ReadLine
                    If lineread.IndexOf("=") <> -1 Then
                        variablevalue = lineread.Remove(0, lineread.IndexOf("=") + 1)
                        If lineread.StartsWith("Setting_StripsFolder=") Then
                            If My.Computer.FileSystem.DirectoryExists(variablevalue) = True Then
                                Setting_StripsFolder.Text = variablevalue
                            End If
                        End If
                     
                    End If
                End While
                reader.Close()
                reader = Nothing

                If Setting_StripsFolder.Text.Length = 0 Then
                    Setting_StripsFolder.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
                End If

            End If
            StatusLabel.Text = "Application Settings Loaded"
        Catch ex As Exception
            Error_Handler(ex, "Load Settings")
        End Try
    End Sub

    Private Sub SaveSettings()
        Try
            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            Dim writer As StreamWriter = New StreamWriter(configfile, False)
            writer.WriteLine("Setting_StripsFolder=" & Setting_StripsFolder.Text)
            writer.Flush()
            writer.Close()
            writer = Nothing
            StatusLabel.Text = "Application Settings Saved"
        Catch ex As Exception
            Error_Handler(ex, "Save Settings")
        End Try
    End Sub

    Private Sub Main_Screen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            SaveSettings()
           
            If AutoUpdate = True Then
                If My.Computer.FileSystem.FileExists((Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")) = True Then
                    Dim startinfo As ProcessStartInfo = New ProcessStartInfo
                    startinfo.FileName = (Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")
                    startinfo.Arguments = "force"
                    startinfo.CreateNoWindow = False
                    Process.Start(startinfo)
                End If
            End If
            StatusLabel.Text = "Application Shutting Down"
        Catch ex As Exception
            Error_Handler(ex, "Closing Application")
        End Try
    End Sub


    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Try
            HelpBox1.ShowDialog()
            StatusLabel.Text = "Help Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display Help Screen")
        End Try
    End Sub

    Private Sub AutoUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoUpdateToolStripMenuItem.Click
        Try
            StatusLabel.Text = "AutoUpdate Requested"
            AutoUpdate = True
            Me.Close()
        Catch ex As Exception
            Error_Handler(ex, "AutoUpdate")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Try
            AboutBox1.ShowDialog()
            StatusLabel.Text = "About Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display About Screen")
        End Try
    End Sub

    Private Sub Control_Enabler(ByVal IsEnabled As Boolean)
        Try
            Select Case IsEnabled
                Case True
                    Button1.Enabled = True
                    MenuStrip1.Enabled = True
                    Me.ControlBox = True
                    ProgressBar1.Enabled = False
                    Button2.Enabled = False
                    '                    Button2.Visible = False
                Case False
                    Button1.Enabled = False
                    MenuStrip1.Enabled = False
                    Me.ControlBox = False
                    ProgressBar1.Enabled = True
                    Button2.Enabled = True
                    '                   Button2.Visible = True
            End Select
            StatusLabel.Text = "Control Enabler Run"
        Catch ex As Exception
            Error_Handler(ex, "Control Enabler")
        End Try
    End Sub

    Private Sub runworker()
        Try
            If busyworking = False Then
                If DateTimePicker1.Value > DateTimePicker2.Value Then
                    MsgBox("Please note that in order for this application to work properly, the Ending Date Range must be greater than the Starting Date Range")
                Else
                    FolderBrowserDialog1.Description = "Please select the folder to which you would like the comic strips downloaded to:"
                    If My.Computer.FileSystem.DirectoryExists(Setting_StripsFolder.Text) = True Then
                        FolderBrowserDialog1.SelectedPath = Setting_StripsFolder.Text
                    End If
                    If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Setting_StripsFolder.Text = FolderBrowserDialog1.SelectedPath
                        precountDays = 0
                        countDays = 0
                        countFiles = 0
                        ProgressBar1.Value = 0
                        ProgressBar1.Refresh()
                        StatusLabel.Refresh()
                        If BackgroundWorker1 Is Nothing Then
                            BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
                            BackgroundWorker1.WorkerReportsProgress = True
                            BackgroundWorker1.WorkerSupportsCancellation = True
                        End If
                        busyworking = True
                        Control_Enabler(False)
                        BackgroundWorker1.RunWorkerAsync()
                    End If
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Run Worker")
        End Try
    End Sub

    Private Sub RunPrecount()
        Try
            BackgroundWorker1.ReportProgress(50)
            precountDays = DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value, FirstDayOfWeek.Monday) + 1
            BackgroundWorker1.ReportProgress(50)
        Catch ex As Exception
            Error_Handler(ex, "Precount Function")
        End Try
    End Sub


    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            If e.ProgressPercentage = 100 Then
                ProgressBar1.Value = Math.Round(((countDays / precountDays) * 100), 0)
                StatusLabel.Text = "Downloading Content: " & countDays & " of " & precountDays & " to Parse | " & countFiles & " Strips Downloaded"
            Else
                StatusLabel.Text = "Running Precount: " & precountDays & " dates to parse"
            End If
        Catch ex As Exception
            Error_Handler(ex, "Report Progress")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Strip Download Operation in Progress"
                StatusLabel.Text = "Starting up Precount Operation"
                RunPrecount()
            Else
                e.Cancel = True
            End If

            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Precount Operation Complete"
                StatusLabel.Text = "Downloading Comic Strips"
                Dim currentdate As Date = DateTimePicker1.Value
                While currentdate <= DateTimePicker2.Value
                    If BackgroundWorker1.CancellationPending = False Then
                        Dim addrs As ArrayList = New ArrayList()
                        addrs.Add("http://www.pvponline.com/comics/pvp" & Format(currentdate, "yyyyMMdd") & ".gif")
                        addrs.Add("http://www.pvponline.com/comics/pvp" & Format(currentdate, "yyyyMMdd") & ".jpg")
                        For Each address As String In addrs
                            Try
                                Dim req As HttpWebRequest = HttpWebRequest.Create(address)
                                Dim resp As HttpWebResponse = req.GetResponse()
                                resp.Close()
                                resp = Nothing
                                req.Abort()
                                req = Nothing
                                My.Computer.Network.DownloadFile(address, (Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/"))).Replace("/", "\").Replace("\\", "\"), "", "", False, 100000, True)
                                If My.Computer.FileSystem.FileExists(Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\")) = True Then
                                    Try
                                        If My.Computer.FileSystem.ReadAllText(Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\")).StartsWith("<!DOCTYPE") Then
                                            My.Computer.FileSystem.DeleteFile(Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\"))
                                        Else

                                            If Not PictureBox1.Image Is Nothing Then
                                                PictureBox1.Image.Dispose()
                                            End If
                                            PictureBox1.Tag = Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\")
                                            PictureBox1.Image = Image.FromFile(Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\"))
                                            countFiles = countFiles + 1
                                        End If
                                    Catch ex As Exception
                                        My.Computer.FileSystem.DeleteFile(Setting_StripsFolder.Text & "\" & address.Remove(0, address.LastIndexOf("/")).Replace("/", "\").Replace("\\", "\"))
                                    End Try
                                End If

                            Catch ex As System.Net.WebException
                                'Do Nothing
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Next
                        BackgroundWorker1.ReportProgress(100)
                    Else
                        e.Cancel = True
                        Exit While
                    End If
                    countDays = countDays + 1
                    BackgroundWorker1.ReportProgress(100)
                    currentdate = currentdate.AddDays(1)
                End While
            Else
                e.Cancel = True
            End If
            If BackgroundWorker1.CancellationPending = False Then
                StatusLabel.Text = "Strip Download Operation Complete"
                e.Result = "Success"
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
            Error_Handler(ex, "Download Operation")
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Control_Enabler(True)
            If e.Cancelled = False And e.Error Is Nothing Then
                If e.Result = "Success" Then
                    StatusLabel.Text = "Download Operation Completed Successfully (" & countFiles & " Strips were Downloaded)"
                End If
            Else
                StatusLabel.Text = "Download Operation Did Not Complete Successfully (" & countFiles & " Strips were Downloaded)"
            End If
            busyworking = False
            BackgroundWorker1.Dispose()
            BackgroundWorker1 = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Download Operation Complete")
        End Try
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            runworker()
        Catch ex As Exception
            Error_Handler(ex, "Force Operation")
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            BackgroundWorker1.CancelAsync()
        Catch ex As Exception
            Error_Handler(ex, "Cancel Backup Operation")
        End Try
    End Sub


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            If DateTimePicker1.Value > DateTimePicker2.Value Then
                MsgBox("Please note that in order for this application to work properly, the Ending Date Range must be greater than the Starting Date Range")
            End If
        Catch ex As Exception
            Error_Handler(ex, "DateTimePicker2 Value Changed")
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            If DateTimePicker1.Value > DateTimePicker2.Value Then
                MsgBox("Please note that in order for this application to work properly, the Ending Date Range must be greater than the Starting Date Range")
            End If
        Catch ex As Exception
            Error_Handler(ex, "DateTimePicker2 Value Changed")
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            If Not PictureBox1.Image Is Nothing Then
                If My.Computer.FileSystem.FileExists(PictureBox1.Tag.ToString) = True Then
                    Process.Start(PictureBox1.Tag.ToString)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Click on Last Downloaded Picture")
        End Try
    End Sub
End Class
