<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDailyReport = New System.Windows.Forms.Button()
        Me.btnSellTickets = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturnToMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSellTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateGame = New System.Windows.Forms.Button()
        Me.lblNewGameTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.grpGameType = New System.Windows.Forms.GroupBox()
        Me.radAway = New System.Windows.Forms.RadioButton()
        Me.radHome = New System.Windows.Forms.RadioButton()
        Me.lblGameType = New System.Windows.Forms.Label()
        Me.txtSetTicketCost = New System.Windows.Forms.TextBox()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.cldGames = New System.Windows.Forms.MonthCalendar()
        Me.MenuStrip1.SuspendLayout()
        Me.grpGameType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDailyReport
        '
        Me.btnDailyReport.BackColor = System.Drawing.Color.Orange
        Me.btnDailyReport.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReport.ForeColor = System.Drawing.Color.Blue
        Me.btnDailyReport.Location = New System.Drawing.Point(417, 436)
        Me.btnDailyReport.Name = "btnDailyReport"
        Me.btnDailyReport.Size = New System.Drawing.Size(150, 68)
        Me.btnDailyReport.TabIndex = 5
        Me.btnDailyReport.Text = "Reports"
        Me.btnDailyReport.UseVisualStyleBackColor = False
        '
        'btnSellTickets
        '
        Me.btnSellTickets.BackColor = System.Drawing.Color.Orange
        Me.btnSellTickets.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellTickets.ForeColor = System.Drawing.Color.Blue
        Me.btnSellTickets.Location = New System.Drawing.Point(229, 436)
        Me.btnSellTickets.Name = "btnSellTickets"
        Me.btnSellTickets.Size = New System.Drawing.Size(150, 68)
        Me.btnSellTickets.TabIndex = 4
        Me.btnSellTickets.Text = "Sell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tickets"
        Me.btnSellTickets.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Orange
        Me.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMainMenu.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Blue
        Me.btnMainMenu.Location = New System.Drawing.Point(41, 436)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(150, 68)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "Main" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReturnToMain, Me.mnuSellTickets, Me.mnuReports})
        Me.mnuMenu.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(53, 20)
        Me.mnuMenu.Text = "&Menu"
        '
        'mnuReturnToMain
        '
        Me.mnuReturnToMain.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuReturnToMain.Name = "mnuReturnToMain"
        Me.mnuReturnToMain.Size = New System.Drawing.Size(167, 22)
        Me.mnuReturnToMain.Text = "&Return To Main"
        '
        'mnuSellTickets
        '
        Me.mnuSellTickets.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuSellTickets.Name = "mnuSellTickets"
        Me.mnuSellTickets.Size = New System.Drawing.Size(167, 22)
        Me.mnuSellTickets.Text = "&Sell Tickets"
        '
        'mnuReports
        '
        Me.mnuReports.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(167, 22)
        Me.mnuReports.Text = "&Reports"
        '
        'btnCreateGame
        '
        Me.btnCreateGame.BackColor = System.Drawing.Color.Orange
        Me.btnCreateGame.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateGame.ForeColor = System.Drawing.Color.Blue
        Me.btnCreateGame.Location = New System.Drawing.Point(229, 361)
        Me.btnCreateGame.Name = "btnCreateGame"
        Me.btnCreateGame.Size = New System.Drawing.Size(150, 69)
        Me.btnCreateGame.TabIndex = 5
        Me.btnCreateGame.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Game"
        Me.btnCreateGame.UseVisualStyleBackColor = False
        '
        'lblNewGameTitle
        '
        Me.lblNewGameTitle.AutoSize = True
        Me.lblNewGameTitle.Font = New System.Drawing.Font("Georgia", 20.0!)
        Me.lblNewGameTitle.Location = New System.Drawing.Point(184, 38)
        Me.lblNewGameTitle.Name = "lblNewGameTitle"
        Me.lblNewGameTitle.Size = New System.Drawing.Size(240, 31)
        Me.lblNewGameTitle.TabIndex = 9
        Me.lblNewGameTitle.Text = "Create a new game"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(336, 108)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(120, 23)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Select a Date"
        '
        'grpGameType
        '
        Me.grpGameType.Controls.Add(Me.radAway)
        Me.grpGameType.Controls.Add(Me.radHome)
        Me.grpGameType.Location = New System.Drawing.Point(41, 138)
        Me.grpGameType.Name = "grpGameType"
        Me.grpGameType.Size = New System.Drawing.Size(207, 49)
        Me.grpGameType.TabIndex = 11
        Me.grpGameType.TabStop = False
        '
        'radAway
        '
        Me.radAway.AutoSize = True
        Me.radAway.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAway.Location = New System.Drawing.Point(114, 14)
        Me.radAway.Name = "radAway"
        Me.radAway.Size = New System.Drawing.Size(80, 29)
        Me.radAway.TabIndex = 1
        Me.radAway.TabStop = True
        Me.radAway.Text = "Away"
        Me.radAway.UseVisualStyleBackColor = True
        '
        'radHome
        '
        Me.radHome.AutoSize = True
        Me.radHome.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHome.Location = New System.Drawing.Point(6, 14)
        Me.radHome.Name = "radHome"
        Me.radHome.Size = New System.Drawing.Size(87, 29)
        Me.radHome.TabIndex = 0
        Me.radHome.TabStop = True
        Me.radHome.Text = "Home"
        Me.radHome.UseVisualStyleBackColor = True
        '
        'lblGameType
        '
        Me.lblGameType.AutoSize = True
        Me.lblGameType.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameType.Location = New System.Drawing.Point(37, 108)
        Me.lblGameType.Name = "lblGameType"
        Me.lblGameType.Size = New System.Drawing.Size(106, 23)
        Me.lblGameType.TabIndex = 12
        Me.lblGameType.Text = "Game Type"
        '
        'txtSetTicketCost
        '
        Me.txtSetTicketCost.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetTicketCost.Location = New System.Drawing.Point(41, 280)
        Me.txtSetTicketCost.Name = "txtSetTicketCost"
        Me.txtSetTicketCost.Size = New System.Drawing.Size(62, 26)
        Me.txtSetTicketCost.TabIndex = 3
        Me.txtSetTicketCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.Location = New System.Drawing.Point(37, 250)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(198, 23)
        Me.lblTicket.TabIndex = 14
        Me.lblTicket.Text = "Enter Price Per Ticket"
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Font = New System.Drawing.Font("Georgia", 14.25!)
        Me.lblSeats.Location = New System.Drawing.Point(37, 207)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(66, 23)
        Me.lblSeats.TabIndex = 15
        Me.lblSeats.Text = "Seats: "
        '
        'txtSeats
        '
        Me.txtSeats.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.txtSeats.Location = New System.Drawing.Point(102, 208)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(41, 26)
        Me.txtSeats.TabIndex = 2
        Me.txtSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cldGames
        '
        Me.cldGames.Location = New System.Drawing.Point(340, 144)
        Me.cldGames.Name = "cldGames"
        Me.cldGames.TabIndex = 4
        '
        'frmNewGame
        '
        Me.AcceptButton = Me.btnCreateGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 516)
        Me.Controls.Add(Me.cldGames)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.txtSetTicketCost)
        Me.Controls.Add(Me.lblGameType)
        Me.Controls.Add(Me.grpGameType)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblNewGameTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDailyReport)
        Me.Controls.Add(Me.btnCreateGame)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnSellTickets)
        Me.Name = "frmNewGame"
        Me.Text = "Create New Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpGameType.ResumeLayout(False)
        Me.grpGameType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDailyReport As Button
    Friend WithEvents btnSellTickets As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuReturnToMain As ToolStripMenuItem
    Friend WithEvents mnuSellTickets As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents btnCreateGame As Button
    Friend WithEvents lblNewGameTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents grpGameType As GroupBox
    Friend WithEvents radAway As RadioButton
    Friend WithEvents radHome As RadioButton
    Friend WithEvents lblGameType As Label
    Friend WithEvents txtSetTicketCost As TextBox
    Friend WithEvents lblTicket As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents cldGames As MonthCalendar
End Class
