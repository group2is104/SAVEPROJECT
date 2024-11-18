Imports System.Drawing.Drawing2D
Imports FontAwesome.Sharp

Public Class RoundIconButton
    Inherits IconButton
    Public Property CornerRadius As Integer = 20 ' Default corner radius

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Create rounded rectangle
        Dim graphics As Graphics = pevent.Graphics
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As GraphicsPath = GetRoundedRectanglePath(rect, CornerRadius)

        ' Clip the button to the rounded rectangle
        Me.Region = New Region(path)

        ' Optionally remove the border by commenting out the code below:
        ' Dim borderPen As New Pen(Color.Black, 2)
        ' graphics.SmoothingMode = SmoothingMode.AntiAlias
        ' graphics.DrawPath(borderPen, path)
    End Sub

    Private Function GetRoundedRectanglePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        ' Add arcs and lines for rounded corners
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class
