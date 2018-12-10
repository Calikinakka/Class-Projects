<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSellTickets
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
        Me.btnDailyReportSell = New System.Windows.Forms.Button()
        Me.btnSellTickets = New System.Windows.Forms.Button()
        Me.btnMainMenuSell = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturnToMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWeekly = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateGameSell = New System.Windows.Forms.Button()
        Me.lstGameDates = New System.Windows.Forms.ListBox()
        Me.lblSellTicketsTitle = New System.Windows.Forms.Label()
        Me.lblSelectGameDate = New System.Windows.Forms.Label()
        Me.txtNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.lblTicketsNeeded = New System.Windows.Forms.Label()
        Me.lblGameTicketCost = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.lblDiscountIs = New System.Windows.Forms.Label()
        Me.lblAvailableSeats = New System.Windows.Forms.Label()
        Me.lblTodaysSalesSell = New System.Windows.Forms.Label()
        Me.lblTicketsSoldToday = New System.Windows.Forms.Label()
        Me.lblDiscountedTicketsToday = New System.Windows.Forms.Label()
        Me.lblTotalSaleAmountToday = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDailyReportSell
        '
        Me.btnDailyReportSell.BackColor = System.Drawing.Color.Orange
        Me.btnDailyReportSell.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReportSell.ForeColor = System.Drawing.Color.Blue
        Me.btnDailyReportSell.Location = New System.Drawing.Point(417, 434)
        Me.btnDailyReportSell.Name = "btnDailyReportSell"
        Me.btnDailyReportSell.Size = New System.Drawing.Size(150, 68)
        Me.btnDailyReportSell.TabIndex = 10
        Me.btnDailyReportSell.Text = "Reports"
        Me.btnDailyReportSell.UseVisualStyleBackColor = False
        '
        'btnSellTickets
        '
        Me.btnSellTickets.BackColor = System.Drawing.Color.Orange
        Me.btnSellTickets.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellTickets.ForeColor = System.Drawing.Color.Blue
        Me.btnSellTickets.Location = New System.Drawing.Point(229, 359)
        Me.btnSellTickets.Name = "btnSellTickets"
        Me.btnSellTickets.Size = New System.Drawing.Size(150, 68)
        Me.btnSellTickets.TabIndex = 7
        Me.btnSellTickets.Text = "Sell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tickets"
        Me.btnSellTickets.UseVisualStyleBackColor = False
        '
        'btnMainMenuSell
        '
        Me.btnMainMenuSell.BackColor = System.Drawing.Color.Orange
        Me.btnMainMenuSell.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMainMenuSell.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenuSell.ForeColor = System.Drawing.Color.Blue
        Me.btnMainMenuSell.Location = New System.Drawing.Point(41, 434)
        Me.btnMainMenuSell.Name = "btnMainMenuSell"
        Me.btnMainMenuSell.Size = New System.Drawing.Size(150, 68)
        Me.btnMainMenuSell.TabIndex = 8
        Me.btnMainMenuSell.Text = "Main" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menu"
        Me.btnMainMenuSell.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReturnToMain, Me.mnuCreateGame, Me.mnuReports})
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
        'mnuCreateGame
        '
        Me.mnuCreateGame.Name = "mnuCreateGame"
        Me.mnuCreateGame.Size = New System.Drawing.Size(167, 22)
        Me.mnuCreateGame.Text = "&Create Game"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDaily, Me.mnuWeekly})
        Me.mnuReports.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(167, 22)
        Me.mnuReports.Text = "&Reports"
        '
        'mnuDaily
        '
        Me.mnuDaily.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuDaily.Name = "mnuDaily"
        Me.mnuDaily.Size = New System.Drawing.Size(119, 22)
        Me.mnuDaily.Text = "Daily"
        '
        'mnuWeekly
        '
        Me.mnuWeekly.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.mnuWeekly.Name = "mnuWeekly"
        Me.mnuWeekly.Size = New System.Drawing.Size(119, 22)
        Me.mnuWeekly.Text = "Weekly"
        '
        'btnCreateGameSell
        '
        Me.btnCreateGameSell.BackColor = System.Drawing.Color.Orange
        Me.btnCreateGameSell.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateGameSell.ForeColor = System.Drawing.Color.Blue
        Me.btnCreateGameSell.Location = New System.Drawing.Point(229, 433)
        Me.btnCreateGameSell.Name = "btnCreateGameSell"
        Me.btnCreateGameSell.Size = New System.Drawing.Size(150, 68)
        Me.btnCreateGameSell.TabIndex = 12
        Me.btnCreateGameSell.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Game"
        Me.btnCreateGameSell.UseVisualStyleBackColor = False
        '
        'lstGameDates
        '
        Me.lstGameDates.FormattingEnabled = True
        Me.lstGameDates.Location = New System.Drawing.Point(28, 128)
        Me.lstGameDates.Name = "lstGameDates"
        Me.lstGameDates.Size = New System.Drawing.Size(160, 173)
        Me.lstGameDates.TabIndex = 13
        '
        'lblSellTicketsTitle
        '
        Me.lblSellTicketsTitle.AutoSize = True
        Me.lblSellTicketsTitle.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellTicketsTitle.Location = New System.Drawing.Point(216, 33)
        Me.lblSellTicketsTitle.Name = "lblSellTicketsTitle"
        Me.lblSellTicketsTitle.Size = New System.Drawing.Size(177, 38)
        Me.lblSellTicketsTitle.TabIndex = 14
        Me.lblSellTicketsTitle.Text = "Sell Tickets"
        '
        'lblSelectGameDate
        '
        Me.lblSelectGameDate.AutoSize = True
        Me.lblSelectGameDate.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGameDate.Location = New System.Drawing.Point(28, 98)
        Me.lblSelectGameDate.Name = "lblSelectGameDate"
        Me.lblSelectGameDate.Size = New System.Drawing.Size(130, 23)
        Me.lblSelectGameDate.TabIndex = 15
        Me.lblSelectGameDate.Text = "Select a Game"
        '
        'txtNumberOfTickets
        '
        Me.txtNumberOfTickets.Location = New System.Drawing.Point(217, 128)
        Me.txtNumberOfTickets.Name = "txtNumberOfTickets"
        Me.txtNumberOfTickets.Size = New System.Drawing.Size(41, 20)
        Me.txtNumberOfTickets.TabIndex = 16
        Me.txtNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTicketsNeeded
        '
        Me.lblTicketsNeeded.AutoSize = True
        Me.lblTicketsNeeded.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsNeeded.Location = New System.Drawing.Point(213, 98)
        Me.lblTicketsNeeded.Name = "lblTicketsNeeded"
        Me.lblTicketsNeeded.Size = New System.Drawing.Size(185, 23)
        Me.lblTicketsNeeded.TabIndex = 17
        Me.lblTicketsNeeded.Text = "Enter Tickets To Sell"
        '
        'lblGameTicketCost
        '
        Me.lblGameTicketCost.AutoSize = True
        Me.lblGameTicketCost.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.lblGameTicketCost.Location = New System.Drawing.Point(25, 314)
        Me.lblGameTicketCost.Name = "lblGameTicketCost"
        Me.lblGameTicketCost.Size = New System.Drawing.Size(114, 17)
        Me.lblGameTicketCost.TabIndex = 18
        Me.lblGameTicketCost.Text = "Price Per Ticket:"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.Location = New System.Drawing.Point(214, 198)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(102, 18)
        Me.lblAmountDue.TabIndex = 19
        Me.lblAmountDue.Text = "Amount Due:"
        '
        'lblDiscountIs
        '
        Me.lblDiscountIs.AutoSize = True
        Me.lblDiscountIs.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountIs.Location = New System.Drawing.Point(214, 165)
        Me.lblDiscountIs.Name = "lblDiscountIs"
        Me.lblDiscountIs.Size = New System.Drawing.Size(89, 18)
        Me.lblDiscountIs.TabIndex = 20
        Me.lblDiscountIs.Text = "Discount is:"
        Me.lblDiscountIs.Visible = False
        '
        'lblAvailableSeats
        '
        Me.lblAvailableSeats.AutoSize = True
        Me.lblAvailableSeats.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableSeats.Location = New System.Drawing.Point(222, 314)
        Me.lblAvailableSeats.Name = "lblAvailableSeats"
        Me.lblAvailableSeats.Size = New System.Drawing.Size(164, 25)
        Me.lblAvailableSeats.TabIndex = 21
        Me.lblAvailableSeats.Text = "Available Seats: "
        '
        'lblTodaysSalesSell
        '
        Me.lblTodaysSalesSell.AutoSize = True
        Me.lblTodaysSalesSell.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaysSalesSell.Location = New System.Drawing.Point(424, 98)
        Me.lblTodaysSalesSell.Name = "lblTodaysSalesSell"
        Me.lblTodaysSalesSell.Size = New System.Drawing.Size(122, 23)
        Me.lblTodaysSalesSell.TabIndex = 22
        Me.lblTodaysSalesSell.Text = "Today's Sales"
        '
        'lblTicketsSoldToday
        '
        Me.lblTicketsSoldToday.AutoSize = True
        Me.lblTicketsSoldToday.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsSoldToday.Location = New System.Drawing.Point(425, 132)
        Me.lblTicketsSoldToday.Name = "lblTicketsSoldToday"
        Me.lblTicketsSoldToday.Size = New System.Drawing.Size(59, 16)
        Me.lblTicketsSoldToday.TabIndex = 23
        Me.lblTicketsSoldToday.Text = "Tickets: "
        '
        'lblDiscountedTicketsToday
        '
        Me.lblDiscountedTicketsToday.AutoSize = True
        Me.lblDiscountedTicketsToday.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountedTicketsToday.Location = New System.Drawing.Point(425, 165)
        Me.lblDiscountedTicketsToday.Name = "lblDiscountedTicketsToday"
        Me.lblDiscountedTicketsToday.Size = New System.Drawing.Size(129, 16)
        Me.lblDiscountedTicketsToday.TabIndex = 23
        Me.lblDiscountedTicketsToday.Text = "Discounted tickets: "
        '
        'lblTotalSaleAmountToday
        '
        Me.lblTotalSaleAmountToday.AutoSize = True
        Me.lblTotalSaleAmountToday.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSaleAmountToday.Location = New System.Drawing.Point(425, 198)
        Me.lblTotalSaleAmountToday.Name = "lblTotalSaleAmountToday"
        Me.lblTotalSaleAmountToday.Size = New System.Drawing.Size(50, 18)
        Me.lblTotalSaleAmountToday.TabIndex = 24
        Me.lblTotalSaleAmountToday.Text = "Total:"
        '
        'frmSellTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 516)
        Me.Controls.Add(Me.lblTotalSaleAmountToday)
        Me.Controls.Add(Me.lblDiscountedTicketsToday)
        Me.Controls.Add(Me.lblTicketsSoldToday)
        Me.Controls.Add(Me.lblTodaysSalesSell)
        Me.Controls.Add(Me.lblAvailableSeats)
        Me.Controls.Add(Me.lblDiscountIs)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.lblGameTicketCost)
        Me.Controls.Add(Me.lblTicketsNeeded)
        Me.Controls.Add(Me.txtNumberOfTickets)
        Me.Controls.Add(Me.lblSelectGameDate)
        Me.Controls.Add(Me.lblSellTicketsTitle)
        Me.Controls.Add(Me.lstGameDates)
        Me.Controls.Add(Me.btnCreateGameSell)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDailyReportSell)
        Me.Controls.Add(Me.btnSellTickets)
        Me.Controls.Add(Me.btnMainMenuSell)
        Me.Name = "frmSellTickets"
        Me.Text = "Sell Tickets"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDailyReportSell As Button
    Friend WithEvents btnSellTickets As Button
    Friend WithEvents btnMainMenuSell As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuReturnToMain As ToolStripMenuItem
    Friend WithEvents mnuCreateGame As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents mnuDaily As ToolStripMenuItem
    Friend WithEvents mnuWeekly As ToolStripMenuItem
    Friend WithEvents btnCreateGameSell As Button
    Friend WithEvents lstGameDates As ListBox
    Friend WithEvents lblSellTicketsTitle As Label
    Friend WithEvents lblSelectGameDate As Label
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents lblTicketsNeeded As Label
    Friend WithEvents lblGameTicketCost As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblDiscountIs As Label
    Friend WithEvents lblAvailableSeats As Label
    Friend WithEvents lblTodaysSalesSell As Label
    Friend WithEvents lblTicketsSoldToday As Label
    Friend WithEvents lblDiscountedTicketsToday As Label
    Friend WithEvents lblTotalSaleAmountToday As Label
End Class
