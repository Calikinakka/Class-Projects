<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFranchiseInvestment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picFranchise = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFranchise = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblAverageInvestment = New System.Windows.Forms.Label()
        Me.lblAverageCost = New System.Windows.Forms.Label()
        CType(Me.picFranchise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picFranchise
        '
        Me.picFranchise.Image = Global.Franchise.My.Resources.Resources.Franchise
        Me.picFranchise.Location = New System.Drawing.Point(80, 98)
        Me.picFranchise.Name = "picFranchise"
        Me.picFranchise.Size = New System.Drawing.Size(176, 147)
        Me.picFranchise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFranchise.TabIndex = 0
        Me.picFranchise.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(332, 22)
        Me.mnuDisplay.Text = "Display Restaurant Names and Investment Values"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(332, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(332, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lstFranchise
        '
        Me.lstFranchise.FormattingEnabled = True
        Me.lstFranchise.Location = New System.Drawing.Point(294, 98)
        Me.lstFranchise.Name = "lstFranchise"
        Me.lstFranchise.Size = New System.Drawing.Size(176, 147)
        Me.lstFranchise.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(73, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(405, 38)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Click to Select Investment"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(291, 79)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(115, 16)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Franchise: "
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.Location = New System.Drawing.Point(41, 264)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(446, 18)
        Me.lblSelected.TabIndex = 5
        Me.lblSelected.Text = "The Selected Restaurant's Investment Cost of $888.888"
        Me.lblSelected.Visible = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DimGray
        Me.btnCompute.ForeColor = System.Drawing.Color.LightGray
        Me.btnCompute.Location = New System.Drawing.Point(170, 305)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(210, 36)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Average Investment"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'lblAverageInvestment
        '
        Me.lblAverageInvestment.AutoSize = True
        Me.lblAverageInvestment.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInvestment.Location = New System.Drawing.Point(75, 356)
        Me.lblAverageInvestment.Name = "lblAverageInvestment"
        Me.lblAverageInvestment.Size = New System.Drawing.Size(273, 25)
        Me.lblAverageInvestment.TabIndex = 7
        Me.lblAverageInvestment.Text = "Average Investment Cost: "
        Me.lblAverageInvestment.Visible = False
        '
        'lblAverageCost
        '
        Me.lblAverageCost.AutoSize = True
        Me.lblAverageCost.Font = New System.Drawing.Font("Century", 15.75!)
        Me.lblAverageCost.Location = New System.Drawing.Point(354, 356)
        Me.lblAverageCost.Name = "lblAverageCost"
        Me.lblAverageCost.Size = New System.Drawing.Size(114, 25)
        Me.lblAverageCost.TabIndex = 8
        Me.lblAverageCost.Text = "$88888.88"
        Me.lblAverageCost.Visible = False
        '
        'frmFranchiseInvestment
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 400)
        Me.Controls.Add(Me.lblAverageCost)
        Me.Controls.Add(Me.lblAverageInvestment)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstFranchise)
        Me.Controls.Add(Me.picFranchise)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFranchiseInvestment"
        Me.Text = "Franchise Investment"
        CType(Me.picFranchise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFranchise As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lstFranchise As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblSelected As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblAverageInvestment As Label
    Friend WithEvents lblAverageCost As Label
End Class
