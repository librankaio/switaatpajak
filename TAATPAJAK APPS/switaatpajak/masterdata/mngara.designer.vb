<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mngara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mngara))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtid_negara = New clopalem.txtFree()
        Me.btnlist = New clopalem.btnList()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtname_negara = New clopalem.txtFree()
        Me.chp3b = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Negara"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(137, 205)
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
        Me.btndelete.Location = New System.Drawing.Point(321, 205)
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
        Me.btnsave.Location = New System.Drawing.Point(35, 205)
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
        Me.btncancel.Location = New System.Drawing.Point(524, 205)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtid_negara
        '
        Me.txtid_negara.BackColor = System.Drawing.SystemColors.Window
        Me.txtid_negara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid_negara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_negara.Location = New System.Drawing.Point(40, 89)
        Me.txtid_negara.Name = "txtid_negara"
        Me.txtid_negara.Size = New System.Drawing.Size(573, 26)
        Me.txtid_negara.TabIndex = 1
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(242, 205)
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
        Me.lblcode.Location = New System.Drawing.Point(429, 223)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(45, 13)
        Me.lblcode.TabIndex = 140
        Me.lblcode.Text = "lblcode"
        Me.lblcode.Visible = False
        '
        'lbluseractivity
        '
        Me.lbluseractivity.AutoSize = True
        Me.lbluseractivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluseractivity.Location = New System.Drawing.Point(38, 187)
        Me.lbluseractivity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbluseractivity.Name = "lbluseractivity"
        Me.lbluseractivity.Size = New System.Drawing.Size(94, 15)
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
        Me.Label28.Size = New System.Drawing.Size(207, 39)
        Me.Label28.TabIndex = 401
        Me.Label28.Text = "KODE NEGARA"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(36, 118)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(107, 20)
        Me.Label30.TabIndex = 404
        Me.Label30.Text = "Nama Negara"
        '
        'txtname_negara
        '
        Me.txtname_negara.BackColor = System.Drawing.SystemColors.Window
        Me.txtname_negara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname_negara.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname_negara.Location = New System.Drawing.Point(40, 140)
        Me.txtname_negara.Name = "txtname_negara"
        Me.txtname_negara.Size = New System.Drawing.Size(573, 26)
        Me.txtname_negara.TabIndex = 405
        '
        'chp3b
        '
        Me.chp3b.AutoSize = True
        Me.chp3b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chp3b.Location = New System.Drawing.Point(555, 172)
        Me.chp3b.Name = "chp3b"
        Me.chp3b.Size = New System.Drawing.Size(58, 24)
        Me.chp3b.TabIndex = 428
        Me.chp3b.Text = "P3B"
        Me.chp3b.UseVisualStyleBackColor = True
        '
        'mngara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(633, 280)
        Me.Controls.Add(Me.chp3b)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtname_negara)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid_negara)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mngara"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid_negara As clopalem.txtFree
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents lblcode As Label
    Friend WithEvents lbluseractivity As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtname_negara As clopalem.txtFree
    Friend WithEvents chp3b As CheckBox
End Class
