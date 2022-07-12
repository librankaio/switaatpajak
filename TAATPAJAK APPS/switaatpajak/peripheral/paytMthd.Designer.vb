<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paytMthd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paytMthd))
        Me.btnsave = New clopalem.btnSave()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbyr1 = New clopalem.txtCurrency()
        Me.txtbyr2 = New clopalem.txtCurrency()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbyr3 = New clopalem.txtCurrency()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancel = New clopalem.btnCancel()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.cmbbyr1 = New System.Windows.Forms.ComboBox()
        Me.cmbbyr2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbbyr3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(38, 332)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 46)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Update"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Metode Byr #1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Nominal Byr #1"
        '
        'txtbyr1
        '
        Me.txtbyr1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtbyr1.Location = New System.Drawing.Point(38, 116)
        Me.txtbyr1.Name = "txtbyr1"
        Me.txtbyr1.Size = New System.Drawing.Size(285, 22)
        Me.txtbyr1.TabIndex = 306
        '
        'txtbyr2
        '
        Me.txtbyr2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtbyr2.Location = New System.Drawing.Point(38, 204)
        Me.txtbyr2.Name = "txtbyr2"
        Me.txtbyr2.Size = New System.Drawing.Size(285, 22)
        Me.txtbyr2.TabIndex = 308
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 307
        Me.Label3.Text = "Nominal Byr #2"
        '
        'txtbyr3
        '
        Me.txtbyr3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtbyr3.Location = New System.Drawing.Point(39, 286)
        Me.txtbyr3.Name = "txtbyr3"
        Me.txtbyr3.Size = New System.Drawing.Size(285, 22)
        Me.txtbyr3.TabIndex = 310
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 309
        Me.Label4.Text = "Nominal Byr #3"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(234, 332)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 311
        Me.btncancel.TabStop = False
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(15, 18)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(19, 21)
        Me.lbldesc.TabIndex = 312
        Me.lbldesc.Text = "..."
        '
        'cmbbyr1
        '
        Me.cmbbyr1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbyr1.FormattingEnabled = True
        Me.cmbbyr1.Location = New System.Drawing.Point(39, 74)
        Me.cmbbyr1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbbyr1.Name = "cmbbyr1"
        Me.cmbbyr1.Size = New System.Drawing.Size(285, 21)
        Me.cmbbyr1.TabIndex = 313
        '
        'cmbbyr2
        '
        Me.cmbbyr2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbyr2.FormattingEnabled = True
        Me.cmbbyr2.Location = New System.Drawing.Point(38, 156)
        Me.cmbbyr2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbbyr2.Name = "cmbbyr2"
        Me.cmbbyr2.Size = New System.Drawing.Size(286, 21)
        Me.cmbbyr2.TabIndex = 314
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "Metode Byr #2"
        '
        'cmbbyr3
        '
        Me.cmbbyr3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbyr3.FormattingEnabled = True
        Me.cmbbyr3.Location = New System.Drawing.Point(39, 244)
        Me.cmbbyr3.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbbyr3.Name = "cmbbyr3"
        Me.cmbbyr3.Size = New System.Drawing.Size(284, 21)
        Me.cmbbyr3.TabIndex = 316
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 317
        Me.Label6.Text = "Metode Byr #3"
        '
        'paytMthd
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(363, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbbyr3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbbyr2)
        Me.Controls.Add(Me.cmbbyr1)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtbyr3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbyr2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbyr1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "paytMthd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbyr1 As clopalem.txtCurrency
    Friend WithEvents txtbyr2 As clopalem.txtCurrency
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbyr3 As clopalem.txtCurrency
    Friend WithEvents Label4 As Label
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents lbldesc As Label
    Friend WithEvents cmbbyr1 As ComboBox
    Friend WithEvents cmbbyr2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbbyr3 As ComboBox
    Friend WithEvents Label6 As Label
End Class
