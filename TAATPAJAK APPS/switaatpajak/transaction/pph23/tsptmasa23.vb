Public Class tsptmasa23
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
        End If
    End Sub
    Private Sub readdata()
        '-----------DIVIDEN ---------------
        txtjpb1.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-101-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph1.Text = cl.cCur(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-101-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'") - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-101-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END DIVIDEN---------------
        '-----------Bunga ---------------
        txtjpb2.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-102-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph2.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-102-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-102-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Bunga---------------
        '-----------Royalti ---------------
        txtjpb3.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-103-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph3.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-103-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-103-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Royalti---------------
        '-----------Hadiah ---------------
        txtjpb4.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-100-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph4.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-100-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-100-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Hadiah---------------
        '-----------Sewa ---------------
        txtjpb5.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-100-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph5.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-100-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-100-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Sewa---------------
        '-----------Jasa ---------------
        txtjpb6.Text = cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-104-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")
        txtpph6.Text = cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-104-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")
        '-----------END Jasa---------------
        '-----------Jteknik ---------------
        txtjpb7.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-104-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph7.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-104-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-104-01'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Jteknik---------------
        '-----------Jmanaj ---------------
        txtjpb8.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-104-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph8.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-104-02'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        'txtpph8.Text = cl.cCur(cl.cNum(cl.readData("select sum(pphdipotong) from tpph23 where kodeobj = '24-104-02'" &
        '                           "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-104-02'" &
        '                           "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Jmanaj---------------
        '-----------Jkonsul ---------------
        txtjpb9.Text = cl.cCur(cl.readData("select IFNULL(sum(jmlbruto),0) from tpph23 where kodeobj = '24-104-03'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        txtpph9.Text = cl.cCur(cl.cNum(cl.readData("select IFNULL(sum(pphdipotong),0) from tpph23 where kodeobj = '24-104-03'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")) - cl.cNum(cl.readData("select IFNULL(SUM(pph),0) from tinputssppbk23 where kdpjk = '24-104-03'" &
                                   "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'")))
        '-----------END Jkonsul---------------
        '-----------Jlain ------
        '----- Txtlain line 1-----------
        txtkap7.Text = cl.cChr(cl.readData("select IFNULL(kodeobj,0) total from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 1"))

        txtlain1.Text = cl.cChr(cl.readData("select uraian from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 1"))

        txtjpb10.Text = cl.cCur(cl.readData("select IFNULL(jmlbruto,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 1"))

        txtpph10.Text = cl.cCur(cl.readData("select IFNULL(pphdipotong,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 1"))
        '----- END Txtlain line 1-----------
        '----- Txtlain line 2-----------
        txtkap8.Text = cl.cChr(cl.readData("select IFNULL(kodeobj,0) total from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 2"))

        txtlain2.Text = cl.cChr(cl.readData("select uraian from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 2"))

        txtjpb11.Text = cl.cCur(cl.readData("select IFNULL(jmlbruto,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 2"))

        txtpph11.Text = cl.cCur(cl.readData("select IFNULL(pphdipotong,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 2"))
        '----- END Txtlain line 2-----------
        '----- Txtlain line 3 -----------
        txtkap9.Text = cl.cChr(cl.readData("select IFNULL(kodeobj,0) total from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 3"))

        txtlain3.Text = cl.cChr(cl.readData("select uraian from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 3"))

        txtjpb12.Text = cl.cCur(cl.readData("select IFNULL(jmlbruto,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 3"))

        txtpph12.Text = cl.cCur(cl.readData("select IFNULL(pphdipotong,0) from (
                                            SELECT row_number() over (
                                                   order by kodeobj asc) 'linenum', T0.* FROM tpph23 T0 INNER JOIN mobjkpjk T1 ON T0.kodeobj = T1.kode
                                            WHERE T0.stat = 1 AND T1.stat = 1
                                            AND T1.kode NOT IN ('24-101-01','24-102-02','24-103-03','24-103-01','24-100-01','24-101-02','24-104-01','24-104-02','24-104-03')
                                            AND T0.masapjk = '" & masapjk & "' AND T0.thnpjk = '" & thnpjk & "') TJOIN
                                            WHERE TJOIN.linenum = 3"))
        '----- END Txtlain line 3 -----------
        'txtjpb10.Text = cl.cCur(cl.readData("SELECT SUM(pphdipotong) FROM tpph23 TA INNER JOIN mpasal23 TB ON TA.trf = TB.tariff " &
        '                           "WHERE TA.stat = 1 AND TB.stat = 1 AND TB.dsc = 'Jlain'" &
        '                           "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        'txtpph10.Text = cl.cCur(cl.readData("SELECT SUM(pphdipotong) FROM tpph23 TA INNER JOIN mpasal23 TB ON TA.trf = TB.tariff " &
        '                           "WHERE TA.stat = 1 AND TB.stat = 1 AND TB.dsc = 'Jlain'" &
        '                           "AND masapjk = '" & masapjk & "' and thnpjk = '" & thnpjk & "'"))
        '-----------END Jlain---------------
    End Sub
    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            getmth()
            readdata()
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
        Me.Select() : txtjpb1.Select()
    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub
    'Private Sub loaddata()
    '    txtjpb1.Text = cl.readData("SELECT SUM(IFNULL(jmlbruto,0)) FROM tpph23 TA WHERE TA.stat = 1 " &
    '                                 " AND MONTH(tanggal) = '" & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "' ")
    '    txtpph1.Text = cl.readData("SELECT SUM(IFNULL(pphptg,0)) FROM tbuktiptgfinal TA INNER JOIN tbuktiptgfinald TB ON TA.id = TB.idh " &
    '                                     " WHERE TA.stat = 1 And TB.stat = 1" &
    '                                     " AND MONTH(tanggal) = '" & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "' ")
    'End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtjpb1.Select()
    End Sub
    Private Sub clearData()
        txtjpb1.Text = 0
        txtjpb2.Text = 0
        txtjpb3.Text = 0
        txtjpb4.Text = 0
        txtjpb5.Text = 0
        txtjpb6.Text = 0
        txtjpb7.Text = 0
        txtjpb8.Text = 0
        txtjpb9.Text = 0
        txtjpb10.Text = 0
        txtjpb11.Text = 0
        txtjpb12.Text = 0
        txtjpb13.Text = 0
        txtjpbjml.Text = 0
        txtpph1.Text = 0
        txtpph2.Text = 0
        txtpph3.Text = 0
        txtpph4.Text = 0
        txtpph5.Text = 0
        txtpph6.Text = 0
        txtpph7.Text = 0
        txtpph8.Text = 0
        txtpph9.Text = 0
        txtpph10.Text = 0
        txtpph11.Text = 0
        txtpph12.Text = 0
        txtpph13.Text = 0
        txtpphjml.Text = 0
        txtlain1.Text = 0
        txtlain2.Text = 0
        txtlain3.Text = 0
        txtlain4.Text = 0
        txtkap7.Text = 0
        txtterbilang.Text = 0
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtjpb1, "Jumlah Bruto Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tsptmasa23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'

                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtjpb1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stsptmasa23 (" &
                        " '" & .cNum(txtjpb1.Text) & "'" &
                        " , '" & .cNum(txtjpb2.Text) & "'" &
                        " , '" & .cNum(txtjpb3.Text) & "'" &
                        " , '" & .cNum(txtjpb4.Text) & "'" &
                        " , '" & .cNum(txtjpb5.Text) & "'" &
                        " , '" & .cNum(txtjpb6.Text) & "'" &
                        " , '" & .cNum(txtjpb7.Text) & "'" &
                        " , '" & .cNum(txtjpb8.Text) & "'" &
                        " , '" & .cNum(txtjpb9.Text) & "'" &
                        " , '" & .cNum(txtjpb10.Text) & "'" &
                        " , '" & .cNum(txtjpb11.Text) & "'" &
                        " , '" & .cNum(txtjpb12.Text) & "'" &
                        " , '" & .cNum(txtjpb13.Text) & "'" &
                        " , '" & .cNum(txtjpbjml.Text) & "'" &
                        " , '" & .cNum(txtpph1.Text) & "'" &
                        " , '" & .cNum(txtpph2.Text) & "'" &
                        " , '" & .cNum(txtpph3.Text) & "'" &
                        " , '" & .cNum(txtpph4.Text) & "'" &
                        " , '" & .cNum(txtpph5.Text) & "'" &
                        " , '" & .cNum(txtpph6.Text) & "'" &
                        " , '" & .cNum(txtpph7.Text) & "'" &
                        " , '" & .cNum(txtpph8.Text) & "'" &
                        " , '" & .cNum(txtpph9.Text) & "'" &
                        " , '" & .cNum(txtpph10.Text) & "'" &
                        " , '" & .cNum(txtpph11.Text) & "'" &
                        " , '" & .cNum(txtpph12.Text) & "'" &
                        " , '" & .cNum(txtpph13.Text) & "'" &
                        " , '" & .cNum(txtpphjml.Text) & "'" &
                        " , '" & .cChr(txtlain1.Text) & "'" &
                        " , '" & .cChr(txtlain2.Text) & "'" &
                        " , '" & .cChr(txtlain3.Text) & "'" &
                        " , '" & .cChr(txtlain4.Text) & "'" &
                        " , '" & .cChr(txtkap7.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtjpb1.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tsptmasa23'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtjpb1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stsptmasa23 (" &
                        " '" & .cNum(txtjpb1.Text) & "'" &
                        " , '" & .cNum(txtjpb2.Text) & "'" &
                        " , '" & .cNum(txtjpb3.Text) & "'" &
                        " , '" & .cNum(txtjpb4.Text) & "'" &
                        " , '" & .cNum(txtjpb5.Text) & "'" &
                        " , '" & .cNum(txtjpb6.Text) & "'" &
                        " , '" & .cNum(txtjpb7.Text) & "'" &
                        " , '" & .cNum(txtjpb8.Text) & "'" &
                        " , '" & .cNum(txtjpb9.Text) & "'" &
                        " , '" & .cNum(txtjpb10.Text) & "'" &
                        " , '" & .cNum(txtjpb11.Text) & "'" &
                        " , '" & .cNum(txtjpb12.Text) & "'" &
                        " , '" & .cNum(txtjpb13.Text) & "'" &
                        " , '" & .cNum(txtjpbjml.Text) & "'" &
                        " , '" & .cNum(txtpph1.Text) & "'" &
                        " , '" & .cNum(txtpph2.Text) & "'" &
                        " , '" & .cNum(txtpph3.Text) & "'" &
                        " , '" & .cNum(txtpph4.Text) & "'" &
                        " , '" & .cNum(txtpph5.Text) & "'" &
                        " , '" & .cNum(txtpph6.Text) & "'" &
                        " , '" & .cNum(txtpph7.Text) & "'" &
                        " , '" & .cNum(txtpph8.Text) & "'" &
                        " , '" & .cNum(txtpph9.Text) & "'" &
                        " , '" & .cNum(txtpph10.Text) & "'" &
                        " , '" & .cNum(txtpph11.Text) & "'" &
                        " , '" & .cNum(txtpph12.Text) & "'" &
                        " , '" & .cNum(txtpph13.Text) & "'" &
                        " , '" & .cNum(txtpphjml.Text) & "'" &
                        " , '" & .cChr(txtlain1.Text) & "'" &
                        " , '" & .cChr(txtlain2.Text) & "'" &
                        " , '" & .cChr(txtlain3.Text) & "'" &
                        " , '" & .cChr(txtlain4.Text) & "'" &
                        " , '" & .cChr(txtkap7.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                       " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtjpb1.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tsptmasa23 TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("jpb1").Visible = True : .Columns("jpb1").HeaderText = "Jumlah Pengasilan Bruto"
            .Columns("terbilang").Visible = True : .Columns("terbilang").HeaderText = "Terbilang"

        End With
        a.loadStatusTempForm(Me, Me.txtjpb1, "[tsptmasa23]tsptmasa23")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tsptmasa23
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tbktbuku42'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtjpb1.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stsptmasa23 (" &
                        " '" & .cNum(txtjpb1.Text) & "'" &
                        " , '" & .cNum(txtjpb2.Text) & "'" &
                        " , '" & .cNum(txtjpb3.Text) & "'" &
                        " , '" & .cNum(txtjpb4.Text) & "'" &
                        " , '" & .cNum(txtjpb5.Text) & "'" &
                        " , '" & .cNum(txtjpb6.Text) & "'" &
                        " , '" & .cNum(txtjpb7.Text) & "'" &
                        " , '" & .cNum(txtjpb8.Text) & "'" &
                        " , '" & .cNum(txtjpb9.Text) & "'" &
                        " , '" & .cNum(txtjpb10.Text) & "'" &
                        " , '" & .cNum(txtjpb11.Text) & "'" &
                        " , '" & .cNum(txtjpb12.Text) & "'" &
                        " , '" & .cNum(txtjpb13.Text) & "'" &
                        " , '" & .cNum(txtjpbjml.Text) & "'" &
                        " , '" & .cNum(txtpph1.Text) & "'" &
                        " , '" & .cNum(txtpph2.Text) & "'" &
                        " , '" & .cNum(txtpph3.Text) & "'" &
                        " , '" & .cNum(txtpph4.Text) & "'" &
                        " , '" & .cNum(txtpph5.Text) & "'" &
                        " , '" & .cNum(txtpph6.Text) & "'" &
                        " , '" & .cNum(txtpph7.Text) & "'" &
                        " , '" & .cNum(txtpph8.Text) & "'" &
                        " , '" & .cNum(txtpph9.Text) & "'" &
                        " , '" & .cNum(txtpph10.Text) & "'" &
                        " , '" & .cNum(txtpph11.Text) & "'" &
                        " , '" & .cNum(txtpph12.Text) & "'" &
                        " , '" & .cNum(txtpph13.Text) & "'" &
                        " , '" & .cNum(txtpphjml.Text) & "'" &
                        " , '" & .cChr(txtlain1.Text) & "'" &
                        " , '" & .cChr(txtlain2.Text) & "'" &
                        " , '" & .cChr(txtlain3.Text) & "'" &
                        " , '" & .cChr(txtlain4.Text) & "'" &
                        " , '" & .cChr(txtkap7.Text) & "'" &
                        " , '" & .cChr(txtterbilang.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtjpb1.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub
    Private Sub calc()
        Dim total As Decimal
        total = cl.cNum(txtpph1.Text) + cl.cNum(txtpph2.Text) + cl.cNum(txtpph3.Text) + cl.cNum(txtpph4.Text) +
            cl.cNum(txtpph5.Text) + cl.cNum(txtpph6.Text) + cl.cNum(txtpph7.Text) + cl.cNum(txtpph8.Text) + cl.cNum(txtpph9.Text) _
            + cl.cNum(txtpph10.Text) + cl.cNum(txtpph11.Text) + cl.cNum(txtpph12.Text) + cl.cNum(txtpph13.Text)
        txtpphjml.Text = cl.cCur(total)
        Dim totbrt As Decimal
        totbrt = cl.cNum(txtjpb1.Text) + cl.cNum(txtjpb2.Text) + cl.cNum(txtjpb3.Text) + cl.cNum(txtjpb4.Text) + cl.cNum(txtjpb5.Text) +
            cl.cNum(txtjpb6.Text) + cl.cNum(txtjpb7.Text) + cl.cNum(txtjpb8.Text) + cl.cNum(txtjpb9.Text) + cl.cNum(txtjpb10.Text) +
            cl.cNum(txtjpb11.Text) + cl.cNum(txtjpb12.Text) + cl.cNum(txtjpb13.Text)
        txtjpbjml.Text = cl.cCur(totbrt)
        terbilang()
    End Sub
    Dim t As New Terbilang
    Sub terbilang()
        Dim total As Decimal
        Dim currency As String = " Rupiah"
        total = cl.cNum(txtpphjml.Text)

        If cl.cNum(txtpphjml.Text) > 0 Then
            t.Text = cl.cNum(txtpphjml.Text)
        End If
        txtterbilang.Text = t.Text & currency
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
End Class