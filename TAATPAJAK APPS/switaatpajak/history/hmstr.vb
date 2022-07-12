Imports CrystalDecisions.CrystalReports.Engine
Public Class hmstr
    Dim formCond As String = ""
    Dim defCond As String = ""
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
        ByVal keyData As System.Windows.Forms.Keys) As Boolean

        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            btncancel.PerformClick()
            '-----------------------------------------------------------------------
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then

        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F2) Then
            btnrefresh.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F5) Then
            btnprint.PerformClick()
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub loadcombo()
        Dim dtemptp As DataTable = cl.table(
            "SELECT id AS 'value', name AS 'display' FROM cusr where stat = 1")

        cmbuser.DataSource = dtemptp
        cmbuser.ValueMember = "value"
        cmbuser.DisplayMember = "display"

        Dim dtemptp2 As DataTable = cl.table(
          "SELECT 1 AS 'value', 'BARU' AS 'display' UNION ALL SELECT 2 AS 'value', 'MODIF' AS 'display'" &
          " UNION ALL SELECT 3 AS 'value', 'HAPUS' AS 'display'")

        cmbaction.DataSource = dtemptp2
        cmbaction.ValueMember = "value"
        cmbaction.DisplayMember = "display"
    End Sub

    Private Sub huserlog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        initializedg()
        loadcombo()
    End Sub

    Private Sub initializedg()

        'deklarasi jumlah datagrid kolom
        dgview.ColumnCount = 4
        dgview.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview
            .Columns(0).Name = "idtrans" : .Columns(0).HeaderText = "ID Transaksi"
            '.Columns(1).Name = "name_cusr" : .Columns(1).HeaderText = "Nama"
            .Columns(1).Name = "tbl" : .Columns(1).HeaderText = "Jenis"
            .Columns(2).Name = "act" : .Columns(2).HeaderText = "Action"
            .Columns(3).Name = "datein" : .Columns(3).HeaderText = "Tanggal / Waktu"

        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            '.Columns("name_cusr").Width = 80
            .Columns("idtrans").Width = 80
            .Columns("tbl").Width = 50
            .Columns("act").Width = 60
            .Columns("datein").Width = 75

            '.Columns("name_cusr").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("idtrans").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("tbl").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("act").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("datein").DefaultCellStyle.BackColor = Color.MistyRose
        End With

    End Sub

    Private Sub viewmode()

        formCond = ""
        If chuser.Checked = True Then : formCond &= " AND  T0.usin = '" & cmbuser.SelectedValue & "'" : End If
        If chaction.Checked = True Then : formCond &= " AND T0.act = '" & cmbaction.Text & "'" : End If
        If chtgl.Checked = True Then : formCond &=
            " AND (T0.datein BETWEEN '" & Format(dtfrom.Value, "yyyyMMdd") & "' AND '" & Format(dtto.Value, "yyyyMMdd") & "')" : End If

        Dim dtdet As DataTable = Nothing

        dtdet = cl.table(
             "SELECT T0.* " &
             " FROM hmstr T0 where 1=1 " & formCond)

        'MsgBox("SELECT T0.* FROM hmstr T0 where 1=1 " & formCond)
        dgview.Rows.Clear()

        Dim rrowpl As Integer = 0
        For r As Integer = 0 To dtdet.Rows.Count - 1
            rrowpl = dgview.Rows.Add

            With dtdet
                'dgview.Rows(rrowpl).Cells("name_cusr").Value = cl.readData("SELECT code FROM cusr WHERE id = '" & cl.cChr(.Rows(r).Item("name_cusr")) & "' ")
                'dgview.Rows(rrowpl).Cells("name_cusr").Value = cl.cChr(.Rows(r).Item("code_cusr"))
                dgview.Rows(rrowpl).Cells("idtrans").Value = cl.cChr(.Rows(r).Item("idtrans"))
                dgview.Rows(rrowpl).Cells("tbl").Value = cl.cChr(.Rows(r).Item("tbl"))
                dgview.Rows(rrowpl).Cells("act").Value = cl.cChr(.Rows(r).Item("act"))
                dgview.Rows(rrowpl).Cells("datein").Value = cl.cChr(.Rows(r).Item("datein"))
            End With
        Next
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        viewmode()
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Dim frm As New hmstr
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click

    End Sub

    Private Sub dgDetail_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgview.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgview.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture) + 1, _
                                   dgview.DefaultCellStyle.Font, _
                                   b, _
                                   e.RowBounds.Location.X + 5, _
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub
End Class