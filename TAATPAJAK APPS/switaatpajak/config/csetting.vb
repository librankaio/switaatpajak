Imports System.IO
Imports System.Drawing.Printing
Public Class csetting
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
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F4) Then
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub clearData()
        cmbjeniscompany.SelectedIndex = -1
        txtcompany.Text = ""
        txtowner.Text = ""
        txtalamat.Text = ""
        txtphone.Text = ""
        txtfax.Text = ""
        txtNPWP.Text = ""
        txtcompanyname.Text = ""

        chpos.Checked = False
        chapproval.Checked = False
        chcompname.Checked = False
    End Sub

    Private Sub loadData()
        With cl
            cmbjeniscompany.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'jeniscompany'"))
            txtcompany.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'company'"))
            txtowner.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'owner'"))
            txtalamat.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'alamat'"))
            txtphone.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'phone'"))
            txtfax.Text = .cchr(.readData("SELECT strvl FROM csetting WHERE name = 'fax'"))
            txtNPWP.Text = .cChr(.readData("SELECT strvl FROM csetting WHERE name = 'npwp'"))
            txtcompanyname.Text = .cChr(.readData("SELECT strvl FROM csetting WHERE name = 'companyname'"))

            If .cChr(.readData("SELECT strvl FROM csetting WHERE name = 'POS'")) = "Y" Then
                chpos.Checked = True
            Else
                chpos.Checked = False
            End If

            If .cChr(.readData("SELECT strvl FROM csetting WHERE name = 'Approval'")) = "Y" Then
                chapproval.Checked = True
            Else
                chapproval.Checked = False
            End If

            If .cChr(.readData("SELECT strvl FROM csetting WHERE name = 'compname'")) = "Y" Then
                chcompname.Checked = True
            Else
                chcompname.Checked = False
            End If
        End With
    End Sub

    Private Sub csetting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub


    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        With cl
            '------ start validasi
            'If .ValidateTxtNull(txtcompany, "Nama Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .ValidateTxtNull(txtalamat, "Alamat Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .validatetxtnull(txtowner, "Owner Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            '' If validatetxtnull(txtphone, "Telpon Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            ''If validatetxtnull(txtfax, "Fax Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If
            'If .ValidateTxtNull(txtNPWP, "NPWP Perusahaan harus diisi !", "Warning Information") = 1 Then : Exit Sub : End If

            Dim pos As String
            Dim compname As String
            Dim approval As String

            If chpos.Checked = True Then
                pos = "Y"
            Else
                pos = "N"
            End If

            If chcompname.Checked = True Then
                compname = "Y"
            Else
                compname = "N"
            End If

            If chapproval.Checked = True Then
                approval = "Y"
            Else
                approval = "N"
            End If

            If txtlogo.Text <> "" And txtlogo.Text <> .readData("SELECT strvl FROM csetting WHERE name = 'logolocation'") Then
                PictureBox1.Image = Nothing
                copyDir(txtlogo.Text, dirimgfolder, "logo")
            ElseIf txtlogo.Text = "" Then
                Dim tempPhoto As String = cl.readData(
                    "SELECT strvl FROM csetting WHERE name = 'logolocation'")
                If File.Exists(dirimgfolder & "\" & tempPhoto) Then
                    File.Delete(dirimgfolder & "\" & tempPhoto)
                End If
            End If

            Dim photo As String = ""
            If txtlogo.Text <> "" Then : photo = "logo" & Path.GetExtension(txtlogo.Text)
            Else : photo = "" : End If


            Dim tny As Integer
            tny = .msgYesNo("Update setting umum ?", "Information")
            If tny = vbYes Then
                .openTrans()

                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(cmbjeniscompany.Text) & "' WHERE name = 'jeniscompany'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(txtcompany.Text) & "' WHERE name = 'company'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(txtowner.Text) & "' WHERE name = 'owner'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(txtalamat.Text) & "' WHERE name = 'alamat'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(txtphone.Text) & "' WHERE name = 'phone'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cchr(txtfax.Text) & "' WHERE name = 'fax'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & .cChr(txtNPWP.Text) & "' WHERE name = 'npwp'")

                .execCmdTrans("UPDATE csetting SET strvl = '" & .cChr(photo) & "' WHERE name = 'logolocation'")

                .execCmdTrans("UPDATE csetting SET strvl = '" & pos & "' WHERE name = 'POS'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & approval & "' WHERE name = 'Approval'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & compname & "' WHERE name = 'compname'")
                .execCmdTrans("UPDATE csetting SET strvl = '" & txtcompanyname.Text & "' WHERE name = 'companyname'")

                .closeTrans(btnsave)

                If .sCloseTrans = 1 Then
                    .msgInform("Sukses update setting umum !", "Informasi")
                    .msgInform("Sistem akan lakukan otomatis restart !", "Informasi")
                    For Each child As Form In Me.MdiChildren
                        child.Close()
                    Next child
                    Me.Dispose()
                    cekform(login, "NEW", Me)
                End If
            End If

        End With
    End Sub
    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Dim frm As New csetting
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btnbrowsecoa_Click(sender As Object, e As EventArgs) Handles btnbrowsecoa.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.InitialDirectory = "C:"
        openFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim img = Image.FromFile(openFileDialog1.FileName)
            '------FILE SIZE DOES NOT MATTER----------'
            'If New FileInfo(openFileDialog1.FileName).Length > 2000 * 1024 Then
            '    cl.msgError("Ukuran File Photo tidak bisa melebihi 2 Mb !", "Upload Photo Gagal")
            '    Exit Sub
            'ElseIf Image.FromFile(openFileDialog1.FileName).Size.Width > 3024 OrElse
            '    Image.FromFile(openFileDialog1.FileName).Size.Height > 3024 Then
            '    cl.msgError("Ukuran Photo melebihi 2056 x 2056 pixel !", "Upload Photo Gagal")
            '    Exit Sub
            'End If

            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    txtlogo.Text = openFileDialog1.FileName
                    Dim fs As System.IO.FileStream
                    fs = New System.IO.FileStream(openFileDialog1.FileName,
                         IO.FileMode.Open, IO.FileAccess.Read)
                    PictureBox1.Visible = True
                    PictureBox1.Image = System.Drawing.Image.FromStream(fs)
                    fs.Close()
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file JPEG/PNG from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open. 
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs)

    End Sub


End Class