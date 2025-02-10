<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKelurahan
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
        Me.DGVKelurahan = New System.Windows.Forms.DataGridView()
        Me.cmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.txtNamaKelurahan = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVKelurahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVKelurahan
        '
        Me.DGVKelurahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKelurahan.Location = New System.Drawing.Point(40, 148)
        Me.DGVKelurahan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVKelurahan.Name = "DGVKelurahan"
        Me.DGVKelurahan.RowHeadersWidth = 51
        Me.DGVKelurahan.Size = New System.Drawing.Size(667, 308)
        Me.DGVKelurahan.TabIndex = 0
        '
        'cmbKecamatan
        '
        Me.cmbKecamatan.Location = New System.Drawing.Point(158, 28)
        Me.cmbKecamatan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbKecamatan.Name = "cmbKecamatan"
        Me.cmbKecamatan.Size = New System.Drawing.Size(160, 24)
        Me.cmbKecamatan.TabIndex = 9
        '
        'txtNamaKelurahan
        '
        Me.txtNamaKelurahan.Location = New System.Drawing.Point(158, 60)
        Me.txtNamaKelurahan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNamaKelurahan.Name = "txtNamaKelurahan"
        Me.txtNamaKelurahan.Size = New System.Drawing.Size(160, 22)
        Me.txtNamaKelurahan.TabIndex = 8
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(600, 70)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(107, 37)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(600, 25)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(107, 37)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(40, 492)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 16)
        Me.lblID.TabIndex = 5
        Me.lblID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kecamatan:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Kelurahan:"
        '
        'FormKelurahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 492)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNamaKelurahan)
        Me.Controls.Add(Me.cmbKecamatan)
        Me.Controls.Add(Me.DGVKelurahan)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormKelurahan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Kelurahan"
        CType(Me.DGVKelurahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVKelurahan As System.Windows.Forms.DataGridView
    Friend WithEvents cmbKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaKelurahan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
