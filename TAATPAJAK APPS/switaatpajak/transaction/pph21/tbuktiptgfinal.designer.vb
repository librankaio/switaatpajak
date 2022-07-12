<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tbuktiptgfinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tbuktiptgfinal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnobkt = New clopalem.txtFree()
        Me.txtnobkt_rl = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnpwp = New clopalem.txtFree()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnama = New clopalem.txtFree()
        Me.txtnikpssprt = New clopalem.txtFree()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtalamat = New clopalem.txtFree()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtobjpjk = New clopalem.txtFree()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnpwpptg = New clopalem.txtFree()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnamaptg = New clopalem.txtFree()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.btnsave = New clopalem.btnSave()
        Me.btnlist = New clopalem.btnList()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btncancel = New clopalem.btnCancel()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.dttdate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnfilter2 = New clopalem.btnBrowse()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnprint = New clopalem.btnPrint()
        Me.BtnBrowse1 = New clopalem.btnBrowse()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(530, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BUKTI PEMOTONGAN PAJAK PENGHASILAN PASAL 21(FINAL)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Bukti Potong"
        '
        'txtnobkt
        '
        Me.txtnobkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnobkt.Location = New System.Drawing.Point(172, 51)
        Me.txtnobkt.Name = "txtnobkt"
        Me.txtnobkt.Size = New System.Drawing.Size(100, 26)
        Me.txtnobkt.TabIndex = 3
        '
        'txtnobkt_rl
        '
        Me.txtnobkt_rl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnobkt_rl.Location = New System.Drawing.Point(294, 51)
        Me.txtnobkt_rl.Name = "txtnobkt_rl"
        Me.txtnobkt_rl.Size = New System.Drawing.Size(228, 26)
        Me.txtnobkt_rl.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(504, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "A. IDENTITAS PENERIMA PENGHASILAN YANG DIPOTONG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "NPWP"
        '
        'txtnpwp
        '
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwp.Location = New System.Drawing.Point(172, 112)
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.ReadOnly = True
        Me.txtnpwp.Size = New System.Drawing.Size(222, 26)
        Me.txtnpwp.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(23, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(172, 144)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(350, 26)
        Me.txtnama.TabIndex = 9
        '
        'txtnikpssprt
        '
        Me.txtnikpssprt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnikpssprt.Location = New System.Drawing.Point(172, 176)
        Me.txtnikpssprt.Name = "txtnikpssprt"
        Me.txtnikpssprt.ReadOnly = True
        Me.txtnikpssprt.Size = New System.Drawing.Size(350, 26)
        Me.txtnikpssprt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "NIK / No.Paspor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(483, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "B. PPh PASAL 21 DAN/ATAU PASAL 26 YANG DIPOTONG"
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(172, 208)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ReadOnly = True
        Me.txtalamat.Size = New System.Drawing.Size(350, 63)
        Me.txtalamat.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(23, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Alamat"
        '
        'txtobjpjk
        '
        Me.txtobjpjk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobjpjk.Location = New System.Drawing.Point(172, 319)
        Me.txtobjpjk.Name = "txtobjpjk"
        Me.txtobjpjk.ReadOnly = True
        Me.txtobjpjk.Size = New System.Drawing.Size(391, 26)
        Me.txtobjpjk.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(24, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Objek Pajak"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(23, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "C.IDENTITAS PEMOTONG"
        '
        'txtnpwpptg
        '
        Me.txtnpwpptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwpptg.Location = New System.Drawing.Point(155, 501)
        Me.txtnpwpptg.Name = "txtnpwpptg"
        Me.txtnpwpptg.Size = New System.Drawing.Size(146, 26)
        Me.txtnpwpptg.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(20, 506)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "NPWP"
        '
        'txtnamaptg
        '
        Me.txtnamaptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaptg.Location = New System.Drawing.Point(155, 533)
        Me.txtnamaptg.Name = "txtnamaptg"
        Me.txtnamaptg.Size = New System.Drawing.Size(408, 26)
        Me.txtnamaptg.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(20, 539)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Nama"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(307, 506)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Tanggal"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(402, 601)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(41, 13)
        Me.lblcode.TabIndex = 155
        Me.lblcode.Text = "lblcode"
        Me.lblcode.Visible = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(8, 583)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 150
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(215, 583)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 152
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(110, 583)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 151
        Me.btnrefresh.Text = "Reset"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(294, 583)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 46)
        Me.btndelete.TabIndex = 153
        Me.btndelete.Text = "Hapus"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(632, 583)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 154
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'dgview
        '
        Me.dgview.AllowUserToOrderColumns = True
        Me.dgview.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(23, 351)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(698, 119)
        Me.dgview.TabIndex = 328
        '
        'dttdate
        '
        Me.dttdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dttdate.CustomFormat = "dd/MM/yyyy"
        Me.dttdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttdate.Location = New System.Drawing.Point(378, 499)
        Me.dttdate.Margin = New System.Windows.Forms.Padding(2)
        Me.dttdate.Name = "dttdate"
        Me.dttdate.Size = New System.Drawing.Size(185, 29)
        Me.dttdate.TabIndex = 429
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(154, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 16)
        Me.Label14.TabIndex = 430
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(154, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 16)
        Me.Label15.TabIndex = 431
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(154, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 16)
        Me.Label16.TabIndex = 432
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(154, 186)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 16)
        Me.Label17.TabIndex = 433
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(154, 214)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 16)
        Me.Label18.TabIndex = 434
        Me.Label18.Text = ":"
        '
        'btnfilter2
        '
        Me.btnfilter2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnfilter2.BackgroundImage = CType(resources.GetObject("btnfilter2.BackgroundImage"), System.Drawing.Image)
        Me.btnfilter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnfilter2.Location = New System.Drawing.Point(400, 114)
        Me.btnfilter2.Name = "btnfilter2"
        Me.btnfilter2.Size = New System.Drawing.Size(23, 23)
        Me.btnfilter2.TabIndex = 435
        Me.btnfilter2.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(276, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 16)
        Me.Label19.TabIndex = 436
        Me.Label19.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(154, 325)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(12, 16)
        Me.Label20.TabIndex = 437
        Me.Label20.Text = ":"
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnprint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprint.Location = New System.Drawing.Point(390, 583)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(83, 46)
        Me.btnprint.TabIndex = 156
        Me.btnprint.Text = "Cetak"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'BtnBrowse1
        '
        Me.BtnBrowse1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnBrowse1.BackgroundImage = CType(resources.GetObject("BtnBrowse1.BackgroundImage"), System.Drawing.Image)
        Me.BtnBrowse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBrowse1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse1.Location = New System.Drawing.Point(569, 321)
        Me.BtnBrowse1.Name = "BtnBrowse1"
        Me.BtnBrowse1.Size = New System.Drawing.Size(23, 23)
        Me.BtnBrowse1.TabIndex = 444
        Me.BtnBrowse1.UseVisualStyleBackColor = False
        '
        'tbuktiptgfinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 645)
        Me.Controls.Add(Me.BtnBrowse1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnfilter2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dttdate)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnamaptg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtnpwpptg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtobjpjk)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnikpssprt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnpwp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnobkt_rl)
        Me.Controls.Add(Me.txtnobkt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "tbuktiptgfinal"
        Me.Text = "Input Bukti Potong Final"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtnobkt As clopalem.txtFree
    Friend WithEvents txtnobkt_rl As clopalem.txtFree
    Friend WithEvents txtnpwp As clopalem.txtFree
    Friend WithEvents txtnama As clopalem.txtFree
    Friend WithEvents txtnikpssprt As clopalem.txtFree
    Friend WithEvents txtalamat As clopalem.txtFree
    Friend WithEvents txtobjpjk As clopalem.txtFree
    Friend WithEvents txtnpwpptg As clopalem.txtFree
    Friend WithEvents txtnamaptg As clopalem.txtFree
    Friend WithEvents lblcode As Label
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents dgview As DataGridView
    Friend WithEvents dttdate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnfilter2 As clopalem.btnBrowse
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnprint As clopalem.btnPrint
    Friend WithEvents BtnBrowse1 As clopalem.btnBrowse
End Class
