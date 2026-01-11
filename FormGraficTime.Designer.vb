<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGraficTime
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
        tlpMain = New TableLayoutPanel()
        tlpRow1 = New TableLayoutPanel()
        tlpRow1Column2 = New TableLayoutPanel()
        pnl3 = New Panel()
        tlpRow1Column1 = New TableLayoutPanel()
        pnl2 = New Panel()
        tlpRow1Column0 = New TableLayoutPanel()
        pnl1 = New Panel()
        tlpMain.SuspendLayout()
        tlpRow1.SuspendLayout()
        tlpRow1Column2.SuspendLayout()
        tlpRow1Column1.SuspendLayout()
        tlpRow1Column0.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpMain
        ' 
        tlpMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpMain.ColumnCount = 1
        tlpMain.ColumnStyles.Add(New ColumnStyle())
        tlpMain.Controls.Add(tlpRow1, 0, 1)
        tlpMain.Location = New Point(12, 12)
        tlpMain.Name = "tlpMain"
        tlpMain.RightToLeft = RightToLeft.No
        tlpMain.RowCount = 3
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 75F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMain.Size = New Size(776, 426)
        tlpMain.TabIndex = 0
        ' 
        ' tlpRow1
        ' 
        tlpRow1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpRow1.ColumnCount = 3
        tlpRow1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        tlpRow1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34F))
        tlpRow1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        tlpRow1.Controls.Add(tlpRow1Column2, 2, 0)
        tlpRow1.Controls.Add(tlpRow1Column1, 1, 0)
        tlpRow1.Controls.Add(tlpRow1Column0, 0, 0)
        tlpRow1.Location = New Point(3, 66)
        tlpRow1.Name = "tlpRow1"
        tlpRow1.RowCount = 1
        tlpRow1.RowStyles.Add(New RowStyle())
        tlpRow1.Size = New Size(773, 313)
        tlpRow1.TabIndex = 0
        ' 
        ' tlpRow1Column2
        ' 
        tlpRow1Column2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpRow1Column2.ColumnCount = 1
        tlpRow1Column2.ColumnStyles.Add(New ColumnStyle())
        tlpRow1Column2.Controls.Add(pnl3, 0, 1)
        tlpRow1Column2.Location = New Point(520, 3)
        tlpRow1Column2.Name = "tlpRow1Column2"
        tlpRow1Column2.RowCount = 2
        tlpRow1Column2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpRow1Column2.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        tlpRow1Column2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpRow1Column2.Size = New Size(250, 307)
        tlpRow1Column2.TabIndex = 2
        ' 
        ' pnl3
        ' 
        pnl3.Dock = DockStyle.Fill
        pnl3.Location = New Point(3, 33)
        pnl3.Name = "pnl3"
        pnl3.Size = New Size(247, 271)
        pnl3.TabIndex = 0
        ' 
        ' tlpRow1Column1
        ' 
        tlpRow1Column1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpRow1Column1.ColumnCount = 1
        tlpRow1Column1.ColumnStyles.Add(New ColumnStyle())
        tlpRow1Column1.Controls.Add(pnl2, 0, 1)
        tlpRow1Column1.Location = New Point(258, 3)
        tlpRow1Column1.Name = "tlpRow1Column1"
        tlpRow1Column1.RowCount = 2
        tlpRow1Column1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpRow1Column1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        tlpRow1Column1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpRow1Column1.Size = New Size(256, 307)
        tlpRow1Column1.TabIndex = 1
        ' 
        ' pnl2
        ' 
        pnl2.Dock = DockStyle.Fill
        pnl2.Location = New Point(3, 33)
        pnl2.Name = "pnl2"
        pnl2.Size = New Size(253, 271)
        pnl2.TabIndex = 0
        ' 
        ' tlpRow1Column0
        ' 
        tlpRow1Column0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpRow1Column0.ColumnCount = 1
        tlpRow1Column0.ColumnStyles.Add(New ColumnStyle())
        tlpRow1Column0.Controls.Add(pnl1, 0, 1)
        tlpRow1Column0.Location = New Point(3, 3)
        tlpRow1Column0.Name = "tlpRow1Column0"
        tlpRow1Column0.RowCount = 2
        tlpRow1Column0.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tlpRow1Column0.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        tlpRow1Column0.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpRow1Column0.Size = New Size(249, 307)
        tlpRow1Column0.TabIndex = 0
        ' 
        ' pnl1
        ' 
        pnl1.Dock = DockStyle.Fill
        pnl1.Location = New Point(3, 33)
        pnl1.Name = "pnl1"
        pnl1.Size = New Size(246, 271)
        pnl1.TabIndex = 0
        ' 
        ' FormGraficTime
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tlpMain)
        Name = "FormGraficTime"
        Text = "FormGraficTime"
        tlpMain.ResumeLayout(False)
        tlpRow1.ResumeLayout(False)
        tlpRow1Column2.ResumeLayout(False)
        tlpRow1Column1.ResumeLayout(False)
        tlpRow1Column0.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpRow1 As TableLayoutPanel
    Friend WithEvents tlpRow1Column2 As TableLayoutPanel
    Friend WithEvents tlpRow1Column1 As TableLayoutPanel
    Friend WithEvents tlpRow1Column0 As TableLayoutPanel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents pnl2 As Panel
    Friend WithEvents pnl3 As Panel
End Class
