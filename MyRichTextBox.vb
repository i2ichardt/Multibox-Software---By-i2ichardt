Public Class MyRichTextBox
    Inherits RichTextBox

    Private _isDisabled As Boolean
    Private _leftMargin As Integer

    Public Property IsDisabled As Boolean
        Get
            Return _isDisabled
        End Get
        Set(value As Boolean)
            _isDisabled = value
            Invalidate() ' Redraw the control
        End Set
    End Property

    Public Property LeftMargin As Integer
        Get
            Return _leftMargin
        End Get
        Set(value As Integer)
            _leftMargin = value
            Me.SelectionIndent = _leftMargin
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' If the control is "disabled", ignore all mouse and keyboard messages
        If _isDisabled AndAlso (m.Msg >= &H200 AndAlso m.Msg <= &H20D OrElse m.Msg >= &H100 AndAlso m.Msg <= &H109) Then
            Return
        End If

        MyBase.WndProc(m)
    End Sub

    Public Sub New()
        ' Set the cursor to default
        Me.Cursor = Cursors.Default
    End Sub
End Class