Public Class menubaru
    Private Sub btnpph21_Click(sender As Object, e As EventArgs) Handles btnpph21.Click
        pnlonbtn.Height = btnpph21.Height
        pnlonbtn.Top = btnpph21.Top
        pnlpph21.Visible = True
        pnlpph23.Visible = False
        pnlpph42.Visible = False
    End Sub

    Private Sub btnpph23_Click(sender As Object, e As EventArgs) Handles btnpph23.Click
        pnlonbtn.Height = btnpph23.Height
        pnlonbtn.Top = btnpph23.Top
        pnlpph21.Visible = False
        pnlpph23.Visible = True
        pnlpph42.Visible = False
    End Sub

    Private Sub btnpph42_Click(sender As Object, e As EventArgs) Handles btnpph42.Click
        pnlonbtn.Height = btnpph42.Height
        pnlonbtn.Top = btnpph42.Top
        pnlpph21.Visible = False
        pnlpph23.Visible = False
        pnlpph42.Visible = True
    End Sub
    Private Sub cprinterconfigmi_Click(sender As Object, e As EventArgs)
        cekform(cprinterconfig, "NEW", Me)
    End Sub


    Private Sub historytsmi_Click(sender As Object, e As EventArgs) Handles historytsmi.Click

    End Sub

    Private Sub mnegarami_Click(sender As Object, e As EventArgs) Handles mnegarami.Click
        cekform(mngara, "NEW", Me)
    End Sub

    Private Sub mkppmi_Click(sender As Object, e As EventArgs) Handles mkppmi.Click
        cekform(mkpp, "NEW", Me)
    End Sub

    Private Sub mobjkpjkmi_Click(sender As Object, e As EventArgs) Handles mobjkpjkmi.Click
        cekform(mobjkpjk, "NEW", Me)
    End Sub

    Private Sub msspmi_Click(sender As Object, e As EventArgs) Handles msspmi.Click
        cekform(mssp, "NEW", Me)
    End Sub
    Private Sub mpenghasilmi_Click(sender As Object, e As EventArgs) Handles mpenghasilmi.Click
        cekform(mpenghasil, "NEW", Me)
    End Sub

    Private Sub mpenghasila1_Click(sender As Object, e As EventArgs) Handles mpenghasila1mi.Click
        cekform(mpenghasila1, "NEW", Me)
    End Sub

    Private Sub mpenghasila2_Click(sender As Object, e As EventArgs) Handles mpenghasila2mi.Click
        cekform(mpenghasila2, "NEW", Me)
    End Sub

    Private Sub PTKPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PTKPToolStripMenuItem.Click
        cekform(mptkp, "NEW", Me)
    End Sub

    Private Sub Pasal17BerlapisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mpasal17mi.Click
        cekform(mpasal17, "NEW", Me)
    End Sub

    Private Sub mpasal21mi_Click(sender As Object, e As EventArgs) Handles mpasal21mi.Click

    End Sub

    Private Sub mpesangonmi_Click(sender As Object, e As EventArgs) Handles mpesangonmi.Click
        cekform(mpasal21, "NEW", Me)
    End Sub

    Private Sub mpensiunmi_Click(sender As Object, e As EventArgs) Handles mpensiunmi.Click
        cekform(mpensiun, "NEW", Me)
    End Sub

    Private Sub mimbalanpns_Click(sender As Object, e As EventArgs) Handles mimbalanpnsmi.Click
        cekform(mimbalanpns, "NEW", Me)
    End Sub

    Private Sub mbyjbtn_Click(sender As Object, e As EventArgs) Handles mbyjbtnmi.Click
        cekform(mbyjbtn, "NEW", Me)
    End Sub

    Private Sub mupahharianmi_Click(sender As Object, e As EventArgs) Handles mupahharianmi.Click
        cekform(mupahharian, "NEW", Me)
    End Sub

    Private Sub msetmasami_Click(sender As Object, e As EventArgs) Handles msetmasami.Click
        cekform(msetmasa, "NEW", Me)
    End Sub

    Private Sub tpph21mi_Click(sender As Object, e As EventArgs) Handles tpph21mi.Click
        'cekform(tpph21, "NEW", Me)
    End Sub

    Private Sub tbuktiptgfinalmi_Click(sender As Object, e As EventArgs) Handles tbuktiptgfinalmi.Click
        cekform(tbuktiptgfinal, "NEW", Me)
    End Sub

    Private Sub tbuktiptgtdkfinalmi_Click(sender As Object, e As EventArgs) Handles tbuktiptgtdkfinalmi.Click
        cekform(tbuktiptgtdkfinal, "NEW", Me)
    End Sub

    Private Sub tpph23mi_Click(sender As Object, e As EventArgs) Handles tpph23mi.Click
        'cekform(tpph23, "NEW", Me)
    End Sub

    Private Sub tpph42mi_Click(sender As Object, e As EventArgs) Handles tpph42mi.Click
        'cekform(tpph42, "NEW", Me)
    End Sub

    Private Sub PPhPasal42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PPhPasal42ToolStripMenuItem.Click
        cekform(mpasal42, "NEW", Me)
    End Sub

    Private Sub DaftarBiayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBiayaToolStripMenuItem.Click
        cekform(tdaftarbiaya, "NEW", Me)
    End Sub
    Private Sub InputDataPemotongToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cekform(tinputdatapemotongpjk, "NEW", Me)
    End Sub

    Private Sub InputSSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPToolStripMenuItem.Click
        cekform(tinputssppbk21, "NEW", Me)
    End Sub

    Private Sub InputSSPPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPPPh23ToolStripMenuItem.Click
        cekform(tinputssppbk23, "NEW", Me)
    End Sub

    Private Sub InputSSPPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputSSPPPh42ToolStripMenuItem.Click
        cekform(tinputssppbk42, "NEW", Me)
    End Sub

    Private Sub SatuMasaPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuMasaPajakToolStripMenuItem.Click
        cekform(tdaftarpemotongpjkbulan, "NEW", Me)
    End Sub

    Private Sub SatuTahunPajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuTahunPajakToolStripMenuItem.Click
        cekform(tdaftarpemotongpjktahun, "NEW", Me)
    End Sub

    Private Sub SPTIndukPPhPsl42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTIndukPPhPsl42ToolStripMenuItem.Click
        cekform(tsptmasapphfinal42, "NEW", Me)
    End Sub

    Private Sub SPTInduk1721ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTInduk1721ToolStripMenuItem.Click
        cekform(tsptmasa21induk, "NEW", Me)
    End Sub

    Private Sub BuktiPotongPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuktiPotongPPh23ToolStripMenuItem.Click
        cekform(tpph23, "NEW", Me)
    End Sub

    Private Sub BuktiPotongPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuktiPotongPPh42ToolStripMenuItem.Click
        cekform(tpph42, "NEW", Me)
    End Sub

    Private Sub InputBuktiPemindahbukuanPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputBuktiPemindahbukuanPPh42ToolStripMenuItem.Click
        cekform(tbktbuku42, "NEW", Me)
    End Sub

    Private Sub SPTIndukPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPTIndukPPh23ToolStripMenuItem.Click
        cekform(tsptmasa23, "NEW", Me)
    End Sub

    Private Sub menuutama_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        With cl
            .openTrans()
            .execCmdTrans("UPDATE msetmasa SET statpjk = 'O' WHERE stat = 1")
            .closeTrans(tpph23mi)
        End With
    End Sub

    Private Sub mprofilemi_Click_1(sender As Object, e As EventArgs) Handles mprofilemi.Click
        cekform(mprofile, "NEW", Me)
    End Sub

    Private Sub A1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A1ToolStripMenuItem.Click
        cekform(ta1, "NEW", Me)
    End Sub

    Private Sub DaftarBungaPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBungaPPh42ToolStripMenuItem.Click
        cekform(tdaftarpph42bunga, "NEW", Me)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        tpph23.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        mnegara_baru.Show()
    End Sub

    'Private Sub ExportCSVPPh21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh21ToolStripMenuItem.Click
    '    cekform(tcsv21, "NEW", Me)
    'End Sub

    'Private Sub ExportCSVPPh23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh23ToolStripMenuItem.Click
    '    cekform(tcsv23, "NEW", Me)
    'End Sub

    'Private Sub ExportCSVPPh42ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCSVPPh42ToolStripMenuItem.Click
    '    cekform(tcsv42, "NEW", Me)
    'End Sub

    'Private Sub UploadDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadDataToolStripMenuItem.Click
    '    cekform(uploaddata, "NEW", Me)
    'End Sub

    'Private Sub TarifPasal23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifPasal23ToolStripMenuItem.Click
    '    cekform(mpasal23, "NEW", Me)
    'End Sub
End Class