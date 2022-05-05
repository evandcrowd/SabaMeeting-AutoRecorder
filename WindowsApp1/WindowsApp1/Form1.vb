Imports System.Net
Imports System
Imports System.IO
Imports System.IO.Compression
Imports System.Threading
Public Class Form1
    Public Shared time As String
    Public Shared timerecording As Integer
    Public Shared recordingDone As Boolean
    Public Shared datePartofDateandTime
    Public Shared timePartofDateandTime
    Public Shared convertedTime As String
    Public Shared SabaID
    Public Shared saba As Process()
    Public Shared obs As Process()
    Public Shared ProcessID
    Public Shared meetingName
    Public Shared i
    Public Shared m
    Public Shared p
    Public Shared f As String
    Dim userprofile As String = Environment.UserName
    Private Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As IntPtr)
    Public Sub PerformMouseClick(ByVal LClick_RClick_DClick As String)
        Const MOUSEEVENTF_LEFTDOWN As Integer = 2
        Const MOUSEEVENTF_LEFTUP As Integer = 4
        Const MOUSEEVENTF_RIGHTDOWN As Integer = 6
        Const MOUSEEVENTF_RIGHTUP As Integer = 8
        If LClick_RClick_DClick = "RClick" Then
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "LClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        ElseIf LClick_RClick_DClick = "DClick" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
        End If
    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add recordings to list.
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo("C:\Users\" & userprofile & "\Desktop\Recordings")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.ccrz")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            strFileSize = (Math.Round(fi.Length / 1024)).ToString()
            Console.WriteLine("File Name: {0}", fi.Name)
            Console.WriteLine("File Full Name: {0}", fi.FullName)
            Console.WriteLine("File Size (KB): {0}", strFileSize)
            Console.WriteLine("File Extension: {0}", fi.Extension)
            recordingList.Items.Add(fi.Name)
            Dim filename As String = fi.Name
        Next
        recordingList.SetItemChecked(0, False)
    End Sub
    Public Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If (Not System.IO.Directory.Exists("C:\Users\" & userprofile & "\Desktop\Recordings")) Then
            System.IO.Directory.CreateDirectory("C:\Users\" & userprofile & "\Desktop\Recordings")
            System.IO.Directory.CreateDirectory("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording\")
            System.IO.Directory.CreateDirectory("C:\Users\" & userprofile & "\Videos\Recording Retentions\")

        End If

        Dim recordingDone As Boolean

        Dim fileList As New List(Of String)
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo("C:\Users\" & userprofile & "\Desktop\Recordings")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.ccrz")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            strFileSize = (Math.Round(fi.Length / 1024)).ToString()
            Console.WriteLine("File Name: {0}", fi.Name)
            fileList.Add(fi.Name)
            Console.WriteLine("File Full Name: {0}", fi.FullName)
            Console.WriteLine("File Size (KB): {0}", strFileSize)
            Console.WriteLine("File Extension: {0}", fi.Extension)
            Dim filename As String = fi.Name

        Next
        'We will run through each indice

        If recordingList.GetItemChecked(0) = True And timer.Enabled = False Then

            Dim FILE_NAME As String = "C:\Users\" & userprofile & "\Desktop\Recordings\" & recordingList.Items(0)
            If System.IO.File.Exists(FILE_NAME) = True Then
                Console.WriteLine("Opening " + FILE_NAME)
                Process.Start(FILE_NAME)
                Thread.Sleep(5000)
            Else
                MsgBox("File Does Not Exist")
            End If

            'Extract CCRZ to Folder'
            Try
                ZipFile.ExtractToDirectory("C:\Users\" & userprofile & "\Desktop\Recordings\" + recordingList.Items(0), "C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording")

                Console.WriteLine("Extracted files.")

            Catch ex As Exception

            End Try

            Dim di2 As New IO.DirectoryInfo("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording\")
            Dim aryFi2 As IO.FileInfo() = di2.GetFiles("*.ccrf")
            Dim fi2 As IO.FileInfo
            For Each fi2 In aryFi2
                Console.WriteLine("File Name: {0}", fi2.Name)
                Console.WriteLine("File Full Name: {0}", fi2.FullName)
                Console.WriteLine("File Extension: {0}", fi2.Extension)
            Next
            'Extracted File List


            Thread.Sleep(2000)
            'Open CCRF to get timestamp'
            Dim strOrig As String = fi2.Name
            If strOrig.Contains("._") Then
                Dim output As String = strOrig.Substring(strOrig.IndexOf("._"))
                output = output.Replace("._", "").Trim()
                output = output.Replace(".ccrf", "").Trim()

                datePartofDateandTime = output.Split("_")(0)
                timePartofDateandTime = output.Split("_")(1)


            Else

                Dim output As String = strOrig.Substring(strOrig.IndexOf("_"))

                i = output.IndexOf("_")
                p = output.Substring(i + 1, output.IndexOf("_", i + 1) - i - 1)

                output = output.Replace("_" + p + "_", "").Trim()
                output = output.Replace(".ccrf", "").Trim()

                datePartofDateandTime = output.Split("_")(0)
                timePartofDateandTime = output.Split("_")(1)

            End If

            i = 2
            While i < datePartofDateandTime.Length
                datePartofDateandTime = datePartofDateandTime.Insert(i, "-")
                i += 3
            End While

            timePartofDateandTime = timePartofDateandTime.Replace(".", ":")

            Dim d As DateTime = DateTime.ParseExact(timePartofDateandTime, "HH:mm:ss", Nothing)

            Dim sHour As String = d.ToString("HH")
            Dim sMinute As String = d.ToString("mm")
            Dim bAddHour As Boolean = False
            Dim oIFP As IFormatProvider
            Select Case CInt(sMinute)
                Case 0 To 7
                    sMinute = "00"
                Case 8 To 22
                    sMinute = "15"
                Case 23 To 37
                    sMinute = "30"
                Case 38 To 52
                    sMinute = "45"
                Case 53 To 59
                    sMinute = "00"
                    bAddHour = True
            End Select
            d = DateTime.ParseExact(sHour & ":" & sMinute, "HH:mm", oIFP)
            If bAddHour Then d = d.AddHours(1)
            convertedTime = d.ToString("hh:mm tt")


            convertedTime = convertedTime.Replace(":", "-")
            convertedTime = convertedTime.Replace(" ", "")


            Dim text As String = File.ReadAllText("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording\" & fi2.Name)
            Dim index As Integer = text.IndexOf("<DURATION>")
            Dim f As String = text.Substring(index + 1, text.IndexOf("</DURATION>", index + 1) - index - 1)


            Dim index2 As Integer = text.IndexOf("<EVENT_NAME>")
            Dim f2 As String = text.Substring(index2 + 1, text.IndexOf("</EVENT_NAME>", index2 + 1) - index2 - 1)
            meetingName = f2.Replace("EVENT_NAME>", "")


            'Set Timestamp to readable time instead of seconds
            time = f.Replace("DURATION>", "")

            Dim hms = TimeSpan.FromSeconds(time)
            Dim h = hms.Hours
            Dim mins = hms.Minutes
            Dim s = hms.Seconds

            RemoveFiles()


            'Get Process ID's


            saba = Process.GetProcessesByName("centra")
            If saba.Length > 0 Then
                For m = 0 To saba.Length - 1
                    SabaID = (saba(m).Id)
                Next
            End If



            obs = Process.GetProcessesByName("obs64")
            If obs.Length > 0 Then
                For p = 0 To obs.Length - 1
                    ProcessID = (obs(p).Id)
                Next
            End If



            'Start Timer
            'Activate SabaMeeting Recording
            AppActivate(SabaID)

            'Start Saba Recording
            Thread.Sleep(5000)
            AppActivate("Saba Rec")
            SendKeys.Send("{ENTER}")
            'Start OBS Recording
            AppActivate(ProcessID)
            SendKeys.Send("{PGUP}")

            'When timer hits 0 then stop recording

            timer.Enabled = True
            timer.Start()

            'Set recording as checked so it goes to the next one.

        ElseIf recordingList.Items.Count = 0 Then
            MsgBox("All recordings have finished!!!!!!")

        End If



    End Sub


    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click

        'Delete Files in Extracted Recordings'
        ' Loop over the subdirectories and remove them with their contents
        For Each d In Directory.GetDirectories("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording")
            File.Delete(f)
        Next
    End Sub
    Public Function RemoveFiles()
        'Delete Files in Extracted Recordings'
        ' Loop over the subdirectories and remove them with their contents
        For Each d In Directory.GetDirectories("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording")
            Directory.Delete(d, True)
        Next

        ' Finish removing also the files in the root folder
        For Each f In Directory.GetFiles("C:\Users\" & userprofile & "\Desktop\Recordings\Extracted Recording")
            File.Delete(f)
        Next
        Dim str As String = "Useless"
        Console.WriteLine("Removed Files from folder.")
        Return str
    End Function

    Public Function Recording()
        If recordingDone = True Then
            AppActivate("OBS")
            Thread.Sleep(7000)
            SendKeys.Send("{PGDN}")
            SendKeys.SendWait("{PGDN}")
            Thread.Sleep(5000)

            Try
                My.Computer.FileSystem.RenameFile("E:\Recording Retentions\recording.mp4", datePartofDateandTime & "_" & convertedTime & "-" & meetingName & ".mp4")
                recordingList.Items.RemoveAt(0)
                recordingList.SetItemChecked(0, True)
                recordingDone = False
                timeleftNumber.Text = 0
                timerecording = 0

                ButtonStart.PerformClick()
            Catch
                If Not System.IO.File.Exists("E:\Recording Retentions\recording.mp4") Then
                    Console.WriteLine("File not found. Going onto the next.")
                    ButtonStart.PerformClick()
                End If

            End Try

        End If
    End Function

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        recordingList.Items.RemoveAt(recordingList.SelectedIndex)
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("Application created by Evan Crowder for personal use with a SabaMeeting migration project for East Carolina University.")
    End Sub

    Private Sub BtnVersion_Click(sender As Object, e As EventArgs) Handles btnVersion.Click
        MsgBox("Version 2.1" & vbCrLf & "Update notes:" & vbCrLf & "     Upgraded UI, made it accessible for laptops to use.  Rename file scheme.")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        timerecording += 1
        timeleftNumber.Text = timerecording

        If timerecording = time Then
            recordingDone = True
            timer.Enabled = False
            Recording()
            ProgressBar1.Value = 0
            timerecording = 0
            timeleftNumber.Text = "0"
        Else
            timer.Enabled = True
            recordingDone = False
            ProgressBar1.Value = ((timerecording / time) * 100)
        End If

        If ProgressBar1.Value > 100 Then
            ProgressBar1.Value = 0
        End If


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class