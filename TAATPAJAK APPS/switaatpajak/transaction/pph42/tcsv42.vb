Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel

Public Class tcsv42
    Private Sub initializedg()
        'deklarasi jumlah datagrid kolom
        dgview.ColumnCount = 22
        dgview.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview
            .Columns(0).Name = "No" : .Columns(0).HeaderText = "No"
            .Columns(1).Name = "Tgl Pemotongan (dd/MM/yyyy)" : .Columns(1).HeaderText = "Tgl Pemotongan (dd/MM/yyyy)"
            .Columns(2).Name = "Penerima Penghasilan? (NPWP/NIK)" : .Columns(2).HeaderText = "Penerima Penghasilan? (NPWP/NIK)"
            .Columns(3).Name = "NPWP (tanpa format/tanda baca)" : .Columns(3).HeaderText = "NPWP (tanpa format/tanda baca)"
            .Columns(4).Name = "NIK (tanpa format/tanda baca)" : .Columns(4).HeaderText = "NIK (tanpa format/tanda baca)"
            .Columns(5).Name = "Nama Penerima Penghasilan Sesuai NIK" : .Columns(5).HeaderText = "Nama Penerima Penghasilan Sesuai NIK"
            .Columns(6).Name = "qq (khusus NPWP Keluarga)" : .Columns(6).HeaderText = "qq (khusus NPWP Keluarga)"
            .Columns(7).Name = "Nomor Telp" : .Columns(7).HeaderText = "Nomor Telp"
            .Columns(8).Name = "Kode Objek Pajak" : .Columns(8).HeaderText = "Kode Objek Pajak"
            .Columns(9).Name = "Penandatangan BP ? (Pengurus/Kuasa)" : .Columns(9).HeaderText = "Penandatangan BP ? (Pengurus/Kuasa)"
            .Columns(10).Name = "Penandatangan Menggunakan NPWP/NIK ?" : .Columns(10).HeaderText = "Penandatangan Menggunakan NPWP/NIK ?"
            .Columns(11).Name = "NPWP Penandatangan (tanpa format/tanda baca)" : .Columns(11).HeaderText = "NPWP Penandatangan (tanpa format/tanda baca)"
            .Columns(12).Name = "NIK Penandatangan (tanpa format/tanda baca)" : .Columns(12).HeaderText = "NIK Penandatangan (tanpa format/tanda baca)"
            .Columns(13).Name = "Nama Penandatangan Sesuai NIK" : .Columns(13).HeaderText = "Nama Penandatangan Sesuai NIK"
            .Columns(14).Name = "Penghasilan Bruto" : .Columns(14).HeaderText = "Penghasilan Bruto"
            .Columns(15).Name = "Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)" : .Columns(15).HeaderText = "Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)"
            .Columns(16).Name = "Nomor SKB" : .Columns(16).HeaderText = "Nomor SKB"
            .Columns(17).Name = "Nomor Aturan DTP" : .Columns(17).HeaderText = "Nomor Aturan DTP"
            .Columns(18).Name = "Nomor Suket PP23" : .Columns(18).HeaderText = "Nomor Suket PP23"
            .Columns(19).Name = "Fasilitas PPh Lainnya" : .Columns(19).HeaderText = "Fasilitas PPh Lainnya"
            .Columns(20).Name = "Tarif PPh Berdasarkan Fas. PPh Lainnya" : .Columns(20).HeaderText = "Tarif PPh Berdasarkan Fas. PPh Lainnya"
            .Columns(21).Name = "LB Diproses Oleh ? (Pemotong/Pemindahbukuan)" : .Columns(21).HeaderText = "LB Diproses Oleh ? (Pemotong/Pemindahbukuan)"

            For i As Integer = 1 To 21
                .Columns(i).Visible = False
            Next
            .Columns(0).Visible = True
            .Columns(1).Visible = True
            .Columns(3).Visible = True
            .Columns(1).Visible = True
            .Columns(8).Visible = True
            .Columns(11).Visible = True
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview

            .Columns("No").Width = 100
            .Columns("Tgl Pemotongan (dd/MM/yyyy)").Width = 100
            .Columns("Penerima Penghasilan? (NPWP/NIK)").Width = 100
            .Columns("NPWP (tanpa format/tanda baca)").Width = 100
            .Columns("NIK (tanpa format/tanda baca)").Width = 100
            .Columns("Nama Penerima Penghasilan Sesuai NIK").Width = 100
            .Columns("qq (khusus NPWP Keluarga)").Width = 100
            .Columns("Nomor Telp").Width = 100
            .Columns("Kode Objek Pajak").Width = 100
            .Columns("Penandatangan BP ? (Pengurus/Kuasa)").Width = 100
            .Columns("Penandatangan Menggunakan NPWP/NIK ?").Width = 100
            .Columns("NPWP Penandatangan (tanpa format/tanda baca)").Width = 100
            .Columns("NIK Penandatangan (tanpa format/tanda baca)").Width = 100
            .Columns("Nama Penandatangan Sesuai NIK").Width = 100
            .Columns("Penghasilan Bruto").Width = 100
            .Columns("Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)").Width = 100
            .Columns("Nomor SKB").Width = 100
            .Columns("Nomor Aturan DTP").Width = 100
            .Columns("Nomor Suket PP23").Width = 100
            .Columns("Fasilitas PPh Lainnya").Width = 100
            .Columns("Tarif PPh Berdasarkan Fas. PPh Lainnya").Width = 100
            .Columns("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").Width = 100



            .Columns("No").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tgl Pemotongan (dd/MM/yyyy)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penerima Penghasilan? (NPWP/NIK)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NPWP (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NIK (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nama Penerima Penghasilan Sesuai NIK").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("qq (khusus NPWP Keluarga)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Telp").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Kode Objek Pajak").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penandatangan BP ? (Pengurus/Kuasa)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penandatangan Menggunakan NPWP/NIK ?").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NPWP Penandatangan (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NIK Penandatangan (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nama Penandatangan Sesuai NIK").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penghasilan Bruto").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor SKB").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Aturan DTP").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Suket PP23").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Fasilitas PPh Lainnya").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tarif PPh Berdasarkan Fas. PPh Lainnya").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").DefaultCellStyle.BackColor = Color.MistyRose
        End With


    End Sub

    Private Sub initializedg2()
        'deklarasi jumlah datagrid kolom
        dgview2.ColumnCount = 25
        dgview2.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview2.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview2.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview2
            .Columns(0).Name = "No" : .Columns(0).HeaderText = "No"
            .Columns(1).Name = "Tgl Pemotongan (dd/MM/yyyy)" : .Columns(1).HeaderText = "Tgl Pemotongan (dd/MM/yyyy)"
            .Columns(2).Name = "TIN (dengan format/tanda baca)" : .Columns(2).HeaderText = "TIN (dengan format/tanda baca)"
            .Columns(3).Name = "Nama Penerima Penghasilan" : .Columns(3).HeaderText = "Nama Penerima Penghasilan"
            .Columns(4).Name = "Tgl Lahir Penerima Penghasilan (dd/MM/yyyy)" : .Columns(4).HeaderText = "Tgl Lahir Penerima Penghasilan (dd/MM/yyyy)"
            .Columns(5).Name = "Tempat Lahir Penerima Penghasilan" : .Columns(5).HeaderText = "Tempat Lahir Penerima Penghasilan"
            .Columns(6).Name = "Alamat Penerima Penghasilan" : .Columns(6).HeaderText = "Alamat Penerima Penghasilan"
            .Columns(7).Name = "No Paspor Penerima Penghasilan" : .Columns(7).HeaderText = "No Paspor Penerima Penghasilan"
            .Columns(8).Name = "No Kitas Penerima Penghasilan" : .Columns(8).HeaderText = "No Kitas Penerima Penghasilan"
            .Columns(9).Name = "Kode Negara" : .Columns(9).HeaderText = "Kode Negara"
            .Columns(10).Name = "Kode Objek Pajak" : .Columns(10).HeaderText = "Kode Objek Pajak"
            .Columns(11).Name = "Penandatangan BP ? (Pengurus/Kuasa)" : .Columns(11).HeaderText = "Penandatangan BP ? (Pengurus/Kuasa)"
            .Columns(12).Name = "Penandatangan Menggunakan NPWP/NIK ?" : .Columns(12).HeaderText = "Penandatangan Menggunakan NPWP/NIK ?"
            .Columns(13).Name = "NPWP Penandatangan (tanpa format/tanda baca)" : .Columns(13).HeaderText = "NPWP Penandatangan (tanpa format/tanda baca)"
            .Columns(14).Name = "NIK Penandatangan (tanpa format/tanda baca)" : .Columns(14).HeaderText = "NIK Penandatangan (tanpa format/tanda baca)"
            .Columns(15).Name = "Nama Penandatangan Sesuai NIK" : .Columns(15).HeaderText = "Nama Penandatangan Sesuai NIK"
            .Columns(16).Name = "Penghasilan Bruto" : .Columns(16).HeaderText = "Penghasilan Bruto"
            .Columns(17).Name = "Perkiraan Penghasilan Neto (%)" : .Columns(17).HeaderText = "Perkiraan Penghasilan Neto (%)"
            .Columns(18).Name = "Mendapatkan Fasilitas ? (N/SKD / DTP/Lainnya)" : .Columns(18).HeaderText = "Mendapatkan Fasilitas ? (N/SKD / DTP/Lainnya)"
            .Columns(19).Name = "Nomor Tanda Terima SKD" : .Columns(19).HeaderText = "Nomor Tanda Terima SKD"
            .Columns(20).Name = "Tarif SKD" : .Columns(20).HeaderText = "Tarif SKD"
            .Columns(21).Name = "Nomor Aturan DTP" : .Columns(21).HeaderText = "Nomor Aturan DTP"
            .Columns(22).Name = "Fasilitas PPh Lainnya" : .Columns(22).HeaderText = "Fasilitas PPh Lainnya"
            .Columns(23).Name = "Tarif PPh Berdasarkan Fas. PPh Lainnya" : .Columns(23).HeaderText = "Tarif PPh Berdasarkan Fas. PPh Lainnya"
            .Columns(24).Name = "LB Diproses Oleh ? (Pemotong/Pemindahbukuan)" : .Columns(24).HeaderText = "Nomor Aturan DTP"

            For i As Integer = 1 To 24
                .Columns(i).Visible = False
            Next
            .Columns(0).Visible = True
            .Columns(1).Visible = True
            .Columns(3).Visible = True
            .Columns(1).Visible = True
            .Columns(8).Visible = True
            .Columns(11).Visible = True

            '.Columns(0).Name = "kodepajak" : .Columns(0).HeaderText = "Kode Pajak"
            '.Columns(1).Name = "jnssetoran" : .Columns(1).HeaderText = "Jenis Setoran"
            '.Columns(2).Name = "tgl" : .Columns(2).HeaderText = "Tanggal"
            '.Columns(3).Name = "nttpn" : .Columns(3).HeaderText = "NTTPN"
            '.Columns(4).Name = "pph" : .Columns(4).HeaderText = "PPh"
            '.Columns(5).Name = "note" : .Columns(5).HeaderText = "Keterangan"
        End With
        adjcolumn2()
    End Sub
    Private Sub adjcolumn2()
        dgview2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview2

            .Columns("No").Width = 100
            .Columns("Tgl Pemotongan (dd/MM/yyyy)").Width = 100
            .Columns("TIN (dengan format/tanda baca)").Width = 100
            .Columns("Nama Penerima Penghasilan").Width = 100
            .Columns("Tgl Lahir Penerima Penghasilan (dd/MM/yyyy)").Width = 100
            .Columns("Tempat Lahir Penerima Penghasilan").Width = 100
            .Columns("Alamat Penerima Penghasilan").Width = 100
            .Columns("No Paspor Penerima Penghasilan").Width = 100
            .Columns("No Kitas Penerima Penghasilan").Width = 100
            .Columns("Kode Negara").Width = 100
            .Columns("Kode Objek Pajak").Width = 100
            .Columns("Penandatangan BP ? (Pengurus/Kuasa)").Width = 100
            .Columns("Penandatangan Menggunakan NPWP/NIK ?").Width = 100
            .Columns("NPWP Penandatangan (tanpa format/tanda baca)").Width = 100
            .Columns("NIK Penandatangan (tanpa format/tanda baca)").Width = 100
            .Columns("Nama Penandatangan Sesuai NIK").Width = 100
            .Columns("Penghasilan Bruto").Width = 100
            .Columns("Perkiraan Penghasilan Neto (%)").Width = 100
            .Columns("Mendapatkan Fasilitas ? (N/SKD / DTP/Lainnya)").Width = 100
            .Columns("Nomor Tanda Terima SKD").Width = 100
            .Columns("Tarif SKD").Width = 100
            .Columns("Nomor Aturan DTP").Width = 100
            .Columns("Fasilitas PPh Lainnya").Width = 100
            .Columns("Tarif PPh Berdasarkan Fas. PPh Lainnya").Width = 100
            .Columns("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").Width = 100



            .Columns("No").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tgl Pemotongan (dd/MM/yyyy)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("TIN (dengan format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nama Penerima Penghasilan").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tgl Lahir Penerima Penghasilan (dd/MM/yyyy)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tempat Lahir Penerima Penghasilan").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Alamat Penerima Penghasilan").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("No Paspor Penerima Penghasilan").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("No Kitas Penerima Penghasilan").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Kode Negara").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Kode Objek Pajak").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penandatangan BP ? (Pengurus/Kuasa)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penandatangan Menggunakan NPWP/NIK ?").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NPWP Penandatangan (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("NIK Penandatangan (tanpa format/tanda baca)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nama Penandatangan Sesuai NIK").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Penghasilan Bruto").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Perkiraan Penghasilan Neto (%)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Mendapatkan Fasilitas ? (N/SKD / DTP/Lainnya)").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Tanda Terima SKD").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tarif SKD").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Aturan DTP").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Fasilitas PPh Lainnya").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tarif PPh Berdasarkan Fas. PPh Lainnya").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").DefaultCellStyle.BackColor = Color.MistyRose
        End With


    End Sub
    Private Sub initializedg3()
        'deklarasi jumlah datagrid kolom
        dgview3.ColumnCount = 5
        dgview3.ColumnHeadersVisible = True

        'untuk melakukan konfigurasi style dari kolo header 
        Dim columnHeaderStyle As New DataGridViewCellStyle()
        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        dgview3.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        dgview3.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        'setting nama kolom datagrid
        With dgview3
            .Columns(0).Name = "No" : .Columns(0).HeaderText = "No"
            .Columns(1).Name = "Worksheet" : .Columns(1).HeaderText = "Worksheet"
            .Columns(2).Name = "Jenis Dokumen" : .Columns(2).HeaderText = "Jenis Dokumen"
            .Columns(3).Name = "Nomor Dokumen" : .Columns(3).HeaderText = "Nomor Dokumen"
            .Columns(4).Name = "Tgl Dokumen (dd/MM/yyyy)" : .Columns(4).HeaderText = "Tgl Dokumen (dd/MM/yyyy)"

            For i As Integer = 1 To 2
                .Columns(i).Visible = False
            Next
            .Columns(0).Visible = True
            .Columns(1).Visible = True
        End With
        adjcolumn3()
    End Sub
    Private Sub adjcolumn3()
        dgview3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview3

            .Columns("No").Width = 100
            .Columns("Worksheet").Width = 100
            .Columns("Jenis Dokumen").Width = 100
            .Columns("Nomor Dokumen").Width = 100
            .Columns("Tgl Dokumen (dd/MM/yyyy)").Width = 100



            .Columns("No").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Worksheet").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Jenis Dokumen").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Nomor Dokumen").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("Tgl Dokumen (dd/MM/yyyy)").DefaultCellStyle.BackColor = Color.MistyRose
        End With


    End Sub
    Private Sub tcsv21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializedg()
        initializedg2()
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
        Dim dtdet1 As DataTable = Nothing
        Dim dtdet2 As DataTable = Nothing

        dtdet1 = cl.table("SELECT T0.tglptgchr, T0.npwp, T0.namaptg, T1.uraian, T1.uraian, T1.nilai FROM tpph42 T0 " &
                            "INNER JOIN tpph42d T1 ON T0.id = T1.idh " &
                            "INNER Join tinputssppbk42 T2 ON T1.uraian = T2.kdpjk " &
                            "where T0.stat = 1 And T0.masapjk = '" & masapjk & "' and T0.thnpjk = '" & thnpjk & "' and T0.wpasing = 'N' group by T1.uraian")
        dtdet2 = cl.table("SELECT T0.tglptgchr, T0.npwp, T0.namaptg, T1.uraian, T1.uraian, T1.nilai FROM tpph42 T0 " &
                            "INNER JOIN tpph42d T1 ON T0.id = T1.idh " &
                            "INNER Join tinputssppbk42 T2 ON T1.uraian = T2.kdpjk " &
                            "where T0.stat = 1 And T0.masapjk = '" & masapjk & "' and T0.thnpjk = '" & thnpjk & "' and T0.wpasing = 'N' group by T1.uraian")
        'LOAD MAIN DGVIEW
        dgview.Rows.Clear()
        dgview2.Rows.Clear()
        Dim rrowpl1 As Integer = 0
        Dim rrowpl2 As Integer = 0

        For r1 As Integer = 0 To dtdet1.Rows.Count - 1
            rrowpl1 = dgview.Rows.Add
            With dtdet1
                dgview.Rows(rrowpl1).Cells("No").Value = r1 + 1
                dgview.Rows(rrowpl1).Cells("Tgl Pemotongan (dd/MM/yyyy)").Value = .Rows(r1).Item("tglptgchr")
                dgview.Rows(rrowpl1).Cells("Penerima Penghasilan? (NPWP/NIK)").Value = "NPWP"
                dgview.Rows(rrowpl1).Cells("NPWP (tanpa format/tanda baca)").Value = .Rows(r1).Item("npwp")
                dgview.Rows(rrowpl1).Cells("NIK (tanpa format/tanda baca)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nama Penerima Penghasilan Sesuai NIK").Value = .Rows(r1).Item("namaptg")
                dgview.Rows(rrowpl1).Cells("qq (khusus NPWP Keluarga)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Telp").Value = ""
                dgview.Rows(rrowpl1).Cells("Kode Objek Pajak").Value = .Rows(r1).Item("uraian")
                dgview.Rows(rrowpl1).Cells("Penandatangan BP ? (Pengurus/Kuasa)").Value = "Pengurus"
                dgview.Rows(rrowpl1).Cells("Penandatangan Menggunakan NPWP/NIK ?").Value = "NPWP"
                dgview.Rows(rrowpl1).Cells("NPWP Penandatangan (tanpa format/tanda baca)").Value = .Rows(r1).Item("npwp")
                dgview.Rows(rrowpl1).Cells("NIK Penandatangan (tanpa format/tanda baca)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nama Penandatangan Sesuai NIK").Value = ""
                dgview.Rows(rrowpl1).Cells("Penghasilan Bruto").Value = .Rows(r1).Item("nilai")
                dgview.Rows(rrowpl1).Cells("Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)").Value = "N"
                dgview.Rows(rrowpl1).Cells("Nomor SKB").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Aturan DTP").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Suket PP23").Value = ""
                dgview.Rows(rrowpl1).Cells("Fasilitas PPh Lainnya").Value = ""
                dgview.Rows(rrowpl1).Cells("Tarif PPh Berdasarkan Fas. PPh Lainnya").Value = ""
                dgview.Rows(rrowpl1).Cells("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").Value = "Pemotong"
            End With
        Next

        For r2 As Integer = 0 To dtdet2.Rows.Count - 1
            rrowpl2 = dgview2.Rows.Add
            With dtdet1
                dgview2.Rows(rrowpl2).Cells("No").Value = r2 + 1
                dgview2.Rows(rrowpl2).Cells("Tgl Pemotongan (dd/MM/yyyy)").Value = .Rows(r2).Item("tglptgchr")
                dgview2.Rows(rrowpl2).Cells("TIN (dengan format/tanda baca)").Value = "NPWP"
                dgview2.Rows(rrowpl2).Cells("Nama Penerima Penghasilan").Value = .Rows(r2).Item("namaptg")
                dgview2.Rows(rrowpl2).Cells("Tgl Lahir Penerima Penghasilan (dd/MM/yyyy)").Value = ""
                dgview2.Rows(rrowpl2).Cells("Tempat Lahir Penerima Penghasilan").Value = ""
                dgview2.Rows(rrowpl2).Cells("Alamat Penerima Penghasilan").Value = ""
                dgview2.Rows(rrowpl2).Cells("No Paspor Penerima Penghasilan").Value = ""
                dgview2.Rows(rrowpl2).Cells("No Kitas Penerima Penghasilan").Value = "Test"
                dgview2.Rows(rrowpl2).Cells("Kode Negara").Value = ""
                dgview2.Rows(rrowpl2).Cells("Kode Objek Pajak").Value = .Rows(r2).Item("uraian")
                dgview2.Rows(rrowpl2).Cells("Penandatangan BP ? (Pengurus/Kuasa)").Value = "TEST"
                dgview2.Rows(rrowpl2).Cells("Penandatangan Menggunakan NPWP/NIK ?").Value = ""
                dgview2.Rows(rrowpl2).Cells("NPWP Penandatangan (tanpa format/tanda baca)").Value = ""
                dgview2.Rows(rrowpl2).Cells("NIK Penandatangan (tanpa format/tanda baca)").Value = ""
                dgview2.Rows(rrowpl2).Cells("Nama Penandatangan Sesuai NIK").Value = ""
                dgview2.Rows(rrowpl2).Cells("Penghasilan Bruto").Value = ""
                dgview2.Rows(rrowpl2).Cells("Perkiraan Penghasilan Neto (%)").Value = ""
                dgview2.Rows(rrowpl2).Cells("Mendapatkan Fasilitas ? (N/SKD / DTP/Lainnya)").Value = ""
                dgview2.Rows(rrowpl2).Cells("Nomor Tanda Terima SKD").Value = ""
                dgview2.Rows(rrowpl2).Cells("Tarif SKD").Value = ""
                dgview2.Rows(rrowpl2).Cells("Nomor Aturan DTP").Value = "Pemotong"
                dgview2.Rows(rrowpl2).Cells("Fasilitas PPh Lainnya").Value = ""
                dgview2.Rows(rrowpl2).Cells("Tarif PPh Berdasarkan Fas. PPh Lainnya").Value = ""
                dgview2.Rows(rrowpl2).Cells("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").Value = "Pemotong"
            End With
        Next
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Dim sfd As New SaveFileDialog()

        Dim profile As String
        profile = cl.readData(
                    "SELECT TA.npwp " &
                    " FROM mprofile TA  " &
                    " WHERE TA.stat = 1 ")

        sfd.FileName = "" & profile & "_" & thnpjk & "" & masapjkstr & ""
        sfd.Filter = "Excel Files (*.xls)|*.xls"

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet1 As excel.Worksheet
            Dim xlWorkSheet2 As excel.Worksheet
            Dim xlWorkSheet3 As excel.Worksheet
            Dim xlWorkSheet4 As excel.Worksheet

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open("D:\Contoh TP\FORMAT_UPLOAD_EBUPOT_UNIFIKASI.xls")
            'xlWorkSheet = xlWorkBook.Worksheets("sheet1")

            xlWorkSheet1 = xlWorkBook.Sheets(1)
            xlWorkSheet2 = xlWorkBook.Sheets(2)
            xlWorkSheet3 = xlWorkBook.Sheets(3)
            xlWorkSheet4 = xlWorkBook.Sheets(4)

            xlWorkSheet1.Cells(2, 4).value = thnpjk
            xlWorkSheet1.Cells(2, 7).value = masapjknum

            For i = 0 To dgview.RowCount - 1
                For j = 0 To dgview.ColumnCount - 1
                    For k As Integer = 1 To dgview.Columns.Count
                        'xlWorkSheet2.Cells(2, k) = dgview.Columns(k - 1).HeaderText
                        xlWorkSheet2.Cells(i + 3, j + 1) = dgview(j, i).Value().ToString()
                    Next
                Next
            Next

            For i = 0 To dgview2.RowCount - 1
                For j = 0 To dgview2.ColumnCount - 1
                    For k As Integer = 1 To dgview2.Columns.Count
                        'xlWorkSheet3.Cells(2, k) = dgview2.Columns(k - 1).HeaderText
                        xlWorkSheet3.Cells(i + 3, j + 1) = dgview2(j, i).Value().ToString()
                    Next
                Next
            Next

            For i = 0 To dgview3.RowCount - 1
                For j = 0 To dgview3.ColumnCount - 1
                    For k As Integer = 1 To dgview3.Columns.Count
                        'xlWorkSheet4.Cells(2, k) = dgview3.Columns(k - 1).HeaderText
                        xlWorkSheet4.Cells(i + 3, j + 1) = dgview3(j, i).Value().ToString()
                    Next
                Next
            Next


            xlWorkSheet1.SaveAs(sfd.FileName)
            xlWorkBook.Close()
            xlApp.Quit()

            releaseobj(xlApp)
            releaseobj(xlWorkBook)
            releaseobj(xlWorkSheet1)
        End If
    End Sub
    Private Sub releaseobj(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim dtdet1 As DataTable = Nothing
        dtdet1 = cl.table(
                    "SELECT T0.tglptgchr, T0.npwp, T0.namaptg, T1.uraian, T1.uraian, T1.nilai FROM tpph42 T0 " &
                            "INNER JOIN tpph42d T1 ON T0.id = T1.idh " &
                            "INNER Join tinputssppbk42 T2 ON T1.uraian = T2.kdpjk " &
                            "where T0.stat = 1 And T0.masapjk = '" & masapjk & "' and T0.thnpjk = '" & thnpjk & "' and T0.wpasing = 'N' group by T1.uraian")


        dgview.Rows.Clear()
        Dim rrowpl1 As Integer = 0
        Dim initnum As Integer = 0
        For r1 As Integer = 0 To dtdet1.Rows.Count - 1
            rrowpl1 = dgview.Rows.Add
            With dtdet1
                dgview.Rows(rrowpl1).Cells("No").Value = r1 + 1
                dgview.Rows(rrowpl1).Cells("Tgl Pemotongan (dd/MM/yyyy)").Value = .Rows(r1).Item("tglptgchr")
                dgview.Rows(rrowpl1).Cells("Penerima Penghasilan? (NPWP/NIK)").Value = "NPWP"
                dgview.Rows(rrowpl1).Cells("NPWP (tanpa format/tanda baca)").Value = .Rows(r1).Item("npwp")
                dgview.Rows(rrowpl1).Cells("NIK (tanpa format/tanda baca)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nama Penerima Penghasilan Sesuai NIK").Value = .Rows(r1).Item("namaptg")
                dgview.Rows(rrowpl1).Cells("qq (khusus NPWP Keluarga)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Telp").Value = ""
                dgview.Rows(rrowpl1).Cells("Kode Objek Pajak").Value = .Rows(r1).Item("uraian")
                dgview.Rows(rrowpl1).Cells("Penandatangan BP ? (Pengurus/Kuasa)").Value = "Pengurus"
                dgview.Rows(rrowpl1).Cells("Penandatangan Menggunakan NPWP/NIK ?").Value = "NPWP"
                dgview.Rows(rrowpl1).Cells("NPWP Penandatangan (tanpa format/tanda baca)").Value = .Rows(r1).Item("npwp")
                dgview.Rows(rrowpl1).Cells("NIK Penandatangan (tanpa format/tanda baca)").Value = ""
                dgview.Rows(rrowpl1).Cells("Nama Penandatangan Sesuai NIK").Value = ""
                dgview.Rows(rrowpl1).Cells("Penghasilan Bruto").Value = .Rows(r1).Item("nilai")
                dgview.Rows(rrowpl1).Cells("Mendapatkan Fasilitas ? (N/SKB / PP23/DTP / Lainnya)").Value = "N"
                dgview.Rows(rrowpl1).Cells("Nomor SKB").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Aturan DTP").Value = ""
                dgview.Rows(rrowpl1).Cells("Nomor Suket PP23").Value = ""
                dgview.Rows(rrowpl1).Cells("Fasilitas PPh Lainnya").Value = ""
                dgview.Rows(rrowpl1).Cells("Tarif PPh Berdasarkan Fas. PPh Lainnya").Value = ""
                dgview.Rows(rrowpl1).Cells("LB Diproses Oleh ? (Pemotong/Pemindahbukuan)").Value = "Pemotong"
            End With

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
End Class