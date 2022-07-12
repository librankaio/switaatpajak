Imports CrystalDecisions.CrystalReports.Engine
Public Class tdaftarpemotongpjktahun
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
        dgview.ColumnCount = 10
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
            .Columns(3).Name = "nbp" : .Columns(3).HeaderText = "No Bkt Ptg" : .Columns(3).ReadOnly = True
            .Columns(4).Name = "kop" : .Columns(4).HeaderText = "Kode Obj Pjk" : .Columns(4).ReadOnly = True
            .Columns(5).Name = "jpb" : .Columns(5).HeaderText = "Jml Hsl Bruto (Rp.)" : .Columns(5).ReadOnly = True
            .Columns(6).Name = "pdp" : .Columns(6).HeaderText = "PPh Dipotong (Rp.)" : .Columns(6).ReadOnly = True
            .Columns(7).Name = "msoleh" : .Columns(7).HeaderText = "Masa Perolehan" : .Columns(7).ReadOnly = True
            .Columns(8).Name = "knd" : .Columns(8).HeaderText = "Negara Dom." : .Columns(8).ReadOnly = True

            .Columns(9).Name = "id" : .Columns(9).Visible = False
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("chooseData").Width = 20
            .Columns("npwp").Width = 80
            .Columns("nama").Width = 120
            .Columns("nbp").Width = 60
            .Columns("kop").Width = 60
            .Columns("jpb").Width = 80
            .Columns("pdp").Width = 180
            .Columns("knd").Width = 80
            .Columns("msoleh").Width = 60

            .Columns("jpb").DefaultCellStyle.Format = "n2"
            .Columns("pdp").DefaultCellStyle.Format = "n2"


            .Columns("npwp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nama").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("kop").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("jpb").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("pdp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("knd").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("msoleh").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nbp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("chooseData").DefaultCellStyle.BackColor = Color.PaleGreen

        End With

    End Sub

    Private Sub tdaftarpemotongpjktahun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cultureSet()
        ' -- Daten löschen
        txtjmbruto.Text = 0
        txtjmlpph.Text = 0
        txtjmlpegawai.Text = 0
        txtbrutopegawai.Text = 0
        txtjmlhslbruto.Text = 0
        txtjmlpphptg.Text = 0

        initializedg()
        Label4.Text = masapjk & " " & thnpjk
        Label5.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")
        cmbkdobjpjk.SelectedIndex = 0

        loadPmotongPjkBlnTable()
        getcalculate()
    End Sub

    Public Sub loadPmotongPjkBlnTable()
        'Dim dtdet As DataTable = Nothing
        'dtdet = cl.table(
        '    "SELECT TA.* " &
        '    " FROM tinputdatapemotongpjk TA " &
        '    " WHERE TA.stat = 1 " &
        '    " AND masapjk = '" & masapjk & "' AND tahunpjk = '" & thnpjk & "'")

        ''LOAD MAIN DGVIEW
        'dgview.Rows.Clear()
        'Dim rrowpl As Integer = 0
        'For r As Integer = 0 To dtdet.Rows.Count - 1
        '    rrowpl = dgview.Rows.Add
        '    With dtdet
        '        dgview.Rows(rrowpl).Cells("chooseData").Value = vbFalse
        '        dgview.Rows(rrowpl).Cells("id").Value = .Rows(r).Item("id")
        '        dgview.Rows(rrowpl).Cells("npwp").Value = .Rows(r).Item("npwp")
        '        dgview.Rows(rrowpl).Cells("nama").Value = .Rows(r).Item("nama")
        '        dgview.Rows(rrowpl).Cells("kop").Value = .Rows(r).Item("kodepjk")
        '        dgview.Rows(rrowpl).Cells("jpb").Value = cl.cCur(.Rows(r).Item("bruto"))
        '        dgview.Rows(rrowpl).Cells("pdp").Value = cl.cCur(.Rows(r).Item("pphptg"))
        '        dgview.Rows(rrowpl).Cells("knd").Value = .Rows(r).Item("kdnegara")
        '    End With
        'Next
    End Sub

    Public Sub getcalculate()
        Dim totalpph As Decimal
        Dim totalbruto As Decimal

        For a As Integer = 0 To dgview.Rows.Count - 1
            If cl.cNum(dgview.Rows(a).Cells("id").Value) <> 0 Then
                totalpph += cl.cNum(dgview.Rows(a).Cells("jpb").Value)
                totalbruto += cl.cNum(dgview.Rows(a).Cells("pdp").Value)
            End If
        Next

        txtjmbruto.Text = cl.cCur(totalbruto)
        txtjmlpph.Text = cl.cCur(totalpph)

        txtjmlhslbruto.Text = cl.cCur(cl.cNum(txtjmbruto.Text) + cl.cNum(txtbrutopegawai.Text))
        txtjmlpphptg.Text = cl.cNum(txtjmlpph.Text)
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            '------PRINT INVOICE
            '  MsgBox(idmaster)
            Dim rpt As New ReportDocument
            Dim f As New rprt
            rpt = New PPh_21_satutahun
            f.crviewer.ReportSource = rpt
            cekform(f, "NEW", Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub clearData()
        txtjmlpegawai.Text = 0
        txtbrutopegawai.Text = 0
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        clearData()
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