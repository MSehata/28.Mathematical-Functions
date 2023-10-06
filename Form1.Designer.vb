<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnAbs = New Button()
        btnInt = New Button()
        btnLog = New Button()
        btnRnd = New Button()
        btnRound = New Button()
        btnClose = New Button()
        btnExp = New Button()
        btnFix = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumber = New TextBox()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' btnAbs
        ' 
        btnAbs.Location = New Point(167, 260)
        btnAbs.Name = "btnAbs"
        btnAbs.Size = New Size(94, 29)
        btnAbs.TabIndex = 0
        btnAbs.Text = "Absolute"
        btnAbs.UseVisualStyleBackColor = True
        ' 
        ' btnInt
        ' 
        btnInt.Location = New Point(84, 330)
        btnInt.Name = "btnInt"
        btnInt.Size = New Size(94, 29)
        btnInt.TabIndex = 0
        btnInt.Text = "Int"
        btnInt.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Location = New Point(260, 330)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(94, 29)
        btnLog.TabIndex = 0
        btnLog.Text = "Log"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' btnRnd
        ' 
        btnRnd.Location = New Point(447, 330)
        btnRnd.Name = "btnRnd"
        btnRnd.Size = New Size(94, 29)
        btnRnd.TabIndex = 0
        btnRnd.Text = "Rnd()"
        btnRnd.UseVisualStyleBackColor = True
        ' 
        ' btnRound
        ' 
        btnRound.Location = New Point(625, 330)
        btnRound.Name = "btnRound"
        btnRound.Size = New Size(94, 29)
        btnRound.TabIndex = 0
        btnRound.Text = "Round"
        btnRound.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(351, 393)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnExp
        ' 
        btnExp.Location = New Point(345, 260)
        btnExp.Name = "btnExp"
        btnExp.Size = New Size(94, 29)
        btnExp.TabIndex = 0
        btnExp.Text = "Exponent"
        btnExp.UseVisualStyleBackColor = True
        ' 
        ' btnFix
        ' 
        btnFix.Location = New Point(531, 260)
        btnFix.Name = "btnFix"
        btnFix.Size = New Size(94, 29)
        btnFix.TabIndex = 0
        btnFix.Text = "Fix"
        btnFix.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(115, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(581, 30)
        Label1.TabIndex = 1
        Label1.Text = "Click the function you will like to check"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter a number to work with"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(115, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 20)
        Label3.TabIndex = 2
        Label3.Text = "The result from your Function"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(416, 123)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(159, 27)
        txtNumber.TabIndex = 3
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(416, 174)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(159, 27)
        txtResult.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtResult)
        Controls.Add(txtNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRound)
        Controls.Add(btnRnd)
        Controls.Add(btnClose)
        Controls.Add(btnFix)
        Controls.Add(btnLog)
        Controls.Add(btnExp)
        Controls.Add(btnInt)
        Controls.Add(btnAbs)
        Name = "Form1"
        Text = "Mathematical Functions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAbs As Button
    Friend WithEvents btnInt As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents btnRnd As Button
    Friend WithEvents btnRound As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnFix As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtResult As TextBox
End Class
