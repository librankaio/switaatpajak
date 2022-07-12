Imports System.IO
Public Class mpenghasila2
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
        txtnip.Text = ""
        cmbid_mgolongan.Text = ""
        txtname_mgolongan.Text = ""
        txtname_mjabatan.Text = ""


        cmbstatus.SelectedIndex = 1
        cmbtgngan.SelectedIndex = 0
        cmbgender.SelectedIndex = 0
    End Sub
    Private Sub loadcmb()
        Dim dtemptp As DataTable = cl.table(
            "SELECT id AS 'value', golongan AS 'display' FROM mgolongan WHERE stat = 1")

        cmbid_mgolongan.DataSource = dtemptp
        cmbid_mgolongan.ValueMember = "value"
        cmbid_mgolongan.DisplayMember = "display"
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
            If validatetxtnull(txtnip, "NIP Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtname_mgolongan, "Golongan Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtname_mjabatan, "Jabatan Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If txtnpwp.Text.Length < 16 Then
                .msgError("Angka NPWP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If txtnik.Text.Length < 16 Then
                .msgError("Angka NIK tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If txtnip.Text.Length < 16 Then
                .msgError("Angka NIP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila2'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smpenghasila2 (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtnip.Text) & "'" &
                         " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtgngan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbid_mgolongan.Text) & "'" &
                        " , '" & .cChr(txtname_mgolongan.Text) & "'" &
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
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila2'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smpenghasila2 (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtnip.Text) & "'" &
                         " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtgngan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbid_mgolongan.Text) & "'" &
                        " , '" & .cChr(txtname_mgolongan.Text) & "'" &
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
        Dim frm As New mpenghasila2
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasila2 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK"
            .Columns("nip").Visible = True : .Columns("nip").HeaderText = "NIP"
            .Columns("status").Visible = True : .Columns("status").HeaderText = "Status"
            .Columns("tgngan").Visible = True : .Columns("tgngan").HeaderText = "Tanggungan"
            .Columns("gender").Visible = True : .Columns("gender").HeaderText = "Jenis Kelamin"
            .Columns("id_mgolongan").Visible = True : .Columns("id_mgolongan").HeaderText = "Id Golongan"
            .Columns("name_mgolongan").Visible = True : .Columns("name_mgolongan").HeaderText = "Golongan"
            .Columns("name_mjabatan").Visible = True : .Columns("name_mjabatan").HeaderText = "Jabatan"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[mpenghasila2]mpenghasila2")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasila2'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnama.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smpenghasila2 (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtnip.Text) & "'" &
                        " , '" & .cChr(cmbstatus.Text) & "'" &
                        " , '" & .cChr(cmbtgngan.Text) & "'" &
                        " , '" & .cChr(cmbgender.Text) & "'" &
                        " , '" & .cChr(cmbid_mgolongan.Text) & "'" &
                        " , '" & .cChr(txtname_mgolongan.Text) & "'" &
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

    Private Sub txtname_mgolongan_LostFocus(sender As Object, e As EventArgs) Handles txtname_mgolongan.LostFocus
        txtname_mgolongan.Text = cl.readData("SELECT pangkat FROM mgolongan WHERE stat = 1 AND id = '" & cmbid_mgolongan.SelectedValue & "'")
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

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        With cl
            If e.KeyChar = " " Then
                e.Handled = True
            Else
                e.Handled = False
            End If

            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                .msgError("NIP Tidak bisa input huruf!", "Informasi")
            End If
        End With
    End Sub
End Class