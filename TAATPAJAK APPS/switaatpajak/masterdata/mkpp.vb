Imports System.IO
Public Class mkpp
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
        txtkode.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
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
        Me.Select() : txtkode.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtkode.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtkode, "Kode KPP Masih Kosong!", "Warning Information") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtnama, "Nama Masih Kosong!", "Warning Information") = 1 Then : Exit Sub : End If
            If validatetxtnull(txtalamat, "Alamat Masih Kosong!", "Warning Information") = 1 Then : Exit Sub : End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mkpp'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '-------------Validate kode----------------------
                If .readData("SELECT * FROM mkpp WHERE kode = '" & txtkode.Text & "' AND stat = '1'") Then
                    .msgError("Data yang dimasukkan sudah ada!", "Informasi")
                    Exit Sub
                End If

                '-------------Validate nama----------------------
                If .readData("SELECT * FROM mkpp WHERE nama = '" & txtnama.Text & "' AND stat = '1'") Then
                    .msgError("Data yang dimasukkan sudah ada!", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtkode.Text & " ?", "Confirmation")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smkpp (" &
                        " '" & .cChr(txtkode.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Success Save : " & txtkode.Text & " !", "Information")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mkpp'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtkode.Text & " ?", "Confirmation")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL smkpp (" &
                        " '" & .cChr(txtkode.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Success Update : " & txtkode.Text & " !", "Information")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mkpp
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mkpp TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("kode").Visible = True : .Columns("kode").HeaderText = "Kode"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
        End With
        a.loadStatusTempForm(Me, Me.txtkode, "[mkpp]mkpp")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'mkpp'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Delete Data : " & txtkode.Text & " ?", "Confirmation")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL smkpp (" &
                        " '" & .cChr(txtkode.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " , ''" &
                        " , '" & 1 & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Success Delete Data : " & txtkode.Text & " !", "Information")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub
    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
End Class