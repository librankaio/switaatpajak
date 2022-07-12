Public Class pinAuth
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

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Select()
    End Sub
    Private Sub search_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cekform(tempForm, "BACK", Me)
        tempObj.select()
    End Sub
    Dim r As Integer = 0, c As Integer = 0
    Private Sub search()

        tempForm.Select() : tempObj.select()
        Me.Dispose()
    End Sub

    'Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuser.KeyDown
    '    'If e.KeyCode = Keys.Enter Then
    '    '    If txtuser.Text <> "" Then
    '    '        search()
    '    '    Else
    '    '        submitsearch()
    '    '    End If
    '    'End If
    'End Sub

    'Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged
    '    If statSQLSearch = 1 Then
    '        search()
    '    End If
    'End Sub

    'Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
    '    With cl
    '        If txtuser.Text = "" Then
    '            .msgError("Mohon input username !", "Information")
    '            txtuser.Select()
    '        ElseIf txtpin.Text = "" Then
    '            .msgError("Mohon input password !", "Information")
    '            txtpin.Select()
    '        ElseIf cl.readData("SELECT MD5('" & txtpin.Text & "')") <> .readData("SELECT apppass FROM cusr WHERE name = '" & txtuser.Text & "' AND sadmin = 'Y' and stat = 1") Then
    '            .msgError("Wrong Password or Username, please contact Administrator !", "Information")
    '            txtuser.Select()
    '        Else
    '            If statusTempForm = "[pos]auth" Then
    '                Dim a As tpos = CType(Application.OpenForms("tpos"), tpos)
    '                a.Enabled = True
    '                a.flagAuthorize = 1
    '                '  SendKeys.Send("{DEL}")
    '                tempForm.Select() : tempObj.select()
    '                Me.Dispose()

    '            ElseIf statusTempForm = "[pos]authprice" Then
    '                Dim a As tpos = CType(Application.OpenForms("tpos"), tpos)
    '                a.Enabled = True
    '                a.flagAuthorize = 1
    '                a.txthrg.ReadOnly = False
    '                a.txthrg.Focus()
    '                a.txtdisc1.Select()
    '                '  SendKeys.Send("{DEL}")
    '                tempForm.Select() : tempObj.select()
    '                a.txthrg.Focus()
    '                a.txthrg.Select()
    '                Me.Dispose()

    '            ElseIf statusTempForm = "[pos]authdisc1" Then
    '                Dim a As tpos = CType(Application.OpenForms("tpos"), tpos)
    '                a.Enabled = True
    '                a.flagAuthorize = 1
    '                a.txtdisc1.ReadOnly = False
    '                a.txtdisc1.Focus()
    '                a.txtdisc1.Select()
    '                '  SendKeys.Send("{DEL}")
    '                tempForm.Select() : tempObj.select()
    '                a.txtdisc1.Focus()
    '                a.txtdisc1.Select()
    '                Me.Dispose()

    '            ElseIf statusTempForm = "[pos]authdisc2" Then
    '                Dim a As tpos = CType(Application.OpenForms("tpos"), tpos)
    '                a.Enabled = True
    '                a.flagAuthorize = 1
    '                a.txtdisc2.ReadOnly = False
    '                a.txtdisc2.Focus()
    '                a.txtdisc2.Select()
    '                '  SendKeys.Send("{DEL}")
    '                tempForm.Select() : tempObj.select()
    '                a.txtdisc1.Focus()
    '                a.txtdisc1.Select()
    '                Me.Dispose()
    '            ElseIf statusTempForm = "[pos]exit" Then
    '                Dim a As tpos = CType(Application.OpenForms("tpos"), tpos)
    '                a.Enabled = True
    '                Me.Dispose()
    '                a.Dispose()
    '            End If
    '        End If
    '    End With
    'End Sub

    'Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cekform(tempForm, "BACK", Me)
    '    tempObj.select()
    'End Sub

End Class