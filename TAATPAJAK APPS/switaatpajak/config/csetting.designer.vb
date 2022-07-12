<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class csetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(csetting))
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chapproval = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcompanyname = New clopalem.txtFree()
        Me.chcompname = New System.Windows.Forms.CheckBox()
        Me.btnbrowsecoa = New clopalem.btnBrowse()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtlogo = New clopalem.txtFree()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chpos = New System.Windows.Forms.CheckBox()
        Me.txtowner = New clopalem.txtFree()
        Me.txtcompany = New clopalem.txtFree()
        Me.txtalamat = New clopalem.txtFree()
        Me.txtphone = New clopalem.txtFree()
        Me.txtNPWP = New clopalem.txtFree()
        Me.txtfax = New clopalem.txtFree()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbjeniscompany = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txtfiskal = New clopalem.txtFree()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(118, 357)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 101
        Me.btnrefresh.Text = "Reset"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        Me.btnrefresh.Visible = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(16, 357)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(568, 357)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informasi"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtfiskal)
        Me.TabPage1.Controls.Add(Me.chapproval)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtcompanyname)
        Me.TabPage1.Controls.Add(Me.chcompname)
        Me.TabPage1.Controls.Add(Me.btnbrowsecoa)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txtlogo)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.chpos)
        Me.TabPage1.Controls.Add(Me.txtowner)
        Me.TabPage1.Controls.Add(Me.txtcompany)
        Me.TabPage1.Controls.Add(Me.txtalamat)
        Me.TabPage1.Controls.Add(Me.txtphone)
        Me.TabPage1.Controls.Add(Me.txtNPWP)
        Me.TabPage1.Controls.Add(Me.txtfax)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmbjeniscompany)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 313)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Company"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chapproval
        '
        Me.chapproval.AutoSize = True
        Me.chapproval.Location = New System.Drawing.Point(453, 253)
        Me.chapproval.Name = "chapproval"
        Me.chapproval.Size = New System.Drawing.Size(110, 17)
        Me.chapproval.TabIndex = 380
        Me.chapproval.Text = "System Approval"
        Me.chapproval.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 379
        Me.Label9.Text = "Brand Name"
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtcompanyname.Location = New System.Drawing.Point(117, 251)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(215, 22)
        Me.txtcompanyname.TabIndex = 378
        '
        'chcompname
        '
        Me.chcompname.AutoSize = True
        Me.chcompname.Location = New System.Drawing.Point(327, 37)
        Me.chcompname.Name = "chcompname"
        Me.chcompname.Size = New System.Drawing.Size(117, 17)
        Me.chcompname.TabIndex = 377
        Me.chcompname.Text = "Tampil di Printout"
        Me.chcompname.UseVisualStyleBackColor = True
        '
        'btnbrowsecoa
        '
        Me.btnbrowsecoa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnbrowsecoa.BackgroundImage = CType(resources.GetObject("btnbrowsecoa.BackgroundImage"), System.Drawing.Image)
        Me.btnbrowsecoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbrowsecoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnbrowsecoa.Location = New System.Drawing.Point(443, 225)
        Me.btnbrowsecoa.Name = "btnbrowsecoa"
        Me.btnbrowsecoa.Size = New System.Drawing.Size(23, 23)
        Me.btnbrowsecoa.TabIndex = 376
        Me.btnbrowsecoa.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(453, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 139)
        Me.PictureBox1.TabIndex = 375
        Me.PictureBox1.TabStop = False
        '
        'txtlogo
        '
        Me.txtlogo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtlogo.Location = New System.Drawing.Point(117, 225)
        Me.txtlogo.Name = "txtlogo"
        Me.txtlogo.ReadOnly = True
        Me.txtlogo.Size = New System.Drawing.Size(320, 22)
        Me.txtlogo.TabIndex = 374
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 325
        Me.Label8.Text = "Logo"
        '
        'chpos
        '
        Me.chpos.AutoSize = True
        Me.chpos.Location = New System.Drawing.Point(352, 253)
        Me.chpos.Name = "chpos"
        Me.chpos.Size = New System.Drawing.Size(85, 17)
        Me.chpos.TabIndex = 373
        Me.chpos.Text = "POS System"
        Me.chpos.UseVisualStyleBackColor = True
        '
        'txtowner
        '
        Me.txtowner.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtowner.Location = New System.Drawing.Point(117, 61)
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(320, 22)
        Me.txtowner.TabIndex = 3
        '
        'txtcompany
        '
        Me.txtcompany.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtcompany.Location = New System.Drawing.Point(117, 35)
        Me.txtcompany.Name = "txtcompany"
        Me.txtcompany.Size = New System.Drawing.Size(204, 22)
        Me.txtcompany.TabIndex = 2
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtalamat.Location = New System.Drawing.Point(117, 87)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(320, 53)
        Me.txtalamat.TabIndex = 4
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtphone.Location = New System.Drawing.Point(117, 144)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(320, 22)
        Me.txtphone.TabIndex = 6
        '
        'txtNPWP
        '
        Me.txtNPWP.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtNPWP.Location = New System.Drawing.Point(117, 197)
        Me.txtNPWP.Name = "txtNPWP"
        Me.txtNPWP.Size = New System.Drawing.Size(320, 22)
        Me.txtNPWP.TabIndex = 8
        '
        'txtfax
        '
        Me.txtfax.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtfax.Location = New System.Drawing.Point(117, 170)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(320, 22)
        Me.txtfax.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jenis Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Perusahaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 303
        Me.Label3.Text = "Alamat"
        '
        'cmbjeniscompany
        '
        Me.cmbjeniscompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjeniscompany.FormattingEnabled = True
        Me.cmbjeniscompany.Items.AddRange(New Object() {"RETAIL", "PRODUKSI", "JASA"})
        Me.cmbjeniscompany.Location = New System.Drawing.Point(117, 10)
        Me.cmbjeniscompany.Name = "cmbjeniscompany"
        Me.cmbjeniscompany.Size = New System.Drawing.Size(320, 21)
        Me.cmbjeniscompany.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Nama Pemilik"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 312
        Me.Label7.Text = "NPWP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 310
        Me.Label6.Text = "Fax"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 339)
        Me.TabControl1.TabIndex = 324
        '
        'txtfiskal
        '
        Me.txtfiskal.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtfiskal.Location = New System.Drawing.Point(117, 277)
        Me.txtfiskal.MaxLength = 4
        Me.txtfiskal.Name = "txtfiskal"
        Me.txtfiskal.Size = New System.Drawing.Size(215, 22)
        Me.txtfiskal.TabIndex = 381
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 382
        Me.Label10.Text = "Periode Fiskal"
        '
        'csetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(689, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "csetting"
        Me.Text = "General Settings"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtowner As clopalem.txtFree
    Friend WithEvents txtcompany As clopalem.txtFree
    Friend WithEvents txtalamat As clopalem.txtFree
    Friend WithEvents txtphone As clopalem.txtFree
    Friend WithEvents txtNPWP As clopalem.txtFree
    Friend WithEvents txtfax As clopalem.txtFree
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbjeniscompany As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents chpos As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtlogo As clopalem.txtFree
    Friend WithEvents Label8 As Label
    Friend WithEvents btnbrowsecoa As clopalem.btnBrowse
    Friend WithEvents chcompname As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcompanyname As clopalem.txtFree
    Friend WithEvents chapproval As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfiskal As clopalem.txtFree
End Class
