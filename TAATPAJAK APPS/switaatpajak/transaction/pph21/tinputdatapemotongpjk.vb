Public Class tinputdatapemotongpjk
    Dim statusTempForm, varTempForm, varTempForm2 As String
    Dim tempForm As Form
    Dim tempObj As Object
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

    Public Sub loadStatusTempForm(ByVal tempAsalForm As Form, ByVal tempAsalObj As Object, ByVal temp As String)
        tempForm = tempAsalForm
        tempObj = tempAsalObj
        statusTempForm = temp
    End Sub

    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Private Sub clearData()
        txtnpwp.Text = ""
        txtnama.Text = ""
        cmbkodepjk.SelectedIndex = 0
        txtbruto.Text = 0
        txtpphptg.Text = 0
        txtkdnegara.Text = ""
        chwpasing.Checked = False
    End Sub
    'Private Sub loadcmbnegara()
    '    Dim dtemptp As DataTable = cl.table(
    '      "SELECT id AS 'value', code AS 'display' FROM mnegara WHERE stat = 1 ")


    'End Sub
    Private Sub loadcmb()
        'Dim cmbobjpjk As DataTable = cl.table(
        '  "SELECT id AS 'value', concat(kode,' - ',objkpjk) AS 'display' FROM mobjkpjk WHERE stat = 1 ")
        Dim cmbnegara As DataTable = cl.table(
          "SELECT id AS 'value', concat(code,' - ',name) AS 'display' FROM mnegara WHERE stat = 1 ")

        Dim row As DataRow = cmbnegara.NewRow()
        row(0) = 0
        row(1) = "----PILIH NEGARA----"
        cmbnegara.Rows.InsertAt(row, 0)

        'cmbkodepjk.DataSource = cmbobjpjk
        'cmbkodepjk.ValueMember = "value"
        'cmbkodepjk.DisplayMember = "display"

        cmbkdnegara_rl.DataSource = cmbnegara
        cmbkdnegara_rl.ValueMember = "value"
        cmbkdnegara_rl.DisplayMember = "display"

    End Sub

    Public Sub changestatform(ByVal tstatform As String)
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            btnsave.Text = "Save"
            'gencode()
            'loadcmbobjpjk()
            'loadcmbnegara()
            loadcmb()
            btndelete.Visible = False
            btnlist.Visible = False
            btnrefresh.Visible = False
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True

        End If
        Me.Select() : txtnpwp.Select()
    End Sub

    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtnpwp.Select()
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tinputdatapemotongpjk
        cekform(frm, "REFRESH", Me)
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtnpwp, "NPWP Tidak Boleh Kosong !", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi

            If txtnpwp.Text.Length < 16 Then
                .msgError("Angka NPWP tidak boleh kurang dari 16!")
                Exit Sub
            End If

            '------ start validasi wpasing
            Dim wpasing As String
            If chwpasing.Checked = True Then
                wpasing = "Y"
            Else
                wpasing = "N"
            End If
            '------ end validasi

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputdatapemotongpjk'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtnpwp.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stinputdatapemotongpjk (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(cmbkodepjk.Text) & "'" &
                        " , '" & .cNum(txtbruto.Text) & "'" &
                        " , '" & .cNum(txtpphptg.Text) & "'" &
                        " , '" & .cChr(txtkdnegara.Text) & "'" &
                        " , '" & .cChr(cmbkdnegara_rl.Text) & "'" &
                        " , '" & masapjk & "'" &
                        " , '" & thnpjk & "'" &
                        " , '" & wpasing & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan : " & txtnpwp.Text & " !", "Informasi")
                        ' -- RETURN BACK TO ORIGINAL FORM !
                        Me.Dispose()
                        Dim a As tdaftarpemotongpjkbulan = CType(Application.OpenForms("tdaftarpemotongpjkbulan"), tdaftarpemotongpjkbulan)
                        a.Enabled = True
                        a.loadPmotongPjkBlnTable()
                        a.getcalculate()
                    End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputdatapemotongpjk'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtnpwp.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stinputdatapemotongpjk (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(cmbkodepjk.Text) & "'" &
                        " , '" & .cNum(txtbruto.Text) & "'" &
                        " , '" & .cNum(txtpphptg.Text) & "'" &
                        " , '" & .cChr(txtkdnegara.Text) & "'" &
                        " , '" & .cChr(cmbkdnegara_rl.Text) & "'" &
                        " , '" & masapjk & "'" &
                        " , '" & thnpjk & "'" &
                        " , '" & wpasing & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtnpwp.Text & " !", "Informasi")
                        ' -- RETURN BACK TO ORIGINAL FORM !
                        Me.Dispose()
                        Dim a As tdaftarpemotongpjkbulan = CType(Application.OpenForms("tdaftarpemotongpjkbulan"), tdaftarpemotongpjkbulan)
                        a.Enabled = True
                        a.loadPmotongPjkBlnTable()
                        a.getcalculate()
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tinputdatapemotongpjk TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("npwp").Visible = True : .Columns("npwp").HeaderText = "NPWP"
            .Columns("nama").Visible = True : .Columns("nama").HeaderText = "Nama"
            .Columns("kodepjk").Visible = True : .Columns("kodepjk").HeaderText = "Kode Pajak"
            .Columns("bruto").Visible = True : .Columns("bruto").HeaderText = "Bruto"
            .Columns("pphptg").Visible = True : .Columns("pphptg").HeaderText = "PPh Potong"
            .Columns("kdnegara").Visible = True : .Columns("kdnegara").HeaderText = "Kode Negara"
            .Columns("kdnegara_rl").Visible = True : .Columns("kdnegara_rl").HeaderText = "Kode Negara RL"

        End With
        a.loadStatusTempForm(Me, Me.txtnpwp, "[tinputdatapemotongpjk]tinputdatapemotongpjk")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tinputdatapemotongpjk'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtnpwp.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stinputdatapemotongpjk (" &
                        " '" & .cChr(txtnpwp.Text) & "'" &
                        " , '" & .cChr(txtnama.Text) & "'" &
                        " , '" & .cChr(cmbkodepjk.Text) & "'" &
                        " , '" & .cChr(txtbruto.Text) & "'" &
                        " , '" & .cChr(txtpphptg.Text) & "'" &
                        " , '" & .cChr(txtkdnegara.Text) & "'" &
                        " , '" & .cChr(cmbkdnegara_rl.Text) & "'" &
                        " , '" & masapjk & "'" &
                        " , '" & thnpjk & "'" &
                        " ,''" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtnpwp.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub
    Private Sub valiwp()
        If chwpasing.Checked = True Then
            cmbkdnegara_rl.Enabled = True
        Else
            cmbkdnegara_rl.Enabled = False
            txtkdnegara.Text = ""
            cmbkdnegara_rl.SelectedIndex = 0
        End If
    End Sub
    Private Sub chwpasing_CheckedChanged(sender As Object, e As EventArgs) Handles chwpasing.CheckedChanged
        valiwp()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub

    Private Sub tinputdatapemotongpjk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub

    Private Sub cmbkdnegara_rl_LostFocus(sender As Object, e As EventArgs) Handles cmbkdnegara_rl.LostFocus
        txtkdnegara.Text = cl.readData("SELECT code FROM mnegara WHERE stat = 1 AND id = '" & cmbkdnegara_rl.SelectedValue & "'")
    End Sub

End Class