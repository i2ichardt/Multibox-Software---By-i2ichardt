<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActionBar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_1 = New Button()
        Btn_2 = New Button()
        Panel1 = New Panel()
        Pnl_Settings = New Panel()
        Btn_HidePanel = New Button()
        Label3 = New Label()
        Txt_CastTime = New TextBox()
        Label2 = New Label()
        Pic_Settings = New PictureBox()
        Label1 = New Label()
        Txt_Cooldown = New TextBox()
        Label4 = New Label()
        Btn_SavePreset = New Button()
        Btn_DeletePreset = New Button()
        Cmb_Profile = New ComboBox()
        Btn_Equals = New Button()
        Btn_Minus = New Button()
        Btn_0 = New Button()
        Btn_8 = New Button()
        Btn_9 = New Button()
        Btn_7 = New Button()
        Btn_6 = New Button()
        Btn_4 = New Button()
        Btn_5 = New Button()
        Btn_3 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1.SuspendLayout()
        Pnl_Settings.SuspendLayout()
        CType(Pic_Settings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_1
        ' 
        Btn_1.BackColor = SystemColors.AppWorkspace
        Btn_1.BackgroundImageLayout = ImageLayout.Stretch
        Btn_1.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_1.ForeColor = SystemColors.ControlLightLight
        Btn_1.Location = New Point(11, 22)
        Btn_1.Name = "Btn_1"
        Btn_1.Size = New Size(50, 50)
        Btn_1.TabIndex = 0
        Btn_1.TabStop = False
        Btn_1.Text = "1"
        Btn_1.TextAlign = ContentAlignment.TopRight
        Btn_1.UseVisualStyleBackColor = False
        ' 
        ' Btn_2
        ' 
        Btn_2.BackColor = SystemColors.AppWorkspace
        Btn_2.BackgroundImageLayout = ImageLayout.Stretch
        Btn_2.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_2.ForeColor = SystemColors.ControlLightLight
        Btn_2.Location = New Point(67, 22)
        Btn_2.Name = "Btn_2"
        Btn_2.Size = New Size(50, 50)
        Btn_2.TabIndex = 1
        Btn_2.TabStop = False
        Btn_2.Text = "2"
        Btn_2.TextAlign = ContentAlignment.TopRight
        Btn_2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Pnl_Settings)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Btn_SavePreset)
        Panel1.Controls.Add(Btn_DeletePreset)
        Panel1.Controls.Add(Cmb_Profile)
        Panel1.Controls.Add(Btn_Equals)
        Panel1.Controls.Add(Btn_Minus)
        Panel1.Controls.Add(Btn_0)
        Panel1.Controls.Add(Btn_8)
        Panel1.Controls.Add(Btn_9)
        Panel1.Controls.Add(Btn_7)
        Panel1.Controls.Add(Btn_6)
        Panel1.Controls.Add(Btn_4)
        Panel1.Controls.Add(Btn_5)
        Panel1.Controls.Add(Btn_3)
        Panel1.Controls.Add(Btn_1)
        Panel1.Controls.Add(Btn_2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 108)
        Panel1.TabIndex = 2
        ' 
        ' Pnl_Settings
        ' 
        Pnl_Settings.BackColor = Color.AliceBlue
        Pnl_Settings.BorderStyle = BorderStyle.FixedSingle
        Pnl_Settings.Controls.Add(Btn_HidePanel)
        Pnl_Settings.Controls.Add(Label3)
        Pnl_Settings.Controls.Add(Txt_CastTime)
        Pnl_Settings.Controls.Add(Label2)
        Pnl_Settings.Controls.Add(Pic_Settings)
        Pnl_Settings.Controls.Add(Label1)
        Pnl_Settings.Controls.Add(Txt_Cooldown)
        Pnl_Settings.Location = New Point(179, 20)
        Pnl_Settings.Name = "Pnl_Settings"
        Pnl_Settings.Size = New Size(402, 73)
        Pnl_Settings.TabIndex = 3
        Pnl_Settings.Visible = False
        ' 
        ' Btn_HidePanel
        ' 
        Btn_HidePanel.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_HidePanel.ForeColor = Color.Red
        Btn_HidePanel.Location = New Point(373, 3)
        Btn_HidePanel.Name = "Btn_HidePanel"
        Btn_HidePanel.Size = New Size(24, 23)
        Btn_HidePanel.TabIndex = 109
        Btn_HidePanel.TabStop = False
        Btn_HidePanel.Tag = "False"
        Btn_HidePanel.Text = "x"
        Btn_HidePanel.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(147, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 6
        Label3.Text = "Cast Time:"
        ' 
        ' Txt_CastTime
        ' 
        Txt_CastTime.ForeColor = SystemColors.WindowText
        Txt_CastTime.Location = New Point(147, 34)
        Txt_CastTime.Name = "Txt_CastTime"
        Txt_CastTime.Size = New Size(80, 23)
        Txt_CastTime.TabIndex = 5
        Txt_CastTime.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 4
        Label2.Text = "Image:"
        ' 
        ' Pic_Settings
        ' 
        Pic_Settings.BackgroundImageLayout = ImageLayout.Stretch
        Pic_Settings.BorderStyle = BorderStyle.FixedSingle
        Pic_Settings.Location = New Point(36, 28)
        Pic_Settings.Name = "Pic_Settings"
        Pic_Settings.Size = New Size(35, 35)
        Pic_Settings.TabIndex = 3
        Pic_Settings.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 15)
        Label1.TabIndex = 1
        Label1.Text = "Global Cooldown"
        ' 
        ' Txt_Cooldown
        ' 
        Txt_Cooldown.BorderStyle = BorderStyle.FixedSingle
        Txt_Cooldown.Location = New Point(259, 34)
        Txt_Cooldown.Name = "Txt_Cooldown"
        Txt_Cooldown.Size = New Size(43, 23)
        Txt_Cooldown.TabIndex = 0
        Txt_Cooldown.Text = "1.5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(437, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 110
        Label4.Text = "Profile:"
        ' 
        ' Btn_SavePreset
        ' 
        Btn_SavePreset.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_SavePreset.ForeColor = Color.Black
        Btn_SavePreset.Location = New Point(655, 77)
        Btn_SavePreset.Name = "Btn_SavePreset"
        Btn_SavePreset.Size = New Size(24, 23)
        Btn_SavePreset.TabIndex = 109
        Btn_SavePreset.TabStop = False
        Btn_SavePreset.Tag = "False"
        Btn_SavePreset.Text = "+"
        Btn_SavePreset.UseVisualStyleBackColor = True
        ' 
        ' Btn_DeletePreset
        ' 
        Btn_DeletePreset.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_DeletePreset.ForeColor = Color.Red
        Btn_DeletePreset.Location = New Point(631, 77)
        Btn_DeletePreset.Name = "Btn_DeletePreset"
        Btn_DeletePreset.Size = New Size(24, 23)
        Btn_DeletePreset.TabIndex = 108
        Btn_DeletePreset.TabStop = False
        Btn_DeletePreset.Tag = "False"
        Btn_DeletePreset.Text = "x"
        Btn_DeletePreset.UseVisualStyleBackColor = True
        ' 
        ' Cmb_Profile
        ' 
        Cmb_Profile.FlatStyle = FlatStyle.Flat
        Cmb_Profile.FormattingEnabled = True
        Cmb_Profile.Location = New Point(487, 78)
        Cmb_Profile.Name = "Cmb_Profile"
        Cmb_Profile.Size = New Size(136, 23)
        Cmb_Profile.TabIndex = 12
        ' 
        ' Btn_Equals
        ' 
        Btn_Equals.BackColor = SystemColors.AppWorkspace
        Btn_Equals.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Equals.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_Equals.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Equals.ForeColor = SystemColors.ControlLightLight
        Btn_Equals.Location = New Point(632, 22)
        Btn_Equals.Name = "Btn_Equals"
        Btn_Equals.Size = New Size(50, 50)
        Btn_Equals.TabIndex = 11
        Btn_Equals.TabStop = False
        Btn_Equals.Text = "="
        Btn_Equals.TextAlign = ContentAlignment.TopRight
        Btn_Equals.UseVisualStyleBackColor = False
        ' 
        ' Btn_Minus
        ' 
        Btn_Minus.BackColor = SystemColors.AppWorkspace
        Btn_Minus.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Minus.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_Minus.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Minus.ForeColor = SystemColors.ControlLightLight
        Btn_Minus.Location = New Point(576, 22)
        Btn_Minus.Name = "Btn_Minus"
        Btn_Minus.Size = New Size(50, 50)
        Btn_Minus.TabIndex = 10
        Btn_Minus.TabStop = False
        Btn_Minus.Text = "-"
        Btn_Minus.TextAlign = ContentAlignment.TopRight
        Btn_Minus.UseVisualStyleBackColor = False
        ' 
        ' Btn_0
        ' 
        Btn_0.BackColor = SystemColors.AppWorkspace
        Btn_0.BackgroundImageLayout = ImageLayout.Stretch
        Btn_0.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_0.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_0.ForeColor = SystemColors.ControlLightLight
        Btn_0.Location = New Point(515, 22)
        Btn_0.Name = "Btn_0"
        Btn_0.Size = New Size(50, 50)
        Btn_0.TabIndex = 9
        Btn_0.TabStop = False
        Btn_0.Text = "0"
        Btn_0.TextAlign = ContentAlignment.TopRight
        Btn_0.UseVisualStyleBackColor = False
        ' 
        ' Btn_8
        ' 
        Btn_8.BackColor = SystemColors.AppWorkspace
        Btn_8.BackgroundImageLayout = ImageLayout.Stretch
        Btn_8.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_8.ForeColor = SystemColors.ControlLightLight
        Btn_8.Location = New Point(403, 22)
        Btn_8.Name = "Btn_8"
        Btn_8.Size = New Size(50, 50)
        Btn_8.TabIndex = 7
        Btn_8.TabStop = False
        Btn_8.Text = "8"
        Btn_8.TextAlign = ContentAlignment.TopRight
        Btn_8.UseVisualStyleBackColor = False
        ' 
        ' Btn_9
        ' 
        Btn_9.BackColor = SystemColors.AppWorkspace
        Btn_9.BackgroundImageLayout = ImageLayout.Stretch
        Btn_9.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_9.ForeColor = SystemColors.ControlLightLight
        Btn_9.Location = New Point(459, 22)
        Btn_9.Name = "Btn_9"
        Btn_9.Size = New Size(50, 50)
        Btn_9.TabIndex = 8
        Btn_9.TabStop = False
        Btn_9.Text = "9"
        Btn_9.TextAlign = ContentAlignment.TopRight
        Btn_9.UseVisualStyleBackColor = False
        ' 
        ' Btn_7
        ' 
        Btn_7.BackColor = SystemColors.AppWorkspace
        Btn_7.BackgroundImageLayout = ImageLayout.Stretch
        Btn_7.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_7.ForeColor = SystemColors.ControlLightLight
        Btn_7.Location = New Point(347, 22)
        Btn_7.Name = "Btn_7"
        Btn_7.Size = New Size(50, 50)
        Btn_7.TabIndex = 6
        Btn_7.TabStop = False
        Btn_7.Text = "7"
        Btn_7.TextAlign = ContentAlignment.TopRight
        Btn_7.UseVisualStyleBackColor = False
        ' 
        ' Btn_6
        ' 
        Btn_6.BackColor = SystemColors.AppWorkspace
        Btn_6.BackgroundImageLayout = ImageLayout.Stretch
        Btn_6.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_6.ForeColor = SystemColors.ControlLightLight
        Btn_6.Location = New Point(291, 22)
        Btn_6.Name = "Btn_6"
        Btn_6.Size = New Size(50, 50)
        Btn_6.TabIndex = 5
        Btn_6.TabStop = False
        Btn_6.Text = "6"
        Btn_6.TextAlign = ContentAlignment.TopRight
        Btn_6.UseVisualStyleBackColor = False
        ' 
        ' Btn_4
        ' 
        Btn_4.BackColor = SystemColors.AppWorkspace
        Btn_4.BackgroundImageLayout = ImageLayout.Stretch
        Btn_4.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_4.ForeColor = SystemColors.ControlLightLight
        Btn_4.Location = New Point(179, 22)
        Btn_4.Name = "Btn_4"
        Btn_4.Size = New Size(50, 50)
        Btn_4.TabIndex = 4
        Btn_4.TabStop = False
        Btn_4.Text = "4"
        Btn_4.TextAlign = ContentAlignment.TopRight
        Btn_4.UseVisualStyleBackColor = False
        ' 
        ' Btn_5
        ' 
        Btn_5.BackColor = SystemColors.AppWorkspace
        Btn_5.BackgroundImageLayout = ImageLayout.Stretch
        Btn_5.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_5.ForeColor = SystemColors.ControlLightLight
        Btn_5.Location = New Point(235, 22)
        Btn_5.Name = "Btn_5"
        Btn_5.Size = New Size(50, 50)
        Btn_5.TabIndex = 4
        Btn_5.TabStop = False
        Btn_5.Text = "5"
        Btn_5.TextAlign = ContentAlignment.TopRight
        Btn_5.UseVisualStyleBackColor = False
        ' 
        ' Btn_3
        ' 
        Btn_3.BackColor = SystemColors.AppWorkspace
        Btn_3.BackgroundImageLayout = ImageLayout.Stretch
        Btn_3.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Btn_3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_3.ForeColor = SystemColors.ControlLightLight
        Btn_3.Location = New Point(123, 22)
        Btn_3.Name = "Btn_3"
        Btn_3.Size = New Size(50, 50)
        Btn_3.TabIndex = 2
        Btn_3.TabStop = False
        Btn_3.Text = "3"
        Btn_3.TextAlign = ContentAlignment.TopRight
        Btn_3.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ActionBar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 108)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "ActionBar"
        Text = "ActionBar"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Pnl_Settings.ResumeLayout(False)
        Pnl_Settings.PerformLayout()
        CType(Pic_Settings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_1 As Button
    Friend WithEvents Btn_2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_3 As Button
    Friend WithEvents Pnl_Settings As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Pic_Settings As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Cooldown As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btn_Equals As Button
    Friend WithEvents Btn_Minus As Button
    Friend WithEvents Btn_0 As Button
    Friend WithEvents Btn_8 As Button
    Friend WithEvents Btn_9 As Button
    Friend WithEvents Btn_7 As Button
    Friend WithEvents Btn_6 As Button
    Friend WithEvents Btn_4 As Button
    Friend WithEvents Btn_5 As Button
    Friend WithEvents Cmb_Profile As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_SavePreset As Button
    Friend WithEvents Btn_DeletePreset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_CastTime As TextBox
    Friend WithEvents Btn_HidePanel As Button
End Class
