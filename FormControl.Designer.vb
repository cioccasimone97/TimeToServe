<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControl
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTitleTime1 = New TextBox()
        nudTime1 = New NumericUpDown()
        lblTime1 = New Label()
        CType(nudTime1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitleTime1
        ' 
        txtTitleTime1.Location = New Point(76, 42)
        txtTitleTime1.Name = "txtTitleTime1"
        txtTitleTime1.Size = New Size(203, 23)
        txtTitleTime1.TabIndex = 1
        ' 
        ' nudTime1
        ' 
        nudTime1.Location = New Point(76, 71)
        nudTime1.Name = "nudTime1"
        nudTime1.Size = New Size(120, 23)
        nudTime1.TabIndex = 2
        ' 
        ' lblTime1
        ' 
        lblTime1.AutoSize = True
        lblTime1.Location = New Point(209, 75)
        lblTime1.Name = "lblTime1"
        lblTime1.Size = New Size(41, 15)
        lblTime1.TabIndex = 3
        lblTime1.Text = "in Min"
        ' 
        ' FormControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTime1)
        Controls.Add(nudTime1)
        Controls.Add(txtTitleTime1)
        Name = "FormControl"
        Text = "FormControl"
        CType(nudTime1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtTitleTime1 As TextBox
    Friend WithEvents nudTime1 As NumericUpDown
    Friend WithEvents lblTime1 As Label
End Class
