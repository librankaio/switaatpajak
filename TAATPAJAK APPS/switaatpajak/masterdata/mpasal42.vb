Imports System.IO
Public Class mpasal42
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
        txtundian.Text = cl.readData("SELECT undian FROM tsettingtarifpphmasa")
        txtbungadepo.Text = cl.readData("SELECT bungadepo FROM tsettingtarifpphmasa")
        txtshmpendiri.Text = cl.readData("SELECT shmpendiri FROM tsettingtarifpphmasa")
        txtbknshmpendiri.Text = cl.readData("SELECT bknshmpendiri FROM tsettingtarifpphmasa")
        txtsewatanah.Text = cl.readData("SELECT sewatanah FROM tsettingtarifpphmasa")
        txtjasausahakcl.Text = cl.readData("SELECT jasausahakcl FROM tsettingtarifpphmasa")
        txtpnydiatdkusaha.Text = cl.readData("SELECT tdkusaha FROM tsettingtarifpphmasa")
        txtjasalainnya.Text = cl.readData("SELECT jasalainnya FROM tsettingtarifpphmasa")
        txtjasausaha.Text = cl.readData("SELECT jasausaha FROM tsettingtarifpphmasa")
        txttidakusaha.Text = cl.readData("SELECT tidakusaha FROM tsettingtarifpphmasa")
        txtbungadiskon.Text = cl.readData("SELECT bungadiskon FROM tsettingtarifpphmasa")
        txtsimpankoperasi.Text = cl.readData("SELECT simpankoperasi FROM tsettingtarifpphmasa")
        txtderivatif.Text = cl.readData("SELECT derivatif FROM tsettingtarifpphmasa")
        txtdividen.Text = cl.readData("SELECT dividen FROM tsettingtarifpphmasa")

    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtbknshmpendiri.Select()
    End Sub
    Private Sub cleardata()
        txtbknshmpendiri.Text = 0
        txtbungadepo.Text = 0
        txtbungadiskon.Text = 0
        txtderivatif.Text = 0
        txtdividen.Text = 0
        txtjasalainnya.Text = 0
        txtjasausaha.Text = 0
        txtjasausahakcl.Text = 0
        txtsewatanah.Text = 0
        txtshmpendiri.Text = 0
        txtsimpankoperasi.Text = 0
        txtpnydiatdkusaha.Text = 0
        txttidakusaha.Text = 0
        txtundian.Text = 0
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            cleardata()
            loaddata()
            btnsave.Text = "Save"

        End If
        Me.Select() : txtbknshmpendiri.Select()
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New mpasal42
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
                .execCmdTrans(
                    "UPDATE tsettingtarifpphmasa SET" &
                    "  undian = '" & .cNum(txtundian.Text) & "'" &
                    " , bungadepo = '" & .cNum(txtbungadepo.Text) & "'" &
                    " , shmpendiri = '" & .cNum(txtshmpendiri.Text) & "'" &
                    " , bknshmpendiri = '" & .cNum(txtbknshmpendiri.Text) & "'" &
                    " , sewatanah = '" & .cNum(txtsewatanah.Text) & "'" &
                    " , jasausahakcl = '" & .cNum(txtjasausahakcl.Text) & "'" &
                    " , tdkusaha = '" & .cNum(txtpnydiatdkusaha.Text) & "'" &
                    " , jasalainnya = '" & .cNum(txtjasalainnya.Text) & "'" &
                    " , jasausaha = '" & .cNum(txtjasausaha.Text) & "'" &
                    " , tidakusaha = '" & .cNum(txttidakusaha.Text) & "'" &
                    " , bungadiskon =  '" & .cNum(txtbungadiskon.Text) & "'" &
                    " , simpankoperasi =  '" & .cNum(txtsimpankoperasi.Text) & "'" &
                    " , derivatif =  '" & .cNum(txtderivatif.Text) & "'" &
                    " , dividen =  '" & .cNum(txtdividen.Text) & "'")

                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Simpan Update Setting Tarif Masa !", "Informasi")
                End If
            End If
        End With
    End Sub
End Class