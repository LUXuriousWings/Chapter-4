<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YMCA_Calculator
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
        Me.Title = New System.Windows.Forms.Label()
        Me.f_name = New System.Windows.Forms.Label()
        Me.B_date = New System.Windows.Forms.Label()
        Me.C_date = New System.Windows.Forms.Label()
        Me.Name_tb = New System.Windows.Forms.TextBox()
        Me.Btn_calculate = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.total_l = New System.Windows.Forms.Label()
        Me.Btn_exit = New System.Windows.Forms.Button()
        Me.B_day = New System.Windows.Forms.TextBox()
        Me.B_month = New System.Windows.Forms.TextBox()
        Me.B_year = New System.Windows.Forms.TextBox()
        Me.C_month = New System.Windows.Forms.TextBox()
        Me.C_day = New System.Windows.Forms.TextBox()
        Me.C_year = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(165, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(251, 63)
        Me.Title.TabIndex = 0
        Me.Title.Text = "YMCA Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f_name
        '
        Me.f_name.AutoSize = True
        Me.f_name.Location = New System.Drawing.Point(140, 110)
        Me.f_name.Name = "f_name"
        Me.f_name.Size = New System.Drawing.Size(57, 13)
        Me.f_name.TabIndex = 1
        Me.f_name.Text = "First Name"
        '
        'B_date
        '
        Me.B_date.AutoSize = True
        Me.B_date.Location = New System.Drawing.Point(140, 142)
        Me.B_date.Name = "B_date"
        Me.B_date.Size = New System.Drawing.Size(52, 13)
        Me.B_date.TabIndex = 2
        Me.B_date.Text = "Birth date"
        '
        'C_date
        '
        Me.C_date.AutoSize = True
        Me.C_date.Location = New System.Drawing.Point(140, 174)
        Me.C_date.Name = "C_date"
        Me.C_date.Size = New System.Drawing.Size(65, 13)
        Me.C_date.TabIndex = 3
        Me.C_date.Text = "Current date"
        '
        'Name_tb
        '
        Me.Name_tb.Location = New System.Drawing.Point(316, 110)
        Me.Name_tb.Name = "Name_tb"
        Me.Name_tb.Size = New System.Drawing.Size(100, 20)
        Me.Name_tb.TabIndex = 4
        '
        'Btn_calculate
        '
        Me.Btn_calculate.Location = New System.Drawing.Point(316, 271)
        Me.Btn_calculate.Name = "Btn_calculate"
        Me.Btn_calculate.Size = New System.Drawing.Size(75, 23)
        Me.Btn_calculate.TabIndex = 7
        Me.Btn_calculate.Text = "Calculate"
        Me.Btn_calculate.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(143, 271)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clear.TabIndex = 8
        Me.Btn_Clear.Text = "Reset"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(316, 230)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(39, 13)
        Me.Total.TabIndex = 9
        Me.Total.Text = "Label1"
        '
        'total_l
        '
        Me.total_l.AutoSize = True
        Me.total_l.Location = New System.Drawing.Point(143, 230)
        Me.total_l.Name = "total_l"
        Me.total_l.Size = New System.Drawing.Size(34, 13)
        Me.total_l.TabIndex = 10
        Me.total_l.Text = "Total:"
        '
        'Btn_exit
        '
        Me.Btn_exit.Location = New System.Drawing.Point(474, 270)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_exit.TabIndex = 11
        Me.Btn_exit.Text = "Exit "
        Me.Btn_exit.UseVisualStyleBackColor = True
        '
        'B_day
        '
        Me.B_day.AccessibleRole = System.Windows.Forms.AccessibleRole.Document
        Me.B_day.Location = New System.Drawing.Point(316, 142)
        Me.B_day.Name = "B_day"
        Me.B_day.Size = New System.Drawing.Size(39, 20)
        Me.B_day.TabIndex = 12
        '
        'B_month
        '
        Me.B_month.Location = New System.Drawing.Point(361, 142)
        Me.B_month.Name = "B_month"
        Me.B_month.Size = New System.Drawing.Size(39, 20)
        Me.B_month.TabIndex = 13
        '
        'B_year
        '
        Me.B_year.Location = New System.Drawing.Point(406, 142)
        Me.B_year.Name = "B_year"
        Me.B_year.Size = New System.Drawing.Size(39, 20)
        Me.B_year.TabIndex = 14
        '
        'C_month
        '
        Me.C_month.Location = New System.Drawing.Point(361, 171)
        Me.C_month.Name = "C_month"
        Me.C_month.Size = New System.Drawing.Size(39, 20)
        Me.C_month.TabIndex = 16
        '
        'C_day
        '
        Me.C_day.Location = New System.Drawing.Point(316, 171)
        Me.C_day.Name = "C_day"
        Me.C_day.Size = New System.Drawing.Size(39, 20)
        Me.C_day.TabIndex = 15
        '
        'C_year
        '
        Me.C_year.Location = New System.Drawing.Point(406, 171)
        Me.C_year.Name = "C_year"
        Me.C_year.Size = New System.Drawing.Size(39, 20)
        Me.C_year.TabIndex = 17
        '
        'YMCA_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(645, 479)
        Me.Controls.Add(Me.C_year)
        Me.Controls.Add(Me.C_month)
        Me.Controls.Add(Me.C_day)
        Me.Controls.Add(Me.B_year)
        Me.Controls.Add(Me.B_month)
        Me.Controls.Add(Me.B_day)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.total_l)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_calculate)
        Me.Controls.Add(Me.Name_tb)
        Me.Controls.Add(Me.C_date)
        Me.Controls.Add(Me.B_date)
        Me.Controls.Add(Me.f_name)
        Me.Controls.Add(Me.Title)
        Me.Name = "YMCA_Calculator"
        Me.Text = "YMCA Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents f_name As Label
    Friend WithEvents B_date As Label
    Friend WithEvents C_date As Label
    Friend WithEvents Name_tb As TextBox
    Friend WithEvents Btn_calculate As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Total As Label
    Friend WithEvents total_l As Label
    Friend WithEvents Btn_exit As Button
    Friend WithEvents B_day As TextBox
    Friend WithEvents B_month As TextBox
    Friend WithEvents B_year As TextBox
    Friend WithEvents C_month As TextBox
    Friend WithEvents C_day As TextBox
    Friend WithEvents C_year As TextBox
End Class
