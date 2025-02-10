<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblTotalOrmas = New System.Windows.Forms.Label()
        Me.CmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.CmbKelurahan = New System.Windows.Forms.ComboBox()
        Me.BtnFilter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 300)
        Me.DataGridView1.TabIndex = 0
        '
        ' LblTotalOrmas
        '
        Me.LblTotalOrmas.AutoSize = True
        Me.LblTotalOrmas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalOrmas.Location = New System.Drawing.Point(20, 400)
        Me.LblTotalOrmas.Name = "LblTotalOrmas"
        Me.LblTotalOrmas.Size = New System.Drawing.Size(114, 19)
        Me.LblTotalOrmas.TabIndex = 1
        Me.LblTotalOrmas.Text = "Total Ormas: 0"
        '
        ' CmbKecamatan
        '
        Me.CmbKecamatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbKecamatan.FormattingEnabled = True
        Me.CmbKecamatan.Location = New System.Drawing.Point(20, 20)
        Me.CmbKecamatan.Name = "CmbKecamatan"
        Me.CmbKecamatan.Size = New System.Drawing.Size(150, 21)
        Me.CmbKecamatan.TabIndex = 2
        '
        ' CmbKelurahan
        '
        Me.CmbKelurahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbKelurahan.FormattingEnabled = True
        Me.CmbKelurahan.Location = New System.Drawing.Point(180, 20)
        Me.CmbKelurahan.Name = "CmbKelurahan"
        Me.CmbKelurahan.Size = New System.Drawing.Size(150, 21)
        Me.CmbKelurahan.TabIndex = 3
        '
        ' BtnFilter
        '
        Me.BtnFilter.Location = New System.Drawing.Point(350, 20)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(75, 23)
        Me.BtnFilter.TabIndex = 4
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        ' FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.BtnFilter)
        Me.Controls.Add(Me.CmbKelurahan)
        Me.Controls.Add(Me.CmbKecamatan)
        Me.Controls.Add(Me.LblTotalOrmas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormLaporan"
        Me.Text = "Laporan Ormas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblTotalOrmas As Label
    Friend WithEvents CmbKecamatan As ComboBox
    Friend WithEvents CmbKelurahan As ComboBox
    Friend WithEvents BtnFilter As Button
End Class
