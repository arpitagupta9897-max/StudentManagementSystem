Imports System.Drawing
Imports System.Windows.Forms

Namespace StudentManagementSystem
    Partial Class MainForm
        Private components As System.ComponentModel.IContainer
        Private pnlSidebar As Panel
        Private WithEvents btnDashboard As Button
        Private WithEvents btnManageStudents As Button
        Private WithEvents btnExit As Button
        Private pnlLogo As Panel
        Private lblLogo As Label
        Private pnlHeader As Panel
        Private lblHeaderTitle As Label
        Public pnlMainContent As Panel
        Private pnlDashboardContent As Panel
        Private pnlStatsCard As Panel
        Private lblStatsTitle As Label
        Private lblTotalStudents As Label

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.pnlSidebar = New System.Windows.Forms.Panel()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnManageStudents = New System.Windows.Forms.Button()
            Me.btnDashboard = New System.Windows.Forms.Button()
            Me.pnlLogo = New System.Windows.Forms.Panel()
            Me.lblLogo = New System.Windows.Forms.Label()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblHeaderTitle = New System.Windows.Forms.Label()
            Me.pnlMainContent = New System.Windows.Forms.Panel()
            Me.pnlDashboardContent = New System.Windows.Forms.Panel()
            Me.pnlStatsCard = New System.Windows.Forms.Panel()
            Me.lblTotalStudents = New System.Windows.Forms.Label()
            Me.lblStatsTitle = New System.Windows.Forms.Label()
            Me.pnlSidebar.SuspendLayout()
            Me.pnlLogo.SuspendLayout()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMainContent.SuspendLayout()
            Me.pnlDashboardContent.SuspendLayout()
            Me.pnlStatsCard.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlSidebar
            '
            Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.pnlSidebar.Controls.Add(Me.btnExit)
            Me.pnlSidebar.Controls.Add(Me.btnManageStudents)
            Me.pnlSidebar.Controls.Add(Me.btnDashboard)
            Me.pnlSidebar.Controls.Add(Me.pnlLogo)
            Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
            Me.pnlSidebar.Name = "pnlSidebar"
            Me.pnlSidebar.Size = New System.Drawing.Size(220, 600)
            Me.pnlSidebar.TabIndex = 0
            '
            'btnExit
            '
            Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.btnExit.FlatAppearance.BorderSize = 0
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.btnExit.ForeColor = System.Drawing.Color.White
            Me.btnExit.Location = New System.Drawing.Point(0, 540)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
            Me.btnExit.Size = New System.Drawing.Size(220, 60)
            Me.btnExit.TabIndex = 3
            Me.btnExit.Text = "🚪 Exit"
            Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnManageStudents
            '
            Me.btnManageStudents.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnManageStudents.FlatAppearance.BorderSize = 0
            Me.btnManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnManageStudents.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.btnManageStudents.ForeColor = System.Drawing.Color.White
            Me.btnManageStudents.Location = New System.Drawing.Point(0, 140)
            Me.btnManageStudents.Name = "btnManageStudents"
            Me.btnManageStudents.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
            Me.btnManageStudents.Size = New System.Drawing.Size(220, 60)
            Me.btnManageStudents.TabIndex = 2
            Me.btnManageStudents.Text = "👥 Manage Students"
            Me.btnManageStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnManageStudents.UseVisualStyleBackColor = True
            '
            'btnDashboard
            '
            Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnDashboard.FlatAppearance.BorderSize = 0
            Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.btnDashboard.ForeColor = System.Drawing.Color.White
            Me.btnDashboard.Location = New System.Drawing.Point(0, 80)
            Me.btnDashboard.Name = "btnDashboard"
            Me.btnDashboard.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
            Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
            Me.btnDashboard.TabIndex = 1
            Me.btnDashboard.Text = "📊 Dashboard"
            Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDashboard.UseVisualStyleBackColor = True
            '
            'pnlLogo
            '
            Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.pnlLogo.Controls.Add(Me.lblLogo)
            Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
            Me.pnlLogo.Name = "pnlLogo"
            Me.pnlLogo.Size = New System.Drawing.Size(220, 80)
            Me.pnlLogo.TabIndex = 0
            '
            'lblLogo
            '
            Me.lblLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
            Me.lblLogo.ForeColor = System.Drawing.Color.White
            Me.lblLogo.Location = New System.Drawing.Point(0, 0)
            Me.lblLogo.Name = "lblLogo"
            Me.lblLogo.Size = New System.Drawing.Size(220, 80)
            Me.lblLogo.TabIndex = 0
            Me.lblLogo.Text = "🎓 SMS"
            Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(780, 80)
            Me.pnlHeader.TabIndex = 1
            '
            'lblHeaderTitle
            '
            Me.lblHeaderTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
            Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
            Me.lblHeaderTitle.Name = "lblHeaderTitle"
            Me.lblHeaderTitle.Size = New System.Drawing.Size(780, 80)
            Me.lblHeaderTitle.TabIndex = 0
            Me.lblHeaderTitle.Text = "Student Management System"
            Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlMainContent
            '
            Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.pnlMainContent.Controls.Add(Me.pnlDashboardContent)
            Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMainContent.Location = New System.Drawing.Point(220, 80)
            Me.pnlMainContent.Name = "pnlMainContent"
            Me.pnlMainContent.Size = New System.Drawing.Size(780, 520)
            Me.pnlMainContent.TabIndex = 2
            '
            'pnlDashboardContent
            '
            Me.pnlDashboardContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.pnlDashboardContent.Controls.Add(Me.pnlStatsCard)
            Me.pnlDashboardContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDashboardContent.Location = New System.Drawing.Point(0, 0)
            Me.pnlDashboardContent.Name = "pnlDashboardContent"
            Me.pnlDashboardContent.Size = New System.Drawing.Size(780, 520)
            Me.pnlDashboardContent.TabIndex = 0
            '
            'pnlStatsCard
            '
            Me.pnlStatsCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.pnlStatsCard.Controls.Add(Me.lblTotalStudents)
            Me.pnlStatsCard.Controls.Add(Me.lblStatsTitle)
            Me.pnlStatsCard.Location = New System.Drawing.Point(40, 40)
            Me.pnlStatsCard.Name = "pnlStatsCard"
            Me.pnlStatsCard.Size = New System.Drawing.Size(250, 150)
            Me.pnlStatsCard.TabIndex = 0
            '
            'lblTotalStudents
            '
            Me.lblTotalStudents.AutoSize = True
            Me.lblTotalStudents.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalStudents.ForeColor = System.Drawing.Color.White
            Me.lblTotalStudents.Location = New System.Drawing.Point(20, 50)
            Me.lblTotalStudents.Name = "lblTotalStudents"
            Me.lblTotalStudents.Size = New System.Drawing.Size(70, 81)
            Me.lblTotalStudents.TabIndex = 1
            Me.lblTotalStudents.Text = "0"
            '
            'lblStatsTitle
            '
            Me.lblStatsTitle.AutoSize = True
            Me.lblStatsTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.lblStatsTitle.ForeColor = System.Drawing.Color.LightGray
            Me.lblStatsTitle.Location = New System.Drawing.Point(20, 20)
            Me.lblStatsTitle.Name = "lblStatsTitle"
            Me.lblStatsTitle.Size = New System.Drawing.Size(135, 28)
            Me.lblStatsTitle.TabIndex = 0
            Me.lblStatsTitle.Text = "Total Students"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1000, 600)
            Me.Controls.Add(Me.pnlMainContent)
            Me.Controls.Add(Me.pnlHeader)
            Me.Controls.Add(Me.pnlSidebar)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Student Management System - Dashboard"
            Me.pnlSidebar.ResumeLayout(False)
            Me.pnlLogo.ResumeLayout(False)
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlMainContent.ResumeLayout(False)
            Me.pnlDashboardContent.ResumeLayout(False)
            Me.pnlStatsCard.ResumeLayout(False)
            Me.pnlStatsCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
