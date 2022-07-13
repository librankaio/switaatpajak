<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.lbltit = New System.Windows.Forms.Label()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtusr = New clopalem.txtFree()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New clopalem.txtFree()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlogin = New clopalem.btnLogin()
        Me.cmbdatabase = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblchangeserver = New System.Windows.Forms.Label()
        Me.lblserver = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltit
        '
        Me.lbltit.AutoSize = True
        Me.lbltit.BackColor = System.Drawing.Color.White
        Me.lbltit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltit.Location = New System.Drawing.Point(12, 9)
        Me.lbltit.Name = "lbltit"
        Me.lbltit.Size = New System.Drawing.Size(101, 39)
        Me.lbltit.TabIndex = 300
        Me.lbltit.Text = "LOGIN"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(330, 162)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtusr
        '
        Me.txtusr.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtusr.Location = New System.Drawing.Point(100, 62)
        Me.txtusr.Name = "txtusr"
        Me.txtusr.Size = New System.Drawing.Size(320, 22)
        Me.txtusr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Username"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtpass.Location = New System.Drawing.Point(100, 90)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(320, 22)
        Me.txtpass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 303
        Me.Label1.Text = "Passprot"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlogin.Image = CType(resources.GetObject("btnlogin.Image"), System.Drawing.Image)
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(11, 162)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(83, 46)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'cmbdatabase
        '
        Me.cmbdatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdatabase.FormattingEnabled = True
        Me.cmbdatabase.Location = New System.Drawing.Point(100, 118)
        Me.cmbdatabase.Name = "cmbdatabase"
        Me.cmbdatabase.Size = New System.Drawing.Size(320, 21)
        Me.cmbdatabase.TabIndex = 306
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 307
        Me.Label5.Text = "Database"
        '
        'lblchangeserver
        '
        Me.lblchangeserver.AutoSize = True
        Me.lblchangeserver.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchangeserver.ForeColor = System.Drawing.Color.Blue
        Me.lblchangeserver.Location = New System.Drawing.Point(432, 180)
        Me.lblchangeserver.Name = "lblchangeserver"
        Me.lblchangeserver.Size = New System.Drawing.Size(82, 13)
        Me.lblchangeserver.TabIndex = 308
        Me.lblchangeserver.Text = "Change Server"
        Me.lblchangeserver.Visible = False
        '
        'lblserver
        '
        Me.lblserver.AutoSize = True
        Me.lblserver.Location = New System.Drawing.Point(428, 202)
        Me.lblserver.Name = "lblserver"
        Me.lblserver.Size = New System.Drawing.Size(86, 13)
        Me.lblserver.TabIndex = 309
        Me.lblserver.Text = "Current Server :"
        Me.lblserver.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(431, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 310
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(593, 224)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblserver)
        Me.Controls.Add(Me.lblchangeserver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbdatabase)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lbltit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltit As System.Windows.Forms.Label
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents txtusr As clopalem.txtFree
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpass As clopalem.txtFree
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnlogin As clopalem.btnLogin
    Friend WithEvents cmbdatabase As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblchangeserver As Label
    Friend WithEvents lblserver As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
