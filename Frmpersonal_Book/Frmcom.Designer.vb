<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcom
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
        Me.txtest = New System.Windows.Forms.TextBox
        Me.txttel = New System.Windows.Forms.MaskedTextBox
        Me.lblest = New System.Windows.Forms.Label
        Me.lbltel = New System.Windows.Forms.Label
        Me.lblgen = New System.Windows.Forms.Label
        Me.cbogen = New System.Windows.Forms.ComboBox
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgcom = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgcom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtest
        '
        Me.txtest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtest.Enabled = False
        Me.txtest.Location = New System.Drawing.Point(96, 36)
        Me.txtest.MaxLength = 80
        Me.txtest.Name = "txtest"
        Me.txtest.Size = New System.Drawing.Size(372, 20)
        Me.txtest.TabIndex = 0
        '
        'txttel
        '
        Me.txttel.Enabled = False
        Me.txttel.Location = New System.Drawing.Point(96, 62)
        Me.txttel.Mask = "(999) 0000-0000"
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(372, 20)
        Me.txttel.TabIndex = 1
        '
        'lblest
        '
        Me.lblest.AutoSize = True
        Me.lblest.Location = New System.Drawing.Point(2, 36)
        Me.lblest.Name = "lblest"
        Me.lblest.Size = New System.Drawing.Size(88, 13)
        Me.lblest.TabIndex = 3
        Me.lblest.Text = "Estabelecimento:"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Location = New System.Drawing.Point(2, 62)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(52, 13)
        Me.lbltel.TabIndex = 4
        Me.lbltel.Text = "Telefone:"
        '
        'lblgen
        '
        Me.lblgen.AutoSize = True
        Me.lblgen.Location = New System.Drawing.Point(2, 88)
        Me.lblgen.Name = "lblgen"
        Me.lblgen.Size = New System.Drawing.Size(45, 13)
        Me.lblgen.TabIndex = 6
        Me.lblgen.Text = "Genero:"
        '
        'cbogen
        '
        Me.cbogen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbogen.Enabled = False
        Me.cbogen.FormattingEnabled = True
        Me.cbogen.Items.AddRange(New Object() {"Academia", "Auto escola", "Agencia de viagem", "Balada", "Bares", "Boates", "Boutique", "Buffet", "Cafeteria", "Cartorio", "Chaveiro", "Chopperia", "Clinica", "Colegio", "Concessionaria", "Construtora", "Curso de idioma", "Dentista", "Deposito de bebida", "Doceria", "Eletronica", "Faculdade", "Fast food", "Festas", "Flores", "Gas", "Gelo", "Guincho", "Hoteis", "Igreja", "Informatica", "Imobiliaria", "Lavanderia", "Livraria", "Loja de roupa", "Motel", "Oficina", "Padaria", "Petshop", "Pousadas", "Perfumaria", "Hospital", "Prefeitura", "Restaurante", "Sorveteria", "Transportadora", "Papelaria", "Supermercado", "Suplemento", "Taxi", "Veterinário"})
        Me.cbogen.Location = New System.Drawing.Point(96, 88)
        Me.cbogen.Name = "cbogen"
        Me.cbogen.Size = New System.Drawing.Size(372, 21)
        Me.cbogen.TabIndex = 2
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(355, 115)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(113, 23)
        Me.btnfunc4.TabIndex = 6
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgcom
        '
        Me.Dtgcom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgcom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgcom.Location = New System.Drawing.Point(5, 144)
        Me.Dtgcom.Name = "Dtgcom"
        Me.Dtgcom.ReadOnly = True
        Me.Dtgcom.Size = New System.Drawing.Size(463, 222)
        Me.Dtgcom.TabIndex = 22
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(239, 115)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(112, 23)
        Me.btnfunc3.TabIndex = 5
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(121, 115)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(112, 23)
        Me.btnfunc2.TabIndex = 4
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(5, 115)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 3
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(96, 9)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 23
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(2, 9)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 24
        Me.lblcod.Text = "Codigo:"
        '
        'Frmcom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgcom)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.cbogen)
        Me.Controls.Add(Me.lblgen)
        Me.Controls.Add(Me.lbltel)
        Me.Controls.Add(Me.lblest)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.txtest)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgcom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtest As System.Windows.Forms.TextBox
    Friend WithEvents txttel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblest As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents lblgen As System.Windows.Forms.Label
    Friend WithEvents cbogen As System.Windows.Forms.ComboBox
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgcom As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
