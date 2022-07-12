Imports System.IO
Public Class mprofile
    Dim idmaster As Integer = 1, statform As String = ""

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
        txtnama.Text = cl.readData("SELECT nama FROM mprofile WHERE id = 1")
        txtnpwp.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")
        txtnik.Text = cl.readData("SELECT nik FROM mprofile WHERE id = 1")
        txtpekerjaan.Text = cl.readData("SELECT pekerjaan FROM mprofile WHERE id = 1")
        txtalamat.Text = cl.readData("SELECT alamat FROM mprofile WHERE id = 1")
        txtttl.Text = cl.readData("SELECT ttl FROM mprofile WHERE id = 1")
        txtname_mnegara.Text = cl.readData("SELECT name_mnegara FROM mprofile WHERE id = 1")
        txthp.Text = cl.readData("SELECT hp FROM mprofile WHERE id = 1")
        txtemaildjp.Text = cl.readData("SELECT emaildjp FROM mprofile WHERE id = 1")

        txtnpwpttd.Text = cl.readData("SELECT npwpttd FROM mprofile WHERE id = 1")
        txtnamattd.Text = cl.readData("SELECT namattd FROM mprofile WHERE id = 1")
    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Update"
            'gencode()
            btndelete.Visible = False
            btnlist.Visible = False
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True

        End If
        Me.Select() : txtnama.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnama.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnama, "Name tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnpwp, "NPWP tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnik, "NIB tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtalamat, "Alamat tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtpekerjaan, "Jenis Usaha tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnpwpttd, "NPWP Penandatangan tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnamattd, "NAMA Penandatangan tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If txtnik.Text.Length < 16 Then
                .msgError("Angka NIK tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If txtnpwp.Text.Length < 15 Then
                .msgError("Angka NPWP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mprofile'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smprofile (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtpekerjaan.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtttl.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(txthp.Text) & "'" &
                        " , '" & .cChr(txtemaildjp.Text) & "'" &
                        " , '" & .cChr(txtnpwpttd.Text) & "'" &
                        " , '" & .cChr(txtnamattd.Text) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil simpan data : " & txtnama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mprofile'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smprofile (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtpekerjaan.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtttl.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(txthp.Text) & "'" &
                        " , '" & .cChr(txtemaildjp.Text) & "'" &
                        " , '" & .cChr(txtnpwpttd.Text) & "'" &
                        " , '" & .cChr(txtnamattd.Text) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnama.Text & " !", "Informasi")
                        npwp = .cChr(txtnpwp.Text)
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mprofile
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mprofile TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK"
            .Columns("pekerjaan").Visible = True : .Columns("pekerjaan").HeaderText = "Pekerjaan"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            .Columns("ttl").Visible = True : .Columns("ttl").HeaderText = "Tempat tanggal lahir"
            .Columns("name_mnegara").Visible = True : .Columns("name_mnegara").HeaderText = "Nama Negara"
            .Columns("hp").Visible = True : .Columns("hp").HeaderText = "No Handphone"
            .Columns("emaildjp").Visible = True : .Columns("emaildjp").HeaderText = "Email DJP"

        End With
        a.loadStatusTempForm(Me, Me.txtnama, "[mprofile]mprofile")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mprofile'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnama.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smprofile (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtpekerjaan.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & .cChr(txtttl.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , '" & .cChr(txthp.Text) & "'" &
                        " , '" & .cChr(txtemaildjp.Text) & "'" &
                        " , '" & .cChr(txtnpwpttd.Text) & "'" &
                        " , '" & .cChr(txtnamattd.Text) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
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

    Private Sub txtnpwp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnpwp.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Tidak bisa input huruf!")
        End If
    End Sub

    Private Sub txtnik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnik.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        Else
            e.Handled = False
        End If

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Tidak bisa input huruf!")
        End If
    End Sub
End Class