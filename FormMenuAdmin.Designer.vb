﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnKelurahan = New System.Windows.Forms.Button()
        Me.btnKecamatan = New System.Windows.Forms.Button()
        Me.btnOrmas = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.btnKelurahan)
        Me.Panel1.Controls.Add(Me.btnKecamatan)
        Me.Panel1.Controls.Add(Me.btnOrmas)
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnLaporan)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 446)
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
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(10, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(230, 40)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnKelurahan
        '
        Me.btnKelurahan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnKelurahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKelurahan.ForeColor = System.Drawing.Color.White
        Me.btnKelurahan.Location = New System.Drawing.Point(10, 150)
        Me.btnKelurahan.Name = "btnKelurahan"
        Me.btnKelurahan.Size = New System.Drawing.Size(230, 40)
        Me.btnKelurahan.TabIndex = 3
        Me.btnKelurahan.Text = "Kelurahan"
        Me.btnKelurahan.UseVisualStyleBackColor = False
        '
        'btnKecamatan
        '
        Me.btnKecamatan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnKecamatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKecamatan.ForeColor = System.Drawing.Color.White
        Me.btnKecamatan.Location = New System.Drawing.Point(10, 200)
        Me.btnKecamatan.Name = "btnKecamatan"
        Me.btnKecamatan.Size = New System.Drawing.Size(230, 40)
        Me.btnKecamatan.TabIndex = 4
        Me.btnKecamatan.Text = "Kecamatan"
        Me.btnKecamatan.UseVisualStyleBackColor = False
        '
        'btnOrmas
        '
        Me.btnOrmas.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnOrmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrmas.ForeColor = System.Drawing.Color.White
        Me.btnOrmas.Location = New System.Drawing.Point(10, 250)
        Me.btnOrmas.Name = "btnOrmas"
        Me.btnOrmas.Size = New System.Drawing.Size(230, 40)
        Me.btnOrmas.TabIndex = 5
        Me.btnOrmas.Text = "Ormas"
        Me.btnOrmas.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(10, 300)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(230, 40)
        Me.btnUser.TabIndex = 6
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(10, 350)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(230, 40)
        Me.btnLaporan.TabIndex = 7
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(10, 400)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(230, 40)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.lblHeader.Location = New System.Drawing.Point(20, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(386, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SISTEM PENDAFTARAN ORMAS"
        '
        'FormMenuAdmin
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(930, 506)
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

    ' Event klik tombol Logout

End Class
