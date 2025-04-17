Imports System.Threading.Tasks
Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
        ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer
    ) As IntPtr
    End Function

    Dim timerValue As Int32

    Dim secTime As Int32 = 0
    Dim minTime As Int32 = 0
    Dim hrTime As Int32 = 0
    Dim toggleStart As Boolean = False
    Dim paused As Boolean = False

    Private isDragging As Boolean = False
    Private startPoint As Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        isDragging = True
        startPoint = e.Location
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isDragging Then
            Dim newPoint As New Point(Me.Location.X + (e.X - startPoint.X), Me.Location.Y + (e.Y - startPoint.Y))
            Me.Location = newPoint
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isDragging = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.BackgroundImage = My.Resources.Polygon_1
        Me.TopMost = True
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 30, 30))
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If toggleStart = True Then
            toggleStart = False
            Button2.BackgroundImage = My.Resources.Polygon_1
        Else
            toggleStart = True
            Button2.BackgroundImage = My.Resources.Group_1
            If paused = True Then
                Label1.ForeColor = Color.Lime
                Await Task.Delay(1000)
            End If
        End If

        While toggleStart
            paused = True

            If secTime >= 59 Then
                minTime += 1
                secTime = -1
                If minTime < 10 Then
                    minTime = "0" & minTime
                End If
            End If

            If minTime >= 59 Then
                hrTime += 1
                minTime = 0
                If hrTime < 10 Then
                    hrTime = "0" & hrTime
                End If
            End If

            If hrTime >= 24 Then
                toggleStart = False
            End If

            secTime += 1

            If secTime < 10 Then
                secTime = "0" & secTime
            End If

            Label1.Text = hrTime.ToString("00") & ":" & minTime.ToString("00") & ":" & secTime.ToString("00")

            Await Task.Delay(1000)
        End While
        If paused = True Then
            Label1.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        toggleStart = False
        paused = False
        secTime = 0
        minTime = 0
        hrTime = 0
        Label1.Text = "00:00:00"
        Button2.BackgroundImage = My.Resources.Polygon_1
        Label1.ForeColor = Color.Lime
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class