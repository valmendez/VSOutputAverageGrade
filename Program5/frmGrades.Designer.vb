<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrades))
        Me.lblEnterGrades = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.txtAverageGoal = New System.Windows.Forms.TextBox()
        Me.lblScore100 = New System.Windows.Forms.Label()
        Me.txtLetterGrade = New System.Windows.Forms.TextBox()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.picMediocre = New System.Windows.Forms.PictureBox()
        Me.picUpset = New System.Windows.Forms.PictureBox()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.grpInput.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMediocre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEnterGrades
        '
        Me.lblEnterGrades.AutoSize = True
        Me.lblEnterGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterGrades.Location = New System.Drawing.Point(6, 26)
        Me.lblEnterGrades.Name = "lblEnterGrades"
        Me.lblEnterGrades.Size = New System.Drawing.Size(98, 16)
        Me.lblEnterGrades.TabIndex = 0
        Me.lblEnterGrades.Text = "Enter 5 grades:"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnEnter)
        Me.grpInput.Controls.Add(Me.txtGrade5)
        Me.grpInput.Controls.Add(Me.txtGrade4)
        Me.grpInput.Controls.Add(Me.txtGrade3)
        Me.grpInput.Controls.Add(Me.txtGrade2)
        Me.grpInput.Controls.Add(Me.txtGrade1)
        Me.grpInput.Controls.Add(Me.lblEnterGrades)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(307, 158)
        Me.grpInput.TabIndex = 1
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "grpInput"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEnter.Location = New System.Drawing.Point(226, 129)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtGrade5
        '
        Me.txtGrade5.Location = New System.Drawing.Point(110, 129)
        Me.txtGrade5.Name = "txtGrade5"
        Me.txtGrade5.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade5.TabIndex = 6
        '
        'txtGrade4
        '
        Me.txtGrade4.Location = New System.Drawing.Point(110, 103)
        Me.txtGrade4.Name = "txtGrade4"
        Me.txtGrade4.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade4.TabIndex = 5
        '
        'txtGrade3
        '
        Me.txtGrade3.Location = New System.Drawing.Point(110, 77)
        Me.txtGrade3.Name = "txtGrade3"
        Me.txtGrade3.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade3.TabIndex = 4
        '
        'txtGrade2
        '
        Me.txtGrade2.Location = New System.Drawing.Point(110, 51)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade2.TabIndex = 3
        '
        'txtGrade1
        '
        Me.txtGrade1.Location = New System.Drawing.Point(110, 25)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade1.TabIndex = 2
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.txtAverageGoal)
        Me.grpOutput.Controls.Add(Me.lblScore100)
        Me.grpOutput.Controls.Add(Me.txtLetterGrade)
        Me.grpOutput.Controls.Add(Me.picHappy)
        Me.grpOutput.Controls.Add(Me.picMediocre)
        Me.grpOutput.Controls.Add(Me.picUpset)
        Me.grpOutput.Controls.Add(Me.lblReset)
        Me.grpOutput.Controls.Add(Me.btnExit)
        Me.grpOutput.Controls.Add(Me.btnReset)
        Me.grpOutput.Controls.Add(Me.lblLetterGrade)
        Me.grpOutput.Controls.Add(Me.txtAverage)
        Me.grpOutput.Controls.Add(Me.lblAverage)
        Me.grpOutput.Location = New System.Drawing.Point(336, 12)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(452, 330)
        Me.grpOutput.TabIndex = 2
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "grpOutput"
        Me.grpOutput.Visible = False
        '
        'txtAverageGoal
        '
        Me.txtAverageGoal.Location = New System.Drawing.Point(304, 84)
        Me.txtAverageGoal.Name = "txtAverageGoal"
        Me.txtAverageGoal.ReadOnly = True
        Me.txtAverageGoal.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageGoal.TabIndex = 12
        '
        'lblScore100
        '
        Me.lblScore100.AutoSize = True
        Me.lblScore100.Location = New System.Drawing.Point(19, 84)
        Me.lblScore100.Name = "lblScore100"
        Me.lblScore100.Size = New System.Drawing.Size(279, 13)
        Me.lblScore100.TabIndex = 3
        Me.lblScore100.Text = "If you score 100 on the next assignment, your average is: "
        '
        'txtLetterGrade
        '
        Me.txtLetterGrade.Location = New System.Drawing.Point(99, 58)
        Me.txtLetterGrade.Name = "txtLetterGrade"
        Me.txtLetterGrade.ReadOnly = True
        Me.txtLetterGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtLetterGrade.TabIndex = 11
        '
        'picHappy
        '
        Me.picHappy.Image = CType(resources.GetObject("picHappy.Image"), System.Drawing.Image)
        Me.picHappy.Location = New System.Drawing.Point(119, 103)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(178, 172)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappy.TabIndex = 9
        Me.picHappy.TabStop = False
        Me.picHappy.Visible = False
        '
        'picMediocre
        '
        Me.picMediocre.Image = CType(resources.GetObject("picMediocre.Image"), System.Drawing.Image)
        Me.picMediocre.Location = New System.Drawing.Point(120, 103)
        Me.picMediocre.Name = "picMediocre"
        Me.picMediocre.Size = New System.Drawing.Size(177, 172)
        Me.picMediocre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMediocre.TabIndex = 8
        Me.picMediocre.TabStop = False
        Me.picMediocre.Visible = False
        '
        'picUpset
        '
        Me.picUpset.Image = CType(resources.GetObject("picUpset.Image"), System.Drawing.Image)
        Me.picUpset.Location = New System.Drawing.Point(120, 107)
        Me.picUpset.Name = "picUpset"
        Me.picUpset.Size = New System.Drawing.Size(177, 168)
        Me.picUpset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUpset.TabIndex = 3
        Me.picUpset.TabStop = False
        Me.picUpset.Visible = False
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.Location = New System.Drawing.Point(6, 302)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(166, 16)
        Me.lblReset.TabIndex = 3
        Me.lblReset.Text = "I want to try it again! -->"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Location = New System.Drawing.Point(371, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnReset.Location = New System.Drawing.Point(178, 302)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Location = New System.Drawing.Point(19, 58)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(67, 13)
        Me.lblLetterGrade.TabIndex = 3
        Me.lblLetterGrade.Text = "Letter grade:"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(99, 29)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 4
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(19, 29)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(74, 13)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Your average:"
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmGrades"
        Me.Text = "5Grades"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMediocre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEnterGrades As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtGrade5 As TextBox
    Friend WithEvents txtGrade4 As TextBox
    Friend WithEvents txtGrade3 As TextBox
    Friend WithEvents txtGrade2 As TextBox
    Friend WithEvents txtGrade1 As TextBox
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblLetterGrade As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents picHappy As PictureBox
    Friend WithEvents picMediocre As PictureBox
    Friend WithEvents picUpset As PictureBox
    Friend WithEvents lblReset As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtLetterGrade As TextBox
    Friend WithEvents txtAverageGoal As TextBox
    Friend WithEvents lblScore100 As Label
End Class
