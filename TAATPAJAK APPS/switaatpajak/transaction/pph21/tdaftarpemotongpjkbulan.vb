Imports CrystalDecisions.CrystalReports.Engine
Public Class tdaftarpemotongpjkbulan
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
            'btnrefresh.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F3) Then
            '  btnlist.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
            '  If idmaster <> 0 And btnsave.Text <> "Save" Then : btndelete.PerformClick() : End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Private Sub initializedg()

        Dim cd As New DataGridViewCheckBoxColumn()
        dgview.Columns.Add(cd)
        cd.Name = "chooseData"
        dgview.Columns("chooseData").HeaderText = ""

        dgview.Columns("chooseData").Visible = True
        'deklarasi jumlah datagrid kolom
        dgview.ColumnCount = 8
        dgview.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview
            .Columns(1).Name = "npwp" : .Columns(1).HeaderText = "NPWP" : .Columns(1).ReadOnly = True
            .Columns(2).Name = "nama" : .Columns(2).HeaderText = "Nama" : .Columns(2).ReadOnly = True
            .Columns(3).Name = "kodepjk" : .Columns(3).HeaderText = "Kd Obj Pjk" : .Columns(3).ReadOnly = True
            .Columns(4).Name = "bruto" : .Columns(4).HeaderText = "Jml Penghasilan Bruto (Rp.)" : .Columns(4).ReadOnly = True
            .Columns(5).Name = "pphptg" : .Columns(5).HeaderText = "PPh Dipotong (Rp.)" : .Columns(5).ReadOnly = True
            .Columns(6).Name = "datein" : .Columns(6).HeaderText = "Tanggal " : .Columns(6).ReadOnly = True

            .Columns(7).Name = "id" : .Columns(7).Visible = False
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("chooseData").Width = 20
            .Columns("npwp").Width = 80
            .Columns("nama").Width = 120
            .Columns("kodepjk").Width = 60
            .Columns("bruto").Width = 80
            .Columns("pphptg").Width = 180
            .Columns("datein").Width = 80

            .Columns("bruto").DefaultCellStyle.Format = "n2"
            .Columns("pphptg").DefaultCellStyle.Format = "n2"


            .Columns("npwp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nama").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("kodepjk").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("bruto").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("pphptg").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("datein").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("chooseData").DefaultCellStyle.BackColor = Color.PaleGreen

        End With

    End Sub

    Private Sub tdaftarpemotongpjkbulan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cultureSet()
        ' -- Daten löschen
        Dim brutopgw As Decimal
        brutopgw = cl.readData("SELECT brutopegawai FROM tdaftarpemotongpjkbulan WHERE stat = 1")
        Dim brutopensi As Decimal
        brutopensi = cl.readData("SELECT brutopensiun FROM tdaftarpemotongpjkbulan WHERE stat = 1")

        txtjmbruto.Text = 0
        txtjmlpph.Text = 0
        txtjmlpegawai.Text = cl.readData("SELECT jmlpegawai FROM tdaftarpemotongpjkbulan WHERE stat = 1")
        txtjmlpensiun.Text = cl.readData("SELECT jmlpensiun FROM tdaftarpemotongpjkbulan WHERE stat = 1")
        txtbrutopegawai.Text = cl.cCur(brutopgw)
        txtbrutopensiun.Text = cl.cCur(brutopensi)
        txtjmlhslbruto.Text = 0
        txtjmlpphptg.Text = 0

        initializedg()
        loadPmotongPjkBlnTable()
        Label4.Text = masapjk & " " & thnpjk
        Label5.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")
        cmbkdobjpjk.SelectedIndex = 0

        loadPmotongPjkBlnTable()
        getcalculate()
    End Sub
    Public Sub loadPmotongPjkBlnTable()
        Dim dtdet As DataTable = Nothing
        dtdet = cl.table(
            "SELECT TA.* " &
            " FROM tinputdatapemotongpjk TA " &
            " WHERE TA.stat = 1 " &
            " AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "'")

        'LOAD MAIN DGVIEW
        dgview.Rows.Clear()
        Dim rrowpl As Integer = 0
        For r As Integer = 0 To dtdet.Rows.Count - 1
            rrowpl = dgview.Rows.Add
            With dtdet
                dgview.Rows(rrowpl).Cells("chooseData").Value = vbFalse
                dgview.Rows(rrowpl).Cells("id").Value = .Rows(r).Item("id")
                dgview.Rows(rrowpl).Cells("npwp").Value = .Rows(r).Item("npwp")
                dgview.Rows(rrowpl).Cells("nama").Value = .Rows(r).Item("nama")
                dgview.Rows(rrowpl).Cells("kodepjk").Value = .Rows(r).Item("kodepjk")
                dgview.Rows(rrowpl).Cells("bruto").Value = cl.cCur(.Rows(r).Item("bruto"))
                dgview.Rows(rrowpl).Cells("pphptg").Value = cl.cCur(.Rows(r).Item("pphptg"))
                dgview.Rows(rrowpl).Cells("datein").Value = .Rows(r).Item("datein")
            End With
        Next
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtnilai.Text = ""
        cmbkdobjpjk.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As New tinputdatapemotongpjk
        a.loadStatusTempForm(Me, Me.dgview, "")
        cekform(a, "SEARCH", Me)
    End Sub

    Public Sub getcalculate()
        Dim totalpph As Decimal
        Dim totalbruto As Decimal

        For a As Integer = 0 To dgview.Rows.Count - 1
            If cl.cNum(dgview.Rows(a).Cells("id").Value) <> 0 Then
                totalpph += cl.cNum(dgview.Rows(a).Cells("pphptg").Value)
                totalbruto += cl.cNum(dgview.Rows(a).Cells("bruto").Value)
            End If
        Next

        txtjmbruto.Text = cl.cCur(totalbruto)
        txtjmlpph.Text = cl.cCur(totalpph)

        txtjmlhslbruto.Text = cl.cCur(cl.cNum(txtjmbruto.Text) + cl.cNum(txtbrutopegawai.Text) + cl.cNum(txtbrutopensiun.Text))
        txtjmlpphptg.Text = cl.cNum(txtjmlpph.Text)
    End Sub

    Private Sub chpilih_CheckedChanged(sender As Object, e As EventArgs) Handles chpilih.CheckedChanged
        With dgview
            If chpilih.Checked = True Then
                For a As Integer = 0 To dgview.Rows.Count - 1
                    .Rows(a).Cells("chooseData").Value = vbTrue
                Next
            ElseIf chpilih.Checked = False Then
                For a As Integer = 0 To dgview.Rows.Count - 1
                    .Rows(a).Cells("chooseData").Value = vbFalse
                Next
            End If
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New tinputdatapemotongpjk
        a.loadStatusTempForm(Me, Me.dgview, "")
        cekform(a, "SEARCH", Me)

        Dim cmbnegara As DataTable = cl.table(
          "SELECT id AS 'value', concat(code,' - ',name) AS 'display' FROM mnegara WHERE stat = 1 ")

        Dim row As DataRow = cmbnegara.NewRow()
        row(0) = 0
        row(1) = "----PILIH NEGARA----"
        cmbnegara.Rows.InsertAt(row, 0)

        ' -- Daten hier laden

        '.Columns(1).Name = "npwp" : .Columns(1).HeaderText = "NPWP" : .Columns(1).ReadOnly = True
        '.Columns(2).Name = "nama" : .Columns(2).HeaderText = "Nama" : .Columns(2).ReadOnly = True
        '.Columns(3).Name = "kodepjk" : .Columns(3).HeaderText = "Kd Obj Pjk" : .Columns(3).ReadOnly = True
        '.Columns(4).Name = "bruto" : .Columns(4).HeaderText = "Jml Penghasilan Bruto (Rp.)" : .Columns(4).ReadOnly = True
        '.Columns(5).Name = "pphptg" : .Columns(5).HeaderText = "PPh Dipotong (Rp.)" : .Columns(5).ReadOnly = True
        '.Columns(6).Name = "datein" : .Columns(6).HeaderText = "Tanggal " : .Columns(6).ReadOnly = True

        '.Columns(7).Name = "id" : .Columns(7).Visible = False

        a.txtnpwp.Text = dgview.Item("npwp", dgview.CurrentRow.Index).Value
        a.txtnama.Text = dgview.Item("nama", dgview.CurrentRow.Index).Value
        a.cmbkodepjk.Text = dgview.Item("kodepjk", dgview.CurrentRow.Index).Value
        a.txtbruto.Text = dgview.Item("bruto", dgview.CurrentRow.Index).Value
        a.txtpphptg.Text = dgview.Item("pphptg", dgview.CurrentRow.Index).Value
        a.getidmaster(dgview.Item("id", dgview.CurrentRow.Index).Value)
        a.cmbkdnegara_rl.Text = cl.readData("Select kdnegara_rl AS 'value' from tinputdatapemotongpjk where npwp ='" & a.txtnpwp.Text & "' AND nama ='" & a.txtnama.Text & "'")
        Dim wpasing As String
        wpasing = cl.readData("Select wpasing from tinputdatapemotongpjk where npwp ='" & a.txtnpwp.Text & "' AND nama ='" & a.txtnama.Text & "'")
        If wpasing = "Y" Then
            a.chwpasing.Checked = True
        Else
            a.chwpasing.Checked = False
        End If
        a.txtkdnegara.Text = cl.readData("Select kdnegara from tinputdatapemotongpjk where npwp ='" & a.txtnpwp.Text & "' AND nama ='" & a.txtnama.Text & "'")
        'a.cmbkdnegara_rl.SelectedValue = cl.readData("Select kdnegara_rl from tinputdatapemotongpjk where npwp ='" & a.txtnpwp.Text & "' AND nama ='" & a.txtnama.Text & "'")
        ' a.txtkdnegara.Text = dgview.Item("datein", dgview.CurrentRow.Index).Value
        a.btnsave.Text = "Update"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputdatapemotongpjk'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stinputdatapemotongpjk (" &
                        " ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , '0'" &
                        " , ''" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data !", "Informasi")
                    loadPmotongPjkBlnTable()
                End If
            End If
        End With

        loadPmotongPjkBlnTable()
        getcalculate()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub txtbrutopegawai_TextChanged(sender As Object, e As EventArgs) Handles txtbrutopegawai.TextChanged
        getcalculate()
    End Sub

    Private Sub txtbrutopensiun_TextChanged(sender As Object, e As EventArgs) Handles txtbrutopensiun.TextChanged
        getcalculate()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            '------PRINT INVOICE
            '  MsgBox(idmaster)
            Dim rpt As New ReportDocument
            Dim f As New rprt
            rpt = New PPh_21_satubulan
            f.crviewer.ReportSource = rpt
            cekform(f, "NEW", Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick

    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            btnsave.Text = "Save"
            'gencode()
            initializedg()
            btnprint.Visible = False


        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"

        End If
        Me.Select() : txtjmlpegawai.Select()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtjmlpegawai, "Jumlah Pegawai Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgfinal'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & Label5.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    ' -- nilai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  nilai = '" & .cNum(txtnilai.Text) & "'")
                    ' -- jmbruto
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmbruto = '" & .cNum(txtjmbruto.Text) & "'")
                    ' -- jmlpph
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpph = '" & .cNum(txtjmlpph.Text) & "'")
                    ' -- jmlpegawai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpegawai = '" & .cNum(txtjmlpegawai.Text) & "'")
                    ' -- jmlpensiun
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpensiun = '" & .cNum(txtjmlpensiun.Text) & "'")
                    ' -- brutopegawai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  brutopegawai = '" & .cNum(txtbrutopegawai.Text) & "'")
                    ' -- brutopensiun
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  brutopensiun = '" & .cNum(txtbrutopensiun.Text) & "'")
                    ' -- jmlhslbruto
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlhslbruto = '" & .cNum(txtjmlhslbruto.Text) & "'")
                    ' -- jmlpphptg
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpphptg = '" & .cNum(txtjmlpphptg.Text) & "'")
                    '"CALL stdaftarpemotongpjkbulan (" &
                    '"  '" & .cChr(txtnilai.Text) & "'" &
                    '" ,'" & .cChr(txtjmbruto.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpph.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpegawai.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpensiun.Text) & "'" &
                    '" ,'" & .cChr(txtbrutopegawai.Text) & "'" &
                    '" ,'" & .cChr(txtbrutopensiun.Text) & "'" &
                    '" ,'" & .cChr(txtjmlhslbruto.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpphptg.Text) & "'" &
                    '" , ''" &
                    '" , '" & idusr & "'" &
                    '" , 'BARU'" &
                    '" , '0'" &
                    '")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kodepjk").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stinputdatapemotongpjkd (" &
                            "  '" & .cChr(Label5.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("npwp").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("nama").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kodepjk").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("bruto").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pphptg").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("datein").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'BARU'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & Label5.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgfinal'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & Label5.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    ' -- nilai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  nilai = '" & .cNum(txtnilai.Text) & "'")
                    ' -- jmbruto
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmbruto = '" & .cNum(txtjmbruto.Text) & "'")
                    ' -- jmlpph
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpph = '" & .cNum(txtjmlpph.Text) & "'")
                    ' -- jmlpegawai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpegawai = '" & .cNum(txtjmlpegawai.Text) & "'")
                    ' -- jmlpensiun
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpensiun = '" & .cNum(txtjmlpensiun.Text) & "'")
                    ' -- brutopegawai
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  brutopegawai = '" & .cNum(txtbrutopegawai.Text) & "'")
                    ' -- brutopensiun
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  brutopensiun = '" & .cNum(txtbrutopensiun.Text) & "'")
                    ' -- jmlhslbruto
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlhslbruto = '" & .cNum(txtjmlhslbruto.Text) & "'")
                    ' -- jmlpphptg
                    .execCmdTrans(
                    "UPDATE tdaftarpemotongpjkbulan SET" &
                    "  jmlpphptg = '" & .cNum(txtjmlpphptg.Text) & "'")
                    '"CALL stdaftarpemotongpjkbulan (" &
                    '"  '" & .cChr(txtnilai.Text) & "'" &
                    '" ,'" & .cChr(txtjmbruto.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpph.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpegawai.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpensiun.Text) & "'" &
                    '" ,'" & .cChr(txtbrutopegawai.Text) & "'" &
                    '" ,'" & .cChr(txtbrutopensiun.Text) & "'" &
                    '" ,'" & .cChr(txtjmlhslbruto.Text) & "'" &
                    '" ,'" & .cChr(txtjmlpphptg.Text) & "'" &
                    '" , ''" &
                    '" , '" & idusr & "'" &
                    '" , 'MODIF'" &
                    '" , '" & idmaster & "'" &
                    '")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kodepjk").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stinputdatapemotongpjkd (" &
                            " , '" & .cChr(Label5.Text) & "'" &
                            " ,  '" & .cChr(dgview.Rows(i).Cells("npwp").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("nama").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kodepjk").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("bruto").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pphptg").Value) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("datein").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'MODIF'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & Label5.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub
    Private Sub clearData()
        txtjmlpegawai.Text = 0
        txtbrutopegawai.Text = 0
        txtjmlpensiun.Text = 0
        txtbrutopensiun.Text = 0
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        clearData()
    End Sub

    Private Sub txtjmbruto_TextChanged(sender As Object, e As EventArgs) Handles txtjmbruto.TextChanged
        getcalculate()
    End Sub

    Private Sub txtjmlpph_TextChanged(sender As Object, e As EventArgs) Handles txtjmlpph.TextChanged
        getcalculate()
    End Sub

    Private Sub dgDetail_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgview.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgview.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture) + 1,
                                   dgview.DefaultCellStyle.Font,
                                   b,
                                   e.RowBounds.Location.X + 10,
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub
End Class