Public Class Form1

    Public setX As Integer
    Public setY As Integer
    Public velocityX As Integer
    Public velocityY As Integer


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        setX = setX + velocityX
        setY = setY + velocityY


        'horizontal bounces
        If (Screen.PrimaryScreen.Bounds.Width - PictureBox1.Location.X < PictureBox1.Width) Then
            Dim randomX As Integer
            randomX = Int((-2 - -6 + 1) * Rnd() + -6)
            velocityX = randomX


        End If
        If (PictureBox1.Location.X < 1) Then

            Dim randomX As Integer
            randomX = Int((6 - 2 + 1) * Rnd() + 2)
            velocityX = randomX

        End If



        'vertical bounces
        If (Screen.PrimaryScreen.Bounds.Height - PictureBox1.Location.Y < PictureBox1.Height) Then
            Dim randomY As Integer
            randomY = Int((-2 - -6 + 1) * Rnd() + -6)
            velocityY = randomY


        End If
        If (PictureBox1.Location.Y < 1) Then

            Dim randomY As Integer
            randomY = Int((6 - 2 + 1) * Rnd() + 2)
            velocityY = randomY

        End If


        'sets new position of image
        PictureBox1.Location = New Point(setX, setY)

        Timer1.Enabled = True


    End Sub
End Class
