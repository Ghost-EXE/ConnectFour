Public Class Board
    Private myGraphics As Graphics
    Private steps As Integer = 50
    Private maxBoard As Integer = 350
    Private ourPen As Pen = New Pen(Brushes.Black, 1)
    Private P1 As Brush = New SolidBrush(Color.Blue)
    Private P2 As Brush = New SolidBrush(Color.Red)
    Private Ne As Brush = New SolidBrush(Color.Gray)

    Public Sub New(form As Form)
        myGraphics = form.CreateGraphics
    End Sub

    Public Sub DrawBoard()
        For i As Integer = 0 To maxBoard Step steps
            myGraphics.DrawLine(ourPen, 0, i, maxBoard, i)
            myGraphics.DrawLine(ourPen, i, 0, i, maxBoard)
        Next
    End Sub

    Public Sub FillSeaColor(marix(,) As Integer, boardSize As Integer)
        Dim r As Integer, c As Integer
        Dim width As Integer = steps - 1
        Dim height As Integer = steps - 1
        For row As Integer = 0 To boardSize - 1
            For column As Integer = 0 To boardSize - 1
                r = ((row) * steps)
                c = ((column) * steps) + 1
                If marix(row, column) = 1 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(P1, rect)
                ElseIf marix(row, column) = 2 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(P2, rect)
                Else
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(Ne, rect)
                End If
            Next column
        Next row
    End Sub

End Class

