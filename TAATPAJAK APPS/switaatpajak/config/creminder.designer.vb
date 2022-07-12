<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class creminder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(creminder))
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txttotal = New clopalem.txtCurrency()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgviewdetail = New System.Windows.Forms.DataGridView()
        Me.chfinish = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgviewdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgview.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgview.Location = New System.Drawing.Point(12, 51)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.Size = New System.Drawing.Size(859, 367)
        Me.dgview.TabIndex = 326
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 26)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Image = CType(resources.GetObject("ApproveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve"
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txttotal.Location = New System.Drawing.Point(612, 418)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(259, 22)
        Me.txttotal.TabIndex = 343
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(534, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 342
        Me.Label1.Text = "T O T A L"
        '
        'dgviewdetail
        '
        Me.dgviewdetail.AllowUserToAddRows = False
        Me.dgviewdetail.AllowUserToDeleteRows = False
        Me.dgviewdetail.AllowUserToOrderColumns = True
        Me.dgviewdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewdetail.Location = New System.Drawing.Point(12, 421)
        Me.dgviewdetail.Name = "dgviewdetail"
        Me.dgviewdetail.ReadOnly = True
        Me.dgviewdetail.Size = New System.Drawing.Size(128, 31)
        Me.dgviewdetail.TabIndex = 403
        Me.dgviewdetail.Visible = False
        '
        'chfinish
        '
        Me.chfinish.AutoSize = True
        Me.chfinish.Location = New System.Drawing.Point(756, 28)
        Me.chfinish.Name = "chfinish"
        Me.chfinish.Size = New System.Drawing.Size(115, 17)
        Me.chfinish.TabIndex = 404
        Me.chfinish.Text = "Hide Approved SO"
        Me.chfinish.UseVisualStyleBackColor = True
        Me.chfinish.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(313, 39)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "DAFTAR SO APPROVAL"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 13)
        Me.Label2.TabIndex = 406
        Me.Label2.Text = "*double click untuk lihat detail. Klik kanan untuk lakukan approval"
        '
        'creminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chfinish)
        Me.Controls.Add(Me.dgviewdetail)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgview)
        Me.Name = "creminder"
        Me.ShowIcon = False
        Me.Text = "SO Approval"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgviewdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgview As DataGridView
    Friend WithEvents txttotal As clopalem.txtCurrency
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotal2 As clopalem.txtCurrency
    Friend WithEvents Label5 As Label
    Friend WithEvents dgviewdetail As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ApproveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chfinish As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
End Class
