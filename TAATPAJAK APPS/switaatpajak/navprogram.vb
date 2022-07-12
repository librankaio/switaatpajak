Public Class navprogram

    Private Sub navprogramtemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TREEVIEW DESIGN
        Me.tvmenu.ShowRootLines = False
        Me.tvmenu.ShowLines = False
        Me.tvmenu.ShowPlusMinus = False
        Me.tvmenu.FullRowSelect = True
        Me.tvmenu.ItemHeight = 32


        Dim tblmasterdata As DataTable = cl.table(
           "SELECT T2.code, T2.name FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp=T2.id " &
           " WHERE T1.id_cusr = " & idusr & " AND T2.apptp = 'M' AND T1.canopen = 'Y'")

        Dim tbltransaction As DataTable = cl.table(
            "SELECT T2.code, T2.name FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp=T2.id " &
            " WHERE T1.id_cusr = " & idusr & " AND T2.apptp = 'T' AND T1.canopen = 'Y'")

        Dim tblconfig As DataTable = cl.table(
           "SELECT T2.code, T2.name FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp=T2.id " &
           " WHERE T1.id_cusr = " & idusr & " AND T2.apptp = 'C' AND T1.canopen = 'Y'")

        Dim tblhistory As DataTable = cl.table(
           "SELECT T2.code, T2.name FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp=T2.id " &
           " WHERE T1.id_cusr = " & idusr & " AND T2.apptp = 'H' AND T1.canopen = 'Y'")

        Dim tblreport As DataTable = cl.table(
           "SELECT T2.code, T2.name FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp=T2.id " &
           " WHERE T1.id_cusr = " & idusr & " AND T2.apptp = 'R' AND T1.canopen = 'Y'")

        If tblmasterdata.Rows.Count > 0 Or tbltransaction.Rows.Count > 0 _
            Or tblconfig.Rows.Count > 0 Or tblreport.Rows.Count > 0 Then

            Dim statnodeprice As Integer = 0
            If tblmasterdata.Rows.Count > 0 Then
                tvmenu.Nodes.Add("masterdata", "MASTER DATA")
                For i As Integer = 0 To tblmasterdata.Rows.Count - 1
                    tvmenu.Nodes("masterdata").Nodes.Add(tblmasterdata.Rows(i).Item("code"), tblmasterdata.Rows(i).Item("name"))
                Next
            End If

            Dim statnodepur As Integer = 0, statnodesales As Integer = 0, statnodepayment As Integer = 0, _
                statnodeacc As Integer = 0, statnodeinv As Integer = 0

            If tbltransaction.Rows.Count > 0 Then
                tvmenu.Nodes.Add("transaction", "TRANSAKSI")
                For i As Integer = 0 To tbltransaction.Rows.Count - 1
                    tvmenu.Nodes("transaction").Nodes.Add(tbltransaction.Rows(i).Item("code"), tbltransaction.Rows(i).Item("name"))
                Next
            End If

            
            If tblconfig.Rows.Count > 0 Then
                tvmenu.Nodes.Add("config", "CONFIG")
                For i As Integer = 0 To tblconfig.Rows.Count - 1
                    tvmenu.Nodes("config").Nodes.Add(tblconfig.Rows(i).Item("code"), tblconfig.Rows(i).Item("name"))
                Next
            End If

            If tblhistory.Rows.Count > 0 Then
                tvmenu.Nodes.Add("history", "HISTORY")
                For i As Integer = 0 To tblhistory.Rows.Count - 1
                    tvmenu.Nodes("history").Nodes.Add(tblhistory.Rows(i).Item("code"), tblhistory.Rows(i).Item("name"))
                Next
            End If

            If tblreport.Rows.Count > 0 Then
                tvmenu.Nodes.Add("laporan", "LAPORAN")
                For i As Integer = 0 To tblreport.Rows.Count - 1
                    tvmenu.Nodes("laporan").Nodes.Add(tblreport.Rows(i).Item("code"), tblreport.Rows(i).Item("name"))
                Next
            End If
        End If

        Try
            Me.tvmenu.Nodes("masterdata").ImageIndex = 0
            Me.tvmenu.Nodes("masterdata").SelectedImageIndex = 1
            Me.tvmenu.Nodes("transaction").ImageIndex = 0
            Me.tvmenu.Nodes("transaction").SelectedImageIndex = 1
            Me.tvmenu.Nodes("config").ImageIndex = 0
            Me.tvmenu.Nodes("config").SelectedImageIndex = 1
        Catch : End Try
        'Me.tvmenu.Nodes("history").ImageIndex = 0
        'Me.tvmenu.Nodes("history").SelectedImageIndex = 1
        'Me.tvmenu.Nodes("laporan").ImageIndex = 0
        'Me.tvmenu.Nodes("laporan").SelectedImageIndex = 1


        Me.SetBounds(0, 0, Me.Width, Me.Height)

    End Sub
    Private Sub enterMenu()
        Try
            Dim frm As New Form
            Dim Tfrm As String = tvmenu.SelectedNode.Name.ToString



            'master data
            'If Tfrm = "msupp" Then : frm = msupp
            'ElseIf Tfrm = "mcust" Then : frm = mcust
            'ElseIf Tfrm = "mitem" And cl.readData("SELECT strvl FROM csetting WHERE name = 'POS'") = "N" Then : frm = mitm
            'ElseIf Tfrm = "mitem" And cl.readData("SELECT strvl FROM csetting WHERE name = 'POS'") = "Y" Then : frm = mitmpos
            'ElseIf Tfrm = "mitmtp" Then : frm = mitmtp
            'ElseIf Tfrm = "mwhse" Then : frm = mwhse
            'ElseIf Tfrm = "msales" Then : frm = msales
            'ElseIf Tfrm = "mcoa" Then : frm = mcoa
            'ElseIf Tfrm = "masset" Then : frm = masset
            'ElseIf Tfrm = "mterm" Then : frm = mterm
            'ElseIf Tfrm = "muom" Then : frm = muom
            'ElseIf Tfrm = "mship" Then : frm = mship
            'ElseIf Tfrm = "mpaytp" Then : frm = mpaytp
            '    'transactions
            'ElseIf Tfrm = "tso" Then : frm = tso
            'ElseIf Tfrm = "tdo" Then : frm = tdo
            'ElseIf Tfrm = "tiv" Then : frm = tiv
            'ElseIf Tfrm = "tret" Then : frm = tret
            'ElseIf Tfrm = "tpret" Then : frm = tpret
            'ElseIf Tfrm = "tpo" Then : frm = tpo
            '    'ElseIf Tfrm = "trec" Then : frm = trec
            '    'ElseIf Tfrm = "tpv" Then : frm = tpv
            '    'ElseIf Tfrm = "tpy" Then : frm = tpy
            '    'ElseIf Tfrm = "tps" Then : frm = tps
            '    'ElseIf Tfrm = "tje" Then : frm = tje
            '    '    '  ElseIf Tfrm = "topname" Then : frm = topname
            '    'ElseIf Tfrm = "tadj" Then : frm = tadj
            '    'ElseIf Tfrm = "trf" Then : frm = trf
            '    '    'config
            '    'ElseIf Tfrm = "sysconfig" Then : frm = sysconfig
            '    'ElseIf Tfrm = "printconfig" Then : frm = cprinterconfig
            '    'ElseIf Tfrm = "changepass" Then : frm = changepass
            '    'ElseIf Tfrm = "accountset" Then : frm = caccount
            '    'ElseIf Tfrm = "csetting" Then : frm = csetting
            '    'ElseIf Tfrm = "usr" Then : frm = usr
            '    'ElseIf Tfrm = "usrpriv" Then : frm = usrpriv
            '    '    '    'history
            '    '    'ElseIf Tfrm = "userlog" Then : frm = huserlog
            '    '    'ElseIf Tfrm = "datalog" Then : frm = hmstr
            '    '    'ElseIf Tfrm = "translog" Then : frm = htrans
            '    '    '    'reports
            '    '    'ElseIf Tfrm = "tpdp" Then : frm = laporanperdokpabean
            '    '    'ElseIf Tfrm = "tbb" Then : frm = laporanmutasibb
            '    '    'ElseIf Tfrm = "tbj" Then : frm = laporanmutasibj
            '    '    'ElseIf Tfrm = "tsr" Then : frm = laporanmutasiscrap
            '    '    'ElseIf Tfrm = "tpr" Then : frm = laporanmutasimesin
            '    '    'ElseIf Tfrm = "twip" Then : frm = laporanmutasiwip
            '    '    'ElseIf Tfrm = "tdocsum" Then : frm = laporansummarydokumenpabean
            '    '    'ElseIf Tfrm = "tks1" Then
            '    '    '    If Format(Now(), "yyyyMMdd") = "20160610" Then
            '    '    '        cl.msgError("Versi trial selesai!", "Information")
            '    '    '        Exit Sub
            '    '    '      End If

            '    '    '    frm = lapkartustock
            '    'End If

            If frm.Name <> "" Then
                cekform(frm, "NEW", Me)
            End If
        Catch : End Try
    End Sub

    Private Sub tvmenu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvmenu.DoubleClick
        enterMenu()
    End Sub

    Private Sub tvmenu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tvmenu.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            enterMenu()
        End If
    End Sub
End Class