Imports System.Data.OleDb
Public Class Frmacss
    Private Sub Frmacss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case op
            Case 1
                btnfunc1.Text = "Cadastrar"
                btnfunc2.Text = "Confirmar"
                btnfunc3.Text = "Cancelar"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
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
                txtlog.Enabled = False
                txtse.Enabled = False
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
                txtlog.Enabled = False
                txtse.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por login"
                btnfunc3.Text = "Retornar grid"
                btnfunc4.Text = "Fechar"
                Cbocod.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
        End Select
        AtualizaGrid(1)
        AtualizaCombo(1)
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
            txtlog.Enabled = True
            txtse.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtlog.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from acesso where user_pk = '" & Cbocod.Text & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtlog.Text = dr.Item("login")
                txtse.Text = Crypt(dr.Item("senha"))
            End If
            Cbocod.Enabled = False
            txtlog.Enabled = True
            txtse.Enabled = True
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            txtlog.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from acesso where user_pk = '" & Cbocod.Text & "'"
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtlog.Text = dr.Item("login")
                txtse.Text = dr.Item("senha")
            End If
            Cbocod.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgacss.Columns.Clear()
            cm = New OleDbCommand("select * from acesso where user_pk = '" & input & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgacss.Columns.Add("User_PK", "ID")
            Dtgacss.Columns.Add("Login", "User")
            Dtgacss.Columns.Add("Senha", "Password")
            If dr.Read Then
                Dtgacss.Rows.Add(dr.Item("User_PK"), dr.Item("login"), dr.Item("senha"))
                Dtgacss.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtlog.Text)) Then
                MsgBox("Preencha o campo com seu login!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtlog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtse.Text)) Then
                MsgBox("Preencha o campo com sua senha!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtse.Focus()
                Return
            End If
            txtse.Text = Crypt(txtse.Text)
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into acesso(User_PK,login,senha) values('" & maxcode & "','" & txtlog.Text & "','" & txtse.Text & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(1)
            AtualizaCombo(1)
            Cbocod.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtlog.Text)) Then
                MsgBox("Preencha o campo com seu login!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtlog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtse.Text)) Then
                MsgBox("Preencha o campo com sua senha!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtse.Focus()
                Return
            End If
            txtse.Text = Crypt(txtse.Text)
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update acesso set login = '" & txtlog.Text & "',senha = '" & txtse.Text & "' where user_pk = '" & Cbocod.Text & "'"
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(1)
            Cbocod.Enabled = True
            txtlog.Enabled = False
            txtse.Enabled = False
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
                cm.CommandText = "delete from acesso where user_pk = '" & Cbocod.Text & "'"
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(1)
                AtualizaCombo(1)
                Cbocod.Enabled = True
                txtlog.Enabled = False
                txtse.Enabled = False
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por login 
            Do
                input = InputBox("Digite um login a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtgacss.Columns.Clear()
            cm = New OleDbCommand("select * from acesso where login like '%" & input & "%'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgacss.Columns.Add("User_PK", "ID")
            Dtgacss.Columns.Add("Login", "User")
            Dtgacss.Columns.Add("Senha", "Password")
            While dr.Read
                Dtgacss.Rows.Add(dr.Item("User_PK"), dr.Item("login"), dr.Item("senha"))
            End While
            For cont = 0 To Dtgacss.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgacss.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgacss.RowCount > 1 Then
                MsgBox("O registro foi localizado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Else
                MsgBox("O registro não foi localizado!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            End If
        End If
    End Sub

    Private Sub btnfunc3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfunc3.Click
        'Botão Fechar
        If op = 1 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtlog.Enabled = False
            txtse.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            Cbocod.Enabled = True
            txtlog.Enabled = False
            txtse.Enabled = False
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Focus()
        ElseIf op = 4 Then
            'Comando SQL para retornar o grid em sua forma original
            AtualizaGrid(1)
        End If
    End Sub
    Private Sub Txtlog_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlog.LostFocus
        If (txtlog.Text <> "") And op = 1 Then
            sql = "Select * from acesso where login = '" & Txtlog.Text & "'"
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                MsgBox("Login já existe,favor escolher outro!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Txtlog.Text = ""
                Txtlog.Focus()
            End If
        End If
    End Sub
End Class