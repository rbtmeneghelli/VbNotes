Imports System.IO.File
Public Class Frmmenu
    Private Sub CadastrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem.Click
        op = 1
        Frmacss.MdiParent = Me
        Frmacss.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem.Click
        op = 2
        Frmacss.MdiParent = Me
        Frmacss.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem.Click
        op = 3
        Frmacss.MdiParent = Me
        Frmacss.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem.Click
        op = 4
        Frmacss.MdiParent = Me
        Frmacss.Show()
    End Sub

    Private Sub Frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        op = 0
        AbleAccessmenu()
    End Sub

    Private Sub CadastrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem1.Click
        op = 1
        Frmgym.MdiParent = Me
        Frmgym.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem1.Click
        op = 2
        Frmgym.MdiParent = Me
        Frmgym.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem1.Click
        op = 3
        Frmgym.MdiParent = Me
        Frmgym.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem1.Click
        op = 4
        Frmgym.MdiParent = Me
        Frmgym.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem2.Click
        op = 1
        Frmamg.MdiParent = Me
        Frmamg.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem2.Click
        op = 2
        Frmamg.MdiParent = Me
        Frmamg.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem2.Click
        op = 3
        Frmamg.MdiParent = Me
        Frmamg.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem2.Click
        op = 4
        Frmamg.MdiParent = Me
        Frmamg.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem3.Click
        op = 2
        Frmcom.MdiParent = Me
        Frmcom.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem3.Click
        op = 3
        Frmcom.MdiParent = Me
        Frmcom.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem3.Click
        op = 4
        Frmcom.MdiParent = Me
        Frmcom.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem3.Click
        op = 1
        Frmcom.MdiParent = Me
        Frmcom.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem6.Click
        op = 1
        Frmser.MdiParent = Me
        Frmser.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem6.Click
        op = 2
        Frmser.MdiParent = Me
        Frmser.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem6.Click
        op = 3
        Frmser.MdiParent = Me
        Frmser.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem6.Click
        op = 4
        Frmser.MdiParent = Me
        Frmser.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem4.Click
        op = 1
        Frmemp.MdiParent = Me
        Frmemp.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem4.Click
        op = 2
        Frmemp.MdiParent = Me
        Frmemp.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem4.Click
        op = 3
        Frmemp.MdiParent = Me
        Frmemp.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem4.Click
        op = 4
        Frmemp.MdiParent = Me
        Frmemp.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem5.Click
        op = 1
        Frmmus.MdiParent = Me
        Frmmus.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem5.Click
        op = 2
        Frmmus.MdiParent = Me
        Frmmus.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem5.Click
        op = 3
        Frmmus.MdiParent = Me
        Frmmus.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem5.Click
        op = 4
        Frmmus.MdiParent = Me
        Frmmus.Show()
    End Sub

    Private Sub CadastrarToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem7.Click
        op = 1
        Frmsites.MdiParent = Me
        Frmsites.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem7.Click
        op = 2
        Frmsites.MdiParent = Me
        Frmsites.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem7.Click
        op = 3
        Frmsites.MdiParent = Me
        Frmsites.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem7.Click
        op = 4
        Frmsites.MdiParent = Me
        Frmsites.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Deseja fazer logoff do sistema???", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Personal_Book") = MsgBoxResult.Yes Then
            op = 0
            Me.Close()
            Frmlog.Show()
        End If
    End Sub

    Private Sub CadastrarToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem8.Click
        op = 1
        Frmjog.MdiParent = Me
        Frmjog.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem8.Click
        op = 2
        Frmjog.MdiParent = Me
        Frmjog.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem8.Click
        op = 3
        Frmjog.MdiParent = Me
        Frmjog.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        op = 4
        Frmjog.MdiParent = Me
        Frmjog.Show()
    End Sub
    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        Dim fileOrigem As String = Application.StartupPath & "\Privdatabase.accdb"
        Dim filedestino As String, o As New FolderBrowserDialog
        MsgBox("Escolha o destino de backup do arquivo", MsgBoxStyle.Information, "Personal_book")
        If o.ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub
        filedestino = o.SelectedPath & "\backup.accdb"
        IO.File.Copy(fileOrigem, filedestino)
        MsgBox("Backup realizado com sucesso", MsgBoxStyle.Information, "Personal_book")
    End Sub
    Private Sub CadastrarToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarToolStripMenuItem9.Click
        op = 1
        Frmapl.MdiParent = Me
        Frmapl.Show()
    End Sub

    Private Sub AlterarToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem9.Click
        op = 2
        Frmapl.MdiParent = Me
        Frmapl.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem9.Click
        op = 3
        Frmapl.MdiParent = Me
        Frmapl.Show()
    End Sub

    Private Sub ProcurarToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcurarToolStripMenuItem8.Click
        op = 4
        Frmapl.MdiParent = Me
        Frmapl.Show()
    End Sub
End Class