Imports LiveCharts
Imports LiveCharts.WinForms

Public Class FormGraficTime

    Private gauge1 As AngularGauge

    Private Sub FormGraficTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gauge 1
        gauge1 = New AngularGauge()
        gauge1.FromValue = 0
        gauge1.ToValue = 100
        gauge1.Value = 50
        gauge1.Dock = DockStyle.Top
        gauge1.Height = 150
        Me.Controls.Add(gauge1)
    End Sub

    Public Sub Set_nTime1(valore As Integer)
        gauge1.Value = valore
    End Sub
End Class
