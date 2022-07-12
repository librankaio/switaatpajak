Imports MySql.Data.MySqlClient
Public Class login



    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If cmbdatabase.SelectedIndex = -1 Then
            cl.msgError("Mohon untuk pilih database terlebih dahulu !", "Informasi")
            Exit Sub
        End If

        Dim pass As String = cl.readData(
           " SELECT pass FROM cusr " &
           " WHERE name = '" & txtusr.Text & "' AND stat = 1")
        '   MsgBox(pass)

        '-------------SETTING CONFIG DATABASE CHANGED
        Dim listsettemp As New List(Of String)
        Using reader As System.IO.StreamReader = New System.IO.StreamReader(cl.dirSettingAppF, True)
            Dim strLine As String = reader.ReadLine
            Do While Not strLine Is Nothing
                listsettemp.Add(Decrypt(strLine))
                strLine = reader.ReadLine
            Loop
            reader.Close()
        End Using

        If System.IO.File.Exists(cl.dirSettingAppF) = True Then
            System.IO.File.Delete(cl.dirSettingAppF)
        ElseIf System.IO.File.Exists(cl.dirSettingAppF) = False Then
            System.IO.Directory.CreateDirectory("C:\SWITP")
        End If

        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(cl.dirSettingAppF, True)
            writer.WriteLine(Encrypt(listsettemp.Item(0)))
            writer.WriteLine(Encrypt(listsettemp.Item(1)))
            writer.WriteLine(Encrypt(listsettemp.Item(2)))
            writer.WriteLine(Encrypt(listsettemp.Item(3)))
            writer.WriteLine(Encrypt(cmbdatabase.Text))
        End Using
        '-------------END SETTING DATABASE CHANGED

        Dim vServer As String = listsettemp.Item(0)
        Dim vDatabase As String = cmbdatabase.Text

        '   id_mbranch = listSet.Item(5)


        'Dim vServer As String = "localhost"
        'Dim vDatabase As String = "gisnew"

        If cl.VerifyMd5Hash(txtpass.Text, pass) = True Then
            idusr = cl.readData(
            " SELECT id FROM cusr " &
            " WHERE name = '" & txtusr.Text & "'  AND stat = 1")

            checksadmin = cl.readData(
            " SELECT sadmin FROM cusr " &
            " WHERE name = '" & txtusr.Text & "'  AND stat = 1")

            Dim namausr As String = cl.readData(
            " SELECT name FROM cusr " &
            " WHERE name = '" & txtusr.Text & "'  AND stat = 1")

            Dim actlog As String
            Dim logname As String
            Dim logid As Integer
            Dim logcode As String
            'logname = txtusr.Text


            logid = cl.readData(" SELECT id FROM cusr " &
            " WHERE name = '" & txtusr.Text & "'  AND stat = 1")
            logcode = cl.readData(" SELECT code FROM cusr " &
            " WHERE name = '" & txtusr.Text & "'  AND stat = 1")
            logname = cl.readData(" SELECT name FROM cusr " &
            " WHERE id = '" & logid & "'  AND stat = 1")

            actlog = "Login"

            cl.openTrans()

            cl.execCmdTrans("INSERT into huserlog (id_cusr, code_cusr, name_cusr, act, usin) VALUES " &
                            " ('" & logid & "','" & logcode & "','" & txtusr.Text & "','" & actlog & "','" & idusr & "')")

            cl.closeTrans(btnlogin)
            Me.Dispose()

            'Data log to logout
            menuutama.logname = logname
            menuutama.logid = logid
            menuutama.logcode = logcode

            menuutama.Text = "Menu Utama :: " & cl.readData("SELECT strvl FROM csetting WHERE name = 'company'")
            menuutama.tsStatus3.Text =
                "Selamat Datang : " & cl.readData("SELECT npwp FROM mprofile where id = 1") & " : " & cl.readData("SELECT nama FROM mprofile where id = 1") & " | "
            menuutama.tsStatus.Text =
                "Anda login sebagai : " & namausr & ", Server : " & vServer & ", Database : " & vDatabase
            menuutama.muvisfalse()
            menuutama.muvistrue(idusr)

            If cl.readData("SELECT showmenu FROM cusr WHERE id = '" & idusr & "'") = "N" Then
                Exit Sub
            End If

            'Dim frm As New navprogram
            'frm.MdiParent = menuutama
            'frm.Show()

            'frm.SetBounds(0, 0, frm.Width, menuutama.Height - 80)

            '-- ADDED BY HANS 05/07/2021
            menuutama.tpph21mi.Enabled = False
            menuutama.tpph23mi.Enabled = False
            menuutama.tpph42mi.Enabled = False

            'If cl.readData("SELECT strvl FROM csetting WHERE name = 'Approval'") = "Y" And
            '    cl.readData("SELECT canopen FROM cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'approver'") = "Y" Then
            '    '--REMINDER SALES ORDER YANG BELUM DI APPROVE
            '    Dim cbirthdaymember As Integer = 0
            '    cbirthdaymember = cl.cNum(cl.readData(
            '    " SELECT COUNT(T0.id) FROM vtransapprove T0 " &
            '    " WHERE IFNULL(T0.approved,'N') = 'N'"))

            '    If cbirthdaymember > 0 Then
            '        'cl.msgInform("Ada invoice yang masih outstanding !", "Informasi Sistem")

            '        Dim a As New creminder
            '        Dim sqlStr As String =
            '        " SELECT T0.* FROM vtransapprove T0  " &
            '        "  " &
            '    " WHERE IFNULL(T0.approved,'N') = 'N'"

            '        With a.dgview : .DataSource = cl.table(sqlStr)
            '            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            '            .Columns("no").Visible = True : .Columns("no").HeaderText = "No. Dokumen"
            '            .Columns("tdt").Visible = True : .Columns("tdt").HeaderText = "Tanggal"
            '            .Columns("name_mcust").Visible = True : .Columns("name_mcust").HeaderText = "Customer"
            '            .Columns("grdtotal").Visible = True : .Columns("grdtotal").HeaderText = "Total" : .Columns("grdtotal").DefaultCellStyle.Format = "n2"
            '            .Columns("jenis").Visible = True : .Columns("jenis").HeaderText = "Jenis"
            '        End With
            '        a.loadStatusTempForm(Me, Me.btnlogin, Me.btnlogin, "[popupbirthday]mmember")
            '        a.loadSQLSearch(sqlStr, 1)
            '        a.Text = ""
            '        cekform(a, "SEARCH", Me)

            '        Dim totalqty As Decimal = 0
            '        For i As Integer = 0 To a.dgview.Rows.Count - 1
            '            totalqty += cl.cNum(a.dgview.Rows(i).Cells("grdtotal").Value)
            '        Next

            '        a.txttotal.Text = cl.cCur(totalqty)
            '        a.chfinish.Checked = True
            '    End If

            'End If
            'Dim cekWarning As Integer = cl.readData(
            '"SELECT COUNT(*) FROM cusrpriv T1 INNER JOIN capp T2 ON T1.id_capp = T2.id " & _
            '" WHERE T1.id_cusr = '" & idusr & "' AND T1.priv = 1 AND T2.code = 'vtransduedt' ")

            'If cekWarning = 1 Then
            '    cekform(vtransduedt, "NEW", Me)
            'End If

        Else
                cl.msgError("Kata Sandi atau User Name ada yang salah, silahkan kontak admin!", "Gagal Login")
            Exit Sub
        End If

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menuutama.muvisfalse()
        menuutama.tsStatus.Text = ""

        Dim listSet As New List(Of String)
        Using reader As System.IO.StreamReader = New System.IO.StreamReader(cl.dirSettingAppF, True)
            Dim strLine As String = reader.ReadLine
            Do While Not strLine Is Nothing
                listSet.Add(Decrypt(strLine))
                strLine = reader.ReadLine
            Loop
            reader.Close()
        End Using

        Dim conn As New MySqlConnection
        Dim msstr As String =
          " Server=" & listSet.Item(0) & "; " &
          " Port=" & listSet.Item(1) & "; " &
          " Uid=" & listSet.Item(2) & "; " &
          " Pwd=" & listSet.Item(3) & ";"
        conn = New MySqlConnection(msstr)

        conn.Open()

        Dim dtTbl As New DataTable
        Dim myAdapter As New MySqlDataAdapter
        myAdapter = New MySqlDataAdapter("SHOW DATABASES", msstr)
        myAdapter.Fill(dtTbl)

        Dim myStatus As Integer = 0

        For i As Integer = 0 To dtTbl.Rows.Count - 1
            Dim dtTbl2 As New DataTable
            myAdapter = New MySqlDataAdapter("SHOW TABLES FROM " & dtTbl.Rows(i).Item("Database"), msstr)
            myAdapter.Fill(dtTbl2)

            myStatus = 0
            For y As Integer = 0 To dtTbl2.Rows.Count - 1
                Dim tempTbl As String = cl.cChr(dtTbl2.Rows(y).Item(0))
                If UCase(tempTbl) = "SWISYTAATPAJAK" Then
                    myStatus = 1
                End If
            Next

            If myStatus = 1 Then
                cmbdatabase.Items.Add(dtTbl.Rows(i).Item("Database"))
            End If
        Next

        myAdapter.Dispose()
        myAdapter = Nothing

        conn.Close()

        cmbdatabase.Text = listSet.Item(4).Replace(" ", "")

        ''load logo here
        'If System.IO.File.Exists(dirImgFilePath & "\" & cl.cChr(cl.readData("SELECT strvl FROM csetting WHERE name = 'logolocation'"))) = True Then
        '    Dim fs As System.IO.FileStream
        '    fs = New System.IO.FileStream(dirImgFilePath & "\" & cl.cChr(cl.readData("SELECT strvl FROM csetting WHERE name = 'logolocation'")),
        '         IO.FileMode.Open, IO.FileAccess.Read)
        '    PictureBox1.Image = System.Drawing.Image.FromStream(fs)
        '    fs.Dispose()
        '    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'Else : PictureBox1.Image = Nothing
        'End If
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
        menuutama.MenuStrip.Visible = True

        menuutama.filetsmi.Visible = True
        menuutama.loginmi.Visible = True
        menuutama.logoutmi.Visible = False

        menuutama.helptsmi.Visible = True
        menuutama.aboutusmi.Visible = True

    End Sub
End Class