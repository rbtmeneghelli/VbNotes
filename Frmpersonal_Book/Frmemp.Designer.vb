<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmemp
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
        Me.txtemp = New System.Windows.Forms.TextBox
        Me.txtdet = New System.Windows.Forms.TextBox
        Me.lblemp = New System.Windows.Forms.Label
        Me.lbldet = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgemp = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtemp
        '
        Me.txtemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemp.Enabled = False
        Me.txtemp.Location = New System.Drawing.Point(97, 36)
        Me.txtemp.MaxLength = 80
        Me.txtemp.Name = "txtemp"
        Me.txtemp.Size = New System.Drawing.Size(334, 20)
        Me.txtemp.TabIndex = 0
        '
        'txtdet
        '
        Me.txtdet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdet.Enabled = False
        Me.txtdet.Location = New System.Drawing.Point(97, 62)
        Me.txtdet.MaxLength = 100
        Me.txtdet.Name = "txtdet"
        Me.txtdet.Size = New System.Drawing.Size(334, 20)
        Me.txtdet.TabIndex = 1
        '
        'lblemp
        '
        Me.lblemp.AutoSize = True
        Me.lblemp.Location = New System.Drawing.Point(0, 36)
        Me.lblemp.Name = "lblemp"
        Me.lblemp.Size = New System.Drawing.Size(96, 13)
        Me.lblemp.TabIndex = 2
        Me.lblemp.Text = "Nome da empresa:"
        '
        'lbldet
        '
        Me.lbldet.AutoSize = True
        Me.lbldet.Location = New System.Drawing.Point(0, 62)
        Me.lbldet.Name = "lbldet"
        Me.lbldet.Size = New System.Drawing.Size(52, 13)
        Me.lbldet.TabIndex = 3
        Me.lbldet.Text = "Detalhes:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(351, 88)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(80, 23)
        Me.btnfunc4.TabIndex = 5
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgemp
        '
        Me.Dtgemp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgemp.Location = New System.Drawing.Point(4, 117)
        Me.Dtgemp.Name = "Dtgemp"
        Me.Dtgemp.ReadOnly = True
        Me.Dtgemp.Size = New System.Drawing.Size(426, 191)
        Me.Dtgemp.TabIndex = 17
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(236, 88)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 4
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(120, 88)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 3
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(3, 88)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc1.TabIndex = 2
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
        Me.Cbocod.Size = New System.Drawing.Size(334, 21)
        Me.Cbocod.TabIndex = 18
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(0, 9)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 19
        Me.lblcod.Text = "Codigo:"
        '
        'Frmemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgemp)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.lbldet)
        Me.Controls.Add(Me.lblemp)
        Me.Controls.Add(Me.txtdet)
        Me.Controls.Add(Me.txtemp)
        Me.Name = "Frmemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtemp As System.Windows.Forms.TextBox
    Friend WithEvents txtdet As System.Windows.Forms.TextBox
    Friend WithEvents lblemp As System.Windows.Forms.Label
    Friend WithEvents lbldet As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgemp As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
