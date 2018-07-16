Imports System.Data.OleDb
Public Class Frmlog
    Private Sub Btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlog.Click
        If Trim(String.IsNullOrEmpty(Txtlog.Text)) Then
            MsgBox("Preencha o campo com seu login", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            Return
        End If
        If Trim(String.IsNullOrEmpty(Txtse.Text)) Then
            MsgBox("Preencha o campo com sua senha", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            Return
        End If
        Txtse.Text = Crypt(Txtse.Text)
        sql = "Select * from acesso where login = '" & Txtlog.Text & "' and senha = '" & Txtse.Text & "'"
        cm = New OleDbCommand(sql)
        adapt.SelectCommand = cm
        adapt.SelectCommand.Connection = cn
        dr = cm.ExecuteReader
        If dr.Read Then
            MsgBox("Login efetuado com sucesso!!!", MsgBoxStyle.Information, "Personal_book")
            coduser = dr.Item("user_pk") 'variavel que vai receber o codigo do usuario que esta logando
            Frmmenu.Show()
            Limpa_Controls(Me)
            Txtlog.Focus()
            Me.Hide()
        Else
            MsgBox("Login de acesso invalido!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Personal_book")
            Limpa_Controls(Me)
            Txtlog.Focus()
        End If
    End Sub
    Private Sub Btnsa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsa.Click
        If MsgBox("Deseja encerrar o sistema ???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
            cn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Frmlog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexaobanco()
    End Sub

    Private Sub Btncanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncanc.Click
        Limpa_Controls(Me)
        Txtlog.Focus()
    End Sub
End Class
