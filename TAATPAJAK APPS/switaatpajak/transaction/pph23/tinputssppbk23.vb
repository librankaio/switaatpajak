Public Class tinputssppbk23
    Dim idmaster As Integer = 0, statform As String = ""

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
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F3) Then
            btnlist.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
            If idmaster <> 0 And btnsave.Text <> "Save" Then : btndelete.PerformClick() : End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            'gencode()
            loadcmb()
            btndelete.Visible = False

        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True

        End If
        Me.Select() : txtnttpn.Select()
    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnttpn.Select()
    End Sub
    Private Sub selctind()
        If (cmbkdpjk.SelectedIndex) Then
            cmbjenissetor.Enabled = True
            cmbjenissetor.SelectedIndex = 0
        Else
            cmbjenissetor.Enabled = False
        End If
    End Sub
    Private Sub loadcmb()
        Dim dtemptp As DataTable = cl.table(
            "SELECT id AS 'value', kode AS 'display' FROM mobjkpjk WHERE stat = 1 AND jnspjk='PPh 23'")
        '"SELECT kode AS 'value', concat(kode,' - ', objkpjk) AS 'display' " &
        '" FROM mobjkpjk WHERE stat = 1 AND jnspjk = 'PPh 23'")

        Dim row As DataRow = dtemptp.NewRow()
        row(0) = 0
        row(1) = "---- PILIH DATA ----"
        dtemptp.Rows.InsertAt(row, 0)

        cmbkdpjk.DataSource = dtemptp
        cmbkdpjk.ValueMember = "value"
        cmbkdpjk.DisplayMember = "display"

        'Dim dtemptp2 As DataTable = cl.table(
        '  "SELECT kode AS 'value', concat(kode,' - ', deskripsi) AS 'display' " &
        '  " FROM mssp WHERE stat = 1 AND jenis = 'PPh 23'")

        'cmbjenissetor.DataSource = dtemptp2
        'cmbjenissetor.ValueMember = "value"
        'cmbjenissetor.DisplayMember = "display"

        'End If
    End Sub
    Private Sub cmbval()
        Dim dtemptp2 As DataTable = cl.table(
         "SELECT jenis AS 'value', concat(jenis,' - ', deskripsi) AS 'display' " &
         " FROM mssp WHERE stat = 1 AND kode = '" & cmbkdpjk.Text & "'")

        cmbjenissetor.DataSource = dtemptp2
        cmbjenissetor.ValueMember = "value"
        cmbjenissetor.DisplayMember = "display"
    End Sub
    Private Sub clearData()
        cmbkdpjk.Text = ""
        cmbjenissetor.Text = ""
        dttglssp.Text = ""
        txtnttpn.Text = ""
        txtpph.Text = ""
        cmbket.Text = ""

        ' cmbkdpjk.SelectedIndex = 0
        cmbjenissetor.Enabled = False
        cmbjenissetor.SelectedIndex = 0
        cmbket.SelectedIndex = 0
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnttpn, "NTTPN Tidak Boleh Kosong!", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If txtnttpn.Text.Length < 16 Then
                .msgError("Angka NTTPN tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputssppbk23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                '----- Validation for obj payment
                'Validasi untuk pembayaran lunas
                Dim tottagihan As Decimal
                tottagihan = cl.cNum(cl.cNum(cl.readData("SELECT ifnull(sum(pphdipotong),0) FROM tpph23  where masapjk ='" & masapjk & "' AND thnpjk ='" & thnpjk & "' AND stat = 1 AND kodeobj = '" & cmbkdpjk.Text & "'")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk23  where masapjk ='" & masapjk & "' AND thnpjk ='" & thnpjk & "' AND stat = 1 AND kdpjk = '" & cmbkdpjk.Text & "'")))
                Dim totterbayar As Decimal
                totterbayar = cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk23 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '" & cmbkdpjk.Text & "'"))

                If totterbayar = tottagihan Then
                    cl.msgInform("Pembayaran anda sudah lunas!", "Informasi")
                    Exit Sub
                ElseIf cl.cNum(txtpph.Text) > tottagihan Then
                    cl.msgError("Pembayaran anda melebihi tagihan pada jenis setoran pajak!", "Peringatan")
                    Exit Sub
                End If

                'Dim totbyr As Decimal
                'totbyr = cl.readData("SELECT sum(pph) FROM tinputssppbk23 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk='" & thnpjk & "'")
                'Dim totpph As Decimal
                'totpph = cl.readData("SELECT sum(pphdipotong) FROM tpph23 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk='" & thnpjk & "'")
                'MsgBox(totpph)
                'If cl.cNum(txtpph.Text) = cl.cNum(totpph - totbyr) Then
                '    menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = True
                'ElseIf cl.cNum(txtpph.Text) >= cl.cNum(totpph - totbyr)
                '    cl.msgInform("Pembayaran Anda Melebihi Jumlah tagihan", "Informasi")
                '    Exit Sub
                'ElseIf cl.cNum(txtpph.Text) <= cl.cNum(totpph - totbyr)
                '    menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = False
                '    cl.msgInform("Sisa Tagihan anda adalah = Rp." & cl.cNum((totpph - totbyr) - cl.cNum(txtpph.Text)), "Informasi")
                'ElseIf cl.cNum(totpph) = 0
                '    menuutama.ExportCSVPPh42ToolStripMenuItem.Enabled = True
                'End If


                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnttpn.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stinputssppbk23 (" &
                        " '" & .cChr(cmbkdpjk.Text) & "'" &
                        " , '" & .cChr(cmbjenissetor.Text) & "'" &
                        " , '" & .cChr(dttglssp.Text) & "'" &
                        " , '" & .cChr(txtnttpn.Text) & "'" &
                        " , '" & .cNum(txtpph.Text) & "'" &
                        " , '" & .cChr(cmbket.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txtnttpn.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputssppbk23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'

                Dim totpph As Decimal
                totpph = cl.readData("SELECT pphjml FROM tsptmasa23 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk='" & thnpjk & "'")
                MsgBox(totpph)
                If cl.cNum(txtpph.Text) = cl.cNum(totpph) Then
                    menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = True
                ElseIf cl.cNum(txtpph.Text) > cl.cNum(totpph)
                    cl.msgInform("Pembayaran Anda Melebihi Jumlah tagihan", "Informasi")
                    Exit Sub
                ElseIf cl.cNum(txtpph.Text) < cl.cNum(totpph)
                    menuutama.ExportCSVPPh23ToolStripMenuItem.Enabled = False
                End If

                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnttpn.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stinputssppbk23 (" &
                        " '" & .cChr(cmbkdpjk.Text) & "'" &
                        " , '" & .cChr(cmbjenissetor.Text) & "'" &
                        " , '" & .cChr(dttglssp.Text) & "'" &
                        " , '" & .cChr(txtnttpn.Text) & "'" &
                        " , '" & .cNum(txtpph.Text) & "'" &
                        " , '" & .cChr(cmbket.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnttpn.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tinputssppbk23 TA WHERE TA.stat = 1 AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("kdpjk").Visible = True : .Columns("kdpjk").HeaderText = "Kode Pajak"
            .Columns("jenissetor").Visible = True : .Columns("jenissetor").HeaderText = "Jenis Setor"
            .Columns("tglssp").Visible = True : .Columns("tglssp").HeaderText = "Tanggal SSP"
            .Columns("nttpn").Visible = True : .Columns("nttpn").HeaderText = "NTTPN"
            .Columns("pph").Visible = True : .Columns("pph").HeaderText = "PPh"
            .Columns("ket").Visible = True : .Columns("ket").HeaderText = "Keterangan"

        End With
        a.loadStatusTempForm(Me, Me.txtnttpn, "[tinputssppbk23]tinputssppbk23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tinputssppbk21
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputssppbk23'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnttpn.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stinputssppbk23 (" &
                        " '" & .cChr(cmbkdpjk.Text) & "'" &
                        " , '" & .cChr(cmbjenissetor.Text) & "'" &
                        " , '" & .cChr(dttglssp.Text) & "'" &
                        " , '" & .cChr(txtnttpn.Text) & "'" &
                        " , '" & .cNum(txtpph.Text) & "'" &
                        " , '" & .cChr(cmbket.Text) & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnttpn.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub cmbkdpjk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkdpjk.SelectedIndexChanged
        selctind()
        'cmbval()
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
End Class