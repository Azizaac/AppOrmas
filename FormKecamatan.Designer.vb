<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKecamatan
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DGVKecamatan = New System.Windows.Forms.DataGridView()
        Me.txtNamaKecamatan = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DB_OrmasDataSet = New AppOrmas.DB_OrmasDataSet()
        Me.DBOrmasDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGVKecamatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_OrmasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBOrmasDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVKecamatan
        '
        Me.DGVKecamatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKecamatan.Location = New System.Drawing.Point(43, 98)
        Me.DGVKecamatan.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVKecamatan.Name = "DGVKecamatan"
        Me.DGVKecamatan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVKecamatan.Size = New System.Drawing.Size(533, 308)
        Me.DGVKecamatan.TabIndex = 0
        '
        'txtNamaKecamatan
        '
        Me.txtNamaKecamatan.Location = New System.Drawing.Point(200, 37)
        Me.txtNamaKecamatan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaKecamatan.Name = "txtNamaKecamatan"
        Me.txtNamaKecamatan.Size = New System.Drawing.Size(265, 22)
        Me.txtNamaKecamatan.TabIndex = 1
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(493, 31)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(107, 37)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(493, 414)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(107, 37)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(40, 431)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 16)
        Me.lblID.TabIndex = 4
        Me.lblID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Kecamatan:"
        '
        'DB_OrmasDataSet
        '
        Me.DB_OrmasDataSet.DataSetName = "DB_OrmasDataSet"
        Me.DB_OrmasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBOrmasDataSetBindingSource
        '
        Me.DBOrmasDataSetBindingSource.DataSource = Me.DB_OrmasDataSet
        Me.DBOrmasDataSetBindingSource.Position = 0
        '
        'FormKecamatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 468)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNamaKecamatan)
        Me.Controls.Add(Me.DGVKecamatan)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormKecamatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Kecamatan"
        CType(Me.DGVKecamatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_OrmasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBOrmasDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVKecamatan As System.Windows.Forms.DataGridView
    Friend WithEvents txtNamaKecamatan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DBOrmasDataSetBindingSource As BindingSource
    Friend WithEvents DB_OrmasDataSet As DB_OrmasDataSet
End Class
