'Auto switches between programs on the desktop on Windows
'dchow[AT]xtecsystems.com 20160125
'Version 1.0
'Import some shit
Imports System.Threading
Imports System.IO

Public Class MainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program switches between programs based on interval using alt tab and focus. 20160125 dchow")
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'Loop the send key forever
        Dim fookMe As Short
        fookMe = 0

        Dim msValue As Integer
        msValue = (NumberBox.Value)
        Dim secondsValue As Integer
        secondsValue = (msValue * 1000)

        'Store pids opening the browser and server manager
        'Dim pidBrowser As Integer
        'Dim pidServerManager As Integer
        'Dim pidNotepad As Integer
        'Dim pidsmLauncher As Integer

        'load up the shell env variables
        'Dim programFilesDir As String
        'Dim system32Dir As String
        'Dim iexplore As String
        'Dim serverManager As String
        'Dim notepad As String

        'programFilesDir = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        'iexplore = programFilesDir + "\" + "Internet Explorer\" + "iexplore.exe"

        'system32Dir = Environment.GetFolderPath(Environment.SpecialFolder.System)
        'serverManager = system32Dir + "\" + "ServerManager.exe"
        'notepad = system32Dir + "\" + "notepad.exe"

        'Input from OpenFileDialog boxes
        Dim app1Path = BrowseFile1Textbox.Text.ToString()
        Dim app2Path = BrowseFile2TextBox.Text.ToString()

        Dim pidApp1 As Integer
        Dim pidApp2 As Integer

        'launch the apps and store the pids
        'pidBrowser = Shell(iexplore, AppWinStyle.NormalFocus)
        'Servermanager.exe refuses to run despite good path. Possible UAC or Escalation issues. Fucking bull shit.
        'http://forums.codeguru.com/printthread.php?t=347845&pp=50
        'pidNotepad = Shell(notepad, AppWinStyle.NormalNoFocus)

        pidApp1 = Shell(app1Path, AppWinStyle.NormalFocus)
        'pidApp1 = Shell("C:\Windows\system32\notepad.exe", AppWinStyle.NormalFocus)
        'Apps may open too fast during focus before activation
        Thread.Sleep(1000)
        pidApp2 = Shell(app2Path, AppWinStyle.NormalNoFocus)

        Do While fookMe < 1
            Try
                AppActivate(pidApp1)
                'Using browser pid first seems to crash upon alt tab for unknown reason
                AppActivate(pidApp1)
                Thread.Sleep(secondsValue)
                SendKeys.SendWait("%{TAB}")
                'SendKeys.SendWait("{F2}")
                Thread.Sleep(secondsValue)
                'SendKeys.SendWait("{F1}")
            Catch
                MessageBox.Show("An Error Has Occured. Quitting.")
                Close()
            End Try

        Loop
    End Sub

    Private Sub NumberBox_ValueChanged(sender As Object, e As EventArgs) Handles NumberBox.ValueChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BrowseFile1Button.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'Jacked this guys code: http://www.techrepublic.com/blog/software-engineer/let-users-pick-a-file-to-open-via-openfiledialog-in-vbnet/
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        BrowseFile1Textbox.Text = OpenFileDialog1.FileName.ToString()
    End Sub

    Private Sub BrowseFile2Button_Click(sender As Object, e As EventArgs) Handles BrowseFile2Button.Click
        OpenFileDialog2.Title = "Please Select a File"
        OpenFileDialog2.InitialDirectory = "C:\"
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog2.OpenFile()
        BrowseFile2TextBox.Text = OpenFileDialog2.FileName.ToString()
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        MessageBox.Show("Browse to the first application you want to ALT+TAB between and then do the same for the second using the buttons." +
                        Environment.NewLine + "Select the timer to the number of seconds between intervals." +
                        Environment.NewLine + "Some programs work better than others. Best to use in Windows 7 or below." +
                        Environment.NewLine + "Use of processes that have multiple focus input areas tend to cause the most trouble like IE" +
                        Environment.NewLine + "Also note if .NET has no visibility or has UAC permission issues, it will fail to load the app" +
                        Environment.NewLine +
                        Environment.NewLine + "If you still can't figure that out, just press ALT+F4 now. dchow[AT]xtecsystems.com ")
    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        'Variables for the loop
        Dim fookMe As Short
        fookMe = 0

        'Convert miliseconds to seconds
        Dim msValue As Integer
        msValue = (NumberBox.Value)
        Dim secondsValue As Integer
        secondsValue = (msValue * 1000)

        'Input from OpenFileDialog boxes
        Dim app1Path = BrowseFile1Textbox.Text.ToString()
        Dim app2Path = BrowseFile2TextBox.Text.ToString()

        Dim pidApp1 As Integer
        Dim pidApp2 As Integer


        'Call the external application and set window focus return the process id to integer
        pidApp1 = Shell(app1Path, AppWinStyle.NormalFocus)
        'Apps may open too fast during focus before activation
        Thread.Sleep(1000)
        pidApp2 = Shell(app2Path, AppWinStyle.NormalNoFocus)

        'Infinite loop until you close one or more of the processes which throws an error to force quit
        Do While fookMe < 1
            Try
                AppActivate(pidApp1)
                'Using browser pid first seems to crash upon alt tab for unknown reason
                AppActivate(pidApp1)
                Thread.Sleep(secondsValue)
                SendKeys.SendWait("%{TAB}")
                'SendKeys.SendWait("{F2}")
                Thread.Sleep(secondsValue)
                'SendKeys.SendWait("{F1}")
            Catch
                MessageBox.Show("An Error Has Occured. Quitting.")
                Close()
            End Try

        Loop
    End Sub
End Class
