Public Class tbuktiptgtdkfinal
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
            .Columns(0).Name = "kdobjpjk" : .Columns(0).HeaderText = "Kd Object Pajak"
            .Columns(1).Name = "bruto" : .Columns(1).HeaderText = "Bruto (Rp.)"
            .Columns(2).Name = "dpp" : .Columns(2).HeaderText = "DPP"
            .Columns(3).Name = "tnpwp" : .Columns(3).HeaderText = "Tanpa NPWP" : .Columns(3).Visible = False
            .Columns(4).Name = "trf" : .Columns(4).HeaderText = "Tarif (%)"
            .Columns(5).Name = "pphptg" : .Columns(5).HeaderText = "PPh Di Ptg"
        End With
        adjcolumn()
    End Sub
    Private Sub adjcolumn()
        dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With dgview
            .Columns("kdobjpjk").Width = 60
            .Columns("bruto").Width = 60
            .Columns("dpp").Width = 60
            .Columns("tnpwp").Width = 80
            .Columns("trf").Width = 80
            .Columns("bruto").Width = 80
            .Columns("pphptg").Width = 100

            .Columns("bruto").DefaultCellStyle.Format = "n2"
            .Columns("dpp").DefaultCellStyle.Format = "n2"
            .Columns("tnpwp").DefaultCellStyle.Format = "n2"
            .Columns("trf").DefaultCellStyle.Format = "n2"
            .Columns("pphptg").DefaultCellStyle.Format = "n2"


            .Columns("kdobjpjk").DefaultCellStyle.BackColor = Color.MistyRose
            .Columns("bruto").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("dpp").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("tnpwp").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("trf").DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns("pphptg").DefaultCellStyle.BackColor = Color.MistyRose
        End With

    End Sub

    'Private Sub gencode()
    '    txtcode.Text = cl.readData("SELECT dbo.fgetcode('msales','')")
    'End Sub

    Private Sub clearData()
        txtnobkt.Text = ""
        txtnobkt_rl.Text = ""
        txtnpwp.Text = ""

        txtnpwpptg.Text = cl.readData("SELECT npwpttd FROM mprofile WHERE id = 1")
        txtnamaptg.Text = cl.readData("SELECT namattd FROM mprofile WHERE id = 1")

        txtnama.Text = ""
        txtalamat.Text = ""
        txtnikpssprt.Text = ""
        chwpasing.Checked = False
        txtkn.Text = ""
        txtkn_rl.Text = ""
        txtobpjk.Text = ""
        dttdate.Text = ""

        dgview.Rows.Clear()

        BtnBrowse1.Enabled = False

    End Sub
    Private Sub valikn()
        If chwpasing.Checked = True Then
            BtnBrowse1.Enabled = True
        Else
            BtnBrowse1.Enabled = False
            txtkn.Text = ""
            txtkn_rl.Text = ""
        End If
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            'gencode()
            btndelete.Visible = False
            btnprint.Visible = False
            initializedg()
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True
        End If
        Me.Select() : txtnobkt.Select()
    End Sub
    Private Sub dgview_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgview.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf CellValidation
    End Sub
    Sub CellValidation(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim colname As String = dgview.Columns(dgview.CurrentCellAddress.X).Name
        Dim strval As String = dgview.CurrentCell.EditedFormattedValue.ToString

        If colname = "bruto" Or colname = "dpp" Or colname = "trf" Or colname = "pphptg" Then
            If cl.cChr(dgview.Rows(dgview.CurrentRow.Index).Cells("kdobjpjk").Value) = "" Then
                e.KeyChar = ""
            Else
                If Not (e.KeyChar = "." And InStr((strval), ".") = 0) And Not (e.KeyChar = "-" And InStr((strval), "-") = 0) Then
                    If InStr(("0123456789"), e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Then
                        e.KeyChar = ""
                    End If
                End If
            End If

        ElseIf colname <> "bruto" And colname <> "dpp" And colname <> "tnpwp" And colname <> "trf" And colname <> "pphptg" And colname <> "kdobjpjk" Then
            e.KeyChar = ""
        End If
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
            '------ end validasi
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgtdkfinal'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnobkt.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stbuktiptgtdkfinal (" &
                        "  '" & .cChr(txtnobkt.Text) & "'" &
                        " ,'" & .cChr(txtnobkt_rl.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(txtkn.Text) & "'" &
                        " ,'" & .cChr(txtkn_rl.Text) & "'" &
                        " ,'" & .cChr(txtobpjk.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & Format(dttdate.Value, "yyyyMMdd") & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kdobjpjk").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stbuktiptgtdkfinald (" &
                            " '" & .cChr(txtnobkt.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kdobjpjk").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("bruto").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("dpp").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("tnpwp").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("trf").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pphptg").Value) & "'" &
                            " , ''" &
                            " , '" & idusr & "'" &
                            " , 'BARU'" &
                            " , '" & idmaster & "'" &
                            ")")
                        End If
                    Next

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txtnobkt.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgtdkfinal'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnobkt.Text & " ?", "Confirmation")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stbuktiptgtdkfinal (" &
                        "  '" & .cChr(txtnobkt.Text) & "'" &
                        " ,'" & .cChr(txtnobkt_rl.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,'" & wpasing & "'" &
                        " ,'" & .cChr(txtkn.Text) & "'" &
                        " ,'" & .cChr(txtkn_rl.Text) & "'" &
                        " ,'" & .cChr(txtobpjk.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & Format(dttdate.Value, "yyyyMMdd") & "'" &
                         " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")

                    For i As Integer = 0 To dgview.Rows.Count - 1
                        If .cChr(dgview.Rows(i).Cells("kdobjpjk").Value) <> "" Then
                            .execCmdTrans(
                            "CALL stbuktiptgtdkfinald (" &
                            " '" & .cChr(txtnobkt.Text) & "'" &
                            " , '" & .cChr(dgview.Rows(i).Cells("kdobjpjk").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("bruto").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("dpp").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("tnpwp").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("trf").Value) & "'" &
                            " , '" & .cNum(dgview.Rows(i).Cells("pphptg").Value) & "'" &
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
        Dim frm As New tbuktiptgtdkfinal
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = "SELECT TA.* FROM tbuktiptgtdkfinal TA WHERE TA.stat = 1 AND masapjk='" & masapjk & "' AND thnpjk= '" & thnpjk & "'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("nobkt").Visible = True : .Columns("nobkt").HeaderText = "No Bukti"
            .Columns("nobkt_rl").Visible = True : .Columns("nobkt_rl").HeaderText = "No Bukti RL"
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("nikpssprt").Visible = True : .Columns("nikpssprt").HeaderText = "NIK / Passport"
            '.Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
            '.Columns("wpasing").Visible = True : .Columns("wpasing").HeaderText = "WP Asing"
            '.Columns("kn").Visible = True : .Columns("kn").HeaderText = "Kode Negara"
            '.Columns("kn_rl").Visible = True : .Columns("kn_rl").HeaderText = "Kode Negara RL"
            '.Columns("objpjk").Visible = True : .Columns("objpjk").HeaderText = "Objek Pajak"
            '.Columns("npwpptg").Visible = True : .Columns("npwpptg").HeaderText = "NPWP Potong"
            '.Columns("namaptg").Visible = True : .Columns("namaptg").HeaderText = "Nama Potong"
            '.Columns("tanggal").Visible = True : .Columns("tanggal").HeaderText = "Date"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[tbuktiptgtdkfinal]tbuktiptgtdkfinal")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbuktiptgtdkfinal'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnpwp.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stbuktiptgtdkfinal (" &
                        "  '" & .cChr(txtnobkt.Text) & "'" &
                        " ,'" & .cChr(txtnobkt_rl.Text) & "'" &
                        " ,'" & .cChr(txtnpwp.Text) & "'" &
                        " ,'" & .cChr(txtnama.Text) & "'" &
                        " ,'" & .cChr(txtnikpssprt.Text) & "'" &
                        " ,'" & .cChr(txtalamat.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(txtkn.Text) & "'" &
                        " ,'" & .cChr(txtkn_rl.Text) & "'" &
                        " ,'" & .cChr(txtobpjk.Text) & "'" &
                        " ,'" & .cChr(txtnpwpptg.Text) & "'" &
                        " ,'" & .cChr(txtnamaptg.Text) & "'" &
                        " ,'" & Format(dttdate.Value, "yyyyMMdd") & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnpwp.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        'Me.Close()
    End Sub
    Public Sub getcalculate()
        Dim total As Decimal

        With dgview
            For a As Integer = 0 To .Rows.Count - 1
                If cl.cChr(.Rows(a).Cells("kdobjpjk").Value) <> "" Then
                    .Rows(a).Cells("bruto").Value = cl.cCur(.Rows(a).Cells("bruto").Value)
                    .Rows(a).Cells("dpp").Value = cl.cCur(.Rows(a).Cells("dpp").Value)
                    .Rows(a).Cells("tnpwp").Value = cl.cCur(.Rows(a).Cells("tnpwp").Value)
                    .Rows(a).Cells("trf").Value = cl.cCur(.Rows(a).Cells("trf").Value)
                    .Rows(a).Cells("pphptg").Value = cl.cCur(cl.cNum(.Rows(a).Cells("dpp").Value) * (cl.cNum(.Rows(a).Cells("trf").Value) / 100))
                    total += cl.cNum(.Rows(a).Cells("pphptg").Value)
                End If
            Next
            'txttotal.Text = cl.cCur(total)
            'Terbilang()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getcalculate()
    End Sub

    Private Sub dgview_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellEndEdit
        getcalculate()
    End Sub

    Private Sub btnfilter2_Click(sender As Object, e As EventArgs) Handles btnfilter2.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mpenghasil TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("nik").Visible = True : .Columns("nik").HeaderText = "NIK / PASSPORT"
            .Columns("alamat").Visible = True : .Columns("alamat").HeaderText = "Alamat"
        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[mpenghasil]tbuktiptgtdkfinal")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub BtnBrowse1_Click(sender As Object, e As EventArgs) Handles BtnBrowse1.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM mnegara TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("code").Visible = True : .Columns("code").HeaderText = "Kode"
            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
        End With
        a.loadStatusTempForm(Me, Me.txtkn, "[mnegara]tbuktiptgtdkfinal")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub BtnBrowse2_Click(sender As Object, e As EventArgs) Handles BtnBrowse2.Click
        Dim a As New search

        Dim sql As String = "SELECT TA.* FROM mobjkpjk TA WHERE TA.stat = 1 AND TA.jnspjk = 'PPh 21' AND TA.kode NOT LIKE '%FINAL%'"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("kode").Visible = True : .Columns("kode").HeaderText = "Kode"
            .Columns("objkpjk").Visible = True : .Columns("objkpjk").HeaderText = "Objek Pajak"
            .Columns("jnspjk").Visible = True : .Columns("jnspjk").HeaderText = "Jenis Pajak"
        End With
        a.loadStatusTempForm(Me, Me.txtobpjk, "[mobjkpjkh]tbuktiptgtdkfinal")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
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

    Private Sub chwpasing_CheckedChanged(sender As Object, e As EventArgs) Handles chwpasing.CheckedChanged
        valikn()
    End Sub

    Private Sub txtobpjk_TextChanged(sender As Object, e As EventArgs) Handles txtobpjk.TextChanged

    End Sub
    Private Sub dgview_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Tab Then
            Dim colname As String = dgview.Columns(dgview.CurrentCellAddress.X).Name
            If colname = "kdobjpjk" And txtobpjk.Text = "" Then
                Dim a As New search
                Dim sql As String = " SELECT TA.* FROM mobjkpjk TA WHERE TA.stat = 1 AND TA.jnspjk = 'PPh 21'"
                With a.dgview : .DataSource = cl.table(sql)
                    For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
                    .Columns("kode").Visible = True : .Columns("kode").HeaderText = "Kode"
                    .Columns("objkpjk").Visible = True : .Columns("objkpjk").HeaderText = "Objek Pajak"
                    .Columns("jnspjk").Visible = True : .Columns("jnspjk").HeaderText = "Jenis Pajak"
                End With
                a.loadStatusTempForm(Me, Me.txtobpjk, "[mobjkpjk]tbuktiptgtdkfinal")
                a.loadSQLSearch(sql, 1)
                a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

                cekform(a, "SEARCH", Me)
            ElseIf colname = "kdobjpjk" And txtobpjk.Text <> "" Then
                dgview.Item("kdobjpjk", dgview.CurrentRow.Index).Value = txtobpjk.Text
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            If dgview.CurrentRow.Index <> dgview.Rows.Count - 1 Then
                dgview.Rows.RemoveAt(dgview.CurrentRow.Index)
                getcalculate()
            End If
        End If
    End Sub
End Class