<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuizForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblTotalInCorrect = New System.Windows.Forms.Label()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.lblTotalCorrect = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdState = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalQuestions = New System.Windows.Forms.Label()
        Me.lblAnswe = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl222 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Index = New System.Windows.Forms.ColumnHeader()
        Me.Id = New System.Windows.Forms.ColumnHeader()
        Me.State = New System.Windows.Forms.ColumnHeader()
        Me.Status = New System.Windows.Forms.ColumnHeader()
        Me.Response = New System.Windows.Forms.ColumnHeader()
        Me.Result = New System.Windows.Forms.ColumnHeader()
        Me.Observation = New System.Windows.Forms.ColumnHeader()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grpResults)
        Me.GroupBox1.Controls.Add(Me.lblIndex)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdState)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCapital)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(692, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 381)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'grpResults
        '
        Me.grpResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResults.Controls.Add(Me.lblTotalInCorrect)
        Me.grpResults.Controls.Add(Me.btnTryAgain)
        Me.grpResults.Controls.Add(Me.lblTotalCorrect)
        Me.grpResults.Controls.Add(Me.Label6)
        Me.grpResults.Controls.Add(Me.Label7)
        Me.grpResults.Location = New System.Drawing.Point(0, 0)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(438, 381)
        Me.grpResults.TabIndex = 18
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        Me.grpResults.Visible = False
        '
        'lblTotalInCorrect
        '
        Me.lblTotalInCorrect.AutoSize = True
        Me.lblTotalInCorrect.Location = New System.Drawing.Point(114, 79)
        Me.lblTotalInCorrect.Name = "lblTotalInCorrect"
        Me.lblTotalInCorrect.Size = New System.Drawing.Size(13, 15)
        Me.lblTotalInCorrect.TabIndex = 22
        Me.lblTotalInCorrect.Text = "0"
        '
        'btnTryAgain
        '
        Me.btnTryAgain.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTryAgain.ForeColor = System.Drawing.Color.White
        Me.btnTryAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTryAgain.Location = New System.Drawing.Point(114, 162)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(234, 30)
        Me.btnTryAgain.TabIndex = 17
        Me.btnTryAgain.Text = "Try again"
        Me.btnTryAgain.UseVisualStyleBackColor = False
        '
        'lblTotalCorrect
        '
        Me.lblTotalCorrect.AutoSize = True
        Me.lblTotalCorrect.Location = New System.Drawing.Point(114, 49)
        Me.lblTotalCorrect.Name = "lblTotalCorrect"
        Me.lblTotalCorrect.Size = New System.Drawing.Size(13, 15)
        Me.lblTotalCorrect.TabIndex = 21
        Me.lblTotalCorrect.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total correct"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total incorrect"
        '
        'lblIndex
        '
        Me.lblIndex.Location = New System.Drawing.Point(114, 133)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.ReadOnly = True
        Me.lblIndex.Size = New System.Drawing.Size(47, 23)
        Me.lblIndex.TabIndex = 17
        Me.lblIndex.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "You must respond to the state capital"
        '
        'txtIdState
        '
        Me.txtIdState.Location = New System.Drawing.Point(374, 56)
        Me.txtIdState.Name = "txtIdState"
        Me.txtIdState.ReadOnly = True
        Me.txtIdState.Size = New System.Drawing.Size(47, 23)
        Me.txtIdState.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "State:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(114, 56)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(254, 23)
        Me.txtState.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Capital:"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(114, 94)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(307, 23)
        Me.txtCapital.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(306, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 30)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblTotalQuestions)
        Me.GroupBox2.Controls.Add(Me.lblAnswe)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lbl222)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 381)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Questions"
        '
        'lblTotalQuestions
        '
        Me.lblTotalQuestions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalQuestions.AutoSize = True
        Me.lblTotalQuestions.Location = New System.Drawing.Point(99, 352)
        Me.lblTotalQuestions.Name = "lblTotalQuestions"
        Me.lblTotalQuestions.Size = New System.Drawing.Size(13, 15)
        Me.lblTotalQuestions.TabIndex = 20
        Me.lblTotalQuestions.Text = "0"
        '
        'lblAnswe
        '
        Me.lblAnswe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnswe.AutoSize = True
        Me.lblAnswe.Location = New System.Drawing.Point(637, 352)
        Me.lblAnswe.Name = "lblAnswe"
        Me.lblAnswe.Size = New System.Drawing.Size(13, 15)
        Me.lblAnswe.TabIndex = 19
        Me.lblAnswe.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(572, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Answered"
        '
        'lbl222
        '
        Me.lbl222.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl222.AutoSize = True
        Me.lbl222.Location = New System.Drawing.Point(7, 352)
        Me.lbl222.Name = "lbl222"
        Me.lbl222.Size = New System.Drawing.Size(86, 15)
        Me.lbl222.TabIndex = 14
        Me.lbl222.Text = "Total questions"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Index, Me.Id, Me.State, Me.Status, Me.Response, Me.Result, Me.Observation})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 17)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(662, 316)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Index
        '
        Me.Index.DisplayIndex = 5
        Me.Index.Text = "Index"
        Me.Index.Width = 0
        '
        'Id
        '
        Me.Id.DisplayIndex = 0
        Me.Id.Text = "Id"
        Me.Id.Width = 40
        '
        'State
        '
        Me.State.DisplayIndex = 1
        Me.State.Text = "State"
        Me.State.Width = 110
        '
        'Status
        '
        Me.Status.DisplayIndex = 2
        Me.Status.Text = "Status"
        Me.Status.Width = 120
        '
        'Response
        '
        Me.Response.DisplayIndex = 3
        Me.Response.Text = "Response"
        Me.Response.Width = 150
        '
        'Result
        '
        Me.Result.DisplayIndex = 4
        Me.Result.Text = "Result"
        Me.Result.Width = 100
        '
        'Observation
        '
        Me.Observation.Text = "Observation"
        Me.Observation.Width = 150
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1015, 403)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 30)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 445)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuizForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdState As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl222 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents State As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Response As ColumnHeader
    Friend WithEvents Result As ColumnHeader
    Friend WithEvents lblTotalQuestions As Label
    Friend WithEvents lblAnswe As Label
    Friend WithEvents lblTotalInCorrect As Label
    Friend WithEvents lblTotalCorrect As Label
    Private WithEvents Index As ColumnHeader
    Friend WithEvents lblIndex As TextBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents btnTryAgain As Button
    Friend WithEvents Observation As ColumnHeader
    Friend WithEvents btnClose As Button
End Class
