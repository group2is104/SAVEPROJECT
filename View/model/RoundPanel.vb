Imports System.Drawing.Drawing2D

Public Class RoundPanel
    Inherits Panel

    Private _cornerRadius As Integer = 20

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graphics As Graphics = e.Graphics
        Dim rect As Rectangle = Me.ClientRectangle

        Using path As New GraphicsPath()
            path.AddArc(rect.X, rect.Y, _cornerRadius, _cornerRadius, 180, 90)
            path.AddArc(rect.Right - _cornerRadius, rect.Y, _cornerRadius, _cornerRadius, 270, 90)
            path.AddArc(rect.Right - _cornerRadius, rect.Bottom - _cornerRadius, _cornerRadius, _cornerRadius, 0, 90)
            path.AddArc(rect.X, rect.Bottom - _cornerRadius, _cornerRadius, _cornerRadius, 90, 90)
            path.CloseFigure()
            Me.Region = New Region(path)
        End Using
    End Sub
End Class
