<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.btnWeeklyReport = New System.Windows.Forms.Button()
        Me.btnMainMenuReports = New System.Windows.Forms.Button()
        Me.btnDailyReports = New System.Windows.Forms.Button()
        Me.lblReportsDailySales = New System.Windows.Forms.Label()
        Me.lblReportsTicketsSold = New System.Windows.Forms.Label()
        Me.lblReportsDiscountedTickets = New System.Windows.Forms.Label()
        Me.lblReportTotalTicketSales = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeeklyReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportsDailyReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWeeklyReport
        '
        Me.btnWeeklyReport.BackColor = System.Drawing.Color.Orange
        Me.btnWeeklyReport.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeeklyReport.ForeColor = System.Drawing.Color.Blue
        Me.btnWeeklyReport.Location = New System.Drawing.Point(229, 422)
        Me.btnWeeklyReport.Name = "btnWeeklyReport"
        Me.btnWeeklyReport.Size = New System.Drawing.Size(150, 68)
        Me.btnWeeklyReport.TabIndex = 12
        Me.btnWeeklyReport.Text = "Weekly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reports"
        Me.btnWeeklyReport.UseVisualStyleBackColor = False
        '
        'btnMainMenuReports
        '
        Me.btnMainMenuReports.BackColor = System.Drawing.Color.Orange
        Me.btnMainMenuReports.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMainMenuReports.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenuReports.ForeColor = System.Drawing.Color.Blue
        Me.btnMainMenuReports.Location = New System.Drawing.Point(52, 422)
        Me.btnMainMenuReports.Name = "btnMainMenuReports"
        Me.btnMainMenuReports.Size = New System.Drawing.Size(150, 68)
        Me.btnMainMenuReports.TabIndex = 11
        Me.btnMainMenuReports.Text = "Main" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Menu"
        Me.btnMainMenuReports.UseVisualStyleBackColor = False
        '
        'btnDailyReports
        '
        Me.btnDailyReports.BackColor = System.Drawing.Color.Orange
        Me.btnDailyReports.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailyReports.ForeColor = System.Drawing.Color.Blue
        Me.btnDailyReports.Location = New System.Drawing.Point(406, 422)
        Me.btnDailyReports.Name = "btnDailyReports"
        Me.btnDailyReports.Size = New System.Drawing.Size(150, 68)
        Me.btnDailyReports.TabIndex = 12
        Me.btnDailyReports.Text = "Daily" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reports"
        Me.btnDailyReports.UseVisualStyleBackColor = False
        Me.btnDailyReports.Visible = False
        '
        'lblReportsDailySales
        '
        Me.lblReportsDailySales.AutoSize = True
        Me.lblReportsDailySales.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportsDailySales.Location = New System.Drawing.Point(208, 36)
        Me.lblReportsDailySales.Name = "lblReportsDailySales"
        Me.lblReportsDailySales.Size = New System.Drawing.Size(171, 38)
        Me.lblReportsDailySales.TabIndex = 13
        Me.lblReportsDailySales.Text = "Daily Sales"
        '
        'lblReportsTicketsSold
        '
        Me.lblReportsTicketsSold.AutoSize = True
        Me.lblReportsTicketsSold.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportsTicketsSold.Location = New System.Drawing.Point(46, 119)
        Me.lblReportsTicketsSold.Name = "lblReportsTicketsSold"
        Me.lblReportsTicketsSold.Size = New System.Drawing.Size(175, 31)
        Me.lblReportsTicketsSold.TabIndex = 14
        Me.lblReportsTicketsSold.Text = "Tickets Sold: "
        '
        'lblReportsDiscountedTickets
        '
        Me.lblReportsDiscountedTickets.AutoSize = True
        Me.lblReportsDiscountedTickets.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportsDiscountedTickets.Location = New System.Drawing.Point(46, 170)
        Me.lblReportsDiscountedTickets.Name = "lblReportsDiscountedTickets"
        Me.lblReportsDiscountedTickets.Size = New System.Drawing.Size(258, 31)
        Me.lblReportsDiscountedTickets.TabIndex = 14
        Me.lblReportsDiscountedTickets.Text = "Discounted Tickets: "
        '
        'lblReportTotalTicketSales
        '
        Me.lblReportTotalTicketSales.AutoSize = True
        Me.lblReportTotalTicketSales.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTotalTicketSales.Location = New System.Drawing.Point(46, 259)
        Me.lblReportTotalTicketSales.Name = "lblReportTotalTicketSales"
        Me.lblReportTotalTicketSales.Size = New System.Drawing.Size(234, 31)
        Me.lblReportTotalTicketSales.TabIndex = 14
        Me.lblReportTotalTicketSales.Text = "Total Ticket Sales:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainScreenToolStripMenuItem, Me.WeeklyReportsToolStripMenuItem, Me.mnuReportsDailyReports})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'MainScreenToolStripMenuItem
        '
        Me.MainScreenToolStripMenuItem.Name = "MainScreenToolStripMenuItem"
        Me.MainScreenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MainScreenToolStripMenuItem.Text = "M&ain Screen"
        '
        'WeeklyReportsToolStripMenuItem
        '
        Me.WeeklyReportsToolStripMenuItem.Name = "WeeklyReportsToolStripMenuItem"
        Me.WeeklyReportsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.WeeklyReportsToolStripMenuItem.Text = "&Weekly Reports"
        '
        'mnuReportsDailyReports
        '
        Me.mnuReportsDailyReports.Name = "mnuReportsDailyReports"
        Me.mnuReportsDailyReports.Size = New System.Drawing.Size(155, 22)
        Me.mnuReportsDailyReports.Text = "&Daily Reports"
        Me.mnuReportsDailyReports.Visible = False
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 516)
        Me.Controls.Add(Me.lblReportsDiscountedTickets)
        Me.Controls.Add(Me.lblReportTotalTicketSales)
        Me.Controls.Add(Me.lblReportsTicketsSold)
        Me.Controls.Add(Me.lblReportsDailySales)
        Me.Controls.Add(Me.btnDailyReports)
        Me.Controls.Add(Me.btnWeeklyReport)
        Me.Controls.Add(Me.btnMainMenuReports)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReports"
        Me.Text = "Ticket Sales Reports"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWeeklyReport As Button
    Friend WithEvents btnMainMenuReports As Button
    Friend WithEvents btnDailyReports As Button
    Friend WithEvents lblReportsDailySales As Label
    Friend WithEvents lblReportsTicketsSold As Label
    Friend WithEvents lblReportsDiscountedTickets As Label
    Friend WithEvents lblReportTotalTicketSales As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeeklyReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuReportsDailyReports As ToolStripMenuItem
End Class
