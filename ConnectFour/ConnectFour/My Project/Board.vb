Public Class Board
    Private myGraphics As Graphics
    Private steps As Integer = 50
    Private maxBoard As Integer = 200
    Private myBrush As Brush = New SolidBrush(Color.Black)
    Private myFont As Font = New Font("Verdana", 12, FontStyle.Bold)
    Private ourPen As Pen = New Pen(Brushes.Black, 1)
    Private myships As Brush = New SolidBrush(Color.Green)
    Private myWater As Brush = New SolidBrush(Color.DeepSkyBlue)
    Private myNum As Brush = New SolidBrush(Color.Red)

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
                If marix(row, column) = 16 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myships, rect)
                ElseIf marix(row, column) = 1 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("1", myFont, myNum, rect)
                ElseIf marix(row, column) = 2 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("2", myFont, myNum, rect)
                ElseIf marix(row, column) = 3 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("3", myFont, myNum, rect)
                ElseIf marix(row, column) = 4 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("4", myFont, myNum, rect)
                ElseIf marix(row, column) = 5 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("5", myFont, myNum, rect)
                ElseIf marix(row, column) = 6 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("6", myFont, myNum, rect)
                ElseIf marix(row, column) = 7 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("7", myFont, myNum, rect)
                ElseIf marix(row, column) = 8 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("8", myFont, myNum, rect)
                ElseIf marix(row, column) = 9 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("9", myFont, myNum, rect)
                ElseIf marix(row, column) = 10 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("10", myFont, myNum, rect)
                ElseIf marix(row, column) = 11 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("11", myFont, myNum, rect)
                ElseIf marix(row, column) = 12 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("12", myFont, myNum, rect)
                ElseIf marix(row, column) = 13 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("13", myFont, myNum, rect)
                ElseIf marix(row, column) = 14 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("14", myFont, myNum, rect)
                ElseIf marix(row, column) = 15 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myWater, rect)
                    myGraphics.DrawString("15", myFont, myNum, rect)
                ElseIf marix(row, column) = 0 Then
                    Dim rect = New Rectangle(c, r, width, height)
                    myGraphics.FillRectangle(myNum, rect)

                End If
            Next column
        Next row
    End Sub

End Class

