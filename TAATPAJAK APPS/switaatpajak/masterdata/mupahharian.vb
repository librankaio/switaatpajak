Imports System.IO
Public Class mupahharian
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
        txtlapis1.Text = 0
        txtlapis2.Text = 0
        txtlapis3.Text = 0
        dtberlaku.Text = ""
        dtberakhir.Text = ""

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
        Me.Select() : txtlapis1.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtlapis1.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtlapis1, "Lapis 1 Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi


            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mupahharian'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtlapis1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smupahharian (" &
                        " '" & .cNum(txtlapis1.Text) & "'" &
                        " , '" & .cNum(txtlapis2.Text) & "'" &
                        " , '" & .cNum(txtlapis3.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Value) & "'" &
                        " , '" & .cChr(dtberakhir.Value) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Save : " & txtlapis1.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mupahharian'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtlapis1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smupahharian (" &
                        " '" & .cNum(txtlapis1.Text) & "'" &
                        " , '" & .cNum(txtlapis2.Text) & "'" &
                        " , '" & .cNum(txtlapis3.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Value) & "'" &
                        " , '" & .cChr(dtberakhir.Value) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ") ")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtlapis1.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mupahharian
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mupahharian TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("lapis1").Visible = True : .Columns("lapis1").HeaderText = "Lapis 1"
            .Columns("lapis2").Visible = True : .Columns("lapis2").HeaderText = "Lapis 3"
            .Columns("lapis3").Visible = True : .Columns("lapis3").HeaderText = "Lapis 3"
            .Columns("berlaku").Visible = True : .Columns("berlaku").HeaderText = "Berlaku"
            .Columns("berakhir").Visible = True : .Columns("berakhir").HeaderText = "Berakhir"
        End With
        a.loadStatusTempForm(Me, Me.txtlapis1, "[mupahharian]mupahharian")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mupahharian'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtlapis1.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smupahharian (" &
                        " '" & .cNum(txtlapis1.Text) & "'" &
                        " , '" & .cNum(txtlapis2.Text) & "'" &
                        " , '" & .cNum(txtlapis3.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Value) & "'" &
                        " , '" & .cChr(dtberakhir.Value) & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ") ")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtlapis1.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub
End Class