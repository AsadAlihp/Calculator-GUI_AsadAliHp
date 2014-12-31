<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.n1 = New System.Windows.Forms.TextBox()
        Me.n2 = New System.Windows.Forms.TextBox()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Button()
        Me.s = New System.Windows.Forms.Button()
        Me.d = New System.Windows.Forms.Button()
        Me.m = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'n1
        '
        Me.n1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n1.Location = New System.Drawing.Point(12, 26)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(203, 30)
        Me.n1.TabIndex = 0
        '
        'n2
        '
        Me.n2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.n2.Location = New System.Drawing.Point(12, 72)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(203, 30)
        Me.n2.TabIndex = 1
        '
        'ans
        '
        Me.ans.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ans.Location = New System.Drawing.Point(12, 119)
        Me.ans.Name = "ans"
        Me.ans.ReadOnly = True
        Me.ans.Size = New System.Drawing.Size(203, 30)
        Me.ans.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Answer:"
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(15, 175)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(75, 23)
        Me.a.TabIndex = 6
        Me.a.Text = "Add"
        Me.a.UseVisualStyleBackColor = True
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(140, 175)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(75, 23)
        Me.s.TabIndex = 7
        Me.s.Text = "Subtract"
        Me.s.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(15, 217)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(75, 23)
        Me.d.TabIndex = 8
        Me.d.Text = "Divide"
        Me.d.UseVisualStyleBackColor = True
        '
        'm
        '
        Me.m.Location = New System.Drawing.Point(140, 217)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(75, 23)
        Me.m.TabIndex = 9
        Me.m.Text = "Multiply"
        Me.m.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SocioTeachers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 272)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.n1)
        Me.Name = "Form1"
        Me.Text = "MyCalc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents n1 As System.Windows.Forms.TextBox
    Friend WithEvents n2 As System.Windows.Forms.TextBox
    Friend WithEvents ans As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.Button
    Friend WithEvents s As System.Windows.Forms.Button
    Friend WithEvents d As System.Windows.Forms.Button
    Friend WithEvents m As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
