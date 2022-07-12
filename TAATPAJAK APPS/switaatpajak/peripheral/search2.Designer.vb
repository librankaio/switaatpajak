<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class search2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search2))
        Me.lbltit = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.txtsearch = New clopalem.txtFree()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbfilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnfilter = New clopalem.btnBrowse()
        Me.btnbrowseso = New clopalem.btnBrowse()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbltit.Size = New System.Drawing.Size(251, 39)
        Me.lbltit.TabIndex = 300
        Me.lbltit.Text = "DATA PENCARIAN"
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.AllowUserToOrderColumns = True
        Me.dgview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(12, 90)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgview.Size = New System.Drawing.Size(993, 261)
        Me.dgview.TabIndex = 200
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(12, 361)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 46)
        Me.btnsave.TabIndex = 100
        Me.btnsave.Text = "Simpan"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(916, 361)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 104
        Me.btncancel.Text = "Keluar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtsearch.Location = New System.Drawing.Point(97, 62)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(320, 22)
        Me.txtsearch.TabIndex = 302
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Pencarian"
        '
        'cmbfilter
        '
        Me.cmbfilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfilter.FormattingEnabled = True
        Me.cmbfilter.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "SEMUA"})
        Me.cmbfilter.Location = New System.Drawing.Point(874, 65)
        Me.cmbfilter.Name = "cmbfilter"
        Me.cmbfilter.Size = New System.Drawing.Size(104, 21)
        Me.cmbfilter.TabIndex = 303
        Me.cmbfilter.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(790, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Filter / Month"
        Me.Label1.Visible = False
        '
        'btnfilter
        '
        Me.btnfilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnfilter.BackgroundImage = CType(resources.GetObject("btnfilter.BackgroundImage"), System.Drawing.Image)
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnfilter.Location = New System.Drawing.Point(984, 65)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(23, 23)
        Me.btnfilter.TabIndex = 305
        Me.btnfilter.UseVisualStyleBackColor = False
        Me.btnfilter.Visible = False
        '
        'btnbrowseso
        '
        Me.btnbrowseso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnbrowseso.BackgroundImage = CType(resources.GetObject("btnbrowseso.BackgroundImage"), System.Drawing.Image)
        Me.btnbrowseso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbrowseso.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnbrowseso.Location = New System.Drawing.Point(423, 61)
        Me.btnbrowseso.Name = "btnbrowseso"
        Me.btnbrowseso.Size = New System.Drawing.Size(23, 23)
        Me.btnbrowseso.TabIndex = 375
        Me.btnbrowseso.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1017, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnbrowseso)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbfilter)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.lbltit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "search"
        Me.Text = "Pencarian"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltit As System.Windows.Forms.Label
    Friend WithEvents dgview As System.Windows.Forms.DataGridView
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents txtsearch As clopalem.txtFree
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbfilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnfilter As clopalem.btnBrowse
    Friend WithEvents btnbrowseso As clopalem.btnBrowse
End Class
