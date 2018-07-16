Imports System.Data.OleDb
Public Class Frmsites
    Private Sub Frmser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                txtsit.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
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
                txtsit.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
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
                txtsit.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
                Cbocod.Focus()
            Case 4
                btnfunc1.Text = "Procurar por codigo"
                btnfunc2.Text = "Procurar por site"
                btnfunc3.Text = "Retornar grid"
                btnfunc4.Text = "Fechar"
                btnfunc1.Enabled = True
                btnfunc2.Enabled = True
                btnfunc3.Enabled = True
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtsit.Enabled = True
                txtlog.Enabled = True
                txtse.Enabled = True
        End Select
        AtualizaGrid(8)
        AtualizaCombo(8)
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
            txtsit.Enabled = True
            txtlog.Enabled = True
            txtse.Enabled = True
            txtsit.Focus()
            Me.Cbocod.Items.Add(maxcode)
            Cbocod.Text = maxcode
        ElseIf op = 2 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from sites where app_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtsit.Text = dr.Item("Site")
                txtlog.Text = dr.Item("Login")
                txtse.Text = dr.Item("Senha")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtsit.Enabled = True
            txtlog.Enabled = True
            txtse.Enabled = True
            txtsit.Focus()
        ElseIf op = 3 Then
            If Trim(String.IsNullOrEmpty(Cbocod.Text)) Then
                MsgBox("Codigo invalido,selecione um!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                Cbocod.Focus()
                Return
            End If
            sql = "Select * from sites where app_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm = New OleDbCommand(sql)
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            If dr.Read Then
                txtsit.Text = dr.Item("Site")
                txtlog.Text = dr.Item("Login")
                txtse.Text = dr.Item("Senha")
            End If
            btnfunc1.Enabled = False
            btnfunc2.Enabled = True
            btnfunc3.Enabled = True
            btnfunc4.Enabled = False
            Cbocod.Enabled = False
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por codigo
            Do
                input = InputBox("Digite um codigo a ser procurado???", "Personal_book")
            Loop Until IsNumeric(input) AndAlso input > 0
            Dtgsit.Columns.Clear()
            cm = New OleDbCommand("select * from sites where app_pk = '" & input & "' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgsit.Columns.Add("App_PK", "ID")
            Dtgsit.Columns.Add("Site", "Site")
            Dtgsit.Columns.Add("Login", "Login")
            Dtgsit.Columns.Add("Senha", "Senha")
            If dr.Read Then
                Dtgsit.Rows.Add(dr.Item("App_PK"), dr.Item("Site"), dr.Item("Login"), dr.Item("Senha"))
                Dtgsit.Rows(0).DefaultCellStyle.BackColor = Color.Blue
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
            If Trim(String.IsNullOrEmpty(txtsit.Text)) Then
                MsgBox("Preencha o campo com o nome do site!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtsit.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtlog.Text)) Then
                MsgBox("Preencha o campo com o login!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtlog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtse.Text)) Then
                MsgBox("Preencha o campo com a senha!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtse.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Insert into sites(App_PK,Site,Login,Senha,User_Fk) values('" & maxcode & "','" & txtsit.Text & "','" & txtlog.Text & "','" & txtse.Text & "','" & coduser & "')"
            cm.ExecuteNonQuery()
            MsgBox("Cadastro efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(8)
            AtualizaCombo(8)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = False
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
        ElseIf op = 2 Then
            'Comando SQL para Alterar
            If Trim(String.IsNullOrEmpty(txtsit.Text)) Then
                MsgBox("Preencha o campo com o nome do site!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtsit.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtlog.Text)) Then
                MsgBox("Preencha o campo com o login!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtlog.Focus()
                Return
            End If
            If Trim(String.IsNullOrEmpty(txtse.Text)) Then
                MsgBox("Preencha o campo com a senha!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
                txtse.Focus()
                Return
            End If
            cm = New OleDbCommand()
            cm.Connection = cn
            cm.CommandText = "Update sites set site = '" & txtsit.Text & "',login = '" & txtlog.Text & "',senha = '" & txtse.Text & "' where app_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
            cm.ExecuteNonQuery()
            MsgBox("Atualização efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            Limpa_Controls(Me)
            AtualizaGrid(8)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            'Comando SQL para excluir
            If MsgBox("Deseja realmente confirmar sua ação???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
                cm = New OleDbCommand()
                cm.Connection = cn
                cm.CommandText = "delete from sites where app_pk = '" & Cbocod.Text & "' and user_fk = '" & coduser & "' "
                cm.ExecuteNonQuery()
                MsgBox("Exclusão efetuada com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
                Limpa_Controls(Me)
                AtualizaGrid(8)
                AtualizaCombo(8)
                btnfunc1.Enabled = True
                btnfunc2.Enabled = False
                btnfunc3.Enabled = False
                btnfunc4.Enabled = True
                Cbocod.Enabled = True
                txtsit.Enabled = False
                txtlog.Enabled = False
                txtse.Enabled = False
                Cbocod.Focus()
            End If
        ElseIf op = 4 Then
            'Comando SQL para procurar registro por site
            Do
                input = InputBox("Digite o nome do site a ser procurado???", "Personal_book")
            Loop Until input <> ""
            Dtgsit.Columns.Clear()
            cm = New OleDbCommand("select * from sites where site like '%" & input & "%' and user_fk = '" & coduser & "'")
            adapt.SelectCommand = cm
            adapt.SelectCommand.Connection = cn
            dr = cm.ExecuteReader
            adapt = New OleDbDataAdapter(sql, cn)
            Dtgsit.Columns.Add("App_PK", "ID")
            Dtgsit.Columns.Add("Site", "Site")
            Dtgsit.Columns.Add("Login", "Login")
            Dtgsit.Columns.Add("Senha", "Senha")
            While dr.Read
                Dtgsit.Rows.Add(dr.Item("App_PK"), dr.Item("Site"), dr.Item("Login"), dr.Item("Senha"))
            End While
            For cont = 0 To Dtgsit.Rows.Count - 1
                If cont Mod 2 = 0 Then
                    Dtgsit.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                End If
            Next cont
            If Dtgsit.RowCount > 1 Then
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
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
        ElseIf op = 2 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            Cbocod.Focus()
        ElseIf op = 3 Then
            Limpa_Controls(Me)
            btnfunc1.Enabled = True
            btnfunc2.Enabled = False
            btnfunc3.Enabled = False
            btnfunc4.Enabled = True
            Cbocod.Enabled = True
            txtsit.Enabled = False
            txtlog.Enabled = False
            txtse.Enabled = False
            Cbocod.Focus()
        ElseIf op = 4 Then
            AtualizaGrid(8)
        End If
    End Sub
End Class