Imports System.IO
Public Class tpph21
    Dim statusTempForm, varTempForm, varTempForm2 As String
    Dim tempForm As Form
    Dim tempObj As Object
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

    Public Sub loadStatusTempForm(ByVal tempAsalForm As Form, ByVal tempAsalObj As Object, ByVal temp As String)
        tempForm = tempAsalForm
        tempObj = tempAsalObj
        statusTempForm = temp
    End Sub

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub

    'Private Sub gencode()
    '    txtcode.Text = cl.readData("SELECT dbo.fgetcode('msales','')")
    'End Sub

    Private Sub clearData()
        txtnobuktptg.Text = ""
        txtnobuktptg_knn.Text = ""
        dttdttanggal.Text = ""
        cmbmasa.Text = masapjk
        cmbmasa_knn.Text = thnpjk
        txtnpwp.Text = ""
        txtnikpssprt.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        cmbgender.Text = ""
        cmbtgngan.Text = ""
        cmbstatus.Text = ""
        cmbname_mjabatan.Text = ""
        chwpasing.Checked = False
        cmbid_mnegara.Text = ""

        cmbkodepjk.Text = ""
        txtgajipensi.Text = 0
        txttunjpph.Text = 0
        txttunjlain.Text = 0
        txthonorarium.Text = 0
        txtpremiapbr.Text = 0
        txtpenerimapotpph21.Text = 0
        txttantiem.Text = 0
        txtjmlbruto.Text = 0
        txtbiayapensi.Text = 0
        txtiuranpensi.Text = 0

        txtjmlpengurangan.Text = 0
        txtjmlneto.Text = 0
        txtjmlnetosblm.Text = 0
        txtjmlneto1thn.Text = 0
        txtptkp.Text = 0
        txtpph21setahun.Text = 0
        txtpph21htg.Text = 0
        txtpph21to26.Text = 0

        txtnpwpptg.Text = cl.readData("SELECT npwpttd FROM mprofile WHERE id = 1")
        txtnamaptg.Text = cl.readData("SELECT namattd FROM mprofile WHERE id = 1")


    End Sub
    Private Sub loadcmb()
        Dim dtmnegara As DataTable = cl.table(
          "SELECT id AS 'value', code AS 'display' FROM mnegara WHERE stat = 1 ")
        Dim dtobjpjk As DataTable = cl.table(
           "SELECT id AS 'value', kode AS 'display' FROM mobjkpjk WHERE stat = 1 AND jnspjk = 'PPh 21' ")
        Dim dtjbtn As DataTable = cl.table(
           "SELECT id AS 'value', jabatan AS 'display' FROM mjbtn WHERE stat = 1 ")

        Dim row As DataRow = dtmnegara.NewRow()
        row(0) = 0
        row(1) = "----PILIH NEGARA----"
        dtmnegara.Rows.InsertAt(row, 0)

        cmbid_mnegara.DataSource = dtmnegara
        cmbid_mnegara.ValueMember = "value"
        cmbid_mnegara.DisplayMember = "display"

        cmbkodepjk.DataSource = dtobjpjk
        cmbkodepjk.ValueMember = "value"
        cmbkodepjk.DisplayMember = "display"

        cmbname_mjabatan.DataSource = dtjbtn
        cmbname_mjabatan.ValueMember = "value"
        cmbname_mjabatan.DisplayMember = "display"
    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            loadcmb()
            btnsave.Text = "Save"
            'gencode()
            btndelete.Visible = False
            btnprint.Visible = False
            btnlist.Visible = False
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True
        End If
        Me.Select() : txtnobuktptg.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnobuktptg.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnobuktptg, "No Bukti Potong Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            '------ start validasi wpasing
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph21'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnobuktptg.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stpph21 (" &
                        "  '" & .cChr(txtnobuktptg.Text) & "'" &
                        " ,'" & .cChr(txtnobuktptg_knn.Text) & "'" &
                        " ,'" & .cChr(dttdttanggal.Text) & "'" &
                        " ,'" & .cChr(cmbmasa.Text) & "'" &
                        " ,'" & .cChr(cmbmasa_knn.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(cmbgender.Text) & "'" &
                        " ,'" & .cChr(cmbtgngan.Text) & "'" &
                        " ,'" & .cChr(cmbstatus.Text) & "'" &
                        " ,'" & .cChr(cmbname_mjabatan.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(cmbid_mnegara.Text) & "'" &
                        " ,'" & .cChr(cmbkodepjk.Text) & "'" &
                        " ,'" & .cNum(txtgajipensi.Text) & "'" &
                        " ,'" & .cNum(txttunjpph.Text) & "'" &
                        " ,'" & .cNum(txttunjlain.Text) & "'" &
                        " ,'" & .cNum(txthonorarium.Text) & "'" &
                        " ,'" & .cNum(txtpremiapbr.Text) & "'" &
                        " ,'" & .cNum(txtpenerimapotpph21.Text) & "'" &
                        " ,'" & .cNum(txttantiem.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txtbiayapensi.Text) & "'" &
                        " ,'" & .cNum(txtiuranpensi.Text) & "'" &
                        " ,'" & .cNum(txtjmlpengurangan.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto.Text) & "'" &
                        " ,'" & .cNum(txtjmlnetosblm.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto1thn.Text) & "'" &
                        " ,'" & .cNum(txtptkp.Text) & "'" &
                        " ,'" & .cNum(txtpph21setahun.Text) & "'" &
                        " ,'" & .cNum(txtpph21htg.Text) & "'" &
                        " ,'" & .cNum(txtpph21to26.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txtnobuktptg.Text & " !", "Informasi")
                        'changestatform("new") : End If
                        Me.Dispose()
                        Dim a As ta1 = CType(Application.OpenForms("ta1"), ta1)
                        a.Enabled = True
                        a.loadPmotongPjkBlnTable()
                    End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph21'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnobuktptg.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stpph21 (" &
                        "  '" & .cChr(txtnobuktptg.Text) & "'" &
                        " ,'" & .cChr(txtnobuktptg_knn.Text) & "'" &
                        " ,'" & .cChr(dttdttanggal.Text) & "'" &
                        " ,'" & .cChr(cmbmasa.Text) & "'" &
                        " ,'" & .cChr(cmbmasa_knn.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(cmbgender.Text) & "'" &
                        " ,'" & .cChr(cmbtgngan.Text) & "'" &
                        " ,'" & .cChr(cmbstatus.Text) & "'" &
                        " ,'" & .cChr(cmbname_mjabatan.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(cmbid_mnegara.Text) & "'" &
                        " ,'" & .cChr(cmbkodepjk.Text) & "'" &
                        " ,'" & .cNum(txtgajipensi.Text) & "'" &
                        " ,'" & .cNum(txttunjpph.Text) & "'" &
                        " ,'" & .cNum(txttunjlain.Text) & "'" &
                        " ,'" & .cNum(txthonorarium.Text) & "'" &
                        " ,'" & .cNum(txtpremiapbr.Text) & "'" &
                        " ,'" & .cNum(txtpenerimapotpph21.Text) & "'" &
                        " ,'" & .cNum(txttantiem.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txtbiayapensi.Text) & "'" &
                        " ,'" & .cNum(txtiuranpensi.Text) & "'" &
                        " ,'" & .cNum(txtjmlpengurangan.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto.Text) & "'" &
                        " ,'" & .cNum(txtjmlnetosblm.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto1thn.Text) & "'" &
                        " ,'" & .cNum(txtptkp.Text) & "'" &
                        " ,'" & .cNum(txtpph21setahun.Text) & "'" &
                        " ,'" & .cNum(txtpph21htg.Text) & "'" &
                        " ,'" & .cNum(txtpph21to26.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        "")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnobuktptg.Text & " !", "Informasi")
                        'changestatform("new") : End If
                        Me.Dispose()
                        Dim a As ta1 = CType(Application.OpenForms("ta1"), ta1)
                        a.Enabled = True
                        a.loadPmotongPjkBlnTable()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tbuktiptgfinal
        cekform(frm, "BARU", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tpph21 TA WHERE TA.stat = 1 AND masa='" & masapjk & "' AND thnpjk= '" & thnpjk & "'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("nobuktptg").Visible = True : .Columns("nobuktptg").HeaderText = "No Bukti"
            .Columns("nobuktptg_knn").Visible = True : .Columns("nobuktptg_knn").HeaderText = "No Bukti KNN"
            .Columns("tanggal").Visible = True : .Columns("tanggal").HeaderText = "Tanggal"
            .Columns("masa").Visible = True : .Columns("masa").HeaderText = "Masa"
            .Columns("masa_knn").Visible = True : .Columns("masa_knn").HeaderText = "Masa KNN"
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nikpssprt").Visible = True : .Columns("nikpssprt").HeaderText = "NIK / Passport"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            '  .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            '   .Columns("gender").Visible = True : .Columns("gender").HeaderText = "Gender"
            .Columns("tgngan").Visible = True : .Columns("tgngan").HeaderText = "Tanggungan"
            .Columns("status").Visible = True : .Columns("status").HeaderText = "status"
            '   .Columns("name_mjabatan").Visible = True : .Columns("name_mjabatan").HeaderText = "Nama Jabatan"
            '.Columns("wpasing").Visible = True : .Columns("wpasing").HeaderText = "Wp Asing"
            '.Columns("id_mnegara").Visible = True : .Columns("id_mnegara").HeaderText = "Id Negara"
            '.Columns("kodepjk").Visible = True : .Columns("kodepjk").HeaderText = "Kode Pajak"
            '.Columns("gajipensi").Visible = True : .Columns("gajipensi").HeaderText = "Gaji/Pensiun"
            '.Columns("tunjpph").Visible = True : .Columns("tunjpph").HeaderText = "Tunjangan PPh"
            '.Columns("tunjlain").Visible = True : .Columns("tunjlain").HeaderText = "Tunjangan Lain"
            '.Columns("honorarium").Visible = True : .Columns("honorarium").HeaderText = "Honorarium"
            '.Columns("premiapbr").Visible = True : .Columns("premiapbr").HeaderText = "Premia"
            '.Columns("penerimapotpph21").Visible = True : .Columns("penerimapotpph21").HeaderText = "Penerima Po PPh21"
            '.Columns("tantiem").Visible = True : .Columns("tantiem").HeaderText = "Tantiem"
            '.Columns("jmlbruto").Visible = True : .Columns("jmlbruto").HeaderText = "Bruto"
            '.Columns("biayapensi").Visible = True : .Columns("biayapensi").HeaderText = "Biaya Pensiun"
            '.Columns("iuranpensi").Visible = True : .Columns("iuranpensi").HeaderText = "Iuran Pensiun"
            '.Columns("jmlpengurangan").Visible = True : .Columns("jmlpengurangan").HeaderText = "Jumlah Pengurangan"
            '.Columns("jmlneto").Visible = True : .Columns("jmlneto").HeaderText = "Jumlah Neto"
            '.Columns("jmlnetosblm").Visible = True : .Columns("jmlnetosblm").HeaderText = "Jumlah Neto Sebelum"
            '.Columns("jmlneto1thn").Visible = True : .Columns("jmlneto1thn").HeaderText = "Jumlah Neto 1 Tahun"
            '.Columns("ptkp").Visible = True : .Columns("ptkp").HeaderText = "PTKP"
            '.Columns("pph21setahun").Visible = True : .Columns("pph21setahun").HeaderText = "PPh21 Setahun"
            '.Columns("pph21htg").Visible = True : .Columns("pph21htg").HeaderText = "PPh21 Hutang"
            '.Columns("pph21to26").Visible = True : .Columns("pph21to26").HeaderText = "PPh21 sampai PPh26"
            .Columns("npwpptg").Visible = True : .Columns("npwpptg").HeaderText = "NPWP Potong"
            .Columns("namaptg").Visible = True : .Columns("namaptg").HeaderText = "Nama Potong"
        End With
        a.loadStatusTempForm(Me, Me.txtnobuktptg, "[tpph21]tpph21")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub


    '!-----------WARNING ERROR----------!
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph21'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnobuktptg.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stpph21 (" &
                        "  '" & .cChr(txtnobuktptg.Text) & "'" &
                        " ,'" & .cChr(txtnobuktptg_knn.Text) & "'" &
                        " ,'" & .cChr(dttdttanggal.Text) & "'" &
                        " ,'" & .cChr(cmbmasa.Text) & "'" &
                        " ,'" & .cChr(cmbmasa_knn.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & .cChr(cmbgender.Text) & "'" &
                        " ,'" & .cChr(cmbtgngan.Text) & "'" &
                        " ,'" & .cChr(cmbstatus.Text) & "'" &
                        " ,'" & .cChr(cmbname_mjabatan.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(cmbid_mnegara.Text) & "'" &
                        " ,'" & .cChr(cmbkodepjk.Text) & "'" &
                        " ,'" & .cNum(txtgajipensi.Text) & "'" &
                        " ,'" & .cNum(txttunjpph.Text) & "'" &
                        " ,'" & .cNum(txttunjlain.Text) & "'" &
                        " ,'" & .cNum(txthonorarium.Text) & "'" &
                        " ,'" & .cNum(txtpremiapbr.Text) & "'" &
                        " ,'" & .cNum(txtpenerimapotpph21.Text) & "'" &
                        " ,'" & .cNum(txttantiem.Text) & "'" &
                        " ,'" & .cNum(txtjmlbruto.Text) & "'" &
                        " ,'" & .cNum(txtbiayapensi.Text) & "'" &
                        " ,'" & .cNum(txtiuranpensi.Text) & "'" &
                        " ,'" & .cNum(txtjmlpengurangan.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto.Text) & "'" &
                        " ,'" & .cNum(txtjmlnetosblm.Text) & "'" &
                        " ,'" & .cNum(txtjmlneto1thn.Text) & "'" &
                        " ,'" & .cNum(txtptkp.Text) & "'" &
                        " ,'" & .cNum(txtpph21setahun.Text) & "'" &
                        " ,'" & .cNum(txtpph21htg.Text) & "'" &
                        " ,'" & .cNum(txtpph21to26.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnpwp.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub clcbruto()
        Dim total17 As Decimal
        total17 = cl.cNum(txtgajipensi.Text) + cl.cNum(txttunjpph.Text) + cl.cNum(txttunjlain.Text) + cl.cNum(txthonorarium.Text) + cl.cNum(txtpremiapbr.Text) + cl.cNum(txtpenerimapotpph21.Text) + cl.cNum(txttantiem.Text)
        txtjmlbruto.Text = cl.cCur(total17)
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasila1 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            .Columns("gender").Visible = True : .Columns("gender").HeaderText = "Jenis Kelamin"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[mpenghasila1]tpph21")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub clckurang()
        Dim totkrg As Decimal
        totkrg = cl.cNum(txtbiayapensi.Text) + cl.cNum(txtiuranpensi.Text)
        txtjmlpengurangan.Text = cl.cCur(totkrg)
    End Sub

    Private Sub txtgajipensi_TextChanged(sender As Object, e As EventArgs) Handles txtgajipensi.TextChanged
        getcalculate()
    End Sub

    Private Sub txttunjpph_TextChanged(sender As Object, e As EventArgs) Handles txttunjpph.TextChanged
        getcalculate()
    End Sub

    Private Sub txttunjlain_TextChanged(sender As Object, e As EventArgs) Handles txttunjlain.TextChanged
        getcalculate()
    End Sub

    Private Sub txthonorarium_TextChanged(sender As Object, e As EventArgs) Handles txthonorarium.TextChanged
        getcalculate()
    End Sub

    Private Sub txtpremiapbr_TextChanged(sender As Object, e As EventArgs) Handles txtpremiapbr.TextChanged
        getcalculate()
    End Sub

    Private Sub txtpenerimapotpph21_TextChanged(sender As Object, e As EventArgs) Handles txtpenerimapotpph21.TextChanged
        getcalculate()
    End Sub

    Private Sub txttantiem_TextChanged(sender As Object, e As EventArgs) Handles txttantiem.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayapensi_TextChanged(sender As Object, e As EventArgs) Handles txtbiayapensi.TextChanged
        getcalculate()
    End Sub

    Private Sub txtiuranpensi_TextChanged(sender As Object, e As EventArgs) Handles txtiuranpensi.TextChanged
        getcalculate()
    End Sub
    Private Sub valiwp()
        If chwpasing.Checked = True Then
            cmbid_mnegara.Enabled = True
        Else
            cmbid_mnegara.Enabled = False
        End If
    End Sub
    Private Sub chwpasing_CheckedChanged(sender As Object, e As EventArgs) Handles chwpasing.CheckedChanged
        valiwp()
    End Sub

    Private Sub txtjmlneto1thn_TextChanged(sender As Object, e As EventArgs) Handles txtjmlneto1thn.TextChanged
        getcalculate()
    End Sub

    Private Sub txtjmlnetosblm_TextChanged(sender As Object, e As EventArgs) Handles txtjmlnetosblm.TextChanged
        getcalculate()
    End Sub

    Private Sub clcneto()
        Dim totneto As Decimal
        totneto = cl.cNum(txtbiayapensi.Text) - cl.cNum(txtbiayapensi.Text)
        txtjmlneto.Text = cl.cCur(totneto)
    End Sub

    Private Sub tinputdatapemotongpjk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub

    Public Sub getcalculate()
        txtjmlbruto.Text = cl.cCur(cl.cNum(txtgajipensi.Text) +
        cl.cNum(txttunjpph.Text) +
        cl.cNum(txttunjlain.Text) +
        cl.cNum(txthonorarium.Text) +
        cl.cNum(txtpremiapbr.Text) +
        cl.cNum(txtpenerimapotpph21.Text) +
        cl.cNum(txttantiem.Text))

        txtjmlpengurangan.Text = cl.cCur(cl.cNum(txtbiayapensi.Text) +
        cl.cNum(txtiuranpensi.Text))

        txtjmlneto.Text = cl.cCur(cl.cNum(txtjmlbruto.Text) - cl.cNum(txtjmlpengurangan.Text))

        txtjmlneto1thn.Text = cl.cCur(cl.cNum(txtjmlneto.Text) + cl.cNum(txtjmlneto.Text))

        txtptkp.Text = cl.cCur(cl.readData("SELECT ptkp FROM mptkp WHERE stat = 1"))

        txtpjksetahun.Text = cl.cCur(cl.cNum(txtjmlneto1thn.Text) - cl.cNum(txtptkp.Text))



    End Sub
End Class