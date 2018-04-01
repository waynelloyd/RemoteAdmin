Imports System.ComponentModel
Imports System.Runtime.InteropServices

Friend Class Balloon 'begin balloon class 

    Private Const WM_USER As Long = &H400
    Private Const NIF_MESSAGE As Int32 = &H1
    Private Const NIF_ICON As Int32 = &H2
    Private Const NIF_STATE As Int32 = &H8
    Private Const NIF_INFO As Int32 = &H10
    Private Const NIF_TIP As Int32 = &H4
    Private Const NIM_ADD As Int32 = &H0
    Private Const NIM_MODIFY As Int32 = &H1
    Private Const NIM_DELETE As Int32 = &H2
    Private Const NIM_SETVERSION As Int32 = &H4
    Private Const NOTIFYICON_VERSION As Int32 = &H5
    Private Const NIIF_ERROR As Int32 = &H3
    Private Const NIIF_INFO As Int32 = &H1
    Private Const NIIF_NONE As Int32 = &H0
    Private Const NIM_SETFOCUS As Int32 = &H3
    Private Const NIN_BALLOONSHOW As Long = (WM_USER + 2)
    Private Const NIN_BALLOONHIDE As Long = (WM_USER + 3)
    Private Const NIN_BALLOONTIMEOUT As Long = (WM_USER + 4)
    Private Const NIN_BALLOONUSERCLICK As Long = (WM_USER + 5)

    Public Enum BalloonMessageTypes
        None = &H0
        Info = &H1
        [Error] = &H3
    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure NOTIFYICONDATA
        Public cbSize As Int32
        Public hwnd As IntPtr
        Public uID As Int32
        Public uFlags As Int32
        Public uCallbackMessage As IntPtr
        Public hIcon As IntPtr
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)> _
        Public szTip As String
        Public dwState As Int32
        Public dwStateMask As Int32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
        Public szInfo As String
        Public uTimeout As Int32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)> _
        Public szInfoTitle As String
        Public dwInfoFlags As Int32
    End Structure

    Private Declare Auto Function Shell_NotifyIconA Lib "shell32" (ByVal dwMessage As Integer, _
    ByRef pnid As NOTIFYICONDATA) As Integer

Public Shared Sub DisplayBalloon(ByRef NotifyIcon As System.Windows.Forms.NotifyIcon, ByVal BalloonTitle As String, ByVal BalloonText As String, _
       Optional ByVal MessageType As BalloonMessageTypes = BalloonMessageTypes.None)
    Dim typNotifyIcon As Type = GetType(System.Windows.Forms.NotifyIcon)
        Dim ptrWindow As IntPtr = (CType(typNotifyIcon.GetField("window", System.Reflection.BindingFlags.Instance Or _
            System.Reflection.BindingFlags.NonPublic).GetValue(NotifyIcon), System.Windows.Forms.NativeWindow)).Handle
    Dim id As Int32 = CType(typNotifyIcon.GetField("id", System.Reflection.BindingFlags.Instance Or _
        System.Reflection.BindingFlags.NonPublic).GetValue(NotifyIcon), Integer)
    Dim clsNID As NOTIFYICONDATA
    With clsNID
        .szTip = ""
        .dwState = 0
        .dwStateMask = 0
        .hIcon = IntPtr.Zero
        .uCallbackMessage = New IntPtr(&H200)
        .uID = id
        .hwnd = ptrWindow
        .szInfo = BalloonText
        .szInfoTitle = BalloonTitle
        .uFlags = NIF_INFO
        .cbSize = Marshal.SizeOf(clsNID)
        .dwInfoFlags = CType(MessageType, Int32)
        .uTimeout = NOTIFYICON_VERSION
    End With
    Dim result As Int32 = Shell_NotifyIconA(NIM_MODIFY, clsNID)
End Sub

Public Shared Sub HideBalloon(ByRef NotifyIcon As System.Windows.Forms.NotifyIcon)
    Dim typNotifyIcon As Type = GetType(System.Windows.Forms.NotifyIcon)
    Dim ptrWindow As IntPtr = (CType(typNotifyIcon.GetField("window", System.Reflection.BindingFlags.Instance Or _
        System.Reflection.BindingFlags.NonPublic).GetValue(NotifyIcon), System.Windows.Forms.NativeWindow)).Handle
    Dim id As Int32 = CType(typNotifyIcon.GetField("id", System.Reflection.BindingFlags.Instance Or _
        System.Reflection.BindingFlags.NonPublic).GetValue(NotifyIcon), Integer)
    Dim clsNID As NOTIFYICONDATA
    With clsNID
        .szTip = ""
        .dwState = 0
        .dwStateMask = 0
        .hIcon = IntPtr.Zero
        .uCallbackMessage = New IntPtr(&H200)
        .uID = id
        .hwnd = ptrWindow
        .szInfo = ""
        .szInfoTitle = ""
        .uFlags = NIF_INFO
        .cbSize = Marshal.SizeOf(clsNID)
        .dwInfoFlags = CType(BalloonMessageTypes.None, Int32)
        .uTimeout = NOTIFYICON_VERSION
    End With
    Dim result As Int32 = Shell_NotifyIconA(NIM_MODIFY, clsNID)
    End Sub
    Public Shared Function HookBalloonEvents(ByVal NotifyIcon As System.Windows.Forms.NotifyIcon) As NotifyIconBalloon
        Dim clsEvents As New NotifyIconBalloon
        Dim typNotifyIcon As Type = GetType(System.Windows.Forms.NotifyIcon)
        Dim ptrWindow As IntPtr = (CType(typNotifyIcon.GetField("window", System.Reflection.BindingFlags.Instance _
            Or System.Reflection.BindingFlags.NonPublic).GetValue(NotifyIcon), System.Windows.Forms.NativeWindow)).Handle
        clsEvents.AssignHandle(ptrWindow)
        Return clsEvents
    End Function

    Public Class NotifyIconBalloon
        Inherits System.Windows.Forms.NativeWindow
        Public Event BallonHidden()
        Public Event BallonShown()
        Public Event BallonTimedOut()
        Public Event BallonClicked()
        Friend Sub New()
            ' 
        End Sub
        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            Select Case m.LParam.ToInt32
                Case NIN_BALLOONHIDE
                    RaiseEvent BallonHidden()
                Case NIN_BALLOONSHOW
                    RaiseEvent BallonShown()
                Case NIN_BALLOONTIMEOUT
                    RaiseEvent BallonTimedOut()
                Case NIN_BALLOONUSERCLICK
                    RaiseEvent BallonClicked()
                Case Else
            End Select
            MyBase.WndProc(m)
        End Sub
    End Class

End Class 'end balloon class 
