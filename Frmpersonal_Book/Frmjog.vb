Imports System.Data.OleDb
Public Class Frmjog
    Private Sub Frmjog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtjog.Enabled = False
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
                txtjog.Enabled = False
                cbogen.Enabled = False
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
                txtjog.Enabled = False
                cbogen.Enabled = False
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por seriado"
                btnfunc3.Text = "Procurar por genero"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtjog.Enabled = False
                cbogen.Enabled = False
        End Select
        AtualizaGrid(9)
        AtualizaCombo(9)
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
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtjog.Enabled = True
            cbogen.Enabled = True
            txtjog.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from jogos where jog_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtjog.Text = dr.Item("Nome")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtjog.Enabled = True
            cbogen.Enabled = True
            txtjog.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from jogos where jog_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtjog.Text = dr.Item("Nome")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtjog.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgjog.Columns.Clear()
            cm = New OleDbCommand("select * from jogos where jog_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgjog.Columns.Add("Jog_pk", "ID")
            Dtgjog.Columns.Add("Nome", "Jogo")
            Dtgjog.Columns.Add("Genero", "Genero")
            If dr.Read Then
                Dtgjog.Rows.Add(dr.Item("Jog_pk"), dr.Item("Nome"), dr.Item("Genero"))
                Dtgjog.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtjog.Text)) Then
                MsgBox("Preencha o campo com o nome do jogo!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtjog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o nome do genero!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into jogos(jog_pk,Nome,Genero,User_Fk) values('" & maxcode & "','" & txtjog.Text & "','" & cbogen.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(9)
            AtualizaCombo(9)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtjog.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtjog.Text)) Then
                MsgBox("Preencha o campo com o nome do jogo!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtjog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o nome do genero!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update jogos set nome = '" & txtjog.Text & "',genero = '" & cbogen.Text & "' where jog_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualiza��o efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(9)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtjog.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua a��o???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from jogos where jog_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclus�o efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(9)
                AtualizaCombo(9)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtjog.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por jogo
            Do
                input = InputBox("Digite o nome do jogo???", "Personal_book")
            Loop Until input <> ""
            Dtgjog.Columns.Clear()
            cm = New OleDbCommand("select * from jogos where nome like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgjog.Columns.Add("Jog_PK", "ID")
            Dtgjog.Columns.Add("Nome", "Jogo")
            Dtgjog.Columns.Add("Genero", "Genero")
            While dr.Read
                Dtgjog.Rows.Add(dr.Item("Jog_PK"), dr.Item("Nome"), dr.Item("Genero"))
            End While
            For cont = 0 To Dtgjog.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgjog.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgjog.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro n�o foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub

    Private Sub btnfunc3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc3.Click
        'Bot�o Cancelar
        If op = 1 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtjog.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtjog.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtjog.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por jogo
            Do
                input = InputBox("Digite o genero do jogo???", "Personal_book")
            Loop Until input <> ""
            Dtgjog.Columns.Clear()
            cm = New OleDbCommand("select * from jogos where genero like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgjog.Columns.Add("Jog_PK", "ID")
            Dtgjog.Columns.Add("Nome", "Jogo")
            Dtgjog.Columns.Add("Genero", "Genero")
            While dr.Read
                Dtgjog.Rows.Add(dr.Item("Jog_PK"), dr.Item("Nome"), dr.Item("Genero"))
            End While
            For cont = 0 To Dtgjog.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgjog.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgjog.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro n�o foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub
End Class