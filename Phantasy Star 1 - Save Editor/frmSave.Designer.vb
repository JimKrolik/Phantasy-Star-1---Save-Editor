<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSave
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
        Me.btnHide = New System.Windows.Forms.Button()
        Me.grpNewDungeon = New System.Windows.Forms.GroupBox()
        Me.grpCurrentDungeon = New System.Windows.Forms.GroupBox()
        Me.lblCurrentDungeon = New System.Windows.Forms.Label()
        Me.cmbDungeonSelector = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(13, 12)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 31
        Me.btnHide.Text = "&Close"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'grpNewDungeon
        '
        Me.grpNewDungeon.Location = New System.Drawing.Point(94, 12)
        Me.grpNewDungeon.Name = "grpNewDungeon"
        Me.grpNewDungeon.Size = New System.Drawing.Size(282, 284)
        Me.grpNewDungeon.TabIndex = 32
        Me.grpNewDungeon.TabStop = False
        Me.grpNewDungeon.Text = "New Dungeon"
        '
        'grpCurrentDungeon
        '
        Me.grpCurrentDungeon.Location = New System.Drawing.Point(94, 302)
        Me.grpCurrentDungeon.Name = "grpCurrentDungeon"
        Me.grpCurrentDungeon.Size = New System.Drawing.Size(282, 284)
        Me.grpCurrentDungeon.TabIndex = 33
        Me.grpCurrentDungeon.TabStop = False
        Me.grpCurrentDungeon.Text = "Current Dungeon"
        '
        'lblCurrentDungeon
        '
        Me.lblCurrentDungeon.AutoSize = True
        Me.lblCurrentDungeon.Location = New System.Drawing.Point(388, 149)
        Me.lblCurrentDungeon.Name = "lblCurrentDungeon"
        Me.lblCurrentDungeon.Size = New System.Drawing.Size(252, 15)
        Me.lblCurrentDungeon.TabIndex = 0
        Me.lblCurrentDungeon.Text = "Note:  Some dungeons share space in layouts. "
        '
        'cmbDungeonSelector
        '
        Me.cmbDungeonSelector.FormattingEnabled = True
        Me.cmbDungeonSelector.Location = New System.Drawing.Point(6, 22)
        Me.cmbDungeonSelector.Name = "cmbDungeonSelector"
        Me.cmbDungeonSelector.Size = New System.Drawing.Size(289, 23)
        Me.cmbDungeonSelector.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDungeonSelector)
        Me.GroupBox1.Location = New System.Drawing.Point(382, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 134)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save Controls"
        '
        'frmSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCurrentDungeon)
        Me.Controls.Add(Me.grpCurrentDungeon)
        Me.Controls.Add(Me.grpNewDungeon)
        Me.Controls.Add(Me.btnHide)
        Me.Name = "frmSave"
        Me.Text = "Save Map"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHide As Button
    Friend WithEvents grpNewDungeon As GroupBox
    Friend WithEvents grpCurrentDungeon As GroupBox
    Friend WithEvents lblCurrentDungeon As Label
    Friend WithEvents cmbDungeonSelector As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
