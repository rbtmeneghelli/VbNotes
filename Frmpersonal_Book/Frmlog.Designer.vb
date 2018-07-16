<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlog
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
        Me.lbllog = New System.Windows.Forms.Label
        Me.lblse = New System.Windows.Forms.Label
        Me.Btnlog = New System.Windows.Forms.Button
        Me.Btncanc = New System.Windows.Forms.Button
        Me.Btnsa = New System.Windows.Forms.Button
        Me.Txtlog = New System.Windows.Forms.TextBox
        Me.Txtse = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbllog
        '
        Me.lbllog.AutoSize = True
        Me.lbllog.Location = New System.Drawing.Point(142, 45)
        Me.lbllog.Name = "lbllog"
        Me.lbllog.Size = New System.Drawing.Size(32, 13)
        Me.lbllog.TabIndex = 0
        Me.lbllog.Text = "User:"
        '
        'lblse
        '
        Me.lblse.AutoSize = True
        Me.lblse.Location = New System.Drawing.Point(118, 68)
        Me.lblse.Name = "lblse"
        Me.lblse.Size = New System.Drawing.Size(56, 13)
        Me.lblse.TabIndex = 1
        Me.lblse.Text = "Password:"
        '
        'Btnlog
        '
        Me.Btnlog.AutoSize = True
        Me.Btnlog.Location = New System.Drawing.Point(100, 100)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(75, 23)
        Me.Btnlog.TabIndex = 2
        Me.Btnlog.Text = "Logar"
        Me.Btnlog.UseVisualStyleBackColor = True
        '
        'Btncanc
        '
        Me.Btncanc.AutoSize = True
        Me.Btncanc.Location = New System.Drawing.Point(177, 100)
        Me.Btncanc.Name = "Btncanc"
        Me.Btncanc.Size = New System.Drawing.Size(75, 23)
        Me.Btncanc.TabIndex = 3
        Me.Btncanc.Text = "Cancelar"
        Me.Btncanc.UseVisualStyleBackColor = True
        '
        'Btnsa
        '
        Me.Btnsa.AutoSize = True
        Me.Btnsa.Location = New System.Drawing.Point(254, 100)
        Me.Btnsa.Name = "Btnsa"
        Me.Btnsa.Size = New System.Drawing.Size(75, 23)
        Me.Btnsa.TabIndex = 4
        Me.Btnsa.Text = "Sair"
        Me.Btnsa.UseVisualStyleBackColor = True
        '
        'Txtlog
        '
        Me.Txtlog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtlog.Location = New System.Drawing.Point(171, 42)
        Me.Txtlog.MaxLength = 10
        Me.Txtlog.Name = "Txtlog"
        Me.Txtlog.Size = New System.Drawing.Size(100, 20)
        Me.Txtlog.TabIndex = 0
        '
        'Txtse
        '
        Me.Txtse.Location = New System.Drawing.Point(171, 65)
        Me.Txtse.MaxLength = 10
        Me.Txtse.Name = "Txtse"
        Me.Txtse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtse.Size = New System.Drawing.Size(100, 20)
        Me.Txtse.TabIndex = 1
        '
        'Frmlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 124)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txtse)
        Me.Controls.Add(Me.Txtlog)
        Me.Controls.Add(Me.Btnsa)
        Me.Controls.Add(Me.Btncanc)
        Me.Controls.Add(Me.Btnlog)
        Me.Controls.Add(Me.lblse)
        Me.Controls.Add(Me.lbllog)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmlog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllog As System.Windows.Forms.Label
    Friend WithEvents lblse As System.Windows.Forms.Label
    Friend WithEvents Btnlog As System.Windows.Forms.Button
    Friend WithEvents Btncanc As System.Windows.Forms.Button
    Friend WithEvents Btnsa As System.Windows.Forms.Button
    Friend WithEvents Txtlog As System.Windows.Forms.TextBox
    Friend WithEvents Txtse As System.Windows.Forms.TextBox

End Class
