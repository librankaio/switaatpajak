Imports System.IO
Public Class CashDrawer

#Region "DECLARATIONS"
    Private Shared OPEN_CODE As String = Chr(27) & "p" & Chr(0) & Chr(100) & Chr(250)
#End Region

#Region "PROPERTIES"

#End Region

#Region "USER-DEFINED"

#End Region

#Region "METHODS"
    Public Shared Sub OpenDrawer(ByVal cDrawer As String)
        Try
            RAWPOSPrinter.SendStringToPrinter(cDrawer, OPEN_CODE)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Shared Sub OpenDrawer(ByVal cDrawer As String, ByVal cOpenString As String)
        Try
            RAWPOSPrinter.SendStringToPrinter(cDrawer, cOpenString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

End Class