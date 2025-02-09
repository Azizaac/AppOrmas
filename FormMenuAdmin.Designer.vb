<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuAdmin
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


    ' Deklarasi komponen UI
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents lblUser As Label
    Private WithEvents lblLevel As Label
    Private WithEvents btnDashboard As Button
    Private WithEvents btnKelurahan As Button
    Private WithEvents btnKecamatan As Button
    Private WithEvents btnOrmas As Button
    Private WithEvents btnUser As Button
    Private WithEvents btnLaporan As Button
    Private WithEvents btnLogout As Button

    ' Konstruktor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Inisialisasi komponen UI
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnKelurahan = New System.Windows.Forms.Button()
        Me.btnKecamatan = New System.Windows.Forms.Button()
        Me.btnOrmas = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblLevel)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 419)
        Me.Panel1.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(20, 20)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 23)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Admin"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(20, 45)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(103, 19)
        Me.lblLevel.TabIndex = 1
        Me.lblLevel.Text = "Super Admin"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(10, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(230, 40)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 60)
        Me.Panel2.TabIndex = 2
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(386, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SISTEM PENDAFTARAN ORMAS"
        '
        'btnKelurahan
        '
        Me.btnKelurahan.Location = New System.Drawing.Point(0, 0)
        Me.btnKelurahan.Name = "btnKelurahan"
        Me.btnKelurahan.Size = New System.Drawing.Size(75, 23)
        Me.btnKelurahan.TabIndex = 0
        '
        'btnKecamatan
        '
        Me.btnKecamatan.Location = New System.Drawing.Point(0, 0)
        Me.btnKecamatan.Name = "btnKecamatan"
        Me.btnKecamatan.Size = New System.Drawing.Size(75, 23)
        Me.btnKecamatan.TabIndex = 0
        '
        'btnOrmas
        '
        Me.btnOrmas.Location = New System.Drawing.Point(0, 0)
        Me.btnOrmas.Name = "btnOrmas"
        Me.btnOrmas.Size = New System.Drawing.Size(75, 23)
        Me.btnOrmas.TabIndex = 0
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(0, 0)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(75, 23)
        Me.btnUser.TabIndex = 0
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(0, 0)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(75, 23)
        Me.btnLaporan.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 0
        '
        'FormMenuAdmin
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(930, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.IsMdiContainer = True
        Me.Name = "FormMenuAdmin"
        Me.Text = "Menu Admin - Sistem Pendaftaran Ormas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    ' Form Load untuk mengatur posisi header

    Private Sub SetupButtons()
        btnDashboard.Text = "Dashboard"
        btnDashboard.Size = New Size(230, 40)
        btnDashboard.Location = New Point(10, 100)
        btnDashboard.BackColor = Color.FromArgb(52, 73, 94)
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = Color.White
        Panel1.Controls.Add(btnDashboard)
    End Sub

    ' Event klik tombol Logout

End Class
