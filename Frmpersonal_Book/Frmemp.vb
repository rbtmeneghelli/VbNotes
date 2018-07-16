Imports System.Data.OleDb
Public Class Frmemp
    Private Sub Frmemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtemp.Enabled = False
                txtdet.Enabled = False
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
                txtemp.Enabled = False
                txtdet.Enabled = False
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
                txtemp.Enabled = False
                txtdet.Enabled = False
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar empresa"
                btnfunc3.Text = "Retornar grid"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtemp.Enabled = False
                txtdet.Enabled = False
        End Select
        AtualizaGrid(5)
        AtualizaCombo(4)
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
            txtemp.Enabled = True
            txtdet.Enabled = True
            txtemp.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from empresas where emp_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtemp.Text = dr.Item("Nome")
                txtdet.Text = dr.Item("Detalhes")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtemp.Enabled = True
            txtdet.Enabled = True
            txtemp.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from empresas where emp_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtemp.Text = dr.Item("Nome")
                txtdet.Text = dr.Item("Detalhes")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtemp.Enabled = False
            txtdet.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgemp.Columns.Clear()
            cm = New OleDbCommand("select * from empresas where emp_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgemp.Columns.Add("Emp_PK", "ID")
            Dtgemp.Columns.Add("Nome", "Empresa")
            Dtgemp.Columns.Add("Detalhes", "Detalhes")
            If dr.Read Then
                Dtgemp.Rows.Add(dr.Item("Emp_PK"), dr.Item("Nome"), dr.Item("Detalhes"))
                Dtgemp.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtemp.Text)) Then
                MsgBox("Preencha o campo com o nome da empresa!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtemp.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtdet.Text)) Then
                MsgBox("Preencha o campo com os detalhes!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtdet.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into empresas(Emp_pk,Nome,Detalhes,User_Fk) values('" & maxcode & "','" & txtemp.Text & "','" & txtdet.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(5)
            AtualizaCombo(4)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtemp.Enabled = False
            txtdet.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtemp.Text)) Then
                MsgBox("Preencha o campo com o nome da empresa!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtemp.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtdet.Text)) Then
                MsgBox("Preencha o campo com os detalhes!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtdet.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update empresas set nome = '" & txtemp.Text & "',detalhes = '" & txtdet.Text & "' where emp_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(5)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtemp.Enabled = False
            txtdet.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from empresas where emp_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(5)
                AtualizaCombo(4)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtemp.Enabled = False
                txtdet.Enabled = False
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por empresa
            Do
                input = InputBox("Digite o nome da empresa???", "Personal_book")
            Loop Until input <> ""
            Dtgemp.Columns.Clear()
            cm = New OleDbCommand("select * from empresas where nome like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgemp.Columns.Add("Emp_PK", "ID")
            Dtgemp.Columns.Add("Nome", "Empresa")
            Dtgemp.Columns.Add("Detalhes", "Detalhes")
            While dr.Read
                Dtgemp.Rows.Add(dr.Item("Emp_PK"), dr.Item("Nome"), dr.Item("Detalhes"))
            End While
            For cont = 0 To Dtgemp.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgemp.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgemp.RowCount > 1 Then
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
            txtemp.Enabled = False
            txtdet.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtemp.Enabled = False
            txtdet.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtemp.Enabled = False
            txtdet.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            AtualizaGrid(5)
        End If
    End Sub
End Class
