

Public Class menuutama
    'Try
    '  Private compid As String = 
    'Catch : End Try
    '    Private compid As String = ""

    Public logid As Integer
    Public logcode As String
    Public logname As String
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If Control.ModifierKeys = Keys.Alt AndAlso (msg.WParam.ToInt32 = Convert.ToInt32(Keys.F10)) Then
            cekform(uploaddata, "NEW", Me)
            '     navprogram.Show()
        ElseIf Control.ModifierKeys = Keys.Alt AndAlso (msg.WParam.ToInt32 = Convert.ToInt32(Keys.F9)) Then

        ElseIf Control.ModifierKeys = Keys.Alt AndAlso (msg.WParam.ToInt32 = Convert.ToInt32(Keys.F8)) Then

        ElseIf Control.ModifierKeys = Keys.Alt AndAlso (msg.WParam.ToInt32 = Convert.ToInt32(Keys.F6)) Then

        ElseIf Control.ModifierKeys = Keys.Alt AndAlso (msg.WParam.ToInt32 = Convert.ToInt32(Keys.F7)) Then
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    'Private Shared Sub Main()
    '    Dim cultureInfo As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("en-US")
    '    Application.CurrentCulture = cultureInfo
    '    Application.EnableVisualStyles()
    '    'Application.SetCompatibleTextRenderingDefault(False)
    '    Application.Run(New tso())

    'End Sub
    Private Sub menuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dateInfo = Globalization.CultureInfo.CurrentCulture.DateTimeFormat()
        Dim sepDecimal = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        'Panel1.Visible = False
        ' Main()
        Application.CurrentCulture = New Globalization.CultureInfo("EN-US")
        'If dateInfo.ShortDatePattern <> "dd/MM/yyyy" Or sepDecimal <> "." Then
        '    MsgBox("Format Tanggal harus : 'dd/MM/yyyy' " & vbNewLine & _
        '           "Format Separator Decimal harus : '.'" & vbNewLine & _
        '           "Format Separator Pemisah Ribuan harus : ','", _
        '           MsgBoxStyle.Exclamation, "Format Data di Komputer Salah")
        '    Call Shell("rundll32.exe shell32.dll,Control_RunDLL intl.cpl,,4", vbNormalFocus)
        '    Me.Dispose()
        '    Exit Sub
        'End If

        If System.IO.File.Exists(cl.dirSettingAppF) = False Then
            muvisfalse()
            cekform(sysconfig, "NEW", Me)
        Else
            cekform(login, "NEW", Me)

            'login.txtusr.Text = "admin"
            'login.txtpass.Text = "admin"
            'login.btnlogin.PerformClick()


            'masapjk = "March"
            'thnpjk = "2022"

            'cekform(tcsv42, "NEW", Me)

        End If

    End Sub

    Public Sub muvisfalse()
        Me.MenuStrip.Visible = False

        Me.filetsmi.Visible = False
        Me.datatsmi.Visible = False
        '  Me.historytsmi.Visible = False
        Me.helptsmi.Visible = False

        '------------------------------------------
        Me.loginmi.Visible = False
        Me.logoutmi.Visible = False
        '------------------------------------------ MASTER DATA
        'Me.barangmi.Visible = False
        '------------------------------------------

        '------------------------------------------ TRANSACTIONS

        '------------------------------------------ REPORTS

        '------------------------------------------ SETTING
        Me.databaseconfigmi.Visible = False
        '   Me.companysettingsmi.Visible = False
        Me.changepasswordmi.Visible = False
        Me.usermi.Visible = False
        Me.userprivilagemi.Visible = False
        ''Me.backdbmi.Visible = False
        'Me.uploaddatami.Visible = False
        ' Me.resettransmi.Visible = False
        '------------------------------------------
        'Me.userlogmi.Visible = False
        'Me.datalogmi.Visible = False
        'Me.translogmi.Visible = False
        '------------------------------------------
    End Sub

    Public Sub muvistrue(ByVal idusr As Integer)

        Me.MenuStrip.Visible = True


        Dim dtall As DataTable = cl.table(
            "Select T1.code_capp, T1.name_capp, T2.apptp 'tp'  FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp = T2.id " &
            " WHERE T1.id_cusr = '" & idusr & "' AND T1.canopen = 'Y' ")

        For i As Integer = 0 To dtall.Rows.Count - 1
            With dtall.Rows(i)

                If .Item("tp") = "M" Then : Me.datatsmi.Visible = True
                    'ElseIf .Item("tp") = "R" Then : Me.laporanmi.Visible = True
                ElseIf .Item("tp") = "C" Then : Me.configtsmi.Visible = True
                ElseIf .Item("tp") = "H" Then : Me.historytsmi.Visible = True
                End If


                If .Item("code_capp") = "mitem" Then : Me.barangmi.Visible = True

                ElseIf .Item("code_capp") = "dbconf" Then : Me.databaseconfigmi.Visible = True
                    ' ElseIf .Item("code_capp") = "companysetting" Then : Me.companysettingsmi.Visible = True
                ElseIf .Item("code_capp") = "changepass" Then : Me.changepasswordmi.Visible = True
                ElseIf .Item("code_capp") = "usr" Then : Me.usermi.Visible = True
                ElseIf .Item("code_capp") = "usrpriv" Then : Me.userprivilagemi.Visible = True
                    ' ElseIf .Item("code_capp") = "backupdb" Then : Me.backdbmi.Visible = True
                    '  ElseIf .Item("code_capp") = "uploaddata" Then : Me.uploaddatami.Visible = True
                    ' ElseIf .Item("code_capp") = "resettrans" Then : Me.resettransmi.Visible = True

                ElseIf .Item("code_capp") = "userlog" Then : Me.userlogmi.Visible = True
                    ElseIf .Item("code_capp") = "datalog" Then : Me.datalogmi.Visible = True
                    ' ElseIf .Item("code_capp") = "translog" Then : Me.translogmi.Visible = True

                End If
            End With
        Next

        Me.filetsmi.Visible = True
        Me.logoutmi.Visible = True

        Me.helptsmi.Visible = True
        Me.aboutusmi.Visible = True
    End Sub

    Private Sub loginmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginmi.Click
        cekform(login, "NEW", Me)
    End Sub

    Private Sub logoutmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logoutmi.Click
        For Each child As Form In Me.MdiChildren
            child.Close()
        Next child

        Dim actlog As String
        'Dim llogid As Integer
        'Dim llogcode As String
        'Dim llogname As Integer

        'logid = cl.readData(" SELECT id FROM cusr " &
        '    " WHERE name = '" & logid & "'  AND stat = 1")
        'logcode = cl.readData(" SELECT code FROM cusr " &
        '    " WHERE name = '" & logcode & "'  AND stat = 1")
        'logname = cl.readData(" SELECT name FROM cusr " &
        '    " WHERE id = '" & logname & "'  AND stat = 1")
        actlog = "Logout"

        cl.openTrans()
        cl.execCmdTrans("INSERT into huserlog (id_cusr, code_cusr, name_cusr, act, usin) VALUES " &
                            " ('" & logid & "','" & logcode & "','" & logname & "','" & actlog & "','" & idusr & "')")

        cl.execCmdTrans("UPDATE msetmasa SET statpjk = 'O' WHERE stat = 1")

        cl.closeTrans(logoutmi)
        'cl.openTrans()
        'cl.execCmdTrans(
        '    "EXEC shuserlog " &
        '    " '" & idusr & "'" &
        '    " , 'LOGOUT'" &
        '    " , ''" &
        '    " , '" & idusr & "'" &
        '    " ")
        'cl.closeTrans(MenuStrip)

        cekform(login, "NEW", Me)
    End Sub
    Private Sub exitmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitmi.Click
        Dim tny As Integer = cl.msgYesNo("Keluar dari aplikasi SWIFECT TAX ALL IN ONE SOLUTION ?", "Confirmation")
        If tny = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub userprivilagemi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userprivilagemi.Click
        cekform(usrpriv, "NEW", Me)
    End Sub

    Private Sub usermi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usermi.Click
        cekform(usr, "NEW", Me)
    End Sub
    Private Sub dbconfigmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles databaseconfigmi.Click
        '  cekform(dbconfig, "NEW", Me)
    End Sub

    Private Sub changepassmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepasswordmi.Click
        cekform(changepass, "NEW", Me)
    End Sub

    Private Sub aboutusmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutusmi.Click
        cekform(aboutus, "NEW", Me)
    End Sub

    Private Sub barangmi_Click(sender As System.Object, e As System.EventArgs) Handles barangmi.Click
        'cekform(mitem, "NEW", Me)
    End Sub


    Private Sub CompanySettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        cekform(csetting, "NEW", Me)
    End Sub


    Private Sub backdbmi_Click(sender As System.Object, e As System.EventArgs)
        'SaveFileDialog1.FileName = "SWIBC_" & Format(Now(), "yyyyMMdd") & ".bak"
        'SaveFileDialog1.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*"
        'SaveFileDialog1.RestoreDirectory = True
        'Dim res As DialogResult = SaveFileDialog1.ShowDialog()
        'If res = DialogResult.Cancel Then
        '    Exit Sub
        'Else
        '    Dim s As String
        '    s = SaveFileDialog1.FileName
        '    cl.execCommand("BACKUP DATABASE " & database & " TO DISK ='" & s & "'")

        '    cl.msgInform("Success backup database !", "Information")
        'End If
    End Sub

    Private Sub resettransmi_Click(sender As System.Object, e As System.EventArgs)
        'Dim tny As Integer
        'tny = cl.msgYesNo("Yakin melakukan DELETE TRANSAKSI?" & vbNewLine &
        '               "Backup dulu sebelum delete !" & vbNewLine &
        '               "Data yang terdelete tidak bisa dikembalikan !", "Information")
        'If tny = vbYes Then
        '    With cl
        '        .openTrans()
        '        'GOODS ISSUE
        '        .execCmdTrans("DELETE FROM tgi")
        '        .execCmdTrans("DBCC CHECKIDENT (tgi, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tgid")
        '        .execCmdTrans("DBCC CHECKIDENT (tgid, RESEED, 1)")

        '        'GOODS RECEIPT
        '        .execCmdTrans("DELETE FROM tgr")
        '        .execCmdTrans("DBCC CHECKIDENT (tgr, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tgrd")
        '        .execCmdTrans("DBCC CHECKIDENT (tgrd, RESEED, 1)")

        '        'STOCK OPNAME
        '        .execCmdTrans("DELETE FROM tsopname")
        '        .execCmdTrans("DBCC CHECKIDENT (tsopname, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tsopnamed")
        '        .execCmdTrans("DBCC CHECKIDENT (tsopnamed, RESEED, 1)")

        '        'BC 2.3
        '        .execCmdTrans("DELETE FROM tbc23h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc23h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc23d")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc23d, RESEED, 1)")

        '        'BC 3.0
        '        .execCmdTrans("DELETE FROM tbc30h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc30h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc30d")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc30d, RESEED, 1)")

        '        'BC 2.6.1
        '        .execCmdTrans("DELETE FROM tbc261h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc261h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc261di")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc261di, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc261dd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc261dd, RESEED, 1)")

        '        'BC 2.6.2
        '        .execCmdTrans("DELETE FROM tbc262h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc262h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc262di")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc262di, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc262dd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc262dd, RESEED, 1)")

        '        'BC 2.7 OUT
        '        .execCmdTrans("DELETE FROM tbc27oh")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27oh, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc27odi")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27odi, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc27odd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27odd, RESEED, 1)")

        '        'BC 2.7 IN
        '        .execCmdTrans("DELETE FROM tbc27ih")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27ih, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc27idi")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27idi, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc27idd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc27idd, RESEED, 1)")

        '        'BC 4.0
        '        .execCmdTrans("DELETE FROM tbc40h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc40h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc40di")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc40di, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc40dd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc40dd, RESEED, 1)")

        '        'BC 4.1
        '        .execCmdTrans("DELETE FROM tbc41h")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc41h, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc41di")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc41di, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tbc41dd")
        '        .execCmdTrans("DBCC CHECKIDENT (tbc41dd, RESEED, 1)")

        '        'BC 2.3 (PALAPA)
        '        .execCmdTrans("DELETE FROM tblBC23Dtl")
        '        '    .execCmdTrans("DBCC CHECKIDENT (tblBC23Dtl, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tblBC23Hdr")
        '        '  .execCmdTrans("DBCC CHECKIDENT (tblBC23Hdr, RESEED, 1)")

        '        'BC 2.5 (PALAPA)
        '        .execCmdTrans("DELETE FROM tblBC25Hdr")
        '        '.execCmdTrans("DBCC CHECKIDENT (tblBC25Hdr, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tblBC25Dtl")
        '        ' .execCmdTrans("DBCC CHECKIDENT (tblBC25Dtl, RESEED, 1)")

        '        'BC 3.0 (PALAPA)
        '        .execCmdTrans("DELETE FROM tblBC30Hdr")
        '        ' .execCmdTrans("DBCC CHECKIDENT (tblBC30Hdr, RESEED, 1)")
        '        .execCmdTrans("DELETE FROM tblBC30Dtl")
        '        ' .execCmdTrans("DBCC CHECKIDENT (tblBC30Dtl, RESEED, 1)")

        '        .closeTrans(resettransmi)

        '        If .sCloseTrans = 1 Then
        '            .msgInform("Sukses menghapus transaksi !", "Informasi")
        '        End If

        '    End With
        'End If
    End Sub

    Private Sub uploaddatami_Click(sender As System.Object, e As System.EventArgs)
        cekform(uploaddata, "NEW", Me)
    End Sub

    Private Sub userlogmi_Click(sender As System.Object, e As System.EventArgs) Handles userlogmi.Click
        cekform(huserlog, "NEW", Me)
    End Sub

    Private Sub datalogmi_Click(sender As System.Object, e As System.EventArgs) Handles datalogmi.Click
        cekform(hmstr, "NEW", Me)
    End Sub

    Private Sub translogmi_Click(sender As System.Object, e As System.EventArgs)
        '   cekform(htrans, "NEW", Me)
    End Sub


    Private Sub restoredbmi_Click(sender As Object, e As EventArgs)
        ''open.FileName = "KOPRA_" & Format(Now(), "yyyyMMdd") & ".bak"
        'OpenFileDialog1.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*"
        'OpenFileDialog1.RestoreDirectory = True
        'Dim res As DialogResult = OpenFileDialog1.ShowDialog()
        'If res = DialogResult.Cancel Then
        '    Exit Sub
        'Else


        '    Dim s As String
        '    s = OpenFileDialog1.FileName
        '    cl.execCommand(" USE [master] " &
        '                " ALTER DATABASE SWIBC set SINGLE_USER WITH ROLLBACK IMMEDIATE " &
        '                    "RESTORE DATABASE " & database & " FROM DISK ='" & s & "' WITH REPLACE")

        '    'Timer1.Enabled = True
        '    'ToolStripProgressBar1.Visible = True

        '    cl.execCommand("ALTER DATABASE SWIBC SET MULTI_USER")

        '    cl.msgInform("Sukses restore database !" & vbNewLine & "Sistem akan melakukan restart", "Information")

        '    For Each child As Form In Me.MdiChildren
        '        child.Close()
        '    Next child

        '    cl.openTrans()
        '    cl.execCmdTrans(
        '        "EXEC shuserlog " &
        '        " '" & idusr & "'" &
        '        " , 'LOGOUT'" &
        '        " , ''" &
        '        " , '" & idusr & "'" &
        '        " ")
        '    cl.closeTrans(MenuStrip)

        '    cekform(login, "NEW", Me)
        '  End If
    End Sub


    Private Sub cprinterconfigmi_Click(sender As Object, e As EventArgs)
        cekform(cprinterconfig, "NEW", Me)
    End Sub


    Private Sub historytsmi_Click(sender As Object, e As EventArgs) Handles historytsmi.Click

    End Sub

    Private Sub mnegarami_Click(sender As Object, e As EventArgs) Handles mnegarami.Click
        cekform(mngara, "NEW", Me)
    End Sub

    Private Sub mkppmi_Click(sender As Object, e As EventArgs) Handles mkppmi.Click
        cekform(mkpp, "NEW", Me)
    End Sub

    Private Sub mobjkpjkmi_Click(sender As Object, e As EventArgs) Handles mobjkpjkmi.Click
        cekform(mobjkpjk, "NEW", Me)
    End Sub

    Private Sub msspmi_Click(sender As Object, e As EventArgs) Handles msspmi.Click
        cekform(mssp, "NEW", Me)
    End Sub
    Private Sub mpenghasilmi_Click(sender As Object, e As EventArgs) Handles mpenghasilmi.Click
        cekform(mpenghasil, "NEW", Me)
    End Sub

    Private Sub mpenghasila1_Click(sender As Object, e As EventArgs) Handles mpenghasila1mi.Click
        cekform(mpenghasila1, "NEW", Me)
    End Sub

    Private Sub mpenghasila2_Click(sender As Object, e As EventArgs) Handles mpenghasila2mi.Click
        cekform(mpenghasila2, "NEW", Me)
    End Sub

    Private Sub PTKPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PTKPToolStripMenuItem.Click
        cekform(mptkp, "NEW", Me)
    End Sub

    Private Sub Pasal17BerlapisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mpasal17mi.Click
        cekform(mpasal17, "NEW", Me)
    End Sub

    Private Sub mpasal21mi_Click(sender As Object, e As EventArgs) Handles mpasal21mi.Click

    End Sub

    Private Sub mpesangonmi_Click(sender As Object, e As EventArgs) Handles mpesangonmi.Click
        cekform(mpasal21, "NEW", Me)
    End Sub

    Private Sub mpensiunmi_Click(sender As Object, e As EventArgs) Handles mpensiunmi.Click
        cekform(mpensiun, "NEW", Me)
    End Sub

    Private Sub mimbalanpns_Click(sender As Object, e As EventArgs) Handles mimbalanpnsmi.Click
        cekform(mimbalanpns, "NEW", Me)
    End Sub

    Private Sub mbyjbtn_Click(sender As Object, e As EventArgs) Handles mbyjbtnmi.Click
        cekform(mbyjbtn, "NEW", Me)
    End Sub

    Private Sub mupahharianmi_Click(sender As Object, e As EventArgs) Handles mupahharianmi.Click
        cekform(mupahharian, "NEW", Me)
    End Sub

    Private Sub msetmasami_Click(sender As Object, e As EventArgs) Handles msetmasami.Click
        cekform(msetmasa, "NEW", Me)
    End Sub

    Private Sub tpph21mi_Click(sender As Object, e As EventArgs) Handles tpph21mi.Click
        'cekform(tpph21, "NEW", Me)
    End Sub

    Private Sub tbuktiptgfinalmi_Click(sender As Object, e As EventArgs) Handles tbuktiptgfinalmi.Click
        cekform(tbuktiptgfinal, "NEW", Me)
    End Sub

    Private Sub tbuktiptgtdkfinalmi_Click(sender As Object, e As EventArgs) Handles tbuktiptgtdkfinalmi.Click
        cekform(tbuktiptgtdkfinal, "NEW", Me)
    End Sub

    Private Sub tpph23mi_Click(sender As Object, e As EventArgs) Handles tpph23mi.Click
        'cekform(tpph23, "NEW", Me)
    End Sub

    Private Sub tpph42mi_Click(sender As Object, e As EventArgs) Handles tpph42mi.Click
        'cekform(tpph42, "NEW", Me)
    End Sub

    Private Sub PPhPasal42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PPhPasal42ToolStripMenuItem.Click
        cekform(mpasal42, "NEW", Me)
    End Sub

    Private Sub DaftarBiayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBiayaToolStripMenuItem.Click
        cekform(tdaftarbiaya, "NEW", Me)
    End Sub
    Private Sub InputDataPemotongToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cekform(tinputdatapemotongpjk, "NEW", Me)
    End Sub

    Private Sub InputSSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPToolStripMenuItem.Click
        cekform(tinputssppbk21, "NEW", Me)
    End Sub

    Private Sub InputSSPPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPPPh23ToolStripMenuItem.Click
        cekform(tinputssppbk23, "NEW", Me)
    End Sub

    Private Sub InputSSPPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPPPh42ToolStripMenuItem.Click
        cekform(tinputssppbk42, "NEW", Me)
    End Sub

    Private Sub SatuMasaPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuMasaPajakToolStripMenuItem.Click
        cekform(tdaftarpemotongpjkbulan, "NEW", Me)
    End Sub

    Private Sub SatuTahunPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuTahunPajakToolStripMenuItem.Click
        cekform(tdaftarpemotongpjktahun, "NEW", Me)
    End Sub

    Private Sub SPTIndukPPhPsl42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTIndukPPhPsl42ToolStripMenuItem.Click
        cekform(tsptmasapphfinal42, "NEW", Me)
    End Sub

    Private Sub SPTInduk1721ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTInduk1721ToolStripMenuItem.Click
        cekform(tsptmasa21induk, "NEW", Me)
    End Sub

    Private Sub BuktiPotongPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuktiPotongPPh23ToolStripMenuItem.Click
        cekform(tpph23, "NEW", Me)
    End Sub

    Private Sub BuktiPotongPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuktiPotongPPh42ToolStripMenuItem.Click
        cekform(tpph42, "NEW", Me)
    End Sub

    Private Sub InputBuktiPemindahbukuanPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cekform(tbktbuku42, "NEW", Me)
    End Sub

    Private Sub SPTIndukPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTIndukPPh23ToolStripMenuItem.Click
        cekform(tsptmasa23, "NEW", Me)
    End Sub

    Private Sub menuutama_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        With cl
            .openTrans()
            .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' WHERE stat = 1")
            .closeTrans(tpph23mi)
        End With
    End Sub

    Private Sub mprofilemi_Click_1(sender As Object, e As EventArgs) Handles mprofilemi.Click
        cekform(mprofile, "NEW", Me)
    End Sub

    Private Sub A1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A1ToolStripMenuItem.Click
        cekform(ta1, "NEW", Me)
    End Sub

    Private Sub DaftarBungaPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBungaPPh42ToolStripMenuItem.Click
        cekform(tdaftarpph42bunga, "NEW", Me)
    End Sub

    Private Sub ExportCSVPPh21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh21ToolStripMenuItem.Click
        cekform(tcsv21, "NEW", Me)
    End Sub

    Private Sub ExportCSVPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh23ToolStripMenuItem.Click
        cekform(tcsv23, "NEW", Me)
    End Sub

    Private Sub ExportCSVPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh42ToolStripMenuItem.Click
        cekform(tcsv42, "NEW", Me)
    End Sub

    Private Sub UploadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadDataToolStripMenuItem.Click
        cekform(uploaddata, "NEW", Me)
    End Sub

    Private Sub TarifPasal23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifPasal23ToolStripMenuItem.Click
        cekform(mpasal23, "NEW", Me)
    End Sub

    Private Sub MenuBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuBaruToolStripMenuItem.Click
        cekform(menubaru, "NEW", Me)
    End Sub

    Private Sub menuutama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        With cl
            .openTrans()
            .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' WHERE stat = 1")
            .closeTrans(tpph23mi)
        End With
    End Sub

    Private Sub menuutama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        With cl
            .openTrans()
            .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' WHERE stat = 1")
            .closeTrans(tpph23mi)
        End With
    End Sub
End Class
