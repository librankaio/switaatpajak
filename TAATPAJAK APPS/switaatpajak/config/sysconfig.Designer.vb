<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sysconfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sysconfig))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtserver = New clopalem.txtFree()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbdb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtport = New clopalem.txtFree()
        Me.txtusr = New clopalem.txtFree()
        Me.txtpass = New clopalem.txtFree()
        Me.btngetdb = New clopalem.btnBlank()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 39)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "KONFIGURASI SISTEM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "User"
        '
        'txtserver
        '
        Me.txtserver.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtserver.Location = New System.Drawing.Point(123, 63)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Size = New System.Drawing.Size(320, 22)
        Me.txtserver.TabIndex = 2
        Me.txtserver.Text = "localhost"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(12, 222)
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
        Me.btncancel.Location = New System.Drawing.Point(354, 222)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 104
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 301
        Me.Label3.Text = "Port"
        '
        'cmbdb
        '
        Me.cmbdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdb.FormattingEnabled = True
        Me.cmbdb.Location = New System.Drawing.Point(123, 175)
        Me.cmbdb.Name = "cmbdb"
        Me.cmbdb.Size = New System.Drawing.Size(320, 21)
        Me.cmbdb.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "Database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Password"
        '
        'txtport
        '
        Me.txtport.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtport.Location = New System.Drawing.Point(123, 91)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(320, 22)
        Me.txtport.TabIndex = 305
        Me.txtport.Text = "3306"
        '
        'txtusr
        '
        Me.txtusr.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtusr.Location = New System.Drawing.Point(123, 119)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(320, 22)
        Me.txtusr.TabIndex = 306
        Me.txtusr.Text = "root"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtpass.Location = New System.Drawing.Point(123, 147)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(320, 22)
        Me.txtpass.TabIndex = 307
        '
        'btngetdb
        '
        Me.btngetdb.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btngetdb.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btngetdb.Image = CType(resources.GetObject("btngetdb.Image"), System.Drawing.Image)
        Me.btngetdb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngetdb.Location = New System.Drawing.Point(114, 224)
        Me.btngetdb.Name = "btngetdb"
        Me.btngetdb.Size = New System.Drawing.Size(152, 44)
        Me.btngetdb.TabIndex = 0
        Me.btngetdb.Text = "Ambil Database"
        Me.btngetdb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btngetdb.UseVisualStyleBackColor = False
        '
        'sysconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(472, 288)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusr)
        Me.Controls.Add(Me.txtport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbdb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btngetdb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtserver)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "sysconfig"
        Me.ShowIcon = False
        Me.Text = "Konfigurasi Sistem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents txtserver As clopalem.txtFree
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbdb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtport As clopalem.txtFree
    Friend WithEvents txtusr As clopalem.txtFree
    Friend WithEvents txtpass As clopalem.txtFree
    Friend WithEvents btngetdb As clopalem.btnBlank
End Class
