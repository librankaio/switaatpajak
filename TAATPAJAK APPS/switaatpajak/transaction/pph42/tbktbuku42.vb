Public Class tbktbuku42
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
            btndelete.Visible = False
            btnprint.Visible = False

        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True

        End If
        Me.Select() : txtnobukti.Select()
    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnobukti.Select()
    End Sub
    Private Sub clearData()
        txtnobukti.Text = ""
        rbpermohonan.Checked = False
        rbskpp.Checked = False
        rbplbk.Checked = False
        rblain.Checked = False
        txtlain.Text = ""
        txtnomer.Text = ""
        dtdate.Text = ""
        txtdrnama.Text = ""
        txtdralamat.Text = ""
        txtdrnpwp.Text = ""
        txtdrjnspjk.Text = ""
        cmbdrkdmap.Text = ""
        txtdrmasa.Text = ""
        txtdrtahun.Text = ""
        cmbnomer.Text = ""
        txtdrnomer.Text = ""
        cmbdrkdjns.Text = ""
        txtdrjml.Text = ""
        txtdrjml_rl.Text = ""
        txttonama.Text = ""
        txttoalamat.Text = ""
        txttonpwp.Text = ""
        txttojnspjk.Text = ""
        txttomasa.Text = ""
        txttotahun.Text = ""
        cmbtonomer.Text = ""
        txttonomer.Text = ""
        cmbtokdjns.Text = ""
        txttojml.Text = ""
        txttojml_rl.Text = ""
        dtberlaku.Text = ""
        txtpemindahbuku.Text = ""
        txtterbilang.Text = ""
        txttmpt.Text = ""
        dttmpt.Text = ""
        txtnamapjbt.Text = ""
        txtnippjbt.Text = ""
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnobukti, "No Bukti Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi
            '----------Validate RB permohonan--------------'
            Dim permohonan As String
            If rbpermohonan.Checked = True Then
                permohonan = "Y"
            Else
                permohonan = "N"
            End If
            '----------END--------------'
            '----------Validate RB skpp--------------'
            Dim skpp As String
            If rbskpp.Checked = True Then
                skpp = "Y"
            Else
                skpp = "N"
            End If
            '----------END--------------'
            '----------Validate RB skpp--------------'
            Dim plbk As String
            If rbplbk.Checked = True Then
                plbk = "Y"
            Else
                plbk = "N"
            End If
            '----------END--------------'
            '----------Validate RB skpp--------------'
            Dim lain As String
            If rblain.Checked = True Then
                lain = "Y"
            Else
                lain = "N"
            End If
            '----------END--------------'


            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbktbuku42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'

                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnobukti.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stbktbuku42 (" &
                        " '" & .cChr(txtnobukti.Text) & "'" &
                        " , '" & permohonan & "'" &
                        " , '" & skpp & "'" &
                        " , '" & plbk & "'" &
                        " , '" & lain & "'" &
                        " , '" & .cChr(txtlain.Text) & "'" &
                        " , '" & .cChr(txtnomer.Text) & "'" &
                        " , '" & .cChr(dtdate.Text) & "'" &
                        " , '" & .cChr(txtdrnama.Text) & "'" &
                        " , '" & .cChr(txtdralamat.Text) & "'" &
                        " , '" & .cChr(txtdrnpwp.Text) & "'" &
                        " , '" & .cChr(txtdrjnspjk.Text) & "'" &
                        " , '" & .cChr(cmbdrkdmap.Text) & "'" &
                        " , '" & .cChr(txtdrmasa.Text) & "'" &
                        " , '" & .cChr(txtdrtahun.Text) & "'" &
                        " , '" & .cChr(cmbnomer.Text) & "'" &
                        " , '" & .cChr(txtdrnomer.Text) & "'" &
                        " , '" & .cChr(cmbdrkdjns.Text) & "'" &
                        " , '" & .cChr(txtdrjml.Text) & "'" &
                        " , '" & .cChr(txtdrjml_rl.Text) & "'" &
                        " , '" & .cChr(txttonama.Text) & "'" &
                        " , '" & .cChr(txttoalamat.Text) & "'" &
                        " , '" & .cChr(txttonpwp.Text) & "'" &
                        " , '" & .cChr(txttojnspjk.Text) & "'" &
                        " , '" & .cChr(txttomasa.Text) & "'" &
                        " , '" & .cChr(txttotahun.Text) & "'" &
                        " , '" & .cChr(cmbtonomer.Text) & "'" &
                        " , '" & .cChr(txttonomer.Text) & "'" &
                        " , '" & .cChr(cmbtokdjns.Text) & "'" &
                        " , '" & .cChr(txttojml.Text) & "'" &
                        " , '" & .cChr(txttojml_rl.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Text) & "'" &
                        " , '" & .cChr(txtpemindahbuku.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                        " , '" & .cChr(txttmpt.Text) & "'" &
                        " , '" & .cChr(dttmpt.Text) & "'" &
                        " , '" & .cChr(txtnamapjbt.Text) & "'" &
                        " , '" & .cChr(txtnippjbt.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtnobukti.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbktbuku42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnobukti.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stbktbuku42 (" &
                        " '" & .cChr(txtnobukti.Text) & "'" &
                        " , '" & permohonan & "'" &
                        " , '" & skpp & "'" &
                        " , '" & plbk & "'" &
                        " , '" & lain & "'" &
                        " , '" & .cChr(txtlain.Text) & "'" &
                        " , '" & .cChr(txtnomer.Text) & "'" &
                        " , '" & .cChr(dtdate.Text) & "'" &
                        " , '" & .cChr(txtdrnama.Text) & "'" &
                        " , '" & .cChr(txtdralamat.Text) & "'" &
                        " , '" & .cChr(txtdrnpwp.Text) & "'" &
                        " , '" & .cChr(txtdrjnspjk.Text) & "'" &
                        " , '" & .cChr(cmbdrkdmap.Text) & "'" &
                        " , '" & .cChr(txtdrmasa.Text) & "'" &
                        " , '" & .cChr(txtdrtahun.Text) & "'" &
                        " , '" & .cChr(cmbnomer.Text) & "'" &
                        " , '" & .cChr(txtdrnomer.Text) & "'" &
                        " , '" & .cChr(cmbdrkdjns.Text) & "'" &
                        " , '" & .cChr(txtdrjml.Text) & "'" &
                        " , '" & .cChr(txtdrjml_rl.Text) & "'" &
                        " , '" & .cChr(txttonama.Text) & "'" &
                        " , '" & .cChr(txttoalamat.Text) & "'" &
                        " , '" & .cChr(txttonpwp.Text) & "'" &
                        " , '" & .cChr(txttojnspjk.Text) & "'" &
                        " , '" & .cChr(txttomasa.Text) & "'" &
                        " , '" & .cChr(txttotahun.Text) & "'" &
                        " , '" & .cChr(cmbtonomer.Text) & "'" &
                        " , '" & .cChr(txttonomer.Text) & "'" &
                        " , '" & .cChr(cmbtokdjns.Text) & "'" &
                        " , '" & .cChr(txttojml.Text) & "'" &
                        " , '" & .cChr(txttojml_rl.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Text) & "'" &
                        " , '" & .cChr(txtpemindahbuku.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                        " , '" & .cChr(txttmpt.Text) & "'" &
                        " , '" & .cChr(dttmpt.Text) & "'" &
                        " , '" & .cChr(txtnamapjbt.Text) & "'" &
                        " , '" & .cChr(txtnippjbt.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnobukti.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tbktbuku42 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("nobukti").Visible = True : .Columns("nobukti").HeaderText = "No Bukti"
            .Columns("drnama").Visible = True : .Columns("drnama").HeaderText = "Nama"
            .Columns("drjnspjk").Visible = True : .Columns("drjnspjk").HeaderText = "Jenis Pajak"
            .Columns("drnpwp").Visible = True : .Columns("drnpwp").HeaderText = "NPWP"

        End With
        a.loadStatusTempForm(Me, Me.txtnobukti, "[tbktbuku42]tbktbuku42")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tbktbuku42
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbktbuku42'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnobukti.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stbktbuku42 (" &
                        " '" & .cChr(txtnobukti.Text) & "'" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , '" & .cChr(txtlain.Text) & "'" &
                        " , '" & .cChr(txtnomer.Text) & "'" &
                        " , '" & .cChr(dtdate.Text) & "'" &
                        " , '" & .cChr(txtdrnama.Text) & "'" &
                        " , '" & .cChr(txtdralamat.Text) & "'" &
                        " , '" & .cChr(txtdrnpwp.Text) & "'" &
                        " , '" & .cChr(txtdrjnspjk.Text) & "'" &
                        " , '" & .cChr(cmbdrkdmap.Text) & "'" &
                        " , '" & .cChr(txtdrmasa.Text) & "'" &
                        " , '" & .cChr(txtdrtahun.Text) & "'" &
                        " , '" & .cChr(cmbnomer.Text) & "'" &
                        " , '" & .cChr(txtdrnomer.Text) & "'" &
                        " , '" & .cChr(cmbdrkdjns.Text) & "'" &
                        " , '" & .cChr(txtdrjml.Text) & "'" &
                        " , '" & .cChr(txtdrjml_rl.Text) & "'" &
                        " , '" & .cChr(txttonama.Text) & "'" &
                        " , '" & .cChr(txttoalamat.Text) & "'" &
                        " , '" & .cChr(txttonpwp.Text) & "'" &
                        " , '" & .cChr(txttojnspjk.Text) & "'" &
                        " , '" & .cChr(txttomasa.Text) & "'" &
                        " , '" & .cChr(txttotahun.Text) & "'" &
                        " , '" & .cChr(cmbtonomer.Text) & "'" &
                        " , '" & .cChr(txttonomer.Text) & "'" &
                        " , '" & .cChr(cmbtokdjns.Text) & "'" &
                        " , '" & .cChr(txttojml.Text) & "'" &
                        " , '" & .cChr(txttojml_rl.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Text) & "'" &
                        " , '" & .cChr(txtpemindahbuku.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                        " , '" & .cChr(txttmpt.Text) & "'" &
                        " , '" & .cChr(dttmpt.Text) & "'" &
                        " , '" & .cChr(txtnamapjbt.Text) & "'" &
                        " , '" & .cChr(txtnippjbt.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnobukti.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
End Class