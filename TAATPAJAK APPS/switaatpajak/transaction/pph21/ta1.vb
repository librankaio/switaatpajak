Public Class ta1
    Dim idmaster As Integer = 0, statform As String = ""

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
        ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            '   btncancel.PerformClick()
            Me.Dispose()
            '-----------------------------------------------------------------------
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then
            'If btnsave.Text = "Save" Or (idmaster <> 0 And btnsave.Text = "Update") Then
            '    btnsave.PerformClick()
            'End If
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
        dgview.ColumnCount = 7
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
            .Columns(3).Name = "nobuktptg" : .Columns(3).HeaderText = "No. Bukti Ptg" : .Columns(3).ReadOnly = True
            .Columns(4).Name = "tanggal" : .Columns(4).HeaderText = "Tgl Bukti Ptg" : .Columns(4).ReadOnly = True
            .Columns(5).Name = "kodepjk" : .Columns(5).HeaderText = "Kd Obj Pjk" : .Columns(5).ReadOnly = True

            .Columns(6).Name = "id" : .Columns(6).Visible = False
        End With
        adjcolumn()
    End Sub


    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("chooseData").Width = 20
            .Columns("npwp").Width = 80
            .Columns("nama").Width = 100
            .Columns("nobuktptg").Width = 80
            .Columns("tanggal").Width = 80
            .Columns("kodepjk").Width = 80

            .Columns("npwp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nama").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nobuktptg").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("tanggal").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("kodepjk").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("chooseData").DefaultCellStyle.BackColor = Color.PaleGreen

        End With

    End Sub

    Private Sub ta1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cultureSet()
        txtjmbruto.Text = 0
        txtjmlpph.Text = 0
        cmbkdobjpjk.SelectedIndex = 0
        initializedg()
        loadPmotongPjkBlnTable()
        Label4.Text = masapjk & " " & thnpjk
        Label5.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As New tpph21
        a.loadStatusTempForm(Me, Me.dgview, "")
        cekform(a, "SEARCH", Me)
    End Sub

    Public Sub loadPmotongPjkBlnTable()
        Dim dtdet As DataTable = Nothing
        dtdet = cl.table(
            "SELECT TA.* " &
            " FROM tpph21 TA " &
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
                dgview.Rows(rrowpl).Cells("nobuktptg").Value = .Rows(r).Item("nobuktptg")
                dgview.Rows(rrowpl).Cells("tanggal").Value = cl.cChr(.Rows(r).Item("tanggal"))
                dgview.Rows(rrowpl).Cells("kodepjk").Value = .Rows(r).Item("kodepjk")
                'dgview.Rows(rrowpl).Cells("kodepjk").Value = cl.cCur(.Rows(r).Item("kodepjk"))
            End With
        Next
    End Sub

    Public Sub getcalculate()
        'Dim totalpph As Decimal
        'Dim totalbruto As Decimal

        'For a As Integer = 0 To dgview.Rows.Count - 1
        '    If cl.cNum(dgview.Rows(a).Cells("id").Value) <> 0 Then
        '        totalpph += cl.cNum(dgview.Rows(a).Cells("jpb").Value)
        '        totalbruto += cl.cNum(dgview.Rows(a).Cells("pdp").Value)
        '    End If
        'Next

        'txtjmbruto.Text = cl.cCur(totalbruto)
        'txtjmlpph.Text = cl.cCur(totalpph)

        'txtjmlhslbruto.Text = cl.cCur(cl.cNum(txtjmbruto.Text) + cl.cNum(txtbrutopegawai.Text) + cl.cNum(txtbrutopensiun.Text))
        'txtjmlpphptg.Text = cl.cNum(txtjmlpph.Text)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With cl
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
                    "CALL stpph21 (" &
                    " ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , ''" &
                    " , '" & idusr & "'" &
                    " , 'HAPUS'" &
                    " , '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'" &
                    ")")
                .closeTrans(Button3)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data !", "Informasi")
                    loadPmotongPjkBlnTable()
                End If
            End If
        End With

        loadPmotongPjkBlnTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New tpph21
        a.loadStatusTempForm(Me, Me.dgview, "")
        cekform(a, "SEARCH", Me)
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
        a.cmbkodepjk.Text = dgview.Item("nobuktptg", dgview.CurrentRow.Index).Value
        a.dttdttanggal.Text = dgview.Item("tanggal", dgview.CurrentRow.Index).Value
        a.cmbkodepjk.Text = dgview.Item("kodepjk", dgview.CurrentRow.Index).Value
        a.getidmaster(dgview.Item("id", dgview.CurrentRow.Index).Value)
        a.txtnikpssprt.Text = cl.readData("SELECT nikpssprt from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtalamat.Text = cl.readData("SELECT alamat from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.cmbgender.Text = cl.readData("SELECT gender AS 'value' from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.cmbtgngan.Text = cl.readData("SELECT tgngan from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.cmbstatus.Text = cl.readData("SELECT status from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.cmbname_mjabatan.Text = cl.readData("SELECT name_mjabatan from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        Dim wpasing As String
        wpasing = cl.readData("Select wpasing from tinputdatapemotongpjk where npwp ='" & a.txtnpwp.Text & "' AND nama ='" & a.txtnama.Text & "'")
        If wpasing = "Y" Then
            a.chwpasing.Checked = True
        Else
            a.chwpasing.Checked = False
        End If
        '--------------------
        a.txtnobuktptg.Text = cl.readData("SELECT nobuktptg from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtnobuktptg_knn.Text = cl.readData("SELECT nobuktptg_knn from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        '--------------------
        a.txtgajipensi.Text = cl.readData("SELECT gajipensi from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txttunjpph.Text = cl.readData("SELECT tunjpph from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txttunjlain.Text = cl.readData("SELECT tunjlain from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txthonorarium.Text = cl.readData("SELECT honorarium from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpremiapbr.Text = cl.readData("SELECT premiapbr from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpenerimapotpph21.Text = cl.readData("SELECT penerimapotpph21 from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txttantiem.Text = cl.readData("SELECT tantiem from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtjmlbruto.Text = cl.readData("SELECT jmlbruto from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtbiayapensi.Text = cl.readData("SELECT biayapensi from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtiuranpensi.Text = cl.readData("SELECT iuranpensi from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtjmlpengurangan.Text = cl.readData("SELECT jmlpengurangan from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        '--------------------
        a.txtjmlneto.Text = cl.readData("SELECT jmlneto from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtjmlnetosblm.Text = cl.readData("SELECT jmlnetosblm from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtjmlneto1thn.Text = cl.readData("SELECT jmlneto1thn from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtptkp.Text = cl.readData("SELECT ptkp from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpjksetahun.Text = cl.readData("SELECT pph21setahun from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpph21setahun.Text = cl.readData("SELECT pph21setahun from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpph21htg.Text = cl.readData("SELECT pph21htg from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtpph21to26.Text = cl.readData("SELECT pph21to26 from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        '--------------------
        a.txtnpwpptg.Text = cl.readData("SELECT npwpptg from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.txtnamaptg.Text = cl.readData("SELECT namaptg from tpph21 where nama = '" & a.txtnama.Text & "' AND npwp = '" & a.txtnpwp.Text & "' AND kodepjk = '" & a.cmbkodepjk.Text & "'")
        a.btnsave.Text = "Update"
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