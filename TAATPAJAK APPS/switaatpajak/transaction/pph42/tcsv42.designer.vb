<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tcsv42
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tcsv42))
        Me.cmbbln = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbthn = New System.Windows.Forms.ComboBox()
        Me.dgview = New System.Windows.Forms.DataGridView()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.dgview2 = New System.Windows.Forms.DataGridView()
        Me.dgview3 = New System.Windows.Forms.DataGridView()
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgview3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbbln
        '
        Me.cmbbln.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbln.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbln.FormattingEnabled = True
        Me.cmbbln.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbbln.Location = New System.Drawing.Point(80, 19)
        Me.cmbbln.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbbln.Name = "cmbbln"
        Me.cmbbln.Size = New System.Drawing.Size(122, 28)
        Me.cmbbln.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bulan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tahun"
        '
        'cmbthn
        '
        Me.cmbthn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbthn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbthn.FormattingEnabled = True
        Me.cmbthn.Items.AddRange(New Object() {"1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099"})
        Me.cmbthn.Location = New System.Drawing.Point(282, 19)
        Me.cmbthn.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbthn.Name = "cmbthn"
        Me.cmbthn.Size = New System.Drawing.Size(122, 28)
        Me.cmbthn.TabIndex = 3
        '
        'dgview
        '
        Me.dgview.AllowUserToAddRows = False
        Me.dgview.AllowUserToDeleteRows = False
        Me.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview.Location = New System.Drawing.Point(15, 61)
        Me.dgview.Margin = New System.Windows.Forms.Padding(2)
        Me.dgview.Name = "dgview"
        Me.dgview.ReadOnly = True
        Me.dgview.RowTemplate.Height = 24
        Me.dgview.Size = New System.Drawing.Size(902, 345)
        Me.dgview.TabIndex = 6
        '
        'btncari
        '
        Me.btncari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Location = New System.Drawing.Point(417, 19)
        Me.btncari.Margin = New System.Windows.Forms.Padding(2)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(64, 27)
        Me.btncari.TabIndex = 7
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 417)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(718, 40)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "1. Jumlah SSP / Pbk yang disetor tidak bisa kurang dari Jumlah " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PPh Terutang. Pa" &
    "stikan Kode Jenis Setoran (KJS) pada SSP/Pbk sesuai dengan Jenis PPh Terutang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 467)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(803, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "2. Laporkan file CSV yang telah dibuat besarta hardcopy dari formulir SPT Induk y" &
    "ang tela ditandatangani ke KPP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 500)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(910, 40)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'btnexport
        '
        Me.btnexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexport.Location = New System.Drawing.Point(805, 554)
        Me.btnexport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(104, 53)
        Me.btnexport.TabIndex = 11
        Me.btnexport.Text = "Export CSV"
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'dgview2
        '
        Me.dgview2.AllowUserToAddRows = False
        Me.dgview2.AllowUserToDeleteRows = False
        Me.dgview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview2.Location = New System.Drawing.Point(15, 559)
        Me.dgview2.Margin = New System.Windows.Forms.Padding(2)
        Me.dgview2.Name = "dgview2"
        Me.dgview2.ReadOnly = True
        Me.dgview2.RowTemplate.Height = 24
        Me.dgview2.Size = New System.Drawing.Size(118, 59)
        Me.dgview2.TabIndex = 13
        Me.dgview2.Visible = False
        '
        'dgview3
        '
        Me.dgview3.AllowUserToAddRows = False
        Me.dgview3.AllowUserToDeleteRows = False
        Me.dgview3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgview3.Location = New System.Drawing.Point(159, 559)
        Me.dgview3.Margin = New System.Windows.Forms.Padding(2)
        Me.dgview3.Name = "dgview3"
        Me.dgview3.ReadOnly = True
        Me.dgview3.RowTemplate.Height = 24
        Me.dgview3.Size = New System.Drawing.Size(118, 59)
        Me.dgview3.TabIndex = 14
        Me.dgview3.Visible = False
        '
        'tcsv42
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 629)
        Me.Controls.Add(Me.dgview3)
        Me.Controls.Add(Me.dgview2)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.dgview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbthn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbbln)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "tcsv42"
        Me.ShowIcon = False
        Me.Text = "EXPORT DATA PPH 4(2)"
        CType(Me.dgview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgview3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbbln As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbthn As ComboBox
    Friend WithEvents dgview As DataGridView
    Friend WithEvents btncari As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnexport As Button
    Friend WithEvents dgview2 As DataGridView
    Friend WithEvents dgview3 As DataGridView
End Class
