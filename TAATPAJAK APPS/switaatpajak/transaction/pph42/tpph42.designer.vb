<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tpph42
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tpph42))
        Me.btnrefresh = New clopalem.btnRefresh()
        Me.btndelete = New clopalem.btnDelete()
        Me.btnsave = New clopalem.btnSave()
        Me.btncancel = New clopalem.btnCancel()
        Me.btnlist = New clopalem.btnList()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeletePhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SyncOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbluseractivity = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtalamatptg = New clopalem.txtFree()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnamaptg = New clopalem.txtFree()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnpwpptg = New clopalem.txtFree()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chwpasing = New System.Windows.Forms.CheckBox()
        Me.lblid_lwntransaksi = New System.Windows.Forms.Label()
        Me.btnmlwntransaksi = New clopalem.btnBrowse()
        Me.txtalamat = New clopalem.txtFree()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New clopalem.txtFree()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnpwp = New clopalem.txtFree()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dttdttglptg = New System.Windows.Forms.DateTimePicker()
        Me.txtnobkt = New clopalem.txtFree()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New clopalem.txtCurrency()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbjnstransaksi = New System.Windows.Forms.ComboBox()
        Me.txtterbilang = New clopalem.txtFree()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.txtnobuktiptg = New clopalem.txtFree()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttglptg = New clopalem.txtFree()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip6.SuspendLayout()
        Me.ContextMenuStrip5.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(126, 664)
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
        Me.btndelete.Location = New System.Drawing.Point(310, 664)
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
        Me.btnsave.Location = New System.Drawing.Point(24, 664)
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
        Me.btncancel.Location = New System.Drawing.Point(797, 664)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 46)
        Me.btncancel.TabIndex = 105
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
        Me.btnlist.Location = New System.Drawing.Point(231, 664)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(73, 46)
        Me.btnlist.TabIndex = 102
        Me.btnlist.Text = "List"
        Me.btnlist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlist.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip6
        '
        Me.ContextMenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.ContextMenuStrip6.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip6.Size = New System.Drawing.Size(167, 26)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem4.Text = "Lihat Daftar Akun"
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.ContextMenuStrip5.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem3.Text = "Delete Photo"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem2.Text = "Delete Photo"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(143, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItem1.Text = "Delete Photo"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeletePhotoToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(143, 26)
        '
        'DeletePhotoToolStripMenuItem
        '
        Me.DeletePhotoToolStripMenuItem.Image = CType(resources.GetObject("DeletePhotoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeletePhotoToolStripMenuItem.Name = "DeletePhotoToolStripMenuItem"
        Me.DeletePhotoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeletePhotoToolStripMenuItem.Text = "Delete Photo"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SyncOnlineToolStripMenuItem, Me.ToolStripSeparator1, Me.ExBCToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 54)
        '
        'SyncOnlineToolStripMenuItem
        '
        Me.SyncOnlineToolStripMenuItem.Image = CType(resources.GetObject("SyncOnlineToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SyncOnlineToolStripMenuItem.Name = "SyncOnlineToolStripMenuItem"
        Me.SyncOnlineToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SyncOnlineToolStripMenuItem.Text = "Sync Online"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'ExBCToolStripMenuItem
        '
        Me.ExBCToolStripMenuItem.Image = CType(resources.GetObject("ExBCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExBCToolStripMenuItem.Name = "ExBCToolStripMenuItem"
        Me.ExBCToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExBCToolStripMenuItem.Text = "Ex BC"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(418, 682)
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
        Me.lbluseractivity.Location = New System.Drawing.Point(27, 646)
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
        Me.Label28.Size = New System.Drawing.Size(598, 39)
        Me.Label28.TabIndex = 401
        Me.Label28.Text = "BUKTI PEMOTONGAN FINAL PPH PASAL 4 (2)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtalamatptg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnamaptg)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnpwpptg)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 130)
        Me.GroupBox1.TabIndex = 402
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PEMOTONG PAJAK"
        '
        'txtalamatptg
        '
        Me.txtalamatptg.BackColor = System.Drawing.SystemColors.Control
        Me.txtalamatptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamatptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamatptg.Location = New System.Drawing.Point(154, 92)
        Me.txtalamatptg.Name = "txtalamatptg"
        Me.txtalamatptg.ReadOnly = True
        Me.txtalamatptg.Size = New System.Drawing.Size(610, 26)
        Me.txtalamatptg.TabIndex = 413
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 414
        Me.Label2.Text = "Alamat"
        '
        'txtnamaptg
        '
        Me.txtnamaptg.BackColor = System.Drawing.SystemColors.Control
        Me.txtnamaptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnamaptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaptg.Location = New System.Drawing.Point(154, 60)
        Me.txtnamaptg.Name = "txtnamaptg"
        Me.txtnamaptg.ReadOnly = True
        Me.txtnamaptg.Size = New System.Drawing.Size(610, 26)
        Me.txtnamaptg.TabIndex = 411
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 412
        Me.Label1.Text = "Nama"
        '
        'txtnpwpptg
        '
        Me.txtnpwpptg.BackColor = System.Drawing.SystemColors.Control
        Me.txtnpwpptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwpptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwpptg.Location = New System.Drawing.Point(154, 28)
        Me.txtnpwpptg.Name = "txtnpwpptg"
        Me.txtnpwpptg.ReadOnly = True
        Me.txtnpwpptg.Size = New System.Drawing.Size(227, 26)
        Me.txtnpwpptg.TabIndex = 409
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 410
        Me.Label8.Text = "NPWP"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chwpasing)
        Me.GroupBox2.Controls.Add(Me.lblid_lwntransaksi)
        Me.GroupBox2.Controls.Add(Me.btnmlwntransaksi)
        Me.GroupBox2.Controls.Add(Me.txtalamat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnpwp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 130)
        Me.GroupBox2.TabIndex = 415
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WAJIB PAJAK DIPOTONG"
        '
        'chwpasing
        '
        Me.chwpasing.AutoSize = True
        Me.chwpasing.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chwpasing.Location = New System.Drawing.Point(656, 27)
        Me.chwpasing.Name = "chwpasing"
        Me.chwpasing.Size = New System.Drawing.Size(75, 21)
        Me.chwpasing.TabIndex = 438
        Me.chwpasing.Text = "wpasing"
        Me.chwpasing.UseVisualStyleBackColor = True
        Me.chwpasing.Visible = False
        '
        'lblid_lwntransaksi
        '
        Me.lblid_lwntransaksi.AutoSize = True
        Me.lblid_lwntransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_lwntransaksi.Location = New System.Drawing.Point(490, 28)
        Me.lblid_lwntransaksi.Name = "lblid_lwntransaksi"
        Me.lblid_lwntransaksi.Size = New System.Drawing.Size(132, 20)
        Me.lblid_lwntransaksi.TabIndex = 433
        Me.lblid_lwntransaksi.Text = "lblid_lwntransaksi"
        Me.lblid_lwntransaksi.Visible = False
        '
        'btnmlwntransaksi
        '
        Me.btnmlwntransaksi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnmlwntransaksi.BackgroundImage = CType(resources.GetObject("btnmlwntransaksi.BackgroundImage"), System.Drawing.Image)
        Me.btnmlwntransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmlwntransaksi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnmlwntransaksi.Location = New System.Drawing.Point(387, 28)
        Me.btnmlwntransaksi.Name = "btnmlwntransaksi"
        Me.btnmlwntransaksi.Size = New System.Drawing.Size(23, 23)
        Me.btnmlwntransaksi.TabIndex = 432
        Me.btnmlwntransaksi.UseVisualStyleBackColor = False
        '
        'txtalamat
        '
        Me.txtalamat.BackColor = System.Drawing.SystemColors.Control
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(154, 92)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.ReadOnly = True
        Me.txtalamat.Size = New System.Drawing.Size(610, 26)
        Me.txtalamat.TabIndex = 413
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 414
        Me.Label3.Text = "Alamat"
        '
        'txtnama
        '
        Me.txtnama.BackColor = System.Drawing.SystemColors.Control
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(154, 60)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(610, 26)
        Me.txtnama.TabIndex = 411
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "Nama"
        '
        'txtnpwp
        '
        Me.txtnpwp.BackColor = System.Drawing.SystemColors.Control
        Me.txtnpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwp.Location = New System.Drawing.Point(154, 28)
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.ReadOnly = True
        Me.txtnpwp.Size = New System.Drawing.Size(227, 26)
        Me.txtnpwp.TabIndex = 409
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 410
        Me.Label5.Text = "NPWP"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dttdttglptg)
        Me.Panel1.Controls.Add(Me.txtnobkt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(24, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 53)
        Me.Panel1.TabIndex = 416
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(517, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 20)
        Me.Label7.TabIndex = 429
        Me.Label7.Text = "Tanggal Pemotongan"
        '
        'dttdttglptg
        '
        Me.dttdttglptg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dttdttglptg.CustomFormat = "dd/MM/yyyy"
        Me.dttdttglptg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttdttglptg.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttdttglptg.Location = New System.Drawing.Point(683, 9)
        Me.dttdttglptg.Margin = New System.Windows.Forms.Padding(2)
        Me.dttdttglptg.Name = "dttdttglptg"
        Me.dttdttglptg.Size = New System.Drawing.Size(163, 29)
        Me.dttdttglptg.TabIndex = 428
        '
        'txtnobkt
        '
        Me.txtnobkt.BackColor = System.Drawing.SystemColors.Window
        Me.txtnobkt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnobkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnobkt.Location = New System.Drawing.Point(153, 12)
        Me.txtnobkt.Name = "txtnobkt"
        Me.txtnobkt.Size = New System.Drawing.Size(227, 26)
        Me.txtnobkt.TabIndex = 415
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 416
        Me.Label6.Text = "Nomor Bukti"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cmbjnstransaksi)
        Me.Panel2.Controls.Add(Me.txtterbilang)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dgview)
        Me.Panel2.Controls.Add(Me.txtnobuktiptg)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(24, 394)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 244)
        Me.Panel2.TabIndex = 430
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(563, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 420
        Me.Label12.Text = "TOTAL"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.Control
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(628, 203)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(227, 26)
        Me.txttotal.TabIndex = 419
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 20)
        Me.Label11.TabIndex = 418
        Me.Label11.Text = "Keterangan"
        '
        'cmbjnstransaksi
        '
        Me.cmbjnstransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbjnstransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbjnstransaksi.FormattingEnabled = True
        Me.cmbjnstransaksi.Items.AddRange(New Object() {"Hadiah Undian", "Bunga Deposito/Tabungan, Diskonto SBI, Jasa Giro", "Penghasilan dari Transaksi Penjualan Saham yang Diperdagangkan di Bursa Efek", "Penghasilan dari Persewaan Tanah dan/atau Bangunan", "Penghasilan dari Usaha Jasa Konstruksi", "Bunga dan/atau Diskonto Obligasi dan Surat Berharga Negara (SBN)", "Wajib Pajak yang Melakukan Pengalihan Hak Atas Tanah/Bangunan", "Bunga Simpanan yang Dibayarkan oleh Koperasi kepada Anggota Koperasi Orang Pribad" &
                "i", "Penghasilan dari Transaksi Derivatif Berupa Kontrak Berjangka yang di perdagangka" &
                "n di Bursa", "Dividen yang Diterima atau Diperoleh Wajib Pajak Orang Pribadi Dalam Negeri", "Penghasilan Tertentu Lainnya..."})
        Me.cmbjnstransaksi.Location = New System.Drawing.Point(153, 6)
        Me.cmbjnstransaksi.Name = "cmbjnstransaksi"
        Me.cmbjnstransaksi.Size = New System.Drawing.Size(693, 28)
        Me.cmbjnstransaksi.TabIndex = 417
        '
        'txtterbilang
        '
        Me.txtterbilang.BackColor = System.Drawing.SystemColors.Control
        Me.txtterbilang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtterbilang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterbilang.Location = New System.Drawing.Point(153, 203)
        Me.txtterbilang.Name = "txtterbilang"
        Me.txtterbilang.ReadOnly = True
        Me.txtterbilang.Size = New System.Drawing.Size(404, 26)
        Me.txtterbilang.TabIndex = 415
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 416
        Me.Label9.Text = "Terbilang"
        '
        'dgview
        '
        Me.dgview.AllowUserToOrderColumns = True
        Me.dgview.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(5, 70)
        Me.dgview.Name = "dgview"
        Me.dgview.Size = New System.Drawing.Size(850, 127)
        Me.dgview.TabIndex = 415
        '
        'txtnobuktiptg
        '
        Me.txtnobuktiptg.BackColor = System.Drawing.SystemColors.Window
        Me.txtnobuktiptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnobuktiptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnobuktiptg.Location = New System.Drawing.Point(153, 39)
        Me.txtnobuktiptg.Name = "txtnobuktiptg"
        Me.txtnobuktiptg.Size = New System.Drawing.Size(693, 26)
        Me.txtnobuktiptg.TabIndex = 415
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 416
        Me.Label10.Text = "Jenis Transaksi"
        '
        'txttglptg
        '
        Me.txttglptg.BackColor = System.Drawing.SystemColors.Window
        Me.txttglptg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttglptg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttglptg.Location = New System.Drawing.Point(761, 22)
        Me.txttglptg.Name = "txttglptg"
        Me.txttglptg.Size = New System.Drawing.Size(119, 26)
        Me.txttglptg.TabIndex = 440
        Me.txttglptg.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(634, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 20)
        Me.Label18.TabIndex = 441
        Me.Label18.Text = "Tanggal Potong"
        Me.Label18.Visible = False
        '
        'tpph42
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(907, 722)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.txttglptg)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbluseractivity)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tpph42"
        Me.Text = "Bukti Potong Pasal 42"
        Me.ContextMenuStrip6.ResumeLayout(False)
        Me.ContextMenuStrip5.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents btndelete As clopalem.btnDelete
    Friend WithEvents btnrefresh As clopalem.btnRefresh
    Friend WithEvents btnlist As clopalem.btnList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SyncOnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeletePhotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExBCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents lblcode As Label
    Friend WithEvents lbluseractivity As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtalamatptg As clopalem.txtFree
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnamaptg As clopalem.txtFree
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnpwpptg As clopalem.txtFree
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtalamat As clopalem.txtFree
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As clopalem.txtFree
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnpwp As clopalem.txtFree
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtnobkt As clopalem.txtFree
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dttdttglptg As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtnobuktiptg As clopalem.txtFree
    Friend WithEvents Label10 As Label
    Friend WithEvents txtterbilang As clopalem.txtFree
    Friend WithEvents Label9 As Label
    Friend WithEvents dgview As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbjnstransaksi As ComboBox
    Friend WithEvents btnmlwntransaksi As clopalem.btnBrowse
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal As clopalem.txtCurrency
    Friend WithEvents lblid_lwntransaksi As Label
    Friend WithEvents chwpasing As CheckBox
    Friend WithEvents txttglptg As clopalem.txtFree
    Friend WithEvents Label18 As Label
End Class
