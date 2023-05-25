<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharacter2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCharacter2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblJawBetul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(701, 75)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "The control which we can click and release to perform some action."
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.BackColor = System.Drawing.Color.Transparent
        Me.rb4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rb4.Location = New System.Drawing.Point(37, 210)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(148, 31)
        Me.rb4.TabIndex = 17
        Me.rb4.TabStop = True
        Me.rb4.Text = "CheckBox"
        Me.rb4.UseVisualStyleBackColor = False
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.BackColor = System.Drawing.Color.Transparent
        Me.rb2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rb2.Location = New System.Drawing.Point(37, 173)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(108, 31)
        Me.rb2.TabIndex = 16
        Me.rb2.TabStop = True
        Me.rb2.Text = "Button"
        Me.rb2.UseVisualStyleBackColor = False
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.BackColor = System.Drawing.Color.Transparent
        Me.rb1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rb1.Location = New System.Drawing.Point(37, 136)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(124, 31)
        Me.rb1.TabIndex = 15
        Me.rb1.TabStop = True
        Me.rb1.Text = "TextBox"
        Me.rb1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 37)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(376, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 41)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblJawBetul
        '
        Me.lblJawBetul.AutoSize = True
        Me.lblJawBetul.BackColor = System.Drawing.Color.Transparent
        Me.lblJawBetul.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJawBetul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJawBetul.Location = New System.Drawing.Point(579, 241)
        Me.lblJawBetul.Name = "lblJawBetul"
        Me.lblJawBetul.Size = New System.Drawing.Size(0, 32)
        Me.lblJawBetul.TabIndex = 20
        '
        'frmCharacter2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 388)
        Me.Controls.Add(Me.lblJawBetul)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCharacter2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblJawBetul As Label
End Class
