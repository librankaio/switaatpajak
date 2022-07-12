<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tinputdatapemotongpjk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tinputdatapemotongpjk))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnpwp = New clopalem.txtFree()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbkodepjk = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpphptg = New clopalem.txtCurrency()
        Me.txtbruto = New clopalem.txtCurrency()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkdnegara = New clopalem.txtFree()
        Me.cmbkdnegara_rl = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.btnlist = New clopalem.btnList()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.chwpasing = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(835, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtnpwp
        '
        Me.txtnpwp.BackColor = System.Drawing.SystemColors.Window
        Me.txtnpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtnpwp.Location = New System.Drawing.Point(446, 99)
        Me.txtnpwp.MaxLength = 16
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.Size = New System.Drawing.Size(395, 26)
        Me.txtnpwp.TabIndex = 405
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(83, 101)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 20)
        Me.Label30.TabIndex = 406
        Me.Label30.Text = "NPWP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 407
        Me.Label2.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.SystemColors.Window
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtnama.Location = New System.Drawing.Point(446, 131)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(395, 26)
        Me.txtnama.TabIndex = 408
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 409
        Me.Label3.Text = "Kode Objek Pajak"
        '
        'cmbkodepjk
        '
        Me.cmbkodepjk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkodepjk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbkodepjk.FormattingEnabled = True
        Me.cmbkodepjk.Items.AddRange(New Object() {"---PILIJH DATA---", "21-100-01", "21-100-02"})
        Me.cmbkodepjk.Location = New System.Drawing.Point(446, 163)
        Me.cmbkodepjk.Name = "cmbkodepjk"
        Me.cmbkodepjk.Size = New System.Drawing.Size(395, 28)
        Me.cmbkodepjk.TabIndex = 410
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 413
        Me.Label4.Text = "PPh Dipotong ( Rp. )"
        '
        'txtpphptg
        '
        Me.txtpphptg.BackColor = System.Drawing.SystemColors.Window
        Me.txtpphptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpphptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtpphptg.Location = New System.Drawing.Point(446, 229)
        Me.txtpphptg.Name = "txtpphptg"
        Me.txtpphptg.Size = New System.Drawing.Size(395, 26)
        Me.txtpphptg.TabIndex = 414
        '
        'txtbruto
        '
        Me.txtbruto.BackColor = System.Drawing.SystemColors.Window
        Me.txtbruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbruto.Location = New System.Drawing.Point(446, 197)
        Me.txtbruto.Name = "txtbruto"
        Me.txtbruto.Size = New System.Drawing.Size(395, 26)
        Me.txtbruto.TabIndex = 411
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 20)
        Me.Label5.TabIndex = 412
        Me.Label5.Text = "Jumlah Penghasilan Bruto ( Rp. )"
        '
        'txtkdnegara
        '
        Me.txtkdnegara.BackColor = System.Drawing.SystemColors.Control
        Me.txtkdnegara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkdnegara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtkdnegara.Location = New System.Drawing.Point(446, 261)
        Me.txtkdnegara.Name = "txtkdnegara"
        Me.txtkdnegara.ReadOnly = True
        Me.txtkdnegara.Size = New System.Drawing.Size(86, 26)
        Me.txtkdnegara.TabIndex = 416
        '
        'cmbkdnegara_rl
        '
        Me.cmbkdnegara_rl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkdnegara_rl.Enabled = False
        Me.cmbkdnegara_rl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbkdnegara_rl.FormattingEnabled = True
        Me.cmbkdnegara_rl.Location = New System.Drawing.Point(537, 260)
        Me.cmbkdnegara_rl.Name = "cmbkdnegara_rl"
        Me.cmbkdnegara_rl.Size = New System.Drawing.Size(304, 28)
        Me.cmbkdnegara_rl.TabIndex = 415
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 20)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Kode Negara Domisili"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(22, 314)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 418
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
        Me.btncancel.Location = New System.Drawing.Point(752, 314)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 419
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(229, 314)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 455
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
        Me.btnrefresh.Location = New System.Drawing.Point(124, 314)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(99, 46)
        Me.btnrefresh.TabIndex = 454
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
        Me.btndelete.Location = New System.Drawing.Point(308, 314)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 46)
        Me.btndelete.TabIndex = 456
        Me.btndelete.Text = "Hapus"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'chwpasing
        '
        Me.chwpasing.AutoSize = True
        Me.chwpasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chwpasing.Location = New System.Drawing.Point(343, 262)
        Me.chwpasing.Name = "chwpasing"
        Me.chwpasing.Size = New System.Drawing.Size(97, 24)
        Me.chwpasing.TabIndex = 457
        Me.chwpasing.Text = "WP Asing"
        Me.chwpasing.UseVisualStyleBackColor = True
        '
        'tinputdatapemotongpjk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 380)
        Me.Controls.Add(Me.chwpasing)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtkdnegara)
        Me.Controls.Add(Me.cmbkdnegara_rl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpphptg)
        Me.Controls.Add(Me.txtbruto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbkodepjk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpwp)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "tinputdatapemotongpjk"
        Me.ShowIcon = False
        Me.Text = "Input Data Pemotong Pajak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnpwp As clopalem.txtFree
    Friend WithEvents Label30 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As clopalem.txtFree
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbkodepjk As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpphptg As clopalem.txtCurrency
    Friend WithEvents txtbruto As clopalem.txtCurrency
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkdnegara As clopalem.txtFree
    Friend WithEvents cmbkdnegara_rl As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents chwpasing As CheckBox
End Class
