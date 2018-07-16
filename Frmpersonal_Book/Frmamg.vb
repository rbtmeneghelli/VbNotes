Imports System.Data.OleDb
Public Class Frmamg
    Private Sub Frmamg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case op
            Case 1
                btnfunc1.Text = "Cadastrar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtnome.Enabled = False
                txttel.Enabled = False
                txtcel.Enabled = False
                cborede.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
            Case 2
                btnfunc1.Text = "Alterar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = True
                txtnome.Enabled = False
                txttel.Enabled = False
                txtcel.Enabled = False
                cborede.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
            Case 3
                btnfunc1.Text = "Excluir"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = True
                txtnome.Enabled = False
                txttel.Enabled = False
                txtcel.Enabled = False
                cborede.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por nome"
                btnfunc3.Text = "Procurar por rede"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtnome.Enabled = False
                txttel.Enabled = False
                txtcel.Enabled = False
                cborede.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
        End Select
        AtualizaGrid(2)
        AtualizaCombo(2)
        DisableAccessmenu()
    End Sub
    Private Sub btnfunc4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc4.Click
        'Botão Fechar
        op = 0
        Limpa_Controls(Me)
        AbleAccessmenu()
        Me.Close()
    End Sub

    Private Sub btnfunc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc1.Click
        'Botao CRUD
        If op = 1 Then
            Cbocod.Enabled = False
            txtnome.Enabled = True
            txttel.Enabled = True
            txtcel.Enabled = True
            cborede.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtnome.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from amigos where amg_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtnome.Text = dr.Item("Nome")
                txttel.Text = dr.Item("Telefone")
                txtcel.Text = dr.Item("Celular")
                cborede.Text = dr.Item("Redesocial")
            End If
            Cbocod.Enabled = False
            txtnome.Enabled = True
            txttel.Enabled = True
            txtcel.Enabled = True
            cborede.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtnome.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from amigos where amg_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtnome.Text = dr.Item("Nome")
                txttel.Text = dr.Item("Telefone")
                txtcel.Text = dr.Item("Celular")
                cborede.Text = dr.Item("Redesocial")
            End If
            Cbocod.Enabled = False
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgamg.Columns.Clear()
            cm = New OleDbCommand("select * from amigos where amg_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgamg.Columns.Add("Amg_PK", "ID")
            Dtgamg.Columns.Add("Nome", "Nome")
            Dtgamg.Columns.Add("Telefone", "Telefone")
            Dtgamg.Columns.Add("Celular", "Celular")
            Dtgamg.Columns.Add("Redesocial", "Rede_Social")
            If dr.Read Then
                Dtgamg.Rows.Add(dr.Item("Amg_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Celular"), dr.Item("Redesocial"))
                Dtgamg.Rows(0).DefaultCellStyle.BackColor = Color.Blue
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
            input = ""
        End If
    End Sub

    Private Sub btnfunc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc2.Click
        'Botao Confirmar 
        If op = 1 Then
            'Comando SQL para cadastro
            If Trim(String.IsNullOrEmpty(txtnome.Text)) Then
                MsgBox("Preencha o campo com seu nome!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtnome.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txttel.Text)) Then
                MsgBox("Preencha o campo com seu telefone!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtcel.Text)) Then
                MsgBox("Preencha o campo com seu Celular!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cborede.Text)) Then
                MsgBox("Preencha o campo com sua rede social!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtnome.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into amigos(Amg_PK,Nome,Telefone,Celular,Redesocial,User_Fk) values('" & maxcode & "','" & txtnome.Text & "','" & txttel.Text & "','" & txtcel.Text & "','" & cborede.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(2)
            AtualizaCombo(2)
            Cbocod.Enabled = False
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtnome.Text)) Then
                MsgBox("Preencha o campo com seu nome!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtnome.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txttel.Text)) Then
                MsgBox("Preencha o campo com seu telefone!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtcel.Text)) Then
                MsgBox("Preencha o campo com seu Celular!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cborede.Text)) Then
                MsgBox("Preencha o campo com sua rede social!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtnome.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update amigos set nome = '" & txtnome.Text & "',telefone = '" & txttel.Text & "',celular = '" & txtcel.Text & "',redesocial = '" & cborede.Text & "' where amg_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(2)
            Cbocod.Enabled = True
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from amigos where amg_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(2)
                AtualizaCombo(2)
                Cbocod.Enabled = True
                txtnome.Enabled = False
                txttel.Enabled = False
                txtcel.Enabled = False
                cborede.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por nome 
            Do
                input = InputBox("Digite um login a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtgamg.Columns.Clear()
            cm = New OleDbCommand("select * from amigos where nome like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgamg.Columns.Add("Amg_PK", "ID")
            Dtgamg.Columns.Add("Nome", "Nome")
            Dtgamg.Columns.Add("Telefone", "Telefone")
            Dtgamg.Columns.Add("Celular", "Celular")
            Dtgamg.Columns.Add("Redesocial", "Rede_Social")
            While dr.Read
                Dtgamg.Rows.Add(dr.Item("Amg_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Celular"), dr.Item("Redesocial"))
            End While
            For cont = 0 To Dtgamg.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgamg.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgamg.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub

    Private Sub btnfunc3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc3.Click
        'Botão Cancelar
        If op = 1 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = False
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtnome.Enabled = False
            txttel.Enabled = False
            txtcel.Enabled = False
            cborede.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por rede social 
            Do
                input = InputBox("Digite uma rede social a ser procurada???", "Personal_book")
            Loop Until input <> ""
            Dtgamg.Columns.Clear()
            cm = New OleDbCommand("select * from amigos where redesocial like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgamg.Columns.Add("Amg_PK", "ID")
            Dtgamg.Columns.Add("Nome", "Nome")
            Dtgamg.Columns.Add("Telefone", "Telefone")
            Dtgamg.Columns.Add("Celular", "Celular")
            Dtgamg.Columns.Add("Redesocial", "Rede_Social")
            While dr.Read
                Dtgamg.Rows.Add(dr.Item("Amg_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Celular"), dr.Item("Redesocial"))
            End While
            For cont = 0 To Dtgamg.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgamg.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgamg.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub
    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcel.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class