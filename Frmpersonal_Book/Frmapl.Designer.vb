<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmapl
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
        Me.lblapp = New System.Windows.Forms.Label
        Me.Dtgapl = New System.Windows.Forms.DataGridView
        Me.txtapp = New System.Windows.Forms.TextBox
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        CType(Me.Dtgapl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbocod
        '
        Me.Cbocod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbocod.Enabled = False
        Me.Cbocod.FormattingEnabled = True
        Me.Cbocod.Location = New System.Drawing.Point(104, 8)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 0
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(-1, 8)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(107, 13)
        Me.lblcod.TabIndex = 17
        Me.lblcod.Text = "Codigo do Aplicativo:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(366, 61)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc4.TabIndex = 5
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'lblapp
        '
        Me.lblapp.AutoSize = True
        Me.lblapp.Location = New System.Drawing.Point(-1, 35)
        Me.lblapp.Name = "lblapp"
        Me.lblapp.Size = New System.Drawing.Size(102, 13)
        Me.lblapp.TabIndex = 16
        Me.lblapp.Text = "Nome do Aplicativo:"
        '
        'Dtgapl
        '
        Me.Dtgapl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgapl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgapl.Location = New System.Drawing.Point(2, 90)
        Me.Dtgapl.Name = "Dtgapl"
        Me.Dtgapl.ReadOnly = True
        Me.Dtgapl.Size = New System.Drawing.Size(474, 191)
        Me.Dtgapl.TabIndex = 14
        '
        'txtapp
        '
        Me.txtapp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapp.Enabled = False
        Me.txtapp.Location = New System.Drawing.Point(104, 35)
        Me.txtapp.MaxLength = 100
        Me.txtapp.Name = "txtapp"
        Me.txtapp.Size = New System.Drawing.Size(372, 20)
        Me.txtapp.TabIndex = 1
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(244, 61)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc3.TabIndex = 4
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(123, 61)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc2.TabIndex = 3
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(2, 61)
        Me.btnfunc1.Name = "btnfunc1"
        Me.btnfunc1.Size = New System.Drawing.Size(115, 23)
        Me.btnfunc1.TabIndex = 2
        Me.btnfunc1.Text = "Cadastrar"
        Me.btnfunc1.UseVisualStyleBackColor = True
        '
        'Frmapl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.lblapp)
        Me.Controls.Add(Me.Dtgapl)
        Me.Controls.Add(Me.txtapp)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmapl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgapl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents lblapp As System.Windows.Forms.Label
    Friend WithEvents Dtgapl As System.Windows.Forms.DataGridView
    Friend WithEvents txtapp As System.Windows.Forms.TextBox
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
End Class
