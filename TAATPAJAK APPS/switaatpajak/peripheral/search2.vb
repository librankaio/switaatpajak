Public Class search2
    Dim statusTempForm, varTempForm, varTempForm2 As String
    Dim tempForm As Form
    Dim tempObj As Object
    Dim itemtable As New DataTable
    Dim SQLSearch As String
    Dim statSQLSearch As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            btncancel.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.Down) Then
            If dgview.Rows.Count = 0 Then
                txtsearch.Select()
            Else
                If txtsearch.Focused = True Then
                    Me.dgview.Select()
                ElseIf dgview.CurrentRow.Index = dgview.Rows.Count - 1 Then
                    txtsearch.Select()
                End If
            End If
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.Up) Then
            If dgview.CurrentRow.Index = 0 Then
                txtsearch.Select()
            Else
                Me.dgview.Select()
            End If

        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then
            Me.txtsearch.Select()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Public Sub loadSQLSearch(ByVal sql As String, Optional ByVal statSearch As Integer = 0)
        SQLSearch = "SELECT * FROM (" & sql & ") TS"
        statSQLSearch = statSearch
    End Sub
    Public Sub loadStatusTempForm(ByVal tempAsalForm As Form, ByVal tempAsalObj As Object, ByVal temp As String)
        tempForm = tempAsalForm
        tempObj = tempAsalObj
        statusTempForm = temp
    End Sub

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbfilter.Text = "SEMUA"
        With dgview
            '    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            If statusTempForm = "[item]tsales" Then
                .Columns("nametemp").Width = 250
                .Columns("codetemp").Width = 100
                .Columns("stocktemp").Width = 80
            ElseIf statusTempForm = "[item]tpur" Then
                .Columns("nametemp").Width = 300
                .Columns("codetemp").Width = 60
                .Columns("qtytemp").Width = 60
                .Columns("name_mwrh").Width = 140
                '.Columns("hpp").Width = 80
            End If
        End With
        txtsearch.Select()
        txtsearch.Focus()
    End Sub
    Private Sub search_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub
    Dim r As Integer = 0, c As Integer = 0
    Private Sub search()
        Try

            'If statusTempForm = "[mitm]tsalh" Or statusTempForm = "[mitm]tsalpjk" Or statusTempForm = "[mitm]tretph" Or statusTempForm = "[mitm]tadj" Or statusTempForm = "[mitm]tpo" Or statusTempForm = "[mitm]tpopjk" Or
            '     statusTempForm = "[mitm]trec" Or statusTempForm = "[mitm]ttgh" Or statusTempForm = "[mitm]tpopjk" Or statusTempForm = "[mitm]tpopjk2" Or statusTempForm = "[mitm]rsalperproduct" Or statusTempForm = "[mitm]rpurchase" _
            '      Or statusTempForm = "[mitem]rptstockperlot" Or statusTempForm = "[mitem2]rptstockoverview" Or statusTempForm = "[mitem2]rptstockdetail" Then
            '    Dim sqlsearch = "SELECT id, code, name, modal, note " &
            '        " FROM mitm WHERE stat = 1 AND name Like '%" & UCase(txtsearch.Text) & "%'"

            '    dgview.Columns(0).Visible = False
            '    dgview.Columns(1).Visible = False
            '    dgview.DataSource = cl.table(sqlsearch)

            'ElseIf statusTempForm = "[mitm]mitm" Then
            '    Dim sqlsearch = "SELECT id, code, name, merk, modal, note, id_msupp,id_mitmtp " &
            '     " FROM mitm WHERE stat = 1 AND name Like '%" & UCase(txtsearch.Text) & "%'"

            '    dgview.Columns(0).Visible = False
            '    dgview.Columns(4).Visible = False
            '    dgview.Columns(5).Visible = False
            '    dgview.DataSource = cl.table(sqlsearch)
            'ElseIf statusTempForm = "[mbp]tsalh" Or statusTempForm = "[mbp]rsaldetail" Or
            '    statusTempForm = "[mbp]tret" Or statusTempForm = "[mbp]tpay" Then

            '    Dim sqlsearch = "SELECT id, name, phn FROM mcust WHERE stat = 1 AND name Like '%" & UCase(txtsearch.Text) & "%'"

            '    dgview.Columns(0).Visible = False
            '    '    dgview.Columns(1).Visible = False
            '    dgview.DataSource = cl.table(sqlsearch)
            'ElseIf statusTempForm = "[mbp]rpurdetail" Then

            '    Dim sqlsearch = "SELECT id, name, phn FROM msupp WHERE stat = 1 AND name Like '%" & UCase(txtsearch.Text) & "%'"

            '    dgview.Columns(0).Visible = False
            '    '    dgview.Columns(1).Visible = False
            '    dgview.DataSource = cl.table(sqlsearch)
            'Else
            If statSQLSearch = 0 Then
                ' MsgBox("0")
                Dim Row As Integer = 0
                Dim Column As Integer = 0

                For Row = 0 To (dgview.RowCount - 1)
                    For Column = 0 To (dgview.ColumnCount - 1)
                        If IsDBNull(dgview.Rows(Row).Cells(Column).Value) = False Then
                            If dgview.Rows(Row).Cells(Column).Visible = True Then
                                If UCase(dgview.Rows(Row).Cells(Column).Value) Like "*" & UCase(txtsearch.Text) & "*" Then
                                    dgview.ClearSelection()
                                    Me.dgview.CurrentCell = dgview.Item(Column, Row)
                                End If
                            Else
                                Me.dgview.CurrentCell = dgview.Item(0, 0)
                            End If
                        End If
                    Next
                Next

            ElseIf statSQLSearch = 1 Then
                '    MsgBox("1")
                If dgview.Rows.Count > 0 Then
                    c = dgview.CurrentCell.ColumnIndex
                    r = dgview.CurrentCell.RowIndex

                    If txtsearch.Text <> "" Then

                        Dim dt As DataTable = cl.table(SQLSearch)
                        Dim dv As New DataView(cl.table(SQLSearch))
                        Dim dc As DataColumn = dt.Columns(dgview.CurrentCell.ColumnIndex)


                        dv.RowFilter = "[" & dc.ColumnName.ToString & "] Like '%" & cl.cChr(txtsearch.Text) & "%'"
                        dgview.DataSource = dv

                        If dv.Count > r Then
                            Me.dgview.CurrentCell = dgview.Item(c, r)
                        End If

                    Else
                        dgview.DataSource = cl.table(SQLSearch)
                        cl.getRowHeightSameDGforDT(dgview, SQLSearch)
                        Me.dgview.CurrentCell = dgview.Item(c, r)
                    End If
                Else
                    dgview.DataSource = cl.table(SQLSearch)
                    Dim dt As DataTable = cl.table(SQLSearch)
                    Dim dv As New DataView(cl.table(SQLSearch))
                    Dim dc As DataColumn = dt.Columns(c)
                    dv.RowFilter = "[" & dc.ColumnName.ToString & "] Like '%" & cl.cChr(txtsearch.Text) & "%'"
                    dgview.DataSource = dv

                    If dv.Count > r Then
                        Me.dgview.CurrentCell = dgview.Item(c, r)
                    End If
                End If
            End If
            '  End If

        Catch ex As Exception
            cl.msgError("Gagal Pencarian " & txtsearch.Text & vbNewLine & vbNewLine &
                    ex.Message, "Gagal Pencarian")
        End Try
    End Sub
    Private Sub submitsearch()
        Dim i As Integer = dgview.CurrentRow.Index
        Dim cekAvailable As Integer = 0
        For z As Integer = 0 To dgview.ColumnCount - 1
            If cl.cChr(dgview.Item(z, i).Value) <> "" Then
                cekAvailable = 1
            End If
        Next

        If dgview.Rows.Count = 0 Then
            MsgBox("No Data is chosen !", MsgBoxStyle.Information, "Failed Pick Data")
            Exit Sub
        ElseIf tempForm.Visible = False Then
            MsgBox("Last Form Closed !", MsgBoxStyle.Information, "Failed Pick Data")
            Me.Dispose()
            Exit Sub
        ElseIf cekAvailable = 0 Then
            MsgBox("NULL Data Pick !", MsgBoxStyle.Information, "Failed Pick Data")
            Exit Sub
        End If

        If statusTempForm = "[mkpp]mkpp" Then
            Dim a As mkpp = CType(Application.OpenForms("mkpp"), mkpp)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtkode.Text = cl.cChr(.Item("kode", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
            End With
            a.changestatform("upd")
            'ElseIf statusTempForm = "[mgolongan]mgolongan" Then
            '    Dim a As mgolongan = CType(Application.OpenForms("mgolongan"), mgolongan)
            '    a.Enabled = True

            '    With Me.dgview
            '        a.getidmaster(cl.cNum(.Item("id", i).Value))
            '        a.txtgolongan.Text = cl.cChr(.Item("golongan", i).Value)
            '        a.txtpangkat.Text = cl.cChr(.Item("pangkat", i).Value)
            '    End With
            '    a.changestatform("upd")
            'ElseIf statusTempForm = "[mjbtn]mjbtn" Then
            '    Dim a As mjbtn = CType(Application.OpenForms("mjbtn"), mjbtn)
            '    a.Enabled = True

            '    With Me.dgview
            '        a.getidmaster(cl.cNum(.Item("id", i).Value))
            '        a.txtjabatan.Text = cl.cChr(.Item("jabatan", i).Value)
            '    End With
            '    a.changestatform("upd")
        ElseIf statusTempForm = "[mlwntransaksi]mlwntransaksi" Then
            Dim a As mlwntransaksi = CType(Application.OpenForms("mlwntransaksi"), mlwntransaksi)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txttelepon.Text = cl.cChr(.Item("telepon", i).Value)
                a.txtkdpos.Text = cl.cChr(.Item("kdpos", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
            End With
        ElseIf statusTempForm = "[mnegara]mnegara" Then
            Dim a As mngara = CType(Application.OpenForms("mngara"), mngara)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtid_negara.Text = cl.cChr(.Item("code", i).Value)
                a.txtname_negara.Text = cl.cChr(.Item("name", i).Value)
                If cl.cChr(.Item("p3b", i).Value) = "Y" Then
                    a.chp3b.Checked = True
                Else
                    a.chp3b.Checked = False
                End If

            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mobjkpjk]mobjkpjk" Then
            Dim a As mobjkpjk = CType(Application.OpenForms("mobjkpjk"), mobjkpjk)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.cmbjnspjk.Text = cl.cChr(.Item("jnspjk", i).Value)
                a.txtkode.Text = cl.cChr(.Item("kode", i).Value)
                a.txtobjpjk.Text = cl.cChr(.Item("objkpjk", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mprofile]mprofile" Then
            Dim a As mprofile = CType(Application.OpenForms("mprofile"), mprofile)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnik.Text = cl.cChr(.Item("nik", i).Value)
                a.txtpekerjaan.Text = cl.cChr(.Item("pekerjaan", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtttl.Text = cl.cChr(.Item("ttl", i).Value)
                a.txtname_mnegara.Text = cl.cChr(.Item("name_mnegara", i).Value)
                a.txthp.Text = cl.cChr(.Item("hp", i).Value)
                a.txtemaildjp.Text = cl.cChr(.Item("emaildjp", i).Value)

                a.txtnpwpttd.Text = cl.cChr(.Item("emaildjp", i).Value)
                a.txtnamattd.Text = cl.cChr(.Item("emaildjp", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mptkp]mptkp" Then
            Dim a As mptkp = CType(Application.OpenForms("mptkp"), mptkp)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtptkp.Text = cl.cNum(.Item("ptkp", i).Value)
                a.txttgngan.Text = cl.cNum(.Item("tgngan", i).Value)
                a.dtberlaku.Text = cl.cNum(.Item("berlaku", i).Value)
                a.dtberakhir.Text = cl.cNum(.Item("berakhir", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mupahharian]mupahharian" Then
            Dim a As mupahharian = CType(Application.OpenForms("mupahharian"), mupahharian)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtlapis1.Text = cl.cNum(.Item("lapis1", i).Value)
                a.txtlapis2.Text = cl.cNum(.Item("lapis2", i).Value)
                a.txtlapis3.Text = cl.cNum(.Item("lapis3", i).Value)
                a.dtberlaku.Text = cl.cChr(.Item("berlaku", i).Value)
                a.dtberakhir.Text = cl.cChr(.Item("berakhir", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mpenghasil]mpenghasil" Then
            Dim a As mpenghasil = CType(Application.OpenForms("mpenghasil"), mpenghasil)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnik.Text = cl.cChr(.Item("nik", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtid_mnegara.Text = cl.cChr(.Item("id_mnegara", i).Value)
                a.txtname_mnegara.Text = cl.cChr(.Item("name_mnegara", i).Value)
                If cl.cChr(.Item("wpasing", i).Value) = "Y" Then
                    a.chwpasing.Checked = True
                Else
                    a.chwpasing.Checked = False
                End If
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mpenghasila1]mpenghasila1" Then
            Dim a As mpenghasila1 = CType(Application.OpenForms("mpenghasila1"), mpenghasila1)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtnik.Text = cl.cChr(.Item("nik", i).Value)
                a.lblid_mnegara.Text = cl.cNum(.Item("id_mnegara", i).Value)
                a.txtid_mnegara.Text = cl.cChr(cl.readData("SELECT code FROM mnegara WHERE id = '" & cl.cNum(.Item("id_mnegara", i).Value) & "' "))
                a.txtname_mnegara.Text = cl.cChr(.Item("name_mnegara", i).Value)
                a.cmbstatus.Text = cl.cChr(.Item("status", i).Value)
                a.cmbtanggungan.Text = cl.cChr(.Item("tanggungan", i).Value)
                a.cmbgender.Text = cl.cChr(.Item("gender", i).Value)
                a.cmbmgolongan.Text = cl.cChr(.Item("mgolongan", i).Value)
                a.txtpangkat.Text = cl.cChr(.Item("pangkat", i).Value)
                a.txtname_mjabatan.Text = cl.cChr(.Item("name_mjabatan", i).Value)

                If cl.cChr(.Item("wpasing", i).Value) = "Y" Then
                    a.chwpasing.Checked = True
                Else
                    a.chwpasing.Checked = False
                End If
                'a.chwpasing.Checked = False
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[mnegara]mpenghasila1" Then
            Dim a As mpenghasila1 = CType(Application.OpenForms("mpenghasila1"), mpenghasila1)
            a.Enabled = True

            With Me.dgview
                a.lblid_mnegara.Text = cl.cNum(.Item("id", i).Value)
                a.txtid_mnegara.Text = cl.cChr(.Item("code", i).Value)
                a.txtname_mnegara.Text = cl.cChr(.Item("name", i).Value)

            End With
        ElseIf statusTempForm = "[mpenghasila2]mpenghasila2" Then
            Dim a As mpenghasila2 = CType(Application.OpenForms("mpenghasila2"), mpenghasila2)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtnik.Text = cl.cChr(.Item("nik", i).Value)
                a.txtnip.Text = cl.cChr(.Item("nip", i).Value)
                a.cmbstatus.Text = cl.cChr(.Item("status", i).Value)
                a.cmbtgngan.Text = cl.cNum(.Item("tgngan", i).Value)
                a.cmbgender.Text = cl.cChr(.Item("gender", i).Value)
                a.cmbid_mgolongan.Text = cl.cNum(.Item("id_mgolongan", i).Value)
                a.txtname_mgolongan.Text = cl.cChr(.Item("name_mgolongan", i).Value)
                a.txtname_mjabatan.Text = cl.cChr(.Item("name_mjabatan", i).Value)

            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mssp]mssp" Then
            Dim a As mssp = CType(Application.OpenForms("mssp"), mssp)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtkode.Text = cl.cChr(.Item("kode", i).Value)
                a.txtkdobj.Text = cl.cChr(.Item("jenis", i).Value)
                a.txtdeskripsi.Text = cl.cChr(.Item("deskripsi", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mnegara]mpenghasil" Then
            Dim a As mpenghasil = CType(Application.OpenForms("mpenghasil"), mpenghasil)
            a.Enabled = True

            With Me.dgview
                a.txtid_mnegara.Text = cl.cChr(.Item("code", i).Value)
                a.txtname_mnegara.Text = cl.cChr(.Item("name", i).Value)
            End With

        ElseIf statusTempForm = "[msetmasa]msetmasa" Then
            Dim a As msetmasa = CType(Application.OpenForms("msetmasa"), msetmasa)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                '  a.cmbjnspjk.Text = cl.cChr(.Item("jnspjk", i).Value)
                a.cmbmasapjk.Text = cl.cChr(.Item("masapjk", i).Value)
                ' nudtahunpjk.Text = 0
                a.txtpembetulan.Text = cl.cChr(.Item("pembetulan", i).Value)

                a.nudtahunpjk.Text = cl.cNum(.Item("tahunpjk", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[mnegara]tpph42" Then
            Dim a As tpph42 = CType(Application.OpenForms("tpph42"), tpph42)
            a.Enabled = True

            With Me.dgview
                a.lblid_lwntransaksi.Text = cl.cNum(.Item("id", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)

            End With

        ElseIf statusTempForm = "[tinputssppbk21]tinputssppbk21" Then
            Dim a As tinputssppbk21 = CType(Application.OpenForms("tinputssppbk21"), tinputssppbk21)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.cmbkdpjk.Text = cl.cChr(.Item("kdpjk", i).Value)
                a.cmbjenissetor.Text = cl.cChr(.Item("jenissetor", i).Value)
                a.dttglssp.Text = cl.cChr(.Item("tglssp", i).Value)
                a.txtnttpn.Text = cl.cChr(.Item("nttpn", i).Value)
                a.txtpph.Text = cl.cChr(.Item("pph", i).Value)
                a.cmbket.Text = cl.cChr(.Item("ket", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[tinputssppbk23]tinputssppbk23" Then
            Dim a As tinputssppbk23 = CType(Application.OpenForms("tinputssppbk23"), tinputssppbk23)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.cmbkdpjk.Text = cl.cChr(.Item("kdpjk", i).Value)
                a.cmbjenissetor.Text = cl.cChr(.Item("jenissetor", i).Value)
                a.dttglssp.Text = cl.cChr(.Item("tglssp", i).Value)
                a.txtnttpn.Text = cl.cChr(.Item("nttpn", i).Value)
                a.txtpph.Text = cl.cChr(.Item("pph", i).Value)
                a.cmbket.Text = cl.cChr(.Item("ket", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[tinputssppbk42]tinputssppbk42" Then
            Dim a As tinputssppbk42 = CType(Application.OpenForms("tinputssppbk42"), tinputssppbk42)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.cmbkdpjk.Text = cl.cChr(.Item("kdpjk", i).Value)
                a.cmbjenissetor.Text = cl.cChr(.Item("jenissetor", i).Value)
                a.dttglssp.Text = cl.cChr(.Item("tglssp", i).Value)
                a.txtnttpn.Text = cl.cChr(.Item("nttpn", i).Value)
                a.txtpph.Text = cl.cChr(.Item("pph", i).Value)
                a.cmbket.Text = cl.cChr(.Item("ket", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[tbuktiptgtdkfinal]tbuktiptgtdkfinal" Then
            Dim a As tbuktiptgtdkfinal = CType(Application.OpenForms("tbuktiptgtdkfinal"), tbuktiptgtdkfinal)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnobkt.Text = cl.cChr(.Item("nobkt", i).Value)
                a.txtnobkt_rl.Text = cl.cChr(.Item("nobkt_rl", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnikpssprt.Text = cl.cChr(.Item("nikpssprt", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                'a.chwpasing.Text = cl.cChr(.Item("wpasing", i).Value)
                If cl.cChr(.Item("wpasing", i).Value) = "Y" Then
                    a.chwpasing.Checked = True
                Else
                    a.chwpasing.Checked = False
                End If
                a.txtkn.Text = cl.cChr(.Item("kn", i).Value)
                a.txtkn_rl.Text = cl.cChr(.Item("kn_rl", i).Value)
                a.txtobpjk.Text = cl.cChr(.Item("objpjk", i).Value)
                a.txtnpwpptg.Text = cl.cChr(.Item("npwpptg", i).Value)
                a.txtnamaptg.Text = cl.cChr(.Item("namaptg", i).Value)
                a.dttdate.Text = cl.cChr(.Item("tanggal", i).Value)
                Dim dtdet As DataTable = Nothing
                dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tbuktiptgtdkfinald TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.idh = " & cl.cNum(.Item("id", i).Value))

                'LOAD MAIN DGVIEW
                a.dgview.Rows.Clear()
                Dim rrowpl As Integer = 0
                For r As Integer = 0 To dtdet.Rows.Count - 1
                    rrowpl = a.dgview.Rows.Add
                    With dtdet

                        '.Columns("uraian").Width = 100
                        '.Columns("nilai").Width = 80
                        '.Columns("tariff").Width = 60
                        '.Columns("pph").Width = 120

                        a.dgview.Rows(rrowpl).Cells("kdobjpjk").Value = .Rows(r).Item("kdobjpjk")
                        a.dgview.Rows(rrowpl).Cells("bruto").Value = .Rows(r).Item("bruto")
                        a.dgview.Rows(rrowpl).Cells("dpp").Value = .Rows(r).Item("dpp")
                        a.dgview.Rows(rrowpl).Cells("tnpwp").Value = .Rows(r).Item("tnpwp")
                        a.dgview.Rows(rrowpl).Cells("trf").Value = .Rows(r).Item("trf")
                        a.dgview.Rows(rrowpl).Cells("pphptg").Value = .Rows(r).Item("pphptg")
                    End With

                Next
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[mpenghasila2]tbuktiptgtdkfinal" Then
            Dim a As tbuktiptgtdkfinal = CType(Application.OpenForms("tbuktiptgtdkfinal"), tbuktiptgtdkfinal)
            a.Enabled = True

            With Me.dgview
                ' a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnikpssprt.Text = cl.cChr(.Item("nik", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)

            End With

        ElseIf statusTempForm = "[mnegara]tbuktiptgtdkfinal" Then
            Dim a As tbuktiptgtdkfinal = CType(Application.OpenForms("tbuktiptgtdkfinal"), tbuktiptgtdkfinal)
            a.Enabled = True

            With Me.dgview
                a.txtkn.Text = cl.cChr(.Item("code", i).Value)
                a.txtkn_rl.Text = cl.cChr(.Item("name", i).Value)

            End With

        ElseIf statusTempForm = "[tbuktiptgfinal]tbuktiptgfinal" Then
            Dim a As tbuktiptgfinal = CType(Application.OpenForms("tbuktiptgfinal"), tbuktiptgfinal)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnobkt.Text = cl.cChr(.Item("nobkt", i).Value)
                a.txtnobkt_rl.Text = cl.cChr(.Item("nobkt_rl", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnikpssprt.Text = cl.cChr(.Item("nikpssprt", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtobjpjk.Text = cl.cChr(.Item("objpjk", i).Value)
                a.txtnamaptg.Text = cl.cChr(.Item("namaptg", i).Value)
                a.txtnpwpptg.Text = cl.cChr(.Item("npwpptg", i).Value)
                a.dttdate.Text = cl.cChr(.Item("tanggal", i).Value)
                Dim dtdet As DataTable = Nothing
                dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tbuktiptgfinald TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.idh = " & cl.cNum(.Item("id", i).Value))

                'LOAD MAIN DGVIEW
                a.dgview.Rows.Clear()
                Dim rrowpl As Integer = 0
                For r As Integer = 0 To dtdet.Rows.Count - 1
                    rrowpl = a.dgview.Rows.Add
                    With dtdet

                        '.Columns("uraian").Width = 100
                        '.Columns("nilai").Width = 80
                        '.Columns("tariff").Width = 60
                        '.Columns("pph").Width = 120

                        a.dgview.Rows(rrowpl).Cells("kdobjpjk").Value = .Rows(r).Item("kdobjpjk")
                        a.dgview.Rows(rrowpl).Cells("bruto").Value = .Rows(r).Item("bruto")
                        a.dgview.Rows(rrowpl).Cells("trf").Value = .Rows(r).Item("trf")
                        a.dgview.Rows(rrowpl).Cells("pphptg").Value = .Rows(r).Item("pphptg")
                    End With

                Next
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[mpenghasila2]tbuktiptgfinal" Then
            Dim a As tbuktiptgfinal = CType(Application.OpenForms("tbuktiptgfinal"), tbuktiptgfinal)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnikpssprt.Text = cl.cChr(.Item("nik", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)

            End With

        ElseIf statusTempForm = "[tinputdatapemotongpjk]tinputdatapemotongpjk" Then
            Dim a As tinputdatapemotongpjk = CType(Application.OpenForms("tinputdatapemotongpjk"), tinputdatapemotongpjk)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.cmbkodepjk.Text = cl.cChr(.Item("kodepjk", i).Value)
                a.txtbruto.Text = cl.cChr(.Item("bruto", i).Value)
                a.txtpphptg.Text = cl.cChr(.Item("pphptg", i).Value)
                a.txtkdnegara.Text = cl.cChr(.Item("kdnegara", i).Value)
                a.cmbkdnegara_rl.Text = cl.cChr(.Item("kdnegara_rl", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[mpenghasila1]tpph21" Then
            Dim a As mpenghasila1 = CType(Application.OpenForms("mpenghasila1"), mpenghasila1)
            a.Enabled = True

            With Me.dgview
                a.txtnpwp.Text = cl.cNum(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.cmbgender.Text = cl.cChr(.Item("gender", i).Value)

                a.cmbstatus.Text = cl.cChr(.Item("status", i).Value)
                a.cmbtanggungan.Text = cl.cChr(.Item("tanggungan", i).Value)
            End With

        ElseIf statusTempForm = "[tpph21]tpph21" Then
            Dim a As tpph21 = CType(Application.OpenForms("tpph21"), tpph21)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnobuktptg.Text = cl.cChr(.Item("nobuktptg", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.cmbtgngan.Text = cl.cChr(.Item("tgngan", i).Value)
                a.txttunjpph.Text = cl.cChr(.Item("tunjpph", i).Value)
                'a.txtkdnegara.Text = cl.cChr(.Item("kdnegara", i).Value)
                'a.cmbkdnegara_rl.Text = cl.cChr(.Item("kdnegara_rl", i).Value)
            End With
            a.changestatform("upd")

        ElseIf statusTempForm = "[tpph23]tpph23" Then
            Dim a As tpph23 = CType(Application.OpenForms("tpph23"), tpph23)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.cmbthnpjk.Text = cl.cChr(.Item("thnpjk", i).Value)
                a.cmbmasapjk.Text = cl.cChr(.Item("masapjk", i).Value)
                'a.rbnpwp.Text = cl.cChr(.Item("rbnpwp", i).Value)
                If cl.cChr(.Item("rbnpwp", i).Value) = "Y" Then
                    a.rbnpwp.Checked = True
                Else
                    a.rbnpwp.Checked = False
                End If
                'a.rbnik.Text = cl.cChr(.Item("rbnik", i).Value)
                If cl.cChr(.Item("rbnik", i).Value) = "Y" Then
                    a.rbnik.Checked = True
                Else
                    a.rbnik.Checked = False
                End If
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtkeldesa.Text = cl.cChr(.Item("keldesa", i).Value)
                a.txtkotakab.Text = cl.cChr(.Item("kotakab", i).Value)
                a.txtkecamatan.Text = cl.cChr(.Item("kecamatan", i).Value)
                a.txtkdpos.Text = cl.cChr(.Item("kdpos", i).Value)
                a.txtprov.Text = cl.cChr(.Item("prov", i).Value)
                'a.rbtanpafslts.Text = cl.cChr(.Item("tanpafslts", i).Value)
                If cl.cChr(.Item("tanpafslts", i).Value) = "Y" Then
                    a.rbtanpafslts.Checked = True
                Else
                    a.rbtanpafslts.Checked = False
                End If
                'a.rbpph23bebas.Text = cl.cChr(.Item("pph23bebas", i).Value)
                If cl.cChr(.Item("pph23bebas", i).Value) = "Y" Then
                    a.rbpph23bebas.Checked = True
                Else
                    a.rbpph23bebas.Checked = False
                End If
                'a.rbpph23pemerintah.Text = cl.cChr(.Item("pph23pemerintah", i).Value)
                If cl.cChr(.Item("pph23pemerintah", i).Value) = "Y" Then
                    a.rbpph23pemerintah.Checked = True
                Else
                    a.rbpph23pemerintah.Checked = False
                End If
                a.txtkodeobj.Text = cl.cChr(.Item("kodeobj", i).Value)
                a.txtjmlbruto.Text = cl.cChr(.Item("jmlbruto", i).Value)
                a.txttrf.Text = cl.cChr(.Item("trf", i).Value)
                a.txtpphdipotong.Text = cl.cChr(.Item("pphdipotong", i).Value)
                a.txtnamaptg.Text = cl.cChr(.Item("namaptg", i).Value)
                a.txtnpwptg.Text = cl.cChr(.Item("npwpptg", i).Value)
                a.txtbertindaksbgi.Text = cl.cChr(.Item("bertindaksbgi", i).Value)
                a.txtnama_brtndk.Text = cl.cChr(.Item("nama_brtndk", i).Value)
                'a.chacceptance.Text = cl.cChr(.Item("acceptance", i).Value)
                If cl.cChr(.Item("acceptance", i).Value) = "Y" Then
                    a.chacceptance.Checked = True
                Else
                    a.chacceptance.Checked = False
                End If
                'a.txtkdnegara.Text = cl.cChr(.Item("kdnegara", i).Value)
                'a.cmbkdnegara_rl.Text = cl.cChr(.Item("kdnegara_rl", i).Value)
                Dim dtdet As DataTable = Nothing
                dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tpph23d TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.idh = " & cl.cNum(.Item("id", i).Value))

                'LOAD MAIN DGVIEW
                a.dgview.Rows.Clear()
                Dim rrowpl As Integer = 0
                For r As Integer = 0 To dtdet.Rows.Count - 1
                    rrowpl = a.dgview.Rows.Add
                    With dtdet

                        '.Columns("uraian").Width = 100
                        '.Columns("nilai").Width = 80
                        '.Columns("tariff").Width = 60
                        '.Columns("pph").Width = 120

                        a.dgview.Rows(rrowpl).Cells("nomordok").Value = .Rows(r).Item("nomordok")
                        a.dgview.Rows(rrowpl).Cells("namadok").Value = .Rows(r).Item("namadok")
                        a.dgview.Rows(rrowpl).Cells("tgl").Value = .Rows(r).Item("tgl")
                        a.dgview.Rows(rrowpl).Cells("aksi").Value = .Rows(r).Item("aksi")
                    End With

                Next

            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[tsptmasa23]tsptmasa23" Then
            Dim a As tsptmasa23 = CType(Application.OpenForms("tsptmasa23"), tsptmasa23)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtjpb1.Text = cl.cNum(.Item("jpb1", i).Value)
                a.txtjpb2.Text = cl.cNum(.Item("jpb2", i).Value)
                a.txtjpb3.Text = cl.cNum(.Item("jpb3", i).Value)
                a.txtjpb4.Text = cl.cNum(.Item("jpb4", i).Value)
                a.txtjpb5.Text = cl.cNum(.Item("jpb5", i).Value)
                a.txtjpb6.Text = cl.cNum(.Item("jpb6", i).Value)
                a.txtjpb7.Text = cl.cNum(.Item("jpb7", i).Value)
                a.txtjpb8.Text = cl.cNum(.Item("jpb8", i).Value)
                a.txtjpb9.Text = cl.cNum(.Item("jpb9", i).Value)
                a.txtjpb10.Text = cl.cNum(.Item("jpb10", i).Value)
                a.txtjpb11.Text = cl.cNum(.Item("jpb11", i).Value)
                a.txtjpb12.Text = cl.cNum(.Item("jpb12", i).Value)
                a.txtjpb13.Text = cl.cNum(.Item("jpb13", i).Value)
                a.txtjpbjml.Text = cl.cNum(.Item("jpbjml", i).Value)
                a.txtpph1.Text = cl.cNum(.Item("pph1", i).Value)
                a.txtpph2.Text = cl.cNum(.Item("pph2", i).Value)
                a.txtpph3.Text = cl.cNum(.Item("pph3", i).Value)
                a.txtpph4.Text = cl.cNum(.Item("pph4", i).Value)
                a.txtpph5.Text = cl.cNum(.Item("pph5", i).Value)
                a.txtpph6.Text = cl.cNum(.Item("pph6", i).Value)
                a.txtpph7.Text = cl.cNum(.Item("pph7", i).Value)
                a.txtpph8.Text = cl.cNum(.Item("pph8", i).Value)
                a.txtpph9.Text = cl.cNum(.Item("pph9", i).Value)
                a.txtpph10.Text = cl.cNum(.Item("pph10", i).Value)
                a.txtpph11.Text = cl.cNum(.Item("pph11", i).Value)
                a.txtpph12.Text = cl.cNum(.Item("pph12", i).Value)
                a.txtpph13.Text = cl.cNum(.Item("pph13", i).Value)
                a.txtpphjml.Text = cl.cNum(.Item("pphjml", i).Value)
                a.txtlain1.Text = cl.cChr(.Item("lain1", i).Value)
                a.txtlain2.Text = cl.cChr(.Item("lain2", i).Value)
                a.txtlain3.Text = cl.cChr(.Item("lain3", i).Value)
                a.txtlain4.Text = cl.cChr(.Item("lain7", i).Value)
                a.txtkap7.Text = cl.cChr(.Item("kap7", i).Value)
                a.txtterbilang.Text = cl.cChr(.Item("terbilang", i).Value)
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[tsptmasapphfinal42]tsptmasapphfinal42" Then
            Dim a As tsptmasapphfinal42 = CType(Application.OpenForms("tsptmasapphfinal42"), tsptmasapphfinal42)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txth1npwp.Text = cl.cChr(.Item("h1npwp", i).Value)
                a.txth1nama.Text = cl.cChr(.Item("h1nama", i).Value)
                a.txth1alamat.Text = cl.cChr(.Item("h1alamat", i).Value)
                a.txth1mspjk.Text = cl.cChr(.Item("h1mspjk", i).Value)
                a.txth1mspjk_rl.Text = cl.cChr(.Item("h1mspjk_rl", i).Value)
                a.txth1kdpbtln.Text = cl.cChr(.Item("h1kdpbtln", i).Value)
                a.txth1nop1.Text = cl.cChr(.Item("h1nop1", i).Value)
                a.txth1nop2.Text = cl.cChr(.Item("h1nop2", i).Value)
                a.txth1nop3.Text = cl.cChr(.Item("h1nop3", i).Value)
                a.txth1nop4.Text = cl.cChr(.Item("h1nop4", i).Value)
                a.txth1nop5.Text = cl.cChr(.Item("h1nop5", i).Value)
                a.txth1nop6.Text = cl.cChr(.Item("h1nop6", i).Value)
                a.txth1nop7.Text = cl.cChr(.Item("h1nop7", i).Value)
                a.txth1nop8.Text = cl.cChr(.Item("h1nop8", i).Value)
                a.txth1nop9.Text = cl.cChr(.Item("h1nop9", i).Value)
                a.txth1nop10.Text = cl.cChr(.Item("h1nop10", i).Value)
                a.txth1trf1.Text = cl.cChr(.Item("h1trf1", i).Value)
                a.txth1trf2.Text = cl.cChr(.Item("h1trf2", i).Value)
                a.txth1trf3.Text = cl.cChr(.Item("h1trf3", i).Value)
                a.txth1trf4.Text = cl.cChr(.Item("h1trf4", i).Value)
                a.txth1trf5.Text = cl.cChr(.Item("h1trf5", i).Value)
                a.txth1trf6.Text = cl.cChr(.Item("h1trf6", i).Value)
                a.txth1trf7.Text = cl.cChr(.Item("h1trf7", i).Value)
                a.txth1trf8.Text = cl.cChr(.Item("h1trf8", i).Value)
                a.txth1trf9.Text = cl.cChr(.Item("h1trf9", i).Value)
                a.txth1trf10.Text = cl.cChr(.Item("h1trf10", i).Value)
                a.txth2nop1.Text = cl.cChr(.Item("h2nop1", i).Value)
                a.txth2nop2.Text = cl.cChr(.Item("h2nop2", i).Value)
                a.txth2nop3.Text = cl.cChr(.Item("h2nop3", i).Value)
                a.txth2nop4.Text = cl.cChr(.Item("h2nop4", i).Value)
                a.txth2nop5.Text = cl.cChr(.Item("h2nop5", i).Value)
                a.txth2nop6.Text = cl.cChr(.Item("h2nop6", i).Value)
                a.txth2nop7.Text = cl.cChr(.Item("h2nop7", i).Value)
                a.txth2nop8.Text = cl.cChr(.Item("h2nop8", i).Value)
                a.txth2nop9.Text = cl.cChr(.Item("h2nop9", i).Value)
                a.txth2nop10.Text = cl.cChr(.Item("h2nop10", i).Value)
                a.txth2nop16.Text = cl.cChr(.Item("h2nop11", i).Value)
                a.txth2nop17.Text = cl.cChr(.Item("h2nop12", i).Value)
                a.txth2nop18.Text = cl.cChr(.Item("h2nop13", i).Value)
                a.txth2nop19.Text = cl.cChr(.Item("h2nop14", i).Value)
                a.txth2nop20.Text = cl.cChr(.Item("h2nop15", i).Value)
                a.txth2trf1.Text = cl.cChr(.Item("h2trf1", i).Value)
                a.txth2trf2.Text = cl.cChr(.Item("h2trf2", i).Value)
                a.txth2trf3.Text = cl.cChr(.Item("h2trf3", i).Value)
                a.txth2trf4.Text = cl.cChr(.Item("h2trf4", i).Value)
                a.txth2trf5.Text = cl.cChr(.Item("h2trf5", i).Value)
                a.txth2trf6.Text = cl.cChr(.Item("h2trf6", i).Value)
                a.txth2trf7.Text = cl.cChr(.Item("h2trf7", i).Value)
                a.txth2trf8.Text = cl.cChr(.Item("h2trf8", i).Value)
                a.txth2trf9.Text = cl.cChr(.Item("h2trf9", i).Value)
                a.txth2trf10.Text = cl.cChr(.Item("h2trf10", i).Value)
                a.txth2trf16.Text = cl.cChr(.Item("h2trf11", i).Value)
                a.txth2trf17.Text = cl.cChr(.Item("h2trf12", i).Value)
                a.txth2trf18.Text = cl.cChr(.Item("h2trf13", i).Value)
                a.txth2trf19.Text = cl.cChr(.Item("h2trf14", i).Value)
                a.txth2trf20.Text = cl.cChr(.Item("h2trf15", i).Value)
                a.txth2pphptg1.Text = cl.cChr(.Item("h2pphptg1", i).Value)
                a.txth2pphptg2.Text = cl.cChr(.Item("h2pphptg2", i).Value)
                a.txth2pphptg3.Text = cl.cChr(.Item("h2pphptg3", i).Value)
                a.txth2pphptg4.Text = cl.cChr(.Item("h2pphptg4", i).Value)
                a.txth2pphptg5.Text = cl.cChr(.Item("h2pphptg5", i).Value)
                a.txth2pphptg6.Text = cl.cChr(.Item("h2pphptg6", i).Value)
                a.txth2pphptg7.Text = cl.cChr(.Item("h2pphptg7", i).Value)
                a.txth2pphptg8.Text = cl.cChr(.Item("h2pphptg8", i).Value)
                a.txth2pphptg9.Text = cl.cChr(.Item("h2pphptg9", i).Value)
                a.txth2pphptg10.Text = cl.cChr(.Item("h2pphptg10", i).Value)
                a.txth2pphptg16.Text = cl.cChr(.Item("h2pphptg11", i).Value)
                a.txth2pphptg17.Text = cl.cChr(.Item("h2pphptg12", i).Value)
                a.txth2pphptg18.Text = cl.cChr(.Item("h2pphptg13", i).Value)
                a.txth2pphptg19.Text = cl.cChr(.Item("h2pphptg14", i).Value)
                a.txth2pphptg20.Text = cl.cChr(.Item("h2pphptg15", i).Value)
                a.txtpenghasil11a.Text = cl.cChr(.Item("penghasil11a", i).Value)
                a.txtpenghasil11b.Text = cl.cChr(.Item("penghasil11b", i).Value)
                a.txtpenghasil11c.Text = cl.cChr(.Item("penghasil11c", i).Value)
                'a.chssp.Text = cl.cChr(.Item("chssp", i).Value)
                If cl.cChr(.Item("chssp", i).Value) = "Y" Then
                    a.chssp.Checked = True
                Else
                    a.chssp.Checked = False
                End If
                a.txtssp.Text = cl.cChr(.Item("ssp", i).Value)
                'a.chbpppsl42.Text = cl.cChr(.Item("chbpppsl42", i).Value)
                If cl.cChr(.Item("chbpppsl42", i).Value) = "Y" Then
                    a.chbpppsl42.Checked = True
                Else
                    a.chbpppsl42.Checked = False
                End If
                a.txtbpppsl42.Text = cl.cChr(.Item("bpppsl42", i).Value)
                'a.chdbpfinalpsl42.Text = cl.cChr(.Item("chdbpfinalpsl42", i).Value)
                If cl.cChr(.Item("chdbpfinalpsl42", i).Value) = "Y" Then
                    a.chdbpfinalpsl42.Checked = True
                Else
                    a.chdbpfinalpsl42.Checked = False
                End If
                'a.chskk.Text = cl.cChr(.Item("chskk", i).Value)
                If cl.cChr(.Item("chskk", i).Value) = "Y" Then
                    a.chskk.Checked = True
                Else
                    a.chskk.Checked = False
                End If
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[tspt21induk]tspt21induk" Then
            Dim a As tsptmasa21induk = CType(Application.OpenForms("tsptmasa21induk"), tsptmasa21induk)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtb1kop1.Text = cl.cChr(.Item("b1kop1", i).Value)
                a.txtb1kop2.Text = cl.cChr(.Item("b1kop2", i).Value)
                a.txtb1kop3.Text = cl.cChr(.Item("b1kop3", i).Value)
                a.txtb1kop4.Text = cl.cChr(.Item("b1kop4", i).Value)
                a.txtb1kop5.Text = cl.cChr(.Item("b1kop5", i).Value)
                a.txtb1kop6.Text = cl.cChr(.Item("b1kop6", i).Value)
                a.txtb1kop7.Text = cl.cChr(.Item("b1kop7", i).Value)
                a.txtb1kop8.Text = cl.cChr(.Item("b1kop8", i).Value)
                a.txtb1kop9.Text = cl.cChr(.Item("b1kop9", i).Value)
                a.txtb1kop10.Text = cl.cChr(.Item("b1kop10", i).Value)
                a.txtb1kop11.Text = cl.cChr(.Item("b1kop11", i).Value)
                a.txtb1kop12.Text = cl.cChr(.Item("b1kop12", i).Value)
                a.txtb1kop13.Text = cl.cChr(.Item("b1kop13", i).Value)
                a.txtb1kop14.Text = cl.cChr(.Item("b1kop14", i).Value)
                a.txtb1kop15.Text = cl.cChr(.Item("b1kop15", i).Value)
                a.txtb1kop16.Text = cl.cChr(.Item("b1kop16", i).Value)
                a.txtb1jpp1.Text = cl.cChr(.Item("b1jpp1", i).Value)
                a.txtb1jpp2.Text = cl.cChr(.Item("b1jpp2", i).Value)
                a.txtb1jpp3.Text = cl.cChr(.Item("b1jpp3", i).Value)
                a.txtb1jpp4.Text = cl.cChr(.Item("b1jpp4", i).Value)
                a.txtb1jpp5.Text = cl.cChr(.Item("b1jpp5", i).Value)
                a.txtb1jpp6.Text = cl.cChr(.Item("b1jpp6", i).Value)
                a.txtb1jpp7.Text = cl.cChr(.Item("b1jpp7", i).Value)
                a.txtb1jpp8.Text = cl.cChr(.Item("b1jpp8", i).Value)
                a.txtb1jpp9.Text = cl.cChr(.Item("b1jpp9", i).Value)
                a.txtb1jpp10.Text = cl.cChr(.Item("b1jpp10", i).Value)
                a.txtb1jpp11.Text = cl.cChr(.Item("b1jpp11", i).Value)
                a.txtb1jpp12.Text = cl.cChr(.Item("b1jpp12", i).Value)
                a.txtb1jpp13.Text = cl.cChr(.Item("b1jpp13", i).Value)
                a.txtb1jpp14.Text = cl.cChr(.Item("b1jpp14", i).Value)
                a.txtb1jpp15.Text = cl.cChr(.Item("b1jpp15", i).Value)
                a.txtb1jpp16.Text = cl.cChr(.Item("b1jpp16", i).Value)
                a.txtb1jpb1.Text = cl.cChr(.Item("b1jpb1", i).Value)
                a.txtb1jpb2.Text = cl.cChr(.Item("b1jpb2", i).Value)
                a.txtb1jpb3.Text = cl.cChr(.Item("b1jpb3", i).Value)
                a.txtb1jpb4.Text = cl.cChr(.Item("b1jpb4", i).Value)
                a.txtb1jpb5.Text = cl.cChr(.Item("b1jpb5", i).Value)
                a.txtb1jpb6.Text = cl.cChr(.Item("b1jpb6", i).Value)
                a.txtb1jpb7.Text = cl.cChr(.Item("b1jpb7", i).Value)
                a.txtb1jpb8.Text = cl.cChr(.Item("b1jpb8", i).Value)
                a.txtb1jpb9.Text = cl.cChr(.Item("b1jpb9", i).Value)
                a.txtb1jpb10.Text = cl.cChr(.Item("b1jpb10", i).Value)
                a.txtb1jpb11.Text = cl.cChr(.Item("b1jpb11", i).Value)
                a.txtb1jpb12.Text = cl.cChr(.Item("b1jpb12", i).Value)
                a.txtb1jpb13.Text = cl.cChr(.Item("b1jpb13", i).Value)
                a.txtb1jpb14.Text = cl.cChr(.Item("b1jpb14", i).Value)
                a.txtb1jpb15.Text = cl.cChr(.Item("b1jpb15", i).Value)
                a.txtb1jpb16.Text = cl.cChr(.Item("b1jpb16", i).Value)
                a.txtb1jpjkp1.Text = cl.cChr(.Item("b1jpjkp1", i).Value)
                a.txtb1jpjkp2.Text = cl.cChr(.Item("b1jpjkp2", i).Value)
                a.txtb1jpjkp3.Text = cl.cChr(.Item("b1jpjkp3", i).Value)
                a.txtb1jpjkp4.Text = cl.cChr(.Item("b1jpjkp4", i).Value)
                a.txtb1jpjkp5.Text = cl.cChr(.Item("b1jpjkp5", i).Value)
                a.txtb1jpjkp6.Text = cl.cChr(.Item("b1jpjkp6", i).Value)
                a.txtb1jpjkp7.Text = cl.cChr(.Item("b1jpjkp7", i).Value)
                a.txtb1jpjkp8.Text = cl.cChr(.Item("b1jpjkp8", i).Value)
                a.txtb1jpjkp9.Text = cl.cChr(.Item("b1jpjkp9", i).Value)
                a.txtb1jpjkp10.Text = cl.cChr(.Item("b1jpjkp10", i).Value)
                a.txtb1jpjkp11.Text = cl.cChr(.Item("b1jpjkp11", i).Value)
                a.txtb1jpjkp12.Text = cl.cChr(.Item("b1jpjkp12", i).Value)
                a.txtb1jpjkp13.Text = cl.cChr(.Item("b1jpjkp13", i).Value)
                a.txtb1jpjkp14.Text = cl.cChr(.Item("b1jpjkp14", i).Value)
                a.txtb1jpjkp15.Text = cl.cChr(.Item("b1jpjkp15", i).Value)
                a.txtb1jpjkp16.Text = cl.cChr(.Item("b1jpjkp16", i).Value)
                'a.ch1b2.Text = cl.cChr(.Item("ch1b2", i).Value)
                If cl.cChr(.Item("ch1b2", i).Value) = "Y" Then
                    a.ch1b2.Checked = True
                Else
                    a.ch1b2.Checked = False
                End If
                'a.ch2b2.Text = cl.cChr(.Item("ch2b2", i).Value)
                If cl.cChr(.Item("ch2b2", i).Value) = "Y" Then
                    a.ch2b2.Checked = True
                Else
                    a.ch2b2.Checked = False
                End If
                'a.ch3b2.Text = cl.cChr(.Item("ch3b2", i).Value)
                If cl.cChr(.Item("ch3b2", i).Value) = "Y" Then
                    a.ch3b2.Checked = True
                Else
                    a.ch3b2.Checked = False
                End If
                'a.ch4b2.Text = cl.cChr(.Item("ch4b2", i).Value)
                If cl.cChr(.Item("ch4b2", i).Value) = "Y" Then
                    a.ch4b2.Checked = True
                Else
                    a.ch4b2.Checked = False
                End If
                'a.ch5b2.Text = cl.cChr(.Item("ch5b2", i).Value)
                If cl.cChr(.Item("ch5b2", i).Value) = "Y" Then
                    a.ch5b2.Checked = True
                Else
                    a.ch5b2.Checked = False
                End If
                'a.ch6b2.Text = cl.cChr(.Item("ch6b2", i).Value)
                If cl.cChr(.Item("ch6b2", i).Value) = "Y" Then
                    a.ch6b2.Checked = True
                Else
                    a.ch6b2.Checked = False
                End If
                'a.ch7b2.Text = cl.cChr(.Item("ch7b2", i).Value)
                If cl.cChr(.Item("ch7b2", i).Value) = "Y" Then
                    a.ch7b2.Checked = True
                Else
                    a.ch7b2.Checked = False
                End If
                'a.ch8b2.Text = cl.cChr(.Item("ch8b2", i).Value)
                If cl.cChr(.Item("ch8b2", i).Value) = "Y" Then
                    a.ch8b2.Checked = True
                Else
                    a.ch8b2.Checked = False
                End If
                'a.ch9b2.Text = cl.cChr(.Item("ch9b2", i).Value)
                If cl.cChr(.Item("ch9b2", i).Value) = "Y" Then
                    a.ch9b2.Checked = True
                Else
                    a.ch9b2.Checked = False
                End If
                'a.ch10b2.Text = cl.cChr(.Item("ch10b2", i).Value)
                If cl.cChr(.Item("ch10b2", i).Value) = "Y" Then
                    a.ch10b2.Checked = True
                Else
                    a.ch10b2.Checked = False
                End If
                'a.ch11b2.Text = cl.cChr(.Item("ch11b2", i).Value)
                If cl.cChr(.Item("ch11b2", i).Value) = "Y" Then
                    a.ch11b2.Checked = True
                Else
                    a.ch11b2.Checked = False
                End If
                'a.ch12b2.Text = cl.cChr(.Item("ch12b2", i).Value)
                If cl.cChr(.Item("ch12b2", i).Value) = "Y" Then
                    a.ch12b2.Checked = True
                Else
                    a.ch12b2.Checked = False
                End If
                a.txtb2jml1.Text = cl.cChr(.Item("b2jml1", i).Value)
                a.txtb2jml2.Text = cl.cChr(.Item("b2jml2", i).Value)
                a.txtb2jml3.Text = cl.cChr(.Item("b2jml3", i).Value)
                a.txtb2jml4.Text = cl.cChr(.Item("b2jml4", i).Value)
                a.txtb2jml5.Text = cl.cChr(.Item("b2jml5", i).Value)
                a.txtb2jml6.Text = cl.cChr(.Item("b2jml6", i).Value)
                a.txtb2jml7.Text = cl.cChr(.Item("b2jml7", i).Value)
                a.txtcnpwp.Text = cl.cChr(.Item("cnpwp", i).Value)
                a.txtcnama.Text = cl.cChr(.Item("cnama", i).Value)
                a.dtcdate.Text = cl.cChr(.Item("cdate", i).Value)
                a.txtctempat.Text = cl.cChr(.Item("ctempat", i).Value)
                a.txtdkop1.Text = cl.cChr(.Item("dkop1", i).Value)
                a.txtdkop2.Text = cl.cChr(.Item("dkop2", i).Value)
                a.txtdkop3.Text = cl.cChr(.Item("dkop3", i).Value)
                a.txtdkop4.Text = cl.cChr(.Item("dkop4", i).Value)
                a.txtdkop5.Text = cl.cChr(.Item("dkop5", i).Value)
                a.txtdjpp1.Text = cl.cChr(.Item("djpp1", i).Value)
                a.txtdjpp2.Text = cl.cChr(.Item("djpp2", i).Value)
                a.txtdjpp3.Text = cl.cChr(.Item("djpp3", i).Value)
                a.txtdjpp4.Text = cl.cChr(.Item("djpp4", i).Value)
                a.txtdjpp5.Text = cl.cChr(.Item("djpp5", i).Value)
                a.txtdjpb1.Text = cl.cChr(.Item("djpb1", i).Value)
                a.txtdjpb2.Text = cl.cChr(.Item("djpb2", i).Value)
                a.txtdjpb3.Text = cl.cChr(.Item("djpb3", i).Value)
                a.txtdjpb4.Text = cl.cChr(.Item("djpb4", i).Value)
                a.txtdjpb5.Text = cl.cChr(.Item("djpb5", i).Value)
                a.txtdjpjkp1.Text = cl.cChr(.Item("djpjkp1", i).Value)
                a.txtdjpjkp2.Text = cl.cChr(.Item("djpjkp2", i).Value)
                a.txtdjpjkp3.Text = cl.cChr(.Item("djpjkp3", i).Value)
                a.txtdjpjkp4.Text = cl.cChr(.Item("djpjkp4", i).Value)
                a.txtdjpjkp5.Text = cl.cChr(.Item("djpjkp5", i).Value)
                'a.chef1721stmspjk.Text = cl.cChr(.Item("chef1721stmspjk", i).Value)
                If cl.cChr(.Item("chef1721stmspjk", i).Value) = "Y" Then
                    a.chef1721stmspjk.Checked = True
                Else
                    a.chef1721stmspjk.Checked = False
                End If
                'a.chef1721stthnmspjk.Text = cl.cChr(.Item("chef1721stthnmspjk", i).Value)
                If cl.cChr(.Item("chef1721stthnmspjk", i).Value) = "Y" Then
                    a.chef1721stthnmspjk.Checked = True
                Else
                    a.chef1721stthnmspjk.Checked = False
                End If
                'a.chef1721ii.Text = cl.cChr(.Item("chef1721ii", i).Value)
                If cl.cChr(.Item("chef1721ii", i).Value) = "Y" Then
                    a.chef1721ii.Checked = True
                Else
                    a.chef1721ii.Checked = False
                End If
                'a.chef1721iii.Text = cl.cChr(.Item("chef1721iii", i).Value)
                If cl.cChr(.Item("chef1721iii", i).Value) = "Y" Then
                    a.chef1721iii.Checked = True
                Else
                    a.chef1721iii.Checked = False
                End If
                'a.chef1721iiia.Text = cl.cChr(.Item("chef1721iiia", i).Value)
                If cl.cChr(.Item("chef1721iiia", i).Value) = "Y" Then
                    a.chef1721iiia.Checked = True
                Else
                    a.chef1721iiia.Checked = False
                End If
                'a.chef1721iv.Text = cl.cChr(.Item("chef1721iv", i).Value)
                If cl.cChr(.Item("chef1721iv", i).Value) = "Y" Then
                    a.chef1721iv.Checked = True
                Else
                    a.chef1721iv.Checked = False
                End If
                'a.chef1721v.Text = cl.cChr(.Item("chef1721v", i).Value)
                If cl.cChr(.Item("chef1721v", i).Value) = "Y" Then
                    a.chef1721v.Checked = True
                Else
                    a.chef1721v.Checked = False
                End If
                'a.cheskuasakhss.Text = cl.cChr(.Item("cheskuasakhss", i).Value)
                If cl.cChr(.Item("cheskuasakhss", i).Value) = "Y" Then
                    a.cheskuasakhss.Checked = True
                Else
                    a.cheskuasakhss.Checked = False
                End If
                a.txtelmbr1.Text = cl.cChr(.Item("txtelmbr1", i).Value)
                a.txtelmbr2.Text = cl.cChr(.Item("txtelmbr2", i).Value)
                a.txtelmbr3.Text = cl.cChr(.Item("txtelmbr3", i).Value)
                a.txtelmbr4.Text = cl.cChr(.Item("txtelmbr4", i).Value)
                a.txtelmbr5.Text = cl.cChr(.Item("txtelmbr5", i).Value)
                a.txtelmbr6.Text = cl.cChr(.Item("txtelmbr6", i).Value)
                'a.chelembar.Text = cl.cChr(.Item("chelembar", i).Value)
                'If cl.cChr(.Item("chelembar", i).Value) = "Y" Then
                '    a.chelembar.Checked = True
                'Else
                '    a.chelembar.Checked = False
                'End If
            End With
            a.changestatform("upd")
        ElseIf statusTempForm = "[mobjkpjk]tpph23" Then
            Dim a As tpph23 = CType(Application.OpenForms("tpph23"), tpph23)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtkodeobj.Text = cl.cChr(.Item("kode", i).Value)

            End With
        ElseIf statusTempForm = "[tbktbuku42]tbktbuku42" Then
            Dim a As tbktbuku42 = CType(Application.OpenForms("tbktbuku42"), tbktbuku42)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnobukti.Text = cl.cChr(.Item("nobukti", i).Value)
                'a.rbpermohonan.Text = cl.cNum(.Item("rbpermohonan", i).Value)
                If cl.cChr(.Item("rbpermohonan", i).Value) = "Y" Then
                    a.rbpermohonan.Checked = True
                Else
                    a.rbpermohonan.Checked = False
                End If
                'a.rbskpp.Text = cl.cNum(.Item("rbskpp", i).Value)
                If cl.cChr(.Item("rbskpp", i).Value) = "Y" Then
                    a.rbskpp.Checked = True
                Else
                    a.rbskpp.Checked = False
                End If
                'a.rbplbk.Text = cl.cNum(.Item("rbplbk", i).Value)
                If cl.cChr(.Item("rbplbk", i).Value) = "Y" Then
                    a.rbplbk.Checked = True
                Else
                    a.rbplbk.Checked = False
                End If
                'a.rblain.Text = cl.cNum(.Item("rblain", i).Value)
                If cl.cChr(.Item("rblain", i).Value) = "Y" Then
                    a.rblain.Checked = True
                Else
                    a.rblain.Checked = False
                End If
                a.txtlain.Text = cl.cChr(.Item("lain", i).Value)
                a.txtnomer.Text = cl.cChr(.Item("nomer", i).Value)
                a.dtdate.Text = cl.cChr(.Item("dtate", i).Value)
                a.txtdrnama.Text = cl.cChr(.Item("drnama", i).Value)
                a.txtdralamat.Text = cl.cChr(.Item("dralamat", i).Value)
                a.txtdrnpwp.Text = cl.cChr(.Item("drnpwp", i).Value)
                a.txtdrjnspjk.Text = cl.cChr(.Item("drjnspjk", i).Value)
                a.cmbdrkdmap.Text = cl.cChr(.Item("drkdmap", i).Value)
                a.txtdrmasa.Text = cl.cChr(.Item("drmasa", i).Value)
                a.txtdrtahun.Text = cl.cChr(.Item("drtahun", i).Value)
                a.cmbnomer.Text = cl.cChr(.Item("cmbnomer", i).Value)
                a.txtdrnomer.Text = cl.cChr(.Item("drnomer", i).Value)
                a.cmbdrkdjns.Text = cl.cChr(.Item("drkdjns", i).Value)
                a.txtdrjml.Text = cl.cChr(.Item("drjml", i).Value)
                a.txtdrjml_rl.Text = cl.cChr(.Item("drjml_rl", i).Value)
                a.txttonama.Text = cl.cChr(.Item("tonama", i).Value)
                a.txttoalamat.Text = cl.cChr(.Item("toalamat", i).Value)
                a.txttonpwp.Text = cl.cChr(.Item("tonpwp", i).Value)
                a.txttojnspjk.Text = cl.cChr(.Item("tojnspjk", i).Value)
                a.txttomasa.Text = cl.cChr(.Item("tomasa", i).Value)
                a.txttotahun.Text = cl.cChr(.Item("totahun", i).Value)
                a.cmbtonomer.Text = cl.cChr(.Item("cmbtonomer", i).Value)
                a.txttonomer.Text = cl.cChr(.Item("tonomer", i).Value)
                a.cmbtokdjns.Text = cl.cChr(.Item("cmbtokdjns", i).Value)
                a.txttojml.Text = cl.cChr(.Item("tojml", i).Value)
                a.txttojml_rl.Text = cl.cChr(.Item("tojml_rl", i).Value)
                a.dtberlaku.Text = cl.cChr(.Item("dtberlaku", i).Value)
                a.txtpemindahbuku.Text = cl.cChr(.Item("pemindahbuku", i).Value)
                a.txtterbilang.Text = cl.cChr(.Item("terbilang", i).Value)
                a.txttmpt.Text = cl.cChr(.Item("tmpt", i).Value)
                a.dttmpt.Text = cl.cChr(.Item("dttmpt", i).Value)
                a.txtnamapjbt.Text = cl.cChr(.Item("namapjbt", i).Value)
                a.txtnippjbt.Text = cl.cChr(.Item("nippjbt", i).Value)

            End With
            a.changestatform("upd")

            a.changestatform("upd")
        ElseIf statusTempForm = "[tpph42]tpph42" Then
            Dim a As tpph42 = CType(Application.OpenForms("tpph42"), tpph42)
            a.Enabled = True

            With Me.dgview
                a.getidmaster(cl.cNum(.Item("id", i).Value))
                a.txtnobkt.Text = cl.cChr(.Item("nobkt", i).Value)
                a.txtnpwp.Text = cl.cChr(.Item("npwp", i).Value)
                a.txtnpwpptg.Text = cl.cChr(.Item("npwpptg", i).Value)
                a.txtnama.Text = cl.cChr(.Item("nama", i).Value)
                a.txtnamaptg.Text = cl.cChr(.Item("namaptg", i).Value)
                a.txtalamat.Text = cl.cChr(.Item("alamat", i).Value)
                a.txtalamatptg.Text = cl.cChr(.Item("alamatptg", i).Value)
                a.txtnobuktiptg.Text = cl.cChr(.Item("nobuktiptg", i).Value)
                a.txtterbilang.Text = cl.cChr(.Item("terbilang", i).Value)
                a.dttdttglptg.Text = cl.cChr(.Item("tglptg", i).Value)
                a.cmbjnstransaksi.Text = cl.cChr(.Item("jnstransaksi", i).Value)
                a.txttotal.Text = cl.cCur(.Item("total", i).Value)

                Dim dtdet As DataTable = Nothing
                dtdet = cl.table(
                    "SELECT TA.* " &
                    " FROM tpph42d TA " &
                    " WHERE TA.stat = 1 " &
                    " AND TA.idh = " & cl.cNum(.Item("id", i).Value))

                'LOAD MAIN DGVIEW
                a.dgview.Rows.Clear()
                Dim rrowpl As Integer = 0
                For r As Integer = 0 To dtdet.Rows.Count - 1
                    rrowpl = a.dgview.Rows.Add
                    With dtdet

                        '.Columns("uraian").Width = 100
                        '.Columns("nilai").Width = 80
                        '.Columns("tariff").Width = 60
                        '.Columns("pph").Width = 120

                        a.dgview.Rows(rrowpl).Cells("uraian").Value = .Rows(r).Item("uraian")
                        a.dgview.Rows(rrowpl).Cells("nilai").Value = .Rows(r).Item("nilai")
                        a.dgview.Rows(rrowpl).Cells("tariff").Value = .Rows(r).Item("tariff")
                        a.dgview.Rows(rrowpl).Cells("pph").Value = .Rows(r).Item("pph")
                    End With
                Next
                a.getcalculate()
            End With
            a.changestatform("upd")

        End If

        tempForm.Select() : tempObj.select()
        Me.Dispose()
    End Sub

    Private Sub dgview_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgview.CellMouseDoubleClick
        submitsearch()
    End Sub
    Private Sub dgview_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgview.KeyDown
        If e.KeyCode = Keys.Enter Then
            submitsearch()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsearch.Text <> "" Then
                search()
            Else
                submitsearch()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If statSQLSearch = 1 Then
            search()
        End If
    End Sub

    Private Sub btnbrowserec_Click(sender As Object, e As EventArgs) Handles btnfilter.Click

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        submitsearch()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cekform(tempForm, "BACK", Me)
        tempObj.select()
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