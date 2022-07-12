<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mpenghasila2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mpenghasila2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtnpwp = New clopalem.txtFree()
        Me.btnlist = New clopalem.btnList()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtnama = New clopalem.txtFree()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtnik = New clopalem.txtFree()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname_mgolongan = New clopalem.txtFree()
        Me.txtalamat = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnip = New clopalem.txtFree()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbtgngan = New System.Windows.Forms.ComboBox()
        Me.cmbid_mgolongan = New System.Windows.Forms.ComboBox()
        Me.txtname_mjabatan = New clopalem.txtFree()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(136, 472)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 101
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
        Me.btndelete.Location = New System.Drawing.Point(320, 472)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 46)
        Me.btndelete.TabIndex = 103
        Me.btndelete.Text = "Hapus"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(34, 472)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 7
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
        Me.btncancel.Location = New System.Drawing.Point(523, 472)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtnpwp
        '
        Me.txtnpwp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwp.Location = New System.Drawing.Point(40, 89)
        Me.txtnpwp.MaxLength = 16
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.Size = New System.Drawing.Size(227, 30)
        Me.txtnpwp.TabIndex = 1
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(241, 472)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 102
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(428, 490)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(52, 19)
        Me.lblcode.TabIndex = 140
        Me.lblcode.Text = "lblcode"
        Me.lblcode.Visible = False
        '
        'lbluseractivity
        '
        Me.lbluseractivity.AutoSize = True
        Me.lbluseractivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluseractivity.Location = New System.Drawing.Point(37, 454)
        Me.lbluseractivity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbluseractivity.Name = "lbluseractivity"
        Me.lbluseractivity.Size = New System.Drawing.Size(110, 18)
        Me.lbluseractivity.TabIndex = 400
        Me.lbluseractivity.Text = "lbluseractivity"
        Me.lbluseractivity.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(229, 48)
        Me.Label28.TabIndex = 401
        Me.Label28.Text = "PEGAWAI A2"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(36, 67)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 25)
        Me.Label30.TabIndex = 404
        Me.Label30.Text = "NPWP"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.SystemColors.Window
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(40, 140)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(227, 30)
        Me.txtnama.TabIndex = 405
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(312, 66)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 25)
        Me.Label31.TabIndex = 406
        Me.Label31.Text = "NIK"
        '
        'txtnik
        '
        Me.txtnik.BackColor = System.Drawing.SystemColors.Window
        Me.txtnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(315, 89)
        Me.txtnik.MaxLength = 16
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(227, 30)
        Me.txtnik.TabIndex = 407
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "Golongan/Pangkat"
        '
        'txtname_mgolongan
        '
        Me.txtname_mgolongan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtname_mgolongan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname_mgolongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_mgolongan.Location = New System.Drawing.Point(41, 358)
        Me.txtname_mgolongan.Name = "txtname_mgolongan"
        Me.txtname_mgolongan.Size = New System.Drawing.Size(502, 30)
        Me.txtname_mgolongan.TabIndex = 409
        '
        'txtalamat
        '
        Me.txtalamat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(40, 197)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(227, 72)
        Me.txtalamat.TabIndex = 410
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 411
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 25)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "NIP"
        '
        'txtnip
        '
        Me.txtnip.BackColor = System.Drawing.SystemColors.Window
        Me.txtnip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnip.Location = New System.Drawing.Point(315, 140)
        Me.txtnip.MaxLength = 16
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(227, 30)
        Me.txtnip.TabIndex = 413
        '
        'cmbgender
        '
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbgender.Location = New System.Drawing.Point(41, 295)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(227, 33)
        Me.cmbgender.TabIndex = 418
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 25)
        Me.Label7.TabIndex = 419
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Status"
        '
        'cmbstatus
        '
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"K", "TK", "HB"})
        Me.cmbstatus.Location = New System.Drawing.Point(315, 196)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(227, 33)
        Me.cmbstatus.TabIndex = 420
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 25)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "Tanggungan"
        '
        'cmbtgngan
        '
        Me.cmbtgngan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtgngan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbtgngan.FormattingEnabled = True
        Me.cmbtgngan.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmbtgngan.Location = New System.Drawing.Point(316, 250)
        Me.cmbtgngan.Name = "cmbtgngan"
        Me.cmbtgngan.Size = New System.Drawing.Size(227, 33)
        Me.cmbtgngan.TabIndex = 422
        '
        'cmbid_mgolongan
        '
        Me.cmbid_mgolongan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbid_mgolongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbid_mgolongan.FormattingEnabled = True
        Me.cmbid_mgolongan.Location = New System.Drawing.Point(315, 295)
        Me.cmbid_mgolongan.Name = "cmbid_mgolongan"
        Me.cmbid_mgolongan.Size = New System.Drawing.Size(90, 33)
        Me.cmbid_mgolongan.TabIndex = 424
        Me.cmbid_mgolongan.Visible = False
        '
        'txtname_mjabatan
        '
        Me.txtname_mjabatan.BackColor = System.Drawing.SystemColors.Window
        Me.txtname_mjabatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname_mjabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_mjabatan.Location = New System.Drawing.Point(40, 419)
        Me.txtname_mjabatan.Name = "txtname_mjabatan"
        Me.txtname_mjabatan.Size = New System.Drawing.Size(503, 30)
        Me.txtname_mjabatan.TabIndex = 425
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 396)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 426
        Me.Label8.Text = "Jabatan"
        '
        'mpenghasila2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(633, 530)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtname_mjabatan)
        Me.Controls.Add(Me.cmbid_mgolongan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbtgngan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname_mgolongan)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnpwp)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mpenghasila2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnpwp As clopalem.txtFree
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents lblcode As Label
    Friend WithEvents lbluseractivity As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtnama As clopalem.txtFree
    Friend WithEvents Label31 As Label
    Friend WithEvents txtnik As clopalem.txtFree
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname_mgolongan As clopalem.txtFree
    Friend WithEvents txtalamat As clopalem.txtFree
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnip As clopalem.txtFree
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbstatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbtgngan As ComboBox
    Friend WithEvents cmbid_mgolongan As ComboBox
    Friend WithEvents txtname_mjabatan As clopalem.txtFree
    Friend WithEvents Label8 As Label
End Class
