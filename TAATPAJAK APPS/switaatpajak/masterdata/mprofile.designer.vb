﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mprofile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtnama = New clopalem.txtFree()
        Me.btnlist = New clopalem.btnList()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtttl = New clopalem.txtFree()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtnpwp = New clopalem.txtFree()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtnik = New clopalem.txtFree()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpekerjaan = New clopalem.txtFree()
        Me.txtalamat = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname_mnegara = New clopalem.txtFree()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txthp = New clopalem.txtFree()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemaildjp = New clopalem.txtFree()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnamattd = New clopalem.txtFree()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnpwpttd = New clopalem.txtFree()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 67)
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
        Me.btnrefresh.Location = New System.Drawing.Point(136, 514)
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
        Me.btndelete.Location = New System.Drawing.Point(320, 514)
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
        Me.btnsave.Location = New System.Drawing.Point(34, 514)
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
        Me.btncancel.Location = New System.Drawing.Point(523, 514)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.SystemColors.Window
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(40, 89)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(502, 30)
        Me.txtnama.TabIndex = 1
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(241, 514)
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
        Me.lblcode.Location = New System.Drawing.Point(428, 532)
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
        Me.lbluseractivity.Location = New System.Drawing.Point(37, 496)
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
        Me.Label28.Size = New System.Drawing.Size(365, 48)
        Me.Label28.TabIndex = 401
        Me.Label28.Text = "PROFIL WAJIB PAJAK"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(342, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(204, 25)
        Me.Label29.TabIndex = 402
        Me.Label29.Text = "Tempat Tanggal Lahir"
        Me.Label29.Visible = False
        '
        'txtttl
        '
        Me.txtttl.BackColor = System.Drawing.SystemColors.Window
        Me.txtttl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtttl.Location = New System.Drawing.Point(345, 40)
        Me.txtttl.Name = "txtttl"
        Me.txtttl.Size = New System.Drawing.Size(227, 30)
        Me.txtttl.TabIndex = 403
        Me.txtttl.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(36, 118)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 25)
        Me.Label30.TabIndex = 404
        Me.Label30.Text = "NPWP"
        '
        'txtnpwp
        '
        Me.txtnpwp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwp.Location = New System.Drawing.Point(40, 140)
        Me.txtnpwp.MaxLength = 16
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.Size = New System.Drawing.Size(227, 30)
        Me.txtnpwp.TabIndex = 405
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(36, 169)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 25)
        Me.Label31.TabIndex = 406
        Me.Label31.Text = "NIB"
        '
        'txtnik
        '
        Me.txtnik.BackColor = System.Drawing.SystemColors.Window
        Me.txtnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.Location = New System.Drawing.Point(39, 192)
        Me.txtnik.MaxLength = 16
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(227, 30)
        Me.txtnik.TabIndex = 407
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "Jenis Usaha"
        '
        'txtpekerjaan
        '
        Me.txtpekerjaan.BackColor = System.Drawing.SystemColors.Window
        Me.txtpekerjaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpekerjaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpekerjaan.Location = New System.Drawing.Point(39, 250)
        Me.txtpekerjaan.Name = "txtpekerjaan"
        Me.txtpekerjaan.Size = New System.Drawing.Size(227, 30)
        Me.txtpekerjaan.TabIndex = 409
        '
        'txtalamat
        '
        Me.txtalamat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(39, 305)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(503, 72)
        Me.txtalamat.TabIndex = 410
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 282)
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
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Negara"
        '
        'txtname_mnegara
        '
        Me.txtname_mnegara.BackColor = System.Drawing.SystemColors.Window
        Me.txtname_mnegara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname_mnegara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_mnegara.Location = New System.Drawing.Point(315, 140)
        Me.txtname_mnegara.Name = "txtname_mnegara"
        Me.txtname_mnegara.Size = New System.Drawing.Size(227, 30)
        Me.txtname_mnegara.TabIndex = 413
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 25)
        Me.Label5.TabIndex = 414
        Me.Label5.Text = "Nomor Handphone"
        '
        'txthp
        '
        Me.txthp.BackColor = System.Drawing.SystemColors.Window
        Me.txthp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthp.Location = New System.Drawing.Point(315, 192)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(227, 30)
        Me.txthp.TabIndex = 415
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 25)
        Me.Label6.TabIndex = 416
        Me.Label6.Text = "Email DJP Online"
        '
        'txtemaildjp
        '
        Me.txtemaildjp.BackColor = System.Drawing.SystemColors.Window
        Me.txtemaildjp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemaildjp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemaildjp.Location = New System.Drawing.Point(315, 250)
        Me.txtemaildjp.Name = "txtemaildjp"
        Me.txtemaildjp.Size = New System.Drawing.Size(227, 30)
        Me.txtemaildjp.TabIndex = 417
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(216, 25)
        Me.Label7.TabIndex = 420
        Me.Label7.Text = "NPWP Penandatangan"
        '
        'txtnamattd
        '
        Me.txtnamattd.BackColor = System.Drawing.SystemColors.Window
        Me.txtnamattd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnamattd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamattd.Location = New System.Drawing.Point(40, 453)
        Me.txtnamattd.Name = "txtnamattd"
        Me.txtnamattd.Size = New System.Drawing.Size(502, 30)
        Me.txtnamattd.TabIndex = 421
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 25)
        Me.Label8.TabIndex = 418
        Me.Label8.Text = "Nama Penandatangan"
        '
        'txtnpwpttd
        '
        Me.txtnpwpttd.BackColor = System.Drawing.SystemColors.Window
        Me.txtnpwpttd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwpttd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwpttd.Location = New System.Drawing.Point(40, 402)
        Me.txtnpwpttd.MaxLength = 15
        Me.txtnpwpttd.Name = "txtnpwpttd"
        Me.txtnpwpttd.Size = New System.Drawing.Size(502, 30)
        Me.txtnpwpttd.TabIndex = 419
        '
        'mprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(633, 571)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnamattd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnpwpttd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtemaildjp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txthp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtname_mnegara)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpekerjaan)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtnpwp)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtttl)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnama)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mprofile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnama As clopalem.txtFree
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents lblcode As Label
    Friend WithEvents lbluseractivity As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtttl As clopalem.txtFree
    Friend WithEvents Label30 As Label
    Friend WithEvents txtnpwp As clopalem.txtFree
    Friend WithEvents Label31 As Label
    Friend WithEvents txtnik As clopalem.txtFree
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpekerjaan As clopalem.txtFree
    Friend WithEvents txtalamat As clopalem.txtFree
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname_mnegara As clopalem.txtFree
    Friend WithEvents Label5 As Label
    Friend WithEvents txthp As clopalem.txtFree
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemaildjp As clopalem.txtFree
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnamattd As clopalem.txtFree
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnpwpttd As clopalem.txtFree
End Class
