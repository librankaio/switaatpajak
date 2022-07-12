Public Class paytMthd
    Dim statusTempForm, varTempForm, varTempForm2 As String
    Dim tempForm As Form
    Dim tempObj As Object
    Dim itemtable As New DataTable
    Dim SQLSearch As String
    Dim statSQLSearch As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32 = Convert.ToInt32(Keys.Escape) Then
            cekform(tempForm, "BACK", Me)
            tempObj.select()
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

    Private Sub loadcmb()
        Dim dtemptp As DataTable = cl.table(
            "SELECT code AS 'value', name AS 'display' FROM mpaytp WHERE stat = 1 ")

        cmbbyr1.DataSource = dtemptp
        cmbbyr1.ValueMember = "value"
        cmbbyr1.DisplayMember = "display"

        Dim dtemptp2 As DataTable = cl.table(
            "SELECT code AS 'value', name AS 'display' FROM mpaytp WHERE stat = 1 ")

        cmbbyr2.DataSource = dtemptp2
        cmbbyr2.ValueMember = "value"
        cmbbyr2.DisplayMember = "display"

        Dim dtemptp3 As DataTable = cl.table(
            "SELECT code AS 'value', name AS 'display' FROM mpaytp WHERE stat = 1 ")

        cmbbyr3.DataSource = dtemptp3
        cmbbyr3.ValueMember = "value"
        cmbbyr3.DisplayMember = "display"

    End Sub

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcmb()
    End Sub
    Private Sub search_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub
    Dim r As Integer = 0, c As Integer = 0
    Private Sub search()

        tempForm.Select() : tempObj.select()
        Me.Dispose()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If txtuser.Text <> "" Then
        '        search()
        '    Else
        '        submitsearch()
        '    End If
        'End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If statSQLSearch = 1 Then
            search()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'With cl
        '    If statusTempForm = "[pos]changeprice" Then
        '        Dim a As tposNEW = CType(Application.OpenForms("tposNEW"), tposNEW)
        '        a.Enabled = True
        '        a.flagAuthorize = 1
        '        a.dgview.Item("price", a.dgview.CurrentRow.Index).Value = cl.cCur(txtbyr3.Text)
        '        a.getcalculate()
        '        Me.Dispose()
        '    End If
        'End With
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub

End Class