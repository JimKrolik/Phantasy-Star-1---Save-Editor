<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.grpAlis = New System.Windows.Forms.GroupBox()
        Me.AlisEXP = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AlisDefense = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlisAttack = New System.Windows.Forms.NumericUpDown()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.AlisActive = New System.Windows.Forms.CheckBox()
        Me.AlisMaxTP = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlisCurrentTP = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlisMaxHP = New System.Windows.Forms.NumericUpDown()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.AlisCurrentHP = New System.Windows.Forms.NumericUpDown()
        Me.AlysHP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlisLevel = New System.Windows.Forms.NumericUpDown()
        Me.grpMyau = New System.Windows.Forms.GroupBox()
        Me.grpOdin = New System.Windows.Forms.GroupBox()
        Me.grpNoah = New System.Windows.Forms.GroupBox()
        Me.chkFreeMode = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpAlis.SuspendLayout()
        CType(Me.AlisEXP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisDefense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisAttack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisMaxTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisCurrentTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisMaxHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisCurrentHP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlisLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'grpAlis
        '
        Me.grpAlis.Controls.Add(Me.TextBox1)
        Me.grpAlis.Controls.Add(Me.AlisEXP)
        Me.grpAlis.Controls.Add(Me.Label5)
        Me.grpAlis.Controls.Add(Me.AlisDefense)
        Me.grpAlis.Controls.Add(Me.Label4)
        Me.grpAlis.Controls.Add(Me.AlisAttack)
        Me.grpAlis.Controls.Add(Me.Label99)
        Me.grpAlis.Controls.Add(Me.AlisActive)
        Me.grpAlis.Controls.Add(Me.AlisMaxTP)
        Me.grpAlis.Controls.Add(Me.Label3)
        Me.grpAlis.Controls.Add(Me.AlisCurrentTP)
        Me.grpAlis.Controls.Add(Me.Label2)
        Me.grpAlis.Controls.Add(Me.AlisMaxHP)
        Me.grpAlis.Controls.Add(Me.Label39)
        Me.grpAlis.Controls.Add(Me.AlisCurrentHP)
        Me.grpAlis.Controls.Add(Me.AlysHP)
        Me.grpAlis.Controls.Add(Me.Label1)
        Me.grpAlis.Controls.Add(Me.AlisLevel)
        Me.grpAlis.Location = New System.Drawing.Point(102, 12)
        Me.grpAlis.Name = "grpAlis"
        Me.grpAlis.Size = New System.Drawing.Size(259, 335)
        Me.grpAlis.TabIndex = 1
        Me.grpAlis.TabStop = False
        Me.grpAlis.Text = "Alis"
        '
        'AlisEXP
        '
        Me.AlisEXP.Location = New System.Drawing.Point(48, 169)
        Me.AlisEXP.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.AlisEXP.Name = "AlisEXP"
        Me.AlisEXP.Size = New System.Drawing.Size(59, 23)
        Me.AlisEXP.TabIndex = 27
        Me.AlisEXP.Value = New Decimal(New Integer() {65535, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "EXP"
        '
        'AlisDefense
        '
        Me.AlisDefense.Location = New System.Drawing.Point(47, 139)
        Me.AlisDefense.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisDefense.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisDefense.Name = "AlisDefense"
        Me.AlisDefense.Size = New System.Drawing.Size(41, 23)
        Me.AlisDefense.TabIndex = 25
        Me.AlisDefense.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "DEF"
        '
        'AlisAttack
        '
        Me.AlisAttack.Location = New System.Drawing.Point(48, 110)
        Me.AlisAttack.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisAttack.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisAttack.Name = "AlisAttack"
        Me.AlisAttack.Size = New System.Drawing.Size(41, 23)
        Me.AlisAttack.TabIndex = 23
        Me.AlisAttack.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(14, 113)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(27, 15)
        Me.Label99.TabIndex = 22
        Me.Label99.Text = "ATK"
        '
        'AlisActive
        '
        Me.AlisActive.AutoSize = True
        Me.AlisActive.Location = New System.Drawing.Point(112, 27)
        Me.AlisActive.Name = "AlisActive"
        Me.AlisActive.Size = New System.Drawing.Size(64, 19)
        Me.AlisActive.TabIndex = 21
        Me.AlisActive.Text = "Active?"
        Me.AlisActive.UseVisualStyleBackColor = True
        '
        'AlisMaxTP
        '
        Me.AlisMaxTP.Location = New System.Drawing.Point(111, 81)
        Me.AlisMaxTP.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisMaxTP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisMaxTP.Name = "AlisMaxTP"
        Me.AlisMaxTP.Size = New System.Drawing.Size(41, 23)
        Me.AlisMaxTP.TabIndex = 20
        Me.AlisMaxTP.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "/"
        '
        'AlisCurrentTP
        '
        Me.AlisCurrentTP.Location = New System.Drawing.Point(48, 81)
        Me.AlisCurrentTP.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisCurrentTP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisCurrentTP.Name = "AlisCurrentTP"
        Me.AlisCurrentTP.Size = New System.Drawing.Size(41, 23)
        Me.AlisCurrentTP.TabIndex = 18
        Me.AlisCurrentTP.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "TP"
        '
        'AlisMaxHP
        '
        Me.AlisMaxHP.Location = New System.Drawing.Point(111, 52)
        Me.AlisMaxHP.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisMaxHP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisMaxHP.Name = "AlisMaxHP"
        Me.AlisMaxHP.Size = New System.Drawing.Size(41, 23)
        Me.AlisMaxHP.TabIndex = 16
        Me.AlisMaxHP.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(95, 54)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(12, 15)
        Me.Label39.TabIndex = 15
        Me.Label39.Text = "/"
        '
        'AlisCurrentHP
        '
        Me.AlisCurrentHP.Location = New System.Drawing.Point(48, 52)
        Me.AlisCurrentHP.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisCurrentHP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisCurrentHP.Name = "AlisCurrentHP"
        Me.AlisCurrentHP.Size = New System.Drawing.Size(41, 23)
        Me.AlisCurrentHP.TabIndex = 3
        Me.AlisCurrentHP.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'AlysHP
        '
        Me.AlysHP.AutoSize = True
        Me.AlysHP.Location = New System.Drawing.Point(18, 54)
        Me.AlysHP.Name = "AlysHP"
        Me.AlysHP.Size = New System.Drawing.Size(23, 15)
        Me.AlysHP.TabIndex = 2
        Me.AlysHP.Text = "HP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Level"
        '
        'AlisLevel
        '
        Me.AlisLevel.Location = New System.Drawing.Point(48, 23)
        Me.AlisLevel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlisLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AlisLevel.Name = "AlisLevel"
        Me.AlisLevel.Size = New System.Drawing.Size(41, 23)
        Me.AlisLevel.TabIndex = 0
        Me.AlisLevel.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'grpMyau
        '
        Me.grpMyau.Location = New System.Drawing.Point(367, 12)
        Me.grpMyau.Name = "grpMyau"
        Me.grpMyau.Size = New System.Drawing.Size(259, 335)
        Me.grpMyau.TabIndex = 2
        Me.grpMyau.TabStop = False
        Me.grpMyau.Text = "Myau"
        '
        'grpOdin
        '
        Me.grpOdin.Location = New System.Drawing.Point(102, 353)
        Me.grpOdin.Name = "grpOdin"
        Me.grpOdin.Size = New System.Drawing.Size(259, 335)
        Me.grpOdin.TabIndex = 3
        Me.grpOdin.TabStop = False
        Me.grpOdin.Text = "Odin"
        '
        'grpNoah
        '
        Me.grpNoah.Location = New System.Drawing.Point(367, 353)
        Me.grpNoah.Name = "grpNoah"
        Me.grpNoah.Size = New System.Drawing.Size(259, 335)
        Me.grpNoah.TabIndex = 4
        Me.grpNoah.TabStop = False
        Me.grpNoah.Text = "Noah"
        '
        'chkFreeMode
        '
        Me.chkFreeMode.AutoSize = True
        Me.chkFreeMode.Location = New System.Drawing.Point(16, 91)
        Me.chkFreeMode.Name = "chkFreeMode"
        Me.chkFreeMode.Size = New System.Drawing.Size(71, 19)
        Me.chkFreeMode.TabIndex = 5
        Me.chkFreeMode.Text = "Free Edit"
        Me.chkFreeMode.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(12, 41)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 780)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkFreeMode)
        Me.Controls.Add(Me.grpNoah)
        Me.Controls.Add(Me.grpOdin)
        Me.Controls.Add(Me.grpMyau)
        Me.Controls.Add(Me.grpAlis)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Form1"
        Me.Text = "Phantasy Star 1 Save Editor"
        Me.grpAlis.ResumeLayout(False)
        Me.grpAlis.PerformLayout()
        CType(Me.AlisEXP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisDefense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisAttack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisMaxTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisCurrentTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisMaxHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisCurrentHP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlisLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents grpAlis As GroupBox
    Friend WithEvents grpMyau As GroupBox
    Friend WithEvents grpOdin As GroupBox
    Friend WithEvents grpNoah As GroupBox
    Friend WithEvents AlisCurrentHP As NumericUpDown
    Friend WithEvents AlysHP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AlisLevel As NumericUpDown
    Friend WithEvents AlisMaxTP As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents AlisCurrentTP As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents AlisMaxHP As NumericUpDown
    Friend WithEvents Label39 As Label
    Friend WithEvents AlisActive As CheckBox
    Friend WithEvents AlisDefense As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents AlisAttack As NumericUpDown
    Friend WithEvents Label99 As Label
    Friend WithEvents chkFreeMode As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents AlisEXP As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
