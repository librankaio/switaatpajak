Imports System.IO
Public Class msetmasa
    Dim idmaster As Integer = 0, statform As String = ""
    Dim yearnow As Integer
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
        ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            btncancel.PerformClick()
            '-----------------------------------------------------------------------
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then
            If btnsave.Text = "Save" Or (idmaster <> 0 And btnsave.Text = "Update") Then
                btnsave.PerformClick()
            End If
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F2) Then
            btnrefresh.PerformClick()
            'ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F3) Then
            '    btnlist.PerformClick()
            'ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
            '    If idmaster <> 0 And btnsave.Text <> "Save" Then : btndelete.PerformClick() : End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub

    Private Sub loaddata()
        ' cmbjnspjk.Text = cl.readData("SELECT jnspjk FROM msetmasa")
        ' cmbmasapjk.Text = cl.readData("SELECT masapjk FROM msetmasa")
        'nudtahunpjk.Text = cl.readData("SELECT tahunpjk FROM msetmasa")
        ' txtpembetulan.Text = cl.readData("SELECT pembetulan FROM msetmasa")
    End Sub

    Private Sub clearData()
        ' cmbjnspjk.Text = 0
        '  cmbmasapjk.Text = 0
        ' nudtahunpjk.Text = 0
        '    txtpembetulan.Text = 0
        'cmbstatus.Text = "OPEN"
        ' cmbjnspjk.SelectedIndex = 0
        If Month(Now()) = 1 Then
            cmbmasapjk.SelectedIndex = 0
        ElseIf Month(Now()) = 2 Then
            cmbmasapjk.SelectedIndex = 1
        ElseIf Month(Now()) = 3 Then
            cmbmasapjk.SelectedIndex = 2
        ElseIf Month(Now()) = 4 Then
            cmbmasapjk.SelectedIndex = 3
        ElseIf Month(Now()) = 5 Then
            cmbmasapjk.SelectedIndex = 4
        ElseIf Month(Now()) = 6 Then
            cmbmasapjk.SelectedIndex = 5
        ElseIf Month(Now()) = 7 Then
            cmbmasapjk.SelectedIndex = 6
        ElseIf Month(Now()) = 8 Then
            cmbmasapjk.SelectedIndex = 7
        ElseIf Month(Now()) = 9 Then
            cmbmasapjk.SelectedIndex = 8
        ElseIf Month(Now()) = 10 Then
            cmbmasapjk.SelectedIndex = 9
        ElseIf Month(Now()) = 11 Then
            cmbmasapjk.SelectedIndex = 10
        ElseIf Month(Now()) = 12 Then
            cmbmasapjk.SelectedIndex = 11
        End If
        lblstatus.Text = "Masa Pajak Aktif : " & cl.readData("SELECT masapjk FROM msetmasa WHERE statpjk = 'A' and stat = 1")
        nudtahunpjk.Text = Year(Now)

    End Sub
    Private Sub loadstat()
        If cmbstatus.Text = "BUAT SPT PEMBETULAN" Then
            If cl.readData("SELECT COUNT(id) FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = 0 Then
                cl.msgError("Periode belom di buat sebelumnya !", "Informasi")
                cmbstatus.SelectedValue = "O"
                txtpembetulan.Text = 0
                Exit Sub
            Else
                Dim status As Integer
                status = cl.readData("SELECT IFNULL(pembetulan,0) from msetmasa WHERE  thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1 ORDER BY id DESC LIMIT 1")
                txtpembetulan.Text = status + 1
            End If
        End If
    End Sub


    Private Sub loadcmb()
        Dim dtemptp4 As DataTable = cl.table(
            "SELECT 'O' AS 'value', 'BUAT SPT' AS 'display' UNION ALL " &
            " SELECT 'A' AS 'value', 'BUKA KEMBALI SPT' AS 'display' UNION ALL" &
            " SELECT 'C' AS 'value', 'BUAT SPT PEMBETULAN' AS 'display' ")

        cmbstatus.DataSource = dtemptp4
        cmbstatus.ValueMember = "value"
        cmbstatus.DisplayMember = "display"

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            cmbmasapjk.Enabled = True
            nudtahunpjk.Enabled = True
            loadcmb()
        ElseIf tstatform = "upd" Then
            btnsave.Text = "Aktif"
            cmbmasapjk.Enabled = False
            nudtahunpjk.Enabled = False
        End If
        Me.Select() : cmbmasapjk.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : cmbmasapjk.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtpembetulan, "Pembetulan Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            yearnow = Year(Now)

            If yearnow < nudtahunpjk.Value Then
                .msgError("Anda tidak bisa mengambil tahun selanjutnya", "PERINGATAN")
                Exit Sub
            End If


            'If btnsave.Text = "Save" Then
            '----------USER AUTHORIZATION CHECK--------------'


            If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'msetmasa'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
            '---------------------END------------------------'

            '-- validasi --

            ' -- GW SENGAJA PAKE BAHASA INGGRIS UNTUK KASIH COMMENTNYA 
            ' -- KALO LO GAK SENENG, ADA 3 OPSI : BELI KAMUS ENGLISH --> INDO, PAKAI GOOGLE TRANSLATE ATAU KURSUS BHS INGGRIS
            ' -- BIASAIN COMMENT, BIAR PAHAM MAKSUD CODING NYA APA
            ' -- 8=============D \|/
            ' -- Masalahnya bukan bahasa Inggris, kemaren bahasa jerman. saya kira abis copas di stack overflow pake bahasa jerman

            Dim tny As Integer
            tny = .msgYesNo("Simpan data : " & cmbmasapjk.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                If cmbstatus.Text = "BUAT SPT" Then
                    '-- CHECK WHETHER THE PERIOD CHOSEN EXISTS
                    If cl.readData("SELECT COUNT(id) FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = 0 Then
                        .openTrans()
                        .execCmdTrans(
                            "INSERT msetmasa (masapjk, mthpjk, thnpjk, pembetulan, statpjk) VALUES " &
                            "  ('" & .cChr(cmbmasapjk.Text) & "'" &
                            " ,'" & .cNum(cmbmasapjk.SelectedIndex) + 1 & "'" &
                            " ,'" & .cNum(nudtahunpjk.Value) & "'" &
                            " ,'" & .cNum(txtpembetulan.Text) & "'" &
                            " ,'" & .cChr(cmbstatus.SelectedValue) & "')")
                        .closeTrans(btnsave)
                        If .sCloseTrans = 1 Then
                            .msgInform("Berhasil Update : " & cmbmasapjk.Text & " !", "Informasi")
                        End If
                    Else
                        ' -- IF EXISTS THEN DISPLAY ERROR MESSAGE
                        .msgError("Periode sudah di buat sebelumnya !", "Informasi")
                        Exit Sub
                    End If

                ElseIf cmbstatus.Text = "BUKA KEMBALI SPT" Then
                    ' -- REOPEN, PREVIOUSLY CREATED PERIOD

                    '-- VALIDATE TO CHECK IF THE USER WANTS TO REOPEN THE PERIOD THAT ITS BEEN CREATED IN THE SYSTEM
                    If cl.readData("SELECT COUNT(id) FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = 0 Then
                        .msgError("Periode belom di buat sebelumnya !", "Informasi")
                        Exit Sub
                    End If

                    .openTrans()
                    '-- QUERY TO MAKE SURE ALL OTHER PERIODS ARE SET TO OPEN (ONLY ONE PERIOD CAN BE ACTIVE DURING ONE SESSION)
                    .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' where  stat = 1")
                    '-- QUERY TO REOPEN THEN PERIOD
                    .execCmdTrans(
                               "UPDATE msetmasa SET " &
                               " statpjk = '" & .cChr(cmbstatus.SelectedValue) & "' WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and pembetulan = '" & txtpembetulan.Text & "'")



                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Buka Kembali SPT : " & cmbmasapjk.Text & " !", "Informasi")

                        '-- DISPOSE THE FORM AND ACTIVATE ALL THE MENUS IN THE TRANSACTION
                        masapjknum = cmbmasapjk.SelectedIndex + 1
                        If masapjknum >= 10 Then
                            masapajakstr = masapjknum.ToString
                        ElseIf masapjknum <= 10
                            masapajakstr = String.Concat("0", "", cl.cChr(masapjknum.ToString))
                            masapjknum = cl.cNum(masapajakstr)
                        End If

                        masapjk = cmbmasapjk.Text
                        mthpjk = cmbmasapjk.SelectedIndex + 1
                        thnpjk = nudtahunpjk.Value
                        pembetulan = txtpembetulan.Text


                        menuutama.tpph21mi.Enabled = True
                        menuutama.tpph23mi.Enabled = True
                        menuutama.tpph42mi.Enabled = True

                        menuutama.ExportCSVPPh21ToolStripMenuItem.Enabled = True
                        menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = True
                        menuutama.ExportCSVPPh42ToolStripMenuItem.Enabled = True

                        menuutama.tsStatus2.Text = " | MASA PAJAK AKTIF :  " & cmbmasapjk.Text & " " & nudtahunpjk.Value

                        changestatform("new")
                        Me.Dispose()
                    End If

                ElseIf cmbstatus.Text = "BUAT SPT PEMBETULAN" Then

                    .openTrans()
                    .execCmdTrans(
                            "INSERT msetmasa (masapjk, mthpjk, thnpjk, pembetulan, statpjk) VALUES " &
                            "  ('" & .cChr(cmbmasapjk.Text) & "'" &
                            " ,'" & .cNum(cmbmasapjk.SelectedIndex) + 1 & "'" &
                            " ,'" & .cNum(nudtahunpjk.Value) & "'" &
                            " ,'" & .cNum(txtpembetulan.Text) & "'" &
                            " ,'" & .cChr(cmbstatus.SelectedValue) & "')")

                    .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' where  thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "'")
                    ' -- 
                    .execCmdTrans("UPDATE msetmasa SET statpjk = 'A' where pembetulan = '" & txtpembetulan.Text & "' and thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "'")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & cmbmasapjk.Text & " !", "Informasi")

                        masapjk = cmbmasapjk.Text
                        mthpjk = cmbmasapjk.SelectedIndex + 1
                        thnpjk = nudtahunpjk.Value

                        menuutama.tpph21mi.Enabled = True
                        menuutama.tpph23mi.Enabled = True
                        menuutama.tpph42mi.Enabled = True
                        menuutama.tsStatus2.Text = " | MASA PAJAK AKTIF : " & cmbmasapjk.Text & " " & nudtahunpjk.Value

                        menuutama.ExportCSVPPh21ToolStripMenuItem.Enabled = True
                        menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = True
                        menuutama.ExportCSVPPh42ToolStripMenuItem.Enabled = True

                        changestatform("new") : Me.Dispose() : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New msetmasa
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub nudtahunpjk_ValueChanged(sender As Object, e As EventArgs) Handles nudtahunpjk.ValueChanged
        If cl.readData("SELECT COUNT(id) FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") >= 1 Then
            If cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "O" Then
                cmbstatus.SelectedValue = "O"
            ElseIf cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "A" Then
                cmbstatus.SelectedValue = "A"
            ElseIf cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "C" Then
                cmbstatus.SelectedValue = "C"
            End If
        End If
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM msetmasa TA WHERE TA.stat = 1 AND thnpjk = '" & nudtahunpjk.Value & "'"

        With a.dgview : .DataSource = cl.table(sql & " ORDER BY mthpjk ")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("masapjk").Visible = True : .Columns("masapjk").HeaderText = "Masa Pajak"
            .Columns("thnpjk").Visible = True : .Columns("thnpjk").HeaderText = "Tahun Pajak"
            .Columns("pembetulan").Visible = True : .Columns("pembetulan").HeaderText = "Pembetulan"
            .Columns("statpjk").Visible = True : .Columns("statpjk").HeaderText = "Status"
        End With
        a.loadStatusTempForm(Me, Me.txtpembetulan, "[msetmasa]msetmasa")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"
        a.btnsave.Enabled = False
        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub cmbmasapjk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmasapjk.SelectedIndexChanged
        If cl.readData("SELECT COUNT(id) FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") >= 1 Then
            '  MsgBox("test")
            If cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "O" Then
                cmbstatus.SelectedValue = "O"
            ElseIf cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "A" Then
                cmbstatus.SelectedValue = "A"
            ElseIf cl.readData("SELECT statpjk FROM msetmasa WHERE thnpjk = '" & nudtahunpjk.Value & "' and masapjk = '" & cmbmasapjk.Text & "' and stat = 1") = "C" Then
                cmbstatus.SelectedValue = "C"
            End If
        Else
            cmbstatus.Text = "OPEN"
        End If
    End Sub
    Private Sub cmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstatus.SelectedIndexChanged
        loadstat()
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub

End Class