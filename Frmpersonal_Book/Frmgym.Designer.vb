<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgym
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
        Me.txtnome = New System.Windows.Forms.TextBox
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.cborep = New System.Windows.Forms.ComboBox
        Me.cbonivel = New System.Windows.Forms.ComboBox
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtggym = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.lblnome = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblrep = New System.Windows.Forms.Label
        Me.lblnivel = New System.Windows.Forms.Label
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtggym, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnome
        '
        Me.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome.Enabled = False
        Me.txtnome.Location = New System.Drawing.Point(105, 33)
        Me.txtnome.MaxLength = 80
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(372, 20)
        Me.txtnome.TabIndex = 0
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.Enabled = False
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Abdomen", "Antibraço", "Biceps", "Costas", "Coxas", "Gluteos", "Ombro", "Peito", "Pernas", "Panturilhas", "Triceps"})
        Me.cbotipo.Location = New System.Drawing.Point(105, 59)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(372, 21)
        Me.cbotipo.TabIndex = 1
        '
        'cborep
        '
        Me.cborep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborep.Enabled = False
        Me.cborep.FormattingEnabled = True
        Me.cborep.Items.AddRange(New Object() {"3x6", "3x8", "3x10", "3x12", "3x15", "3x20", "3x6 +10 Repetições", "3x8 +10 Repetições", "3x10 +10 Repetições", "3x12 +10 Repetições", "3x15 +10 Repetições", "3x20 +10 Repetições", "3x6 +10 Repetições + 10 Segundos", "3x8 +10 Repetições + 10 Segundos", "3x10 +10 Repetições + 10 Segundos", "3x12 +10 Repetições + 10 Segundos", "3x15 +10 Repetições + 10 Segundos", "3x20 +10 Repetições + 10 Segundos", "4x6", "4x8", "4x10", "4x12", "4x15", "4x20", "4x6 +10 Repetições", "4x8 +10 Repetições", "4x10 +10 Repetições", "4x12 +10 Repetições", "4x15 +10 Repetições", "4x20 +10 Repetições", "4x6 +10 Repetições + 10 Segundos", "4x8 +10 Repetições + 10 Segundos", "4x10 +10 Repetições + 10 Segundos", "4x12 +10 Repetições + 10 Segundos", "4x15 +10 Repetições + 10 Segundos", "4x20 +10 Repetições + 10 Segundos", "5x6", "5x8", "5x10", "5x12", "5x15", "5x20", "5x6 +10 Repetições", "5x8 +10 Repetições", "5x10 +10 Repetições", "5x12 +10 Repetições", "5x15 +10 Repetições", "5x20 +10 Repetições", "5x6 +10 Repetições + 10 Segundos", "5x8 +10 Repetições + 10 Segundos", "5x10 +10 Repetições + 10 Segundos", "5x12 +10 Repetições + 10 Segundos", "5x15 +10 Repetições + 10 Segundos", "5x20 +10 Repetições + 10 Segundos", "10/6/10/6", "10/8/6/4", "10/8/10/8", "15/12/10/8", "8/8/6/6", "8/6/8/6", "6/4/6/4", "12/8/12/8", "3x", "4x", "5x"})
        Me.cborep.Location = New System.Drawing.Point(105, 86)
        Me.cborep.Name = "cborep"
        Me.cborep.Size = New System.Drawing.Size(372, 21)
        Me.cborep.TabIndex = 2
        '
        'cbonivel
        '
        Me.cbonivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonivel.Enabled = False
        Me.cbonivel.FormattingEnabled = True
        Me.cbonivel.Items.AddRange(New Object() {"Iniciante", "Intermediario", "Avançado"})
        Me.cbonivel.Location = New System.Drawing.Point(105, 113)
        Me.cbonivel.Name = "cbonivel"
        Me.cbonivel.Size = New System.Drawing.Size(372, 21)
        Me.cbonivel.TabIndex = 3
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(366, 140)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(111, 23)
        Me.btnfunc4.TabIndex = 7
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtggym
        '
        Me.Dtggym.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtggym.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtggym.Location = New System.Drawing.Point(5, 169)
        Me.Dtggym.Name = "Dtggym"
        Me.Dtggym.ReadOnly = True
        Me.Dtggym.Size = New System.Drawing.Size(471, 191)
        Me.Dtggym.TabIndex = 12
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(246, 140)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc3.TabIndex = 6
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(125, 140)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc2.TabIndex = 5
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(4, 140)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc1.TabIndex = 4
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Location = New System.Drawing.Point(1, 33)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(98, 13)
        Me.lblnome.TabIndex = 14
        Me.lblnome.Text = "Nome do exercicio:"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(1, 59)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(88, 13)
        Me.lbltipo.TabIndex = 15
        Me.lbltipo.Text = "Tipo do musculo:"
        '
        'lblrep
        '
        Me.lblrep.AutoSize = True
        Me.lblrep.Location = New System.Drawing.Point(1, 86)
        Me.lblrep.Name = "lblrep"
        Me.lblrep.Size = New System.Drawing.Size(100, 13)
        Me.lblrep.TabIndex = 16
        Me.lblrep.Text = "Qtde de repetições:"
        '
        'lblnivel
        '
        Me.lblnivel.AutoSize = True
        Me.lblnivel.Location = New System.Drawing.Point(1, 113)
        Me.lblnivel.Name = "lblnivel"
        Me.lblnivel.Size = New System.Drawing.Size(94, 13)
        Me.lblnivel.TabIndex = 17
        Me.lblnivel.Text = "Nivel do exercicio:"
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(105, 6)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 18
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(1, 6)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 19
        Me.lblcod.Text = "Codigo:"
        '
        'Frmgym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.lblnivel)
        Me.Controls.Add(Me.lblrep)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtggym)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.cbonivel)
        Me.Controls.Add(Me.cborep)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.txtnome)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmgym"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtggym, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents cborep As System.Windows.Forms.ComboBox
    Friend WithEvents cbonivel As System.Windows.Forms.ComboBox
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtggym As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblrep As System.Windows.Forms.Label
    Friend WithEvents lblnivel As System.Windows.Forms.Label
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
