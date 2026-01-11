Imports AGauge

Public Class FormGraficTime

    ' ====== GAUGE ======
    Private ag1 As New AGauge()
    Private ag2 As New AGauge()
    Private ag3 As New AGauge()

    ' ====== PANEL CONTENITORI ======
    Private pnl1 As New Panel()
    Private pnl2 As New Panel()
    Private pnl3 As New Panel()

    ' ====== LABEL ======
    Private lblMinute1 As New Label()
    Private lblMinute2 As New Label()
    Private lblMinute3 As New Label()

    Private lblTitle1 As New Label()
    Private lblTitle2 As New Label()
    Private lblTitle3 As New Label()

    ' ==============================
    ' FORM LOAD
    ' ==============================
    Private Sub FormGraficTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreaColonna(tlpRow1Column0, ag1, pnl1, lblTitle1, lblMinute1)
        CreaColonna(tlpRow1Column1, ag2, pnl2, lblTitle2, lblMinute2)
        CreaColonna(tlpRow1Column2, ag3, pnl3, lblTitle3, lblMinute3)
    End Sub

    ' ==============================
    ' CREAZIONE COLONNA COMPLETA
    ' ==============================
    Private Sub CreaColonna(
        tlp As TableLayoutPanel,
        g As AGauge,
        pnl As Panel,
        lblTitle As Label,
        lblMinute As Label)

        ' --- Titolo ---
        ConfigureLabelTitleGauge(lblTitle)
        tlp.Controls.Add(lblTitle, 0, 0)

        ' --- Panel ---
        pnl.Dock = DockStyle.Fill
        pnl.Padding = New Padding(6)
        tlp.Controls.Add(pnl, 0, 1)

        ' --- Gauge ---
        ConfigureGauge(g)
        g.Dock = DockStyle.None
        pnl.Controls.Add(g)

        ' Resize gestito DAL PANEL
        AddHandler pnl.Resize, AddressOf Panel_Resize

        ' --- Minuti ---
        ConfigureLabelGauge(lblMinute)
        tlp.Controls.Add(lblMinute, 0, 2)

    End Sub

    ' ==============================
    ' CONFIGURAZIONI
    ' ==============================
    Private Sub ConfigureGauge(g As AGauge)
        g.MinValue = 0
        g.MaxValue = 120

        g.BaseArcStart = 180
        g.BaseArcSweep = 180
        g.BaseArcWidth = 35
        g.BaseArcColor = Color.LightGray

        g.NeedleWidth = 4

        g.ScaleNumbersFormat = "0"
        g.ScaleNumbersColor = Color.Black

    End Sub

    Private Sub ConfigureLabelGauge(lbl As Label)
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Font = New Font("Segoe UI", 11, FontStyle.Bold)
    End Sub

    Private Sub ConfigureLabelTitleGauge(lbl As Label)
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    ' ==============================
    ' RESIZE CORRETTO (SUL PANEL)
    ' ==============================
    Private Sub Panel_Resize(sender As Object, e As EventArgs)
        Dim pnl As Panel = CType(sender, Panel)
        If pnl.Controls.Count = 0 Then Exit Sub

        Dim g As AGauge = CType(pnl.Controls(0), AGauge)

        Dim lato As Integer = Math.Min(pnl.ClientSize.Width, pnl.ClientSize.Height)
        If lato < 60 Then Exit Sub

        ' Gauge quadrato
        g.Size = New Size(lato, lato)

        g.Location = New Point(
        (pnl.ClientSize.Width - lato) \ 2,
        (pnl.ClientSize.Height - lato) \ 2
    )
        g.Center = New Point(lato \ 2, lato \ 2)

        g.BaseArcRadius = CInt(lato * 0.3)
        g.NeedleRadius = CInt(lato * 0.26)
        g.ScaleNumbersRadius = CInt(lato * 0.34)

        g.Invalidate()
    End Sub

    ' ==============================
    ' AGGIORNAMENTO DATI
    ' ==============================
    Private Sub ChangeGaugeColor(g As AGauge)
        Select Case g.Value
            Case <= 45
                g.BaseArcColor = Color.Green
            Case <= 90
                g.BaseArcColor = Color.Goldenrod
            Case Else
                g.BaseArcColor = Color.Red
        End Select
    End Sub

    Private Sub UpdateGauge(g As AGauge, valore As Integer, lbl As Label)
        g.Value = valore
        ChangeGaugeColor(g)
        lbl.Text = valore.ToString() & " min"
    End Sub

    ' ==============================
    ' CHIAMATE ESTERNE
    ' ==============================
    Public Sub Set_nTime1(v As Integer)
        UpdateGauge(ag1, v, lblMinute1)
    End Sub

    Public Sub Set_nTime2(v As Integer)
        UpdateGauge(ag2, v, lblMinute2)
    End Sub

    Public Sub Set_nTime3(v As Integer)
        UpdateGauge(ag3, v, lblMinute3)
    End Sub

    Public Sub Set_sTitle1(t As String)
        lblTitle1.Text = t
    End Sub

    Public Sub Set_sTitle2(t As String)
        lblTitle2.Text = t
    End Sub

    Public Sub Set_sTitle3(t As String)
        lblTitle3.Text = t
    End Sub

End Class
