Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports Newtonsoft.Json ' Ensure you have Newtonsoft.Json installed via NuGet

Public Class ActionBar
    ' Constants for moving the window
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    ' New structure to hold multiple profiles
    Private AllProfiles As New Dictionary(Of String, Dictionary(Of String, ButtonInfo))
    ' Dictionary to hold button data: Key = Button Name, Value = {ImagePath, Cooldown}
    Private ButtonData As New Dictionary(Of String, ButtonInfo)
    Private BtnTarget As Button

    Public Class ButtonInfo
        Public Property ImagePath As String
        Public Property Cooldown As Double
        Public Property CastTime As Double
    End Class

    ' --- Windows API for Moving Window ---
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function


    ' SAVE PRESET
    Private Sub Btn_SavePreset_Click(sender As Object, e As EventArgs) Handles Btn_SavePreset.Click
        Dim profileName As String = Cmb_Profile.Text
        If String.IsNullOrWhiteSpace(profileName) Then
            MessageBox.Show("Please enter a name for the profile.")
            Return
        End If

        ' Save current state to the dictionary
        AllProfiles(profileName) = New Dictionary(Of String, ButtonInfo)(ButtonData)

        ' Update ComboBox list if it's a new profile
        If Not Cmb_Profile.Items.Contains(profileName) Then
            Cmb_Profile.Items.Add(profileName)
        End If

        ' Serialize the Master Dictionary
        My.Settings.AllProfilesJson = Newtonsoft.Json.JsonConvert.SerializeObject(AllProfiles)
        My.Settings.Save()
        MessageBox.Show("Profile saved!")
    End Sub

    ' DELETE PRESET
    Private Sub Btn_DeletePreset_Click(sender As Object, e As EventArgs) Handles Btn_DeletePreset.Click
        Dim profileName As String = Cmb_Profile.Text
        If AllProfiles.ContainsKey(profileName) Then
            AllProfiles.Remove(profileName)
            Cmb_Profile.Items.Remove(profileName)
            Cmb_Profile.Text = ""

            ' Update settings
            My.Settings.AllProfilesJson = Newtonsoft.Json.JsonConvert.SerializeObject(AllProfiles)
            My.Settings.Save()
            MessageBox.Show("Profile deleted.")
        End If
    End Sub

    ' LOAD PROFILE WHEN SELECTION CHANGES
    Private Sub Cmb_Profile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Profile.SelectedIndexChanged
        Dim selectedName As String = Cmb_Profile.Text
        If AllProfiles.ContainsKey(selectedName) Then
            ' Load the button data for this profile
            ButtonData = AllProfiles(selectedName)

            ' Refresh all buttons visually
            ApplyButtonSettings()
        End If
    End Sub

    Private Sub ApplyButtonSettings()
        ' List of your buttons
        Dim buttons As Button() = {Btn_1, Btn_2, Btn_3, Btn_4, Btn_5, Btn_6, Btn_7, Btn_8, Btn_9, Btn_0, Btn_Minus, Btn_Equals}

        For Each btn In buttons
            If ButtonData.ContainsKey(btn.Name) Then
                Dim info = ButtonData(btn.Name)
                If File.Exists(info.ImagePath) Then
                    btn.BackgroundImage = Image.FromFile(info.ImagePath)
                End If
            Else
                ' Clear if no data
                btn.BackgroundImage = Nothing
            End If
        Next
    End Sub


    Private Sub ActionBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Load existing profiles from settings
        If Not String.IsNullOrEmpty(My.Settings.AllProfilesJson) Then
            AllProfiles = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Dictionary(Of String, ButtonInfo)))(My.Settings.AllProfilesJson)

            ' Populate ComboBox
            Cmb_Profile.Items.Clear()
            ' Change 'Name' to 'profileName'
            For Each profileName As String In AllProfiles.Keys
                Cmb_Profile.Items.Add(profileName)
            Next
        End If
    End Sub

    ' --- Logic to Save/Load ---
    Private Sub SaveSettings()
        My.Settings.ButtonSettings = Newtonsoft.Json.JsonConvert.SerializeObject(ButtonData)
        My.Settings.Save()
    End Sub

    Private Sub LoadSettings()
        If Not String.IsNullOrEmpty(My.Settings.ButtonSettings) Then
            ButtonData = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, ButtonInfo))(My.Settings.ButtonSettings)

            ' Apply settings to buttons
            For Each btn In {Btn_1, Btn_2} ' Add all your 12 buttons here
                If ButtonData.ContainsKey(btn.Name) Then
                    Dim info = ButtonData(btn.Name)
                    If File.Exists(info.ImagePath) Then btn.BackgroundImage = Image.FromFile(info.ImagePath)
                    ' You could also load the Cooldown value if you have a way to store it per button
                End If
            Next
        End If
    End Sub

    ' --- Right Click to Set Target ---
    Private Sub Button_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_1.MouseDown, Btn_2.MouseDown, Btn_3.MouseDown, Btn_4.MouseDown, Btn_5.MouseDown, Btn_6.MouseDown, Btn_7.MouseDown, Btn_8.MouseDown, Btn_9.MouseDown, Btn_0.MouseDown, Btn_Minus.MouseDown, Btn_Equals.MouseDown
        If e.Button = MouseButtons.Right Then
            ' 1. Identify which button was right-clicked
            BtnTarget = CType(sender, Button)

            ' 2. Show the settings panel
            Pnl_Settings.Visible = True
            Pnl_Settings.BringToFront()

            ' 3. Update the UI to match this button's saved state
            If ButtonData.ContainsKey(BtnTarget.Name) Then
                Dim info = ButtonData(BtnTarget.Name)

                ' Update Cooldown Textbox
                Txt_Cooldown.Text = info.Cooldown.ToString()
                Txt_CastTime.Text = info.CastTime.ToString()

                ' Update PictureBox (load the file again)
                If File.Exists(info.ImagePath) Then
                    Pic_Settings.Image = Image.FromFile(info.ImagePath)
                Else
                    Pic_Settings.Image = Nothing ' Or a default "no image" icon
                End If
            Else
                ' If no data exists yet, clear the UI
                Txt_Cooldown.Text = "1.0" ' Default
                Pic_Settings.Image = Nothing
            End If
        End If
    End Sub

    ' --- Pic_Settings Click: Store Path ---
    Private Sub Pic_Settings_Click(sender As Object, e As EventArgs) Handles Pic_Settings.Click
        Using ofd As New OpenFileDialog() With {.Filter = "Images|*.jpg;*.png"}
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Save path to our dictionary
                Dim info As New ButtonInfo With {.ImagePath = ofd.FileName, .Cooldown = Val(Txt_Cooldown.Text)}
                ButtonData(BtnTarget.Name) = info

                ' Update UI
                BtnTarget.BackgroundImage = Image.FromFile(ofd.FileName)
                Pic_Settings.Image = BtnTarget.BackgroundImage
                SaveSettings()
            End If
        End Using
    End Sub







    ' --- Window Dragging ---
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub



    Private Sub Txt_Cooldown_TextChanged(sender As Object, e As EventArgs) Handles Txt_Cooldown.TextChanged
        ' Only proceed if a target button is selected
        If BtnTarget IsNot Nothing Then

            ' 1. Get existing data, or initialize new if it doesn't exist
            Dim info As ButtonInfo
            If ButtonData.ContainsKey(BtnTarget.Name) Then
                info = ButtonData(BtnTarget.Name)
            Else
                info = New ButtonInfo()
            End If

            ' 2. Update ONLY the Cooldown
            ' We use CDbl for better precision than Val
            Dim newCooldown As Double
            If Double.TryParse(Txt_Cooldown.Text, newCooldown) Then
                info.Cooldown = newCooldown
            End If

            ' 3. Put it back in the dictionary
            ButtonData(BtnTarget.Name) = info
        End If
    End Sub
    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        BtnTarget = Btn_1
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D1)

    End Sub
    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        BtnTarget = Btn_2
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D2)

    End Sub
    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        BtnTarget = Btn_3
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D3)
    End Sub
    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        BtnTarget = Btn_4
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D4)
    End Sub
    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        BtnTarget = Btn_5
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D5)
    End Sub
    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        BtnTarget = Btn_6
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D6)
    End Sub
    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        BtnTarget = Btn_7
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D7)
    End Sub
    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        BtnTarget = Btn_8
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D8)
    End Sub
    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        BtnTarget = Btn_9
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D9)
    End Sub
    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        BtnTarget = Btn_0
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.D0)
    End Sub
    Private Sub Btn_Minus_Click(sender As Object, e As EventArgs) Handles Btn_Minus.Click
        BtnTarget = Btn_Minus
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.OemMinus)
    End Sub
    Private Sub Btn_Equals_Click(sender As Object, e As EventArgs) Handles Btn_Equals.Click
        BtnTarget = Btn_Equals
        Dim mainForm = TryCast(Application.OpenForms("Form1"), Form1)
        mainForm?.SendKeyToTarget(Keys.Oemplus)
    End Sub

    Private Sub Btn_HidePanel_Click(sender As Object, e As EventArgs) Handles Btn_HidePanel.Click
        Pnl_Settings.Visible = False
    End Sub
End Class