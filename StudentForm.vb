Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms

Namespace StudentManagementSystem
    Public Partial Class StudentForm
        Inherits Form

        Private currentStudentId As Integer = 0

        Public Sub New()
            InitializeComponent()
            LoadStudents()
        End Sub

        Private Sub LoadStudents()
            Try
                Using conn As OleDbConnection = DatabaseHelper.GetConnection()
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT * FROM Students ORDER BY Id DESC", conn)
                    Dim adapter As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvStudents.DataSource = dt
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function ValidateInput() As Boolean
            If String.IsNullOrWhiteSpace(txtFullName.Text) Then
                MessageBox.Show("Please enter Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFullName.Focus()
                Return False
            End If
            If String.IsNullOrWhiteSpace(txtEmail.Text) Then
                MessageBox.Show("Please enter Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return False
            End If
            If String.IsNullOrWhiteSpace(txtPhone.Text) Then
                MessageBox.Show("Please enter Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.Focus()
                Return False
            End If
            If String.IsNullOrWhiteSpace(txtCourse.Text) Then
                MessageBox.Show("Please enter Course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCourse.Focus()
                Return False
            End If
            Return True
        End Function

        Private Sub ClearFields()
            txtFullName.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            txtCourse.Clear()
            currentStudentId = 0
            btnSave.Text = "➕ Add Student"
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If Not ValidateInput() Then Return

            Try
                Using conn As OleDbConnection = DatabaseHelper.GetConnection()
                    conn.Open()
                    If currentStudentId = 0 Then
                        ' Insert
                        Dim query As String = "INSERT INTO Students (FullName, Email, Phone, Course) VALUES (?, ?, ?, ?)"
                        Using cmd As New OleDbCommand(query, conn)
                            cmd.Parameters.AddWithValue("FullName", txtFullName.Text.Trim())
                            cmd.Parameters.AddWithValue("Email", txtEmail.Text.Trim())
                            cmd.Parameters.AddWithValue("Phone", txtPhone.Text.Trim())
                            cmd.Parameters.AddWithValue("Course", txtCourse.Text.Trim())
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Update
                        Dim query As String = "UPDATE Students SET FullName=?, Email=?, Phone=?, Course=? WHERE Id=?"
                        Using cmd As New OleDbCommand(query, conn)
                            cmd.Parameters.AddWithValue("FullName", txtFullName.Text.Trim())
                            cmd.Parameters.AddWithValue("Email", txtEmail.Text.Trim())
                            cmd.Parameters.AddWithValue("Phone", txtPhone.Text.Trim())
                            cmd.Parameters.AddWithValue("Course", txtCourse.Text.Trim())
                            cmd.Parameters.AddWithValue("Id", currentStudentId)
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                ClearFields()
                LoadStudents()
            Catch ex As Exception
                MessageBox.Show("Error saving student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If currentStudentId = 0 Then
                MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As OleDbConnection = DatabaseHelper.GetConnection()
                        conn.Open()
                        Dim query As String = "DELETE FROM Students WHERE Id=?"
                        Using cmd As New OleDbCommand(query, conn)
                            cmd.Parameters.AddWithValue("Id", currentStudentId)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                    LoadStudents()
                Catch ex As Exception
                    MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            ClearFields()
        End Sub

        Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)
                currentStudentId = Convert.ToInt32(row.Cells("Id").Value)
                txtFullName.Text = row.Cells("FullName").Value.ToString()
                txtEmail.Text = row.Cells("Email").Value.ToString()
                txtPhone.Text = row.Cells("Phone").Value.ToString()
                txtCourse.Text = row.Cells("Course").Value.ToString()
                btnSave.Text = "💾 Update Student"
            End If
        End Sub
    End Class
End Namespace
