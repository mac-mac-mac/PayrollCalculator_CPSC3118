<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPaycheckCalc = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFicaNum = New System.Windows.Forms.Label()
        Me.lblFed = New System.Windows.Forms.Label()
        Me.lblFedNum = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblStateNum = New System.Windows.Forms.Label()
        Me.lblNetPaycheck = New System.Windows.Forms.Label()
        Me.lblNetPaycheckNum = New System.Windows.Forms.Label()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = Global.PayrollCalculator_CPSC3118.My.Resources.Resources.payroll
        Me.picPayroll.Location = New System.Drawing.Point(0, 0)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(300, 200)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(400, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Payroll Calculator"
        '
        'lblPaycheckCalc
        '
        Me.lblPaycheckCalc.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheckCalc.Location = New System.Drawing.Point(458, 89)
        Me.lblPaycheckCalc.Name = "lblPaycheckCalc"
        Me.lblPaycheckCalc.Size = New System.Drawing.Size(197, 80)
        Me.lblPaycheckCalc.TabIndex = 2
        Me.lblPaycheckCalc.Text = "Paycheck Calculation"
        Me.lblPaycheckCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(198, 225)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(191, 25)
        Me.lblGrossPay.TabIndex = 3
        Me.lblGrossPay.Text = "Enter Gross Pay:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(502, 219)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 31)
        Me.txtGrossPay.TabIndex = 4
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCompute.Location = New System.Drawing.Point(115, 275)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(150, 50)
        Me.btnCompute.TabIndex = 5
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.Window
        Me.btnClear.Location = New System.Drawing.Point(336, 275)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnExit.Location = New System.Drawing.Point(562, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFica
        '
        Me.lblFica.AutoSize = True
        Me.lblFica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFica.Location = New System.Drawing.Point(112, 346)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(45, 16)
        Me.lblFica.TabIndex = 8
        Me.lblFica.Text = "FICA:"
        '
        'lblFicaNum
        '
        Me.lblFicaNum.AutoSize = True
        Me.lblFicaNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaNum.Location = New System.Drawing.Point(233, 346)
        Me.lblFicaNum.Name = "lblFicaNum"
        Me.lblFicaNum.Size = New System.Drawing.Size(32, 16)
        Me.lblFicaNum.TabIndex = 9
        Me.lblFicaNum.Text = "123"
        '
        'lblFed
        '
        Me.lblFed.AutoSize = True
        Me.lblFed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFed.Location = New System.Drawing.Point(333, 345)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(96, 16)
        Me.lblFed.TabIndex = 10
        Me.lblFed.Text = "Federal Tax:"
        '
        'lblFedNum
        '
        Me.lblFedNum.AutoSize = True
        Me.lblFedNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedNum.Location = New System.Drawing.Point(454, 345)
        Me.lblFedNum.Name = "lblFedNum"
        Me.lblFedNum.Size = New System.Drawing.Size(32, 16)
        Me.lblFedNum.TabIndex = 11
        Me.lblFedNum.Text = "456"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(559, 345)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(78, 16)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State Tax:"
        '
        'lblStateNum
        '
        Me.lblStateNum.AutoSize = True
        Me.lblStateNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateNum.Location = New System.Drawing.Point(680, 345)
        Me.lblStateNum.Name = "lblStateNum"
        Me.lblStateNum.Size = New System.Drawing.Size(32, 16)
        Me.lblStateNum.TabIndex = 13
        Me.lblStateNum.Text = "789"
        '
        'lblNetPaycheck
        '
        Me.lblNetPaycheck.AutoSize = True
        Me.lblNetPaycheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPaycheck.Location = New System.Drawing.Point(202, 403)
        Me.lblNetPaycheck.Name = "lblNetPaycheck"
        Me.lblNetPaycheck.Size = New System.Drawing.Size(187, 20)
        Me.lblNetPaycheck.TabIndex = 14
        Me.lblNetPaycheck.Text = "Net Paycheck Income:"
        '
        'lblNetPaycheckNum
        '
        Me.lblNetPaycheckNum.AutoSize = True
        Me.lblNetPaycheckNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPaycheckNum.Location = New System.Drawing.Point(498, 403)
        Me.lblNetPaycheckNum.Name = "lblNetPaycheckNum"
        Me.lblNetPaycheckNum.Size = New System.Drawing.Size(94, 20)
        Me.lblNetPaycheckNum.TabIndex = 15
        Me.lblNetPaycheckNum.Text = "$12345.67"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNetPaycheckNum)
        Me.Controls.Add(Me.lblNetPaycheck)
        Me.Controls.Add(Me.lblStateNum)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFedNum)
        Me.Controls.Add(Me.lblFed)
        Me.Controls.Add(Me.lblFicaNum)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblPaycheckCalc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPaycheckCalc As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFicaNum As Label
    Friend WithEvents lblFed As Label
    Friend WithEvents lblFedNum As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblStateNum As Label
    Friend WithEvents lblNetPaycheck As Label
    Friend WithEvents lblNetPaycheckNum As Label
End Class
