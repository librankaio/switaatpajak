<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usr))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtname = New clopalem.txtFree()
        Me.txtnote = New clopalem.txtNote()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtcode = New clopalem.txtFree()
        Me.btnresetpass = New clopalem.btnBlank()
        Me.btnlist = New clopalem.btnList()
        Me.chsadmin = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chshowmenu = New System.Windows.Forms.CheckBox()
        Me.txtapppass = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 39)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "PENGGUNA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Catatan"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtname.Location = New System.Drawing.Point(149, 89)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(320, 22)
        Me.txtname.TabIndex = 2
        '
        'txtnote
        '
        Me.txtnote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtnote.Location = New System.Drawing.Point(149, 168)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(320, 44)
        Me.txtnote.TabIndex = 5
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(114, 259)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(101, 46)
        Me.btnrefresh.TabIndex = 102
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
        Me.btndelete.Location = New System.Drawing.Point(300, 260)
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
        Me.btnsave.Location = New System.Drawing.Point(12, 259)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 100
        Me.btnsave.Text = "Simpan"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(563, 259)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 104
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.SystemColors.Control
        Me.txtcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtcode.Location = New System.Drawing.Point(149, 61)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ReadOnly = True
        Me.txtcode.Size = New System.Drawing.Size(320, 22)
        Me.txtcode.TabIndex = 1
        Me.txtcode.TabStop = False
        '
        'btnresetpass
        '
        Me.btnresetpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnresetpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnresetpass.Image = CType(resources.GetObject("btnresetpass.Image"), System.Drawing.Image)
        Me.btnresetpass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnresetpass.Location = New System.Drawing.Point(396, 260)
        Me.btnresetpass.Name = "btnresetpass"
        Me.btnresetpass.Size = New System.Drawing.Size(119, 44)
        Me.btnresetpass.TabIndex = 0
        Me.btnresetpass.Text = "Reset Pass"
        Me.btnresetpass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnresetpass.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(221, 259)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 340
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'chsadmin
        '
        Me.chsadmin.AutoSize = True
        Me.chsadmin.Location = New System.Drawing.Point(149, 117)
        Me.chsadmin.Name = "chsadmin"
        Me.chsadmin.Size = New System.Drawing.Size(92, 17)
        Me.chsadmin.TabIndex = 341
        Me.chsadmin.Text = "Super Admin"
        Me.chsadmin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 342
        Me.Label4.Text = "*Default Password 12345"
        '
        'chshowmenu
        '
        Me.chshowmenu.AutoSize = True
        Me.chshowmenu.Location = New System.Drawing.Point(377, 214)
        Me.chshowmenu.Name = "chshowmenu"
        Me.chshowmenu.Size = New System.Drawing.Size(88, 17)
        Me.chshowmenu.TabIndex = 343
        Me.chshowmenu.Text = "Show Menu"
        Me.chshowmenu.UseVisualStyleBackColor = True
        '
        'txtapppass
        '
        Me.txtapppass.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtapppass.Location = New System.Drawing.Point(149, 140)
        Me.txtapppass.MaxLength = 6
        Me.txtapppass.Name = "txtapppass"
        Me.txtapppass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtapppass.Size = New System.Drawing.Size(320, 22)
        Me.txtapppass.TabIndex = 344
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 345
        Me.Label3.Text = "Approval PIN"
        '
        'usr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(665, 320)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtapppass)
        Me.Controls.Add(Me.chshowmenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chsadmin)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnresetpass)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "usr"
        Me.ShowIcon = False
        Me.Text = "Pengguna"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcode As clopalem.txtFree
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents txtnote As clopalem.txtNote
    Friend WithEvents txtname As clopalem.txtFree
    Friend WithEvents btnresetpass As clopalem.btnBlank
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents chsadmin As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chshowmenu As CheckBox
    Friend WithEvents txtapppass As clopalem.txtFree
    Friend WithEvents Label3 As Label
End Class
