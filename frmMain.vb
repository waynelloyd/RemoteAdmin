
Public Class frmMain
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "
    Dim frmMessage1 As New frmMessage1
    Dim frmServices As New frmServices
    Dim frmRestart As New frmRestart
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.

        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button5 = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Computer name or IP address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "\\"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(192, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem5, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem3})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "E&xit"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem8, Me.MenuItem18, Me.MenuItem24, Me.MenuItem13, Me.MenuItem14, Me.MenuItem7})
        Me.MenuItem5.Text = "&Tools"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "&Messenger"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Restart (Remote)"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "&Remote Desktop"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 3
        Me.MenuItem24.Text = "&Command Prompt"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 5
        Me.MenuItem14.Text = "&Services (Local)"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "&Services (Remote)"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem11, Me.MenuItem2})
        Me.MenuItem4.Text = "&Help"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "&Important"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "&About"
        '
        'TextBox1
        '
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(32, 48)
        Me.TextBox1.MaxLength = 256
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenu = Me.ContextMenu1
        Me.NotifyIcon1.Text = "Remote Admin"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20, Me.MenuItem22, Me.MenuItem10, Me.MenuItem21, Me.MenuItem23, Me.MenuItem16, Me.MenuItem15, Me.MenuItem9})
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Text = "&Services (Local)"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "&Services (Remote)"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 2
        Me.MenuItem22.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.Text = "&Command Prompt"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Text = "&Remote Desktop"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Text = "&Restart (Remote)"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 6
        Me.MenuItem16.Text = "&Messenger"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.Text = "E&xit"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(24, 88)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "Ping"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(184, 216)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 24)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "OK"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(24, 120)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "System Information"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(24, 152)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "Group Policy"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(24, 184)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 24)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.Text = "Remote Desktop"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(112, 152)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 24)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Restart"
        Me.CheckBox1.Visible = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(24, 216)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.TabIndex = 13
        Me.RadioButton5.Text = "Services"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(270, 255)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remote Admin"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public WithEvents TrayIcon As NotifyIcon

    Private Shown As Boolean

    Public Shared Function ShowWindowAsync(ByVal hWnd As IntPtr, ByVal swCommand As Integer) As Integer
    End Function
    Public Enum ShowWindowConstants
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZED = 2
        SW_SHOWMAXIMIZED = 3
        SW_MAXIMIZE = 3
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWMINNOACTIVE = 7
        SW_SHOWNA = 8
        SW_RESTORE = 9
        SW_SHOWDEFAULT = 10
        SW_FORCEMINIMIZE = 11
        SW_MAX = 11
    End Enum
    Public Shared Sub Main()

        Dim initForm As Process() = Process.GetProcessesByName("remadm")
        'Change the name above to suit your application
        If (initForm.Length = 1) Then
            Application.Run(New frmMain)
        Else
            ShowWindowAsync(initForm(0).MainWindowHandle, ShowWindowConstants.SW_SHOWMINIMIZED)
            ShowWindowAsync(initForm(0).MainWindowHandle, ShowWindowConstants.SW_RESTORE)
            MsgBox("Remote Admin is already running")
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        TrayIcon = New NotifyIcon ' Makes a new instance of the tray icon (this
        '                           automatically creates it on the System Tray

        Shown = True '              The form is currently shown, so...


        With TrayIcon '                         Let's fill the tray icon
            .Visible = False '                  Becouse the form is currently
            '                                   shown, let's hide the tray icon
            .Icon = Me.Icon '                   You can define the image to be
            '                                   shown here, i put the icon of the
            '                                   form
            .Text = "Application Running..." '   This is the tool tip text that 
            '                                   shows the icon (You can change it
            '                                   dinamicaly)
            .ContextMenu = Me.ContextMenu1 '    This tells the icon to show the 
            '                                   popup menu defined in the form
        End With
    End Sub

#Region " IconMenu Handlers "
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    ' !!! You have to add this  handlers to your form to handle the IconMenu events !!!
    ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub MenuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayIcon.DoubleClick
        ' This handler restores the window when you click open in the 
        ' IconMenu-Open or when you double-click on the tray icon

        Me.WindowState = FormWindowState.Normal '   Restores the window
        Me.ShowInTaskbar = True '                   Show the TaskBar button
        Shown = True '                              The form is currently shown, so...
        TrayIcon.Visible = False '                  Hides the tray icon

    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        ' This handler exits the program when you click exit in the IconMenu-Exit
        ' WARNING!!!: If you have a code for the closing of the program, call it
        ' !!!!!!!!!!  from here, or it may not be executed

        TrayIcon.Visible = False '  This hides the tray icon before closing the
        '                           application. This is nessesary becouse of a
        '                           problem with some Windows (like XP) that don't
        '                           refresh the System Tray unless you hover the 
        '                           mouse over it
        Me.Close() '                Closes the form
        End '                       Ends the program

    End Sub
#End Region

    Private Sub frmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' This handler hides the Taskbar button of the window and shows the tray icon
        ' if the form was minimized
        If Shown And Me.WindowState = FormWindowState.Minimized Then
            Shown = False '                 The form is currently hided, so...
            Me.ShowInTaskbar = False '      Hides the Taskbar button of the form
            TrayIcon.Visible = True '       Shows the tray icon
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim frmAbout As New frmAbout
        frmAbout.ShowDialog(Me)
        frmAbout.Dispose()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.Close()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns2 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                System.Diagnostics.Process.Start("cmd.exe", "/c ping.exe -n 10 " & TextBox1.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns3 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                intAnswer = MsgBox("Click Yes to restart the remote" & vbCrLf & "system otherwise No", MsgBoxStyle.YesNo, "Restart")
                If intAnswer = vbYes = True Then
                    System.Diagnostics.Process.Start("shutdown.exe", "-r -t 60 -f -m \\" & TextBox1.Text)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns4 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                System.Diagnostics.Process.Start("msinfo32.exe", "/computer " & TextBox1.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim frmNotice As New frmNotice
        frmNotice.ShowDialog(Me)
        frmNotice.Dispose()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim bAns7 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            If CheckBox1.Checked = True Then
                Try
                    intAnswer = MsgBox("Click Yes to restart the remote" & vbCrLf & "system otherwise No", MsgBoxStyle.YesNo, "Restart")
                    If intAnswer = vbYes = True Then
                        System.Diagnostics.Process.Start("shutdown.exe", "-r -t 60 -f -m \\" & TextBox1.Text)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton1.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("cmd.exe", "/c ping.exe -n 10 " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton2.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("msinfo32.exe", "/computer " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton3.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("gpedit.msc", "/gpcomputer: " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton4.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("mstsc.exe", "-v:" & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton5.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("services.msc", "/computer:" & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            CheckBox1.Visible = True
        ElseIf RadioButton3.Checked = False Then
            CheckBox1.Checked = False
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns8 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                System.Diagnostics.Process.Start("gpedit.msc")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns9 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
            frmMessage1.Dispose()
        ElseIf TextBox1.Text = strAddress Then
            Try
                System.Diagnostics.Process.Start("mstsc.exe", "-v:" & TextBox1.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Try
            System.Diagnostics.Process.Start("cmd.exe", "/k, TITLE Remote Admin & VER & CD\")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim frmMessenger As New frmMessenger
        frmMessenger.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim frmMessenger As New frmMessenger
        frmMessenger.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bAns10 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                System.Diagnostics.Process.Start("services.msc", "/computer:" & TextBox1.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Try
            System.Diagnostics.Process.Start("services.msc")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        frmServices.ShowDialog(Me)
        frmServices.Dispose()
    End Sub

    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Try
            System.Diagnostics.Process.Start("services.msc")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        frmServices.ShowDialog(Me)
    End Sub

    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        frmRestart.ShowDialog(Me)
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Try
            System.Diagnostics.Process.Start("mstsc.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Try
            System.Diagnostics.Process.Start("mstsc.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        frmRestart.ShowDialog(Me)
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Try
            System.Diagnostics.Process.Start("cmd.exe", "/k, TITLE Remote Admin & VER & CD\")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

