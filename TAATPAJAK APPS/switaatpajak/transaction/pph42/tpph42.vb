Imports System.IO
Public Class tpph42
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
            btnlist.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
            If idmaster <> 0 And btnsave.Text <> "Save" Then : btndelete.PerformClick() : End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub

    'Private Sub gencode()
    '    txtcode.Text = cl.readData("SELECT dbo.fgetcode('msales','')")
    'End Sub

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
            .Columns(0).Name = "kdobj" : .Columns(0).HeaderText = "Kode Objek Pajak"
            .Columns(1).Name = "nilai" : .Columns(1).HeaderText = "Nilai Trans (Rp.)"
            .Columns(2).Name = "tariff" : .Columns(2).HeaderText = "Tariff (%)"
            .Columns(3).Name = "pph" : .Columns(3).HeaderText = "PPh Dipotong (Rp.)"
        End With
        adjcolumn()
    End Sub

    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("kdobj").Width = 100
            .Columns("nilai").Width = 80
            .Columns("tariff").Width = 60
            .Columns("pph").Width = 120

            .Columns("nilai").DefaultCellStyle.Format = "n2"
            .Columns("pph").DefaultCellStyle.Format = "n2"
            .Columns("tariff").DefaultCellStyle.Format = "n2"


            .Columns("kdobj").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("nilai").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("tariff").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("pph").DefaultCellStyle.BackColor = Color.MistyRose
        End With

    End Sub

    Private Sub clearData()
        txtnpwpptg.Text = cl.readData("SELECT npwp FROM mprofile WHERE stat = 1 LIMIT 1")
        txtnamaptg.Text = cl.readData("SELECT nama FROM mprofile WHERE stat = 1 LIMIT 1")
        txtalamatptg.Text = cl.readData("SELECT alamat FROM mprofile WHERE stat = 1 LIMIT 1")

        txtnobkt.Text = ""
        txtnpwp.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""

        txtnobuktiptg.Text = ""
        txtterbilang.Text = ""
        dttdttglptg.Text = ""
        cmbjnstransaksi.SelectedIndex = 0
        txttotal.Text = 0

        dgview.Rows.Clear()
    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            'gencode()
            initdate()
            btndelete.Visible = False
            ' btnprint.Visible = False
            '  MsgBox(Format(dttdttglptg.Value, "yyyyMMdd"))
            initializedg()
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            'btnprint.Visible = True
        End If
        Me.Select() : txtnobkt.Select()
    End Sub

    Private Sub dgview_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgview.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf CellValidation
    End Sub

    Sub CellValidation(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim colname As String = dgview.Columns(dgview.CurrentCellAddress.X).Name
        Dim strval As String = dgview.CurrentCell.EditedFormattedValue.ToString

        If colname = "nilai" Or colname = "tariff" Or colname = "pph" Then
            If cl.cChr(dgview.Rows(dgview.CurrentRow.Index).Cells("kdobj").Value) = "" Then
                e.KeyChar = ""
            Else
                If Not (e.KeyChar = "." And InStr((strval), ".") = 0) And Not (e.KeyChar = "-" And InStr((strval), "-") = 0) Then
                    If InStr(("0123456789"), e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Then
                        e.KeyChar = ""
                    End If
                End If
            End If

        ElseIf colname <> "nilai" And colname <> "tariff" And colname <> "kdobj" Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub initdate()
        Dim iDate As String = "01/" & masapjknum & "/" & thnpjk & ""
        Dim odate As DateTime = Convert.ToDateTime(iDate)
        Dim MyDate As Date = odate
        Dim DaysInMonth As Integer = Date.DaysInMonth(MyDate.Year, MyDate.Month)
        Dim LastDayInMonthDate As Date = New Date(MyDate.Year, MyDate.Month, DaysInMonth)

        txttglptg.Text = LastDayInMonthDate
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnobkt.Select()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnobkt, "No Bukti Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If

            If validatetxtnull(txtnpwp, "No NPWP Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            '------ CheckBox WP Asing validation
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If
            '------- END WPASING

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data PPh Psl 4(2) : " & txtnobkt.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stpph42 (" &
                         "  '" & .cChr(txtnobkt.Text) & "'" &
                       " , '" & Format(dttdttglptg.Value, "yyyyMMdd") & "'" &
                       " , '" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtalamatptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(cmbjnstransaksi.Text) & "'" &
                        " ,'" & .cChr(txtnobuktiptg.Text) & "'" &
                        " ,'" & .cChr(txtterbilang.Text) & "'" &
                        " ,'" & .cNum(txttotal.Text) & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ") ")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kdobj").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stpph42d (" &
                            " '" & .cChr(txtnobkt.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kdobj").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("nilai").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("tariff").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pph").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'BARU'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtnobkt.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data PPh Psl 4(2) : " & txtnobkt.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                         "CALL stpph42 (" &
                         "  '" & .cChr(txtnobkt.Text) & "'" &
                       " , '" & Format(dttdttglptg.Value, "yyyyMMdd") & "'" &
                       " , '" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtalamatptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(cmbjnstransaksi.Text) & "'" &
                        " ,'" & .cChr(txtnobuktiptg.Text) & "'" &
                        " ,'" & .cChr(txtterbilang.Text) & "'" &
                        " ,'" & .cNum(txttotal.Text) & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ") ")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kdobj").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stpph42d (" &
                            " '" & .cChr(txtnobkt.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kdobj").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("nilai").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("tariff").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pph").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'MODIF'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnobkt.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tpph42
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tpph42 TA WHERE TA.stat = 1 AND masapjk='" & masapjk & "' AND thnpjk= '" & thnpjk & "'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("nobkt").Visible = True : .Columns("nobkt").HeaderText = "No Bukti"
            .Columns("tglptg").Visible = True : .Columns("tglptg").HeaderText = "Tgl Potong"
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama Potong"
            .Columns("jnstransaksi").Visible = True : .Columns("jnstransaksi").HeaderText = "Jns Transaksi"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[tpph42]tpph42")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tpph42'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data PPh Psl 4(2) : " & txtnpwp.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                       "CALL stpph42 (" &
                         "  '" & .cChr(txtnobkt.Text) & "'" &
                       " , " & .cDt(dttdttglptg) & "" &
                       " , '" & .cChr(txttglptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & .cChr(txtalamatptg.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(cmbjnstransaksi.Text) & "'" &
                        " ,'" & .cChr(txtnobuktiptg.Text) & "'" &
                        " ,'" & .cChr(txtterbilang.Text) & "'" &
                        " ,'" & .cNum(txttotal.Text) & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ") ")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnpwp.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btnmnegara_Click(sender As Object, e As EventArgs) Handles btnmlwntransaksi.Click
        Dim a As New search

        Dim sql As String = "SELECT TA.* FROM mpenghasil TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"

        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[mpenghasil]tpph42")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Public Sub getcalculate()
        Dim total As Decimal

        With dgview
            For a As Integer = 0 To .Rows.Count - 1
                If cl.cChr(.Rows(a).Cells("kdobj").Value) <> "" Then
                    .Rows(a).Cells("nilai").Value = cl.cCur(.Rows(a).Cells("nilai").Value)
                    .Rows(a).Cells("tariff").Value = cl.cCur(.Rows(a).Cells("tariff").Value)
                    .Rows(a).Cells("pph").Value = cl.cCur(cl.cNum(.Rows(a).Cells("nilai").Value) * (cl.cNum(.Rows(a).Cells("tariff").Value) / 100))
                    total += cl.cNum(.Rows(a).Cells("pph").Value)
                End If
            Next
            txttotal.Text = cl.cCur(total)
            Try : terbilang() : Catch : End Try
        End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub

    Private Sub dgview_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellEndEdit
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

    Dim t As New Terbilang

    Private Sub dgview_KeyDown(sender As Object, e As KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgview.CurrentRow.Index <> dgview.Rows.Count - 1 Then
                dgview.Rows.RemoveAt(dgview.CurrentRow.Index)
                getcalculate()
            End If
        End If
    End Sub

    Sub terbilang()
        Dim total As Decimal
        Dim currency As String = " Rupiah"
        total = cl.cNum(txttotal.Text)

        If cl.cNum(txttotal.Text) > 0 Then
            t.Text = cl.cNum(txttotal.Text)
        End If
        txtterbilang.Text = t.Text & currency
    End Sub

End Class