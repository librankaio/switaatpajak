<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mssp_baru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mssp_baru))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsave = New clopalem.btnSave()
        Me.btnlist = New clopalem.btnList()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btncancel = New clopalem.btnCancel()
        Me.btnsearch = New clopalem.btnBrowse()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkdobj = New clopalem.txtFree()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtdeskripsi = New clopalem.txtFree()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkode = New clopalem.txtFree()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 102)
        Me.Panel2.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(533, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 28)
        Me.Button3.TabIndex = 405
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(492, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 28)
        Me.Button2.TabIndex = 404
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(451, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 403
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(12, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(142, 37)
        Me.Label28.TabIndex = 402
        Me.Label28.Text = "KODE SSP"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 46)
        Me.Panel3.TabIndex = 406
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtkdobj)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.txtdeskripsi)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtkode)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnlist)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 262)
        Me.Panel1.TabIndex = 3
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(20, 198)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 429
        Me.btnsave.Text = "Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(227, 198)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 431
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(122, 198)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 430
        Me.btnrefresh.Text = "Reset"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(306, 198)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 46)
        Me.btndelete.TabIndex = 432
        Me.btndelete.Text = "Hapus"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(479, 198)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 433
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsearch.BackgroundImage = CType(resources.GetObject("btnsearch.BackgroundImage"), System.Drawing.Image)
        Me.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(545, 39)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(23, 23)
        Me.btnsearch.TabIndex = 474
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 472
        Me.Label3.Text = "Kode Objek"
        '
        'txtkdobj
        '
        Me.txtkdobj.BackColor = System.Drawing.SystemColors.Window
        Me.txtkdobj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkdobj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdobj.Location = New System.Drawing.Point(19, 36)
        Me.txtkdobj.Name = "txtkdobj"
        Me.txtkdobj.ReadOnly = True
        Me.txtkdobj.Size = New System.Drawing.Size(508, 26)
        Me.txtkdobj.TabIndex = 473
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(15, 116)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 20)
        Me.Label30.TabIndex = 470
        Me.Label30.Text = "Deskripsi"
        '
        'txtdeskripsi
        '
        Me.txtdeskripsi.BackColor = System.Drawing.SystemColors.Window
        Me.txtdeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdeskripsi.Location = New System.Drawing.Point(19, 139)
        Me.txtdeskripsi.Name = "txtdeskripsi"
        Me.txtdeskripsi.Size = New System.Drawing.Size(550, 26)
        Me.txtdeskripsi.TabIndex = 471
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 468
        Me.Label1.Text = "Kode"
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.SystemColors.Window
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(20, 88)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(550, 26)
        Me.txtkode.TabIndex = 469
        '
        'mssp_baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 364)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mssp_baru"
        Me.Text = "mssp_baru"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsearch As clopalem.btnBrowse
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkdobj As clopalem.txtFree
    Friend WithEvents Label30 As Label
    Friend WithEvents txtdeskripsi As clopalem.txtFree
    Friend WithEvents Label1 As Label
    Friend WithEvents txtkode As clopalem.txtFree
End Class
