Imports AGauge

Public Class FormGraficTime
    Private ag1 As AGauge
    Private Sub FormGraficTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gauge 1
        ag1 = New AGauge()
        ag1.Width = 300
        ag1.Height = 200
        ag1.Location = New Point(10, 10)

        ' Semicerchio: 180° → da 135° a 45°
        ag1.BaseArcStart = 135
        ag1.BaseArcSweep = 270

        ' Range
        ag1.MinValue = 5
        ag1.MaxValue = 120
        ag1.Value = 5

        ' Sfondo
        ag1.BaseArcColor = Color.LightGray
        ag1.BaseArcRadius = 80
        ag1.BaseArcWidth = 10

        ' Ago
        ag1.NeedleRadius = 70
        ag1.NeedleWidth = 5

        ' Numeri
        ag1.ScaleNumbersColor = Color.Black
        ag1.ScaleNumbersRadius = 85
        ag1.ScaleNumbersFormat = "0"

        ' Aggiungi al form
        Me.Controls.Add(ag1)
    End Sub

    Public Sub Set_nTime1(valore As Integer)
        ag1.Value = Math.Min(ag1.MaxValue, Math.Max(ag1.MinValue, valore))
    End Sub
End Class
