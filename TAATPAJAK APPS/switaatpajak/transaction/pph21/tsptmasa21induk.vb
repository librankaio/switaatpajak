Public Class tsptmasa21induk
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
    Public Sub getidmaster(ByVal tidmaster As Integer)
        idmaster = tidmaster
    End Sub
    Public Sub changestatform(ByVal tstatform As String)
        cultureSet()
        statform = tstatform
        If tstatform = "new" Then
            clearData()
            getmth()
            loaddata()
            calculated()
            btnsave.Text = "Save"
            'gencode()
            btndelete.Visible = False
            btnprint.Visible = False
        ElseIf tstatform = "upd" Then

            btnsave.Text = "Update"
            btndelete.Visible = True
            btnprint.Visible = True
        End If
        Me.Select() : txtb1jpp1.Select()
    End Sub
    Private Sub mbranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cultureSet()
        changestatform("new")
    End Sub

    Private Sub mbp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.BringToFront() : Me.Select() : txtb1jpp1.Select()
    End Sub
    Private Sub loaddata()
        '-------KODE '21-100-01'-----------
        Dim brt1 As Decimal
        Dim brt1d As Decimal
        Dim totbrut1 As Decimal
        Dim totpph1 As Decimal
        Dim pgw1 As Integer
        Dim pgw1d As Integer
        Dim totpegawai1 As Decimal
        brt1 = cl.readData("SELECT ifnull(SUM(bruto),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-01' AND stat = 1")
        brt1d = cl.readData("SELECT brutopegawai FROM tdaftarpemotongpjkbulan WHERE stat = 1 ")
        totbrut1 = cl.cNum(brt1) + cl.cNum(brt1d)
        totpph1 = cl.readData("SELECT ifnull(sum(pphptg),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-01' AND stat = 1")
        pgw1 = cl.readData("SELECT ifnull(COUNT(kodepjk),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-01' AND stat = 1")
        pgw1d = cl.readData("SELECT jmlpegawai FROM tdaftarpemotongpjkbulan WHERE stat = 1 ")
        totpegawai1 = cl.cNum(pgw1) + cl.cNum(pgw1d)
        '---------------END-------------------
        '-------KODE '21-100-02'-----------
        Dim brt2 As Decimal
        Dim brt2d As Decimal
        Dim totbrut2 As Decimal
        Dim totpph2 As Decimal
        Dim pgw2 As Integer
        Dim pgw2d As Integer
        Dim totpegawai2 As Integer
        brt2 = cl.readData("SELECT ifnull(SUM(bruto),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-02' AND stat = 1")
        brt2d = cl.readData("SELECT brutopensiun FROM tdaftarpemotongpjkbulan WHERE stat = 1 ")
        totbrut2 = cl.cNum(brt2) + cl.cNum(brt2d)
        totpph2 = cl.readData("SELECT ifnull(sum(pphptg),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-02' AND stat = 1")
        pgw2 = cl.readData("SELECT ifnull(COUNT(kodepjk),0) from tinputdatapemotongpjk where masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND kodepjk ='21-100-02' AND stat = 1")
        pgw2d = cl.readData("SELECT jmlpensiun FROM tdaftarpemotongpjkbulan WHERE stat = 1 ")
        totpegawai2 = cl.cNum(pgw2) + cl.cNum(pgw2d)
        '---------------END-------------------
        '-------KODE '21-100-03'-----------
        Dim totbrut3 As Decimal
        Dim totpph3 As Decimal
        Dim totpegawai3 As Decimal
        totbrut3 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-03' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai3 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-03' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph3 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-03' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-04'-----------
        Dim totbrut4 As Decimal
        Dim totpph4 As Decimal
        Dim totpegawai4 As Decimal
        totbrut4 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-04' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai4 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-04' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph4 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-04' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-05'-----------
        Dim totbrut5 As Decimal
        Dim totpph5 As Decimal
        Dim totpegawai5 As Decimal
        totbrut5 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-05' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai5 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-05' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph5 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-05' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-06'-----------
        Dim totbrut6 As Decimal
        Dim totpph6 As Decimal
        Dim totpegawai6 As Decimal
        totbrut6 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-06' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai6 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-06' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph6 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-06' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-07'-----------
        Dim totbrut7 As Decimal
        Dim totpph7 As Decimal
        Dim totpegawai7 As Decimal
        totbrut7 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-07' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai7 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-07' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph7 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-07' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-08'-----------
        Dim totbrut8 As Decimal
        Dim totpph8 As Decimal
        Dim totpegawai8 As Decimal
        totbrut8 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-08' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai8 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-08' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph8 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-08' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-09'-----------
        Dim totbrut9 As Decimal
        Dim totpph9 As Decimal
        Dim totpegawai9 As Decimal
        totbrut9 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-09' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai9 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-09' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph9 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-09' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-10'-----------
        Dim totbrut10 As Decimal
        Dim totpph10 As Decimal
        Dim totpegawai10 As Decimal
        totbrut10 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-10' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai10 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-10' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph10 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-10' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-11'-----------
        Dim totbrut11 As Decimal
        Dim totpph11 As Decimal
        Dim totpegawai11 As Decimal
        totbrut11 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-11' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai11 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-11' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph11 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-11' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-100-12'-----------
        Dim totbrut12 As Decimal
        Dim totpph12 As Decimal
        Dim totpegawai12 As Decimal
        totbrut12 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-12' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai12 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-12' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph12 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-12' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-402-01'-----------
        Dim totbrut13 As Decimal
        Dim totpph13 As Decimal
        Dim totpegawai13 As Decimal
        totbrut13 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-13' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai13 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-13' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph13 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-13' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-401-01'-----------
        Dim totbrut14 As Decimal
        Dim totpph14 As Decimal
        Dim totpegawai14 As Decimal
        totbrut14 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-14' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai14 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-14' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph14 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-14' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-------KODE '21-401-02'-----------
        Dim totbrut15 As Decimal
        Dim totpph15 As Decimal
        Dim totpegawai15 As Decimal
        totbrut15 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-15' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpegawai15 = cl.readData("Select count(kdobjpjk) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb On ta.id = tb.idh where kdobjpjk = '21-100-15' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph15 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgtdkfinal ta INNER JOIN tbuktiptgtdkfinald tb ON ta.id = tb.idh where kdobjpjk = '21-100-15' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        '---------------END-------------------
        '-----------PEGAWA TETAP---------------
        txtb1jpp1.Text = cl.cCur(totpegawai1)
        txtb1jpb1.Text = cl.cCur(totbrut1)
        txtb1jpjkp1.Text = cl.cCur(totpph1)
        '-----------END PEGAWA TETAP ---------------

        '-----------PEGAWA TETAP 2---------------
        txtb1jpp2.Text = cl.cCur(totpegawai2)
        txtb1jpb2.Text = cl.cCur(totbrut2)
        txtb1jpjkp2.Text = cl.cCur(totpph2)
        '-----------END PEGAWA TETAP 2---------------

        '-----------PEGAWA TETAP 3---------------
        txtb1jpp3.Text = cl.cCur(totpegawai3)
        txtb1jpb3.Text = cl.cCur(totbrut3)
        txtb1jpjkp3.Text = cl.cCur(totpph3)
        '-----------END PEGAWA TETAP 3---------------

        '-----------PEGAWA TETAP 4---------------
        txtb1jpp4.Text = cl.cCur(totpegawai4)
        txtb1jpb4.Text = cl.cCur(totbrut4)
        txtb1jpjkp4.Text = cl.cCur(totpph4)
        '-----------END PEGAWA TETAP 4---------------

        '-----------PEGAWA TETAP 5---------------
        txtb1jpp5.Text = cl.cCur(totpegawai5)
        txtb1jpb5.Text = cl.cCur(totbrut5)
        txtb1jpjkp5.Text = cl.cCur(totpph5)
        '-----------END PEGAWA TETAP 5---------------
        '-----------PEGAWA TETAP 6---------------
        txtb1jpp6.Text = cl.cCur(totpegawai6)
        txtb1jpb6.Text = cl.cCur(totbrut6)
        txtb1jpjkp6.Text = cl.cCur(totpph6)
        '-----------END PEGAWA TETAP 6---------------
        '-----------PEGAWA TETAP 7---------------
        txtb1jpp7.Text = cl.cCur(totpegawai7)
        txtb1jpb7.Text = cl.cCur(totbrut7)
        txtb1jpjkp7.Text = cl.cCur(totpph7)
        '-----------END PEGAWA TETAP 7---------------
        '-----------PEGAWA TETAP 8---------------
        txtb1jpp8.Text = cl.cCur(totpegawai8)
        txtb1jpb8.Text = cl.cCur(totbrut8)
        txtb1jpjkp8.Text = cl.cCur(totpph8)

        '-----------END PEGAWA TETAP 8---------------
        '-----------PEGAWA TETAP 9---------------
        txtb1jpp9.Text = cl.cCur(totpegawai9)
        txtb1jpb9.Text = cl.cCur(totbrut9)
        txtb1jpjkp9.Text = cl.cCur(totpph9)
        '-----------END PEGAWA TETAP 9---------------
        '-----------PEGAWA TETAP 10---------------
        txtb1jpp10.Text = cl.cCur(totpegawai10)
        txtb1jpb10.Text = cl.cCur(totbrut10)
        txtb1jpjkp10.Text = cl.cCur(totpph10)
        '-----------END PEGAWA TETAP 10---------------
        '-----------PEGAWA TETAP 11---------------
        txtb1jpp11.Text = cl.cCur(totpegawai11)
        txtb1jpb11.Text = cl.cCur(totbrut11)
        txtb1jpjkp11.Text = cl.cCur(totpph11)
        '-----------END PEGAWA TETAP 11---------------
        '-----------PEGAWA TETAP 12---------------
        txtb1jpp12.Text = cl.cCur(totpegawai12)
        txtb1jpb12.Text = cl.cCur(totbrut12)
        txtb1jpjkp12.Text = cl.cCur(totpph12)
        '-----------END PEGAWA TETAP 12---------------
        '-----------PEGAWA TETAP 13---------------
        txtb1jpp13.Text = cl.cCur(totpegawai13)
        txtb1jpb13.Text = cl.cCur(totbrut13)
        txtb1jpjkp13.Text = cl.cCur(totpph13)
        '-----------END PEGAWA TETAP 13---------------
        '-----------PEGAWA TETAP 14---------------
        txtb1jpp14.Text = cl.cCur(totpegawai14)
        txtb1jpb14.Text = cl.cCur(totbrut14)
        txtb1jpjkp14.Text = cl.cCur(totpph14)
        '-----------END PEGAWA TETAP 14---------------
        '-----------PEGAWA TETAP 15---------------
        txtb1jpp15.Text = cl.cCur(totpegawai15)
        txtb1jpb15.Text = cl.cCur(totbrut15)
        txtb1jpjkp15.Text = cl.cCur(totpph15)
        '-----------END PEGAWA TETAP 15---------------

        '----------C.Objek Pajak Final
        '-----------Penerima Uang 1
        Dim totpegawai16 As Decimal
        Dim totbrut16 As Decimal
        Dim totpph16 As Decimal

        totpegawai16 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totbrut16 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph16 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")

        txtdjpp1.Text = cl.cCur(totpegawai16)
        txtdjpb1.Text = cl.cCur(totbrut16)
        txtdjpjkp1.Text = cl.cCur(totpph16)
        '-----------END Penerima Uang 1
        '-----------Penerima Uang 2
        Dim totpegawai17 As Decimal
        Dim totbrut17 As Decimal
        Dim totpph17 As Decimal

        'txtdkop2.Text = cl.readData("SELECT nobkt FROM tbuktiptgfinal TA  WHERE TA.stat = 1 AND MONTH(tanggal) = ' " & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "'")
        totpegawai17 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-02' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totbrut17 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-02' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph17 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-401-02' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")

        txtdjpp2.Text = cl.cCur(totpegawai17)
        txtdjpb2.Text = cl.cCur(totbrut17)
        txtdjpjkp2.Text = cl.cCur(totpph17)
        '-----------END Penerima Uang 2
        '-----------Penerima Uang 3
        Dim totpegawai18 As Decimal
        Dim totbrut18 As Decimal
        Dim totpph18 As Decimal

        'txtdkop3.Text = cl.readData("SELECT nobkt FROM tbuktiptgfinal TA  WHERE TA.stat = 1 AND MONTH(tanggal) = ' " & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "'")
        totpegawai18 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-402-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totbrut18 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-402-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph18 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '21-402-01' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")

        txtdjpp3.Text = cl.cCur(totpegawai18)
        txtdjpb3.Text = cl.cCur(totbrut18)
        txtdjpjkp3.Text = cl.cCur(totpph18)
        '-----------END Penerima Uang 3
        '-----------Penerima Uang 4
        Dim totpegawai19 As Decimal
        Dim totbrut19 As Decimal
        Dim totpph19 As Decimal

        'txtdkop4.Text = cl.readData("SELECT nobkt FROM tbuktiptgfinal TA  WHERE TA.stat = 1 AND MONTH(tanggal) = ' " & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "'")
        totpegawai19 = cl.readData("SELECT count(kdobjpjk) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '27-100-99' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totbrut19 = cl.readData("SELECT ifnull(sum(bruto),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '27-100-99' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")
        totpph19 = cl.readData("SELECT ifnull(sum(pphptg),0) FROM tbuktiptgfinal ta INNER JOIN tbuktiptgfinald tb ON ta.id = tb.idh where kdobjpjk = '27-100-99' AND masapjk = '" & masapjk & "' AND thnpjk = '" & thnpjk & "' AND  tb.stat = 1 AND tb.stat = 1 order by ta.datein AND tb.datein")

        txtdjpp4.Text = cl.cCur(totpegawai19)
        txtdjpb4.Text = cl.cCur(totbrut19)
        txtdjpjkp4.Text = cl.cCur(totpph19)
        '-----------END Penerima Uang 4
        '-----------Penerima Uang 5
        'txtdkop5.Text = cl.readData("SELECT nobkt FROM tbuktiptgfinal TA  WHERE TA.stat = 1 AND MONTH(tanggal) = ' " & masapajakint & "' and YEAR(tanggal) = '" & thnpjk & "'")
        Dim sumpegawaid As Decimal
        sumpegawaid = cl.cNum(txtdjpp1.Text) + cl.cNum(txtdjpp2.Text) + cl.cNum(txtdjpp3.Text) + cl.cNum(txtdjpp4.Text)
        txtdjpp5.Text = cl.cCur(sumpegawaid)

        Dim totalbrutod As Decimal
        totalbrutod = cl.cNum(txtdjpb1.Text) + cl.cNum(txtdjpb2.Text) + cl.cNum(txtdjpb3.Text) + cl.cNum(txtdjpb4.Text)
        txtdjpb5.Text = cl.cNum(totalbrutod)

        Dim totalpphd As Decimal
        totalpphd = cl.cNum(txtdjpjkp1.Text) + cl.cNum(txtdjpjkp2.Text) + cl.cNum(txtdjpjkp3.Text) + cl.cNum(txtdjpjkp4.Text)
        txtdjpjkp5.Text = cl.cCur(totalpphd)
        '-----------END Penerima Uang 5
        '----------END C.Objek Pajak Final
    End Sub
    Private Sub calculated()
        Dim sumpegawai As Decimal
        sumpegawai = cl.cNum(txtb1jpp1.Text) + cl.cNum(txtb1jpp2.Text) + cl.cNum(txtb1jpp3.Text) + cl.cNum(txtb1jpp4.Text) + cl.cNum(txtb1jpp5.Text) + cl.cNum(txtb1jpp6.Text) + cl.cNum(txtb1jpp7.Text) +
        cl.cNum(txtb1jpp8.Text) + cl.cNum(txtb1jpp9.Text) + cl.cNum(txtb1jpp10.Text) + cl.cNum(txtb1jpp11.Text) + cl.cNum(txtb1jpp12.Text) + cl.cNum(txtb1jpp13.Text) + cl.cNum(txtb1jpp14.Text) + cl.cNum(txtb1jpp15.Text)
        txtb1jpp16.Text = cl.cCur(sumpegawai)
        Dim totalbruto As Decimal
        totalbruto = cl.cNum(txtb1jpb1.Text) + cl.cNum(txtb1jpb1.Text) + cl.cNum(txtb1jpb2.Text) + cl.cNum(txtb1jpb3.Text) + cl.cNum(txtb1jpb4.Text) + cl.cNum(txtb1jpb5.Text) +
            cl.cNum(txtb1jpb6.Text) + cl.cNum(txtb1jpb7.Text) + cl.cNum(txtb1jpb8.Text) + cl.cNum(txtb1jpb9.Text) + cl.cNum(txtb1jpb10.Text) + cl.cNum(txtb1jpb11.Text) +
            cl.cNum(txtb1jpb12.Text) + cl.cNum(txtb1jpb13.Text) + cl.cNum(txtb1jpb14.Text) + cl.cNum(txtb1jpb15.Text)
        txtb1jpb16.Text = cl.cCur(totalbruto)
        Dim totalpph As Decimal
        totalpph = cl.cNum(txtb1jpjkp1.Text) + cl.cNum(txtb1jpjkp2.Text) + cl.cNum(txtb1jpjkp3.Text) + cl.cNum(txtb1jpjkp4.Text) + cl.cNum(txtb1jpjkp5.Text) + cl.cNum(txtb1jpjkp6.Text) + cl.cNum(txtb1jpjkp7.Text) +
            cl.cNum(txtb1jpjkp8.Text) + cl.cNum(txtb1jpjkp9.Text) + cl.cNum(txtb1jpjkp10.Text) + cl.cNum(txtb1jpjkp11.Text) + cl.cNum(txtb1jpjkp12.Text) + cl.cNum(txtb1jpjkp13.Text) + cl.cNum(txtb1jpjkp14.Text) + cl.cNum(txtb1jpjkp15.Text)
        txtb1jpjkp16.Text = cl.cCur(totalpph)
        Dim total14 As Decimal
        total14 = cl.cNum(txtb2jml1.Text) + cl.cNum(txtb2jml2.Text)
        txtb2jml3.Text = cl.cCur(total14)

        Dim calcbrutoobj As String
        calcbrutoobj = cl.cNum(txtdjpb1.Text) + cl.cNum(txtdjpb2.Text) + cl.cNum(txtdjpb3.Text) + cl.cNum(txtdjpb4.Text)
        txtdjpb5.Text = cl.cCur(calcbrutoobj)

        Dim calcjppd As String
        calcjppd = cl.cNum(txtdjpjkp1.Text) + cl.cNum(txtdjpjkp2.Text) + cl.cNum(txtdjpjkp3.Text) + cl.cNum(txtdjpjkp4.Text)
        txtdjpjkp5.Text = cl.cCur(calcjppd)
    End Sub
    Private Sub clearData()
        'txtb1kop1.Text = ""
        'txtb1kop2.Text = ""
        'txtb1kop3.Text = ""
        'txtb1kop4.Text = ""
        'txtb1kop5.Text = ""
        'txtb1kop6.Text = ""
        'txtb1kop7.Text = ""
        'txtb1kop8.Text = ""
        'txtb1kop9.Text = ""
        'txtb1kop10.Text = ""
        'txtb1kop11.Text = ""
        'txtb1kop12.Text = ""
        'txtb1kop13.Text = ""
        'txtb1kop14.Text = ""
        'txtb1kop15.Text = ""
        'txtb1kop16.Text = ""
        txtb1jpp1.Text = ""
        txtb1jpp2.Text = ""
        txtb1jpp3.Text = ""
        txtb1jpp4.Text = ""
        txtb1jpp5.Text = ""
        txtb1jpp6.Text = ""
        txtb1jpp7.Text = ""
        txtb1jpp8.Text = ""
        txtb1jpp9.Text = ""
        txtb1jpp10.Text = ""
        txtb1jpp11.Text = ""
        txtb1jpp12.Text = ""
        txtb1jpp13.Text = ""
        txtb1jpp14.Text = ""
        txtb1jpp15.Text = ""
        txtb1jpp16.Text = ""
        txtb1jpb1.Text = ""
        txtb1jpb2.Text = ""
        txtb1jpb3.Text = ""
        txtb1jpb4.Text = ""
        txtb1jpb5.Text = ""
        txtb1jpb6.Text = ""
        txtb1jpb7.Text = ""
        txtb1jpb8.Text = ""
        txtb1jpb9.Text = ""
        txtb1jpb10.Text = ""
        txtb1jpb11.Text = ""
        txtb1jpb12.Text = ""
        txtb1jpb13.Text = ""
        txtb1jpb14.Text = ""
        txtb1jpb15.Text = ""
        txtb1jpjkp1.Text = ""
        txtb1jpjkp2.Text = ""
        txtb1jpjkp3.Text = ""
        txtb1jpjkp4.Text = ""
        txtb1jpjkp5.Text = ""
        txtb1jpjkp6.Text = ""
        txtb1jpjkp7.Text = ""
        txtb1jpjkp8.Text = ""
        txtb1jpjkp9.Text = ""
        txtb1jpjkp10.Text = ""
        txtb1jpjkp11.Text = ""
        txtb1jpjkp12.Text = ""
        txtb1jpjkp13.Text = ""
        txtb1jpjkp14.Text = ""
        txtb1jpjkp15.Text = ""
        txtb1jpjkp16.Text = ""
        txtb2jml1.Text = ""
        txtb2jml2.Text = ""
        txtb2jml3.Text = ""
        txtb2jml4.Text = ""
        txtb2jml5.Text = ""
        txtb2jml6.Text = ""
        txtb2jml7.Text = ""

        ch1b2.Checked = False
        ch2b2.Checked = False
        ch3b2.Checked = False
        ch4b2.Checked = False
        ch5b2.Checked = False
        ch6b2.Checked = False
        ch7b2.Checked = False
        ch8b2.Checked = False
        ch9b2.Checked = False
        ch10b2.Checked = False
        ch11b2.Checked = False
        ch12b2.Checked = False
        ComboBox1.SelectedIndex = 0


        ComboBox2.SelectedIndex = 0
        txtcnpwp.Text = cl.readData("SELECT npwpttd FROM mprofile WHERE id = 1")
        txtcnama.Text = cl.readData("SELECT namattd FROM mprofile WHERE id = 1")
        dtcdate.Text = ""
        txtctempat.Text = ""

        'txtdkop1.Text = ""
        'txtdkop2.Text = ""
        'txtdkop3.Text = ""
        'txtdkop4.Text = ""
        'txtdkop5.Text = ""
        txtdjpp1.Text = ""
        txtdjpp2.Text = ""
        txtdjpp3.Text = ""
        txtdjpp4.Text = ""
        txtdjpp5.Text = ""
        txtdjpb1.Text = ""
        txtdjpb2.Text = ""
        txtdjpb3.Text = ""
        txtdjpb4.Text = ""
        txtdjpb5.Text = ""
        txtdjpjkp1.Text = ""
        txtdjpjkp2.Text = ""
        txtdjpjkp3.Text = ""
        txtdjpjkp4.Text = ""
        txtdjpjkp5.Text = ""

        chef1721stmspjk.Checked = False
        chef1721stthnmspjk.Checked = False
        chef1721ii.Checked = False
        chef1721iii.Checked = False
        chef1721iiia.Checked = False
        chef1721iv.Checked = False
        chef1721v.Checked = False
        cheskuasakhss.Checked = False
        txtelmbr6.Text = 0
        txtelmbr1.Text = 0
        txtelmbr2.Text = 0
        txtelmbr3.Text = 0
        txtelmbr4.Text = 0
        txtelmbr5.Text = 0

        Label3.Text = masapjk & " - " & cl.cChr(thnpjk)
    End Sub
    Private Sub valicmb()
        If chef1721stmspjk.Checked = True Then
            txtelmbr1.ReadOnly = False
        Else
            txtelmbr1.ReadOnly = True
            txtelmbr1.Text = 0
        End If
        If chef1721stthnmspjk.Checked = True Then
            txtelmbr2.ReadOnly = False
        Else
            txtelmbr2.ReadOnly = True
            txtelmbr2.Text = 0
        End If
        If chef1721ii.Checked = True Then
            txtelmbr3.ReadOnly = False
        Else
            txtelmbr3.ReadOnly = True
            txtelmbr3.Text = 0
        End If
        If chef1721iii.Checked = True Then
            txtelmbr4.ReadOnly = False
        Else
            txtelmbr4.ReadOnly = True
            txtelmbr4.Text = 0
        End If
        If chef1721iiia.Checked = True Then
            txtelmbr5.ReadOnly = False
        Else
            txtelmbr5.ReadOnly = True
            txtelmbr5.Text = 0
        End If
        If chef1721v.Checked = True Then
            txtelmbr6.ReadOnly = False
        Else
            txtelmbr6.ReadOnly = True
            txtelmbr6.Text = 0
        End If
    End Sub
    Private Sub getmth()
        If masapjk = "January" Then
            masapajakint = 1
        ElseIf masapjk = "February" Then
            masapajakint = 2
        ElseIf masapjk = "March" Then
            masapajakint = 3
        ElseIf masapjk = "April" Then
            masapajakint = 4
        ElseIf masapjk = "May" Then
            masapajakint = 5
        ElseIf masapjk = "June" Then
            masapajakint = 6
        ElseIf masapjk = "July" Then
            masapajakint = 7
        ElseIf masapjk = "August" Then
            masapajakint = 8
        ElseIf masapjk = "September" Then
            masapajakint = 9
        ElseIf masapjk = "October" Then
            masapajakint = 10
        ElseIf masapjk = "November" Then
            masapajakint = 11
        ElseIf masapjk = "December" Then
            masapajakint = 12
        End If
    End Sub
    'Private Sub loaddata()
    '    txtb1kop1.Text =
    '    txtb1kop2.Text = ""
    '    txtb1kop3.Text = ""
    '    txtb1kop4.Text = ""
    '    txtb1kop5.Text = ""
    '    txtb1kop6.Text = ""
    '    txtb1kop7.Text = ""
    '    txtb1kop8.Text = ""
    '    txtb1kop9.Text = ""
    '    txtb1kop10.Text = ""
    '    txtb1kop11.Text = ""
    '    txtb1kop12.Text = ""
    '    txtb1kop13.Text = ""
    '    txtb1kop14.Text = ""
    '    txtb1kop15.Text = ""
    '    txtb1kop16.Text = ""
    'End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        With cl

            '------ start validasi
            If validatetxtnull(txtb1jpp1, "Jumlah Penerima Penghasilan Tidak Boleh Kosong!", "Informasi Peringatan") = 1 Then : Exit Sub : End If
            '------ end validasi
            '--------VALIDASI FORM C----------
            '------- Start Validasi ch1
            Dim ch1 As String
            If ch1b2.Checked = True Then
                ch1 = "Y"
            Else
                ch1 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch2
            Dim ch2 As String
            If ch2b2.Checked = True Then
                ch2 = "Y"
            Else
                ch2 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch3
            Dim ch3 As String
            If ch3b2.Checked = True Then
                ch3 = "Y"
            Else
                ch3 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch4
            Dim ch4 As String
            If ch4b2.Checked = True Then
                ch4 = "Y"
            Else
                ch4 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch5
            Dim ch5 As String
            If ch5b2.Checked = True Then
                ch5 = "Y"
            Else
                ch5 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch6
            Dim ch6 As String
            If ch6b2.Checked = True Then
                ch6 = "Y"
            Else
                ch6 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch7
            Dim ch7 As String
            If ch7b2.Checked = True Then
                ch7 = "Y"
            Else
                ch7 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch8
            Dim ch8 As String
            If ch8b2.Checked = True Then
                ch8 = "Y"
            Else
                ch8 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch9
            Dim ch9 As String
            If ch9b2.Checked = True Then
                ch9 = "Y"
            Else
                ch9 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch10
            Dim ch10 As String
            If ch10b2.Checked = True Then
                ch10 = "Y"
            Else
                ch10 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch11
            Dim ch11 As String
            If ch11b2.Checked = True Then
                ch11 = "Y"
            Else
                ch11 = "N"
            End If
            '------- End Validasi
            '------- Start Validasi ch12
            Dim ch12 As String
            If ch12b2.Checked = True Then
                ch12 = "Y"
            Else
                ch12 = "N"
            End If
            '------- End Validasi
            '--------END VALIDASI FORM C----------

            '--------VALIDASI FORM E----------
            '------- Start Validasi chef1721stmspjk
            Dim stmspjk As String
            If chef1721stmspjk.Checked = True Then
                stmspjk = "Y"
            Else
                stmspjk = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721stthnmspjk
            Dim stmspjkthn As String
            If chef1721stthnmspjk.Checked = True Then
                stmspjkthn = "Y"
            Else
                stmspjkthn = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721ii
            Dim stmspjkii As String
            If chef1721ii.Checked = True Then
                stmspjkii = "Y"
            Else
                stmspjkii = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721ii
            Dim stmspjkiii As String
            If chef1721iii.Checked = True Then
                stmspjkiii = "Y"
            Else
                stmspjkiii = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721iiia
            Dim stmspjkiiia As String
            If chef1721iiia.Checked = True Then
                stmspjkiiia = "Y"
            Else
                stmspjkiiia = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721iv
            Dim stmspjkiv As String
            If chef1721iv.Checked = True Then
                stmspjkiv = "Y"
            Else
                stmspjkiv = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chef1721v
            Dim stmspjkv As String
            If chef1721v.Checked = True Then
                stmspjkv = "Y"
            Else
                stmspjkv = "N"
            End If
            '------- End Validasi
            '------- Start Validasi cheskuasakhss
            Dim kuasakhss As String
            If cheskuasakhss.Checked = True Then
                kuasakhss = "Y"
            Else
                kuasakhss = "N"
            End If
            '------- End Validasi
            '------- Start Validasi chelembar
            'Dim lembar As String
            'If chelembar.Checked = True Then
            '    lembar = "Y"
            'Else
            '    lembar = "N"
            'End If
            '------- End Validasi
            '--------END VALIDASI FORM E----------

            If btnsave.Text = "Save" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canadd from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tspt21induk'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Simpan data : " & txtb1jpp1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stspt21induk (" &
                        " '" & .cChr(txtb1kop1.Text) & "'" &
                        " , '" & .cChr(txtb1kop2.Text) & "'" &
                        " , '" & .cChr(txtb1kop3.Text) & "'" &
                        " , '" & .cChr(txtb1kop4.Text) & "'" &
                        " , '" & .cChr(txtb1kop5.Text) & "'" &
                        " , '" & .cChr(txtb1kop6.Text) & "'" &
                        " , '" & .cChr(txtb1kop7.Text) & "'" &
                        " , '" & .cChr(txtb1kop8.Text) & "'" &
                        " , '" & .cChr(txtb1kop9.Text) & "'" &
                        " , '" & .cChr(txtb1kop10.Text) & "'" &
                        " , '" & .cChr(txtb1kop11.Text) & "'" &
                        " , '" & .cChr(txtb1kop12.Text) & "'" &
                        " , '" & .cChr(txtb1kop13.Text) & "'" &
                        " , '" & .cChr(txtb1kop14.Text) & "'" &
                        " , '" & .cChr(txtb1kop15.Text) & "'" &
                        " , '" & .cChr(txtb1kop16.Text) & "'" &
                        " , '" & .cNum(txtb1jpp1.Text) & "'" &
                        " , '" & .cNum(txtb1jpp2.Text) & "'" &
                        " , '" & .cNum(txtb1jpp3.Text) & "'" &
                        " , '" & .cNum(txtb1jpp4.Text) & "'" &
                        " , '" & .cNum(txtb1jpp5.Text) & "'" &
                        " , '" & .cNum(txtb1jpp6.Text) & "'" &
                        " , '" & .cNum(txtb1jpp7.Text) & "'" &
                        " , '" & .cNum(txtb1jpp8.Text) & "'" &
                        " , '" & .cNum(txtb1jpp9.Text) & "'" &
                        " , '" & .cNum(txtb1jpp10.Text) & "'" &
                        " , '" & .cNum(txtb1jpp11.Text) & "'" &
                        " , '" & .cNum(txtb1jpp12.Text) & "'" &
                        " , '" & .cNum(txtb1jpp13.Text) & "'" &
                        " , '" & .cNum(txtb1jpp14.Text) & "'" &
                        " , '" & .cNum(txtb1jpp15.Text) & "'" &
                        " , '" & .cNum(txtb1jpp16.Text) & "'" &
                        " , '" & .cNum(txtb1jpb1.Text) & "'" &
                        " , '" & .cNum(txtb1jpb2.Text) & "'" &
                        " , '" & .cNum(txtb1jpb3.Text) & "'" &
                        " , '" & .cNum(txtb1jpb4.Text) & "'" &
                        " , '" & .cNum(txtb1jpb5.Text) & "'" &
                        " , '" & .cNum(txtb1jpb6.Text) & "'" &
                        " , '" & .cNum(txtb1jpb7.Text) & "'" &
                        " , '" & .cNum(txtb1jpb8.Text) & "'" &
                        " , '" & .cNum(txtb1jpb9.Text) & "'" &
                        " , '" & .cNum(txtb1jpb10.Text) & "'" &
                        " , '" & .cNum(txtb1jpb11.Text) & "'" &
                        " , '" & .cNum(txtb1jpb12.Text) & "'" &
                        " , '" & .cNum(txtb1jpb13.Text) & "'" &
                        " , '" & .cNum(txtb1jpb14.Text) & "'" &
                        " , '" & .cNum(txtb1jpb15.Text) & "'" &
                        " , '" & .cNum(txtb1jpb16.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp1.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp2.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp3.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp4.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp5.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp6.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp7.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp8.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp9.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp10.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp11.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp12.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp13.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp14.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp15.Text) & "'" &
                        " , '" & .cNum(txtb1jpjkp16.Text) & "'" &
                        " , '" & .cNum(txtb2jml1.Text) & "'" &
                        " , '" & .cNum(txtb2jml2.Text) & "'" &
                        " , '" & .cNum(txtb2jml3.Text) & "'" &
                        " , '" & .cNum(txtb2jml4.Text) & "'" &
                        " , '" & .cNum(txtb2jml5.Text) & "'" &
                        " , '" & .cNum(txtb2jml6.Text) & "'" &
                        " , '" & .cNum(txtb2jml7.Text) & "'" &
                        " , '" & ch1 & "'" &
                        " , '" & ch2 & "'" &
                        " , '" & ch3 & "'" &
                        " , '" & ch4 & "'" &
                        " , '" & ch5 & "'" &
                        " , '" & ch6 & "'" &
                        " , '" & ch7 & "'" &
                        " , '" & ch8 & "'" &
                        " , '" & ch9 & "'" &
                        " , '" & ch10 & "'" &
                        " , '" & ch11 & "'" &
                        " , '" & ch12 & "'" &
                        " , '" & .cChr(txtcnpwp.Text) & "'" &
                        " , '" & .cChr(txtcnama.Text) & "'" &
                        " , '" & .cChr(dtcdate.Text) & "'" &
                        " , '" & .cChr(txtctempat.Text) & "'" &
                        " , '" & .cChr(txtdkop1.Text) & "'" &
                        " , '" & .cChr(txtdkop2.Text) & "'" &
                        " , '" & .cChr(txtdkop3.Text) & "'" &
                        " , '" & .cChr(txtdkop4.Text) & "'" &
                        " , '" & .cChr(txtdkop5.Text) & "'" &
                        " , '" & .cNum(txtdjpp1.Text) & "'" &
                        " , '" & .cNum(txtdjpp2.Text) & "'" &
                        " , '" & .cNum(txtdjpp3.Text) & "'" &
                        " , '" & .cNum(txtdjpp4.Text) & "'" &
                        " , '" & .cNum(txtdjpp5.Text) & "'" &
                        " , '" & .cNum(txtdjpb1.Text) & "'" &
                        " , '" & .cNum(txtdjpb2.Text) & "'" &
                        " , '" & .cNum(txtdjpb3.Text) & "'" &
                        " , '" & .cNum(txtdjpb4.Text) & "'" &
                        " , '" & .cNum(txtdjpb5.Text) & "'" &
                        " , '" & .cNum(txtdjpjkp1.Text) & "'" &
                        " , '" & .cNum(txtdjpjkp2.Text) & "'" &
                        " , '" & .cNum(txtdjpjkp3.Text) & "'" &
                        " , '" & .cNum(txtdjpjkp4.Text) & "'" &
                        " , '" & .cNum(txtdjpjkp5.Text) & "'" &
                        " , '" & stmspjk & "'" &
                        " , '" & stmspjkthn & "'" &
                        " , '" & stmspjkii & "'" &
                        " , '" & stmspjkiii & "'" &
                        " , '" & stmspjkiiia & "'" &
                        " , '" & stmspjkiv & "'" &
                        " , '" & stmspjkv & "'" &
                        " , '" & kuasakhss & "'" &
                        " , '" & .cNum(txtelmbr6.Text) & "'" &
                        " , '" & .cNum(txtelmbr1.Text) & "'" &
                        " , '" & .cNum(txtelmbr2.Text) & "'" &
                        " , '" & .cNum(txtelmbr3.Text) & "'" &
                        " , '" & .cNum(txtelmbr4.Text) & "'" &
                        " , '" & .cNum(txtelmbr5.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'BARU'" &
                        " , '0'" &
                        ")")

                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Simpan Data : " & txtb1jpp1.Text & " !", "Informasi")
                        changestatform("new")
                    End If
                End If
            ElseIf btnsave.Text = "Update" Then
                '----------USER AUTHORIZATION CHECK--------------'
                If .readData("SELECT canupdate from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tspt21induk'") = "N" Then
                    .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                    Exit Sub
                End If
                '---------------------END------------------------'
                Dim tny As Integer
                tny = .msgYesNo("Update data : " & txtb1jpp1.Text & " ?", "Konfirmasi")
                If tny = vbYes Then
                    .openTrans()
                    .execCmdTrans(
                        "CALL stspt21induk (" &
                        " '" & .cChr(txtb1kop1.Text) & "'" &
                        " , '" & .cChr(txtb1kop2.Text) & "'" &
                        " , '" & .cChr(txtb1kop3.Text) & "'" &
                        " , '" & .cChr(txtb1kop4.Text) & "'" &
                        " , '" & .cChr(txtb1kop5.Text) & "'" &
                        " , '" & .cChr(txtb1kop6.Text) & "'" &
                        " , '" & .cChr(txtb1kop7.Text) & "'" &
                        " , '" & .cChr(txtb1kop8.Text) & "'" &
                        " , '" & .cChr(txtb1kop9.Text) & "'" &
                        " , '" & .cChr(txtb1kop10.Text) & "'" &
                        " , '" & .cChr(txtb1kop11.Text) & "'" &
                        " , '" & .cChr(txtb1kop12.Text) & "'" &
                        " , '" & .cChr(txtb1kop13.Text) & "'" &
                        " , '" & .cChr(txtb1kop14.Text) & "'" &
                        " , '" & .cChr(txtb1kop15.Text) & "'" &
                        " , '" & .cChr(txtb1kop16.Text) & "'" &
                        " , '" & .cChr(txtb1jpp1.Text) & "'" &
                        " , '" & .cChr(txtb1jpp2.Text) & "'" &
                        " , '" & .cChr(txtb1jpp3.Text) & "'" &
                        " , '" & .cChr(txtb1jpp4.Text) & "'" &
                        " , '" & .cChr(txtb1jpp5.Text) & "'" &
                        " , '" & .cChr(txtb1jpp6.Text) & "'" &
                        " , '" & .cChr(txtb1jpp7.Text) & "'" &
                        " , '" & .cChr(txtb1jpp8.Text) & "'" &
                        " , '" & .cChr(txtb1jpp9.Text) & "'" &
                        " , '" & .cChr(txtb1jpp10.Text) & "'" &
                        " , '" & .cChr(txtb1jpp11.Text) & "'" &
                        " , '" & .cChr(txtb1jpp12.Text) & "'" &
                        " , '" & .cChr(txtb1jpp13.Text) & "'" &
                        " , '" & .cChr(txtb1jpp14.Text) & "'" &
                        " , '" & .cChr(txtb1jpp15.Text) & "'" &
                        " , '" & .cChr(txtb1jpp16.Text) & "'" &
                        " , '" & .cChr(txtb1jpb1.Text) & "'" &
                        " , '" & .cChr(txtb1jpb2.Text) & "'" &
                        " , '" & .cChr(txtb1jpb3.Text) & "'" &
                        " , '" & .cChr(txtb1jpb4.Text) & "'" &
                        " , '" & .cChr(txtb1jpb5.Text) & "'" &
                        " , '" & .cChr(txtb1jpb6.Text) & "'" &
                        " , '" & .cChr(txtb1jpb7.Text) & "'" &
                        " , '" & .cChr(txtb1jpb8.Text) & "'" &
                        " , '" & .cChr(txtb1jpb9.Text) & "'" &
                        " , '" & .cChr(txtb1jpb10.Text) & "'" &
                        " , '" & .cChr(txtb1jpb11.Text) & "'" &
                        " , '" & .cChr(txtb1jpb12.Text) & "'" &
                        " , '" & .cChr(txtb1jpb13.Text) & "'" &
                        " , '" & .cChr(txtb1jpb14.Text) & "'" &
                        " , '" & .cChr(txtb1jpb15.Text) & "'" &
                        " , '" & .cChr(txtb1jpb16.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp1.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp2.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp3.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp4.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp5.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp6.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp7.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp8.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp9.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp10.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp11.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp12.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp13.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp14.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp15.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp16.Text) & "'" &
                        " , '" & .cChr(txtb2jml1.Text) & "'" &
                        " , '" & .cChr(txtb2jml2.Text) & "'" &
                        " , '" & .cChr(txtb2jml3.Text) & "'" &
                        " , '" & .cChr(txtb2jml4.Text) & "'" &
                        " , '" & .cChr(txtb2jml5.Text) & "'" &
                        " , '" & .cChr(txtb2jml6.Text) & "'" &
                        " , '" & .cChr(txtb2jml7.Text) & "'" &
                        " , '" & ch1 & "'" &
                        " , '" & ch2 & "'" &
                        " , '" & ch3 & "'" &
                        " , '" & ch4 & "'" &
                        " , '" & ch5 & "'" &
                        " , '" & ch6 & "'" &
                        " , '" & ch7 & "'" &
                        " , '" & ch8 & "'" &
                        " , '" & ch9 & "'" &
                        " , '" & ch10 & "'" &
                        " , '" & ch11 & "'" &
                        " , '" & ch12 & "'" &
                        " , '" & .cChr(txtcnpwp.Text) & "'" &
                        " , '" & .cChr(txtcnama.Text) & "'" &
                        " , '" & .cChr(dtcdate.Text) & "'" &
                        " , '" & .cChr(txtctempat.Text) & "'" &
                        " , '" & .cChr(txtdkop1.Text) & "'" &
                        " , '" & .cChr(txtdkop2.Text) & "'" &
                        " , '" & .cChr(txtdkop3.Text) & "'" &
                        " , '" & .cChr(txtdkop4.Text) & "'" &
                        " , '" & .cChr(txtdkop5.Text) & "'" &
                        " , '" & .cChr(txtdjpp1.Text) & "'" &
                        " , '" & .cChr(txtdjpp2.Text) & "'" &
                        " , '" & .cChr(txtdjpp3.Text) & "'" &
                        " , '" & .cChr(txtdjpp4.Text) & "'" &
                        " , '" & .cChr(txtdjpp5.Text) & "'" &
                        " , '" & .cChr(txtdjpb1.Text) & "'" &
                        " , '" & .cChr(txtdjpb2.Text) & "'" &
                        " , '" & .cChr(txtdjpb3.Text) & "'" &
                        " , '" & .cChr(txtdjpb4.Text) & "'" &
                        " , '" & .cChr(txtdjpb5.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp1.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp2.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp3.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp4.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp5.Text) & "'" &
                        " , '" & stmspjk & "'" &
                        " , '" & stmspjkthn & "'" &
                        " , '" & stmspjkii & "'" &
                        " , '" & stmspjkiii & "'" &
                        " , '" & stmspjkiiia & "'" &
                        " , '" & stmspjkiv & "'" &
                        " , '" & stmspjkv & "'" &
                        " , '" & kuasakhss & "'" &
                        " , '" & .cChr(txtelmbr6.Text) & "'" &
                        " , '" & .cChr(txtelmbr1.Text) & "'" &
                        " , '" & .cChr(txtelmbr2.Text) & "'" &
                        " , '" & .cChr(txtelmbr3.Text) & "'" &
                        " , '" & .cChr(txtelmbr4.Text) & "'" &
                        " , '" & .cChr(txtelmbr5.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'MODIF'" &
                        " , '" & idmaster & "'" &
                        ")")
                    .closeTrans(btnsave)
                    If .sCloseTrans = 1 Then
                        .msgInform("Berhasil Update : " & txtb1jpp1.Text & " !", "Informasi")
                        changestatform("new") : End If
                End If
            End If
        End With
    End Sub

    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        Dim a As New search

        Dim sql As String = " SELECT TA.* FROM tspt21induk TA WHERE TA.stat = 1"

        With a.dgview : .DataSource = cl.table(sql)
            For i As Integer = 0 To .Columns.Count - 1 : .Columns(i).Visible = False : Next
            .Columns("cnama").Visible = True : .Columns("cnama").HeaderText = "Nama"
            .Columns("cnpwp").Visible = True : .Columns("cnpwp").HeaderText = "NPWP"
            .Columns("cdate").Visible = True : .Columns("cdate").HeaderText = "Tanggal"

        End With
        a.loadStatusTempForm(Me, Me.txtb1jpp1, "[tspt21induk]tspt21induk")
        a.loadSQLSearch(sql, 1)
        a.Text = "Pencarian Data"  'a.lbltit.Text = "SALES"

        cekform(a, "SEARCH", Me)
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.Dispose()
        Dim frm As New tsptmasa21induk
        cekform(frm, "REFRESH", Me)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        With cl
            '----------USER AUTHORIZATION CHECK--------------'
            If .readData("SELECT candelete from cusrpriv WHERE id_cusr = '" & idusr & "' AND code_capp = 'tspt21induk'") = "N" Then
                .msgError("User tidak dapat melakukan tindakan ini ! Mohon untuk check setting otorisasi !", "Informasi")
                Exit Sub
            End If
            '---------------------END------------------------'
            Dim tny As Integer
            tny = .msgYesNo("Hapus Data : " & txtb1jpp1.Text & " ?", "Konfirmasi")
            If tny = vbYes Then
                .openTrans()
                .execCmdTrans(
                        "CALL stspt21induk (" &
                       " '" & .cChr(txtb1kop1.Text) & "'" &
                        " , '" & .cChr(txtb1kop2.Text) & "'" &
                        " , '" & .cChr(txtb1kop3.Text) & "'" &
                        " , '" & .cChr(txtb1kop4.Text) & "'" &
                        " , '" & .cChr(txtb1kop5.Text) & "'" &
                        " , '" & .cChr(txtb1kop6.Text) & "'" &
                        " , '" & .cChr(txtb1kop7.Text) & "'" &
                        " , '" & .cChr(txtb1kop8.Text) & "'" &
                        " , '" & .cChr(txtb1kop9.Text) & "'" &
                        " , '" & .cChr(txtb1kop10.Text) & "'" &
                        " , '" & .cChr(txtb1kop11.Text) & "'" &
                        " , '" & .cChr(txtb1kop12.Text) & "'" &
                        " , '" & .cChr(txtb1kop13.Text) & "'" &
                        " , '" & .cChr(txtb1kop14.Text) & "'" &
                        " , '" & .cChr(txtb1kop15.Text) & "'" &
                        " , '" & .cChr(txtb1kop16.Text) & "'" &
                        " , '" & .cChr(txtb1jpp1.Text) & "'" &
                        " , '" & .cChr(txtb1jpp2.Text) & "'" &
                        " , '" & .cChr(txtb1jpp3.Text) & "'" &
                        " , '" & .cChr(txtb1jpp4.Text) & "'" &
                        " , '" & .cChr(txtb1jpp5.Text) & "'" &
                        " , '" & .cChr(txtb1jpp6.Text) & "'" &
                        " , '" & .cChr(txtb1jpp7.Text) & "'" &
                        " , '" & .cChr(txtb1jpp8.Text) & "'" &
                        " , '" & .cChr(txtb1jpp9.Text) & "'" &
                        " , '" & .cChr(txtb1jpp10.Text) & "'" &
                        " , '" & .cChr(txtb1jpp11.Text) & "'" &
                        " , '" & .cChr(txtb1jpp12.Text) & "'" &
                        " , '" & .cChr(txtb1jpp13.Text) & "'" &
                        " , '" & .cChr(txtb1jpp14.Text) & "'" &
                        " , '" & .cChr(txtb1jpp15.Text) & "'" &
                        " , '" & .cChr(txtb1jpp16.Text) & "'" &
                        " , '" & .cChr(txtb1jpb1.Text) & "'" &
                        " , '" & .cChr(txtb1jpb2.Text) & "'" &
                        " , '" & .cChr(txtb1jpb3.Text) & "'" &
                        " , '" & .cChr(txtb1jpb4.Text) & "'" &
                        " , '" & .cChr(txtb1jpb5.Text) & "'" &
                        " , '" & .cChr(txtb1jpb6.Text) & "'" &
                        " , '" & .cChr(txtb1jpb7.Text) & "'" &
                        " , '" & .cChr(txtb1jpb8.Text) & "'" &
                        " , '" & .cChr(txtb1jpb9.Text) & "'" &
                        " , '" & .cChr(txtb1jpb10.Text) & "'" &
                        " , '" & .cChr(txtb1jpb11.Text) & "'" &
                        " , '" & .cChr(txtb1jpb12.Text) & "'" &
                        " , '" & .cChr(txtb1jpb13.Text) & "'" &
                        " , '" & .cChr(txtb1jpb14.Text) & "'" &
                        " , '" & .cChr(txtb1jpb15.Text) & "'" &
                        " , '" & .cChr(txtb1jpb16.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp1.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp2.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp3.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp4.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp5.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp6.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp7.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp8.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp9.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp10.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp11.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp12.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp13.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp14.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp15.Text) & "'" &
                        " , '" & .cChr(txtb1jpjkp16.Text) & "'" &
                        " , '" & .cChr(txtb2jml1.Text) & "'" &
                        " , '" & .cChr(txtb2jml2.Text) & "'" &
                        " , '" & .cChr(txtb2jml3.Text) & "'" &
                        " , '" & .cChr(txtb2jml4.Text) & "'" &
                        " , '" & .cChr(txtb2jml5.Text) & "'" &
                        " , '" & .cChr(txtb2jml6.Text) & "'" &
                        " , '" & .cChr(txtb2jml7.Text) & "'" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , '" & .cChr(txtcnpwp.Text) & "'" &
                        " , '" & .cChr(txtcnama.Text) & "'" &
                        " , '" & .cChr(dtcdate.Text) & "'" &
                        " , '" & .cChr(txtctempat.Text) & "'" &
                        " , '" & .cChr(txtdkop1.Text) & "'" &
                        " , '" & .cChr(txtdkop2.Text) & "'" &
                        " , '" & .cChr(txtdkop3.Text) & "'" &
                        " , '" & .cChr(txtdkop4.Text) & "'" &
                        " , '" & .cChr(txtdkop5.Text) & "'" &
                        " , '" & .cChr(txtdjpp1.Text) & "'" &
                        " , '" & .cChr(txtdjpp2.Text) & "'" &
                        " , '" & .cChr(txtdjpp3.Text) & "'" &
                        " , '" & .cChr(txtdjpp4.Text) & "'" &
                        " , '" & .cChr(txtdjpp5.Text) & "'" &
                        " , '" & .cChr(txtdjpb1.Text) & "'" &
                        " , '" & .cChr(txtdjpb2.Text) & "'" &
                        " , '" & .cChr(txtdjpb3.Text) & "'" &
                        " , '" & .cChr(txtdjpb4.Text) & "'" &
                        " , '" & .cChr(txtdjpb5.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp1.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp2.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp3.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp4.Text) & "'" &
                        " , '" & .cChr(txtdjpjkp5.Text) & "'" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , ''" &
                        " , '" & .cChr(txtelmbr1.Text) & "'" &
                        " , '" & .cChr(txtelmbr2.Text) & "'" &
                        " , '" & .cChr(txtelmbr3.Text) & "'" &
                        " , '" & .cChr(txtelmbr4.Text) & "'" &
                        " , '" & .cChr(txtelmbr5.Text) & "'" &
                        " ,'" & masapjk & "'" &
                        " ,'" & thnpjk & "'" &
                        " , ''" &
                        " , '" & idusr & "'" &
                        " , 'HAPUS'" &
                        " , '" & idmaster & "'" &
                        ")")
                .closeTrans(btnsave)
                If .sCloseTrans = 1 Then
                    .msgInform("Berhasil Hapus Data : " & txtb1jpp1.Text & " !", "Informasi")
                    changestatform("new") : End If
            End If
        End With
    End Sub
    Private Sub txtb2jml1_TextChanged(sender As Object, e As EventArgs) Handles txtb2jml1.TextChanged
        calculated()
    End Sub

    Private Sub txtb2jml2_TextChanged(sender As Object, e As EventArgs) Handles txtb2jml2.TextChanged
        calculated()
    End Sub

    Private Sub chef1721stmspjk_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721stmspjk.CheckedChanged
        valicmb()
    End Sub

    Private Sub chef1721stthnmspjk_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721stthnmspjk.CheckedChanged
        valicmb()
    End Sub

    Private Sub chef1721ii_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721ii.CheckedChanged
        valicmb()
    End Sub

    Private Sub chef1721iii_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721iii.CheckedChanged
        valicmb()
    End Sub

    Private Sub chef1721iiia_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721iiia.CheckedChanged
        valicmb()
    End Sub

    Private Sub chef1721v_CheckedChanged(sender As Object, e As EventArgs) Handles chef1721v.CheckedChanged
        valicmb()
    End Sub

    Private Sub txtb1jpb1_TextChanged(sender As Object, e As EventArgs) Handles txtb1jpb1.TextChanged

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
End Class