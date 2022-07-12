Imports System.IO
Public Class tpph23
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

    'Private Sub gencode()
    '    txtcode.Text = cl.readData("SELECT dbo.fgetcode('msales','')")
    'End Sub
    Private Sub initdate()
        Dim iDate As String = "01/" & masapjknum & "/" & thnpjk & ""
        Dim odate As DateTime = Convert.ToDateTime(iDate)
        Dim MyDate As Date = odate
        Dim DaysInMonth As Integer = Date.DaysInMonth(MyDate.Year, MyDate.Month)
        Dim LastDayInMonthDate As Date = New Date(MyDate.Year, MyDate.Month, DaysInMonth)

        txttglptg.Text = LastDayInMonthDate
    End Sub
    Private Sub initializedg()
        'deklarasi jumlah datagrid kolom
        dgview.ColumnCount = 4
        dgview.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview
            .Columns(0).Name = "namadok" : .Columns(0).HeaderText = "Nama Dokumen"
            .Columns(1).Name = "nomordok" : .Columns(1).HeaderText = "Nomor Dokumen"
            .Columns(2).Name = "tgl" : .Columns(2).HeaderText = "Tanggal"
            .Columns(3).Name = "aksi" : .Columns(3).HeaderText = "Aksi" : .Columns(3).Visible = False
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("namadok").Width = 100
            .Columns("nomordok").Width = 100
            .Columns("tgl").Width = 300
            .Columns("aksi").Width = 100

            .Columns("nomordok").DefaultCellStyle.Format = "n2"
            .Columns("tgl").DefaultCellStyle.Format = "n2"

            .Columns("namadok").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("nomordok").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("tgl").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("aksi").DefaultCellStyle.BackColor = Color.MistyRose
        End With

    End Sub

    Private Sub clearData()
        '---------Identitas Wajib Pajak---------
        ' MsgBox(cl.readData("SELECT masapjk FROM msetmasa WHERE statpjk = 'A' and stat = 1 LIMIT 1"))
        cmbthnpjk.Text = cl.readData("SELECT thnpjk FROM msetmasa WHERE statpjk = 'A' and stat = 1 LIMIT 1")
        cmbmasapjk.Text = cl.readData("SELECT masapjk FROM msetmasa WHERE statpjk = 'A' and stat = 1 LIMIT 1")

        txtnama.Text = ""
        txtnpwp.Text = ""
        txtalamat.Text = ""
        txtkeldesa.Text = ""
        txtkotakab.Text = ""
        txtkecamatan.Text = ""
        txtkdpos.Text = ""
        txtprov.Text = ""

        '---------Pajak Penghasilan Dipotong---------
        txtkodeobj.Text = ""
        txtjmlbruto.Text = ""
        txttrf.Text = ""
        txtpphdipotong.Text = ""
        '---------Identitas Pemotong Pajak---------
        txtnamaptg.Text = cl.readData("SELECT namattd FROM mprofile WHERE id = 1")
        txtnpwptg.Text = cl.readData("SELECT npwpttd FROM mprofile WHERE id = 1")
        txtbertindaksbgi.SelectedIndex = 0
        txtnama_brtndk.Text = ""

        rbnpwp.Checked = True
        rbtanpafslts.Checked = True

        dgview.Rows.Clear()
    End Sub
    'Private Sub loadcmb()
    '    Dim dtmasapjk As DataTable = cl.table(
    '      "SELECT id AS 'value', masapjk AS 'display' FROM msetmasa WHERE stat = 1 ")
    '    Dim dtthnpjk As DataTable = cl.table(
    '       "SELECT id AS 'value', thnpjk AS 'display' FROM msetmasa WHERE stat = 1 ")

    '    cmbmasapjk.DataSource = dtmasapjk
    '    cmbmasapjk.ValueMember = "value"
    '    cmbmasapjk.DisplayMember = "display"

    '    cmbthnpjk.DataSource = dtthnpjk
    '    cmbthnpjk.ValueMember = "value"
    '    cmbthnpjk.DisplayMember = "display"
    'End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            ' loadcmb()
            btnsave.Text = "Save"
            'gencode()
            initdate()
            initializedg()
            btndelete.Visible = False
            btnprint.Visible = False
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True
        End If
        Me.Select() : cmbthnpjk.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : cmbthnpjk.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnama, "Name Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            '------ start validasi Radio identitas
            Dim radionik As String
            If rbnik.Checked = True Then
                radionik = "Y"
            Else
                radionik = "N"
            End If

            Dim radionpwp As String
            If rbnpwp.Checked = True Then
                radionpwp = "Y"
            Else
                radionpwp = "N"
            End If
            '------ end validasi

            '------ CheckBox WP Asing validation
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If
            '------- END WPASING

            '------ start validasi Radio Dokumen
            Dim rdfasilitas As String
            If rbtanpafslts.Checked = True Then
                rdfasilitas = "Y"
            Else
                rdfasilitas = "N"
            End If

            Dim rdpph23bebas As String
            If rbpph23bebas.Checked = True Then
                rdpph23bebas = "Y"
            Else
                rdpph23bebas = "N"
            End If

            Dim rdpph23pemerintah As String
            If rbpph23pemerintah.Checked = True Then
                rdpph23pemerintah = "Y"
            Else
                rdpph23pemerintah = "N"
            End If
            '------ end validasi

            '------ start validasi Radio identitas
            Dim chsetuju As String
            If chacceptance.Checked = True Then
                chsetuju = "Y"
            Else
                chsetuju = "N"
            End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stpph23 (" &
                        "  '" & .cChr(cmbthnpjk.Text) & "'" &
                        " ,'" & .cChr(cmbmasapjk.Text) & "'" &
                        " ,'" & radionpwp & "'" &
                        " ,'" & radionik & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtkeldesa.Text) & "'" &
                        " ,'" & .cChr(txtkotakab.Text) & "'" &
                        " ,'" & .cChr(txtkecamatan.Text) & "'" &
                        " ,'" & .cChr(txtkdpos.Text) & "'" &
                        " ,'" & .cChr(txtprov.Text) & "'" &
                        " ,'" & rdfasilitas & "'" &
                        " ,'" & rdpph23bebas & "'" &
                        " ,'" & rdpph23pemerintah & "'" &
                        " ,'" & .cChr(txtkodeobj.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txttrf.Text) & "'" &
                        " ,'" & .cNum(txtpphdipotong.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwptg.Text) & "'" &
                        " ,'" & .cChr(txtbertindaksbgi.Text) & "'" &
                        " ,'" & .cChr(txtnama_brtndk.Text) & "'" &
                        " ,'" & .cChr(txturaian.Text) & "'" &
                        " ,'" & chsetuju & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("namadok").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stpph23d (" &
                            " '" & .cChr(txtnpwp.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("namadok").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("nomordok").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("tgl").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("aksi").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'BARU'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtnama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stpph23 (" &
                        "  '" & .cChr(cmbthnpjk.Text) & "'" &
                        " ,'" & .cChr(cmbmasapjk.Text) & "'" &
                        " ,'" & radionpwp & "'" &
                        " ,'" & radionik & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtkeldesa.Text) & "'" &
                        " ,'" & .cChr(txtkotakab.Text) & "'" &
                        " ,'" & .cChr(txtkecamatan.Text) & "'" &
                        " ,'" & .cChr(txtkdpos.Text) & "'" &
                        " ,'" & .cChr(txtprov.Text) & "'" &
                        " ,'" & rdfasilitas & "'" &
                        " ,'" & rdpph23bebas & "'" &
                        " ,'" & rdpph23pemerintah & "'" &
                        " ,'" & .cChr(txtkodeobj.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txttrf.Text) & "'" &
                        " ,'" & .cNum(txtpphdipotong.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwptg.Text) & "'" &
                        " ,'" & .cChr(txtbertindaksbgi.Text) & "'" &
                        " ,'" & .cChr(txtnama_brtndk.Text) & "'" &
                        " ,'" & .cChr(txturaian.Text) & "'" &
                        " ,'" & chsetuju & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("namadok").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stpph23d (" &
                            " '" & .cChr(txtnpwp.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("namadok").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("nomordok").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("tgl").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("aksi").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'MODIF'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tpph23
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tpph23 TA WHERE TA.stat = 1 AND masapjk='" & masapjk & "' AND thnpjk= '" & thnpjk & "'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("thnpjk").Visible = True : .Columns("thnpjk").HeaderText = "Tahun Pajak"
            .Columns("masapjk").Visible = True : .Columns("masapjk").HeaderText = "Masa Pajak"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("namaptg").Visible = True : .Columns("namaptg").HeaderText = "Nama Pemotong"
            '.Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            '.Columns("namaptg").Visible = True : .Columns("namaptg").HeaderText = "Nama Potong"
            '.Columns("nikpssprt").Visible = True : .Columns("nikpssprt").HeaderText = "NIK / Passport"
            '.Columns("obpjk").Visible = True : .Columns("obpjk").HeaderText = "Objek Pajak"
            '.Columns("dttdate").Visible = True : .Columns("dttdate").HeaderText = "Date"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[tpph23]tpph23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgfinal'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnpwp.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stpph23 (" &
                          "  '" & .cChr(cmbthnpjk.Text) & "'" &
                        " ,'" & .cChr(cmbmasapjk.Text) & "'" &
                        " ,''" &
                        " ,''" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtkeldesa.Text) & "'" &
                        " ,'" & .cChr(txtkotakab.Text) & "'" &
                        " ,'" & .cChr(txtkecamatan.Text) & "'" &
                        " ,'" & .cChr(txtkdpos.Text) & "'" &
                        " ,'" & .cChr(txtprov.Text) & "'" &
                        " ,''" &
                        " ,''" &
                        " ,''" &
                        " ,'" & .cChr(txtkodeobj.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txttrf.Text) & "'" &
                        " ,'" & .cNum(txtpphdipotong.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwptg.Text) & "'" &
                        " ,'" & .cChr(txtbertindaksbgi.Text) & "'" &
                        " ,'" & .cChr(txtnama_brtndk.Text) & "'" &
                        " ,'" & .cChr(txturaian.Text) & "'" &
                        " ,''" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnama.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub
    Private Sub BtnBrowse1_Click(sender As Object, e As EventArgs) Handles BtnBrowse1.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpasal23 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("dsc").Visible = True : .Columns("dsc").HeaderText = "Jenis"
            .Columns("tariff").Visible = True : .Columns("tariff").HeaderText = "Tarif"
            .Columns("dsc").Visible = True : .Columns("dsc").HeaderText = "Deskripsi"
        End With
        a.loadStatusTempForm(Me, Me.txttrf, "[mpasal23]tpph23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnfilter2_Click(sender As Object, e As EventArgs) Handles btnfilter2.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mobjkpjk TA WHERE TA.stat = 1 AND TA.jnspjk = 'PPh 23'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("kode").Visible = True : .Columns("kode").HeaderText = "Kode"
            .Columns("objkpjk").Visible = True : .Columns("objkpjk").HeaderText = "Objek Pajak"
            .Columns("jnspjk").Visible = True : .Columns("jnspjk").HeaderText = "Jenis Pajak"
        End With
        a.loadStatusTempForm(Me, Me.txtkodeobj, "[mobjkpjk]tpph23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub

    Private Sub rbnpwp_CheckedChanged(sender As Object, e As EventArgs) Handles rbnpwp.CheckedChanged
        If rbnpwp.Checked = True Then
            Label30.Text = "NPWP"
        End If
    End Sub

    Private Sub rbnik_CheckedChanged(sender As Object, e As EventArgs) Handles rbnik.CheckedChanged
        If rbnik.Checked = True Then
            Label30.Text = "NIK"
        End If
    End Sub

    Private Sub rbtanpafslts_CheckedChanged(sender As Object, e As EventArgs) Handles rbtanpafslts.CheckedChanged
        If rbtanpafslts.Checked = True Then
            Label12.Text = rbtanpafslts.Text
        End If
    End Sub

    Private Sub rbpph23bebas_CheckedChanged(sender As Object, e As EventArgs) Handles rbpph23bebas.CheckedChanged
        If rbpph23bebas.Checked = True Then
            Label12.Text = rbpph23bebas.Text
        End If
    End Sub

    Private Sub rbpph23pemerintah_CheckedChanged(sender As Object, e As EventArgs) Handles rbpph23pemerintah.CheckedChanged
        If rbpph23pemerintah.Checked = True Then
            Label12.Text = rbpph23pemerintah.Text
        End If
    End Sub

    Private Sub dgDetail_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgview.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgview.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture) + 1,
                                   dgview.DefaultCellStyle.Font,
                                   b,
                                   e.RowBounds.Location.X + 10,
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub txtjmlbruto_TextChanged(sender As Object, e As EventArgs) Handles txtjmlbruto.TextChanged
        calc()
    End Sub

    Private Sub txtbertindaksbgi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtbertindaksbgi.SelectedIndexChanged
        If txtbertindaksbgi.Text = "Wajib Pajak/Wakil Wajib Pajak" Then
            txtnama_brtndk.ReadOnly = True
            txtnama_brtndk.Text = ""
        ElseIf txtbertindaksbgi.Text = "Kuasa" Then
            txtnama_brtndk.ReadOnly = False
        End If
    End Sub

    Private Sub BtnBrowse2_Click(sender As Object, e As EventArgs) Handles BtnBrowse2.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasil TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK / PASSPORT"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[mpenghasil]tpph23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgview.CurrentRow.Index <> dgview.Rows.Count - 1 Then
                dgview.Rows.RemoveAt(dgview.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub txttrf_TextChanged(sender As Object, e As EventArgs) Handles txttrf.TextChanged
        calc()
    End Sub

    Private Sub calc()
        Dim totpph As Decimal
        totpph = cl.cNum(txtjmlbruto.Text) * cl.cNum(txttrf.Text) / 100
        txtpphdipotong.Text = cl.cNum(totpph)
    End Sub
End Class