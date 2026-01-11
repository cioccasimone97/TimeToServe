Imports System.Diagnostics.Metrics
Public Class FormControl
    Private display As FormGraficTime
    Private fontNameMin As String
    Private fontSizeMin As Single
    Private fontNameTitle As String
    Private fontSizeTitle As Single

    Private Sub FormControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ==============================
        ' Creo il form display
        display = New FormGraficTime()
        display.Show()

        'Eseguo init da codice, altrimenti display potrebbe andare in errore
        nudTime1.Minimum = 5
        nudTime1.Maximum = 120
        nudTime1.Increment = 5
        nudTime2.Minimum = 5
        nudTime2.Maximum = 120
        nudTime2.Increment = 5
        nudTime3.Minimum = 5
        nudTime3.Maximum = 120
        nudTime3.Increment = 5

        ' ==============================
        'Carico i valori per gestire font e dimensione dei minuti
        ' --- ComboBox Font ---
        For Each f As FontFamily In FontFamily.Families
            If Not String.IsNullOrWhiteSpace(f.Name) Then
                cmbFontMin.Items.Add(f.Name)
            End If
        Next
        cmbFontMin.SelectedItem = Me.Font.Name
        AddHandler cmbFontMin.SelectedIndexChanged, AddressOf UpdateLabelFontMin

        ' --- NumericUpDown Dimensione Font ---
        nudSizeMin.Minimum = 15
        nudSizeMin.Maximum = 99
        nudSizeMin.Value = 25
        AddHandler nudSizeMin.ValueChanged, AddressOf UpdateLabelFontMin

        ' ==============================
        'Carico i valori per gestire font e dimensione dei titoli
        ' --- ComboBox Font ---
        For Each f As FontFamily In FontFamily.Families
            If Not String.IsNullOrWhiteSpace(f.Name) Then
                cmbFontTitle.Items.Add(f.Name)
            End If
        Next
        cmbFontTitle.SelectedItem = Me.Font.Name
        AddHandler cmbFontTitle.SelectedIndexChanged, AddressOf UpdateLabelFontTitle

        ' --- NumericUpDown Dimensione Font ---
        nudSizeTitle.Minimum = 20
        nudSizeTitle.Maximum = 150
        nudSizeTitle.Value = 35
        AddHandler nudSizeTitle.ValueChanged, AddressOf UpdateLabelFontTitle

        'Carico tutti gli aggiornamenti
        UpdateLabelFontMin()
        UpdateLabelFontTitle()
    End Sub
    Private Sub UpdateLabelFontMin()
        fontNameMin = If(cmbFontMin.SelectedItem IsNot Nothing, cmbFontMin.SelectedItem.ToString(), Me.Font.ToString())
        fontSizeMin = If(CSng(nudSizeMin.Value) = 0, 12, CSng(nudSizeMin.Value))

        nudTime1_ValueChanged(Nothing, EventArgs.Empty)
        nudTime2_ValueChanged(Nothing, EventArgs.Empty)
        nudTime3_ValueChanged(Nothing, EventArgs.Empty)
    End Sub

    Private Sub UpdateLabelFontTitle()
        fontNameTitle = If(cmbFontTitle.SelectedItem IsNot Nothing, cmbFontTitle.SelectedItem.ToString(), Me.Font.ToString())
        fontSizeTitle = If(CSng(nudSizeTitle.Value) = 0, 35, CSng(nudSizeTitle.Value))

        txtTitleTime1_TextChanged(Nothing, EventArgs.Empty)
        txtTitleTime2_TextChanged(Nothing, EventArgs.Empty)
        txtTitleTime3_TextChanged(Nothing, EventArgs.Empty)
    End Sub

    Private Sub nudTime1_ValueChanged(sender As Object, e As EventArgs) Handles nudTime1.ValueChanged
        display.Set_nTime1(nudTime1.Value, New Font(fontNameMin, If(CSng(fontSizeMin) = 0, 12, CSng(fontSizeMin)), FontStyle.Bold))
    End Sub

    Private Sub txtTitleTime1_TextChanged(sender As Object, e As EventArgs) Handles txtTitleTime1.TextChanged
        display.Set_sTitle1(txtTitleTime1.Text, New Font(fontNameTitle, If(CSng(fontSizeTitle) = 0, 35, CSng(fontSizeTitle)), FontStyle.Bold))
    End Sub

    Private Sub nudTime2_ValueChanged(sender As Object, e As EventArgs) Handles nudTime2.ValueChanged
        display.Set_nTime2(nudTime2.Value, New Font(fontNameMin, If(CSng(fontSizeMin) = 0, 12, CSng(fontSizeMin)), FontStyle.Bold))
    End Sub

    Private Sub txtTitleTime2_TextChanged(sender As Object, e As EventArgs) Handles txtTitleTime2.TextChanged
        display.Set_sTitle2(txtTitleTime2.Text, New Font(fontNameTitle, If(CSng(fontSizeTitle) = 0, 35, CSng(fontSizeTitle)), FontStyle.Bold))
    End Sub

    Private Sub nudTime3_ValueChanged(sender As Object, e As EventArgs) Handles nudTime3.ValueChanged
        display.Set_nTime3(nudTime3.Value, New Font(fontNameMin, If(CSng(fontSizeMin) = 0, 12, CSng(fontSizeMin)), FontStyle.Bold))
    End Sub

    Private Sub txtTitleTime3_TextChanged(sender As Object, e As EventArgs) Handles txtTitleTime3.TextChanged
        display.Set_sTitle3(txtTitleTime3.Text, New Font(fontNameTitle, If(CSng(fontSizeTitle) = 0, 35, CSng(fontSizeTitle)), FontStyle.Bold))
    End Sub

    Private Sub FormControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result1 As DialogResult = MessageBox.Show("Sei sicuro di voler chiudere?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result1 = DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

End Class