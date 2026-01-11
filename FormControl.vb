Public Class FormControl
    Private display As FormGraficTime

    Private Sub FormControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Creo il form display
        display = New FormGraficTime()
        display.Show()

        'Eseguo init da codice, altrimenti display potrebbe andare in errore
        nudTime1.Minimum = 5
        nudTime1.Maximum = 120
        nudTime1.Increment = 5
    End Sub

    Private Sub nudTime1_ValueChanged(sender As Object, e As EventArgs) Handles nudTime1.ValueChanged
        display.Set_nTime1(nudTime1.Value)
    End Sub

    Private Sub txtTitleTime1_TextChanged(sender As Object, e As EventArgs) Handles txtTitleTime1.TextChanged
        display.Set_sTitle1(txtTitleTime1.Text)
    End Sub
End Class