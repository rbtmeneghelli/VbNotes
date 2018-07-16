<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsites
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
        Me.txtsit = New System.Windows.Forms.TextBox
        Me.txtlog = New System.Windows.Forms.TextBox
        Me.txtse = New System.Windows.Forms.TextBox
        Me.lblsit = New System.Windows.Forms.Label
        Me.lbllog = New System.Windows.Forms.Label
        Me.lblse = New System.Windows.Forms.Label
        Me.btnfunc4 = New System.Windows.Forms.Button
        Me.Dtgsit = New System.Windows.Forms.DataGridView
        Me.btnfunc3 = New System.Windows.Forms.Button
        Me.btnfunc2 = New System.Windows.Forms.Button
        Me.btnfunc1 = New System.Windows.Forms.Button
        Me.Cbocod = New System.Windows.Forms.ComboBox
        Me.lblcod = New System.Windows.Forms.Label
        CType(Me.Dtgsit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsit
        '
        Me.txtsit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsit.Enabled = False
        Me.txtsit.Location = New System.Drawing.Point(85, 37)
        Me.txtsit.MaxLength = 80
        Me.txtsit.Name = "txtsit"
        Me.txtsit.Size = New System.Drawing.Size(372, 20)
        Me.txtsit.TabIndex = 0
        '
        'txtlog
        '
        Me.txtlog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlog.Enabled = False
        Me.txtlog.Location = New System.Drawing.Point(85, 63)
        Me.txtlog.MaxLength = 80
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(372, 20)
        Me.txtlog.TabIndex = 1
        '
        'txtse
        '
        Me.txtse.Enabled = False
        Me.txtse.Location = New System.Drawing.Point(85, 89)
        Me.txtse.MaxLength = 80
        Me.txtse.Name = "txtse"
        Me.txtse.Size = New System.Drawing.Size(372, 20)
        Me.txtse.TabIndex = 2
        '
        'lblsit
        '
        Me.lblsit.AutoSize = True
        Me.lblsit.Location = New System.Drawing.Point(3, 37)
        Me.lblsit.Name = "lblsit"
        Me.lblsit.Size = New System.Drawing.Size(72, 13)
        Me.lblsit.TabIndex = 3
        Me.lblsit.Text = "Nome do site:"
        '
        'lbllog
        '
        Me.lbllog.AutoSize = True
        Me.lbllog.Location = New System.Drawing.Point(3, 63)
        Me.lbllog.Name = "lbllog"
        Me.lbllog.Size = New System.Drawing.Size(36, 13)
        Me.lbllog.TabIndex = 4
        Me.lbllog.Text = "Login:"
        '
        'lblse
        '
        Me.lblse.AutoSize = True
        Me.lblse.Location = New System.Drawing.Point(3, 89)
        Me.lblse.Name = "lblse"
        Me.lblse.Size = New System.Drawing.Size(41, 13)
        Me.lblse.TabIndex = 5
        Me.lblse.Text = "Senha:"
        '
        'btnfunc4
        '
        Me.btnfunc4.Location = New System.Drawing.Point(357, 115)
        Me.btnfunc4.Name = "btnfunc4"
        Me.btnfunc4.Size = New System.Drawing.Size(101, 23)
        Me.btnfunc4.TabIndex = 6
        Me.btnfunc4.Text = "Fechar"
        Me.btnfunc4.UseVisualStyleBackColor = True
        '
        'Dtgsit
        '
        Me.Dtgsit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Dtgsit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgsit.Location = New System.Drawing.Point(7, 144)
        Me.Dtgsit.Name = "Dtgsit"
        Me.Dtgsit.ReadOnly = True
        Me.Dtgsit.Size = New System.Drawing.Size(450, 195)
        Me.Dtgsit.TabIndex = 27
        '
        'btnfunc3
        '
        Me.btnfunc3.Enabled = False
        Me.btnfunc3.Location = New System.Drawing.Point(238, 115)
        Me.btnfunc3.Name = "btnfunc3"
        Me.btnfunc3.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc3.TabIndex = 5
        Me.btnfunc3.Text = "Cancelar"
        Me.btnfunc3.UseVisualStyleBackColor = True
        '
        'btnfunc2
        '
        Me.btnfunc2.Enabled = False
        Me.btnfunc2.Location = New System.Drawing.Point(122, 115)
        Me.btnfunc2.Name = "btnfunc2"
        Me.btnfunc2.Size = New System.Drawing.Size(110, 23)
        Me.btnfunc2.TabIndex = 4
        Me.btnfunc2.Text = "Confirmar"
        Me.btnfunc2.UseVisualStyleBackColor = True
        '
        'btnfunc1
        '
        Me.btnfunc1.Location = New System.Drawing.Point(6, 115)
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
        Me.Cbocod.Location = New System.Drawing.Point(85, 7)
        Me.Cbocod.Name = "Cbocod"
        Me.Cbocod.Size = New System.Drawing.Size(372, 21)
        Me.Cbocod.TabIndex = 28
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Location = New System.Drawing.Point(4, 7)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(43, 13)
        Me.lblcod.TabIndex = 29
        Me.lblcod.Text = "Codigo:"
        '
        'Frmsites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cbocod)
        Me.Controls.Add(Me.lblcod)
        Me.Controls.Add(Me.btnfunc4)
        Me.Controls.Add(Me.Dtgsit)
        Me.Controls.Add(Me.btnfunc3)
        Me.Controls.Add(Me.btnfunc2)
        Me.Controls.Add(Me.btnfunc1)
        Me.Controls.Add(Me.lblse)
        Me.Controls.Add(Me.lbllog)
        Me.Controls.Add(Me.lblsit)
        Me.Controls.Add(Me.txtse)
        Me.Controls.Add(Me.txtlog)
        Me.Controls.Add(Me.txtsit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmsites"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal_Book"
        CType(Me.Dtgsit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsit As System.Windows.Forms.TextBox
    Friend WithEvents txtlog As System.Windows.Forms.TextBox
    Friend WithEvents txtse As System.Windows.Forms.TextBox
    Friend WithEvents lblsit As System.Windows.Forms.Label
    Friend WithEvents lbllog As System.Windows.Forms.Label
    Friend WithEvents lblse As System.Windows.Forms.Label
    Friend WithEvents btnfunc4 As System.Windows.Forms.Button
    Friend WithEvents Dtgsit As System.Windows.Forms.DataGridView
    Friend WithEvents btnfunc3 As System.Windows.Forms.Button
    Friend WithEvents btnfunc2 As System.Windows.Forms.Button
    Friend WithEvents btnfunc1 As System.Windows.Forms.Button
    Friend WithEvents Cbocod As System.Windows.Forms.ComboBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
End Class
