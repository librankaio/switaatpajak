Imports System.IO
Module modsistem
    Public cl As New clspalem.mainClass
    Public idusr As Integer
    Public id_mbranch As Integer
    Public name_mbranch As String
    Public addr_mbranch As String
    Public phone_mbranch As String
    Public checksadmin As String
    '-- 14/06/2021 BY HANS
    Public masapjk As String
    Public mthpjk As Integer
    Public thnpjk As Integer
    Public npwp As String
    'Added by Rafiq @13/05/2022
    Public masapjkstr As String
    'Added by Rafiq @30/05/2022
    Public masapjknum As Integer

    'Added by Rafiq @30/03/2022
    Public pembetulan As Integer

    Public masapajakint As Integer
    Public tmasapajakint As String
    '-----21/07/2021 BY RAFIQ
    Public masapajakstr As String

    Public dirapp As String = System.Environment.CurrentDirectory
    Public dirAppPath As String = System.Environment.CurrentDirectory
    Public dirimgfolder As String = dirapp & "\img"
    Public dirImgFilePath As String = dirAppPath & "\img"



    Public Sub cekform(ByVal tfrm As Form, ByVal st As String, ByVal frfrm As Form)
        If st = "NEW" Then
            tfrm.Show() : tfrm.MdiParent = menuutama

            'nama form yang mau di set full screen
            If tfrm.Name = "" Then
                tfrm.SetBounds(0,
                    0,
                    menuutama.Width - 10,
                    menuutama.Height - 80)
            ElseIf tfrm.Name = "login" Or tfrm.Name = "aboutus" Or tfrm.Name = "sysconfig" Then
                tfrm.SetBounds((menuutama.Width - tfrm.Width) / 2,
                           (menuutama.Height - tfrm.Height) / 2 - 100,
                           tfrm.Width, tfrm.Height)
            Else
                Dim statnav As Integer = 0
                For Each child As Form In menuutama.MdiChildren
                    If child.Name = "navprogram" Then
                        statnav = 1
                    End If
                Next child
                If statnav = 1 Then
                    tfrm.SetBounds(navprogram.Width, 0, tfrm.Width, tfrm.Height)
                Else
                    tfrm.SetBounds(0, 0, tfrm.Width, tfrm.Height)
                End If
            End If

            tfrm.Select()
        ElseIf st = "BACK" Then
            frfrm.Dispose() : tfrm.Enabled = True : tfrm.BringToFront()
        ElseIf st = "SEARCH" Then
            frfrm.Enabled = False : tfrm.Show() : tfrm.MdiParent = menuutama
            tfrm.SetBounds((menuutama.Width - tfrm.Width) / 2,
                           (menuutama.Height - tfrm.Height) / 2,
                           tfrm.Width, tfrm.Height) : tfrm.Select()
            tfrm.Select()
        ElseIf st = "REFRESH" Then

            frfrm.Dispose()

            tfrm.Show() : tfrm.MdiParent = menuutama

            'nama form yang mau di set full screen
            If tfrm.Name = "" Then
                tfrm.SetBounds(0,
                    0,
                    menuutama.Width - 10,
                    menuutama.Height - 80)
            Else
                Dim statnav As Integer = 0
                For Each child As Form In menuutama.MdiChildren
                    If child.Name = "navprogram" Then
                        statnav = 1
                    End If
                Next child
                If statnav = 1 Then
                    tfrm.SetBounds(navprogram.Width, 0, tfrm.Width, tfrm.Height)
                Else
                    tfrm.SetBounds(0, 0, tfrm.Width, tfrm.Height)
                End If
            End If

            tfrm.Select()

        End If
    End Sub
    Public Sub encol(ByVal dg As DataGridView,
                      ByVal nm As String,
                      ByVal hdr As String,
                      Optional ByVal w As Integer = 0)
        With dg.Columns(nm)
            .Visible = True
            If w <> 0 Then : .Width = w : End If
            .HeaderText = hdr
        End With
    End Sub
    Public Function validatetxtnull(ByVal tObj As TextBox,
                               ByVal msg As String,
                               ByVal tmsg As String,
                               Optional ByVal tp As String = "CHR")
        Dim treturn As Integer = 0
        If tp = "CHR" Then
            If cl.cChr(tObj.Text) = "" Then : cl.msgError(msg, tmsg) : tObj.Select() : treturn = 1 : End If
        ElseIf tp = "NUM" Then
            If cl.cNum(tObj.Text) = 0 Then : cl.msgError(msg, tmsg) : tObj.Select() : treturn = 1 : End If
        End If
        Return treturn
    End Function
    Public Function validatedgnull(ByVal tDG As DataGridView,
                               ByVal colint As String,
                               ByVal msg As String,
                               ByVal tmsg As String,
                               Optional ByVal tp As String = "CHR")
        Dim treturn As Integer = 0

        If tp = "CHR" Then
            If tDG.Rows.Count = 0 Then
                treturn = 1
            Else
                For i As Integer = 0 To tDG.Rows.Count - 2
                    If cl.cChr(tDG.Rows(i).Cells(colint).Value) = "" Then
                        treturn = 1
                    End If
                Next
            End If
        Else
            If tDG.Rows.Count = 0 Then
                treturn = 1
            Else
                For i As Integer = 0 To tDG.Rows.Count - 1
                    If cl.cNum(tDG.Rows(i).Cells(colint).Value) = 0 Then
                        treturn = 1
                    End If
                Next
            End If
        End If


        If treturn = 1 Then
            cl.msgError(msg, tmsg) : tDG.Select() : treturn = 1
        End If

        Return treturn
    End Function

    Public Sub copyDir(ByVal sourcePath As String, ByVal destPath As String,
                          ByVal filename As String, Optional ByVal withExt As Integer = 1)


        If Not Directory.Exists(destPath) Then
            Directory.CreateDirectory(destPath)
        End If
        Dim sourceExt As String = Path.GetExtension(sourcePath).ToLower

        'untuk mengkopi extension file
        Dim dest As String
        If withExt = 0 Then : dest = Path.Combine(destPath, Path.GetFileName(filename))
        Else : dest = Path.Combine(destPath, Path.GetFileName(filename & sourceExt))
        End If

        'direktori mainTemp
        Dim mainTemp As String = dirImgFilePath & "\main\temp" & sourceExt
        If File.Exists(mainTemp) Then : File.Delete(mainTemp) : End If

        If File.Exists(dest) = False Then
            File.Copy(sourcePath, dest)
        Else

            File.Copy(sourcePath, mainTemp)
            File.Delete(dest)
            File.Copy(mainTemp, dest)
            File.Delete(mainTemp)
        End If

    End Sub

    Private Const INT_lens As Integer = 1
    Public str As System.Text.StringBuilder
    Public searchStr As String
    Dim b As Integer = 6
    Dim p() As Integer = {2, 4, 7, 9, 3, INT_lens}
    Dim i As Integer
    Dim j As Integer
    Dim k As Integer
    Dim c As Integer
    Dim lens As Integer

    'Encrypt function
    Public Function Encrypt(ByVal inputstr As String)
        Str = New System.Text.StringBuilder(inputstr)
        lens = Str.Length
        While (lens < b) OrElse (lens Mod b)
            Str.Append(" ")
            lens += INT_lens
        End While
        For i As Integer = 0 To ((lens / b) - INT_lens)
            For j As Integer = 0 To (b - INT_lens)
                k = p(j) + 100
                c = (6 * i + j)
                Str.Replace(Str.Chars(c), Chr(Asc(Str.Chars(c)) + k), c, INT_lens)
            Next
        Next
        Return Str.ToString
        Str = Nothing
    End Function
    'Decrypt function
    Public Function Decrypt(ByVal inputstr As String)

        Str = New System.Text.StringBuilder(inputstr)
        lens = Str.Length
        While (lens < b) OrElse (lens Mod b)
            Str.Append(" ")
            lens += INT_lens
        End While

        For i As Integer = 0 To ((lens / b) - INT_lens)
            For j As Integer = 0 To (b - INT_lens)
                k = p(j) + 100
                c = (6 * i + j)
                Str.Replace(Str.Chars(c), Chr(Asc(Str.Chars(c)) - k), c, INT_lens)
            Next
        Next
        Return Str.ToString
        Str = Nothing
    End Function
    '--------------------------------- end encrypt decrypt ---------------------------------'

    Public Sub cultureSet()
        Dim cultureInfo As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("id-ID")
        Application.CurrentCulture = cultureInfo
        '    System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo.GetCultureInfo("en-US")
        cultureInfo.NumberFormat.NumberDecimalSeparator = ","
        cultureInfo.NumberFormat.NumberGroupSeparator = "."
        cultureInfo.DateTimeFormat.DateSeparator = "/"
        cultureInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
    End Sub
End Module
