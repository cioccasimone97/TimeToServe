Imports System.Diagnostics.Metrics
Imports AGauge

Public Class FormGraficTime
    Private ag1 As New AGauge()
    Private ag2 As New AGauge()
    Private ag3 As New AGauge()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gauge 1
        ag1 = New AGauge()
        ConfigureGauge(ag1)
        TableLayoutPanel2.Controls.Add(ag1, 0, 0)

        ' Gauge 2
        ag2 = New AGauge()
        ConfigureGauge(ag2)
        TableLayoutPanel2.Controls.Add(ag2, 1, 0)

        ' Gauge 3
        ag3 = New AGauge()
        ConfigureGauge(ag3)
        TableLayoutPanel2.Controls.Add(ag3, 2, 0)
    End Sub

    Private Sub ConfigureGauge(gaugeN As AGauge)
        gaugeN.Dock = DockStyle.None
        gaugeN.Anchor = AnchorStyles.None

        ' Semicerchio: 180° → da 135° a 45°
        gaugeN.BaseArcStart = 135
        gaugeN.BaseArcSweep = 270

        ' Range
        gaugeN.MinValue = 5
        gaugeN.MaxValue = 120
        gaugeN.Value = 5

        ' Sfondo
        gaugeN.BaseArcColor = Color.LightGray
        gaugeN.BaseArcRadius = 80
        gaugeN.BaseArcWidth = 10

        ' Ago
        gaugeN.NeedleRadius = 70
        gaugeN.NeedleWidth = 5

        ' Numeri
        gaugeN.ScaleNumbersColor = Color.Black
        gaugeN.ScaleNumbersRadius = 85
        gaugeN.ScaleNumbersFormat = "0"
    End Sub

    Private Sub ChangeGaugeColor(gaugeN As AGauge)
        If gaugeN.Value <= 45 Then
            gaugeN.BaseArcColor = Color.Green
        End If
        If gaugeN.Value > 45 And gaugeN.Value < 90 Then
            gaugeN.BaseArcColor = Color.Yellow
        End If
        If gaugeN.Value >= 90 Then
            gaugeN.BaseArcColor = Color.Red
        End If
    End Sub

    Public Sub Set_nTime1(nVal As Integer)
        ag1.Value = nVal
        ChangeGaugeColor(ag1)
    End Sub
End Class
