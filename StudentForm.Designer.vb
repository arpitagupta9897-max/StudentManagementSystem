Imports System.Drawing
Imports System.Windows.Forms

Namespace StudentManagementSystem
    Partial Class StudentForm
        Private components As System.ComponentModel.IContainer

        Private lblTitle As Label
        Private lblFullName As Label
        Private txtFullName As TextBox
        Private lblEmail As Label
        Private txtEmail As TextBox
        Private lblPhone As Label
        Private txtPhone As TextBox
        Private lblCourse As Label
        Private txtCourse As TextBox

        Private WithEvents btnSave As Button
        Private WithEvents btnDelete As Button
        Private WithEvents btnClear As Button

        Private WithEvents dgvStudents As DataGridView

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblFullName = New System.Windows.Forms.Label()
            Me.txtFullName = New System.Windows.Forms.TextBox()
            Me.lblEmail = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.lblPhone = New System.Windows.Forms.Label()
            Me.txtPhone = New System.Windows.Forms.TextBox()
            Me.lblCourse = New System.Windows.Forms.Label()
            Me.txtCourse = New System.Windows.Forms.TextBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.dgvStudents = New System.Windows.Forms.DataGridView()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(30, 20)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(240, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Manage Students"
            '
            'lblFullName
            '
            Me.lblFullName.AutoSize = True
            Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblFullName.ForeColor = System.Drawing.Color.LightGray
            Me.lblFullName.Location = New System.Drawing.Point(35, 80)
            Me.lblFullName.Name = "lblFullName"
            Me.lblFullName.Size = New System.Drawing.Size(87, 23)
            Me.lblFullName.TabIndex = 1
            Me.lblFullName.Text = "Full Name"
            '
            'txtFullName
            '
            Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtFullName.ForeColor = System.Drawing.Color.White
            Me.txtFullName.Location = New System.Drawing.Point(35, 105)
            Me.txtFullName.Name = "txtFullName"
            Me.txtFullName.Size = New System.Drawing.Size(250, 30)
            Me.txtFullName.TabIndex = 2
            '
            'lblEmail
            '
            Me.lblEmail.AutoSize = True
            Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblEmail.ForeColor = System.Drawing.Color.LightGray
            Me.lblEmail.Location = New System.Drawing.Point(310, 80)
            Me.lblEmail.Name = "lblEmail"
            Me.lblEmail.Size = New System.Drawing.Size(51, 23)
            Me.lblEmail.TabIndex = 3
            Me.lblEmail.Text = "Email"
            '
            'txtEmail
            '
            Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtEmail.ForeColor = System.Drawing.Color.White
            Me.txtEmail.Location = New System.Drawing.Point(310, 105)
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(250, 30)
            Me.txtEmail.TabIndex = 4
            '
            'lblPhone
            '
            Me.lblPhone.AutoSize = True
            Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblPhone.ForeColor = System.Drawing.Color.LightGray
            Me.lblPhone.Location = New System.Drawing.Point(35, 145)
            Me.lblPhone.Name = "lblPhone"
            Me.lblPhone.Size = New System.Drawing.Size(59, 23)
            Me.lblPhone.TabIndex = 5
            Me.lblPhone.Text = "Phone"
            '
            'txtPhone
            '
            Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPhone.ForeColor = System.Drawing.Color.White
            Me.txtPhone.Location = New System.Drawing.Point(35, 170)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(250, 30)
            Me.txtPhone.TabIndex = 6
            '
            'lblCourse
            '
            Me.lblCourse.AutoSize = True
            Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblCourse.ForeColor = System.Drawing.Color.LightGray
            Me.lblCourse.Location = New System.Drawing.Point(310, 145)
            Me.lblCourse.Name = "lblCourse"
            Me.lblCourse.Size = New System.Drawing.Size(63, 23)
            Me.lblCourse.TabIndex = 7
            Me.lblCourse.Text = "Course"
            '
            'txtCourse
            '
            Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtCourse.ForeColor = System.Drawing.Color.White
            Me.txtCourse.Location = New System.Drawing.Point(310, 170)
            Me.txtCourse.Name = "txtCourse"
            Me.txtCourse.Size = New System.Drawing.Size(250, 30)
            Me.txtCourse.TabIndex = 8
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(35, 220)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(150, 35)
            Me.btnSave.TabIndex = 9
            Me.btnSave.Text = "➕ Add Student"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Location = New System.Drawing.Point(200, 220)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(120, 35)
            Me.btnDelete.TabIndex = 10
            Me.btnDelete.Text = "🗑 Delete"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.Location = New System.Drawing.Point(335, 220)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(100, 35)
            Me.btnClear.TabIndex = 11
            Me.btnClear.Text = "🔄 Clear"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'dgvStudents
            '
            Me.dgvStudents.AllowUserToAddRows = False
            Me.dgvStudents.AllowUserToDeleteRows = False
            Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvStudents.EnableHeadersVisualStyles = False
            Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(65, Byte), Integer))
            Me.dgvStudents.Location = New System.Drawing.Point(35, 280)
            Me.dgvStudents.Name = "dgvStudents"
            Me.dgvStudents.ReadOnly = True
            Me.dgvStudents.RowHeadersVisible = False
            Me.dgvStudents.RowHeadersWidth = 51
            Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvStudents.Size = New System.Drawing.Size(710, 200)
            Me.dgvStudents.TabIndex = 12
            '
            'StudentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(780, 520)
            Me.Controls.Add(Me.dgvStudents)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.txtCourse)
            Me.Controls.Add(Me.lblCourse)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.lblPhone)
            Me.Controls.Add(Me.txtEmail)
            Me.Controls.Add(Me.lblEmail)
            Me.Controls.Add(Me.txtFullName)
            Me.Controls.Add(Me.lblFullName)
            Me.Controls.Add(Me.lblTitle)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "StudentForm"
            Me.Text = "Student Form"
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
    End Class
End Namespace
