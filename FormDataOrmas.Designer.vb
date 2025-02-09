<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataOrmas
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
        Me.DGVOrmas = New System.Windows.Forms.DataGridView()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnProsesVerifikasi = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVOrmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' DataGridView Ormas
        Me.DGVOrmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrmas.Location = New System.Drawing.Point(30, 80)
        Me.DGVOrmas.Name = "DGVOrmas"
        Me.DGVOrmas.Size = New System.Drawing.Size(600, 300)
        Me.DGVOrmas.TabIndex = 0

        ' ComboBox Status
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"", "Daftar", "Proses", "Aktif"})
        Me.cmbStatus.Location = New System.Drawing.Point(120, 30)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(150, 21)
        Me.cmbStatus.TabIndex = 1

        ' Label Status
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter Berdasarkan Status:"

        ' Button Proses Verifikasi
        Me.btnProsesVerifikasi.Location = New System.Drawing.Point(500, 400)
        Me.btnProsesVerifikasi.Name = "btnProsesVerifikasi"
        Me.btnProsesVerifikasi.Size = New System.Drawing.Size(130, 30)
        Me.btnProsesVerifikasi.TabIndex = 3
        Me.btnProsesVerifikasi.Text = "Verifikasi"
        Me.btnProsesVerifikasi.UseVisualStyleBackColor = True

        ' Label ID (Hidden Label for Selected Ormas ID)
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 400)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 4
        Me.lblID.Visible = False

        ' FormDataOrmas
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 450)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnProsesVerifikasi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.DGVOrmas)
        Me.Name = "FormDataOrmas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Ormas"
        CType(Me.DGVOrmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents DGVOrmas As System.Windows.Forms.DataGridView
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnProsesVerifikasi As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
