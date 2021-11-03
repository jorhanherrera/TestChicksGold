Public Class SetupForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCap.Text = "" Then
            MessageBox.Show("Enter a value", "Message")
            Return
        End If

        If IsNumeric(txtCap.Text) = False Then
            MessageBox.Show("Invalid value", "Message")
            Return
        End If

        'Another recommendation would be to save it in a configuration table in the database.

        vGlobal.QuestionsCap = CInt(txtCap.Text)

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCap.Text = vGlobal.QuestionsCap
    End Sub

    Private Sub txtCap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCap.KeyPress
        'only numbers

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class