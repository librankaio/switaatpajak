Imports System.IO

Public Class tcsv21

    Private Sub initializedg()
        'deklarasi jumlah datagrid kolom
        dgview.ColumnCount = 6
        dgview.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview
            .Columns(0).Name = "kodepajak" : .Columns(0).HeaderText = "Kode Pajak"
            .Columns(1).Name = "jnssetoran" : .Columns(1).HeaderText = "Jenis Setoran"
            .Columns(2).Name = "tgl" : .Columns(2).HeaderText = "Tgl"
            .Columns(3).Name = "nttpn" : .Columns(3).HeaderText = "NTTPN"
            .Columns(4).Name = "pph" : .Columns(4).HeaderText = "PPh"
            .Columns(5).Name = "note" : .Columns(5).HeaderText = "Keterangan"
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("kodepajak").Width = 100
            .Columns("jnssetoran").Width = 100
            .Columns("tgl").Width = 100
            .Columns("nttpn").Width = 100
            .Columns("pph").Width = 100
            .Columns("note").Width = 100


            .Columns("kodepajak").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("jnssetoran").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("tgl").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("nttpn").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("pph").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("note").DefaultCellStyle.BackColor = Color.MistyRose
        End With


    End Sub
    Private Sub tcsv21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializedg()
        loadPmotongPjkBlnTable()
        cmbbln.Text = masapjk
        cmbthn.Text = thnpjk
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
    Public Sub loadPmotongPjkBlnTable()
        Dim dtdet As DataTable = Nothing
        dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tinputssppbk21 TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.masapjk = '" & masapjk & "' and TA.thnpjk = '" & thnpjk & "'")
        'LOAD MAIN DGVIEW
        dgview.Rows.Clear()
        Dim rrowpl As Integer = 0
        For r As Integer = 0 To dtdet.Rows.Count - 1
            rrowpl = dgview.Rows.Add
            With dtdet
                dgview.Rows(rrowpl).Cells("kodepajak").Value = .Rows(r).Item("kdpjk")
                dgview.Rows(rrowpl).Cells("jnssetoran").Value = .Rows(r).Item("jenissetor")
                dgview.Rows(rrowpl).Cells("tgl").Value = .Rows(r).Item("tglssp")
                dgview.Rows(rrowpl).Cells("nttpn").Value = .Rows(r).Item("nttpn")
                dgview.Rows(rrowpl).Cells("pph").Value = .Rows(r).Item("pph")
                dgview.Rows(rrowpl).Cells("note").Value = .Rows(r).Item("ket")
            End With
        Next
    End Sub
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim dtdet As DataTable = Nothing
        dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tinputssppbk21 TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.masapjk = '" & masapjk & "' and TA.thnpjk = '" & thnpjk & "'")


        dgview.Rows.Clear()
        Dim rrowpl As Integer = 0
        For r As Integer = 0 To dtdet.Rows.Count - 1
            rrowpl = dgview.Rows.Add
            With dtdet

                '.Columns(0).Name = "kodepajak" : .Columns(0).HeaderText = "Kode Pajak"
                '.Columns(1).Name = "jnssetoran" : .Columns(1).HeaderText = "Jenis Setoran"
                '.Columns(2).Name = "tgl" : .Columns(2).HeaderText = "Tgl"
                '.Columns(3).Name = "nttpn" : .Columns(3).HeaderText = "NTTPN"
                '.Columns(4).Name = "pph" : .Columns(4).HeaderText = "PPh"
                '.Columns(5).Name = "note" : .Columns(5).HeaderText = "Keterangan"

                dgview.Rows(rrowpl).Cells("kodepajak").Value = .Rows(r).Item("kdpjk")
                dgview.Rows(rrowpl).Cells("jnssetoran").Value = .Rows(r).Item("jenissetor")
                dgview.Rows(rrowpl).Cells("tgl").Value = .Rows(r).Item("tglssp")
                dgview.Rows(rrowpl).Cells("nttpn").Value = .Rows(r).Item("nttpn")
                dgview.Rows(rrowpl).Cells("pph").Value = .Rows(r).Item("pph")
                dgview.Rows(rrowpl).Cells("note").Value = .Rows(r).Item("ket")
            End With

        Next
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        'cl.msgInform("Under Maintenance !", "Information")
        Dim sfd As New SaveFileDialog()
        sfd.FileName = "export-csv"
        sfd.Filter = "CSV File | *.csv"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using sw As StreamWriter = File.CreateText(sfd.FileName)
                Dim dgColNames As List(Of String) = dgview.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.Name).ToList()

                sw.WriteLine(String.Join(",", dgColNames))

                For Each row As DataGridViewRow In dgview.Rows
                    Dim rowdata As New List(Of String)
                    For Each column As DataGridViewColumn In dgview.Columns
                        rowdata.Add(Convert.ToString(row.Cells(column.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowdata))
                Next

                Process.Start(sfd.FileName)
            End Using
        End If
    End Sub
End Class