<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmacss
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
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.txtlog = New System.Windows.Forms.TextBox
        Me.txtse = New System.Windows.Forms.TextBox
        Me.Dtgacss = New System.Windows.Forms.DataGridView
        Me.lblus = New System.Windows.Forms.Label
        Me.lblpsw = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.lblcod = New System.Windows.Forms.Label
        Me.Cbocod = New System.Windows.Forms.ComboBox
        CType(Me.Dtgacss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(1, 98)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 3
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(118, 98)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 4
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(236, 98)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 5
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'txtlog
        '
        Me.txtlog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlog.Enabled = False
        Me.txtlog.Location = New System.Drawing.Point(56, 43)
        Me.txtlog.MaxLength = 10
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(372, 20)
        Me.txtlog.TabIndex = 1
        '
        'txtse
        '
        Me.txtse.Enabled = False
        Me.txtse.Location = New System.Drawing.Point(56, 69)
        Me.txtse.MaxLength = 10
        Me.txtse.Name = "txtse"
        Me.txtse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtse.Size = New System.Drawing.Size(372, 20)
        Me.txtse.TabIndex = 2
        '
        'Dtgacss
        '
        Me.Dtgacss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgacss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgacss.Location = New System.Drawing.Point(3, 127)
        Me.Dtgacss.Name = "Dtgacss"
        Me.Dtgacss.ReadOnly = True
        Me.Dtgacss.Size = New System.Drawing.Size(424, 191)
        Me.Dtgacss.TabIndex = 5
        '
        'lblus
        '
        Me.lblus.AutoSize = True
        Me.lblus.Location = New System.Drawing.Point(-2, 45)
        Me.lblus.Name = "lblus"
        Me.lblus.Size = New System.Drawing.Size(32, 13)
        Me.lblus.TabIndex = 6
        Me.lblus.Text = "User:"
        '
        'lblpsw
        '
        Me.lblpsw.AutoSize = True
        Me.lblpsw.Location = New System.Drawing.Point(-1, 69)
        Me.lblpsw.Name = "lblpsw"
        Me.lblpsw.Size = New System.Drawing.Size(56, 13)
        Me.lblpsw.TabIndex = 7
        Me.lblpsw.Text = "Password:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(351, 98)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(77, 23)
        Me.btnfunc4.TabIndex = 6
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(0, 16)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 8
        Me.lblcod.Text = "Codigo:"
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(56, 16)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 0
        '
        'Frmacss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.lblpsw)
        Me.Controls.Add(Me.lblus)
        Me.Controls.Add(Me.Dtgacss)
        Me.Controls.Add(Me.txtse)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmacss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgacss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents txtlog As System.Windows.Forms.TextBox
    Friend WithEvents txtse As System.Windows.Forms.TextBox
    Friend WithEvents Dtgacss As System.Windows.Forms.DataGridView
    Friend WithEvents lblus As System.Windows.Forms.Label
    Friend WithEvents lblpsw As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
End Class
