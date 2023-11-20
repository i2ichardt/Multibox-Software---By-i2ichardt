Imports System.Runtime.InteropServices

Public Module SharedVariables
    'If you want to keep ExcludedInputs accessible even after the form is closed, you should declare it in a module or in a class outside of the form’s class.
    Public ExcludedInputs As New List(Of String)
End Module

Public Class Settings

    Dim Input_Key As String


    'Number keys :   Keys.D0 to Keys.D9 for the top row number keys 0-9.
    'Function keys() : keys.F1 to Keys.F12 for the function keys F1-F12.
    'Arrow keys: keys.Up, keys.Down, keys.Left, keys.Right for the arrow keys.
    'Special keys: keys.Enter, keys.Space, keys.Back, keys.Delete, keys.Insert, keys.Home, keys.End, keys.PageUp, keys.PageDown For Enter, Space, Backspace, Delete, Insert, Home, End, Page Up, And Page Down keys.
    'Numpad keys: keys.NumPad0 to Keys.NumPad9 for the number pad keys 0-9.

    'Modifier keys: keys.Shift, keys.Control, keys.Alt For the Shift, Ctrl, And Alt keys.
    'Shift keys: Keys.LShiftKey for the left Shift key and Keys.RShiftKey for the right Shift key.
    'Ctrl keys :  Keys.LControlKey for the left Ctrl key And Keys.RControlKey for the right Ctrl key.
    'Alt keys :  Keys.LMenu for the left Alt key And Keys.RMenu for the right Alt key.
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click
        'Debug Purposes only, delete when form is donw being made
        TextBox1.SelectAll()
        TextBox1.Cut()
    End Sub

    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ExcludedInputs.Count > 0 Then
            For i = 0 To ExcludedInputs.Count - 1

                Dim buttonName As String = "Btn_" & ExcludedInputs.Item(i)
                Dim button As Button = TryCast(Me.Controls(buttonName), Button)
                If button IsNot Nothing Then
                    button.PerformClick()
                End If

            Next

        End If

    End Sub

    Private Sub ButtonStyling_Toggle(Button As Button)

        If Button.Tag = "False" Then
            'Exclude
            Button.ForeColor = Color.White
            Button.BackColor = Color.Red
            Button.Tag = "True"

            ExcludedInputs.Add(Input_Key)
            'List_ExcludedKeys.Items.Add(Input_Key.ToString)
        Else
            'Include
            Button.ForeColor = Color.Black
            Button.BackColor = SystemColors.ControlLightLight
            Button.Tag = "False"

            'Remove the button from the list
            ExcludedInputs.Remove(Input_Key)
            'List_ExcludedKeys.Items.Remove(Input_Key.ToString)
        End If

    End Sub

    Private Sub Settings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim buttonName As String = "Btn_" & e.KeyCode.ToString()
        Dim button As Button = TryCast(Me.Controls(buttonName), Button)
        If button IsNot Nothing Then
            button.PerformClick()
        End If

        TextBox1.Text = ("Btn_" + e.KeyCode.ToString)


    End Sub

    'Buttons need named with there enumeration in the .NET Framework  ex: Esc key --> Keys.Escape ---> Btn_Escape
    Private Sub Btn_Escape_Click(sender As Object, e As EventArgs) Handles Btn_Escape.Click
        Input_Key = "Escape"
        ButtonStyling_Toggle(sender)

    End Sub

    Private Sub Btn_F1_Click(sender As Object, e As EventArgs) Handles Btn_F1.Click
        Input_Key = "F1"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F2_Click(sender As Object, e As EventArgs) Handles Btn_F2.Click
        Input_Key = "F2"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F3_Click(sender As Object, e As EventArgs) Handles Btn_F3.Click
        Input_Key = "F3"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F4_Click(sender As Object, e As EventArgs) Handles Btn_F4.Click
        Input_Key = "F4"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F5_Click(sender As Object, e As EventArgs) Handles Btn_F5.Click
        Input_Key = "F5"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F6_Click(sender As Object, e As EventArgs) Handles Btn_F6.Click
        Input_Key = "F6"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F7_Click(sender As Object, e As EventArgs) Handles Btn_F7.Click
        Input_Key = "F7"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F8_Click(sender As Object, e As EventArgs) Handles Btn_F8.Click
        Input_Key = "F8"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F9_Click(sender As Object, e As EventArgs) Handles Btn_F9.Click
        Input_Key = "F9"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F10_Click(sender As Object, e As EventArgs) Handles Btn_F10.Click
        Input_Key = "F10"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F11_Click(sender As Object, e As EventArgs) Handles Btn_F11.Click
        Input_Key = "F11"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F12_Click(sender As Object, e As EventArgs) Handles Btn_F12.Click
        Input_Key = "F12"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oemtilde_Click(sender As Object, e As EventArgs) Handles Btn_Oemtilde.Click
        Input_Key = "Oemtilde"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D1_Click(sender As Object, e As EventArgs) Handles Btn_D1.Click
        Input_Key = "D1"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D2_Click(sender As Object, e As EventArgs) Handles Btn_D2.Click
        Input_Key = "D2"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D3_Click(sender As Object, e As EventArgs) Handles Btn_D3.Click
        Input_Key = "D3"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D4_Click(sender As Object, e As EventArgs) Handles Btn_D4.Click
        Input_Key = "D4"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D5_Click(sender As Object, e As EventArgs) Handles Btn_D5.Click
        Input_Key = "D5"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D6_Click(sender As Object, e As EventArgs) Handles Btn_D6.Click
        Input_Key = "D6"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D7_Click(sender As Object, e As EventArgs) Handles Btn_D7.Click
        Input_Key = "D7"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D8_Click(sender As Object, e As EventArgs) Handles Btn_D8.Click
        Input_Key = "D8"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D9_Click(sender As Object, e As EventArgs) Handles Btn_D9.Click
        Input_Key = "D9"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D0_Click(sender As Object, e As EventArgs) Handles Btn_D0.Click
        Input_Key = "D0"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_OemMinus_Click(sender As Object, e As EventArgs) Handles Btn_OemMinus.Click
        Input_Key = "OemMinus"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oemplus_Click(sender As Object, e As EventArgs) Handles Btn_Oemplus.Click
        Input_Key = "Oemplus"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Input_Key = "Back"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        Input_Key = "Insert"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        Input_Key = "Home"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_PageUp_Click(sender As Object, e As EventArgs) Handles Btn_PageUp.Click
        Input_Key = "PageUp"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Tab_Click(sender As Object, e As EventArgs) Handles Btn_Tab.Click
        Input_Key = "Tab"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Q_Click(sender As Object, e As EventArgs) Handles Btn_Q.Click
        Input_Key = "Q"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_W_Click(sender As Object, e As EventArgs) Handles Btn_W.Click
        Input_Key = "W"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_E_Click(sender As Object, e As EventArgs) Handles Btn_E.Click
        Input_Key = "E"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_R_Click(sender As Object, e As EventArgs) Handles Btn_R.Click
        Input_Key = "R"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_T_Click(sender As Object, e As EventArgs) Handles Btn_T.Click
        Input_Key = "T"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Y_Click(sender As Object, e As EventArgs) Handles Btn_Y.Click
        Input_Key = "Y"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_U_Click(sender As Object, e As EventArgs) Handles Btn_U.Click
        Input_Key = "U"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_I_Click(sender As Object, e As EventArgs) Handles Btn_I.Click
        Input_Key = "I"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_O_Click(sender As Object, e As EventArgs) Handles Btn_O.Click
        Input_Key = "O"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_P_Click(sender As Object, e As EventArgs) Handles Btn_P.Click
        Input_Key = "P"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_OemOpenBrackets_Click(sender As Object, e As EventArgs) Handles Btn_OemOpenBrackets.Click
        Input_Key = "OemOpenBrackets"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oem6_Click(sender As Object, e As EventArgs) Handles Btn_Oem6.Click
        Input_Key = "Oem6"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oem5_Click(sender As Object, e As EventArgs) Handles Btn_Oem5.Click
        Input_Key = "Oem5"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Input_Key = "Delete"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_End_Click(sender As Object, e As EventArgs) Handles Btn_End.Click
        Input_Key = "End"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click
        Input_Key = "Next"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Capital_Click(sender As Object, e As EventArgs) Handles Btn_Capital.Click
        Input_Key = "Capital"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_A_Click(sender As Object, e As EventArgs) Handles Btn_A.Click
        Input_Key = "A"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_S_Click(sender As Object, e As EventArgs) Handles Btn_S.Click
        Input_Key = "S"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_D_Click(sender As Object, e As EventArgs) Handles Btn_D.Click
        Input_Key = "D"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_F_Click(sender As Object, e As EventArgs) Handles Btn_F.Click
        Input_Key = "F"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_G_Click(sender As Object, e As EventArgs) Handles Btn_G.Click
        Input_Key = "G"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_H_Click(sender As Object, e As EventArgs) Handles Btn_H.Click
        Input_Key = "H"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_J_Click(sender As Object, e As EventArgs) Handles Btn_J.Click
        Input_Key = "J"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_K_Click(sender As Object, e As EventArgs) Handles Btn_K.Click
        Input_Key = "K"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_L_Click(sender As Object, e As EventArgs) Handles Btn_L.Click
        Input_Key = "L"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oem1_Click(sender As Object, e As EventArgs) Handles Btn_Oem1.Click
        Input_Key = "Oem1"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oem7_Click(sender As Object, e As EventArgs) Handles Btn_Oem7.Click
        Input_Key = "Oem7"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Return_Click(sender As Object, e As EventArgs) Handles Btn_Return.Click
        Input_Key = "Return"
        ButtonStyling_Toggle(sender)
        ButtonStyling_Toggle(Btn_Return2)
    End Sub

    Private Sub Btn_ShiftKey_Click(sender As Object, e As EventArgs) Handles Btn_ShiftKey.Click
        Input_Key = "ShiftKey"
        ButtonStyling_Toggle(sender)

        'Toggle other Shiftkey also, Can't distinguish between them using the method im using to send inputs to window
        ButtonStyling_Toggle(Btn_ShiftKey2)
    End Sub

    Private Sub Btn_Z_Click(sender As Object, e As EventArgs) Handles Btn_Z.Click
        Input_Key = "Z"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_X_Click(sender As Object, e As EventArgs) Handles Btn_X.Click
        Input_Key = "X"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_C_Click(sender As Object, e As EventArgs) Handles Btn_C.Click
        Input_Key = "C"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_V_Click(sender As Object, e As EventArgs) Handles Btn_V.Click
        Input_Key = "V"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_B_Click(sender As Object, e As EventArgs) Handles Btn_B.Click
        Input_Key = "B"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_N_Click(sender As Object, e As EventArgs) Handles Btn_N.Click
        Input_Key = "N"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_M_Click(sender As Object, e As EventArgs) Handles Btn_M.Click
        Input_Key = "M"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Oemcomma_Click(sender As Object, e As EventArgs) Handles Btn_Oemcomma.Click
        Input_Key = "Oemcomma"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_OemPeriod_Click(sender As Object, e As EventArgs) Handles Btn_OemPeriod.Click
        Input_Key = "OemPeriod"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_OemQuestion_Click(sender As Object, e As EventArgs) Handles Btn_OemQuestion.Click
        Input_Key = "OemQuestion"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_ControlKey_Click(sender As Object, e As EventArgs) Handles Btn_ControlKey.Click
        Input_Key = "ControlKey"
        ButtonStyling_Toggle(sender)

        'Toggle Other Ctrl key also, Can't distinguish between them using the method im using to send inputs to window
        ButtonStyling_Toggle(Btn_ControlKey2)
    End Sub

    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        Input_Key = "Menu"
        ButtonStyling_Toggle(sender)

        'Toggle Other Alt key also, Can't distinguish between them using the method im using to send inputs to window
        ButtonStyling_Toggle(Btn_Menu2)
    End Sub

    Private Sub Btn_Space_Click(sender As Object, e As EventArgs) Handles Btn_Space.Click
        Input_Key = "Space"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Left_Click(sender As Object, e As EventArgs) Handles Btn_Left.Click
        Input_Key = "Left"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Down_Click(sender As Object, e As EventArgs) Handles Btn_Down.Click
        Input_Key = "Down"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Right_Click(sender As Object, e As EventArgs) Handles Btn_Right.Click
        Input_Key = "Right"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Up_Click(sender As Object, e As EventArgs) Handles Btn_Up.Click
        Input_Key = "Up"
        ButtonStyling_Toggle(sender)
    End Sub


    Private Sub Btn_Divide_Click(sender As Object, e As EventArgs) Handles Btn_Divide.Click
        Input_Key = "Divide"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Multiply_Click(sender As Object, e As EventArgs) Handles Btn_Multiply.Click
        Input_Key = "Multiply"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Subtract_Click(sender As Object, e As EventArgs) Handles Btn_Subtract.Click
        Input_Key = "Subtract"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad7_Click(sender As Object, e As EventArgs) Handles Btn_NumPad7.Click
        Input_Key = "NumPad7"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad8_Click(sender As Object, e As EventArgs) Handles Btn_NumPad8.Click
        Input_Key = "NumPad8"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad9_Click(sender As Object, e As EventArgs) Handles Btn_NumPad9.Click
        Input_Key = "NumPad9"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Input_Key = "Add"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad4_Click(sender As Object, e As EventArgs) Handles Btn_NumPad4.Click
        Input_Key = "NumPad4"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad5_Click(sender As Object, e As EventArgs) Handles Btn_NumPad5.Click
        Input_Key = "NumPad5"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad6_Click(sender As Object, e As EventArgs) Handles Btn_NumPad6.Click
        Input_Key = "NumPad6"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad1_Click(sender As Object, e As EventArgs) Handles Btn_NumPad1.Click
        Input_Key = "NumPad1"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad2_Click(sender As Object, e As EventArgs) Handles Btn_NumPad2.Click
        Input_Key = "NumPad2"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad3_Click(sender As Object, e As EventArgs) Handles Btn_NumPad3.Click
        Input_Key = "NumPad3"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_NumPad0_Click(sender As Object, e As EventArgs) Handles Btn_NumPad0.Click
        Input_Key = "NumPad0"
        ButtonStyling_Toggle(sender)
    End Sub

    Private Sub Btn_Decimal_Click(sender As Object, e As EventArgs) Handles Btn_Decimal.Click
        Input_Key = "Decimal"
        ButtonStyling_Toggle(sender)
    End Sub


End Class