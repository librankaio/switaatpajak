Imports System.IO
Imports System.Drawing.Printing
Public Class caccount
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
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub clearData()
        'AKUN DEFAULT MATA UANG
        txtAH.Text = ""
        txtAP.Text = ""
        txtUMP.Text = ""
        txtUMJ.Text = ""
        txtDP.Text = ""
        txtLRT.Text = ""
        txtLRTT.Text = ""
        txtPP.Text = ""
        txtPB.Text = ""

        txtPCA.Text = ""
        txtPBA.Text = ""
        txtCS.Text = ""

        lblAH.Text = 0
        lblAP.Text = 0
        lblUMP.Text = 0
        lblUMJ.Text = 0
        lblDP.Text = 0
        lblLRT.Text = 0
        lblLRTT.Text = 0
        lblPP.Text = 0
        lblPB.Text = 0

        lblPCA.Text = 0
        lblPBA.Text = 0
        lblCS.Text = 0

        'AKUN DEFAULT PERSEDIAAN
        txtPR.Text = ""
        txtPJ.Text = ""
        txtRP.Text = ""
        txtDK.Text = ""
        txtBK.Text = ""
        txtHPP.Text = ""
        txtRPB.Text = ""
        txtBT.Text = ""
        txtCS.Text = ""

        lblPR.Text = 0
        lblPJ.Text = 0
        lblRP.Text = 0
        lblDK.Text = 0
        lblBK.Text = 0
        lblHPP.Text = 0
        lblRPB.Text = 0
        lblBT.Text = 0


    End Sub

    Private Sub loadData()
        With cl

            'AKUN DEFAULT MATA UANG
            txtAH.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'AH'"))
            txtAP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'AP'"))
            txtUMP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'UMP'"))
            txtUMJ.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'UMJ'"))
            txtDP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'DP'"))
            txtLRT.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'LRT'"))
            txtLRTT.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'LRTT'"))
            txtPP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PP'"))
            txtPB.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PB'"))

            txtPCA.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PCA'"))
            txtPBA.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PBA'"))
            txtCS.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'CS'"))

            lblAH.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'AH'"))
            lblAP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'AP'"))
            lblUMP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'UMP'"))
            lblUMJ.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'UMJ'"))
            lblDP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'DP'"))
            lblLRT.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'LRT'"))
            lblLRTT.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'LRTT'"))
            lblPP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'PP'"))
            lblPB.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'PB'"))

            lblPCA.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'PCA'"))
            lblPBA.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'PBA'"))

            lblCS.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'CS'"))

            'AKUN DEFAULT PERSEDIAAN
            txtPR.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PR'"))
            txtPJ.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'PJ'"))
            txtRP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'RP'"))
            txtDK.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'DK'"))
            txtBK.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'BK'"))
            txtHPP.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'HPP'"))
            txtRPB.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'RPB'"))
            txtBT.Text = .cChr(.readData("SELECT strvl FROM caccount WHERE name = 'BT'"))

            lblPR.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'RP'"))
            lblPJ.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'PJ'"))
            lblRP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'RP'"))
            lblDK.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'DK'"))
            lblBK.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'BK'"))
            lblHPP.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'HPP'"))
            lblRPB.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'RPB'"))
            lblBT.Text = .cNum(.readData("SELECT intvl FROM caccount WHERE name = 'BT'"))
        End With
    End Sub

    Private Sub csetting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl
            '------ start validasi
            'If .ValidateTxtNull(txtcompany, "Nama Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .ValidateTxtNull(txtalamat, "Alamat Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .validatetxtnull(txtowner, "Owner Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            '' If validatetxtnull(txtphone, "Telpon Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            ''If validatetxtnull(txtfax, "Fax Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .ValidateTxtNull(txtNPWP, "NPWP Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If

            Dim tny As Integer
            tny = .msgYesNo("Update setting akun ?", "Information")
            If tny = vbYes Then
                .openTrans()

                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtAH.Text) & "' WHERE name = 'AH'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtAP.Text) & "' WHERE name = 'AP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtUMP.Text) & "' WHERE name = 'UMP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtUMJ.Text) & "' WHERE name = 'UMJ'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtDP.Text) & "' WHERE name = 'DP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtLRT.Text) & "' WHERE name = 'LRT'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtLRTT.Text) & "' WHERE name = 'LRTT'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPP.Text) & "' WHERE name = 'PP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPB.Text) & "' WHERE name = 'PB'")

                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPCA.Text) & "' WHERE name = 'PCA'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPBA.Text) & "' WHERE name = 'PBA'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtCS.Text) & "' WHERE name = 'CS'")

                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblAH.Text) & "' WHERE name = 'AH'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblAP.Text) & "' WHERE name = 'AP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblUMP.Text) & "' WHERE name = 'UMP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblUMJ.Text) & "' WHERE name = 'UMJ'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblDP.Text) & "' WHERE name = 'DP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblLRT.Text) & "' WHERE name = 'LRT'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblLRTT.Text) & "' WHERE name = 'LRTT'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPP.Text) & "' WHERE name = 'PP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPB.Text) & "' WHERE name = 'PB'")

                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPCA.Text) & "' WHERE name = 'PCA'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPBA.Text) & "' WHERE name = 'PBA'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblCS.Text) & "' WHERE name = 'CS'")


                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPR.Text) & "' WHERE name = 'PR'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtPJ.Text) & "' WHERE name = 'PJ'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtRP.Text) & "' WHERE name = 'RP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtDK.Text) & "' WHERE name = 'DK'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtBK.Text) & "' WHERE name = 'BK'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtHPP.Text) & "' WHERE name = 'HPP'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtRPB.Text) & "' WHERE name = 'RPB'")
                .execCmdTrans("UPDATE caccount SET strvl = '" & .cChr(txtBT.Text) & "' WHERE name = 'BT'")

                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPR.Text) & "' WHERE name = 'PR'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblPJ.Text) & "' WHERE name = 'PJ'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblRP.Text) & "' WHERE name = 'RP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblDK.Text) & "' WHERE name = 'DK'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblBK.Text) & "' WHERE name = 'BK'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblHPP.Text) & "' WHERE name = 'HPP'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblRPB.Text) & "' WHERE name = 'RPB'")
                .execCmdTrans("UPDATE caccount SET intvl = '" & .cChr(lblBT.Text) & "' WHERE name = 'BT'")

                .closeTrans(btnsave)

                If .sCloseTrans = 1 Then
                    .msgInform("Sukses update setting akun, closing all open windows !", "Informasi")
                    '    .msgInform("Sistem akan lakukan otomatis restart !", "Informasi")
                    For Each child As Form In Me.MdiChildren
                        child.Close()
                    Next child
                End If
            End If

        End With
    End Sub
    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Dim frm As New caccount
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnPR_Click(sender As Object, e As EventArgs) Handles btnPR.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtPR, "[mcoapr]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnPJ_Click(sender As Object, e As EventArgs) Handles btnPJ.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtPJ, "[mcoapj]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnRP_Click(sender As Object, e As EventArgs) Handles btnRP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtRP, "[mcoarp]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnDK_Click(sender As Object, e As EventArgs) Handles btnDK.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtDK, "[mcoadk]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnBK_Click(sender As Object, e As EventArgs) Handles btnBK.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtBK, "[mcoabk]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnHPP_Click(sender As Object, e As EventArgs) Handles btnHPP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtHPP, "[mcoahpp]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnRPB_Click(sender As Object, e As EventArgs) Handles btnRPB.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtRPB, "[mcoarpb]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnBT_Click(sender As Object, e As EventArgs) Handles btnBT.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtBT, "[mcoabt]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnAH_Click(sender As Object, e As EventArgs) Handles btnAH.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtAH, "[mcoaah]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnAP_Click(sender As Object, e As EventArgs) Handles btnAP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtAP, "[mcoaap]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnUMP_Click(sender As Object, e As EventArgs) Handles btnUMP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtUMP, "[mcoaump]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnUMJ_Click(sender As Object, e As EventArgs) Handles btnUMJ.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtUMJ, "[mcoaumj]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnDP_Click(sender As Object, e As EventArgs) Handles btnDP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtDP, "[mcoadp]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnLRT_Click(sender As Object, e As EventArgs) Handles btnLRT.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtLRT, "[mcoalrt]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnLRTT_Click(sender As Object, e As EventArgs) Handles btnLRTT.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtLRTT, "[mcoalrtt]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnPP_Click(sender As Object, e As EventArgs) Handles btnPP.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtPP, "[mcoapp]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnPB_Click(sender As Object, e As EventArgs) Handles btnPB.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtPB, "[mcoapb]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnPCA_Click(sender As Object, e As EventArgs) Handles btnPCA.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtAH, "[mcoapca]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnPBA_Click(sender As Object, e As EventArgs) Handles btnPBA.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtAH, "[mcoapba]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnCS_Click(sender As Object, e As EventArgs) Handles btnCS.Click
        Dim a As New search
        Dim sqlStr As String =
            "SELECT id, code, name FROM mcoa WHERE stat = 1 and active = 'Y'"

        With a.dgview : .DataSource = cl.table(sqlStr & " ORDER BY code ASC")
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With

        a.loadStatusTempForm(Me, Me.txtCS, "[mcoacs]caccount")
        a.loadSQLSearch(sqlStr, 1)
        a.Text = "Pencarian : Chart of Accounts"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub

End Class