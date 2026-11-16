Public Class frmMain
    Private Sub Form1_Load(sender As Object, k As EventArgs) Handles MyBase.Load
        dtpCardDueDate.MinDate = DateTime.Now
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
        End If
    End Sub
End Class
Public Class Card
    Private Sub createCard(ByVal title As String, ByVal description As String, ByVal dueDate As DateTime, ByVal urgency As Integer)
        ' Subprogram to create a new card with the provided title, description, and due date + urgency
    End Sub
End Class