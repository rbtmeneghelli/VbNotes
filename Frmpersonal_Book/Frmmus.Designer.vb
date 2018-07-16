<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmus
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
        Me.txtmus = New System.Windows.Forms.TextBox
        Me.txtband = New System.Windows.Forms.TextBox
        Me.cbogen = New System.Windows.Forms.ComboBox
        Me.lblmus = New System.Windows.Forms.Label
        Me.lblband = New System.Windows.Forms.Label
        Me.lblgen = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgmus = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgmus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmus
        '
        Me.txtmus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmus.Enabled = False
        Me.txtmus.Location = New System.Drawing.Point(97, 36)
        Me.txtmus.MaxLength = 80
        Me.txtmus.Name = "txtmus"
        Me.txtmus.Size = New System.Drawing.Size(368, 20)
        Me.txtmus.TabIndex = 0
        '
        'txtband
        '
        Me.txtband.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtband.Enabled = False
        Me.txtband.Location = New System.Drawing.Point(97, 62)
        Me.txtband.MaxLength = 80
        Me.txtband.Name = "txtband"
        Me.txtband.Size = New System.Drawing.Size(368, 20)
        Me.txtband.TabIndex = 1
        '
        'cbogen
        '
        Me.cbogen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogen.Enabled = False
        Me.cbogen.FormattingEnabled = True
        Me.cbogen.Items.AddRange(New Object() {"Black", "Eletronica", "Funk", "Pagode", "Pop", "Internacional", "Rap", "Reggae", "Rock", "Samba", "Sertanejo Universitario"})
        Me.cbogen.Location = New System.Drawing.Point(97, 92)
        Me.cbogen.Name = "cbogen"
        Me.cbogen.Size = New System.Drawing.Size(368, 21)
        Me.cbogen.TabIndex = 2
        '
        'lblmus
        '
        Me.lblmus.AutoSize = True
        Me.lblmus.Location = New System.Drawing.Point(2, 36)
        Me.lblmus.Name = "lblmus"
        Me.lblmus.Size = New System.Drawing.Size(89, 13)
        Me.lblmus.TabIndex = 3
        Me.lblmus.Text = "Nome da musica:"
        '
        'lblband
        '
        Me.lblband.AutoSize = True
        Me.lblband.Location = New System.Drawing.Point(2, 62)
        Me.lblband.Name = "lblband"
        Me.lblband.Size = New System.Drawing.Size(86, 13)
        Me.lblband.TabIndex = 4
        Me.lblband.Text = "Nome da banda:"
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.Location = New System.Drawing.Point(2, 92)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(45, 13)
        Me.lblgen.TabIndex = 5
        Me.lblgen.Text = "Genero:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(353, 119)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(113, 23)
        Me.btnfunc4.TabIndex = 23
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgmus
        '
        Me.Dtgmus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgmus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgmus.Location = New System.Drawing.Point(6, 151)
        Me.Dtgmus.Name = "Dtgmus"
        Me.Dtgmus.ReadOnly = True
        Me.Dtgmus.Size = New System.Drawing.Size(459, 195)
        Me.Dtgmus.TabIndex = 22
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(237, 119)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 21
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(121, 119)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 20
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(5, 119)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 19
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(97, 9)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(368, 21)
        Me.Cbocod.TabIndex = 24
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(2, 9)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 25
        Me.lblcod.Text = "Codigo:"
        '
        'Frmmus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgmus)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.lblgen)
        Me.Controls.Add(Me.lblband)
        Me.Controls.Add(Me.lblmus)
        Me.Controls.Add(Me.cbogen)
        Me.Controls.Add(Me.txtband)
        Me.Controls.Add(Me.txtmus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmmus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgmus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmus As System.Windows.Forms.TextBox
    Friend WithEvents txtband As System.Windows.Forms.TextBox
    Friend WithEvents cbogen As System.Windows.Forms.ComboBox
    Friend WithEvents lblmus As System.Windows.Forms.Label
    Friend WithEvents lblband As System.Windows.Forms.Label
    Friend WithEvents lblgen As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgmus As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
