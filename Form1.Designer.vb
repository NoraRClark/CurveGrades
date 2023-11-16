<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurveGrades
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
        Me.btnAnalyzeGrades = New System.Windows.Forms.Button()
        Me.lblNumExams = New System.Windows.Forms.Label()
        Me.txtNumExams = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.txtStandardDeviation = New System.Windows.Forms.TextBox()
        Me.lblStandardDeviation = New System.Windows.Forms.Label()
        Me.dgvDisplayGrades = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDisplayGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnalyzeGrades
        '
        Me.btnAnalyzeGrades.Location = New System.Drawing.Point(12, 12)
        Me.btnAnalyzeGrades.Name = "btnAnalyzeGrades"
        Me.btnAnalyzeGrades.Size = New System.Drawing.Size(192, 34)
        Me.btnAnalyzeGrades.TabIndex = 0
        Me.btnAnalyzeGrades.Text = "Analyze Grades"
        Me.btnAnalyzeGrades.UseVisualStyleBackColor = True
        '
        'lblNumExams
        '
        Me.lblNumExams.AutoSize = True
        Me.lblNumExams.Location = New System.Drawing.Point(20, 60)
        Me.lblNumExams.Name = "lblNumExams"
        Me.lblNumExams.Size = New System.Drawing.Size(93, 13)
        Me.lblNumExams.TabIndex = 1
        Me.lblNumExams.Text = "Number of Exams:"
        '
        'txtNumExams
        '
        Me.txtNumExams.Location = New System.Drawing.Point(119, 57)
        Me.txtNumExams.Name = "txtNumExams"
        Me.txtNumExams.ReadOnly = True
        Me.txtNumExams.Size = New System.Drawing.Size(88, 20)
        Me.txtNumExams.TabIndex = 2
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(119, 83)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.ReadOnly = True
        Me.txtMean.Size = New System.Drawing.Size(88, 20)
        Me.txtMean.TabIndex = 4
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(76, 86)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(37, 13)
        Me.lblMean.TabIndex = 3
        Me.lblMean.Text = "Mean:"
        '
        'txtStandardDeviation
        '
        Me.txtStandardDeviation.Location = New System.Drawing.Point(119, 109)
        Me.txtStandardDeviation.Name = "txtStandardDeviation"
        Me.txtStandardDeviation.ReadOnly = True
        Me.txtStandardDeviation.Size = New System.Drawing.Size(88, 20)
        Me.txtStandardDeviation.TabIndex = 6
        '
        'lblStandardDeviation
        '
        Me.lblStandardDeviation.AutoSize = True
        Me.lblStandardDeviation.Location = New System.Drawing.Point(12, 112)
        Me.lblStandardDeviation.Name = "lblStandardDeviation"
        Me.lblStandardDeviation.Size = New System.Drawing.Size(101, 13)
        Me.lblStandardDeviation.TabIndex = 5
        Me.lblStandardDeviation.Text = "Standard Deviation:"
        '
        'dgvDisplayGrades
        '
        Me.dgvDisplayGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDisplayGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplayGrades.Location = New System.Drawing.Point(222, 12)
        Me.dgvDisplayGrades.Name = "dgvDisplayGrades"
        Me.dgvDisplayGrades.ReadOnly = True
        Me.dgvDisplayGrades.RowHeadersVisible = False
        Me.dgvDisplayGrades.Size = New System.Drawing.Size(195, 331)
        Me.dgvDisplayGrades.TabIndex = 8
        '
        'frmCurveGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 349)
        Me.Controls.Add(Me.dgvDisplayGrades)
        Me.Controls.Add(Me.txtStandardDeviation)
        Me.Controls.Add(Me.lblStandardDeviation)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.txtNumExams)
        Me.Controls.Add(Me.lblNumExams)
        Me.Controls.Add(Me.btnAnalyzeGrades)
        Me.Name = "frmCurveGrades"
        Me.Text = "Curve Grades"
        CType(Me.dgvDisplayGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalyzeGrades As Button
    Friend WithEvents lblNumExams As Label
    Friend WithEvents txtNumExams As TextBox
    Friend WithEvents txtMean As TextBox
    Friend WithEvents lblMean As Label
    Friend WithEvents txtStandardDeviation As TextBox
    Friend WithEvents lblStandardDeviation As Label
    Friend WithEvents dgvDisplayGrades As DataGridView
End Class
