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

            txtCardTitle.Text = ""
            dtpCardDueDate.Value = Date.Today
            txtCardContent.Text = ""
            rbtUrgency0.Checked = False
            rbtUrgency1.Checked = False
            rbtUrgency2.Checked = False
            rbtUrgency3.Checked = False
        End If
    End Sub

    Public Sub createCard(ByVal title As String, ByVal description As String, ByVal dueDate As DateTime, ByVal urgency As Integer, ByVal completion As Integer)
        ' Subprogram to create a new card with the provided title, description, and due date + urgency
        Dim newCard As New Cards(title, description, dueDate, urgency, completion)
        Dim targetBox As GroupBox = If(urgency = 0, grpNotices, grpToDo)
        targetBox.Controls.Add(newCard)
        stackAll()
    End Sub
    Public Sub deleteCard(ByVal title As String, ByVal dueDate As DateTime)
        ' Subprogram to delete a card with the provided title and due date
    End Sub
    Public Sub writeToJSON(ByVal title As String, ByVal description As String, ByVal dueDate As DateTime, ByVal urgency As Integer, ByVal completion As Integer)

    End Sub
    Public Sub readFromJSON()

    End Sub
    Public Sub detectCreateJSON()

    End Sub
    Public Sub populateCards()

    End Sub
    Public Sub UpdateUrgency()

        For Each group As GroupBox In {
        grpToDo,
        grpInProgress
    }

            For Each ctrl As Control In group.Controls

                If TypeOf ctrl Is Cards Then

                    Dim card As Cards = DirectCast(ctrl, Cards)

                    Dim daysRemaining As Integer =
                    (card.dueDate.Date - Date.Today).Days

                    If daysRemaining <= 2 Then
                        card.urgency = 3
                    ElseIf daysRemaining <= 5 Then
                        card.urgency = 2
                    ElseIf daysRemaining <= 7 Then
                        card.urgency = 1
                    Else
                        card.urgency = 0
                    End If

                    card.updateColour(urgency)

                End If

            Next
        Next

    End Sub
    Public Sub stackCards(group As GroupBox)
        Dim cards = group.Controls.OfType(Of Cards)().ToList()
        Dim posStart As Integer = 10
        Dim posSpacing As Integer = 65
        Dim cardLength As Integer = 300
        Dim cardYPos As Integer

        For count = 0 To cards.Count - 1
            If count = 0 Then
                cardYPos = 0
            ElseIf count = 1 Then
                cardYPos = 300
            Else
                cardYPos = cardLength + (count - 1) * posSpacing
            End If
            cards(count).Location = New Point(0, cardYPos)
            cards(count).BringToFront()
        Next
    End Sub
    Public Sub stackAll()
        stackCards(grpNotices)
        stackCards(grpToDo)
        stackCards(grpInProgress)
        stackCards(grpDone)
    End Sub
End Class

Public Class Cards
    Inherits Panel
    Public Property title As String
    Public Property description As String
    Public Property dueDate As Date
    Public Property urgency As Integer
    Public Property completion As Integer
    Public Sub New(ByVal title As String, ByVal description As String, ByVal dueDate As Date, ByVal urgency As Integer, ByVal completion As Integer)
        Me.Size = New Size(250, 300)
        Me.title = title
        Me.description = description
        Me.dueDate = dueDate
        Me.urgency = urgency
        Me.completion = completion
        updateColour(urgency)

        Dim lblTitle As New Label()
        lblTitle.Location = New Point(10, 10)
        lblTitle.Font = New Font("Consolas Code", 14, FontStyle.Bold)
        lblTitle.Text = title
        lblTitle.Size = New Size(230, 60)
        lblTitle.AutoEllipsis = True
        Me.Controls.Add(lblTitle)

        Dim lblDescription As New Label()
        lblDescription.Location = New Point(10, 80)
        lblDescription.Size = New Size(230, 150)
        lblDescription.Text = description
        lblDescription.AutoEllipsis = True
        lblDescription.Font = New Font("Consolas Code", 12)
        Me.Controls.Add(lblDescription)

        Dim lblDueDate As New Label()
        lblDueDate.Location = New Point(10, 250)
        lblDueDate.Font = New Font("Consolas Code", 12)
        lblDueDate.AutoSize = True
        lblDueDate.Text = "Due " & Format(dueDate, "Short Date")
        Me.Controls.Add(lblDueDate)

    End Sub
    Public Sub updateColour(urgency)
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
