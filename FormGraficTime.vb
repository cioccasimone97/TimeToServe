Imports System.Diagnostics.Metrics
Imports System.Drawing.Drawing2D
Imports AGauge

Public Class FormGraficTime

    ' ====== GAUGE ======
    Private ag1 As New AGauge()
    Private ag2 As New AGauge()
    Private ag3 As New AGauge()

    ' ====== LABEL ======
    Private lblMinute1 As New Label()
    Private lblMinute2 As New Label()
    Private lblMinute3 As New Label()

    Private lblTitle1 As New Label()
    Private lblTitle2 As New Label()
    Private lblTitle3 As New Label()

    '===== COLORI ======
    Public PastelGreen As Color = Color.FromArgb(255, 0, 200, 0)
    Public PastelYellow As Color = Color.FromArgb(255, 240, 220, 50)
    Public PastelRed As Color = Color.FromArgb(255, 220, 50, 60)


    ' ==============================
    ' FORM LOAD
    ' ==============================
    Private Sub FormGraficTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '===DEBUG===
        pnl1.BorderStyle = BorderStyle.FixedSingle
        '===DEBUG===
        CreaColonna(tlpRow1Column0, ag1, pnl1, lblTitle1, lblMinute1)
        CreaColonna(tlpRow1Column1, ag2, pnl2, lblTitle2, lblMinute2)
        CreaColonna(tlpRow1Column2, ag3, pnl3, lblTitle3, lblMinute3)

        ' Rimuove il bordo della finestra
        'Me.FormBorderStyle = FormBorderStyle.None

        ' Massimizza la finestra
        Me.WindowState = FormWindowState.Maximized
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

        ' --- Gauge ---
        ConfigureGauge(g)
        g.Dock = DockStyle.None
        pnl.Controls.Add(g)

        ' Resize gestito DAL PANEL
        AddHandler pnl.Resize, AddressOf Panel_Resize

        ' --- Minuti ---
        ConfigureLabelGauge(lblMinute, g)
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

        g.NeedleType = NeedleType.Advance
        g.NeedleWidth = 4

        g.ScaleNumbersFormat = "0"
        g.ScaleNumbersColor = Color.Black

        g.ScaleLinesMajorStepValue = 30
    End Sub

    Private Sub ConfigureLabelGauge(lbl As Label, gauge As AGauge)
        lbl.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lbl.AutoSize = True
        MakeLabelAlwaysCentered(lbl, gauge, Me)
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
        g.ScaleLinesInterInnerRadius = CInt(lato * 0.28)
        g.ScaleLinesInterOuterRadius = CInt(lato * 0.31)
        g.ScaleLinesMajorInnerRadius = CInt(lato * 0.28)
        g.ScaleLinesMajorOuterRadius = CInt(lato * 0.31)
        g.ScaleLinesMinorInnerRadius = CInt(lato * 0.28)
        g.ScaleLinesMinorOuterRadius = CInt(lato * 0.29)

        g.Invalidate()
    End Sub

    ' ==============================
    ' AGGIORNAMENTO DATI
    ' ==============================
    Private Sub ChangeGaugeColor(g As AGauge)
        Select Case g.Value
            Case <= 45
                g.BaseArcColor = PastelGreen
            Case <= 90
                g.BaseArcColor = PastelYellow
            Case Else
                g.BaseArcColor = PastelRed
        End Select
    End Sub

    Private Sub UpdateGauge(g As AGauge, valore As Integer, lbl As Label)
        g.Value = valore
        ChangeGaugeColor(g)
        lbl.Text = valore.ToString() & " min"
    End Sub

    Public Sub MakeLabelAlwaysCentered(lbl As Label, targetControl As Control, parentForm As Form)
        ' Imposta font e AutoSize se non già fatto
        lbl.AutoSize = True
        lbl.BackColor = Color.Transparent
        lbl.ForeColor = Color.Black
        If Not parentForm.Controls.Contains(lbl) Then
            parentForm.Controls.Add(lbl)
        End If

        ' Funzione interna per aggiornare la posizione
        Dim UpdatePosition As Action = Sub()
                                           ' Calcola centro del target relativo al parent
                                           Dim centerInTarget As New Point(targetControl.Width \ 2, targetControl.Height \ 2)
                                           ' Converte in coordinate relative al form
                                           Dim centerOnForm As Point = targetControl.Parent.PointToScreen(centerInTarget)
                                           centerOnForm = parentForm.PointToClient(centerOnForm)
                                           ' Posiziona la label centrata sul punto
                                           Dim offsetX As Integer = CInt(-0.05 * targetControl.Width)
                                           Dim offsetY As Integer = CInt(0.1 * targetControl.Height)
                                           lbl.Location = New Point(centerOnForm.X - lbl.Width \ 2 + offsetX,
                         centerOnForm.Y - lbl.Height \ 2 + offsetY)
                                           ' Porta sopra tutto
                                           lbl.BringToFront()
                                       End Sub

        ' Aggiorna subito la posizione
        UpdatePosition()

        ' Aggiorna la posizione al resize del form o del target
        AddHandler parentForm.Resize, Sub(s, e) UpdatePosition()
        AddHandler targetControl.Resize, Sub(s, e) UpdatePosition()
        AddHandler targetControl.Parent.Resize, Sub(s, e) UpdatePosition() ' Se target è dentro panel o tablelayout
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
