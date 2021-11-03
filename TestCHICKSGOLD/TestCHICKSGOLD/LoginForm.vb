
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class LoginForm

    Private Connetion As New SqlConnection
    Private _Sql As String
    Private db As DataSet
    Private dbCount As Integer

    Private _CountAttempts As Integer = 0


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


#End Region


#Region "FunctionsGenerals"

    Public Function Validate_String(ByVal Cadena As String) As Boolean

        Validate_String = False
        Dim _reservedWords = ""
        Dim tReservados() As String


        _reservedWords = "'|;|-| UPDATE| INSERT| DELETE| TRUNCATE| DROP| DATABASE| TABLE| ALTER"

        tReservados = Split(_reservedWords, "|")
        Dim tCaracter As String = ""
        Dim tCaracterEspacio As String = ""
        Dim tCaracterPC As String = ""
        Validate_String = True

        For jh = 0 To tReservados.Length - 1

            tCaracter = UCase(Trim(tReservados(jh).Trim()))

            If InStr(Cadena, tCaracter, CompareMethod.Text) > 0 Then

                tCaracterEspacio = " " & tCaracter
                tCaracterPC = ";" & tCaracter

                If InStr(" " & Cadena, tCaracterEspacio, CompareMethod.Text) > 0 Or InStr(Cadena, tCaracterPC, CompareMethod.Text) > 0 Then

                    Validate_String = False
                    Exit Function

                End If

            End If

        Next



        Return Validate_String

    End Function


#End Region




    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click


        If txtUser.Text.Trim() = "" Then
            MessageBox.Show("Sorry, you must enter your username", "Message")
            Return
        End If

        'for keys it is recommended to encrypt them

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Sorry, you must enter your password", "Message")
            Return
        End If

        _CountAttempts += 1

        'to avoid sql injection

        If Validate_String(txtUser.Text.Trim()) = False Then

            If _CountAttempts = 3 Then
                MessageBox.Show("Sorry, you reached the limit of allowed attempts", "Message")
                Me.Close()
                Return
            Else
                MessageBox.Show("Sorry, Username or password incorrect, you have 3 attempts", "Message")
                Return
            End If
        End If

        If Validate_String(txtPassword.Text.Trim()) = False Then

            If _CountAttempts = 3 Then
                MessageBox.Show("Sorry, you reached the limit of allowed attempts", "Message")
                Me.Close()
                Return
            Else
                MessageBox.Show("Sorry, Username or password incorrect, you have 3 attempts", "Message")
                Return
            End If

        End If

        _Sql = $"Select UserId, userName " &
              "from [User] where userName = '" & txtUser.Text & "' and " &
              "password = '" & txtPassword.Text & "' "

        Try


            Select Case (QueryDB(_Sql))
                Case "E"
                    Return
                Case "N"

                    If _CountAttempts = 3 Then
                        MessageBox.Show("Sorry, you reached the limit of allowed attempts", "Message")
                        Me.Close()
                        Return
                    Else
                        MessageBox.Show("Sorry, Username or password incorrect, you have 3 attempts", "Message")
                        Return
                    End If

            End Select

            vGlobal.IsLogin = True
            vGlobal.UserId = Val(db.Tables(0).Rows(0)("UserId").ToString())
            vGlobal.UserName = Trim(db.Tables(0).Rows(0)("userName").ToString())


            MessageBox.Show("Welcome " & vGlobal.UserName, "Message")



            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Message")
        End Try
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then btnSignIn_Click(Nothing, e)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        vGlobal.UserId = 0
        vGlobal.UserName = ""

        vGlobal.IsLogin = False
        txtUser.Focus()
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress

        'only letters

        If Char.IsLetter(e.KeyChar) Then
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
