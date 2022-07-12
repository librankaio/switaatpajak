Imports System.IO
Public Class mpenghasil
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
        txtnama.Text = ""
        txtnpwp.Text = ""
        txtnik.Text = ""
        txtalamat.Text = ""
        txtid_mnegara.Text = ""
        txtname_mnegara.Text = ""

        chwpasing.Checked = False
        btnmnegara.Enabled = False
    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            'gencode()
            btndelete.Visible = False

        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True

        End If
        Me.Select() : txtnama.Select()
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
            If validatetxtnull(txtalamat, "Alamat Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If txtnpwp.Text.Length < 15 Then
                .msgError("Angka NPWP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            If txtnik.Text.Length < 16 Then
                .msgError("Angka NIK tidak boleh kurang dari 16!")
                Exit Sub
            End If

            '------ CheckBox WP Asing validation
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasil'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smpenghasil (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & wpasing & "'" &
                        " , '" & .cChr(txtid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Save : " & txtnama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasil'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                         "CALL smpenghasil (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , '" & wpasing & "'" &
                        " , '" & .cChr(txtid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
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
        Dim frm As New mpenghasil
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasil TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            .Columns("id_mnegara").Visible = True : .Columns("id_mnegara").HeaderText = "Id Negara"
            .Columns("name_mnegara").Visible = True : .Columns("name_mnegara").HeaderText = "Nama Negara"
            .Columns("wpasing").Visible = True : .Columns("wpasing").HeaderText = "WP Asing"
        End With
        a.loadStatusTempForm(Me, Me.txtname_mnegara, "[mpenghasil]mpenghasil")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpenghasil'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnama.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                       "CALL smpenghasil (" &
                        " '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnik.Text) & "'" &
                        " , '" & .cChr(txtalamat.Text) & "'" &
                        " , ''" &
                        " , '" & .cChr(txtid_mnegara.Text) & "'" &
                        " , '" & .cChr(txtname_mnegara.Text) & "'" &
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

    Private Sub btnfilter2_Click(sender As Object, e As EventArgs) Handles btnmnegara.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mnegara TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Code"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With
        a.loadStatusTempForm(Me, Me.txtname_mnegara, "[mnegara]mpenghasil")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub chwpasing_CheckedChanged(sender As Object, e As EventArgs) Handles chwpasing.CheckedChanged
        valisearch()
    End Sub

    Private Sub mpenghasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub txtnik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnik.KeyPress
        With cl
            If e.KeyChar = " " Then
                e.Handled = True
            Else
                e.Handled = False
            End If

            If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Space) Then
                e.Handled = True
                .msgError("Nama Tidak bisa input huruf!", "Informasi")
            End If
        End With
    End Sub
End Class