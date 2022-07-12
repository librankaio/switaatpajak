Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class tdaftarbiaya
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
        Label4.Text = masapjk & " " & thnpjk
        Label5.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")

        txtgajiupah.Text = cl.readData("SELECT gajiupah FROM tdaftarbiaya")
        txttransport.Text = cl.readData("SELECT transport FROM tdaftarbiaya")
        txtbiayapenyusutan.Text = cl.readData("SELECT biayapenyusutan FROM tdaftarbiaya")
        txtbiayasewa.Text = cl.readData("SELECT biayasewa FROM tdaftarbiaya")
        txtbiayabunga.Text = cl.readData("SELECT biayabunga FROM tdaftarbiaya")
        txtbiayasehubungan.Text = cl.readData("SELECT biayasehubungan FROM tdaftarbiaya")
        txtbiayapiutang.Text = cl.readData("SELECT biayapiutang FROM tdaftarbiaya")
        txtroyalti.Text = cl.readData("SELECT royalti FROM tdaftarbiaya")
        txtpemasaran.Text = cl.readData("SELECT pemasaran FROM tdaftarbiaya")
        txtbiayalain.Text = cl.readData("SELECT biayalain FROM tdaftarbiaya")
        txttotal.Text = cl.readData("SELECT total FROM tdaftarbiaya")
    End Sub

    Private Sub clearData()
        txtgajiupah.Text = 0
        txttransport.Text = 0
        txtbiayapenyusutan.Text = 0
        txtbiayasewa.Text = 0
        txtbiayabunga.Text = 0
        txtbiayasehubungan.Text = 0
        txtbiayapiutang.Text = 0
        txtroyalti.Text = 0
        txtpemasaran.Text = 0
        txtbiayalain.Text = 0
        txttotal.Text = 0

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtgajiupah.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtgajiupah.Select()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tdaftarbiaya'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If

                Dim tny As Integer
                tny = .msgYesNo("Update Data Daftar Biaya ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "UPDATE tdaftarbiaya  SET" &
                        " gajiupah = '" & .cNum(txtgajiupah.Text) & "'" &
                        " , transport = '" & .cNum(txttransport.Text) & "'" &
                        " , biayapenyusutan =  '" & .cNum(txtbiayapenyusutan.Text) & "'" &
                        " ,  biayasewa = '" & .cNum(txtbiayasewa.Text) & "'" &
                        " , biayabunga = '" & .cNum(txtbiayabunga.Text) & "'" &
                        " , biayasehubungan =  '" & .cNum(txtbiayasehubungan.Text) & "'" &
                        " , biayapiutang =  '" & .cNum(txtbiayapiutang.Text) & "'" &
                        " ,  royalti = '" & .cNum(txtroyalti.Text) & "'" &
                        " , pemasaran = '" & .cNum(txtpemasaran.Text) & "'" &
                        " , biayalain =  '" & .cNum(txtbiayalain.Text) & "'" &
                        " , total =  '" & .cNum(txttotal.Text) & "'")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update Data Biaya Jabatan !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Dim frm As New tdaftarbiaya
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub getcalculate()
        Dim total As Decimal
        total = cl.cNum(txtgajiupah.Text) + cl.cNum(txttransport.Text) + cl.cNum(txtbiayapenyusutan.Text) + cl.cNum(txtbiayasewa.Text) + cl.cNum(txtbiayabunga.Text) + cl.cNum(txtbiayasehubungan.Text) +
            cl.cNum(txtbiayapiutang.Text) + cl.cNum(txtroyalti.Text) + cl.cNum(txtpemasaran.Text) + cl.cNum(txtbiayalain.Text)
        txttotal.Text = cl.cCur(total)
    End Sub

    Private Sub txtgajiupah_TextChanged(sender As Object, e As EventArgs) Handles txtgajiupah.TextChanged
        getcalculate()
    End Sub

    Private Sub txttransport_TextChanged(sender As Object, e As EventArgs) Handles txttransport.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayapenyusutan_TextChanged(sender As Object, e As EventArgs) Handles txtbiayapenyusutan.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayasewa_TextChanged(sender As Object, e As EventArgs) Handles txtbiayasewa.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayabunga_TextChanged(sender As Object, e As EventArgs) Handles txtbiayabunga.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayasehubungan_TextChanged(sender As Object, e As EventArgs) Handles txtbiayasehubungan.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayapiutang_TextChanged(sender As Object, e As EventArgs) Handles txtbiayapiutang.TextChanged
        getcalculate()
    End Sub

    Private Sub txtroyalti_TextChanged(sender As Object, e As EventArgs) Handles txtroyalti.TextChanged
        getcalculate()
    End Sub

    Private Sub txtpemasaran_TextChanged(sender As Object, e As EventArgs) Handles txtpemasaran.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbiayalain_TextChanged(sender As Object, e As EventArgs) Handles txtbiayalain.TextChanged
        getcalculate()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            '------PRINT INVOICE
            '  MsgBox(idmaster)
            Dim rpt As New ReportDocument
            Dim f As New rprt
            rpt = New Daftar_Biaya
            f.crviewer.ReportSource = rpt
            cekform(f, "NEW", Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class