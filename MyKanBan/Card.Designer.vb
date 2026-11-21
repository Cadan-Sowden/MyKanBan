<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCardTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCardTitle
        '
        Me.lblCardTitle.AutoEllipsis = True
        Me.lblCardTitle.AutoSize = True
        Me.lblCardTitle.Font = New System.Drawing.Font("Cascadia Code", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardTitle.Location = New System.Drawing.Point(54, 11)
        Me.lblCardTitle.Name = "lblCardTitle"
        Me.lblCardTitle.Size = New System.Drawing.Size(84, 27)
        Me.lblCardTitle.TabIndex = 0
        Me.lblCardTitle.Text = "Label1"
        Me.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uctCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCardTitle)
        Me.Name = "uctCard"
        Me.Size = New System.Drawing.Size(200, 280)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardTitle As Label
End Class
