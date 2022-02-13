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
        Me.grpDungeon = New System.Windows.Forms.GroupBox()
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
        'grpDungeon
        '
        Me.grpDungeon.Location = New System.Drawing.Point(95, 12)
        Me.grpDungeon.Name = "grpDungeon"
        Me.grpDungeon.Size = New System.Drawing.Size(271, 284)
        Me.grpDungeon.TabIndex = 32
        Me.grpDungeon.TabStop = False
        Me.grpDungeon.Text = "Dungeon"
        '
        'frmSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 584)
        Me.Controls.Add(Me.grpDungeon)
        Me.Controls.Add(Me.btnHide)
        Me.Name = "frmSave"
        Me.Text = "Save Map"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHide As Button
    Friend WithEvents grpDungeon As GroupBox
End Class
