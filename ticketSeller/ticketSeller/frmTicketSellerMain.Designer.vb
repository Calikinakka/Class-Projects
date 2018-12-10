<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketSellerMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetupNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSellTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewGameMain = New System.Windows.Forms.Button()
        Me.btnSellTicketsMain = New System.Windows.Forms.Button()
        Me.btnDailyReportMain = New System.Windows.Forms.Button()
        Me.lblTicketSellerMain = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetupNewGame, Me.mnuSellTickets, Me.mnuReports})
        Me.mnuMenu.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(55, 20)
        Me.mnuMenu.Text = "&Menu"
        '
        'mnuSetupNewGame
        '
        Me.mnuSetupNewGame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSetupNewGame.Name = "mnuSetupNewGame"
        Me.mnuSetupNewGame.Size = New System.Drawing.Size(189, 22)
        Me.mnuSetupNewGame.Text = "Setup &New Game"
        '
        'mnuSellTickets
        '
        Me.mnuSellTickets.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSellTickets.Name = "mnuSellTickets"
        Me.mnuSellTickets.Size = New System.Drawing.Size(189, 22)
        Me.mnuSellTickets.Text = "&Sell Tickets"
        '
        'mnuReports
        '
        Me.mnuReports.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(189, 22)
        Me.mnuReports.Text = "&Reports"
        '
        'btnNewGameMain
        '
        Me.btnNewGameMain.BackColor = System.Drawing.Color.Orange
        Me.btnNewGameMain.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGameMain.ForeColor = System.Drawing.Color.Blue
        Me.btnNewGameMain.Location = New System.Drawing.Point(47, 281)
        Me.btnNewGameMain.Name = "btnNewGameMain"
        Me.btnNewGameMain.Size = New System.Drawing.Size(149, 141)
        Me.btnNewGameMain.TabIndex = 1
        Me.btnNewGameMain.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Game"
        Me.btnNewGameMain.UseVisualStyleBackColor = False
        '
        'btnSellTicketsMain
        '
        Me.btnSellTicketsMain.BackColor = System.Drawing.Color.Orange
        Me.btnSellTicketsMain.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellTicketsMain.ForeColor = System.Drawing.Color.Blue
        Me.btnSellTicketsMain.Location = New System.Drawing.Point(230, 281)
        Me.btnSellTicketsMain.Name = "btnSellTicketsMain"
        Me.btnSellTicketsMain.Size = New System.Drawing.Size(149, 141)
        Me.btnSellTicketsMain.TabIndex = 2
        Me.btnSellTicketsMain.Text = "Sell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tickets"
        Me.btnSellTicketsMain.UseVisualStyleBackColor = False
        '
        'btnDailyReportMain
        '
        Me.btnDailyReportMain.BackColor = System.Drawing.Color.Orange
        Me.btnDailyReportMain.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReportMain.ForeColor = System.Drawing.Color.Blue
        Me.btnDailyReportMain.Location = New System.Drawing.Point(413, 281)
        Me.btnDailyReportMain.Name = "btnDailyReportMain"
        Me.btnDailyReportMain.Size = New System.Drawing.Size(149, 141)
        Me.btnDailyReportMain.TabIndex = 3
        Me.btnDailyReportMain.Text = "Reports"
        Me.btnDailyReportMain.UseVisualStyleBackColor = False
        '
        'lblTicketSellerMain
        '
        Me.lblTicketSellerMain.AutoSize = True
        Me.lblTicketSellerMain.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketSellerMain.Location = New System.Drawing.Point(210, 51)
        Me.lblTicketSellerMain.Name = "lblTicketSellerMain"
        Me.lblTicketSellerMain.Size = New System.Drawing.Size(191, 38)
        Me.lblTicketSellerMain.TabIndex = 4
        Me.lblTicketSellerMain.Text = "Ticket Seller"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Blue
        Me.btnExit.Location = New System.Drawing.Point(242, 462)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmTicketSellerMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 516)
        Me.Controls.Add(Me.lblTicketSellerMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDailyReportMain)
        Me.Controls.Add(Me.btnSellTicketsMain)
        Me.Controls.Add(Me.btnNewGameMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTicketSellerMain"
        Me.Text = "Ticket Seller Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuSetupNewGame As ToolStripMenuItem
    Friend WithEvents mnuSellTickets As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents btnNewGameMain As Button
    Friend WithEvents btnSellTicketsMain As Button
    Friend WithEvents btnDailyReportMain As Button
    Friend WithEvents lblTicketSellerMain As Label
    Friend WithEvents btnExit As Button
End Class
