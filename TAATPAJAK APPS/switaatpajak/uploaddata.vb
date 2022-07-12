Imports System.IO
Public Class uploaddata
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            Me.Dispose()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub uploaddata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbtipefile.SelectedIndex = 0
        '    txtbrowse.Text = "C:\Dropbox\Swifect Share\GalaxyInformationSystem\openingbalance.xlsx"
    End Sub
    Private Sub convertToSQL(ByVal tableName As String)
        Try
            Dim dtTemp As New DataTable
            Dim tempField As String = ""
            Dim tempFieldHeader As String = ""
            Dim tempFieldDetail As String = ""

            If cmbtipefile.Text = "NEGARA" Then
                dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [NEGARA$]")
            ElseIf cmbtipefile.Text = "KPP" Then
                dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [KPP$]")
            ElseIf cmbtipefile.Text = "OBJEK PAJAK" Then
                dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [OJP$]")
            ElseIf cmbtipefile.Text = "SSP" Then
                dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [SSP$]")
            ElseIf cmbtipefile.Text = "GOLONGAN" Then
                dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [GP$]")
            End If

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 10000
            Dim progressCounter As Integer = 10000 / dtTemp.Rows.Count

            'dgview.DataSource = dtTemp : Exit Sub

            For i As Integer = 0 To dtTemp.Rows.Count - 1
                'If cl.cchr(dtTemp.Rows(i).Item(1)) = "" Then
                '    Continue For
                'End If

                If ProgressBar1.Value < ProgressBar1.Maximum And
                    ProgressBar1.Value + progressCounter < ProgressBar1.Maximum Then
                    ProgressBar1.Value += progressCounter
                End If

                tempField = ""
                tempFieldHeader = ""
                tempFieldDetail = ""

                If tableName = "mnegara" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (code, name, p3b) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                ElseIf tableName = "mkpp" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (kode, nama, alamat) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                ElseIf tableName = "mobjkpjk" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (jnspjk, kode, objkpjk, note) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                ElseIf tableName = "mssp" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (kode, jenis, deskripsi, note) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                ElseIf tableName = "mgolongan" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (golongan, pangkat) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)


                ElseIf tableName = "tadj" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (no, tdt,id_mcoa, valchange, grdtotal, note, usin) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                ElseIf tableName = "tadjd" Then
                    For j As Integer = 0 To dtTemp.Columns.Count - 1
                        If j = dtTemp.Columns.Count - 1 Then
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "''"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "'"
                            End If
                        Else
                            If IsDBNull(dtTemp.Rows(i).Item(j)) Then : tempField += "'',"
                            Else : tempField += "'" + cl.cChr(dtTemp.Rows(i).Item(j)) + "',"
                            End If
                        End If
                    Next

                    Dim sql As String = "INSERT INTO " & tableName &
                    " (id_tadjh, no_tadjh, linenum, id_mitm, qty, price, id_muom, id_mwhse, note, usin) " &
                    " VALUES (" & tempField & ") "

                    cl.execCmdTrans(sql)

                End If
            Next


            dtTemp.Clear()
            ProgressBar1.Value = 10000

        Catch ex As Exception
            MessageBox.Show("Tidak bisa duplikat file dari disk ke System. Original error : " & ex.Message)

            Exit Sub
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:"
        openFileDialog1.Filter = "All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 4
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    txtbrowse.Text = openFileDialog1.FileName
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file Excel from disk. Original error : " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open. 
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtbrowse.Text = "" Then
            MsgBox("Direktori File belum diisi !", MsgBoxStyle.Information, "Gagal Upload")
            Exit Sub
        End If

        'If cmbtipefile.Text = "NEGARA" Then
        '    dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [NEGARA$]")
        'ElseIf cmbtipefile.Text = "KPP" Then
        '    dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [KPP$]")
        'ElseIf cmbtipefile.Text = "OBJEK PAJAK" Then
        '    dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [OJP$]")
        'ElseIf cmbtipefile.Text = "SSP" Then
        '    dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [SSP$]")
        'ElseIf cmbtipefile.Text = "GOLONGAN" Then
        '    dtTemp = cl.gettabeldataexcel(txtbrowse.Text, "SELECT * FROM [GP$]")
        'End If

        Try
            If cmbtipefile.Text = "NEGARA" Then
                cl.openTrans()
                convertToSQL("mnegara")
                cl.closeTrans(btnbrowse)
                If cl.sCloseTrans = 1 Then
                    cl.msgInform("Berhasil upload data " & cmbtipefile.Text & " !", "Sukses Upload")
                End If
            ElseIf cmbtipefile.Text = "KPP" Then
                cl.openTrans()
                convertToSQL("mkpp")
                cl.closeTrans(btnbrowse)
                If cl.sCloseTrans = 1 Then
                    cl.msgInform("Berhasil upload data " & cmbtipefile.Text & " !", "Sukses Upload")
                End If
            ElseIf cmbtipefile.Text = "OBJEK PAJAK" Then
                cl.openTrans()
                convertToSQL("mobjkpjk")
                cl.closeTrans(btnbrowse)
                If cl.sCloseTrans = 1 Then
                    cl.msgInform("Berhasil upload data " & cmbtipefile.Text & " !", "Sukses Upload")
                End If
            ElseIf cmbtipefile.Text = "SSP" Then
                cl.openTrans()
                convertToSQL("mssp")
                cl.closeTrans(btnbrowse)
                If cl.sCloseTrans = 1 Then
                    cl.msgInform("Berhasil upload data " & cmbtipefile.Text & " !", "Sukses Upload")
                End If
            ElseIf cmbtipefile.Text = "GOLONGAN" Then
                cl.openTrans()
                convertToSQL("mgolongan")
                cl.closeTrans(btnbrowse)
                If cl.sCloseTrans = 1 Then
                    cl.msgInform("Berhasil upload data " & cmbtipefile.Text & " !", "Sukses Upload")
                End If

            Else
                cl.msgError("Gagal upload file Excel to ", "Gagal Upload")
            End If

            ProgressBar1.Value = 0
            txtbrowse.Clear()
        Catch ex As Exception
            MessageBox.Show("Tidak bisa duplikat file dari disk ke System. Original error : " & ex.Message)

            Exit Sub
        End Try
    End Sub
End Class