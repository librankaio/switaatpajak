<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mobjkpjk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mobjkpjk))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtkode = New clopalem.txtFree()
        Me.btnlist = New clopalem.btnList()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtobjpjk = New clopalem.txtFree()
        Me.cmbjnspjk = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(127, 623)
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
        Me.btndelete.Location = New System.Drawing.Point(311, 623)
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
        Me.btnsave.Location = New System.Drawing.Point(25, 623)
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
        Me.btncancel.Location = New System.Drawing.Point(514, 623)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtkode
        '
        Me.txtkode.BackColor = System.Drawing.SystemColors.Window
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(35, 140)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(573, 26)
        Me.txtkode.TabIndex = 1
        '
        'btnlist
        '
        Me.btnlist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnlist.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnlist.Image = CType(resources.GetObject("btnlist.Image"), System.Drawing.Image)
        Me.btnlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlist.Location = New System.Drawing.Point(232, 623)
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
        Me.lblcode.Location = New System.Drawing.Point(419, 641)
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
        Me.lbluseractivity.Location = New System.Drawing.Point(28, 605)
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
        Me.Label28.Size = New System.Drawing.Size(190, 39)
        Me.Label28.TabIndex = 401
        Me.Label28.Text = "OBJEK PAJAK"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(31, 169)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 20)
        Me.Label30.TabIndex = 404
        Me.Label30.Text = "Objek Pajak"
        '
        'txtobjpjk
        '
        Me.txtobjpjk.BackColor = System.Drawing.SystemColors.Window
        Me.txtobjpjk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobjpjk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobjpjk.Location = New System.Drawing.Point(35, 191)
        Me.txtobjpjk.Multiline = True
        Me.txtobjpjk.Name = "txtobjpjk"
        Me.txtobjpjk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobjpjk.Size = New System.Drawing.Size(573, 411)
        Me.txtobjpjk.TabIndex = 405
        '
        'cmbjnspjk
        '
        Me.cmbjnspjk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjnspjk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbjnspjk.FormattingEnabled = True
        Me.cmbjnspjk.Items.AddRange(New Object() {"PPh 21", "PPh 23", "PPh 4(2)"})
        Me.cmbjnspjk.Location = New System.Drawing.Point(36, 87)
        Me.cmbjnspjk.Name = "cmbjnspjk"
        Me.cmbjnspjk.Size = New System.Drawing.Size(572, 28)
        Me.cmbjnspjk.TabIndex = 463
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 464
        Me.Label2.Text = "Jenis Pajak"
        '
        'mobjkpjk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(633, 681)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbjnspjk)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtobjpjk)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtkode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mobjkpjk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkode As clopalem.txtFree
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents lblcode As Label
    Friend WithEvents lbluseractivity As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtobjpjk As clopalem.txtFree
    Friend WithEvents cmbjnspjk As ComboBox
    Friend WithEvents Label2 As Label
End Class
