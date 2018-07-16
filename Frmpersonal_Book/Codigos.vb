Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Module Codigos
    Public backupfile As String 'Variavel de unidade de disco ou unidade movel para realização de backup!!!
    Public op As Integer 'Funções CRUD
    Public coduser As Integer 'Codigo do usuario
    Public cont As Integer 'Contador
    Public input As String = "" 'Variavel do inputbox
    Public maxcode As Integer = 1 'Codigo maximo do usuario
    Public cn As OleDbConnection
    Public cm As OleDbCommand
    Public dr As OleDbDataReader
    Public strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Privdatabase.accdb;Persist Security Info=False;"
    Public adapt As OleDbDataAdapter
    Public tbl As System.Data.DataTable
    Public sql As String
    Public ds As New System.Data.DataSet
    Public Function conexaobanco()
        Try
            cn = New OleDbConnection(strcon)
            cn.Open()
            adapt = New OleDbDataAdapter
            tbl = New System.Data.DataTable
            'MessageBox.Show("Conexão efetuada com sucesso!!!")
        Catch
            MessageBox.Show("Conexão não efetutada com sucesso!!!")
        End Try
        Return True
    End Function
    Public Function Crypt(ByVal Text As String) As String
        Dim strTempChar As String
        Dim i As Integer
        strTempChar = ""
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) + 128
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) - 128
            End If
            Mid$(Text, i, 1) = Chr(strTempChar)
        Next i
        Crypt = Text
    End Function
    Public Sub Limpa_Controls(ByRef Tela As Control)
        On Error Resume Next
        Dim Campo As Object
        For Each Campo In Tela.Controls
            If TypeOf Campo Is System.Windows.Forms.GroupBox Or TypeOf Campo Is System.Windows.Forms.TabPage Or TypeOf Campo Is System.Windows.Forms.Panel Then
                Limpa_Controls(Campo)
            ElseIf TypeOf Campo Is System.Windows.Forms.TextBox Then
                Campo.Text = ""
            ElseIf TypeOf Campo Is System.Windows.Forms.ComboBox Then
                If Campo.DropDownStyle = ComboBoxStyle.DropDownList Then
                    Campo.SelectedIndex = -1
                Else
                    Campo.Text = ""
                End If
            ElseIf TypeOf Campo Is System.Windows.Forms.CheckBox Then
                Campo.Checked = False
            ElseIf TypeOf Campo Is System.Windows.Forms.MaskedTextBox Then
                Campo.Text = ""
            End If
        Next
    End Sub
    Public Function AtualizaGrid(ByVal gop As Integer)
        Select Case gop
            Case 1
                Frmacss.Dtgacss.Columns.Clear()
                cm = New OleDbCommand("select * from acesso where user_pk = '" & coduser & "' order by user_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmacss.Dtgacss.Columns.Add("User_PK", "ID")
                Frmacss.Dtgacss.Columns.Add("Login", "User")
                Frmacss.Dtgacss.Columns.Add("Senha", "Password")
                While dr.Read
                    Frmacss.Dtgacss.Rows.Add(dr.Item("User_PK"), dr.Item("login"), dr.Item("senha"))
                End While
                For cont = 0 To Frmacss.Dtgacss.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmacss.Dtgacss.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 2
                Frmamg.Dtgamg.Columns.Clear()
                cm = New OleDbCommand("select * from amigos where user_fk = '" & coduser & "' order by amg_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmamg.Dtgamg.Columns.Add("Amg_PK", "ID")
                Frmamg.Dtgamg.Columns.Add("Nome", "User")
                Frmamg.Dtgamg.Columns.Add("Telefone", "Telefone")
                Frmamg.Dtgamg.Columns.Add("Celular", "Celular")
                Frmamg.Dtgamg.Columns.Add("RedeSocial", "Rede Social")
                While dr.Read
                    Frmamg.Dtgamg.Rows.Add(dr.Item("Amg_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Celular"), dr.Item("Redesocial"))
                End While
                For cont = 0 To Frmamg.Dtgamg.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmamg.Dtgamg.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 3
                Frmgym.Dtggym.Columns.Clear()
                cm = New OleDbCommand("select * from academia where user_fk = '" & coduser & "' order by acm_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmgym.Dtggym.Columns.Add("Acm_PK", "ID")
                Frmgym.Dtggym.Columns.Add("Nome", "Nome")
                Frmgym.Dtggym.Columns.Add("Tipo", "Tipo")
                Frmgym.Dtggym.Columns.Add("Serie", "Serie")
                Frmgym.Dtggym.Columns.Add("Nivel", "Nivel")
                While dr.Read
                    Frmgym.Dtggym.Rows.Add(dr.Item("Acm_PK"), dr.Item("Nome"), dr.Item("Tipo"), dr.Item("Serie"), dr.Item("Nivel"))
                End While
                For cont = 0 To Frmgym.Dtggym.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmgym.Dtggym.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 4
                Frmcom.Dtgcom.Columns.Clear()
                cm = New OleDbCommand("select * from comercio where user_fk = '" & coduser & "' order by crm_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmcom.Dtgcom.Columns.Add("Crm_PK", "ID")
                Frmcom.Dtgcom.Columns.Add("Nome", "Nome")
                Frmcom.Dtgcom.Columns.Add("Telefone", "Telefone")
                Frmcom.Dtgcom.Columns.Add("Genero", "Genero")
                While dr.Read
                    Frmcom.Dtgcom.Rows.Add(dr.Item("Crm_PK"), dr.Item("Nome"), dr.Item("Telefone"), dr.Item("Genero"))
                End While
                For cont = 0 To Frmcom.Dtgcom.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmcom.Dtgcom.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 5
                Frmemp.Dtgemp.Columns.Clear()
                cm = New OleDbCommand("select * from empresas where user_fk = '" & coduser & "' order by emp_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmemp.Dtgemp.Columns.Add("Emp_PK", "ID")
                Frmemp.Dtgemp.Columns.Add("Nome", "Nome")
                Frmemp.Dtgemp.Columns.Add("Detalhes", "Detalhes")
                While dr.Read
                    Frmemp.Dtgemp.Rows.Add(dr.Item("Emp_PK"), dr.Item("Nome"), dr.Item("Detalhes"))
                End While
                For cont = 0 To Frmemp.Dtgemp.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmemp.Dtgemp.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 6
                Frmmus.Dtgmus.Columns.Clear()
                cm = New OleDbCommand("select * from Musicas where user_fk = '" & coduser & "' order by mus_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmmus.Dtgmus.Columns.Add("Mus_PK", "ID")
                Frmmus.Dtgmus.Columns.Add("Nome", "Nome")
                Frmmus.Dtgmus.Columns.Add("Banda", "Banda")
                Frmmus.Dtgmus.Columns.Add("Genero", "Genero")
                While dr.Read
                    Frmmus.Dtgmus.Rows.Add(dr.Item("Mus_PK"), dr.Item("Nome"), dr.Item("Banda"), dr.Item("Genero"))
                End While
                For cont = 0 To Frmmus.Dtgmus.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmmus.Dtgmus.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 7
                Frmser.Dtgser.Columns.Clear()
                cm = New OleDbCommand("select * from seriados where user_fk = '" & coduser & "' order by ser_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmser.Dtgser.Columns.Add("Ser_PK", "ID")
                Frmser.Dtgser.Columns.Add("Nome", "Nome")
                Frmser.Dtgser.Columns.Add("Genero", "Genero")
                While dr.Read
                    Frmser.Dtgser.Rows.Add(dr.Item("Ser_PK"), dr.Item("Nome"), dr.Item("Genero"))
                End While
                For cont = 0 To Frmser.Dtgser.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmser.Dtgser.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 8
                Frmsites.Dtgsit.Columns.Clear()
                cm = New OleDbCommand("select * from sites where user_fk = '" & coduser & "' order by app_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmsites.Dtgsit.Columns.Add("App_PK", "ID")
                Frmsites.Dtgsit.Columns.Add("Site", "Site")
                Frmsites.Dtgsit.Columns.Add("Login", "User")
                Frmsites.Dtgsit.Columns.Add("Senha", "Password")
                While dr.Read
                    Frmsites.Dtgsit.Rows.Add(dr.Item("App_PK"), dr.Item("Site"), dr.Item("Login"), dr.Item("Senha"))
                End While
                For cont = 0 To Frmsites.Dtgsit.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmsites.Dtgsit.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 9
                Frmjog.Dtgjog.Columns.Clear()
                cm = New OleDbCommand("select * from jogos where user_fk = '" & coduser & "' order by jog_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmjog.Dtgjog.Columns.Add("Jog_PK", "ID")
                Frmjog.Dtgjog.Columns.Add("Nome", "Jogo")
                Frmjog.Dtgjog.Columns.Add("Genero", "Genero")
                While dr.Read
                    Frmjog.Dtgjog.Rows.Add(dr.Item("Jog_PK"), dr.Item("Nome"), dr.Item("Genero"))
                End While
                For cont = 0 To Frmjog.Dtgjog.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmjog.Dtgjog.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
            Case 10
                Frmapl.Dtgapl.Columns.Clear()
                cm = New OleDbCommand("select * from aplicativos where user_fk = '" & coduser & "' order by apl_pk")
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                adapt = New OleDbDataAdapter(sql, cn)
                Frmapl.Dtgapl.Columns.Add("Apl_PK", "ID")
                Frmapl.Dtgapl.Columns.Add("Nome", "Aplicativo")
                While dr.Read
                    Frmapl.Dtgapl.Rows.Add(dr.Item("Apl_PK"), dr.Item("Nome"))
                End While
                For cont = 0 To Frmapl.Dtgapl.Rows.Count - 1
                    If cont Mod 2 = 0 Then
                        Frmapl.Dtgapl.Rows(cont).DefaultCellStyle.BackColor = Color.Blue
                    End If
                Next cont
        End Select
        Return True
    End Function
    Public Function AtualizaCombo(ByVal mop As Integer)
        maxcode = 1
        Select Case mop
            Case 1
                Frmacss.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select user_pk from acesso where user_pk = '" & coduser & "' order by user_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmacss.Cbocod.Items.Add(dr.Item("user_pk"))
                    maxcode = maxcode + 1
                End While
            Case 2
                Frmamg.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select amg_pk from amigos where user_fk = '" & coduser & "' order by amg_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmamg.Cbocod.Items.Add(dr.Item("amg_pk"))
                    maxcode = maxcode + 1
                End While
            Case 3
                Frmcom.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select crm_pk from comercio where user_fk = '" & coduser & "' order by crm_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmcom.Cbocod.Items.Add(dr.Item("crm_pk"))
                    maxcode = maxcode + 1
                End While
            Case 4
                Frmemp.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select emp_pk from empresas where user_fk = '" & coduser & "' order by emp_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmemp.Cbocod.Items.Add(dr.Item("emp_pk"))
                    maxcode = maxcode + 1
                End While
            Case 5
                Frmgym.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select acm_pk from academia where user_fk = '" & coduser & "' order by acm_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmgym.Cbocod.Items.Add(dr.Item("acm_pk"))
                    maxcode = maxcode + 1
                End While
            Case 6
                Frmmus.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select mus_pk from musicas where user_fk = '" & coduser & "' order by mus_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmmus.Cbocod.Items.Add(dr.Item("mus_pk"))
                    maxcode = maxcode + 1
                End While
            Case 7
                Frmser.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select ser_pk from seriados where user_fk = '" & coduser & "' order by ser_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmser.Cbocod.Items.Add(dr.Item("ser_pk"))
                    maxcode = maxcode + 1
                End While
            Case 8
                Frmsites.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select app_pk from sites where user_fk = '" & coduser & "' order by app_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmsites.Cbocod.Items.Add(dr.Item("app_pk"))
                    maxcode = maxcode + 1
                End While
            Case 9
                Frmjog.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select jog_pk from jogos where user_fk = '" & coduser & "' order by jog_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmjog.Cbocod.Items.Add(dr.Item("jog_pk"))
                    maxcode = maxcode + 1
                End While
            Case 10
                Frmapl.Cbocod.Items.Clear()
                'Preenchimento do combobox codigo
                sql = "Select apl_pk from aplicativos where user_fk = '" & coduser & "' order by apl_pk"
                cm = New OleDbCommand(sql)
                adapt.SelectCommand = cm
                adapt.SelectCommand.Connection = cn
                dr = cm.ExecuteReader
                While dr.Read
                    Frmapl.Cbocod.Items.Add(dr.Item("apl_pk"))
                    maxcode = maxcode + 1
                End While
        End Select
        Return True
    End Function
    Public Function AbleAccessmenu()
        If coduser = 1 Then
            Frmmenu.AcessoToolStripMenuItem.Enabled = True
            Frmmenu.AcademiaToolStripMenuItem.Enabled = True
            Frmmenu.AmigosToolStripMenuItem.Enabled = True
            Frmmenu.AplicativosToolStripMenuItem.Enabled = True
            Frmmenu.ComercioToolStripMenuItem.Enabled = True
            Frmmenu.EmpresaToolStripMenuItem.Enabled = True
            Frmmenu.JogoToolStripMenuItem.Enabled = True
            Frmmenu.MusicaToolStripMenuItem.Enabled = True
            Frmmenu.SeriadoToolStripMenuItem.Enabled = True
            Frmmenu.SiteToolStripMenuItem.Enabled = True
            Frmmenu.BackupToolStripMenuItem.Enabled = True
            Frmmenu.SairToolStripMenuItem.Enabled = True
        Else
            Frmmenu.AcessoToolStripMenuItem.Enabled = False
            Frmmenu.AcademiaToolStripMenuItem.Enabled = True
            Frmmenu.AmigosToolStripMenuItem.Enabled = True
            Frmmenu.AplicativosToolStripMenuItem.Enabled = True
            Frmmenu.ComercioToolStripMenuItem.Enabled = True
            Frmmenu.EmpresaToolStripMenuItem.Enabled = True
            Frmmenu.JogoToolStripMenuItem.Enabled = True
            Frmmenu.MusicaToolStripMenuItem.Enabled = True
            Frmmenu.SeriadoToolStripMenuItem.Enabled = True
            Frmmenu.SiteToolStripMenuItem.Enabled = True
            Frmmenu.BackupToolStripMenuItem.Enabled = True
            Frmmenu.SairToolStripMenuItem.Enabled = True
        End If
        Return True
    End Function
    Public Function DisableAccessmenu()
        If coduser = 1 Then
            Frmmenu.AcessoToolStripMenuItem.Enabled = False
            Frmmenu.AcademiaToolStripMenuItem.Enabled = False
            Frmmenu.AmigosToolStripMenuItem.Enabled = False
            Frmmenu.AplicativosToolStripMenuItem.Enabled = False
            Frmmenu.ComercioToolStripMenuItem.Enabled = False
            Frmmenu.EmpresaToolStripMenuItem.Enabled = False
            Frmmenu.JogoToolStripMenuItem.Enabled = False
            Frmmenu.MusicaToolStripMenuItem.Enabled = False
            Frmmenu.SeriadoToolStripMenuItem.Enabled = False
            Frmmenu.SiteToolStripMenuItem.Enabled = False
            Frmmenu.BackupToolStripMenuItem.Enabled = False
            Frmmenu.SairToolStripMenuItem.Enabled = False
        Else
            Frmmenu.AcessoToolStripMenuItem.Enabled = False
            Frmmenu.AcademiaToolStripMenuItem.Enabled = False
            Frmmenu.AmigosToolStripMenuItem.Enabled = False
            Frmmenu.AplicativosToolStripMenuItem.Enabled = False
            Frmmenu.ComercioToolStripMenuItem.Enabled = False
            Frmmenu.EmpresaToolStripMenuItem.Enabled = False
            Frmmenu.JogoToolStripMenuItem.Enabled = False
            Frmmenu.MusicaToolStripMenuItem.Enabled = False
            Frmmenu.SeriadoToolStripMenuItem.Enabled = False
            Frmmenu.SiteToolStripMenuItem.Enabled = False
            Frmmenu.BackupToolStripMenuItem.Enabled = False
            Frmmenu.SairToolStripMenuItem.Enabled = False
        End If
        Return True
    End Function
    Public Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
End Module
