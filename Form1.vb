Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Principal
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Public TargetWindow_Hwnd As IntPtr

    ''start - get process information
    Public selectedProcessName As String
    Public selectedWindowTitle As String
    Public selectedHWnd As IntPtr
    Public selectedIcon As Icon


    Private Sub Processes_Load()
        Dim missedProcesses As Integer = 0

        For Each OneProcess As Process In Process.GetProcesses
            If Not String.IsNullOrEmpty(OneProcess.MainWindowTitle) Then ' Only show processes with a window
                Try
                    ' Try to access the MainModule property
                    Dim mainModule = OneProcess.MainModule

                    ' ... rest of your code ...
                Catch ex As Win32Exception
                    ' Increment the missedProcesses counter
                    missedProcesses += 1

                    ' Skip this process
                    Continue For
                End Try



                Dim pnl As New Panel
                pnl.BorderStyle = BorderStyle.FixedSingle
                pnl.Width = FlowLayoutPanel1.Width * 0.85
                pnl.Height = 50
                pnl.Margin = New Padding(10)
                pnl.Cursor = Cursors.Hand

                ' Add process name label
                Dim lblName As New Label
                lblName.Name = "lblName"
                lblName.Text = OneProcess.ProcessName
                lblName.Location = New Point(50, 10)
                pnl.Controls.Add(lblName)

                ' Add window title label
                Dim lblTitle As New Label
                lblTitle.Name = "lblTitle"
                lblTitle.Text = OneProcess.MainWindowTitle
                lblTitle.Location = New Point(50, 30)
                pnl.Controls.Add(lblTitle)

                ' Add hWnd label
                Dim lblHwnd As New Label
                lblHwnd.Name = "lblHwnd"
                lblHwnd.Text = $"({OneProcess.MainWindowHandle})"
                lblHwnd.Location = New Point(lblTitle.Right + 10, 30)
                pnl.Controls.Add(lblHwnd)

                ' Add icon picture box
                Dim icon As Icon = Icon.ExtractAssociatedIcon(OneProcess.MainModule.FileName)

                If icon IsNot Nothing Then
                    Dim picIcon As New PictureBox
                    picIcon.Name = "picIcon"
                    picIcon.Image = icon.ToBitmap()
                    picIcon.SizeMode = PictureBoxSizeMode.Zoom
                    picIcon.Location = New Point(10, 10)
                    picIcon.Size = New Size(32, 32)
                    pnl.Controls.Add(picIcon)

                    ' Attach event handler to icon
                    AddHandler picIcon.Click, AddressOf pnl_Click
                End If

                AddHandler pnl.Click, AddressOf pnl_Click
                ' Attach event handler to process name label
                AddHandler lblName.Click, AddressOf pnl_Click

                ' Attach event handler to window title label
                AddHandler lblTitle.Click, AddressOf pnl_Click

                ' Attach event handler to hWnd label
                AddHandler lblHwnd.Click, AddressOf pnl_Click

                FlowLayoutPanel1.Controls.Add(pnl)
            End If
        Next






        ' Show a MessageBox at the end if any processes were missed
        If missedProcesses > 0 Then
            MessageBox.Show($"{missedProcesses} process(es) were missed because the program wasn't running with Administrator privileges. Run the program as Administrator if the window you need doesn't appear in the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub
    Private Sub pnl_Paint(sender As Object, e As PaintEventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle, pnl.BackColor, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnl_Click(sender As Object, e As EventArgs)
        Dim pnl As Panel = Nothing
        Dim lblName As Label = Nothing
        Dim lblTitle As Label = Nothing
        Dim lblHwnd As Label = Nothing
        Dim picIcon As PictureBox = Nothing

        ''START - show selected effect
        ' Reset all panel borders to default

        For Each ctrl As Panel In FlowLayoutPanel1.Controls
            ctrl.BackColor = SystemColors.Control
            ctrl.Padding = New Padding(1)
        Next

        Dim clickedctrl As Panel = Nothing

        If TypeOf sender Is Panel Then
            clickedctrl = CType(sender, Panel)
        ElseIf TypeOf sender Is Label OrElse TypeOf sender Is PictureBox Then
            clickedctrl = CType(CType(sender, Control).Parent, Panel)
        End If

        If clickedctrl IsNot Nothing Then
            ' Change the border style of the clicked panel
            clickedctrl.BackColor = Color.DodgerBlue
            clickedctrl.Padding = New Padding(3)
        End If
        ''END - show selected effect

        If TypeOf sender Is Panel Then
            pnl = CType(sender, Panel)
            lblName = CType(pnl.Controls("lblName"), Label)
            lblTitle = CType(pnl.Controls("lblTitle"), Label)
            lblHwnd = CType(pnl.Controls("lblHwnd"), Label)
            picIcon = CType(pnl.Controls("picIcon"), PictureBox)
        ElseIf TypeOf sender Is Label Then
            Dim lbl As Label = CType(sender, Label)
            Dim parentPanel As Panel = CType(lbl.Parent, Panel)
            lblName = CType(parentPanel.Controls("lblName"), Label)
            lblTitle = CType(parentPanel.Controls("lblTitle"), Label)
            lblHwnd = CType(parentPanel.Controls("lblHwnd"), Label)
            picIcon = CType(parentPanel.Controls("picIcon"), PictureBox)
        ElseIf TypeOf sender Is PictureBox Then
            Dim pic As PictureBox = CType(sender, PictureBox)
            Dim parentPanel As Panel = CType(pic.Parent, Panel)
            lblName = CType(parentPanel.Controls("lblName"), Label)
            lblTitle = CType(parentPanel.Controls("lblTitle"), Label)
            lblHwnd = CType(parentPanel.Controls("lblHwnd"), Label)
            picIcon = CType(parentPanel.Controls("picIcon"), PictureBox)
        End If

        If lblName IsNot Nothing AndAlso lblTitle IsNot Nothing AndAlso lblHwnd IsNot Nothing AndAlso picIcon IsNot Nothing Then
            selectedProcessName = lblName.Text
            selectedWindowTitle = lblTitle.Text
            selectedHWnd = lblHwnd.Text.Substring(1, lblHwnd.Text.Length - 2)

            LblTargetWindowTitle.Text = selectedWindowTitle.ToString
            LblTargetWindowhWnd.Text = selectedHWnd.ToString
            LblTargetWindowProcessName.Text = selectedProcessName.ToString

            ' Parse the hWnd from the label's text
            Dim hWndString As String = lblHwnd.Text.TrimStart("(").TrimEnd(")")
            Dim hWnd As IntPtr
            If IntPtr.TryParse(hWndString, hWnd) Then
                ' Successfully parsed, hWnd now contains the window handle
                TargetWindow_Hwnd = hWnd
            Else
                ' Failed to parse, handle the error
            End If

            Pnl_Info.Visible = True

            FlowLayoutPanel1.Visible = False
            Label5.Visible = False
        End If

    End Sub
    ''end - get process information

    '' Start - Send Keyinput stuff
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(
       ByVal lpClassName As String,
       ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    '' END - 

    Private WithEvents kbHook As New KeyboardHook

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'kbHook.HookKeyboard()
        Processes_Load()
        Rtb_InputLog.AppendText($"{Environment.NewLine}")
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If Not ExcludedInputs.Contains(Key.ToString()) Then
            LblKeyPressed.Text = (Key.ToString + " PRESSED")

            If TargetWindow_Hwnd <> IntPtr.Zero Then
                SendMessage(TargetWindow_Hwnd, WM_KEYDOWN, Key, 0)
            End If
        End If
    End Sub

    Private Sub kbHook_KeyUp(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyUp
        If Not ExcludedInputs.Contains(Key.ToString()) Then
            LblKeyPressed.Text = (Key.ToString + " RELEASED")

            Rtb_InputLog.AppendText($"{Key} was pressed.{Environment.NewLine}")
            Rtb_InputLog.ScrollToCaret()

            If TargetWindow_Hwnd <> IntPtr.Zero Then
                SendMessage(TargetWindow_Hwnd, WM_KEYUP, Key, 0)
            End If
        End If
    End Sub



    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        kbHook.UnhookKeyboard()
    End Sub

    Private Sub Lbl_CloseInfo_Click(sender As Object, e As EventArgs) Handles Lbl_CloseInfo.Click
        Pnl_Info.Visible = False

        FlowLayoutPanel1.Visible = True
        Label5.Visible = True
    End Sub

    Private Sub Btn_RefreshList_Click(sender As Object, e As EventArgs) Handles Btn_RefreshList.Click
        ' Clear the existing controls
        FlowLayoutPanel1.Controls.Clear()

        ' Call the Processes_Load method
        Processes_Load()
        ' Set ActiveControl to nothing
        Me.ActiveControl = Nothing
    End Sub

    Private Sub Btn_StartStop_Click(sender As Object, e As EventArgs) Handles Btn_StartStop.Click

        If Btn_StartStop.Text = "START" Then
            kbHook.HookKeyboard()

            Btn_StartStop.Text = "STOP"
            Btn_StartStop.BackColor = Color.Red

        ElseIf Btn_StartStop.Text = "STOP" Then
            kbHook.UnhookKeyboard()

            Btn_StartStop.Text = "START"
            Btn_StartStop.BackColor = Color.LimeGreen

        End If


    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        Settings.Show()
    End Sub









    ''Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ''Dim hWnd As IntPtr = FindWindow(Nothing, "World of Warcraft")
    ''If hWnd <> IntPtr.Zero Then
    ''
    ''        TargetWindow_Hwnd = hWnd
    ''
    ''End If
    ''End Sub


End Class

Public Class KeyboardHook
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN = &H100
    Private Const WM_SYSKEYDOWN = &H104

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As UInt32
        Public scanCode As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()>
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)

    Private keyboardHook As IntPtr
    Private Shared keyBoardDelegate As KBDLLHookProc
    Private Declare Auto Function GetModuleHandle Lib "kernel32.dll" (ByVal lpModuleName As String) As IntPtr

    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    Private Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = 0) Then
            Dim kbd As KBDLLHOOKSTRUCT = DirectCast(Marshal.PtrToStructure(lParam, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
            If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
                RaiseEvent KeyDown(CType(kbd.vkCode, Keys))
            ElseIf (kbd.flags And KBDLLHOOKSTRUCTFlags.LLKHF_UP) <> 0 Then
                RaiseEvent KeyUp(CType(kbd.vkCode, Keys))
            End If
        End If

        Return CallNextHookEx(keyboardHook, nCode, wParam, lParam)
    End Function

    Public Sub HookKeyboard()
        keyBoardDelegate = AddressOf LowLevelKeyboardProc
        keyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, keyBoardDelegate, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0)
    End Sub

    Public Sub UnhookKeyboard()
        UnhookWindowsHookEx(keyboardHook)
    End Sub
End Class
