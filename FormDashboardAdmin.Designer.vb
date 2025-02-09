<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardAdmin
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProses = New System.Windows.Forms.Label()
        Me.lblAktif = New System.Windows.Forms.Label()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProses
        '
        Me.lblProses.AutoSize = True
        Me.lblProses.Location = New System.Drawing.Point(428, 181)
        Me.lblProses.Name = "lblProses"
        Me.lblProses.Size = New System.Drawing.Size(50, 16)
        Me.lblProses.TabIndex = 1
        Me.lblProses.Text = "Proses"
        '
        'lblAktif
        '
        Me.lblAktif.AutoSize = True
        Me.lblAktif.Location = New System.Drawing.Point(428, 236)
        Me.lblAktif.Name = "lblAktif"
        Me.lblAktif.Size = New System.Drawing.Size(32, 16)
        Me.lblAktif.TabIndex = 1
        Me.lblAktif.Text = "Aktif"
        '
        'lblDaftar
        '
        Me.lblDaftar.AutoSize = True
        Me.lblDaftar.Location = New System.Drawing.Point(428, 123)
        Me.lblDaftar.Name = "lblDaftar"
        Me.lblDaftar.Size = New System.Drawing.Size(43, 16)
        Me.lblDaftar.TabIndex = 0
        Me.lblDaftar.Text = "Daftar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jumlah Daftar :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Proses :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Jumlah Aktif :"
        '
        'FormDashboardAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAktif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblProses)
        Me.Controls.Add(Me.lblDaftar)
        Me.Name = "FormDashboardAdmin"
        Me.Text = "FormDashboardAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProses As Label
    Friend WithEvents lblAktif As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
