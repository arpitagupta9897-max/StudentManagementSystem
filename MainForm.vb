Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.OleDb

Namespace StudentManagementSystem
    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
            LoadDashboardData()
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Additional initialization if needed
        End Sub

        Private Sub LoadDashboardData()
            Try
                Using conn As OleDbConnection = DatabaseHelper.GetConnection()
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM Students", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblTotalStudents.Text = count.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
            pnlMainContent.Controls.Clear()
            pnlMainContent.Controls.Add(pnlDashboardContent)
            pnlDashboardContent.Visible = True
            pnlDashboardContent.Dock = DockStyle.Fill
            LoadDashboardData()
        End Sub

        Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
            pnlDashboardContent.Visible = False
            Dim studentForm As New StudentForm()
            studentForm.TopLevel = False
            studentForm.FormBorderStyle = FormBorderStyle.None
            studentForm.Dock = DockStyle.Fill
            pnlMainContent.Controls.Clear()
            pnlMainContent.Controls.Add(studentForm)
            studentForm.Show()
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        End Sub
    End Class
End Namespace
