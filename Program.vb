Imports System.Windows.Forms

Namespace StudentManagementSystem
    Public Class Program
        <STAThread>
        Public Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            
            ' Initialize database on startup
            DatabaseHelper.InitializeDatabase()
            
            Application.Run(New MainForm())
        End Sub
    End Class
End Namespace
