Public Class frmMain
    Dim urgency As Integer
    Private Sub Form1_Load(sender As Object, k As EventArgs) Handles MyBase.Load
        dtpCardDueDate.MinDate = DateTime.Today
        grpNotices.AllowDrop = True
        grpToDo.AllowDrop = True
        grpInProgress.AllowDrop = True
        grpDone.AllowDrop = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpNotices.Enter

    End Sub

    Private Sub btnCreateCardSubmit_Click(sender As Object, e As EventArgs) Handles btnCreateCardSubmit.Click
        Dim status As Integer = 0
        If txtCardTitle.Text = "" Then
            MsgBox("Please enter a title for the card.")
            status = 2
        ElseIf txtCardContent.Text = "" Then
            MsgBox("Please enter a description for the card.")
            status = 2
        ElseIf dtpCardDueDate.Value < DateTime.Now Then
            MsgBox("Please select a valid due date for the card.")
            status = 2
        ElseIf status <> 2 Then
            status = 1

        End If
        If status = 1 Then
            Dim completion As Integer = 0

            If rbtUrgency0.Checked Then
                urgency = 0
            ElseIf rbtUrgency1.Checked Then
                urgency = 1
            ElseIf rbtUrgency2.Checked Then
                urgency = 2
            ElseIf rbtUrgency3.Checked Then
                urgency = 3
            End If

            createCard(txtCardTitle.Text, txtCardContent.Text, dtpCardDueDate.Value, urgency, completion)
        End If
    End Sub

    Public Sub createCard(ByVal title As String, ByVal description As String, ByVal dueDate As DateTime, ByVal urgency As Integer, ByVal completion As Integer)
        ' Subprogram to create a new card with the provided title, description, and due date + urgency
        Dim newCard As New Cards(title, description, dueDate, urgency, completion)
        Dim targetBox As GroupBox = If(urgency = 0, grpNotices, grpToDo)
        targetBox.Controls.Add(newCard)
    End Sub
    Public Sub deleteCard(ByVal title As String, ByVal dueDate As DateTime)
        ' Subprogram to delete a card with the provided title and due date
    End Sub
End Class

Public Class Cards
    Inherits Panel
    Public title As String
    Public description As String
    Public dueDate As DateTime
    Public urgency As Integer
    Public completion As Integer
    Public Sub New(ByVal title As String, ByVal description As String, ByVal dueDate As DateTime, ByVal urgency As Integer, ByVal completion As Integer)
        Me.Size = New Size(250, 300)
        Me.title = title
        Me.description = description
        Me.dueDate = dueDate
        Me.urgency = urgency
        Me.completion = completion
        If urgency = 0 Then
            Me.BackColor = Color.MediumTurquoise
        ElseIf urgency = 1 Then
            Me.BackColor = Color.LightGreen
        ElseIf urgency = 2 Then
            Me.BackColor = Color.FromArgb(253, 253, 150)
        ElseIf urgency = 3 Then
            Me.BackColor = Color.Tomato







        End If
    End Sub
End Class