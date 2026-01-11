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
        nudTime2 = New NumericUpDown()
        txtTitleTime2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        nudTime3 = New NumericUpDown()
        txtTitleTime3 = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        pnl1 = New Panel()
        pnl2 = New Panel()
        pnl3 = New Panel()
        pnlFontMin = New Panel()
        nudSizeMin = New NumericUpDown()
        cmbFontMin = New ComboBox()
        pnlFontTitle = New Panel()
        nudSizeTitle = New NumericUpDown()
        cmbFontTitle = New ComboBox()
        CType(nudTime1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTime2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTime3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        pnl1.SuspendLayout()
        pnl2.SuspendLayout()
        pnl3.SuspendLayout()
        pnlFontMin.SuspendLayout()
        CType(nudSizeMin, ComponentModel.ISupportInitialize).BeginInit()
        pnlFontTitle.SuspendLayout()
        CType(nudSizeTitle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitleTime1
        ' 
        txtTitleTime1.Location = New Point(24, 16)
        txtTitleTime1.Name = "txtTitleTime1"
        txtTitleTime1.Size = New Size(203, 23)
        txtTitleTime1.TabIndex = 1
        ' 
        ' nudTime1
        ' 
        nudTime1.Location = New Point(24, 45)
        nudTime1.Name = "nudTime1"
        nudTime1.Size = New Size(120, 23)
        nudTime1.TabIndex = 2
        ' 
        ' lblTime1
        ' 
        lblTime1.AutoSize = True
        lblTime1.Location = New Point(157, 49)
        lblTime1.Name = "lblTime1"
        lblTime1.Size = New Size(41, 15)
        lblTime1.TabIndex = 3
        lblTime1.Text = "in Min"
        ' 
        ' nudTime2
        ' 
        nudTime2.Location = New Point(26, 45)
        nudTime2.Name = "nudTime2"
        nudTime2.Size = New Size(120, 23)
        nudTime2.TabIndex = 5
        ' 
        ' txtTitleTime2
        ' 
        txtTitleTime2.Location = New Point(26, 16)
        txtTitleTime2.Name = "txtTitleTime2"
        txtTitleTime2.Size = New Size(203, 23)
        txtTitleTime2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(164, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 6
        Label1.Text = "in Min"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 9
        Label2.Text = "in Min"
        ' 
        ' nudTime3
        ' 
        nudTime3.Location = New Point(19, 45)
        nudTime3.Name = "nudTime3"
        nudTime3.Size = New Size(120, 23)
        nudTime3.TabIndex = 8
        ' 
        ' txtTitleTime3
        ' 
        txtTitleTime3.Location = New Point(19, 16)
        txtTitleTime3.Name = "txtTitleTime3"
        txtTitleTime3.Size = New Size(203, 23)
        txtTitleTime3.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel1.Controls.Add(pnlFontMin, 0, 3)
        TableLayoutPanel1.Controls.Add(pnlFontTitle, 0, 1)
        TableLayoutPanel1.Location = New Point(12, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(776, 426)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33F))
        TableLayoutPanel2.Controls.Add(pnl1, 0, 0)
        TableLayoutPanel2.Controls.Add(pnl2, 1, 0)
        TableLayoutPanel2.Controls.Add(pnl3, 2, 0)
        TableLayoutPanel2.Location = New Point(3, 130)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(773, 249)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' pnl1
        ' 
        pnl1.Controls.Add(txtTitleTime1)
        pnl1.Controls.Add(nudTime1)
        pnl1.Controls.Add(lblTime1)
        pnl1.Dock = DockStyle.Fill
        pnl1.Location = New Point(3, 3)
        pnl1.Name = "pnl1"
        pnl1.Size = New Size(249, 250)
        pnl1.TabIndex = 0
        ' 
        ' pnl2
        ' 
        pnl2.Controls.Add(txtTitleTime2)
        pnl2.Controls.Add(nudTime2)
        pnl2.Controls.Add(Label1)
        pnl2.Dock = DockStyle.Fill
        pnl2.Location = New Point(258, 3)
        pnl2.Name = "pnl2"
        pnl2.Size = New Size(256, 250)
        pnl2.TabIndex = 1
        ' 
        ' pnl3
        ' 
        pnl3.Controls.Add(Label2)
        pnl3.Controls.Add(txtTitleTime3)
        pnl3.Controls.Add(nudTime3)
        pnl3.Dock = DockStyle.Fill
        pnl3.Location = New Point(520, 3)
        pnl3.Name = "pnl3"
        pnl3.Size = New Size(250, 250)
        pnl3.TabIndex = 2
        ' 
        ' pnlFontMin
        ' 
        pnlFontMin.Controls.Add(nudSizeMin)
        pnlFontMin.Controls.Add(cmbFontMin)
        pnlFontMin.Dock = DockStyle.Fill
        pnlFontMin.Location = New Point(3, 385)
        pnlFontMin.Name = "pnlFontMin"
        pnlFontMin.Size = New Size(773, 38)
        pnlFontMin.TabIndex = 1
        ' 
        ' nudSizeMin
        ' 
        nudSizeMin.Location = New Point(314, 6)
        nudSizeMin.Name = "nudSizeMin"
        nudSizeMin.Size = New Size(120, 23)
        nudSizeMin.TabIndex = 1
        ' 
        ' cmbFontMin
        ' 
        cmbFontMin.FormattingEnabled = True
        cmbFontMin.Location = New Point(70, 6)
        cmbFontMin.Name = "cmbFontMin"
        cmbFontMin.Size = New Size(193, 23)
        cmbFontMin.TabIndex = 0
        ' 
        ' pnlFontTitle
        ' 
        pnlFontTitle.Controls.Add(nudSizeTitle)
        pnlFontTitle.Controls.Add(cmbFontTitle)
        pnlFontTitle.Dock = DockStyle.Fill
        pnlFontTitle.Location = New Point(3, 45)
        pnlFontTitle.Name = "pnlFontTitle"
        pnlFontTitle.Size = New Size(773, 79)
        pnlFontTitle.TabIndex = 2
        ' 
        ' nudSizeTitle
        ' 
        nudSizeTitle.Location = New Point(314, 32)
        nudSizeTitle.Name = "nudSizeTitle"
        nudSizeTitle.Size = New Size(120, 23)
        nudSizeTitle.TabIndex = 3
        ' 
        ' cmbFontTitle
        ' 
        cmbFontTitle.FormattingEnabled = True
        cmbFontTitle.Location = New Point(70, 32)
        cmbFontTitle.Name = "cmbFontTitle"
        cmbFontTitle.Size = New Size(193, 23)
        cmbFontTitle.TabIndex = 2
        ' 
        ' FormControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormControl"
        Text = "FormControl"
        CType(nudTime1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTime2, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTime3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        pnl1.ResumeLayout(False)
        pnl1.PerformLayout()
        pnl2.ResumeLayout(False)
        pnl2.PerformLayout()
        pnl3.ResumeLayout(False)
        pnl3.PerformLayout()
        pnlFontMin.ResumeLayout(False)
        CType(nudSizeMin, ComponentModel.ISupportInitialize).EndInit()
        pnlFontTitle.ResumeLayout(False)
        CType(nudSizeTitle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtTitleTime1 As TextBox
    Friend WithEvents nudTime1 As NumericUpDown
    Friend WithEvents lblTime1 As Label
    Friend WithEvents nudTime2 As NumericUpDown
    Friend WithEvents txtTitleTime2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudTime3 As NumericUpDown
    Friend WithEvents txtTitleTime3 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents pnl2 As Panel
    Friend WithEvents pnl3 As Panel
    Friend WithEvents pnlFontMin As Panel
    Friend WithEvents cmbFontMin As ComboBox
    Friend WithEvents nudSizeMin As NumericUpDown
    Friend WithEvents pnlFontTitle As Panel
    Friend WithEvents nudSizeTitle As NumericUpDown
    Friend WithEvents cmbFontTitle As ComboBox
End Class
