Imports System.Runtime.InteropServices

Public Class menubaru_v2
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub hidesubmenu()
        pnlsubpph.Visible = False
    End Sub

    Private Sub menubaru_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidesubmenu()
    End Sub
    '----Show panel and hide panel
    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnpph_Click(sender As Object, e As EventArgs) Handles btnpph.Click
        showsubmenu(pnlsubpph)

        pnlonbtn.Height = btnpph.Height
        pnlonbtn.Top = btnpph.Top
    End Sub
    '----Show child panel from another panel
    Private currentform As Form = Nothing
    Private Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        pnlutama.Controls.Add(childform)
        pnlutama.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btnmaster_Click(sender As Object, e As EventArgs) Handles btnmaster.Click
        hidesubmenu()
        pnlonbtn.Height = btnmaster.Height
        pnlonbtn.Top = btnmaster.Top
        openchildform(New master())
    End Sub

    Private Sub btntarif_Click(sender As Object, e As EventArgs) Handles btntarif.Click
        hidesubmenu()
        pnlonbtn.Height = btntarif.Height
        pnlonbtn.Top = btntarif.Top
    End Sub

    Private Sub pnltools_MouseMove(sender As Object, e As MouseEventArgs) Handles pnltools.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnexitapp_Click(sender As Object, e As EventArgs) Handles btnexitapp.Click
        Me.Close()
    End Sub

    Private Sub btnmaximize_Click(sender As Object, e As EventArgs) Handles btnmaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub
End Class