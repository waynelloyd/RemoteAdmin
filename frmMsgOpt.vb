Imports System.ServiceProcess
Imports System.Windows.Forms

Public Class frmMsgOpt
    Inherits System.Windows.Forms.Form
    Dim frmMessage1 As New frmMessage1

#Region " Windows Form Designer generated code "

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMsgOpt))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(32, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Start"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(120, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Stop"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(24, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.Text = "(Local)"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(24, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.Text = "(Remote)"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(24, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Text = ""
        '
        'frmMsgOpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 214)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgOpt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Messenger"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public msgServ As New System.ServiceProcess.ServiceController("Messenger")



    Private Overloads Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim sStatus As String
        If RadioButton1.Checked = True Then
            msgServ.Refresh()
            sStatus = msgServ.Status.ToString
            Label3.Text = (msgServ.ServiceName & " status:  " & sStatus)
        ElseIf msgServ.Status = ServiceControllerStatus.Running Then
            Button1.Enabled = False
            Button2.Enabled = True
        ElseIf msgServ.Status = ServiceControllerStatus.Stopped Then
            Button1.Enabled = True
            Button2.Enabled = False
        ElseIf msgServ.MachineName = TextBox1.Text = True Then
            msgServ.Refresh()
            sStatus = msgServ.Status.ToString
            Label3.Text = (msgServ.ServiceName & " status:  " & sStatus)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bAns As Boolean = True
        Dim strAddress As String = TextBox1.Text

        If RadioButton1.Checked = True Then
            Try
                msgServ.Start()
                Button1.Enabled = False
            Catch exp As Exception
                MsgBox("Remote Admin encountered a problem while trying" & vbCrLf & "to start the messenger service!" & vbCrLf & vbCrLf & "You can try to start the service manually from the" & vbCrLf & "Tools menu:" & vbCrLf & vbCrLf & "> Select Tools" & vbCrLf & vbCrLf & "> Services (Local)" & vbCrLf & vbCrLf & "", MsgBoxStyle.OKOnly, "Messenger failed to start!")
            End Try
        End If
        RadioButton2.Checked = True
        If TextBox1.Text = String.Empty Then
            frmMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                msgServ.MachineName = TextBox1.Text
                msgServ.Start()
                Button1.Enabled = False
            Catch ex As Exception
                MsgBox("Remote Admin encountered a problem while trying" & vbCrLf & "to start the messenger service!" & vbCrLf & vbCrLf & "You can try to start the service manually from the" & vbCrLf & "Tools menu:" & vbCrLf & vbCrLf & "> Select Tools" & vbCrLf & vbCrLf & "> Services (Local)" & vbCrLf & vbCrLf & "", MsgBoxStyle.OKOnly, "Messenger failed to start!")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            msgServ.Stop()
            Button2.Enabled = False
        Catch exp As Exception
            MsgBox("Remote Admin encountered a problem while trying" & vbCrLf & "to start the messenger service!" & vbCrLf & vbCrLf & "You can try to start the service manually from the" & vbCrLf & "Tools menu:" & vbCrLf & vbCrLf & "> Select Tools" & vbCrLf & vbCrLf & "> Services (Local)" & vbCrLf & vbCrLf & "", MsgBoxStyle.OKOnly, "Messenger failed to start!")
        End Try
    End Sub

    Private Sub frmMsgOpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        If msgServ.Status = ServiceControllerStatus.Running Then
            Button1.Enabled = False
            Button2.Enabled = True
        ElseIf msgServ.Status = ServiceControllerStatus.Stopped Then
            Button1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = True
    End Sub
End Class
