<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpCardCreate = New System.Windows.Forms.GroupBox()
        Me.lblInfoCardUrgency = New System.Windows.Forms.Label()
        Me.lblInfoCardDescription = New System.Windows.Forms.Label()
        Me.lblInfoCardDueDate = New System.Windows.Forms.Label()
        Me.lblInfoCardName = New System.Windows.Forms.Label()
        Me.btnCreateCardSubmit = New System.Windows.Forms.Button()
        Me.grpCardCreationUrgency = New System.Windows.Forms.GroupBox()
        Me.rbtUrgency3 = New System.Windows.Forms.RadioButton()
        Me.rbtUrgency2 = New System.Windows.Forms.RadioButton()
        Me.rbtUrgency1 = New System.Windows.Forms.RadioButton()
        Me.rbtUrgency0 = New System.Windows.Forms.RadioButton()
        Me.dtpCardDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCardContent = New System.Windows.Forms.TextBox()
        Me.txtCardTitle = New System.Windows.Forms.TextBox()
        Me.lblTitleCardCreation = New System.Windows.Forms.Label()
        Me.grpNotices = New System.Windows.Forms.GroupBox()
        Me.grpToDo = New System.Windows.Forms.GroupBox()
        Me.grpInProgress = New System.Windows.Forms.GroupBox()
        Me.grpDone = New System.Windows.Forms.GroupBox()
        Me.lblInfoNotices = New System.Windows.Forms.Label()
        Me.lblInfoToDo = New System.Windows.Forms.Label()
        Me.lblInfoInProgress = New System.Windows.Forms.Label()
        Me.lblInfoDone = New System.Windows.Forms.Label()
        Me.grpCardCreate.SuspendLayout()
        Me.grpCardCreationUrgency.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCardCreate
        '
        Me.grpCardCreate.Controls.Add(Me.lblInfoCardUrgency)
        Me.grpCardCreate.Controls.Add(Me.lblInfoCardDescription)
        Me.grpCardCreate.Controls.Add(Me.lblInfoCardDueDate)
        Me.grpCardCreate.Controls.Add(Me.lblInfoCardName)
        Me.grpCardCreate.Controls.Add(Me.btnCreateCardSubmit)
        Me.grpCardCreate.Controls.Add(Me.grpCardCreationUrgency)
        Me.grpCardCreate.Controls.Add(Me.dtpCardDueDate)
        Me.grpCardCreate.Controls.Add(Me.txtCardContent)
        Me.grpCardCreate.Controls.Add(Me.txtCardTitle)
        Me.grpCardCreate.Controls.Add(Me.lblTitleCardCreation)
        Me.grpCardCreate.Location = New System.Drawing.Point(12, 12)
        Me.grpCardCreate.Name = "grpCardCreate"
        Me.grpCardCreate.Size = New System.Drawing.Size(325, 744)
        Me.grpCardCreate.TabIndex = 0
        Me.grpCardCreate.TabStop = False
        '
        'lblInfoCardUrgency
        '
        Me.lblInfoCardUrgency.AutoSize = True
        Me.lblInfoCardUrgency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCardUrgency.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoCardUrgency.Location = New System.Drawing.Point(42, 486)
        Me.lblInfoCardUrgency.Name = "lblInfoCardUrgency"
        Me.lblInfoCardUrgency.Size = New System.Drawing.Size(133, 25)
        Me.lblInfoCardUrgency.TabIndex = 8
        Me.lblInfoCardUrgency.Text = "Card Urgency"
        '
        'lblInfoCardDescription
        '
        Me.lblInfoCardDescription.AutoSize = True
        Me.lblInfoCardDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCardDescription.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoCardDescription.Location = New System.Drawing.Point(41, 232)
        Me.lblInfoCardDescription.Name = "lblInfoCardDescription"
        Me.lblInfoCardDescription.Size = New System.Drawing.Size(109, 25)
        Me.lblInfoCardDescription.TabIndex = 8
        Me.lblInfoCardDescription.Text = "Description"
        '
        'lblInfoCardDueDate
        '
        Me.lblInfoCardDueDate.AutoSize = True
        Me.lblInfoCardDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCardDueDate.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoCardDueDate.Location = New System.Drawing.Point(42, 164)
        Me.lblInfoCardDueDate.Name = "lblInfoCardDueDate"
        Me.lblInfoCardDueDate.Size = New System.Drawing.Size(100, 25)
        Me.lblInfoCardDueDate.TabIndex = 8
        Me.lblInfoCardDueDate.Text = "Due Date:"
        '
        'lblInfoCardName
        '
        Me.lblInfoCardName.AutoSize = True
        Me.lblInfoCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCardName.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoCardName.Location = New System.Drawing.Point(41, 94)
        Me.lblInfoCardName.Name = "lblInfoCardName"
        Me.lblInfoCardName.Size = New System.Drawing.Size(97, 25)
        Me.lblInfoCardName.TabIndex = 7
        Me.lblInfoCardName.Text = "Card Title"
        '
        'btnCreateCardSubmit
        '
        Me.btnCreateCardSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateCardSubmit.Location = New System.Drawing.Point(121, 678)
        Me.btnCreateCardSubmit.Name = "btnCreateCardSubmit"
        Me.btnCreateCardSubmit.Size = New System.Drawing.Size(75, 28)
        Me.btnCreateCardSubmit.TabIndex = 6
        Me.btnCreateCardSubmit.Text = "Create"
        Me.btnCreateCardSubmit.UseVisualStyleBackColor = True
        '
        'grpCardCreationUrgency
        '
        Me.grpCardCreationUrgency.Controls.Add(Me.rbtUrgency3)
        Me.grpCardCreationUrgency.Controls.Add(Me.rbtUrgency2)
        Me.grpCardCreationUrgency.Controls.Add(Me.rbtUrgency1)
        Me.grpCardCreationUrgency.Controls.Add(Me.rbtUrgency0)
        Me.grpCardCreationUrgency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCardCreationUrgency.Location = New System.Drawing.Point(40, 504)
        Me.grpCardCreationUrgency.Name = "grpCardCreationUrgency"
        Me.grpCardCreationUrgency.Size = New System.Drawing.Size(249, 138)
        Me.grpCardCreationUrgency.TabIndex = 5
        Me.grpCardCreationUrgency.TabStop = False
        '
        'rbtUrgency3
        '
        Me.rbtUrgency3.AutoSize = True
        Me.rbtUrgency3.ForeColor = System.Drawing.Color.Tomato
        Me.rbtUrgency3.Location = New System.Drawing.Point(7, 98)
        Me.rbtUrgency3.Name = "rbtUrgency3"
        Me.rbtUrgency3.Size = New System.Drawing.Size(137, 29)
        Me.rbtUrgency3.TabIndex = 3
        Me.rbtUrgency3.TabStop = True
        Me.rbtUrgency3.Text = "High Priority"
        Me.rbtUrgency3.UseVisualStyleBackColor = True
        '
        'rbtUrgency2
        '
        Me.rbtUrgency2.AutoSize = True
        Me.rbtUrgency2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.rbtUrgency2.Location = New System.Drawing.Point(7, 72)
        Me.rbtUrgency2.Name = "rbtUrgency2"
        Me.rbtUrgency2.Size = New System.Drawing.Size(167, 29)
        Me.rbtUrgency2.TabIndex = 2
        Me.rbtUrgency2.TabStop = True
        Me.rbtUrgency2.Text = "Medium Priority"
        Me.rbtUrgency2.UseVisualStyleBackColor = True
        '
        'rbtUrgency1
        '
        Me.rbtUrgency1.AutoSize = True
        Me.rbtUrgency1.ForeColor = System.Drawing.Color.LightGreen
        Me.rbtUrgency1.Location = New System.Drawing.Point(7, 46)
        Me.rbtUrgency1.Name = "rbtUrgency1"
        Me.rbtUrgency1.Size = New System.Drawing.Size(133, 29)
        Me.rbtUrgency1.TabIndex = 1
        Me.rbtUrgency1.TabStop = True
        Me.rbtUrgency1.Text = "Low Priority"
        Me.rbtUrgency1.UseVisualStyleBackColor = True
        '
        'rbtUrgency0
        '
        Me.rbtUrgency0.AutoSize = True
        Me.rbtUrgency0.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.rbtUrgency0.Location = New System.Drawing.Point(7, 20)
        Me.rbtUrgency0.Name = "rbtUrgency0"
        Me.rbtUrgency0.Size = New System.Drawing.Size(136, 29)
        Me.rbtUrgency0.TabIndex = 0
        Me.rbtUrgency0.TabStop = True
        Me.rbtUrgency0.Text = "Notice Card"
        Me.rbtUrgency0.UseVisualStyleBackColor = True
        '
        'dtpCardDueDate
        '
        Me.dtpCardDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCardDueDate.Location = New System.Drawing.Point(66, 189)
        Me.dtpCardDueDate.Name = "dtpCardDueDate"
        Me.dtpCardDueDate.Size = New System.Drawing.Size(200, 30)
        Me.dtpCardDueDate.TabIndex = 4
        '
        'txtCardContent
        '
        Me.txtCardContent.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCardContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardContent.Location = New System.Drawing.Point(39, 258)
        Me.txtCardContent.Multiline = True
        Me.txtCardContent.Name = "txtCardContent"
        Me.txtCardContent.Size = New System.Drawing.Size(250, 225)
        Me.txtCardContent.TabIndex = 3
        '
        'txtCardTitle
        '
        Me.txtCardTitle.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCardTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardTitle.Location = New System.Drawing.Point(39, 122)
        Me.txtCardTitle.Name = "txtCardTitle"
        Me.txtCardTitle.Size = New System.Drawing.Size(250, 30)
        Me.txtCardTitle.TabIndex = 1
        '
        'lblTitleCardCreation
        '
        Me.lblTitleCardCreation.AutoSize = True
        Me.lblTitleCardCreation.Font = New System.Drawing.Font("Cascadia Code", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCardCreation.ForeColor = System.Drawing.Color.Azure
        Me.lblTitleCardCreation.Location = New System.Drawing.Point(40, 36)
        Me.lblTitleCardCreation.Name = "lblTitleCardCreation"
        Me.lblTitleCardCreation.Size = New System.Drawing.Size(257, 37)
        Me.lblTitleCardCreation.TabIndex = 0
        Me.lblTitleCardCreation.Text = "Create New Card"
        '
        'grpNotices
        '
        Me.grpNotices.Location = New System.Drawing.Point(371, 85)
        Me.grpNotices.Name = "grpNotices"
        Me.grpNotices.Size = New System.Drawing.Size(240, 673)
        Me.grpNotices.TabIndex = 1
        Me.grpNotices.TabStop = False
        '
        'grpToDo
        '
        Me.grpToDo.Location = New System.Drawing.Point(617, 85)
        Me.grpToDo.Name = "grpToDo"
        Me.grpToDo.Size = New System.Drawing.Size(240, 673)
        Me.grpToDo.TabIndex = 2
        Me.grpToDo.TabStop = False
        '
        'grpInProgress
        '
        Me.grpInProgress.Location = New System.Drawing.Point(863, 85)
        Me.grpInProgress.Name = "grpInProgress"
        Me.grpInProgress.Size = New System.Drawing.Size(240, 673)
        Me.grpInProgress.TabIndex = 2
        Me.grpInProgress.TabStop = False
        '
        'grpDone
        '
        Me.grpDone.Location = New System.Drawing.Point(1109, 85)
        Me.grpDone.Name = "grpDone"
        Me.grpDone.Size = New System.Drawing.Size(240, 673)
        Me.grpDone.TabIndex = 2
        Me.grpDone.TabStop = False
        '
        'lblInfoNotices
        '
        Me.lblInfoNotices.AutoSize = True
        Me.lblInfoNotices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoNotices.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoNotices.Location = New System.Drawing.Point(366, 57)
        Me.lblInfoNotices.Name = "lblInfoNotices"
        Me.lblInfoNotices.Size = New System.Drawing.Size(83, 25)
        Me.lblInfoNotices.TabIndex = 9
        Me.lblInfoNotices.Text = "Notices:"
        '
        'lblInfoToDo
        '
        Me.lblInfoToDo.AutoSize = True
        Me.lblInfoToDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoToDo.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoToDo.Location = New System.Drawing.Point(612, 57)
        Me.lblInfoToDo.Name = "lblInfoToDo"
        Me.lblInfoToDo.Size = New System.Drawing.Size(69, 25)
        Me.lblInfoToDo.TabIndex = 10
        Me.lblInfoToDo.Text = "To do:"
        '
        'lblInfoInProgress
        '
        Me.lblInfoInProgress.AutoSize = True
        Me.lblInfoInProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoInProgress.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoInProgress.Location = New System.Drawing.Point(858, 57)
        Me.lblInfoInProgress.Name = "lblInfoInProgress"
        Me.lblInfoInProgress.Size = New System.Drawing.Size(117, 25)
        Me.lblInfoInProgress.TabIndex = 11
        Me.lblInfoInProgress.Text = "In Progress:"
        '
        'lblInfoDone
        '
        Me.lblInfoDone.AutoSize = True
        Me.lblInfoDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoDone.ForeColor = System.Drawing.Color.Azure
        Me.lblInfoDone.Location = New System.Drawing.Point(1104, 57)
        Me.lblInfoDone.Name = "lblInfoDone"
        Me.lblInfoDone.Size = New System.Drawing.Size(65, 25)
        Me.lblInfoDone.TabIndex = 12
        Me.lblInfoDone.Text = "Done:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1360, 770)
        Me.Controls.Add(Me.lblInfoDone)
        Me.Controls.Add(Me.lblInfoInProgress)
        Me.Controls.Add(Me.lblInfoToDo)
        Me.Controls.Add(Me.lblInfoNotices)
        Me.Controls.Add(Me.grpDone)
        Me.Controls.Add(Me.grpInProgress)
        Me.Controls.Add(Me.grpToDo)
        Me.Controls.Add(Me.grpNotices)
        Me.Controls.Add(Me.grpCardCreate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(-25, 125)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "MyKanBan"
        Me.grpCardCreate.ResumeLayout(False)
        Me.grpCardCreate.PerformLayout()
        Me.grpCardCreationUrgency.ResumeLayout(False)
        Me.grpCardCreationUrgency.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCardCreate As GroupBox
    Friend WithEvents lblTitleCardCreation As Label
    Friend WithEvents txtCardTitle As TextBox
    Friend WithEvents txtCardContent As TextBox
    Friend WithEvents dtpCardDueDate As DateTimePicker
    Friend WithEvents grpCardCreationUrgency As GroupBox
    Friend WithEvents rbtUrgency3 As RadioButton
    Friend WithEvents rbtUrgency2 As RadioButton
    Friend WithEvents rbtUrgency1 As RadioButton
    Friend WithEvents rbtUrgency0 As RadioButton
    Friend WithEvents btnCreateCardSubmit As Button
    Friend WithEvents lblInfoCardName As Label
    Friend WithEvents lblInfoCardUrgency As Label
    Friend WithEvents lblInfoCardDescription As Label
    Friend WithEvents lblInfoCardDueDate As Label
    Friend WithEvents grpNotices As GroupBox
    Friend WithEvents grpToDo As GroupBox
    Friend WithEvents grpInProgress As GroupBox
    Friend WithEvents grpDone As GroupBox
    Friend WithEvents lblInfoNotices As Label
    Friend WithEvents lblInfoToDo As Label
    Friend WithEvents lblInfoInProgress As Label
    Friend WithEvents lblInfoDone As Label
End Class
