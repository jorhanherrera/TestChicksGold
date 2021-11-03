Public Class HomeForm
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _Window As LoginForm = New LoginForm
        _Window.ShowDialog()
        _Window.Dispose()

        If vGlobal.IsLogin = False Then
            Application.Exit()
            Return
        End If

        Dim _Window2 As QuizForm = New QuizForm
        _Window2.ShowDialog()
        _Window2.Dispose()

        'Application.Exit()
        'Return

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
        Return
    End Sub

    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        Dim _Window As QuizForm = New QuizForm
        _Window.ShowDialog()
        _Window.Dispose()
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        Dim _Window As SetupForm = New SetupForm
        _Window.ShowDialog()
        _Window.Dispose()
    End Sub
End Class