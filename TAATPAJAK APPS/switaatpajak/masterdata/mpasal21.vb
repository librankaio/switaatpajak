Imports System.IO
Public Class mpasal21
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
            'ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F3) Then
            '    btnlist.PerformClick()
            'ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
            '    If idmaster <> 0 And btnsave.Text <> "Save" Then : btndelete.PerformClick() : End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub

    Private Sub loaddata()
        txtlapis1fr.Text = cl.cCur(cl.readData("SELECT lapis1fr FROM mpasal21"))
        txtlapis1to.Text = cl.cCur(cl.readData("SELECT lapis1to FROM mpasal21"))
        txtlapis1trf.Text = cl.cCur(cl.readData("SELECT lapis1trf FROM mpasal21"))

        txtlapis2fr.Text = cl.cCur(cl.readData("SELECT lapis2fr FROM mpasal21"))
        txtlapis2to.Text = cl.cCur(cl.readData("SELECT lapis2to FROM mpasal21"))
        txtlapis2trf.Text = cl.cCur(cl.readData("SELECT lapis2trf FROM mpasal21"))

        txtlapis3fr.Text = cl.cCur(cl.readData("SELECT lapis3fr FROM mpasal21"))
        txtlapis3to.Text = cl.cCur(cl.readData("SELECT lapis3to FROM mpasal21"))
        txtlapis3trf.Text = cl.cCur(cl.readData("SELECT lapis3trf FROM mpasal21"))

        txtlapis4fr.Text = cl.cCur(cl.readData("SELECT lapis4fr FROM mpasal21"))
        txtlapis4to.Text = cl.cCur(cl.readData("SELECT lapis4to FROM mpasal21"))
        txtlapis4trf.Text = cl.cCur(cl.readData("SELECT lapis4trf FROM mpasal21"))

        txtlapis5fr.Text = cl.cCur(cl.readData("SELECT lapis5fr FROM mpasal21"))
        txtlapis5trf.Text = cl.cCur(cl.readData("SELECT lapis5trf FROM mpasal21"))
    End Sub

    Private Sub clearData()
        txtlapis1fr.Text = 0
        txtlapis1to.Text = 0
        txtlapis1trf.Text = 0
        txtlapis2fr.Text = 0
        txtlapis2to.Text = 0
        txtlapis2trf.Text = 0
        txtlapis3fr.Text = 0
        txtlapis3to.Text = 0
        txtlapis3trf.Text = 0
        txtlapis4fr.Text = 0
        txtlapis4to.Text = 0
        txtlapis4trf.Text = 0
        txtlapis5fr.Text = 0
        txtlapis5trf.Text = 0

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtlapis1fr.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtlapis1fr.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtlapis1fr, "Lapis 1 tidak boleh kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If

            If .cNum(txtlapis1trf.Text) > 100 Then
                .msgInform("Presentasi tidak boleh lebih dari 100%", "Informasi")
                Exit Sub
            ElseIf .cNum(txtlapis2trf.Text) > 100 Then
                .msgInform("Presentasi tidak boleh lebih dari 100%", "Informasi")
                Exit Sub
            ElseIf .cNum(txtlapis3trf.Text) > 100 Then
                .msgInform("Presentasi tidak boleh lebih dari 100%", "Informasi")
                Exit Sub
            ElseIf .cNum(txtlapis4trf.Text) > 100 Then
                .msgInform("Presentasi tidak boleh lebih dari 100%", "Informasi")
                Exit Sub
            ElseIf .cNum(txtlapis5trf.Text) > 100 Then
                .msgInform("Presentasi tidak boleh lebih dari 100%", "Informasi")
                Exit Sub
            End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpasal21'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtlapis1fr.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "UPDATE mpasal21 SET" &
                        " lapis1fr = '" & .cNum(txtlapis1fr.Text) & "'" &
                        " , lapis1to = '" & .cNum(txtlapis1to.Text) & "'" &
                        " , lapis1trf = '" & .cNum(txtlapis1trf.Text) & "'" &
                        " , lapis2fr = '" & .cNum(txtlapis2fr.Text) & "'" &
                        " , lapis2to = '" & .cNum(txtlapis2to.Text) & "'" &
                        " , lapis2trf = '" & .cNum(txtlapis2trf.Text) & "'" &
                        " , lapis3fr = '" & .cNum(txtlapis3fr.Text) & "'" &
                        " , lapis3to = '" & .cNum(txtlapis3to.Text) & "'" &
                        " , lapis3trf = '" & .cNum(txtlapis3trf.Text) & "'" &
                        " , lapis4fr = '" & .cNum(txtlapis4fr.Text) & "'" &
                        " , lapis4to = '" & .cNum(txtlapis4to.Text) & "'" &
                        " , lapis4trf = '" & .cNum(txtlapis4trf.Text) & "'" &
                        " , lapis5fr = '" & .cNum(txtlapis5fr.Text) & "'" &
                        " , lapis5trf = '" & .cNum(txtlapis5trf.Text) & "'")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txtlapis1fr.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
                'ElseIf btnsave.Text = "Update" Then
                '    '----------USER AUTHORIZATION CHECK--------------'
                '    If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mpasal21'") = "N" Then
                '        .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                '        Exit Sub
                '    End If
                '    '---------------------END------------------------'
                '    Dim tny As Integer
                '    tny = .msgYesNo("Update data : " & txtlapis1fr.Text & " ?", "Confirmation")
                '    If tny = vbYes Then
                '        .openTrans()
                '        .execCmdTrans(
                '            "CALL mpasal21 " &
                '            " '" & .cChr(txtlapis1fr.Text) & "'" &
                '            " , '" & .cChr(txtlapis1to.Text) & "'" &
                '            " , '" & .cChr(txtlapis1trf.Text) & "'" &
                '            " . '" & .cChr(txtlapis2fr.Text) & "'" &
                '            " , '" & .cChr(txtlapis2to.Text) & "'" &
                '            " , '" & .cChr(txtlapis2trf.Text) & "'" &
                '            " . '" & .cChr(txtlapis3fr.Text) & "'" &
                '            " , '" & .cChr(txtlapis3to.Text) & "'" &
                '            " , '" & .cChr(txtlapis3trf.Text) & "'" &
                '            " , '" & .cChr(txtlapis4fr.Text) & "'" &
                '            " , '" & .cChr(txtlapis4to.Text) & "'" &
                '            " , '" & .cChr(txtlapis4trf.Text) & "'" &
                '            " , '" & .cChr(txtlapis5fr.Text) & "'" &
                '            " , '" & .cChr(txtlapis5trf.Text) & "'" &
                '            " , '" & 1 & "'" &
                '            " , 'MODIF'" &
                '            " , '" & idmaster & "'" &
                '            "")
                '        .closeTrans(btnsave)
                '        If .sCloseTrans = 1 Then
                '            .msgInform("Success Update : " & txtlapis1fr.Text & " !", "Information")
                '            changestatform("BARU") : End If
                '    End If
                'End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mpasal21
        cekform(frm, "REFRESH", Me)
    End Sub

    'Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
    '    Dim a As New search

    '    Dim sql As String = " SELECT TA.* FROM msales TA WHERE TA.tstatus = 1"

    '    With a.dgview : .DataSource = cl.table(sql)
    '        For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
    '        .Columns("jabatan").Visible = True : .Columns("jabatan").HeaderText = "Jabatan"
    '        .Columns("jabatanpcg").Visible = True : .Columns("jabatanpcg").HeaderText = "Jabatan Persen"
    '        .Columns("pensiun").Visible = True : .Columns("pensiun").HeaderText = "Pensiun"
    '        .Columns("pensiunpcg").Visible = True : .Columns("pensiunpcg").HeaderText = "Pensiun Persen"
    '    End With
    '    'a.loadStatusTempForm(Me, Me.txtcode, Me.txtcode, "[mpenghasil]mpenghasil")
    '    a.loadSQLSearch(sql, 1)
    '    a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

    '    cekform(a, "SEARCH", Me)
    'End Sub

    'Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
    '    With cl
    '        '----------USER AUTHORIZATION CHECK--------------'
    '        If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mbyjbtn'") = "N" Then
    '            .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
    '            Exit Sub
    '        End If
    '        '---------------------END------------------------'
    '        Dim tny As Integer
    '        tny = .msgYesNo("Delete Data : " & txtnama.Text & " ?", "Confirmation")
    '        If tny = vbYes Then
    '            .openTrans()
    '            .execCmdTrans(
    '                    "EXEC mbyjbtn" &
    '                    "  ''" &
    '                    " , ''" &
    '                    " , ''" &
    '                    " , ''" &
    '                    " , '" & 1 & "'" &
    '                    " , 'HAPUS'" &
    '                    " , '" & idmaster & "'" &
    '                    "")
    '            .closeTrans(btnsave)
    '            If .sCloseTrans = 1 Then
    '                .msgInform("Success Delete Data : " & txtnama.Text & " !", "Information")
    '                changestatform("BARU") : End If
    '        End If
    '    End With
    'End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub
End Class