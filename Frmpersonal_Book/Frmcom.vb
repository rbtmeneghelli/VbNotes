Imports System.Data.OleDb
Public Class Frmcom
    Private Sub Frmcom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case op
            Case 1
                btnfunc1.Text = "Cadastrar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtest.Enabled = False
                txttel.Enabled = False
                cbogen.Enabled = False
            Case 2
                btnfunc1.Text = "Alterar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtest.Enabled = False
                txttel.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            Case 3
                btnfunc1.Text = "Excluir"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtest.Enabled = False
                txttel.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar comercio"
                btnfunc3.Text = "Procurar por genero"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtest.Enabled = False
                txttel.Enabled = False
                cbogen.Enabled = False
        End Select
        AtualizaGrid(4)
        AtualizaCombo(3)
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
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtest.Enabled = True
            txttel.Enabled = True
            cbogen.Enabled = True
            txtest.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from comercio where crm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtest.Text = dr.Item("Nome")
                txttel.Text = dr.Item("Telefone")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtest.Enabled = True
            txttel.Enabled = True
            cbogen.Enabled = True
            txtest.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from comercio where crm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtest.Text = dr.Item("Nome")
                txttel.Text = dr.Item("Telefone")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgcom.Columns.Clear()
            cm = New OleDbCommand("select * from comercio where crm_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgcom.Columns.Add("Crm_PK", "ID")
            Dtgcom.Columns.Add("Nome", "Estabelecimento")
            Dtgcom.Columns.Add("Telefone", "Telefone")
            Dtgcom.Columns.Add("Genero", "Genero")
            If dr.Read Then
                Dtgcom.Rows.Add(dr.Item("Crm_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Genero"))
                Dtgcom.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtest.Text)) Then
                MsgBox("Preencha o campo com o estabelecimento!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtest.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txttel.Text)) Then
                MsgBox("Preencha o campo com o telefone!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o genero!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into comercio(Crm_PK,Nome,Telefone,Genero,User_Fk) values('" & maxcode & "','" & txtest.Text & "','" & txttel.Text & "','" & cbogen.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(4)
            AtualizaCombo(3)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtest.Text)) Then
                MsgBox("Preencha o campo com o estabelecimento!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtest.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txttel.Text)) Then
                MsgBox("Preencha o campo com o telefone!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txttel.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o genero!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update comercio set nome = '" & txtest.Text & "',telefone = '" & txttel.Text & "',genero = '" & cbogen.Text & "' where crm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(4)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from comercio where crm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(4)
                AtualizaCombo(3)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtest.Enabled = False
                txttel.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            End If
            ElseIf op = 4 Then
            'Comando SQL para procurar registro por estabelecimento
                Do
                input = InputBox("Digite o nome de um estabelecimento???", "Personal_book")
                Loop Until input <> ""
            Dtgcom.Columns.Clear()
            cm = New OleDbCommand("select * from comercio where nome like '%" & input & "%' and user_fk = '" & coduser & "'")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
            Dtgcom.Columns.Add("Crm_PK", "ID")
            Dtgcom.Columns.Add("Nome", "Estabelecimento")
            Dtgcom.Columns.Add("Telefone", "Telefone")
            Dtgcom.Columns.Add("Genero", "Genero")
                While dr.Read
                Dtgcom.Rows.Add(dr.Item("Crm_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Genero"))
                End While
            For cont = 0 To Dtgcom.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgcom.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgcom.RowCount > 1 Then
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
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtest.Enabled = False
            txttel.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por estabelecimento
            Do
                input = InputBox("Digite o nome de um genero???", "Personal_book")
            Loop Until input <> ""
            Dtgcom.Columns.Clear()
            cm = New OleDbCommand("select * from comercio where genero like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgcom.Columns.Add("Crm_PK", "ID")
            Dtgcom.Columns.Add("Nome", "Estabelecimento")
            Dtgcom.Columns.Add("Telefone", "Telefone")
            Dtgcom.Columns.Add("Genero", "Genero")
            While dr.Read
                Dtgcom.Rows.Add(dr.Item("Crm_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Genero"))
            End While
            For cont = 0 To Dtgcom.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgcom.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgcom.RowCount > 1 Then
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
End Class