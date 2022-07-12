Public Class tpph23_baru2
    Private Sub btndiptg_CheckedChanged(sender As Object, e As EventArgs) Handles btnidentitas.CheckedChanged
        If btnidentitas.Checked Then
            pnIdentitas.BringToFront()
        End If
    End Sub

    Private Sub btndokumen_CheckedChanged(sender As Object, e As EventArgs) Handles btndokumen.CheckedChanged
        If btndokumen.Checked Then
            pnDokumen.BringToFront()
        End If
    End Sub

    Private Sub btnIdentitasPmtg_CheckedChanged(sender As Object, e As EventArgs) Handles btnIdentitasPmtg.CheckedChanged
        If btnIdentitasPmtg.Checked Then
            pnIdentitasPmtg.BringToFront()
        End If
    End Sub

    Private Sub btnpphptg_CheckedChanged(sender As Object, e As EventArgs) Handles btnpphptg.CheckedChanged
        If btnpphptg.Checked Then
            pnPphptg.BringToFront()
        End If
    End Sub

    Private Sub tpph23_baru2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
    End Sub

End Class