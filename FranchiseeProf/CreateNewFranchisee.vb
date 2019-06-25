Public Class pnlMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub


End Class