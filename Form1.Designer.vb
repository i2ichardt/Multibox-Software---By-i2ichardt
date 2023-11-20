<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        LblTargetWindowTitle = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Pnl_Info = New Panel()
        Lbl_CloseInfo = New Label()
        LblTargetWindowProcessName = New Label()
        Label6 = New Label()
        LblTargetWindowhWnd = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Btn_RefreshList = New Button()
        ToolTip1 = New ToolTip(components)
        Rtb_InputLog = New MyRichTextBox()
        Btn_StartStop = New Button()
        Btn_Settings = New Button()
        LblKeyPressed = New Label()
        Label1 = New Label()
        Pnl_Info.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblTargetWindowTitle
        ' 
        LblTargetWindowTitle.AutoSize = True
        LblTargetWindowTitle.ForeColor = Color.DodgerBlue
        LblTargetWindowTitle.Location = New Point(12, 44)
        LblTargetWindowTitle.Name = "LblTargetWindowTitle"
        LblTargetWindowTitle.Size = New Size(99, 15)
        LblTargetWindowTitle.TabIndex = 5
        LblTargetWindowTitle.Text = "<target window>"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(12, 36)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(258, 245)
        FlowLayoutPanel1.TabIndex = 7
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' Pnl_Info
        ' 
        Pnl_Info.BorderStyle = BorderStyle.FixedSingle
        Pnl_Info.Controls.Add(Lbl_CloseInfo)
        Pnl_Info.Controls.Add(LblTargetWindowProcessName)
        Pnl_Info.Controls.Add(Label6)
        Pnl_Info.Controls.Add(LblTargetWindowhWnd)
        Pnl_Info.Controls.Add(Label4)
        Pnl_Info.Controls.Add(Label3)
        Pnl_Info.Controls.Add(Label2)
        Pnl_Info.Controls.Add(LblTargetWindowTitle)
        Pnl_Info.Location = New Point(33, 90)
        Pnl_Info.Name = "Pnl_Info"
        Pnl_Info.Size = New Size(214, 143)
        Pnl_Info.TabIndex = 8
        Pnl_Info.Visible = False
        ' 
        ' Lbl_CloseInfo
        ' 
        Lbl_CloseInfo.AutoSize = True
        Lbl_CloseInfo.Cursor = Cursors.Hand
        Lbl_CloseInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_CloseInfo.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Lbl_CloseInfo.Location = New Point(195, 0)
        Lbl_CloseInfo.Name = "Lbl_CloseInfo"
        Lbl_CloseInfo.Size = New Size(15, 15)
        Lbl_CloseInfo.TabIndex = 11
        Lbl_CloseInfo.Text = "X"
        ' 
        ' LblTargetWindowProcessName
        ' 
        LblTargetWindowProcessName.AutoSize = True
        LblTargetWindowProcessName.ForeColor = Color.DodgerBlue
        LblTargetWindowProcessName.Location = New Point(12, 113)
        LblTargetWindowProcessName.Name = "LblTargetWindowProcessName"
        LblTargetWindowProcessName.Size = New Size(99, 15)
        LblTargetWindowProcessName.TabIndex = 10
        LblTargetWindowProcessName.Text = "<target window>"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label6.Location = New Point(12, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 13)
        Label6.TabIndex = 9
        Label6.Text = "Window Process Name:"
        ' 
        ' LblTargetWindowhWnd
        ' 
        LblTargetWindowhWnd.AutoSize = True
        LblTargetWindowhWnd.ForeColor = Color.DodgerBlue
        LblTargetWindowhWnd.Location = New Point(12, 78)
        LblTargetWindowhWnd.Name = "LblTargetWindowhWnd"
        LblTargetWindowhWnd.Size = New Size(99, 15)
        LblTargetWindowhWnd.TabIndex = 8
        LblTargetWindowhWnd.Text = "<target window>"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(12, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 13)
        Label4.TabIndex = 7
        Label4.Text = "Window hWnd:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label3.Location = New Point(12, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 13)
        Label3.TabIndex = 6
        Label3.Text = "Window Title:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 17)
        Label2.TabIndex = 0
        Label2.Text = "Targets Information:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(12, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 17)
        Label5.TabIndex = 9
        Label5.Text = "Available Targets:"
        ' 
        ' Btn_RefreshList
        ' 
        Btn_RefreshList.BackgroundImageLayout = ImageLayout.None
        Btn_RefreshList.Cursor = Cursors.Hand
        Btn_RefreshList.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Btn_RefreshList.FlatAppearance.MouseDownBackColor = Color.Gray
        Btn_RefreshList.FlatAppearance.MouseOverBackColor = Color.White
        Btn_RefreshList.FlatStyle = FlatStyle.Flat
        Btn_RefreshList.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_RefreshList.Location = New Point(184, 10)
        Btn_RefreshList.Name = "Btn_RefreshList"
        Btn_RefreshList.Size = New Size(86, 23)
        Btn_RefreshList.TabIndex = 12
        Btn_RefreshList.Text = "REFRESH LIST"
        ToolTip1.SetToolTip(Btn_RefreshList, "Available targets list is updated only when the program loads. Unless you click Refresh List.")
        Btn_RefreshList.UseVisualStyleBackColor = True
        ' 
        ' Rtb_InputLog
        ' 
        Rtb_InputLog.BackColor = Color.Black
        Rtb_InputLog.BorderStyle = BorderStyle.None
        Rtb_InputLog.ForeColor = Color.Green
        Rtb_InputLog.IsDisabled = True
        Rtb_InputLog.LeftMargin = 5
        Rtb_InputLog.Location = New Point(276, 36)
        Rtb_InputLog.Name = "Rtb_InputLog"
        Rtb_InputLog.Size = New Size(276, 197)
        Rtb_InputLog.TabIndex = 13
        Rtb_InputLog.Text = "Captured Inputs Log:"
        ' 
        ' Btn_StartStop
        ' 
        Btn_StartStop.BackColor = Color.LimeGreen
        Btn_StartStop.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_StartStop.Location = New Point(316, 5)
        Btn_StartStop.Name = "Btn_StartStop"
        Btn_StartStop.Size = New Size(206, 28)
        Btn_StartStop.TabIndex = 14
        Btn_StartStop.Text = "START"
        Btn_StartStop.UseVisualStyleBackColor = False
        ' 
        ' Btn_Settings
        ' 
        Btn_Settings.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Settings.Location = New Point(528, 7)
        Btn_Settings.Name = "Btn_Settings"
        Btn_Settings.Size = New Size(32, 26)
        Btn_Settings.TabIndex = 15
        Btn_Settings.Text = ""
        Btn_Settings.UseVisualStyleBackColor = True
        ' 
        ' LblKeyPressed
        ' 
        LblKeyPressed.BackColor = SystemColors.Control
        LblKeyPressed.ForeColor = SystemColors.ActiveCaptionText
        LblKeyPressed.Location = New Point(360, 256)
        LblKeyPressed.Name = "LblKeyPressed"
        LblKeyPressed.Size = New Size(97, 15)
        LblKeyPressed.TabIndex = 17
        LblKeyPressed.Text = "<null>"
        LblKeyPressed.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(375, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 16
        Label1.Text = "Key Pressed:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 293)
        Controls.Add(LblKeyPressed)
        Controls.Add(Label1)
        Controls.Add(Btn_Settings)
        Controls.Add(Btn_StartStop)
        Controls.Add(Rtb_InputLog)
        Controls.Add(Btn_RefreshList)
        Controls.Add(Label5)
        Controls.Add(Pnl_Info)
        Controls.Add(FlowLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Multibox Software - By i2ichardt"
        Pnl_Info.ResumeLayout(False)
        Pnl_Info.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblTargetWindowTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Pnl_Info As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblTargetWindowhWnd As Label
    Friend WithEvents LblTargetWindowProcessName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_CloseInfo As Label
    Friend WithEvents Btn_RefreshList As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Rtb_InputLog As MyRichTextBox
    Friend WithEvents Btn_StartStop As Button
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents LblKeyPressed As Label
    Friend WithEvents Label1 As Label
End Class
