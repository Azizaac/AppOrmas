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

        ' DataGridView Kelurahan
        Me.DGVKelurahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVKelurahan.Location = New System.Drawing.Point(30, 120)
        Me.DGVKelurahan.Name = "DGVKelurahan"
        Me.DGVKelurahan.Size = New System.Drawing.Size(500, 250)
        Me.DGVKelurahan.TabIndex = 0


        Me.btnSimpan.Size = New System.Drawing.Size(80, 30)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True

        ' Button Hapus
        Me.btnHapus.Location = New System.Drawing.Point(450, 20)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(80, 30)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True

        ' Label ID (Hidden Label for Selected Kelurahan ID)
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 400)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 5
        Me.lblID.Visible = False

        ' Label Kecamatan
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kecamatan:"

        ' Label Nama Kelurahan
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Kelurahan:"

        ' FormKelurahan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNamaKelurahan)
        Me.Controls.Add(Me.cmbKecamatan)
        Me.Controls.Add(Me.DGVKelurahan)
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
