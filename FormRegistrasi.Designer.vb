<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegistrasi
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

    'Komponen UI
    Private components As System.ComponentModel.IContainer
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents txtNamaLengkap As TextBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtNoHP As TextBox
    Private WithEvents btnDaftar As Button
    Private WithEvents btnBatal As Button

    'Konstruktor
    Public Sub New()
        InitializeComponent()
    End Sub

    'Inisialisasi Komponen
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()

        'Form Properties
        Me.Text = "Registrasi User Ormas"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Size = New Size(450, 550)

        'Label1 - Header
        Me.Label1.Text = "REGISTRASI USER ORMAS"
        Me.Label1.Font = New Font("Arial", 14, FontStyle.Bold)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(120, 30)

        'Label2 - Nama Lengkap
        Me.Label2.Text = "Nama Lengkap"
        Me.Label2.Location = New Point(50, 100)
        Me.Label2.AutoSize = True

        'Label3 - Username
        Me.Label3.Text = "Username"
        Me.Label3.Location = New Point(50, 160)
        Me.Label3.AutoSize = True

        'Label4 - Password
        Me.Label4.Text = "Password"
        Me.Label4.Location = New Point(50, 220)
        Me.Label4.AutoSize = True

        'Label5 - Email
        Me.Label5.Text = "Email"
        Me.Label5.Location = New Point(50, 280)
        Me.Label5.AutoSize = True

        'Label6 - No HP
        Me.Label6.Text = "No HP"
        Me.Label6.Location = New Point(50, 340)
        Me.Label6.AutoSize = True

        'txtNamaLengkap
        Me.txtNamaLengkap.Size = New Size(300, 25)
        Me.txtNamaLengkap.Location = New Point(50, 120)

        'txtUsername
        Me.txtUsername.Size = New Size(300, 25)
        Me.txtUsername.Location = New Point(50, 180)

        'txtPassword
        Me.txtPassword.Size = New Size(300, 25)
        Me.txtPassword.Location = New Point(50, 240)
        Me.txtPassword.PasswordChar = "●"c

        'txtEmail
        Me.txtEmail.Size = New Size(300, 25)
        Me.txtEmail.Location = New Point(50, 300)

        'txtNoHP
        Me.txtNoHP.Size = New Size(300, 25)
        Me.txtNoHP.Location = New Point(50, 360)

        'btnDaftar
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.Size = New Size(145, 35)
        Me.btnDaftar.Location = New Point(50, 420)
        Me.btnDaftar.BackColor = Color.FromArgb(0, 122, 204)
        Me.btnDaftar.ForeColor = Color.White
        Me.btnDaftar.FlatStyle = FlatStyle.Flat

        'btnBatal
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Size = New Size(145, 35)
        Me.btnBatal.Location = New Point(205, 420)
        Me.btnBatal.BackColor = Color.FromArgb(234, 67, 53)
        Me.btnBatal.ForeColor = Color.White
        Me.btnBatal.FlatStyle = FlatStyle.Flat

        'Menambahkan kontrol ke form
        Me.Controls.AddRange(New Control() {
            Me.Label1,
            Me.Label2,
            Me.Label3,
            Me.Label4,
            Me.Label5,
            Me.Label6,
            Me.txtNamaLengkap,
            Me.txtUsername,
            Me.txtPassword,
            Me.txtEmail,
            Me.txtNoHP,
            Me.btnDaftar,
            Me.btnBatal
        })
    End Sub



End Class
