Imports CrystalDecisions.CrystalReports.Engine
Public Class creminder
    Dim idmaster As Integer = 0, statform As String = ""

    Dim statusTempForm, varTempForm, varTempForm2 As String
    Dim tempForm As Form
    Dim tempFromObj As Object, tempToObj As Object
    Dim itemtable As New DataTable
    Dim SQLSearch As String
    Dim statSQLSearch As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            Me.Dispose()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.Down) Then
            ' If dgview.Rows.Count = 0 Then
            '    txtsearch.Select()
            'Else
            '    If txtsearch.Focused = True Then
            '        Me.dgview.Select()
            '    ElseIf dgview.CurrentRow.Index = dgview.Rows.Count - 1 Then
            '        txtsearch.Select()
            '    End If
            'End If
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.Up) Then
                'If dgview.CurrentRow.Index = 0 Then
                '    txtsearch.Select()
                'Else
                '    Me.dgview.Select()
                'End If

            ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then
            'Me.txtsearch.Select()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Public Sub loadSQLSearch(ByVal sql As String, Optional ByVal statSearch As Integer = 0)
        SQLSearch = "SELECT * FROM (" & sql & ") TS"
        statSQLSearch = statSearch
    End Sub
    Public Sub loadStatusTempForm(ByVal tempAsalForm As Form, ByVal fromObj As Object, ByVal toObj As Object, ByVal temp As String)
        tempForm = tempAsalForm
        tempFromObj = fromObj
        tempToObj = toObj

        statusTempForm = temp
    End Sub

    'Private Sub loadcmb()
    '    Dim dtemptp As DataTable = cl.table(
    '        "SELECT 'S' AS 'value', 'SALES ORDER' AS 'display' " &
    '        " UNION SELECT 'D' , 'SURAT JALAN' UNION SELECT 'F' , 'FAKTUR PENJUALAN' ")

    '    cmbcriteria2.DataSource = dtemptp
    '    cmbcriteria2.ValueMember = "value"
    '    cmbcriteria2.DisplayMember = "display"

    '    'End If
    'End Sub

    Private Sub vpurchasekaingrey_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And dgview.Focused = False Then
            Me.ProcessTabKey(True)
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up And dgview.Focused = False Then
            Me.ProcessTabKey(False)
            e.Handled = True
        End If
    End Sub

    Private Sub vkaingrey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' chfinish.Checked = True
        '   lblidmbp.Text = 0
        txttotal.Text = 0
        '   loadcmb()

        'dtfrom.Text = Format(Now(), "dd/MM/yyyy").ToString
        'dtto.Text = Format(Now(), "dd/MM/yyyy").ToString

    End Sub
    Private Sub vdistkaingrey_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() ': btnview.Select()
    End Sub

    Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick

    End Sub

    Private Sub dgDetail_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgview.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgview.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentUICulture) + 1,
                                   dgview.DefaultCellStyle.Font,
                                   b,
                                   e.RowBounds.Location.X + 20,
                                   e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub ApproveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApproveToolStripMenuItem.Click
        With cl
            If dgview.Item("jenis", dgview.CurrentRow.Index).Value = "SALES ORDER" Then
                If cl.readData("SELECT approved FROM tso WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "' AND stat = 1") = "Y" Then
                    .msgError("SO sudah di approve !", "Informasi")
                    Exit Sub
                End If

                Dim tny As Integer
                tny = .msgYesNo("Approve Sales Order : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()

                    .execCmdTrans(
                        "UPDATE tso SET approved = 'Y', usr_approve = '" & idusr & "' " &
                        " , dt_approve = '" & Format(Now(), "yyyyMMdd") & "'" &
                        " WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'" &
                        "")

                    .closeTrans(ApproveToolStripMenuItem)
                    If .sCloseTrans = 1 Then
                        .msgInform("Sukses Approval Sales Order : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " !", "Informasi")
                    End If
                End If
            ElseIf dgview.Item("jenis", dgview.CurrentRow.Index).Value = "SURAT JALAN" Then
                If cl.readData("SELECT approved FROM tdo WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "' AND stat = 1") = "Y" Then
                    .msgError("SURAT JALAN sudah di approve !", "Informasi")
                    Exit Sub
                End If

                Dim tny As Integer
                tny = .msgYesNo("Approve Surat Jalan : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()

                    .execCmdTrans(
                        "UPDATE tdo SET approved = 'Y', usr_approve = '" & idusr & "' " &
                        " , dt_approve = '" & Format(Now(), "yyyyMMdd") & "'" &
                        " WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'" &
                        "")

                    .closeTrans(ApproveToolStripMenuItem)
                    If .sCloseTrans = 1 Then
                        .msgInform("Sukses Approval Surat Jalan : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " !", "Informasi")
                    End If
                End If
            ElseIf dgview.Item("jenis", dgview.CurrentRow.Index).Value = "PURCHASE ORDER" Then
                If cl.readData("SELECT approved FROM tpo WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "' AND stat = 1") = "Y" Then
                    .msgError("PURCHASE ORDER sudah di approve !", "Informasi")
                    Exit Sub
                End If

                Dim tny As Integer
                tny = .msgYesNo("Approve Purchase Order : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()

                    .execCmdTrans(
                        "UPDATE tpo SET approved = 'Y', usr_approve = '" & idusr & "' " &
                        " , dt_approve = '" & Format(Now(), "yyyyMMdd") & "'" &
                        " WHERE id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'" &
                        "")

                    .closeTrans(ApproveToolStripMenuItem)
                    If .sCloseTrans = 1 Then
                        .msgInform("Sukses Approval Purchase Order : " & dgview.Item("no", dgview.CurrentRow.Index).Value & " !", "Informasi")
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub chfinish_CheckedChanged(sender As Object, e As EventArgs) Handles chfinish.CheckedChanged
        'If chfinish.Checked = True Then
        '    If (dgview.Rows.Count > 0) Then
        '        For Each row As DataGridViewRow In dgview.Rows
        '            If row.Cells("approved").Value.ToString.Contains("N") Then
        '                dgview.Rows.Item(row.Index).Visible = False
        '            End If
        '        Next
        '    End If
        'Else
        '    If (dgview.Rows.Count > 0) Then
        '        For Each row As DataGridViewRow In dgview.Rows
        '            If row.Cells("approved").Value.ToString.Contains("Y") Then
        '                dgview.Rows.Item(row.Index).Visible = True
        '            End If
        '        Next
        '    End If
        'End If
    End Sub

    Private Sub btnbrowsembp_Click(sender As Object, e As EventArgs)
        ' searchbp("btnbrowsembp")
    End Sub

    Private Sub txtname_msupp_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub searchbp(ByVal sender As String)
    '    If sender = "btnbrowsembp" Then
    '        Dim a As New tsearch
    '        Dim sqlStr As String =
    '            "SELECT * FROM mitem WHERE tstatus = 1"

    '        With a.dgview : .DataSource = cl.table(sqlStr)
    '            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
    '            .Columns("name").Visible = True : .Columns("name").HeaderText = "Nama"
    '            .Columns("name_muom").Visible = True : .Columns("name_muom").HeaderText = "Satuan"
    '            .Columns("name_mitemgrp").Visible = True : .Columns("name_mitemgrp").HeaderText = "Tipe"
    '        End With

    '        a.loadStatusTempForm(Me, Me.txtname_msupp, Me.txtname_msupp, "[mitem]rptsperbrg")
    '        a.loadSQLSearch(sqlStr, 1)
    '        a.Text = "Pencarian : Item"

    '        cl.CheckForm(a, "SEARCH", Me)

    '    End If
    'End Sub

    'Private Sub dgview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellContentClick

    'End Sub

    'Private Sub txtname_msupp_DoubleClick(sender As Object, e As EventArgs)
    '    lblidmbp.Text = 0
    '    txtname_msupp.Text = ""
    'End Sub



    Private Sub dgview2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgview_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgview.CellDoubleClick
        Dim i As Integer = 0
        '--delete all the rows, make sure its clean
        Try : dgview.Rows.Clear() : Catch : End Try

        'If dgview.Item("jenis", dgview.CurrentRow.Index).Value = "SALES ORDER" Then
        '    Dim a As New tso
        '    cekform(a, "NEW", Me)

        '    Dim sql As String = " SELECT T0.*, T1.code 'code_mcust', T1.name 'name_mcust' " &
        '    " FROM tso T0 LEFT JOIN mcust T1 ON T0.id_mcust = T1.id WHERE T0.stat = 1 " &
        '        " AND T0.id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'"

        '    With dgviewdetail : .DataSource = cl.table(sql) : End With
        '    dgviewdetail.CurrentCell = dgviewdetail.Item(0, 0)
        '    i = dgviewdetail.CurrentRow.Index
        '    With Me.dgviewdetail
        '        a.getidmaster(cl.cNum(.Item("id", i).Value))
        '        a.txtno.Text = cl.cChr(.Item("no", i).Value)
        '        a.txtcode_mcust.Text = cl.cChr(.Item("code_mcust", i).Value)
        '        a.txtname_mcust.Text = cl.cChr(.Item("name_mcust", i).Value)
        '        a.txtaddr1.Text = cl.cChr(.Item("addr1", i).Value)
        '        a.txtaddr2.Text = cl.cChr(.Item("addr2", i).Value)

        '        a.txtrefno.Text = cl.cChr(.Item("refno", i).Value)

        '        '  a.cmbjenis.Text = cl.cChr(.Item("jenis", i).Value)

        '        a.cmbfob.SelectedValue = cl.cChr(.Item("fob", i).Value)
        '        a.cmbship.SelectedValue = cl.cNum(.Item("id_mship", i).Value)
        '        a.cmbtop.SelectedValue = cl.cNum(.Item("id_top", i).Value)
        '        a.cmbsales.SelectedValue = cl.cNum(.Item("id_msales", i).Value)

        '        a.dttdt.Text = cl.cChr(.Item("tdt", i).Value)
        '        a.dttdt2.Text = cl.cChr(.Item("tdt2", i).Value)
        '        a.txtnote.Text = cl.cChr(.Item("note", i).Value)
        '        a.lblid_mcust.Text = cl.cNum(.Item("id_mcust", i).Value)

        '        '  a.txtsubtotal.Text = cl.cCur(.Item("subtotal", i).Value)
        '        'a.txtdiscpcg.Text = cl.cCur(.Item("discpcg", i).Value)
        '        'If cl.cNum(.Item("disctotal", i).Value) > 0 Then
        '        '    a.chdisc.Checked = True
        '        'Else
        '        '    a.chdisc.Checked = False
        '        'End If
        '        '    a.txtdisctotal.Text = cl.cCur(.Item("disctotal", i).Value)
        '        'a.txttaxtotal.Text = cl.cCur(.Item("taxtotal", i).Value)
        '        If cl.cNum(.Item("taxtotal", i).Value) > 0 Then
        '            a.chppn.Checked = True
        '        Else
        '            a.chppn.Checked = False
        '        End If
        '        a.txtfreight.Text = cl.cCur(.Item("freight", i).Value)
        '        a.txtgrdtotal.Text = cl.cCur(.Item("grdtotal", i).Value)

        '        'If cl.readData("SELECT ftsoHEADER('" & cl.cNum(.Item("id", i).Value) & "')-ftdoHEADER('" & cl.cNum(.Item("id", i).Value) & "') ") = 0 Then
        '        '    a.lblprocess.Visible = True
        '        'Else
        '        '    a.lblprocess.Visible = False
        '        'End If

        '        Dim dtdet As DataTable = Nothing
        '        dtdet = cl.table(
        '        "Select TA.*, TB.code 'code_mitem', TB.name 'name_mitem', TC.name 'code_muom' " &
        '        " FROM tsod TA INNER JOIN mitm TB ON TA.id_mitm = TB.id INNER JOIN muom TC ON TA.id_muom = TC.id " &
        '        " WHERE TA.stat = 1 " &
        '        " AND TA.id_tsoh = " & cl.cNum(.Item("id", i).Value))

        '        a.dgview.Rows.Clear()
        '        Dim rrowpl As Integer = 0
        '        For r As Integer = 0 To dtdet.Rows.Count - 1
        '            rrowpl = a.dgview.Rows.Add
        '            With dtdet
        '                a.dgview.Rows(rrowpl).Cells("id_mitem").Value = .Rows(r).Item("id_mitm")
        '                a.dgview.Rows(rrowpl).Cells("id_muom").Value = .Rows(r).Item("id_muom")

        '                a.dgview.Rows(rrowpl).Cells("code_mitem").Value = .Rows(r).Item("code_mitem")
        '                a.dgview.Rows(rrowpl).Cells("name_mitem").Value = .Rows(r).Item("name_mitem")
        '                a.dgview.Rows(rrowpl).Cells("code_muom").Value = .Rows(r).Item("code_muom")
        '                a.dgview.Rows(rrowpl).Cells("qty").Value = cl.cCur(.Rows(r).Item("qty"))
        '                a.dgview.Rows(rrowpl).Cells("price").Value = cl.cCur(.Rows(r).Item("price"))

        '                If cl.cNum(.Rows(r).Item("discpcg1")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = cl.cCur(.Rows(r).Item("discpcg1"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg2")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = cl.cCur(.Rows(r).Item("discpcg2"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg3")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = cl.cCur(.Rows(r).Item("discpcg3"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = 0
        '                End If

        '                a.dgview.Rows(rrowpl).Cells("subtotal").Value = cl.cCur(.Rows(r).Item("subtotal"))
        '            End With
        '        Next
        '    End With
        '    a.getcalculate()
        '    a.changestatform("upd")

        '    '-- DISABLE ALL BUTTONS
        '    a.btnsave.Enabled = False
        '    a.btnapprove.Enabled = False
        '    a.btnlist.Enabled = False
        '    a.btndelete.Enabled = False
        '    a.btnrefresh.Enabled = False
        'ElseIf dgview.Item("jenis", dgview.CurrentRow.Index).Value = "PURCHASE ORDER" Then
        '    Dim a As New tpo
        '    cekform(a, "NEW", Me)

        '    Dim sql As String = " SELECT T0.*, T1.code 'code_msupp', T1.name 'name_msupp' " &
        '    " FROM tpo T0 LEFT JOIN msupp T1 ON T0.id_msupp = T1.id WHERE T0.stat = 1 " &
        '        " AND T0.id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'"

        '    With dgviewdetail : .DataSource = cl.table(sql) : End With
        '    dgviewdetail.CurrentCell = dgviewdetail.Item(0, 0)
        '    i = dgviewdetail.CurrentRow.Index
        '    With Me.dgviewdetail
        '        a.getidmaster(cl.cNum(.Item("id", i).Value))
        '        a.txtno.Text = cl.cChr(.Item("no", i).Value)
        '        a.txtcode_msupp.Text = cl.cChr(.Item("code_msupp", i).Value)
        '        a.txtname_msupp.Text = cl.cChr(.Item("name_msupp", i).Value)
        '        a.txtaddr1.Text = cl.cChr(.Item("addr1", i).Value)
        '        a.txtaddr2.Text = cl.cChr(.Item("addr2", i).Value)

        '        '  a.txtrefno.Text = cl.cChr(.Item("refno", i).Value)

        '        '  a.cmbjenis.Text = cl.cChr(.Item("jenis", i).Value)

        '        a.cmbfob.SelectedValue = cl.cChr(.Item("fob", i).Value)
        '        a.cmbship.SelectedValue = cl.cNum(.Item("id_mship", i).Value)
        '        a.cmbtop.SelectedValue = cl.cNum(.Item("id_top", i).Value)
        '        '   a.cmbsales.SelectedValue = cl.cNum(.Item("id_msales", i).Value)

        '        a.dttdt.Text = cl.cChr(.Item("tdt", i).Value)
        '        a.dttdt2.Text = cl.cChr(.Item("tdt2", i).Value)
        '        a.txtnote.Text = cl.cChr(.Item("note", i).Value)
        '        a.lblid_msupp.Text = cl.cNum(.Item("id_msupp", i).Value)

        '        '  a.txtsubtotal.Text = cl.cCur(.Item("subtotal", i).Value)
        '        'a.txtdiscpcg.Text = cl.cCur(.Item("discpcg", i).Value)
        '        'If cl.cNum(.Item("disctotal", i).Value) > 0 Then
        '        '    a.chdisc.Checked = True
        '        'Else
        '        '    a.chdisc.Checked = False
        '        'End If
        '        '    a.txtdisctotal.Text = cl.cCur(.Item("disctotal", i).Value)
        '        'a.txttaxtotal.Text = cl.cCur(.Item("taxtotal", i).Value)
        '        If cl.cNum(.Item("taxtotal", i).Value) > 0 Then
        '            a.chppn.Checked = True
        '        Else
        '            a.chppn.Checked = False
        '        End If
        '        a.txtfreight.Text = cl.cCur(.Item("freight", i).Value)
        '        a.txtgrdtotal.Text = cl.cCur(.Item("grdtotal", i).Value)

        '        'If cl.readData("SELECT ftsoHEADER('" & cl.cNum(.Item("id", i).Value) & "')-ftdoHEADER('" & cl.cNum(.Item("id", i).Value) & "') ") = 0 Then
        '        '    a.lblprocess.Visible = True
        '        'Else
        '        '    a.lblprocess.Visible = False
        '        'End If

        '        Dim dtdet As DataTable = Nothing
        '        dtdet = cl.table(
        '        "Select TA.*, TB.code 'code_mitem', TB.name 'name_mitem', TC.name 'code_muom' " &
        '        " FROM tpod TA INNER JOIN mitm TB ON TA.id_mitm = TB.id INNER JOIN muom TC ON TA.id_muom = TC.id " &
        '        " WHERE TA.stat = 1 " &
        '        " AND TA.id_tpoh = " & cl.cNum(.Item("id", i).Value))

        '        a.dgview.Rows.Clear()
        '        Dim rrowpl As Integer = 0
        '        For r As Integer = 0 To dtdet.Rows.Count - 1
        '            rrowpl = a.dgview.Rows.Add
        '            With dtdet
        '                a.dgview.Rows(rrowpl).Cells("id_mitem").Value = .Rows(r).Item("id_mitm")
        '                a.dgview.Rows(rrowpl).Cells("id_muom").Value = .Rows(r).Item("id_muom")

        '                a.dgview.Rows(rrowpl).Cells("code_mitem").Value = .Rows(r).Item("code_mitem")
        '                a.dgview.Rows(rrowpl).Cells("name_mitem").Value = .Rows(r).Item("name_mitem")
        '                a.dgview.Rows(rrowpl).Cells("code_muom").Value = .Rows(r).Item("code_muom")
        '                a.dgview.Rows(rrowpl).Cells("qty").Value = cl.cCur(.Rows(r).Item("qty"))
        '                a.dgview.Rows(rrowpl).Cells("price").Value = cl.cCur(.Rows(r).Item("price"))

        '                If cl.cNum(.Rows(r).Item("discpcg1")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = cl.cCur(.Rows(r).Item("discpcg1"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg2")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = cl.cCur(.Rows(r).Item("discpcg2"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg3")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = cl.cCur(.Rows(r).Item("discpcg3"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = 0
        '                End If

        '                a.dgview.Rows(rrowpl).Cells("subtotal").Value = cl.cCur(.Rows(r).Item("subtotal"))
        '            End With
        '        Next
        '    End With
        '    a.getcalculate()
        '    a.changestatform("upd")

        '    '-- DISABLE ALL BUTTONS
        '    a.btnsave.Enabled = False
        '    a.btnapprove.Enabled = False
        '    a.btnlist.Enabled = False
        '    a.btndelete.Enabled = False
        '    a.btnrefresh.Enabled = False
        'ElseIf dgview.Item("jenis", dgview.CurrentRow.Index).Value = "SURAT JALAN" Then
        '    Dim a As New tdo
        '    cekform(a, "NEW", Me)

        '    Dim sql As String = " SELECT T0.*, T1.code 'code_mcust', T1.name 'name_mcust' " &
        '    " FROM tdo T0 LEFT JOIN mcust T1 ON T0.id_mcust = T1.id WHERE T0.stat = 1 " &
        '        " AND T0.id = '" & dgview.Item("id", dgview.CurrentRow.Index).Value & "'"

        '    With dgviewdetail : .DataSource = cl.table(sql) : End With
        '    dgviewdetail.CurrentCell = dgviewdetail.Item(0, 0)
        '    i = dgviewdetail.CurrentRow.Index
        '    With Me.dgviewdetail
        '        a.getidmaster(cl.cNum(.Item("id", i).Value))
        '        a.txtno.Text = cl.cChr(.Item("no", i).Value)
        '        a.txtcode_mcust.Text = cl.cChr(.Item("code_mcust", i).Value)
        '        a.txtname_mcust.Text = cl.cChr(.Item("name_mcust", i).Value)
        '        a.txtaddr1.Text = cl.cChr(.Item("addr1", i).Value)
        '        a.txtaddr2.Text = cl.cChr(.Item("addr2", i).Value)

        '        a.txtrefno.Text = cl.cChr(.Item("refno", i).Value)

        '        '  a.cmbjenis.Text = cl.cChr(.Item("jenis", i).Value)

        '        '   a.cmbfob.SelectedValue = cl.cChr(.Item("fob", i).Value)
        '        a.cmbship.SelectedValue = cl.cNum(.Item("id_mship", i).Value)
        '        a.cmbtop.SelectedValue = cl.cNum(.Item("id_top", i).Value)
        '        ' a.cmbsales.SelectedValue = cl.cNum(.Item("id_msales", i).Value)

        '        a.dttdt.Text = cl.cChr(.Item("tdt", i).Value)
        '        ' a.dttdt2.Text = cl.cChr(.Item("tdt2", i).Value)
        '        a.txtnote.Text = cl.cChr(.Item("note", i).Value)
        '        a.lblid_mcust.Text = cl.cNum(.Item("id_mcust", i).Value)

        '        '  a.txtsubtotal.Text = cl.cCur(.Item("subtotal", i).Value)
        '        'a.txtdiscpcg.Text = cl.cCur(.Item("discpcg", i).Value)
        '        'If cl.cNum(.Item("disctotal", i).Value) > 0 Then
        '        '    a.chdisc.Checked = True
        '        'Else
        '        '    a.chdisc.Checked = False
        '        'End If
        '        '    a.txtdisctotal.Text = cl.cCur(.Item("disctotal", i).Value)
        '        'a.txttaxtotal.Text = cl.cCur(.Item("taxtotal", i).Value)
        '        'If cl.cNum(.Item("taxtotal", i).Value) > 0 Then
        '        '    a.chppn.Checked = True
        '        'Else
        '        '    a.chppn.Checked = False
        '        'End If
        '        'a.txtfreight.Text = cl.cCur(.Item("freight", i).Value)
        '        'a.txtgrdtotal.Text = cl.cCur(.Item("grdtotal", i).Value)

        '        'If cl.readData("SELECT ftsoHEADER('" & cl.cNum(.Item("id", i).Value) & "')-ftdoHEADER('" & cl.cNum(.Item("id", i).Value) & "') ") = 0 Then
        '        '    a.lblprocess.Visible = True
        '        'Else
        '        '    a.lblprocess.Visible = False
        '        'End If

        '        Dim dtdet As DataTable = Nothing
        '        dtdet = cl.table(
        '        "Select TA.*, TB.code 'code_mitem', TB.name 'name_mitem', TC.name 'code_muom' " &
        '        " FROM tdod TA INNER JOIN mitm TB ON TA.id_mitm = TB.id INNER JOIN muom TC ON TA.id_muom = TC.id " &
        '        " WHERE TA.stat = 1 " &
        '        " AND TA.id_tdoh = " & cl.cNum(.Item("id", i).Value))

        '        a.dgview.Rows.Clear()
        '        Dim rrowpl As Integer = 0
        '        For r As Integer = 0 To dtdet.Rows.Count - 1
        '            rrowpl = a.dgview.Rows.Add
        '            With dtdet
        '                a.dgview.Rows(rrowpl).Cells("id_mitem").Value = .Rows(r).Item("id_mitm")
        '                a.dgview.Rows(rrowpl).Cells("id_muom").Value = .Rows(r).Item("id_muom")

        '                a.dgview.Rows(rrowpl).Cells("code_mitem").Value = .Rows(r).Item("code_mitem")
        '                a.dgview.Rows(rrowpl).Cells("name_mitem").Value = .Rows(r).Item("name_mitem")
        '                a.dgview.Rows(rrowpl).Cells("code_muom").Value = .Rows(r).Item("code_muom")
        '                a.dgview.Rows(rrowpl).Cells("qty").Value = cl.cCur(.Rows(r).Item("qty"))
        '                a.dgview.Rows(rrowpl).Cells("price").Value = cl.cCur(.Rows(r).Item("price"))

        '                If cl.cNum(.Rows(r).Item("discpcg1")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = cl.cCur(.Rows(r).Item("discpcg1"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc1").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg2")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = cl.cCur(.Rows(r).Item("discpcg2"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc2").Value = 0
        '                End If

        '                If cl.cNum(.Rows(r).Item("discpcg3")) <> 0 Then
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = cl.cCur(.Rows(r).Item("discpcg3"))
        '                Else
        '                    a.dgview.Rows(rrowpl).Cells("disc3").Value = 0
        '                End If

        '                a.dgview.Rows(rrowpl).Cells("subtotal").Value = cl.cCur(.Rows(r).Item("subtotal"))
        '            End With
        '        Next
        '    End With
        '    a.getcalculate()
        '    a.changestatform("upd")

        '    '-- DISABLE ALL BUTTONS
        '    a.btnsave.Enabled = False
        '    a.btnapprove.Enabled = False
        '    a.btnlist.Enabled = False
        '    a.btndelete.Enabled = False
        '    a.btnrefresh.Enabled = False
        'End If
    End Sub
End Class