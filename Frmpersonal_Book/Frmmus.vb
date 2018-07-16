Imports System.Data.OleDb
Public Class Frmmus
    Private Sub Frmmus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtmus.Enabled = False
                txtband.Enabled = False
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
                txtmus.Enabled = False
                txtband.Enabled = False
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
                txtmus.Enabled = False
                txtband.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por banda"
                btnfunc3.Text = "Procurar por genero"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = False
                txtmus.Enabled = False
                txtband.Enabled = False
                cbogen.Enabled = False
        End Select
        AtualizaGrid(6)
        AtualizaCombo(6)
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
            txtmus.Enabled = True
            txtband.Enabled = True
            cbogen.Enabled = True
            txtmus.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from musicas where mus_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtmus.Text = dr.Item("Nome")
                txtband.Text = dr.Item("Banda")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtmus.Enabled = True
            txtband.Enabled = True
            cbogen.Enabled = True
            txtmus.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from musicas where mus_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtmus.Text = dr.Item("Nome")
                txtband.Text = dr.Item("Banda")
                cbogen.Text = dr.Item("Genero")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgmus.Columns.Clear()
            cm = New OleDbCommand("select * from musicas where mus_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgmus.Columns.Add("Mus_PK", "ID")
            Dtgmus.Columns.Add("Nome", "Musica")
            Dtgmus.Columns.Add("Banda", "Banda")
            Dtgmus.Columns.Add("Genero", "Genero")
            If dr.Read Then
                Dtgmus.Rows.Add(dr.Item("Mus_PK"), dr.Item("Nome"), dr.Item("Banda"), dr.Item("Genero"))
                Dtgmus.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtmus.Text)) Then
                MsgBox("Preencha o campo com o nome da musica!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtmus.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtband.Text)) Then
                MsgBox("Preencha o campo com o nome da banda!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtband.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o genero da musica!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into musicas(Mus_PK,Nome,Banda,Genero,User_Fk) values('" & maxcode & "','" & txtmus.Text & "','" & txtband.Text & "','" & cbogen.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(6)
            AtualizaCombo(6)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtmus.Text)) Then
                MsgBox("Preencha o campo com o nome da musica!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtmus.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtband.Text)) Then
                MsgBox("Preencha o campo com o nome da banda!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtband.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(cbogen.Text)) Then
                MsgBox("Preencha o campo com o genero da musica!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                cbogen.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update musicas set nome = '" & txtmus.Text & "',banda = '" & txtband.Text & "',genero = '" & cbogen.Text & "' where mus_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(6)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from musicas where mus_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(6)
                AtualizaCombo(6)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtmus.Enabled = False
                txtband.Enabled = False
                cbogen.Enabled = False
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por banda
            Do
                input = InputBox("Digite o nome da banda a ser procurada???", "Personal_book")
            Loop Until input <> ""
            Dtgmus.Columns.Clear()
            cm = New OleDbCommand("select * from musicas where banda like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgmus.Columns.Add("Mus_PK", "ID")
            Dtgmus.Columns.Add("Nome", "Musica")
            Dtgmus.Columns.Add("Banda", "Banda")
            Dtgmus.Columns.Add("Genero", "Genero")
            While dr.Read
                Dtgmus.Rows.Add(dr.Item("Mus_PK"), dr.Item("Nome"), dr.Item("Banda"), dr.Item("Genero"))
            End While
            For cont = 0 To Dtgmus.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgmus.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgmus.RowCount > 1 Then
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
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtmus.Enabled = False
            txtband.Enabled = False
            cbogen.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por genero
            Do
                input = InputBox("Digite o nome do genero a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtgmus.Columns.Clear()
            cm = New OleDbCommand("select * from musicas where genero like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgmus.Columns.Add("Mus_PK", "ID")
            Dtgmus.Columns.Add("Nome", "Musica")
            Dtgmus.Columns.Add("Banda", "Banda")
            Dtgmus.Columns.Add("Genero", "Genero")
            While dr.Read
                Dtgmus.Rows.Add(dr.Item("Mus_PK"), dr.Item("Nome"), dr.Item("Banda"), dr.Item("Genero"))
            End While
            For cont = 0 To Dtgmus.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgmus.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgmus.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub
End Class