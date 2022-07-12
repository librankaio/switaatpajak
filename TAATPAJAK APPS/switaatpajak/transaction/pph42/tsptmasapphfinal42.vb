Imports CrystalDecisions.CrystalReports.Engine
Public Class tsptmasapphfinal42
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

    Private Sub getmth()
        If masapjk = "January" Then
            masapajakint = 1
        ElseIf masapjk = "February" Then
            masapajakint = 2
        ElseIf masapjk = "March" Then
            masapajakint = 3
        ElseIf masapjk = "April" Then
            masapajakint = 4
        ElseIf masapjk = "May" Then
            masapajakint = 5
        ElseIf masapjk = "June" Then
            masapajakint = 6
        ElseIf masapjk = "July" Then
            masapajakint = 7
        ElseIf masapjk = "August" Then
            masapajakint = 8
        ElseIf masapjk = "September" Then
            masapajakint = 9
        ElseIf masapjk = "October" Then
            masapajakint = 10
        ElseIf masapjk = "November" Then
            masapajakint = 11
        ElseIf masapjk = "December" Then
            masapajakint = 12
        End If
    End Sub

    Private Sub gencmb()
        '  MsgBox(masapajakint)
        With cl
            '-----------HADIAH BUNGA DEPOSIT---------------
            txth1nop1.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-401-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf1.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-401-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg1.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-401-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-401-03'")))
            '-----------END BUNGA DEPOSIT---------------
            '-----------HADIAH BUNGA DEPOSIT---------------
            txth1nop2.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf2.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg2.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-403-02'")))
            '-----------END BUNGA DEPOSIT---------------
            '-----------HADIAH BUNGA DEPOSIT---------------
            txth1nop3.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf3.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg3.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-405-01'")))
            '-----------END BUNGA DEPOSIT---------------
            '-----------HADIAH BUNGA DEPOSIT---------------
            txth1nop4.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf4.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg4.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-405-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-405-02'")))
            '-----------END BUNGA DEPOSIT---------------
            '-----------Penghasilan dari Transaksi---------------
            txth1nop5.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-08' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf5.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-08' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg5.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-08' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-08'")))
            '-----------END Penghasilan dari Transaksi---------------
            '-----------Penghasilan dari Transaksi---------------
            txth1nop6.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-09' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf6.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-09' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg6.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-09' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-09'")))
            '-----------END Penghasilan dari Transaksi---------------
            '-----------Bunga dan/atau Diskonto Obligasi dan Surat Berharga Negara (SBN)---------------
            txth1nop7.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-10' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf7.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-10' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg7.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-10' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-10'")))
            '-----------END Bunga dan/atau Diskonto Obligasi dan Surat Berharga Negara (SBN)---------------
            '-----------HADIAH UNDIAN---------------
            txth1nop8.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-11' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf8.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-11' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg8.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-11' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-11'")))
            '-----------END HADIAH UNDIAN---------------
            '-----------Penghasilan dari Persewaan Tanah dan/atau Bangunan---------------
            txth1nop9.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-12' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf9.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-12' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg9.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-12' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-12'")))
            '-----------END Penghasilan dari Persewaan Tanah dan/atau Bangunan---------------
            '-----------Penghasilan dari Persewaan Tanah dan/atau Bangunan---------------
            txth1nop10.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-13' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf10.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-13' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg10.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-13' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-13'")))

            txth1nop11.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-14' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf11.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-14' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg11.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-14' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-14'")))

            txth1nop12.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf12.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg12.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-417-01'")))

            txth1nop13.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf13.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg13.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-417-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-417-02'")))

            txth1nop14.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-419-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf14.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-419-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg14.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-419-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-419-01'")))

            txth1nop15.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-423-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf15.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-423-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg15.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-423-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-423-01'")))

            txth1nop16.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf16.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg16.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-421-01'")))

            txth1nop17.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf17.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg17.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-421-02'")))

            txth1nop18.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf18.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg18.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-421-03'")))

            txth1nop19.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-499-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf19.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-499-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg19.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-499-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-499-02'")))

            txth1nop20.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf20.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg20.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-402-01'")))

            txth1nop21.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf21.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg21.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-402-02'")))

            txth1nop22.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf22.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg22.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-402-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-402-03'")))

            txth1nop23.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf23.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg23.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-01'")))

            txth1nop24.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1trf24.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth1pphptg24.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-02' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-02'")))
            '-----------END Penghasilan dari Persewaan Tanah dan/atau Bangunan---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop1.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop1.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop1.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-03' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-03'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop2.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop2.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop2.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-04'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop3.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop3.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop3.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-05'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop4.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-06' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop4.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-06' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop4.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-06' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-06'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop5.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-07' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop5.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-07' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop5.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-07' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-07'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Penghasilan dari Usaha Jasa Konstruksi---------------
            txth2nop6.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop6.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop6.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-403-01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-403-01'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Wajib Pajak yang Melakukan Pengalihan Hak Atas Tanah/Bangunan---------------
            txth2nop7.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop7.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop7.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-04' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-421-04'")))
            '-----------END Penghasilan dari Usaha Jasa Konstruksi---------------
            '-----------Bunga Simpanan yang Dibayarkan oleh Koperasi kepada Anggota Koperasi Orang Pribadi---------------
            txth2nop8.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop8.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop8.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-421-05' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-421-05'")))
            '-----------END Bunga Simpanan yang Dibayarkan oleh Koperasi kepada Anggota Koperasi Orang Pribadi---------------
            '-----------Penghasilan dari Transaksi Derivatif Berupa Kontrak Berjangka yang di perdagangkan di Bursa---------------
            txth2nop9.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-22' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop9.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-22' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop9.Text = cl.cCur(cl.cNum(.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-22' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-22'")))
            '-----------END Penghasilan dari Transaksi Derivatif Berupa Kontrak Berjangka yang di perdagangkan di Bursa---------------
            '-----------Dividen yang Diterima atau Diperoleh Wajib Pajak Orang Pribadi Dalam Negeri---------------
            txth2nop10.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-23' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop10.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-23' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop10.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-23' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-23'")))

            txth2nop11.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-24' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop11.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-24' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop11.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-24' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-24'")))

            txth2nop12.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-25' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop12.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-25' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop12.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-25' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-25'")))

            txth2nop13.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-26' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop13.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-26' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop13.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-26' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-26'")))

            txth2nop14.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-27' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop14.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-27' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop14.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-27' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-27'")))

            txth2nop15.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-28' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop15.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-28' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            txth2nop15.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '28-409-28' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "' AND tb.stat = 1")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '28-409-28'")))

            'txth2nop16.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop16.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop16.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '411128/419/01'")))

            'txth2nop17.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop17.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop17.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '411128/419/01'")))

            'txth2nop18.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop18.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop18.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '411128/419/01'")))

            'txth2nop19.Text = cl.cCur(cl.readData("SELECT ifnull(sum(nilai),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop19.Text = cl.cCur(cl.readData("SELECT ifnull(tariff,0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'"))
            'txth2nop19.Text = cl.cCur(cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tpph42 ta INNER JOIN tpph42d tb ON ta.id=tb.idh WHERE tb.uraian = '411128/419/01' AND ta.masapjk ='" & masapjk & "' AND ta.thnpjk ='" & thnpjk & "'")) - cl.cNum(cl.readData("SELECT ifnull(sum(pph),0) FROM tinputssppbk42 WHERE stat = 1 AND masapjk='" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kdpjk = '411128/419/01'")))
            '-----------END Dividen yang Diterima atau Diperoleh Wajib Pajak Orang Pribadi Dalam Negeri---------------
            '-----------Penghasil Tertentu Lainnya---------------
            'txth2nop11.Text =
            'txth2nop11.Text =
            'txth2nop11.Text = 

            'txth2nop12.Text =
            'txth2nop12.Text =
            'txth2nop12.Text = 

            'txth2nop13.Text =
            'txth2nop13.Text =
            'txth2nop13.Text = 

            'txth2nop14.Text =
            'txth2nop14.Text =
            'txth2nop14.Text = 
            '-----------END Penghasil Tertentu Lainnya---------------
        End With
    End Sub
    Private Sub clearData()
        txth1npwp.Text = cl.readData("SELECT npwp FROM mprofile WHERE id = 1")
        txth1nama.Text = cl.readData("SELECT nama FROM mprofile WHERE id = 1")
        txth1alamat.Text = cl.readData("SELECT alamat FROM mprofile WHERE id = 1")
        txth1mspjk.Text = masapjk
        txth1mspjk_rl.Text = thnpjk
        txth1kdpbtln.Text = 0
        ' -- HALAMAN 1
        txth1nop1.Text = 0
        txth1nop2.Text = 0
        txth1nop3.Text = 0
        txth1nop4.Text = 0
        txth1nop5.Text = 0
        txth1nop6.Text = 0
        txth1nop7.Text = 0
        txth1nop8.Text = 0
        txth1nop9.Text = 0
        txth1nop10.Text = 0
        txth1trf1.Text = 0
        txth1trf2.Text = 0
        txth1trf3.Text = 0
        txth1trf4.Text = 0
        txth1trf5.Text = 0
        txth1trf6.Text = 0
        txth1trf7.Text = 0
        txth1trf8.Text = 0
        txth1trf9.Text = 0
        txth1trf10.Text = 0
        txth1pphptg1.Text = 0
        txth1pphptg2.Text = 0
        txth1pphptg3.Text = 0
        txth1pphptg4.Text = 0
        txth1pphptg5.Text = 0
        txth1pphptg6.Text = 0
        txth1pphptg7.Text = 0
        txth1pphptg8.Text = 0
        txth1pphptg9.Text = 0
        txth1pphptg10.Text = 0
        ' -- HALAMAN2 
        txth2nop1.Text = 0
        txth2nop2.Text = 0
        txth2nop3.Text = 0
        txth2nop4.Text = 0
        txth2nop5.Text = 0
        txth2nop6.Text = 0
        txth2nop7.Text = 0
        txth2nop8.Text = 0
        txth2nop9.Text = 0
        txth2nop10.Text = 0
        txth2nop16.Text = 0
        txth2nop17.Text = 0
        txth2nop18.Text = 0
        txth2nop19.Text = 0
        txth2nop20.Text = 0
        txth2trf1.Text = 0
        txth2trf2.Text = 0
        txth2trf3.Text = 0
        txth2trf4.Text = 0
        txth2trf5.Text = 0
        txth2trf6.Text = 0
        txth2trf7.Text = 0
        txth2trf8.Text = 0
        txth2trf9.Text = 0
        txth2trf10.Text = 0
        txth2trf16.Text = 0
        txth2trf17.Text = 0
        txth2trf18.Text = 0
        txth2trf19.Text = 0
        txth2trf20.Text = 0
        txth2pphptg1.Text = 0
        txth2pphptg2.Text = 0
        txth2pphptg3.Text = 0
        txth2pphptg4.Text = 0
        txth2pphptg5.Text = 0
        txth2pphptg6.Text = 0
        txth2pphptg7.Text = 0
        txth2pphptg8.Text = 0
        txth2pphptg9.Text = 0
        txth2pphptg10.Text = 0
        txth2pphptg16.Text = 0
        txth2pphptg17.Text = 0
        txth2pphptg18.Text = 0
        txth2pphptg19.Text = 0
        txth2pphptg20.Text = 0
        txtpenghasil11a.Text = 0
        txtpenghasil11b.Text = 0
        txtpenghasil11c.Text = 0

        chssp.Checked = True
        txtssp.Text = ""
        chbpppsl42.Checked = True
        txtbpppsl42.Text = ""
        chdbpfinalpsl42.Checked = True
        chskk.Checked = False

    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "New" Then
            clearData()
            getmth()
            gencmb()
            calc()

            btnsave.Text = "Save"
            'gencode()
            btndelete.Visible = False
            btnprint.Visible = False

        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True
        End If
        Me.Select() : txth1nama.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("New")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txth1nama.Select()
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txth1nama, "Nama Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            '------ start validasi chssp
            Dim sspauthorize As String
            If chssp.Checked = True Then
                sspauthorize = "Y"
            Else
                sspauthorize = "N"
            End If
            '------ end validasi
            '------ start validasi chbpppsl42
            Dim pppsl42 As String
            If chbpppsl42.Checked = True Then
                pppsl42 = "Y"
            Else
                pppsl42 = "N"
            End If
            '------ end validasi
            '------ start validasi chdbpfinalpsl42
            Dim finalpsl42 As String
            If chdbpfinalpsl42.Checked = True Then
                finalpsl42 = "Y"
            Else
                finalpsl42 = "N"
            End If
            '------ end validasi
            '------ start validasi chdbpfinalpsl42
            Dim skk As String
            If chskk.Checked = True Then
                skk = "Y"
            Else
                skk = "N"
            End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tsptmasapphfinal42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txth1nama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stsptmasapphfinal42 (" &
                        "  '" & .cChr(txth1npwp.Text) & "'" &
                        " ,'" & .cChr(txth1nama.Text) & "'" &
                        " ,'" & .cChr(txth1alamat.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk_rl.Text) & "'" &
                        " ,'" & .cChr(txth1kdpbtln.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth1nop2.Text) & "'" &
                        " ,'" & .cChr(txth1nop3.Text) & "'" &
                        " ,'" & .cChr(txth1nop4.Text) & "'" &
                        " ,'" & .cChr(txth1nop5.Text) & "'" &
                        " ,'" & .cChr(txth1nop6.Text) & "'" &
                        " ,'" & .cChr(txth1nop7.Text) & "'" &
                        " ,'" & .cChr(txth1nop8.Text) & "'" &
                        " ,'" & .cChr(txth1nop9.Text) & "'" &
                        " ,'" & .cChr(txth1nop10.Text) & "'" &
                        " ,'" & .cChr(txth1trf1.Text) & "'" &
                        " ,'" & .cChr(txth1trf2.Text) & "'" &
                        " ,'" & .cChr(txth1trf3.Text) & "'" &
                        " ,'" & .cChr(txth1trf4.Text) & "'" &
                        " ,'" & .cChr(txth1trf5.Text) & "'" &
                        " ,'" & .cChr(txth1trf6.Text) & "'" &
                        " ,'" & .cChr(txth1trf7.Text) & "'" &
                        " ,'" & .cChr(txth1trf8.Text) & "'" &
                        " ,'" & .cChr(txth1trf9.Text) & "'" &
                        " ,'" & .cChr(txth1trf10.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth2nop2.Text) & "'" &
                        " ,'" & .cChr(txth2nop3.Text) & "'" &
                        " ,'" & .cChr(txth2nop4.Text) & "'" &
                        " ,'" & .cChr(txth2nop5.Text) & "'" &
                        " ,'" & .cChr(txth2nop6.Text) & "'" &
                        " ,'" & .cChr(txth2nop7.Text) & "'" &
                        " ,'" & .cChr(txth2nop8.Text) & "'" &
                        " ,'" & .cChr(txth2nop9.Text) & "'" &
                        " ,'" & .cChr(txth2nop10.Text) & "'" &
                        " ,'" & .cChr(txth2nop16.Text) & "'" &
                        " ,'" & .cChr(txth2nop17.Text) & "'" &
                        " ,'" & .cChr(txth2nop18.Text) & "'" &
                        " ,'" & .cChr(txth2nop19.Text) & "'" &
                        " ,'" & .cChr(txth2nop20.Text) & "'" &
                        " ,'" & .cChr(txth2trf1.Text) & "'" &
                        " ,'" & .cChr(txth2trf2.Text) & "'" &
                        " ,'" & .cChr(txth2trf3.Text) & "'" &
                        " ,'" & .cChr(txth2trf4.Text) & "'" &
                        " ,'" & .cChr(txth2trf5.Text) & "'" &
                        " ,'" & .cChr(txth2trf6.Text) & "'" &
                        " ,'" & .cChr(txth2trf7.Text) & "'" &
                        " ,'" & .cChr(txth2trf8.Text) & "'" &
                        " ,'" & .cChr(txth2trf9.Text) & "'" &
                        " ,'" & .cChr(txth2trf10.Text) & "'" &
                        " ,'" & .cChr(txth2trf16.Text) & "'" &
                        " ,'" & .cChr(txth2trf17.Text) & "'" &
                        " ,'" & .cChr(txth2trf18.Text) & "'" &
                        " ,'" & .cChr(txth2trf19.Text) & "'" &
                        " ,'" & .cChr(txth2trf20.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg16.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg17.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg18.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg19.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg20.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11a.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11b.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11c.Text) & "'" &
                        " ,'" & sspauthorize & "'" &
                        " ,'" & .cChr(txtssp.Text) & "'" &
                        " ,'" & pppsl42 & "'" &
                        " ,'" & .cChr(txtbpppsl42.Text) & "'" &
                        " ,'" & finalpsl42 & "'" &
                        " ,'" & skk & "'" &
                       " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txth1nama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tsptmasapphfinal42'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txth1nama.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stsptmasapphfinal42 (" &
                        "  '" & .cChr(txth1npwp.Text) & "'" &
                        " ,'" & .cChr(txth1nama.Text) & "'" &
                        " ,'" & .cChr(txth1alamat.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk_rl.Text) & "'" &
                        " ,'" & .cChr(txth1kdpbtln.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth1nop2.Text) & "'" &
                        " ,'" & .cChr(txth1nop3.Text) & "'" &
                        " ,'" & .cChr(txth1nop4.Text) & "'" &
                        " ,'" & .cChr(txth1nop5.Text) & "'" &
                        " ,'" & .cChr(txth1nop6.Text) & "'" &
                        " ,'" & .cChr(txth1nop7.Text) & "'" &
                        " ,'" & .cChr(txth1nop8.Text) & "'" &
                        " ,'" & .cChr(txth1nop9.Text) & "'" &
                        " ,'" & .cChr(txth1nop10.Text) & "'" &
                        " ,'" & .cChr(txth1trf1.Text) & "'" &
                        " ,'" & .cChr(txth1trf2.Text) & "'" &
                        " ,'" & .cChr(txth1trf3.Text) & "'" &
                        " ,'" & .cChr(txth1trf4.Text) & "'" &
                        " ,'" & .cChr(txth1trf5.Text) & "'" &
                        " ,'" & .cChr(txth1trf6.Text) & "'" &
                        " ,'" & .cChr(txth1trf7.Text) & "'" &
                        " ,'" & .cChr(txth1trf8.Text) & "'" &
                        " ,'" & .cChr(txth1trf9.Text) & "'" &
                        " ,'" & .cChr(txth1trf10.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth2nop2.Text) & "'" &
                        " ,'" & .cChr(txth2nop3.Text) & "'" &
                        " ,'" & .cChr(txth2nop4.Text) & "'" &
                        " ,'" & .cChr(txth2nop5.Text) & "'" &
                        " ,'" & .cChr(txth2nop6.Text) & "'" &
                        " ,'" & .cChr(txth2nop7.Text) & "'" &
                        " ,'" & .cChr(txth2nop8.Text) & "'" &
                        " ,'" & .cChr(txth2nop9.Text) & "'" &
                        " ,'" & .cChr(txth2nop10.Text) & "'" &
                        " ,'" & .cChr(txth2nop16.Text) & "'" &
                        " ,'" & .cChr(txth2nop17.Text) & "'" &
                        " ,'" & .cChr(txth2nop18.Text) & "'" &
                        " ,'" & .cChr(txth2nop19.Text) & "'" &
                        " ,'" & .cChr(txth2nop20.Text) & "'" &
                        " ,'" & .cChr(txth2trf1.Text) & "'" &
                        " ,'" & .cChr(txth2trf2.Text) & "'" &
                        " ,'" & .cChr(txth2trf3.Text) & "'" &
                        " ,'" & .cChr(txth2trf4.Text) & "'" &
                        " ,'" & .cChr(txth2trf5.Text) & "'" &
                        " ,'" & .cChr(txth2trf6.Text) & "'" &
                        " ,'" & .cChr(txth2trf7.Text) & "'" &
                        " ,'" & .cChr(txth2trf8.Text) & "'" &
                        " ,'" & .cChr(txth2trf9.Text) & "'" &
                        " ,'" & .cChr(txth2trf10.Text) & "'" &
                        " ,'" & .cChr(txth2trf16.Text) & "'" &
                        " ,'" & .cChr(txth2trf17.Text) & "'" &
                        " ,'" & .cChr(txth2trf18.Text) & "'" &
                        " ,'" & .cChr(txth2trf19.Text) & "'" &
                        " ,'" & .cChr(txth2trf20.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg16.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg17.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg18.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg19.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg20.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11a.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11b.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11c.Text) & "'" &
                        " ,'" & sspauthorize & "'" &
                        " ,'" & .cChr(txtssp.Text) & "'" &
                        " ,'" & pppsl42 & "'" &
                        " ,'" & .cChr(txtbpppsl42.Text) & "'" &
                        " ,'" & finalpsl42 & "'" &
                        " ,'" & skk & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txth1nama.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tsptmasapphfinal42
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tsptmasapphfinal42 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("h1npwp").Visible = True : .Columns("h1npwp").HeaderText = "NPWP"
            .Columns("h1nama").Visible = True : .Columns("h1nama").HeaderText = "Nama"
            .Columns("h1mspjk").Visible = True : .Columns("h1mspjk").HeaderText = "Masa Pajak"
        End With
        a.loadStatusTempForm(Me, Me.txth1nama, "[tsptmasapphfinal42]tsptmasapphfinal42")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
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
            rpt = New rpttsptmasapphfinal42
            f.crviewer.ReportSource = rpt
            cekform(f, "NEW", Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    '!-----------WARNING ERROR----------!
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tsptmasapphfinal42'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txth1nama.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stsptmasapphfinal42 (" &
                        "  '" & .cChr(txth1npwp.Text) & "'" &
                        " ,'" & .cChr(txth1nama.Text) & "'" &
                        " ,'" & .cChr(txth1alamat.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk.Text) & "'" &
                        " ,'" & .cChr(txth1mspjk_rl.Text) & "'" &
                        " ,'" & .cChr(txth1kdpbtln.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth1nop2.Text) & "'" &
                        " ,'" & .cChr(txth1nop3.Text) & "'" &
                        " ,'" & .cChr(txth1nop4.Text) & "'" &
                        " ,'" & .cChr(txth1nop5.Text) & "'" &
                        " ,'" & .cChr(txth1nop6.Text) & "'" &
                        " ,'" & .cChr(txth1nop7.Text) & "'" &
                        " ,'" & .cChr(txth1nop8.Text) & "'" &
                        " ,'" & .cChr(txth1nop9.Text) & "'" &
                        " ,'" & .cChr(txth1nop10.Text) & "'" &
                        " ,'" & .cChr(txth1trf1.Text) & "'" &
                        " ,'" & .cChr(txth1trf2.Text) & "'" &
                        " ,'" & .cChr(txth1trf3.Text) & "'" &
                        " ,'" & .cChr(txth1trf4.Text) & "'" &
                        " ,'" & .cChr(txth1trf5.Text) & "'" &
                        " ,'" & .cChr(txth1trf6.Text) & "'" &
                        " ,'" & .cChr(txth1trf7.Text) & "'" &
                        " ,'" & .cChr(txth1trf8.Text) & "'" &
                        " ,'" & .cChr(txth1trf9.Text) & "'" &
                        " ,'" & .cChr(txth1trf10.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth1pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2nop1.Text) & "'" &
                        " ,'" & .cChr(txth2nop2.Text) & "'" &
                        " ,'" & .cChr(txth2nop3.Text) & "'" &
                        " ,'" & .cChr(txth2nop4.Text) & "'" &
                        " ,'" & .cChr(txth2nop5.Text) & "'" &
                        " ,'" & .cChr(txth2nop6.Text) & "'" &
                        " ,'" & .cChr(txth2nop7.Text) & "'" &
                        " ,'" & .cChr(txth2nop8.Text) & "'" &
                        " ,'" & .cChr(txth2nop9.Text) & "'" &
                        " ,'" & .cChr(txth2nop10.Text) & "'" &
                        " ,'" & .cChr(txth2nop16.Text) & "'" &
                        " ,'" & .cChr(txth2nop17.Text) & "'" &
                        " ,'" & .cChr(txth2nop18.Text) & "'" &
                        " ,'" & .cChr(txth2nop19.Text) & "'" &
                        " ,'" & .cChr(txth2nop20.Text) & "'" &
                        " ,'" & .cChr(txth2trf1.Text) & "'" &
                        " ,'" & .cChr(txth2trf2.Text) & "'" &
                        " ,'" & .cChr(txth2trf3.Text) & "'" &
                        " ,'" & .cChr(txth2trf4.Text) & "'" &
                        " ,'" & .cChr(txth2trf5.Text) & "'" &
                        " ,'" & .cChr(txth2trf6.Text) & "'" &
                        " ,'" & .cChr(txth2trf7.Text) & "'" &
                        " ,'" & .cChr(txth2trf8.Text) & "'" &
                        " ,'" & .cChr(txth2trf9.Text) & "'" &
                        " ,'" & .cChr(txth2trf10.Text) & "'" &
                        " ,'" & .cChr(txth2trf16.Text) & "'" &
                        " ,'" & .cChr(txth2trf17.Text) & "'" &
                        " ,'" & .cChr(txth2trf18.Text) & "'" &
                        " ,'" & .cChr(txth2trf19.Text) & "'" &
                        " ,'" & .cChr(txth2trf20.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg1.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg2.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg3.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg4.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg5.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg6.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg7.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg8.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg9.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg10.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg16.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg17.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg18.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg19.Text) & "'" &
                        " ,'" & .cChr(txth2pphptg20.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11a.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11b.Text) & "'" &
                        " ,'" & .cChr(txtpenghasil11c.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(txtssp.Text) & "'" &
                        " ,''" &
                        " ,'" & .cChr(txtbpppsl42.Text) & "'" &
                        " ,''" &
                        " ,''" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txth1nama.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub
    Private Sub calc()
        '-----Calc NOP-------
        Dim totalnop As Integer
        totalnop = cl.cNum(txth1nop1.Text) + cl.cNum(txth1nop2.Text) + cl.cNum(txth1nop3.Text) + cl.cNum(txth1nop4.Text) + cl.cNum(txth1nop5.Text) + cl.cNum(txth1nop6.Text) + cl.cNum(txth1nop7.Text) + cl.cNum(txth1nop8.Text) + cl.cNum(txth1nop9.Text) + cl.cNum(txth1nop10.Text) + cl.cNum(txth2nop1.Text) + cl.cNum(txth2nop2.Text) + cl.cNum(txth2nop3.Text) + cl.cNum(txth2nop4.Text) + cl.cNum(txth2nop5.Text) + cl.cNum(txth2nop6.Text) + cl.cNum(txth2nop7.Text) + cl.cNum(txth2nop8.Text) + cl.cNum(txth2nop9.Text) + cl.cNum(txth2nop10.Text) + cl.cNum(txth2nop16.Text) + cl.cNum(txth2nop17.Text) + cl.cNum(txth2nop18.Text) + cl.cNum(txth2nop19.Text)
        txth2nop20.Text = cl.cCur(totalnop)

        '-----Calc TRF-------
        Dim totaltrf As Integer
        totaltrf = cl.cNum(txth1trf1.Text) + cl.cNum(txth1trf2.Text) + cl.cNum(txth1trf3.Text) + cl.cNum(txth1trf4.Text) + cl.cNum(txth1trf5.Text) + cl.cNum(txth1trf6.Text) + cl.cNum(txth1trf7.Text) + cl.cNum(txth1trf8.Text) + cl.cNum(txth1trf9.Text) + cl.cNum(txth1trf10.Text) + cl.cNum(txth2trf1.Text) + cl.cNum(txth2trf2.Text) + cl.cNum(txth2trf3.Text) + cl.cNum(txth2trf4.Text) + cl.cNum(txth2trf5.Text) + cl.cNum(txth2trf6.Text) + cl.cNum(txth2trf7.Text) + cl.cNum(txth2trf8.Text) + cl.cNum(txth2trf9.Text) + cl.cNum(txth2trf10.Text) + cl.cNum(txth2trf16.Text) + cl.cNum(txth2trf17.Text) + cl.cNum(txth2trf18.Text) + cl.cNum(txth2trf19.Text)
        txth2trf20.Text = cl.cCur(totaltrf)

        '-----Calc PPH-------
        Dim totalpph As Integer
        totalpph = cl.cNum(txth1pphptg1.Text) + cl.cNum(txth1pphptg2.Text) + cl.cNum(txth1pphptg3.Text) + cl.cNum(txth1pphptg4.Text) + cl.cNum(txth1pphptg5.Text) + cl.cNum(txth1pphptg6.Text) + cl.cNum(txth1pphptg7.Text) + cl.cNum(txth1pphptg8.Text) + cl.cNum(txth1pphptg9.Text) + cl.cNum(txth1pphptg10.Text) + cl.cNum(txth2pphptg1.Text) + cl.cNum(txth2pphptg2.Text) + cl.cNum(txth2pphptg3.Text) + cl.cNum(txth2pphptg4.Text) + cl.cNum(txth2pphptg5.Text) + cl.cNum(txth2pphptg6.Text) + cl.cNum(txth2pphptg7.Text) + cl.cNum(txth2pphptg8.Text) + cl.cNum(txth2pphptg9.Text) + cl.cNum(txth2pphptg10.Text) + cl.cNum(txth2pphptg16.Text) + cl.cNum(txth2trf17.Text) + cl.cNum(txth2pphptg18.Text) + cl.cNum(txth2pphptg19.Text)
        txth2pphptg20.Text = cl.cCur(totalpph)
        terbilang()
    End Sub
    Dim t As New Terbilang

    Private Sub txth2nop11_TextChanged(sender As Object, e As EventArgs) Handles txth2nop16.TextChanged
        calc()
    End Sub

    Private Sub txth2nop12_TextChanged(sender As Object, e As EventArgs) Handles txth2nop17.TextChanged
        calc()
    End Sub

    Private Sub txth2nop13_TextChanged(sender As Object, e As EventArgs) Handles txth2nop18.TextChanged
        calc()
    End Sub

    Private Sub txth2nop14_TextChanged(sender As Object, e As EventArgs) Handles txth2nop19.TextChanged
        calc()
    End Sub

    Private Sub txth2trf11_TextChanged(sender As Object, e As EventArgs) Handles txth2trf16.TextChanged
        calc()
    End Sub

    Private Sub txth2trf12_TextChanged(sender As Object, e As EventArgs) Handles txth2trf17.TextChanged
        calc()
    End Sub

    Private Sub txth2trf13_TextChanged(sender As Object, e As EventArgs) Handles txth2trf18.TextChanged
        calc()
    End Sub

    Private Sub txth2trf14_TextChanged(sender As Object, e As EventArgs) Handles txth2trf19.TextChanged
        calc()
    End Sub

    Private Sub txth2pphptg11_TextChanged(sender As Object, e As EventArgs) Handles txth2pphptg16.TextChanged
        calc()
    End Sub

    Private Sub txth2pphptg12_TextChanged(sender As Object, e As EventArgs) Handles txth2pphptg17.TextChanged
        calc()
    End Sub

    Private Sub txth2pphptg13_TextChanged(sender As Object, e As EventArgs) Handles txth2pphptg18.TextChanged
        calc()
    End Sub

    Private Sub txth2pphptg14_TextChanged(sender As Object, e As EventArgs) Handles txth2pphptg19.TextChanged
        calc()
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub txth1nop1_TextChanged(sender As Object, e As EventArgs) Handles txth1nop1.TextChanged

    End Sub

    Sub terbilang()
        Dim total As Decimal
        Dim currency As String = " Rupiah"
        total = cl.cNum(txth2pphptg20.Text)

        If cl.cNum(txth2pphptg20.Text) > 0 Then
            t.Text = cl.cNum(txth2pphptg20.Text)
        End If
        txth2terbilang.Text = t.Text & currency
    End Sub
End Class