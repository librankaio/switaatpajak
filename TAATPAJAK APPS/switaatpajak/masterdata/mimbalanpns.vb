Imports System.IO
Public Class mimbalanpns
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
        txtgol1.Text = cl.readData("SELECT gol1 FROM mimbalanpns")
        txtgol2.Text = cl.readData("SELECT gol2 FROM mimbalanpns")
        txtgol3.Text = cl.readData("SELECT gol3 FROM mimbalanpns")
        txtgol4.Text = cl.readData("SELECT gol4 FROM mimbalanpns")
    End Sub
    Private Sub clearData()
        txtgol1.Text = 0
        txtgol2.Text = 0
        txtgol3.Text = 0
        txtgol4.Text = 0

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtgol1.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtgol1.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtgol1, "Data Imbalan Golongan Masih Kosong!", "Warning Information") = 1 Then : Exit Sub : End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mimbalanpns'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '-------------Validate gol1----------------------
                If .readData("SELECT * FROM mimbalanpns WHERE gol1 = '" & txtgol1.Text & "' AND stat = '1'") Then
                    .msgError("Data yang dimasukkan sudah ada!", "Informasi")
                    Exit Sub
                End If

                '-------------Validate gol2----------------------
                If .readData("SELECT * FROM mimbalanpns WHERE gol2 = '" & txtgol2.Text & "' AND stat = '1'") Then
                    .msgError("Data yang dimasukkan sudah ada!", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update Data Imbalan PNS ?", "Confirmation")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "UPDATE mimbalanpns SET" &
                        " gol1 = '" & .cChr(txtgol1.Text) & "'" &
                        " , gol2 = '" & .cChr(txtgol2.Text) & "'" &
                        " , gol3 = '" & .cChr(txtgol3.Text) & "'" &
                        " , gol4 = '" & .cChr(txtgol4.Text) & "'")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Success Update Data Imbalan PNS !", "Information")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mimbalanpns
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