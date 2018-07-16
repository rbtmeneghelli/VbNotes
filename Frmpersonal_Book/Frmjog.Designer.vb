<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmjog
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
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgjog = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.cbogen = New System.Windows.Forms.ComboBox
        Me.lblgen = New System.Windows.Forms.Label
        Me.lblser = New System.Windows.Forms.Label
        Me.txtjog = New System.Windows.Forms.TextBox
        CType(Me.Dtgjog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(52, 6)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(376, 21)
        Me.Cbocod.TabIndex = 25
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(1, 6)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 26
        Me.lblcod.Text = "Codigo:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(351, 86)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(78, 23)
        Me.btnfunc4.TabIndex = 24
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgjog
        '
        Me.Dtgjog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgjog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgjog.Location = New System.Drawing.Point(4, 114)
        Me.Dtgjog.Name = "Dtgjog"
        Me.Dtgjog.ReadOnly = True
        Me.Dtgjog.Size = New System.Drawing.Size(424, 191)
        Me.Dtgjog.TabIndex = 23
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(235, 86)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 22
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(119, 86)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 21
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(3, 85)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 20
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'cbogen
        '
        Me.cbogen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogen.Enabled = False
        Me.cbogen.FormattingEnabled = True
        Me.cbogen.Items.AddRange(New Object() {"Ação", "Aventura", "Esporte", "Estrategia", "Faroeste", "Guerra", "Heroi", "Rpg", "Suspense", "Terror"})
        Me.cbogen.Location = New System.Drawing.Point(52, 59)
        Me.cbogen.Name = "cbogen"
        Me.cbogen.Size = New System.Drawing.Size(376, 21)
        Me.cbogen.TabIndex = 17
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.Location = New System.Drawing.Point(0, 59)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(45, 13)
        Me.lblgen.TabIndex = 19
        Me.lblgen.Text = "Genero:"
        '
        'lblser
        '
        Me.lblser.AutoSize = True
        Me.lblser.Location = New System.Drawing.Point(0, 30)
        Me.lblser.Name = "lblser"
        Me.lblser.Size = New System.Drawing.Size(33, 13)
        Me.lblser.TabIndex = 18
        Me.lblser.Text = "Jogo:"
        '
        'txtjog
        '
        Me.txtjog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtjog.Enabled = False
        Me.txtjog.Location = New System.Drawing.Point(52, 33)
        Me.txtjog.MaxLength = 80
        Me.txtjog.Name = "txtjog"
        Me.txtjog.Size = New System.Drawing.Size(376, 20)
        Me.txtjog.TabIndex = 16
        '
        'Frmjog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgjog)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.cbogen)
        Me.Controls.Add(Me.lblgen)
        Me.Controls.Add(Me.lblser)
        Me.Controls.Add(Me.txtjog)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmjog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgjog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgjog As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents cbogen As System.Windows.Forms.ComboBox
    Friend WithEvents lblgen As System.Windows.Forms.Label
    Friend WithEvents lblser As System.Windows.Forms.Label
    Friend WithEvents txtjog As System.Windows.Forms.TextBox
End Class
