Imports System.IO
Public Class mpasal23
    Dim idmaster As Integer = 0, statform As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
        ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            btncancel.PerformClick()
            '-----------------------------------------------------------------------
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then

        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F2) Then

        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F3) Then

        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then

        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Private Sub loaddata()
        txtdividen.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Dividen'")
        txtbunga.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Bunga'")
        txtroyalti.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Royalti'")
        txthadiah.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Hadiah'")
        txtsewa.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Sewa'")
        txtjasa.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Jasa'")
        txtjteknik.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Jteknik'")
        txtjmanaj.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Jmanaj'")
        txtjkonsul.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Jkonsul'")
        txtjlain.Text = cl.readData("SELECT tariff FROM mpasal23 where dsc = 'Jlain'")

    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtdividen.Select()
    End Sub
    Private Sub cleardata()
        txtdividen.Text = 0
        txtbunga.Text = 0
        txtroyalti.Text = 0
        txthadiah.Text = 0
        txtsewa.Text = 0
        txtjasa.Text = 0
        txtjteknik.Text = 0
        txtjmanaj.Text = 0
        txtjkonsul.Text = 0
        txtjlain.Text = 0
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            cleardata()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtdividen.Select()
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mpasal23
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl
            Dim tny As Integer
            tny = .msgYesNo("Update Setting Tarif PPh Masa", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                ' -- DIVIDEN
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtdividen.Text) & "'" &
                    "  WHERE dsc = 'Dividen'")
                ' -- BUNGA
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtbunga.Text) & "'" &
                    "  WHERE dsc = 'Bunga'")
                ' -- ROYALTI
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtroyalti.Text) & "'" &
                    "  WHERE dsc = 'Royalti'")
                ' -- HADIAH
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txthadiah.Text) & "'" &
                    "  WHERE dsc = 'Hadiah'")
                ' -- SEWA
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtsewa.Text) & "'" &
                    "  WHERE dsc = 'Sewa'")
                ' -- JASA
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtjasa.Text) & "'" &
                    "  WHERE dsc = 'Jasa'")
                ' -- JTEKNIK
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtjteknik.Text) & "'" &
                    "  WHERE dsc = 'Jteknik'")
                ' -- JMANAJ
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtjmanaj.Text) & "'" &
                    "  WHERE dsc = 'Jmanaj'")
                ' -- JKONSUL
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtjkonsul.Text) & "'" &
                    "  WHERE dsc = 'Jkonsul'")
                ' -- JLAIN
                .execCmdTrans(
                    "UPDATE mpasal23 SET" &
                    "  tariff = '" & .cNum(txtjlain.Text) & "'" &
                    "  WHERE dsc = 'Jlain'")

                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Simpan Update Setting Tarif Masa !", "Informasi")
                End If
            End If
        End With
    End Sub
End Class