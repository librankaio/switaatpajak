Public Class changepass
    
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message,
        ByVal keyData As System.Windows.Forms.Keys) As Boolean


        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            btncancel.PerformClick()
        ElseIf msg.WParam.ToInt32 = Convert.ToInt32(Keys.F1) Then
            btnsave.PerformClick()
        End If


        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    
    Private Sub changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcode.Text = cl.readData("SELECT code FROM cusr WHERE id = '" & idusr & "'")
        txtusername.Text = cl.readData("SELECT name FROM cusr WHERE id = '" & idusr & "'")
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtoldpass.Text = "" Then
            cl.msgError("Kata Sandi Lama tidak boleh kosong !", "Gagal Verfikasi")
            Exit Sub
        ElseIf txtnewpass.Text = "" Then
            cl.msgError("Kata Sandi Baru tidak boleh kosong !", "Gagal Verfikasi")
            Exit Sub
        ElseIf txtnewpass2.Text = "" Then
            cl.msgError("Konfirmasi Kata Sandi Baru tidak boleh kosong !", "Gagal Verfikasi")
            Exit Sub
        ElseIf txtnewpass.Text <> txtnewpass2.Text Then
            cl.msgError("Kata Sandi Baru tidak sama dengan Konfirmasi Kata Sandi Baru !", "Gagal Verfikasi")
            Exit Sub
        End If

        Dim pass As String = cl.readData(
           " SELECT pass FROM cusr " & _
           " WHERE code = '" & txtcode.Text & "' AND stat = 1")
        With cl
            If .VerifyMd5Hash(txtoldpass.Text, pass) = True Then
                Dim tny As Integer
                tny = .msgYesNo("Apakah anda mau Ganti Password ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                       "CALL susr (" &
                        " '" & .cChr(txtcode.Text) & "'" &
                        " , ''" &
                        " , '" & .cChr(txtnewpass2.Text) & "'" &
                        " , '0'" &
                        " , 'Y'" &
                        " , ''" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIFPASS'" &
                        " , '" & idusr & "'" &
                        " )")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Sukses Ganti Password data User : " & txtcode.Text & " !", "Simpan Data Sukses")
                        txtoldpass.Select()
                        txtoldpass.Text = ""
                        txtnewpass.Text = ""
                        txtnewpass2.Text = ""
                    End If
                End If
            Else
                cl.msgError("Kata Sandi ada yang salah, silahkan ulangi !", "Gagal Verfikasi")
                Exit Sub
            End If

        End With
    End Sub
End Class