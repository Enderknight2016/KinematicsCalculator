<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKinematicsCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbTime1 = New System.Windows.Forms.RadioButton()
        Me.rbDisplacement1 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityInitial1 = New System.Windows.Forms.RadioButton()
        Me.rbAcceleration1 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityFinal1 = New System.Windows.Forms.RadioButton()
        Me.txtVariable1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTime2 = New System.Windows.Forms.RadioButton()
        Me.rbDisplacement2 = New System.Windows.Forms.RadioButton()
        Me.rbAcceleration2 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityInitial2 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityFinal2 = New System.Windows.Forms.RadioButton()
        Me.txtVariable2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTime3 = New System.Windows.Forms.RadioButton()
        Me.rbDisplacement3 = New System.Windows.Forms.RadioButton()
        Me.rbAcceleration3 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityInitial3 = New System.Windows.Forms.RadioButton()
        Me.rbVelocityFinal3 = New System.Windows.Forms.RadioButton()
        Me.txtVariable3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(264, 346)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(144, 36)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 346)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(158, 36)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTime1)
        Me.GroupBox1.Controls.Add(Me.rbDisplacement1)
        Me.GroupBox1.Controls.Add(Me.rbVelocityInitial1)
        Me.GroupBox1.Controls.Add(Me.rbAcceleration1)
        Me.GroupBox1.Controls.Add(Me.rbVelocityFinal1)
        Me.GroupBox1.Controls.Add(Me.txtVariable1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First Variable"
        '
        'rbTime1
        '
        Me.rbTime1.AutoSize = True
        Me.rbTime1.Location = New System.Drawing.Point(246, 47)
        Me.rbTime1.Name = "rbTime1"
        Me.rbTime1.Size = New System.Drawing.Size(62, 17)
        Me.rbTime1.TabIndex = 5
        Me.rbTime1.TabStop = True
        Me.rbTime1.Text = "Time (s)"
        Me.rbTime1.UseVisualStyleBackColor = True
        '
        'rbDisplacement1
        '
        Me.rbDisplacement1.AutoSize = True
        Me.rbDisplacement1.Location = New System.Drawing.Point(246, 21)
        Me.rbDisplacement1.Name = "rbDisplacement1"
        Me.rbDisplacement1.Size = New System.Drawing.Size(106, 17)
        Me.rbDisplacement1.TabIndex = 4
        Me.rbDisplacement1.TabStop = True
        Me.rbDisplacement1.Text = "Displacement (m)"
        Me.rbDisplacement1.UseVisualStyleBackColor = True
        '
        'rbVelocityInitial1
        '
        Me.rbVelocityInitial1.AutoSize = True
        Me.rbVelocityInitial1.Location = New System.Drawing.Point(124, 22)
        Me.rbVelocityInitial1.Name = "rbVelocityInitial1"
        Me.rbVelocityInitial1.Size = New System.Drawing.Size(116, 17)
        Me.rbVelocityInitial1.TabIndex = 3
        Me.rbVelocityInitial1.TabStop = True
        Me.rbVelocityInitial1.Text = "Initial Velocity (m/s)"
        Me.rbVelocityInitial1.UseVisualStyleBackColor = True
        '
        'rbAcceleration1
        '
        Me.rbAcceleration1.AutoSize = True
        Me.rbAcceleration1.Location = New System.Drawing.Point(124, 47)
        Me.rbAcceleration1.Name = "rbAcceleration1"
        Me.rbAcceleration1.Size = New System.Drawing.Size(123, 17)
        Me.rbAcceleration1.TabIndex = 2
        Me.rbAcceleration1.TabStop = True
        Me.rbAcceleration1.Text = "Acceleration (m/s^2)"
        Me.rbAcceleration1.UseVisualStyleBackColor = True
        '
        'rbVelocityFinal1
        '
        Me.rbVelocityFinal1.AutoSize = True
        Me.rbVelocityFinal1.Location = New System.Drawing.Point(7, 47)
        Me.rbVelocityFinal1.Name = "rbVelocityFinal1"
        Me.rbVelocityFinal1.Size = New System.Drawing.Size(114, 17)
        Me.rbVelocityFinal1.TabIndex = 1
        Me.rbVelocityFinal1.TabStop = True
        Me.rbVelocityFinal1.Text = "Final Velocity (m/s)"
        Me.rbVelocityFinal1.UseVisualStyleBackColor = True
        '
        'txtVariable1
        '
        Me.txtVariable1.Location = New System.Drawing.Point(7, 20)
        Me.txtVariable1.Name = "txtVariable1"
        Me.txtVariable1.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbTime2)
        Me.GroupBox2.Controls.Add(Me.rbDisplacement2)
        Me.GroupBox2.Controls.Add(Me.rbAcceleration2)
        Me.GroupBox2.Controls.Add(Me.rbVelocityInitial2)
        Me.GroupBox2.Controls.Add(Me.rbVelocityFinal2)
        Me.GroupBox2.Controls.Add(Me.txtVariable2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second Variable"
        '
        'rbTime2
        '
        Me.rbTime2.AutoSize = True
        Me.rbTime2.Location = New System.Drawing.Point(246, 47)
        Me.rbTime2.Name = "rbTime2"
        Me.rbTime2.Size = New System.Drawing.Size(62, 17)
        Me.rbTime2.TabIndex = 5
        Me.rbTime2.TabStop = True
        Me.rbTime2.Text = "Time (s)"
        Me.rbTime2.UseVisualStyleBackColor = True
        '
        'rbDisplacement2
        '
        Me.rbDisplacement2.AutoSize = True
        Me.rbDisplacement2.Location = New System.Drawing.Point(246, 21)
        Me.rbDisplacement2.Name = "rbDisplacement2"
        Me.rbDisplacement2.Size = New System.Drawing.Size(106, 17)
        Me.rbDisplacement2.TabIndex = 4
        Me.rbDisplacement2.TabStop = True
        Me.rbDisplacement2.Text = "Displacement (m)"
        Me.rbDisplacement2.UseVisualStyleBackColor = True
        '
        'rbAcceleration2
        '
        Me.rbAcceleration2.AutoSize = True
        Me.rbAcceleration2.Location = New System.Drawing.Point(124, 47)
        Me.rbAcceleration2.Name = "rbAcceleration2"
        Me.rbAcceleration2.Size = New System.Drawing.Size(123, 17)
        Me.rbAcceleration2.TabIndex = 3
        Me.rbAcceleration2.TabStop = True
        Me.rbAcceleration2.Text = "Acceleration (m/s^2)"
        Me.rbAcceleration2.UseVisualStyleBackColor = True
        '
        'rbVelocityInitial2
        '
        Me.rbVelocityInitial2.AutoSize = True
        Me.rbVelocityInitial2.Location = New System.Drawing.Point(124, 22)
        Me.rbVelocityInitial2.Name = "rbVelocityInitial2"
        Me.rbVelocityInitial2.Size = New System.Drawing.Size(116, 17)
        Me.rbVelocityInitial2.TabIndex = 2
        Me.rbVelocityInitial2.TabStop = True
        Me.rbVelocityInitial2.Text = "Initial Velocity (m/s)"
        Me.rbVelocityInitial2.UseVisualStyleBackColor = True
        '
        'rbVelocityFinal2
        '
        Me.rbVelocityFinal2.AutoSize = True
        Me.rbVelocityFinal2.Location = New System.Drawing.Point(7, 47)
        Me.rbVelocityFinal2.Name = "rbVelocityFinal2"
        Me.rbVelocityFinal2.Size = New System.Drawing.Size(114, 17)
        Me.rbVelocityFinal2.TabIndex = 1
        Me.rbVelocityFinal2.TabStop = True
        Me.rbVelocityFinal2.Text = "Final Velocity (m/s)"
        Me.rbVelocityFinal2.UseVisualStyleBackColor = True
        '
        'txtVariable2
        '
        Me.txtVariable2.Location = New System.Drawing.Point(7, 20)
        Me.txtVariable2.Name = "txtVariable2"
        Me.txtVariable2.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTime3)
        Me.GroupBox3.Controls.Add(Me.rbDisplacement3)
        Me.GroupBox3.Controls.Add(Me.rbAcceleration3)
        Me.GroupBox3.Controls.Add(Me.rbVelocityInitial3)
        Me.GroupBox3.Controls.Add(Me.rbVelocityFinal3)
        Me.GroupBox3.Controls.Add(Me.txtVariable3)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(426, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Third Variable"
        '
        'rbTime3
        '
        Me.rbTime3.AutoSize = True
        Me.rbTime3.Location = New System.Drawing.Point(246, 47)
        Me.rbTime3.Name = "rbTime3"
        Me.rbTime3.Size = New System.Drawing.Size(62, 17)
        Me.rbTime3.TabIndex = 5
        Me.rbTime3.TabStop = True
        Me.rbTime3.Text = "Time (s)"
        Me.rbTime3.UseVisualStyleBackColor = True
        '
        'rbDisplacement3
        '
        Me.rbDisplacement3.AutoSize = True
        Me.rbDisplacement3.Location = New System.Drawing.Point(246, 21)
        Me.rbDisplacement3.Name = "rbDisplacement3"
        Me.rbDisplacement3.Size = New System.Drawing.Size(106, 17)
        Me.rbDisplacement3.TabIndex = 4
        Me.rbDisplacement3.TabStop = True
        Me.rbDisplacement3.Text = "Displacement (m)"
        Me.rbDisplacement3.UseVisualStyleBackColor = True
        '
        'rbAcceleration3
        '
        Me.rbAcceleration3.AutoSize = True
        Me.rbAcceleration3.Location = New System.Drawing.Point(124, 47)
        Me.rbAcceleration3.Name = "rbAcceleration3"
        Me.rbAcceleration3.Size = New System.Drawing.Size(123, 17)
        Me.rbAcceleration3.TabIndex = 3
        Me.rbAcceleration3.TabStop = True
        Me.rbAcceleration3.Text = "Acceleration (m/s^2)"
        Me.rbAcceleration3.UseVisualStyleBackColor = True
        '
        'rbVelocityInitial3
        '
        Me.rbVelocityInitial3.AutoSize = True
        Me.rbVelocityInitial3.Location = New System.Drawing.Point(124, 20)
        Me.rbVelocityInitial3.Name = "rbVelocityInitial3"
        Me.rbVelocityInitial3.Size = New System.Drawing.Size(116, 17)
        Me.rbVelocityInitial3.TabIndex = 2
        Me.rbVelocityInitial3.TabStop = True
        Me.rbVelocityInitial3.Text = "Initial Velocity (m/s)"
        Me.rbVelocityInitial3.UseVisualStyleBackColor = True
        '
        'rbVelocityFinal3
        '
        Me.rbVelocityFinal3.AutoSize = True
        Me.rbVelocityFinal3.Location = New System.Drawing.Point(7, 47)
        Me.rbVelocityFinal3.Name = "rbVelocityFinal3"
        Me.rbVelocityFinal3.Size = New System.Drawing.Size(114, 17)
        Me.rbVelocityFinal3.TabIndex = 1
        Me.rbVelocityFinal3.TabStop = True
        Me.rbVelocityFinal3.Text = "Final Velocity (m/s)"
        Me.rbVelocityFinal3.UseVisualStyleBackColor = True
        '
        'txtVariable3
        '
        Me.txtVariable3.Location = New System.Drawing.Point(7, 20)
        Me.txtVariable3.Name = "txtVariable3"
        Me.txtVariable3.Size = New System.Drawing.Size(100, 20)
        Me.txtVariable3.TabIndex = 0
        '
        'frmKinematicsCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 409)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmKinematicsCalculator"
        Me.Text = "Kinematics Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTime1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDisplacement1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityInitial1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbAcceleration1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityFinal1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVariable1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTime2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDisplacement2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbAcceleration2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityInitial2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityFinal2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVariable2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTime3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDisplacement3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbAcceleration3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityInitial3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVelocityFinal3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVariable3 As System.Windows.Forms.TextBox
End Class
