Imports System.IO
Public Class tdaftarpph42bunga
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
            'ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F2) Then
            '    btnrefresh.PerformClick()
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
        txtdlmnegri11.Text = cl.cCur(cl.readData("SELECT dlmnegri11 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtdlmnegri12.Text = cl.cCur(cl.readData("SELECT dlmnegri12 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtdlmnegri13.Text = cl.cCur(cl.readData("SELECT dlmnegri13 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtluarnegri21.Text = cl.cCur(cl.readData("SELECT luarnegri21 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtluarnegri22.Text = cl.cCur(cl.readData("SELECT luarnegri22 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtluarnegri23.Text = cl.cCur(cl.readData("SELECT luarnegri23 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtdiskontobi31.Text = cl.cCur(cl.readData("SELECT diskontobi31 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtdiskontobi32.Text = cl.cCur(cl.readData("SELECT diskontobi32 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtdiskontobi33.Text = cl.cCur(cl.readData("SELECT diskontobi33 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtjasagiro41.Text = cl.cCur(cl.readData("SELECT jasagiro41 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtjasagiro42.Text = cl.cCur(cl.readData("SELECT jasagiro42 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtjasagiro43.Text = cl.cCur(cl.readData("SELECT jasagiro43 FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))

        txtjmlnasabah.Text = cl.cCur(cl.readData("SELECT jmlnasabah FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtjmlnilaiobj.Text = cl.cCur(cl.readData("SELECT jmlnilaiobj FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtjmlpph.Text = cl.cCur(cl.readData("SELECT pphdiptg FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))

        Label3.Text = masapjk & " - " & cl.cChr(thnpjk)
        Label6.Text = "0"
    End Sub

    Private Sub clearData()
        txtdlmnegri11.Text = 0
        txtdlmnegri12.Text = 0
        txtdlmnegri13.Text = 0
        txtluarnegri21.Text = 0
        txtluarnegri22.Text = 0
        txtluarnegri23.Text = 0
        txtdiskontobi31.Text = 0
        txtdiskontobi32.Text = 0
        txtdiskontobi33.Text = 0
        txtjasagiro41.Text = 0
        txtjasagiro42.Text = 0
        txtjasagiro43.Text = 0
        txtjmlnasabah.Text = 0
        txtjmlnilaiobj.Text = 0
        txtjmlpph.Text = 0

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtdlmnegri11.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtdlmnegri11.Select()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl
            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tdaftarbiaya'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If

                If cl.readData("SELECT COUNT(id) FROM tdaftarpph42bunga WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'") = 0 Then
                    Dim tny As Integer
                    tny = .msgYesNo("Simpan Data Daftar PPh 4(2) Bunga ?", "Konfirmasi")
                    If tny = vbYes Then
                        .openTrans()
                        .execCmdTrans(
                        "INSERT INTO tdaftarpph42bunga (dlmnegri11, dlmnegri12, dlmnegri13, luarnegri21, luarnegri22, luarnegri23, diskontobi31, diskontobi32, " &
                        " diskontobi33, jasagiro41, jasagiro42, jasagiro43, jmlnasabah, jmlnilaiobj, pphdiptg, masapjk, thnpjk) VALUES " &
                        " ( '" & .cNum(txtdlmnegri11.Text) & "'" &
                        " , '" & .cNum(txtdlmnegri12.Text) & "'" &
                        " , '" & .cNum(txtdlmnegri13.Text) & "'" &
                        " ,  '" & .cNum(txtluarnegri21.Text) & "'" &
                        " , '" & .cNum(txtluarnegri22.Text) & "'" &
                        " ,   '" & .cNum(txtluarnegri23.Text) & "'" &
                        " ,  '" & .cNum(txtdiskontobi31.Text) & "'" &
                        " ,  '" & .cNum(txtdiskontobi32.Text) & "'" &
                        " ,  '" & .cNum(txtdiskontobi33.Text) & "'" &
                        " ,   '" & .cNum(txtjasagiro41.Text) & "'" &
                        " ,   '" & .cNum(txtjasagiro42.Text) & "'" &
                        " ,   '" & .cNum(txtjasagiro43.Text) & "'" &
                        " ,  '" & .cNum(txtjmlnasabah.Text) & "'" &
                        " ,  '" & .cNum(txtjmlnilaiobj.Text) & "'" &
                        " ,   '" & .cNum(txtjmlpph.Text) & "', '" & masapjk & "', '" & thnpjk & "')")

                        .closeTrans(btnsave)
                        If .sCloseTrans = 1 Then
                            .msgInform("Berhasil Update Data Biaya Jabatan !", "Informasi")
                            changestatform("new") : End If
                    End If
                Else
                    Dim tny As Integer
                    tny = .msgYesNo("Update Data Daftar Biaya ?", "Confirmation")
                    If tny = vbYes Then
                        .openTrans()
                        .execCmdTrans(
                        "UPDATE tdaftarpph42bunga  SET" &
                        " dlmnegri11 = '" & .cNum(txtdlmnegri11.Text) & "'" &
                        " , dlmnegri12 = '" & .cNum(txtdlmnegri12.Text) & "'" &
                        " , dlmnegri13 =  '" & .cNum(txtdlmnegri13.Text) & "'" &
                        " , luarnegri21 = '" & .cNum(txtluarnegri21.Text) & "'" &
                        " , luarnegri22 = '" & .cNum(txtluarnegri22.Text) & "'" &
                        " , luarnegri23 =  '" & .cNum(txtluarnegri23.Text) & "'" &
                        " , diskontobi31 =  '" & .cNum(txtdiskontobi31.Text) & "'" &
                        " , diskontobi32 = '" & .cNum(txtdiskontobi32.Text) & "'" &
                        " , diskontobi33 = '" & .cNum(txtdiskontobi33.Text) & "'" &
                        " , jasagiro41 =  '" & .cNum(txtjasagiro41.Text) & "'" &
                        " , jasagiro42 =  '" & .cNum(txtjasagiro42.Text) & "'" &
                        " , jasagiro43 =  '" & .cNum(txtjasagiro43.Text) & "'" &
                        " , jmlnasabah = '" & .cNum(txtjmlnasabah.Text) & "'" &
                        " , jmlnilaiobj = '" & .cNum(txtjmlnilaiobj.Text) & "'" &
                        " , pphdiptg =  '" & .cNum(txtjmlpph.Text) & "' WHERE masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")

                        .closeTrans(btnsave)
                        If .sCloseTrans = 1 Then
                            .msgInform("Berhasil Update Data Biaya Jabatan !", "Informasi")
                            changestatform("new") : End If
                    End If
                End If

            End If
        End With
    End Sub

    Private Sub sumnasabah()
        Dim sumnas As Decimal
        sumnas = cl.cNum(txtdlmnegri11.Text) + cl.cNum(txtluarnegri21.Text) + cl.cNum(txtdiskontobi31.Text) + cl.cNum(txtjasagiro41.Text)
        txtjmlnasabah.Text = cl.cCur(sumnas)
    End Sub
    Private Sub sumnlobj()
        Dim sumobj As Decimal
        sumobj = cl.cNum(txtdlmnegri12.Text) + cl.cNum(txtluarnegri22.Text) + cl.cNum(txtdiskontobi32.Text) + cl.cNum(txtjasagiro42.Text)
        txtjmlnilaiobj.Text = cl.cCur(sumobj)
    End Sub
    Private Sub sumpph()
        Dim sumpphd As Decimal
        sumpphd = cl.cNum(txtdlmnegri13.Text) + cl.cNum(txtluarnegri23.Text) + cl.cNum(txtdiskontobi33.Text) + cl.cNum(txtjasagiro43.Text)
        txtjmlpph.Text = cl.cCur(sumpphd)
    End Sub

    Private Sub txtdlmnegri11_TextChanged(sender As Object, e As EventArgs) Handles txtdlmnegri11.TextChanged
        sumnasabah()
    End Sub

    Private Sub txtluarnegri21_TextChanged(sender As Object, e As EventArgs) Handles txtluarnegri21.TextChanged
        sumnasabah()
    End Sub

    Private Sub txtdiskontobi31_TextChanged(sender As Object, e As EventArgs) Handles txtdiskontobi31.TextChanged
        sumnasabah()
    End Sub

    Private Sub txtdlmnegri12_TextChanged(sender As Object, e As EventArgs) Handles txtdlmnegri12.TextChanged
        sumnlobj()
    End Sub

    Private Sub txtluarnegri22_TextChanged(sender As Object, e As EventArgs) Handles txtluarnegri22.TextChanged
        sumnlobj()
    End Sub

    Private Sub txtdiskontobi32_TextChanged(sender As Object, e As EventArgs) Handles txtdiskontobi32.TextChanged
        sumnlobj()
    End Sub

    Private Sub txtjasagiro42_TextChanged(sender As Object, e As EventArgs) Handles txtjasagiro42.TextChanged
        sumnlobj()
    End Sub

    Private Sub txtdlmnegri13_TextChanged(sender As Object, e As EventArgs) Handles txtdlmnegri13.TextChanged
        sumpph()
    End Sub

    Private Sub txtluarnegri23_TextChanged(sender As Object, e As EventArgs) Handles txtluarnegri23.TextChanged
        sumpph()
    End Sub

    Private Sub txtdiskontobi33_TextChanged(sender As Object, e As EventArgs) Handles txtdiskontobi33.TextChanged
        sumpph()
    End Sub

    Private Sub txtjasagiro43_TextChanged(sender As Object, e As EventArgs) Handles txtjasagiro43.TextChanged
        sumpph()
    End Sub

    Private Sub txtjasagiro41_TextChanged(sender As Object, e As EventArgs) Handles txtjasagiro41.TextChanged
        sumnasabah()
    End Sub
End Class