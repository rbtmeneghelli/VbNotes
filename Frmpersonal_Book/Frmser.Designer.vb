<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmser
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
        Me.txtser = New System.Windows.Forms.TextBox
        Me.lblser = New System.Windows.Forms.Label
        Me.lblgen = New System.Windows.Forms.Label
        Me.cbogen = New System.Windows.Forms.ComboBox
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgser = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtser
        '
        Me.txtser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtser.Enabled = False
        Me.txtser.Location = New System.Drawing.Point(51, 39)
        Me.txtser.MaxLength = 80
        Me.txtser.Name = "txtser"
        Me.txtser.Size = New System.Drawing.Size(376, 20)
        Me.txtser.TabIndex = 0
        '
        'lblser
        '
        Me.lblser.AutoSize = True
        Me.lblser.Location = New System.Drawing.Point(-1, 36)
        Me.lblser.Name = "lblser"
        Me.lblser.Size = New System.Drawing.Size(46, 13)
        Me.lblser.TabIndex = 2
        Me.lblser.Text = "Seriado:"
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.Location = New System.Drawing.Point(-1, 65)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(45, 13)
        Me.lblgen.TabIndex = 3
        Me.lblgen.Text = "Genero:"
        '
        'cbogen
        '
        Me.cbogen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogen.Enabled = False
        Me.cbogen.FormattingEnabled = True
        Me.cbogen.Items.AddRange(New Object() {"Desenho", "Filme", "Seriado", "Filme\Desenho"})
        Me.cbogen.Location = New System.Drawing.Point(51, 65)
        Me.cbogen.Name = "cbogen"
        Me.cbogen.Size = New System.Drawing.Size(376, 21)
        Me.cbogen.TabIndex = 1
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(350, 92)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(78, 23)
        Me.btnfunc4.TabIndex = 13
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgser
        '
        Me.Dtgser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgser.Location = New System.Drawing.Point(3, 120)
        Me.Dtgser.Name = "Dtgser"
        Me.Dtgser.ReadOnly = True
        Me.Dtgser.Size = New System.Drawing.Size(424, 191)
        Me.Dtgser.TabIndex = 12
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(234, 92)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 11
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(118, 92)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 10
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(2, 91)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 9
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(51, 12)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(376, 21)
        Me.Cbocod.TabIndex = 14
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(0, 12)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 15
        Me.lblcod.Text = "Codigo:"
        '
        'Frmser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgser)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.cbogen)
        Me.Controls.Add(Me.lblgen)
        Me.Controls.Add(Me.lblser)
        Me.Controls.Add(Me.txtser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtser As System.Windows.Forms.TextBox
    Friend WithEvents lblser As System.Windows.Forms.Label
    Friend WithEvents lblgen As System.Windows.Forms.Label
    Friend WithEvents cbogen As System.Windows.Forms.ComboBox
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgser As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
