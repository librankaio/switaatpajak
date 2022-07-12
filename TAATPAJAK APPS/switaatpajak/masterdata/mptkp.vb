Imports System.IO
Public Class mptkp
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
        txtptkp.Text = ""
        txttgngan.Text = ""
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
        Me.Select() : txtptkp.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtptkp.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtptkp, "PTKP Tidak Boleh Kosong !", "Warning Information") = 1 Then : Exit Sub : End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mptkp'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                '----yang ini bisa validationnya cukup bagus cuma dia sql berakhirnya gak mau ngeread ( berakhir harus >= / > baru ngeread)
                Dim berlaku As String
                Dim berakhir As String

                berlaku = .readData("SELECT berlaku FROM mptkp where berlaku >= '" & dtberlaku.Text & "' between berlaku and berakhir order by berlaku")
                berakhir = .readData("SELECT berakhir FROM mptkp where berakhir <= '" & dtberakhir.Text & "'between berlaku and berakhir order by berakhir")

                'MsgBox(berlaku)
                'MsgBox(berakhir)

                If dtberlaku.Text >= berlaku And dtberakhir.Text <= berakhir Then
                    'If .readData("SELECT * FROM mptkp where berakhir <= '" & dtberakhir.Text & "' and berlaku >='" & dtberlaku.Text & "' between berlaku and berakhir order by berakhir and stat = 1") Then
                    .msgError("Tidak bisa input data")
                    Exit Sub
                End If

                '---Ini gabisa dibuka diluar yang ada di data base
                'If .readData("select * from mptkp where stat = 1 and ((berlaku >= '" & dtberlaku.Text & "' and berakhir <= '" & dtberakhir.Text & "')" &
                '    "or (berlaku <= '" & dtberlaku.Text & "' and berakhir >= '" & dtberakhir.Text & "')" &
                '    "or (berlaku > '" & dtberlaku.Text & "' and berakhir > '" & dtberakhir.Text & "' and berlaku < berakhir)" &
                '    "or (berlaku < '" & dtberlaku.Text & "' and berakhir < '" & dtberakhir.Text & "' and berakhir > berlaku))") Then
                '    .msgError("tidak bisa input data")
                '    Exit Sub
                'End If


                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtptkp.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                        .openTrans()
                        .execCmdTrans(
                            "CALL smptkp (" &
                            " '" & .cNum(txtptkp.Text) & "'" &
                            " , '" & .cNum(txttgngan.Text) & "'" &
                            " , '" & .cChr(dtberlaku.Text) & "'" &
                            " , '" & .cChr(dtberakhir.Text) & "'" &
                            " , ''" &
                            " , '" & 1 & "'" &
                            " , 'BARU'" &
                            " , '0'" &
                            ")")

                        .closeTrans(btnsave)
                        If .sCloseTrans = 1 Then
                            .msgInform("Berhasil Simpan data : " & txtptkp.Text & " !", "Informasi")
                            changestatform("new") : End If
                    End If
                ElseIf btnsave.Text = "Update" Then
                    '----------USER AUTHORIZATION CHECK--------------'
                    If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mptkp'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtptkp.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smptkp (" &
                        " '" & .cNum(txtptkp.Text) & "'" &
                        " , '" & .cNum(txttgngan.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Text) & "'" &
                        " , '" & .cChr(dtberakhir.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtptkp.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mptkp
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mptkp TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("ptkp").Visible = True : .Columns("ptkp").HeaderText = "PTKP"
            .Columns("tgngan").Visible = True : .Columns("tgngan").HeaderText = "Tanggungan"
            .Columns("berlaku").Visible = True : .Columns("berlaku").HeaderText = "Berlaku"
            .Columns("berakhir").Visible = True : .Columns("berakhir").HeaderText = "Berakhir"

        End With
        a.loadStatusTempForm(Me, Me.txtptkp, "[mptkp]mptkp")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mptkp'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtptkp.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smptkp (" &
                        " '" & .cNum(txtptkp.Text) & "'" &
                        " , '" & .cNum(txttgngan.Text) & "'" &
                        " , '" & .cChr(dtberlaku.Text) & "'" &
                        " , '" & .cChr(dtberakhir.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtptkp.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub

    Private Sub txttgngan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttgngan.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class