Imports System.Diagnostics.Metrics
Imports AGauge

Public Class FormGraficTime
    Private ag1 As New AGauge()
    Private ag2 As New AGauge()
    Private ag3 As New AGauge()
    Dim lblMinute1 As New Label()
    Dim lblMinute2 As New Label()
    Dim lblMinute3 As New Label()
    Dim lblTitle1 As New Label()
    Dim lblTitle2 As New Label()
    Dim lblTitle3 As New Label()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gauge 
        ag1 = New AGauge()
        ConfigureGauge(ag1)
        tlpRow1Column0.Controls.Add(ag1, 0, 1)

        ag2 = New AGauge()
        ConfigureGauge(ag2)
        tlpRow1Column1.Controls.Add(ag2, 1, 1)

        ag3 = New AGauge()
        ConfigureGauge(ag3)
        tlpRow1Column2.Controls.Add(ag3, 2, 1)

        'Label gauge
        ConfigureLabelGauge(lblMinute1)
        tlpRow1Column0.Controls.Add(lblMinute1, 0, 2)

        ConfigureLabelGauge(lblMinute2)
        tlpRow1Column1.Controls.Add(lblMinute2, 0, 2)

        ConfigureLabelGauge(lblMinute3)
        tlpRow1Column2.Controls.Add(lblMinute3, 0, 2)

        'Label title gauge
        ConfigureLabelTitleGauge(lblTitle1)
        tlpRow1Column0.Controls.Add(lblTitle1, 0, 0)

        ConfigureLabelTitleGauge(lblTitle2)
        tlpRow1Column1.Controls.Add(lblTitle2, 0, 0)

        ConfigureLabelTitleGauge(lblTitle3)
        tlpRow1Column2.Controls.Add(lblTitle3, 0, 0)
    End Sub

    Private Sub ConfigureLabelGauge(lblN As Label)
        lblN.AutoSize = False
        lblN.Dock = DockStyle.Fill
        lblN.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub ConfigureLabelTitleGauge(lblN As Label)
        lblN.AutoSize = False
        lblN.Dock = DockStyle.Fill
        lblN.TextAlign = ContentAlignment.MiddleCenter
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
    Private Sub UpdateGauge(gaugeN As AGauge, nVal As Integer, lblN As Label)
        gaugeN.Value = nVal
        ChangeGaugeColor(gaugeN)
        lblN.Text = gaugeN.Value.ToString("0") & " min."
    End Sub

    Private Sub UpdateTitleGauge(lblTitleN As Label, sTitleN As String)
        lblTitleN.Text = sTitleN
    End Sub

    Public Sub Set_nTime1(nVal As Integer)
        UpdateGauge(ag1, nVal, lblMinute1)
    End Sub

    Public Sub Set_nTime2(nVal As Integer)
        UpdateGauge(ag2, nVal, lblMinute2)
    End Sub

    Public Sub Set_nTime3(nVal As Integer)
        UpdateGauge(ag3, nVal, lblMinute3)
    End Sub

    Public Sub Set_sTitle1(sTitle As String)
        UpdateTitleGauge(lblTitle1, sTitle)
    End Sub

End Class
