<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmamg
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
        Me.cborede = New System.Windows.Forms.ComboBox
        Me.txttel = New System.Windows.Forms.MaskedTextBox
        Me.txtcel = New System.Windows.Forms.MaskedTextBox
        Me.lblnome = New System.Windows.Forms.Label
        Me.lbltel = New System.Windows.Forms.Label
        Me.lblcel = New System.Windows.Forms.Label
        Me.lblrede = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgamg = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgamg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnome
        '
        Me.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome.Enabled = False
        Me.txtnome.Location = New System.Drawing.Point(93, 36)
        Me.txtnome.MaxLength = 80
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(372, 20)
        Me.txtnome.TabIndex = 0
        '
        'cborede
        '
        Me.cborede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborede.Enabled = False
        Me.cborede.FormattingEnabled = True
        Me.cborede.Items.AddRange(New Object() {"Ask", "Facebook", "Hello", "Kirk", "Linkedin", "Messenger", "Orkut", "Social", "Twitter", "Vk", "Whatsapp", "Outros"})
        Me.cborede.Location = New System.Drawing.Point(93, 114)
        Me.cborede.Name = "cborede"
        Me.cborede.Size = New System.Drawing.Size(372, 21)
        Me.cborede.TabIndex = 3
        '
        'txttel
        '
        Me.txttel.Enabled = False
        Me.txttel.Location = New System.Drawing.Point(93, 62)
        Me.txttel.Mask = "(999) 0000-0000"
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(372, 20)
        Me.txttel.TabIndex = 1
        '
        'txtcel
        '
        Me.txtcel.Enabled = False
        Me.txtcel.Location = New System.Drawing.Point(93, 88)
        Me.txtcel.Mask = "(999) 00000-0000"
        Me.txtcel.Name = "txtcel"
        Me.txtcel.Size = New System.Drawing.Size(372, 20)
        Me.txtcel.TabIndex = 2
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Location = New System.Drawing.Point(2, 36)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(85, 13)
        Me.lblnome.TabIndex = 4
        Me.lblnome.Text = "Nome Completo:"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Location = New System.Drawing.Point(2, 62)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(52, 13)
        Me.lbltel.TabIndex = 5
        Me.lbltel.Text = "Telefone:"
        '
        'lblcel
        '
        Me.lblcel.AutoSize = True
        Me.lblcel.Location = New System.Drawing.Point(2, 88)
        Me.lblcel.Name = "lblcel"
        Me.lblcel.Size = New System.Drawing.Size(42, 13)
        Me.lblcel.TabIndex = 6
        Me.lblcel.Text = "Celular:"
        '
        'lblrede
        '
        Me.lblrede.AutoSize = True
        Me.lblrede.Location = New System.Drawing.Point(2, 114)
        Me.lblrede.Name = "lblrede"
        Me.lblrede.Size = New System.Drawing.Size(68, 13)
        Me.lblrede.TabIndex = 7
        Me.lblrede.Text = "Rede Social:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(352, 141)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(113, 23)
        Me.btnfunc4.TabIndex = 7
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgamg
        '
        Me.Dtgamg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.Dtgamg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgamg.Location = New System.Drawing.Point(5, 170)
        Me.Dtgamg.Name = "Dtgamg"
        Me.Dtgamg.ReadOnly = True
        Me.Dtgamg.Size = New System.Drawing.Size(460, 191)
        Me.Dtgamg.TabIndex = 17
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(237, 141)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 6
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(121, 141)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 5
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(5, 141)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 4
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(93, 9)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 18
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(2, 9)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 19
        Me.lblcod.Text = "Codigo:"
        '
        'Frmamg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgamg)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.lblrede)
        Me.Controls.Add(Me.lblcel)
        Me.Controls.Add(Me.lbltel)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.txtcel)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.cborede)
        Me.Controls.Add(Me.txtnome)
        Me.Name = "Frmamg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgamg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents cborede As System.Windows.Forms.ComboBox
    Friend WithEvents txttel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtcel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents lblcel As System.Windows.Forms.Label
    Friend WithEvents lblrede As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgamg As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
