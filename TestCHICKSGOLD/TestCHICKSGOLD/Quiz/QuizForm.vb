
Imports System.Data.SqlClient
Public Class QuizForm

    Private Connetion As New SqlConnection
    Private _Sql As String
    Private db As DataSet
    Private dbCount As Integer

    Private _ArrQuestions(2, vGlobal.QuestionsCap)

#Region "FunctionsDB"

    Private Function OpenDB() As Boolean

        Try
            Dim ConnectionStr As String = vGlobal.ConnectionStr

            Connetion = New SqlConnection(ConnectionStr)

            If (Connetion.State = ConnectionState.Closed) Then Connetion.Open()


            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
            Return False
        End Try

    End Function

    Private Function CloseDB() As Boolean

        Try

            If (Connetion.State = ConnectionState.Open) Then Connetion.Close()


            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
            Return False
        End Try

    End Function

    Private Function QueryDB(Sql As String) As String

        Try

            Dim _Return As String = "E"

            If (OpenDB() = False) Then Return _Return

            db = New DataSet()

            Dim adapter As SqlDataAdapter = New SqlDataAdapter()
            adapter.SelectCommand = New SqlCommand(Sql, Connetion)
            adapter.Fill(db)

            dbCount = db.Tables(0).Rows.Count

            If (dbCount > 0) Then
                _Return = "Y"
            Else
                _Return = "N"
            End If

            If (CloseDB() = False) Then Return "E"

            Return _Return


        Catch ex As Exception
            CloseDB()
            MessageBox.Show(ex.Message.ToString(), "Message")
            Return "E"

        End Try

    End Function

    Private Function ExecuteDB(Sql As String) As Boolean

        Try

            If (OpenDB() = False) Then Return False

            Dim sqlcom As SqlCommand = New SqlCommand(Sql, Connetion)

            sqlcom.ExecuteNonQuery()

            CloseDB()

            Return True


        Catch ex As Exception
            CloseDB()
            MessageBox.Show(ex.Message.ToString(), "Message")
            Return False

        End Try

    End Function


#End Region



#Region "FunctionsSubGenerals"

    Private Sub Validate_responses()

        Dim _CountCorrect As Integer = 0
        Dim _CountIncorrect As Integer = 0


        'response verification

        For jh = 0 To ListView1.Items.Count - 1

            If ListView1.Items(jh).SubItems(4).Text.ToLower.Trim() <> _ArrQuestions(1, jh).ToString().ToLower.Trim() Then
                ListView1.Items(jh).SubItems(5).Text = "Incorrect"
                ListView1.Items(jh).SubItems(6).Text = "Correct: " & _ArrQuestions(1, jh).ToString()
                ListView1.Items(jh).SubItems(3).Text = "Checked"
                ListView1.Items(jh).BackColor = Color.LightPink
                _CountIncorrect += 1
            Else
                ListView1.Items(jh).SubItems(3).Text = "Checked"
                ListView1.Items(jh).SubItems(5).Text = "Correct"
                _CountCorrect += 1
            End If

            ListView1.Items(jh).Selected = False

        Next


        _Sql = "insert into testResult(UserId, totalQuestions, numberCorrect, testDateTime ) values (" &
           vGlobal.UserId & ", " & CInt(lblTotalQuestions.Text.ToString()) & ", " & _CountCorrect & ", " & "getdate())"


        If ExecuteDB(_Sql) = False Then
            Return
        End If

        lblTotalCorrect.Text = _CountCorrect
        lblTotalInCorrect.Text = _CountIncorrect

    End Sub

    Private Sub List_questions()

        ListView1.Items.Clear()

        _Sql = $"Select top " & vGlobal.QuestionsCap & " StateId, state, capital " &
          "from [State] " &
          "ORDER BY newid() "


        Select Case (QueryDB(_Sql))
            Case "E"
                Return
            Case "N"
                MessageBox.Show("Sorry, no questions found", "Message")
                Return

        End Select

        Dim itms As ListViewItem
        For jh = 0 To dbCount - 1

            itms = New ListViewItem(jh)
            itms.SubItems.Add(Val(db.Tables(0).Rows(jh)("StateId").ToString()))
            itms.SubItems.Add(Trim(db.Tables(0).Rows(jh)("state").ToString()))
            itms.SubItems.Add("Pending")
            itms.SubItems.Add("")
            itms.SubItems.Add("")
            itms.SubItems.Add("")
            ListView1.Items.Add(itms)

            'is saved for later comparison with user responses

            _ArrQuestions(0, jh) = Val(db.Tables(0).Rows(jh)("StateId").ToString())
            _ArrQuestions(1, jh) = Trim(db.Tables(0).Rows(jh)("capital").ToString())

        Next


        lblTotalQuestions.Text = dbCount.ToString()

        ListView1.Items(0).Selected = True
    End Sub


    Private Sub Clear()

        lblIndex.Text = ""
        txtIdState.Text = ""
        txtCapital.Text = ""
        txtState.Text = ""

        lblTotalCorrect.Text = ""
        lblTotalInCorrect.Text = ""

        lblTotalQuestions.Text = 0
        lblAnswe.Text = 0

    End Sub

#End Region

    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ListView1.View = View.Details
            ListView1.GridLines = True

            btnTryAgain_Click(Nothing, e)


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
        End Try


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Try

            If (ListView1.Items.Count = 0) Then Return

            If ListView1.SelectedItems().Count = 0 Then Return

            txtIdState.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtState.Text = ListView1.SelectedItems(0).SubItems(2).Text

            'position in the list
            'is hidden

            lblIndex.Text = ListView1.SelectedItems(0).SubItems(0).Text

            txtCapital.Text = ""

            txtCapital.Focus()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If (ListView1.Items.Count = 0) Then Return

            If (CInt(lblAnswe.Text)) = lblTotalQuestions.Text Then Return


            If (lblIndex.Text.Trim() = "") Then
                MessageBox.Show("Select a question", "Message")
                Return
            End If

            If (txtCapital.Text.Trim() = "") Then
                MessageBox.Show("Enter a capital", "Message")
                txtCapital.Focus()
                Return
            End If

            If ListView1.Items(CInt(lblIndex.Text)).SubItems(3).Text = "Pending" Then
                lblAnswe.Text = CInt(lblAnswe.Text) + 1
            End If

            ListView1.Items(CInt(lblIndex.Text)).SubItems(3).Text = "To be checked"
            ListView1.Items(CInt(lblIndex.Text)).SubItems(4).Text = txtCapital.Text.Trim()


            If (CInt(lblAnswe.Text)) = lblTotalQuestions.Text Then
                lblIndex.Text = ""
                txtIdState.Text = ""
                txtCapital.Text = ""
                txtState.Text = ""
                Validate_responses()
                grpResults.Visible = True
                Return
            End If

            For jh = 0 To ListView1.Items.Count - 1

                If ListView1.Items(jh).SubItems(3).Text = "Pending" Then
                    ListView1.Items(jh).Selected = True
                    Exit For
                End If

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
        End Try

    End Sub

    Private Sub txtCapital_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapital.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then btnSave_Click(Nothing, e)
    End Sub



    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        Clear()
        List_questions()
        grpResults.Visible = False
        txtCapital.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class