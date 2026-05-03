Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.IO

Namespace StudentManagementSystem
    Public Class DatabaseHelper
        ' Use Jet OLEDB for MS Access .mdb
        Private Shared ReadOnly ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentDb.mdb;"

        Public Shared Function GetConnection() As OleDbConnection
            Return New OleDbConnection(ConnectionString)
        End Function

        Public Shared Sub InitializeDatabase()
            Try
                If Not File.Exists("StudentDb.mdb") Then
                    ' Create MDB file using ADOX via late binding
                    Dim catalogType As Type = Type.GetTypeFromProgID("ADOX.Catalog")
                    Dim catalog As Object = Activator.CreateInstance(catalogType)
                    catalogType.InvokeMember("Create", Reflection.BindingFlags.InvokeMethod, Nothing, catalog, New Object() {ConnectionString})

                    ' Create table
                    Using conn As New OleDbConnection(ConnectionString)
                        conn.Open()
                        Dim createTableQuery As String = "CREATE TABLE Students (" & _
                            "Id AUTOINCREMENT PRIMARY KEY, " & _
                            "FullName VARCHAR(100) NOT NULL, " & _
                            "Email VARCHAR(100) NOT NULL, " & _
                            "Phone VARCHAR(20) NOT NULL, " & _
                            "Course VARCHAR(100) NOT NULL, " & _
                            "EnrollmentDate DATETIME DEFAULT NOW())"
                        Using cmd As New OleDbCommand(createTableQuery, conn)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Database Initialization Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
