Imports System.IO
Public Class mpenghasila1
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

    Private Sub clearData()
        txtnpwp.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtnik.Text = ""
        txtid_mnegara.Text = ""
        txtname_mnegara.Text = ""
        cmbstatus.Text = ""
        cmbtanggungan.Text = ""
        cmbgender.Text = ""
        cmbmgolongan.Text = ""
        txtpangkat.Text = ""
        txtname_mjabatan.Text = ""

        chwpasing.Checked = False
        cmbgender.SelectedIndex = 0
        cmbstatus.SelectedIndex = 1
        cmbtanggungan.SelectedIndex = 0

        lblid_mnegara.Text = 0

        btnmnegara.Enabled = False
    End Sub
    Private Sub valisearch()
        If chwpasing.Checked = True Then
            btnmnegara.Enabled = True
        Else
            btnmnegara.Enabled = False
            txtname_mnegara.Text = ""
            txtid_mnegara.Text = ""
        End If
    End Sub
    Private Sub loadcmb()
        Dim dtemptp As DataTable = cl.table(
          "SELECT id AS 'value', golongan AS 'display' FROM mgolongan WHERE stat = 1 ")

        cmbmgolongan.DataSource = dtemptp
        cmbmgolongan.ValueMember = "value"
        cmbmgolongan.DisplayMember = "display"
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
        Me.Select() : txtnama.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnama.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnama, "Name Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnpwp, "NPWP Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnik, "NIK Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            '------ CheckBox WP Asing validation
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If

            If txtnpwp.Text.Length < 16 Then
                .msgError("Angka NPWP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If txtnik.Text.Length < 16 Then
                .msgError("Angka NIK tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila1'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smpenghasila1 (" &
                        "  '" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & wpasing & "'" &
                        " , '" & .cNum(lblid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtanggungan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbmgolongan.Text) & "'" &
                        " , '" & .cChr(txtpangkat.Text) & "'" &
                        " , '" & .cChr(txtname_mjabatan.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtnama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila1'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smpenghasila1 (" &
                        "  '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & wpasing & "'" &
                        " , '" & .cNum(lblid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtanggungan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbmgolongan.Text) & "'" &
                        " , '" & .cChr(txtpangkat.Text) & "'" &
                        " , '" & .cChr(txtname_mjabatan.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
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
        Dim frm As New mpenghasila1
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasila1 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            '     .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            ' .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK"
            '   .Columns("wpasing").Visible = True : .Columns("wpasing").HeaderText = "WP Asing"
            '  .Columns("id_mnegara").Visible = True : .Columns("id_mnegara").HeaderText = "ID Negara"
            ' .Columns("name_mnegara").Visible = True : .Columns("name_mnegara").HeaderText = "Nama Negara"
            .Columns("status").Visible = True : .Columns("status").HeaderText = "Status"
            .Columns("tanggungan").Visible = True : .Columns("tanggungan").HeaderText = "Tanggungan"
            .Columns("gender").Visible = True : .Columns("gender").HeaderText = "Jenis Kelamin"
            ' .Columns("mgolongan").Visible = True : .Columns("mgolongan").HeaderText = "Golongan"
            '  .Columns("pangkat").Visible = True : .Columns("pangkat").HeaderText = "Pangkat"
            ' .Columns("name_mjabatan").Visible = True : .Columns("name_mjabatan").HeaderText = "Jabatan"
        End With
        a.loadStatusTempForm(Me, Me.txtnama, "[mpenghasila1]mpenghasila1")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila1'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnama.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smpenghasila1 (" &
                        "  '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , ''" &
                        " , '" & .cNum(lblid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtanggungan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbmgolongan.Text) & "'" &
                        " , '" & .cChr(txtpangkat.Text) & "'" &
                        " , '" & .cChr(txtname_mjabatan.Text) & "'" &
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
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub

    Private Sub cmbmgolongan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmgolongan.SelectedIndexChanged
        'txtpangkat.Text = cl.readData("SELECT pangkat FROM mgolongan WHERE stat = 1 AND id = '" & cmbmgolongan.SelectedValue & "'")
    End Sub

    Private Sub btnfilter2_Click(sender As Object, e As EventArgs) Handles btnmnegara.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mnegara TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With
        a.loadStatusTempForm(Me, Me.txtid_mnegara, "[mnegara]mpenghasila1")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub cmbmgolongan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbmgolongan.SelectedValueChanged

    End Sub

    Private Sub chwpasing_CheckedChanged(sender As Object, e As EventArgs) Handles chwpasing.CheckedChanged
        valisearch()
    End Sub

    Private Sub cmbmgolongan_LostFocus(sender As Object, e As EventArgs) Handles cmbmgolongan.LostFocus
        txtpangkat.Text = cl.readData("SELECT pangkat FROM mgolongan WHERE stat = 1 AND id = '" & cmbmgolongan.SelectedValue & "'")
    End Sub

    Private Sub txtnik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnik.KeyPress
        With cl
            If e.KeyChar = " " Then
                e.Handled = True
            Else
                e.Handled = False
            End If

            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                .msgError("NIK Tidak bisa input huruf!", "Informasi")
            End If
        End With
    End Sub

    Private Sub txtnpwp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnpwp.KeyPress
        With cl
            If e.KeyChar = " " Then
                e.Handled = True
            Else
                e.Handled = False
            End If

            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                .msgError("NPWP Tidak bisa input huruf!", "Informasi")
            End If
        End With
    End Sub
End Class