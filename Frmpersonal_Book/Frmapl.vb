Imports System.Data.OleDb
Public Class Frmapl
    Private Sub Frmapl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case op
            Case 1
                btnfunc1.Text = "Cadastrar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtapp.Enabled = False
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
                txtapp.Enabled = False
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
                txtapp.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por app"
                btnfunc3.Text = "Retornar grid"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtapp.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
        End Select
        AtualizaGrid(10)
        AtualizaCombo(10)
        DisableAccessmenu()
    End Sub

    Private Sub btnfunc4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc4.Click
        'Bot�o Fechar
        op = 0
        Limpa_Controls(Me)
        AbleAccessmenu()
        Me.Close()
    End Sub

    Private Sub btnfunc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc1.Click
        'Botao CRUD
        If op = 1 Then
            Cbocod.Enabled = False
            txtapp.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtapp.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from aplicativos where apl_pk = '" & Cbocod.Text & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtapp.Text = dr.Item("nome")
            End If
            Cbocod.Enabled = False
            txtapp.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtapp.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from aplicativos where apl_pk = '" & Cbocod.Text & "'"
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtapp.Text = dr.Item("nome")
            End If
            Cbocod.Enabled = False
            txtapp.Enabled = False
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgapl.Columns.Clear()
            cm = New OleDbCommand("select * from aplicativos where apl_pk = '" & input & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgapl.Columns.Add("Apl_PK", "ID")
            Dtgapl.Columns.Add("Nome", "Aplicativo")
            If dr.Read Then
                Dtgapl.Rows.Add(dr.Item("Apl_PK"), dr.Item("nome"))
                Dtgapl.Rows(0).DefaultCellStyle.BackColor = Color.Blue
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro n�o foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
            input = ""
        End If
    End Sub

    Private Sub btnfunc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc2.Click
        'Botao Confirmar 
        If op = 1 Then
            'Comando SQL para cadastro
            If Trim(String.IsNullOrEmpty(txtapp.Text)) Then
                MsgBox("Preencha o campo com o nome do aplicativo!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtapp.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into aplicativos(Apl_PK,Nome,User_FK) values('" & maxcode & "','" & txtapp.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(10)
            AtualizaCombo(10)
            Cbocod.Enabled = False
            txtapp.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtapp.Text)) Then
                MsgBox("Preencha o campo com o nome do aplicativo!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtapp.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update aplicativos set nome = '" & txtapp.Text & "' where apl_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualiza��o efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(10)
            Cbocod.Enabled = True
            txtapp.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua a��o???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from aplicativos where apl_pk = '" & Cbocod.Text & "'"
                cm.ExecuteNonQuery()
                MsgBox("Exclus�o efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(10)
                AtualizaCombo(10)
                Cbocod.Enabled = True
                txtapp.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por aplicativo 
            Do
                input = InputBox("Digite um aplicativo a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtgapl.Columns.Clear()
            cm = New OleDbCommand("select * from aplicativos where nome like '%" & input & "%'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgapl.Columns.Add("Apl_PK", "ID")
            Dtgapl.Columns.Add("Nome", "Aplicativo")
            While dr.Read
                Dtgapl.Rows.Add(dr.Item("Apl_PK"), dr.Item("Nome"))
            End While
            For cont = 0 To Dtgapl.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgapl.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgapl.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro n�o foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub

    Private Sub btnfunc3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc3.Click
        'Bot�o Fechar
        If op = 1 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = False
            txtapp.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtapp.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtapp.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para retornar o grid em sua forma original
            AtualizaGrid(10)
        End If
    End Sub
End Class
