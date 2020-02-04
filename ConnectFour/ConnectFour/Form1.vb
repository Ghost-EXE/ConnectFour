Imports System.IO

Public Class Form1
    Private board As Board
    Private IsGame As Boolean = False
    Private boardSize As Integer = 7
    Private matrix(boardSize, boardSize) As Integer
    Private steps As Integer = 50
    Private maxBoard As Integer = 500
    Private player1 = False

    Private Sub NewGame()
        ClearGameData()
        board = New Board(Me)
        board.DrawBoard()
        board.FillSeaColor(matrix, boardSize)

    End Sub

    Private Sub ClearGameData()
        Array.Clear(matrix, 0, matrix.Length)
        IsGame = True

    End Sub

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewGame()
        ' ShowMatrix()
        player1 = True
        Label1.ForeColor = Color.Blue
        Label1.Text = "Blue's turn"


    End Sub

    '*http://www.vbforums.com/showthread.php?711137-VB-Net-Connect-4
    Private Sub Gamewin()
        Dim endgame As Boolean = False

        For x As Integer = 0 To 3
            For y As Integer = 0 To 6
                'Horizontal - Player1
                If matrix(x, y) = 1 And matrix(x + 1, y) = 1 And matrix(x + 2, y) = 1 And matrix(x + 3, y) = 1 Then
                    MessageBox.Show("Blue Wins!")
                    endgame = True
                End If

                'Horizontal - Player2
                If matrix(x, y) = 2 And matrix(x + 1, y) = 2 And matrix(x + 2, y) = 2 And matrix(x + 3, y) = 2 Then
                    MessageBox.Show("Red Wins!")
                    endgame = True
                End If
            Next
        Next

        If endgame = False Then
            For x As Integer = 0 To 6
                For y As Integer = 0 To 3

                    'Verticle - Player1
                    If matrix(x, y) = 1 And matrix(x, y + 1) = 1 And matrix(x, y + 2) = 1 And matrix(x, y + 3) = 1 Then
                        MessageBox.Show("blue Wins!")
                        endgame = True
                        Exit For
                    End If

                    'Verticle - Player2
                    If matrix(x, y) = 2 And matrix(x, y + 1) = 2 And matrix(x, y + 2) = 2 And matrix(x, y + 3) = 2 Then
                        MessageBox.Show("red Wins!")
                        endgame = True
                        Exit For
                    End If
                Next
            Next
        End If
        If endgame = False Then
            For x As Integer = 0 To 3
                For y As Integer = 3 To 6
                    'Diagonal(/) - Player1
                    If matrix(x, y) = 1 And matrix(x + 1, y - 1) = 1 And matrix(x + 2, y - 2) = 1 And matrix(x + 3, y - 3) = 1 Then
                        MessageBox.Show("blue Wins!")
                        endgame = True
                        Exit For
                    End If

                    'Diagonal(/) - Player2
                    If matrix(x, y) = 2 And matrix(x + 1, y - 1) = 2 And matrix(x + 2, y - 2) = 2 And matrix(x + 3, y - 3) = 2 Then
                        MessageBox.Show("Red Wins!")
                        endgame = True
                        Exit For
                    End If
                Next
            Next
        End If

        If endgame = False Then

            For x As Integer = 0 To 3
                For y As Integer = 0 To 3

                    'Diagonal(\) - Player1
                    If matrix(x, y) = 1 And matrix(x + 1, y + 1) = 1 And matrix(x + 2, y + 2) = 1 And matrix(x + 3, y + 3) = 1 Then
                        MessageBox.Show("Blue Wins!")
                        endgame = True
                        Exit For
                    End If

                    'Diagonal(\) - Player2
                    If matrix(x, y) = 2 And matrix(x + 1, y + 1) = 2 And matrix(x + 2, y + 2) = 2 And matrix(x + 3, y + 3) = 2 Then
                        MessageBox.Show("Red Wins!")
                        endgame = True
                        Exit For
                    End If

                Next
            Next

        End If
    End Sub

    Public Function GetMouseX(x As Double)
        If x > steps And x < maxBoard Then
            Return Math.Floor(x / steps)
        End If
        Return 0
    End Function

    Public Function GetMouseY(y As Double)
        If y > steps And y < maxBoard Then
            Return Math.Floor(y / steps)
        End If
        Return 0
    End Function

    Private Sub ChangeMatrix(y As Double, x As Double)
        Console.WriteLine(y & ": " & x)
        If player1 = True Then
            If matrix(6, x) = 0 Then
                matrix(6, x) = 1
                y = 6
            ElseIf matrix(5, x) = 0 Then
                matrix(5, x) = 1
                y = 5
            ElseIf matrix(4, x) = 0 Then
                matrix(4, x) = 1
                y = 4
            ElseIf matrix(3, x) = 0 Then
                matrix(3, x) = 1
                y = 3
            ElseIf matrix(2, x) = 0 Then
                matrix(2, x) = 1
                y = 2
            ElseIf matrix(1, x) = 0 Then
                matrix(1, x) = 1
                y = 1
            ElseIf matrix(0, x) = 0 Then
                matrix(0, x) = 1
                y = 0

            End If
            player1 = False
            Label1.ForeColor = Color.Red
            Label1.Text = "Red's turn"

        Else
            If matrix(6, x) = 0 Then
                matrix(6, x) = 2
            ElseIf matrix(5, x) = 0 Then
                matrix(5, x) = 2
            ElseIf matrix(4, x) = 0 Then
                matrix(4, x) = 2
            ElseIf matrix(3, x) = 0 Then
                matrix(3, x) = 2
            ElseIf matrix(2, x) = 0 Then
                matrix(2, x) = 2
            ElseIf matrix(1, x) = 0 Then
                matrix(1, x) = 2
            ElseIf matrix(0, x) = 0 Then
                matrix(0, x) = 2

            End If
            player1 = True
            Label1.ForeColor = Color.Blue
            Label1.Text = "Blue's turn"
        End If
        board.FillSeaColor(matrix, boardSize)
        Call Gamewin()
        'If matrix Is endCon Then
        '    Dim myWin As String

        '    Try
        '        myWin = InputBox("You Won!")
        '    Catch
        '    End Try
        '    Using writer As New StreamWriter(path, True)
        '        writer.WriteLine(myWin & ": " & moves)
        '    End Using
        'End If

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If IsGame Then
            Dim x As Integer = GetMouseX(e.X)
            Dim y As Integer = GetMouseY(e.Y)
            If x > -1 And y > -1 Then
                ChangeMatrix(y, x)

                ' ShowMatrix()

            Else
            End If

        End If

    End Sub

End Class
