<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class changePrice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changePrice))
        Me.btnsave = New clopalem.btnSave()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtminprice = New clopalem.txtCurrency()
        Me.txtprice = New clopalem.txtCurrency()
        Me.txtmaxprice = New clopalem.txtCurrency()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnewprice = New clopalem.txtCurrency()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancel = New clopalem.btnCancel()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(39, 245)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 46)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Ubah"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Harga Minimal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Harga Jual"
        '
        'txtminprice
        '
        Me.txtminprice.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtminprice.Location = New System.Drawing.Point(39, 75)
        Me.txtminprice.Name = "txtminprice"
        Me.txtminprice.ReadOnly = True
        Me.txtminprice.Size = New System.Drawing.Size(285, 22)
        Me.txtminprice.TabIndex = 305
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtprice.Location = New System.Drawing.Point(39, 116)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(285, 22)
        Me.txtprice.TabIndex = 306
        '
        'txtmaxprice
        '
        Me.txtmaxprice.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtmaxprice.Location = New System.Drawing.Point(39, 158)
        Me.txtmaxprice.Name = "txtmaxprice"
        Me.txtmaxprice.ReadOnly = True
        Me.txtmaxprice.Size = New System.Drawing.Size(285, 22)
        Me.txtmaxprice.TabIndex = 308
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 307
        Me.Label3.Text = "Harga Maximal"
        '
        'txtnewprice
        '
        Me.txtnewprice.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtnewprice.Location = New System.Drawing.Point(39, 199)
        Me.txtnewprice.Name = "txtnewprice"
        Me.txtnewprice.Size = New System.Drawing.Size(285, 22)
        Me.txtnewprice.TabIndex = 310
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 309
        Me.Label4.Text = "Harga Diinginkan"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btncancel.Image = CType(resources.GetObject("btncancel.Image"), System.Drawing.Image)
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(235, 245)
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
        'changePrice
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(363, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtnewprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmaxprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtminprice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsave)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "changePrice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As clopalem.btnSave
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtminprice As clopalem.txtCurrency
    Friend WithEvents txtprice As clopalem.txtCurrency
    Friend WithEvents txtmaxprice As clopalem.txtCurrency
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnewprice As clopalem.txtCurrency
    Friend WithEvents Label4 As Label
    Friend WithEvents btncancel As clopalem.btnCancel
    Friend WithEvents lbldesc As Label
End Class
