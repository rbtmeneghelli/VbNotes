Imports System.Data.OleDb
Public Class Frmgym
    Private Sub Frmgym_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtnome.Enabled = False
                cbotipo.Enabled = False
                cborep.Enabled = False
                cbonivel.Enabled = False
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
                txtnome.Enabled = False
                cbotipo.Enabled = False
                cborep.Enabled = False
                cbonivel.Enabled = False
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
                txtnome.Enabled = False
                cbotipo.Enabled = False
                cborep.Enabled = False
                cbonivel.Enabled = False
                Cbocod.Focus()
            Case 4
                btnfunc1.Text = "Procurar por nome"
                btnfunc2.Text = "Procurar por tipo"
                btnfunc3.Text = "Procurar por nivel"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtnome.Enabled = False
                cbotipo.Enabled = False
                cborep.Enabled = False
                cbonivel.Enabled = False
        End Select
        AtualizaGrid(3)
        AtualizaCombo(5)
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
            cbotipo.Enabled = True
            cborep.Enabled = True
            cbonivel.Enabled = True
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
            sql = "Select * from academia where acm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtnome.Text = dr.Item("Nome")
                cbotipo.Text = dr.Item("Tipo")
                cborep.Text = dr.Item("Serie")
                cbonivel.Text = dr.Item("Nivel")
            End If
            Cbocod.Enabled = False
            txtnome.Enabled = True
            cbotipo.Enabled = True
            cborep.Enabled = True
            cbonivel.Enabled = True
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
            sql = "Select * from academia where acm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtnome.Text = dr.Item("Nome")
                cbotipo.Text = dr.Item("Tipo")
                cborep.Text = dr.Item("Serie")
                cbonivel.Text = dr.Item("Nivel")
            End If
            Cbocod.Enabled = False
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por nome de exercicio 
            Do
                input = InputBox("Digite um nome de exercicio a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtggym.Columns.Clear()
            cm = New OleDbCommand("select * from academia where nome like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtggym.Columns.Add("Acm_PK", "ID")
            Dtggym.Columns.Add("Nome", "Nome")
            Dtggym.Columns.Add("Tipo", "Tipo")
            Dtggym.Columns.Add("Serie", "Serie")
            Dtggym.Columns.Add("Nivel", "Nivel")
            While dr.Read
                Dtggym.Rows.Add(dr.Item("Acm_PK"), dr.Item("Nome"), dr.Item("Tipo"), dr.Item("Serie"), dr.Item("Nivel"))
            End While
            For cont = 0 To Dtggym.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtggym.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtggym.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
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
            If Trim(String.IsNullOrEmpty(cbotipo.Text)) Then
                MsgBox("Preencha o campo com o tipo de exercicio!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbotipo.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cborep.Text)) Then
                MsgBox("Preencha o campo com o numero de repetições!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cborep.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbonivel.Text)) Then
                MsgBox("Preencha o campo com o nivel do exercicio!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbonivel.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into academia(Acm_PK,Nome,Tipo,Serie,Nivel,User_Fk) values('" & maxcode & "','" & txtnome.Text & "','" & cbotipo.Text & "','" & cborep.Text & "','" & cbonivel.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(3)
            AtualizaCombo(5)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtnome.Text)) Then
                MsgBox("Preencha o campo com seu nome!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtnome.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbotipo.Text)) Then
                MsgBox("Preencha o campo com o tipo de exercicio!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbotipo.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cborep.Text)) Then
                MsgBox("Preencha o campo com o numero de repetições!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cborep.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbonivel.Text)) Then
                MsgBox("Preencha o campo com o nivel do exercicio!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbonivel.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update academia set nome = '" & txtnome.Text & "',tipo = '" & cbotipo.Text & "',serie = '" & cborep.Text & "',nivel = '" & cbonivel.Text & "' where acm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(3)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from academia where acm_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(3)
                AtualizaCombo(5)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtnome.Enabled = False
                cbotipo.Enabled = False
                cborep.Enabled = False
                cbonivel.Enabled = False
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por tipo de musculo
            Do
                input = InputBox("Digite um tipo de musculo a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtggym.Columns.Clear()
            cm = New OleDbCommand("select * from academia where tipo like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtggym.Columns.Add("Acm_PK", "ID")
            Dtggym.Columns.Add("Nome", "Nome")
            Dtggym.Columns.Add("Tipo", "Tipo")
            Dtggym.Columns.Add("Serie", "Serie")
            Dtggym.Columns.Add("Nivel", "Nivel")
            While dr.Read
                Dtggym.Rows.Add(dr.Item("Acm_PK"), dr.Item("Nome"), dr.Item("Tipo"), dr.Item("Serie"), dr.Item("Nivel"))
            End While
            For cont = 0 To Dtggym.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtggym.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtggym.RowCount > 1 Then
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
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtnome.Enabled = False
            cbotipo.Enabled = False
            cborep.Enabled = False
            cbonivel.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por nivel de exercicio
            Do
                input = InputBox("Digite o nivel de exercicio a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtggym.Columns.Clear()
            cm = New OleDbCommand("select * from academia where nivel like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtggym.Columns.Add("Acm_PK", "ID")
            Dtggym.Columns.Add("Nome", "Nome")
            Dtggym.Columns.Add("Tipo", "Tipo")
            Dtggym.Columns.Add("Serie", "Serie")
            Dtggym.Columns.Add("Nivel", "Nivel")
            While dr.Read
                Dtggym.Rows.Add(dr.Item("Acm_PK"), dr.Item("Nome"), dr.Item("Tipo"), dr.Item("Serie"), dr.Item("Nivel"))
            End While
            For cont = 0 To Dtggym.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtggym.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtggym.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub
End Class