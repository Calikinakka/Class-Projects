<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTours
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboTour = New System.Windows.Forms.ComboBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.btnCalculateCost = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblSubTotalAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblFinalTotalAmount = New System.Windows.Forms.Label()
        Me.radWeekend = New System.Windows.Forms.RadioButton()
        Me.radWeekday = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(311, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(381, 74)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "GUIDED TOUR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THROUGH THE ALAMO"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTour
        '
        Me.cboTour.FormattingEnabled = True
        Me.cboTour.Items.AddRange(New Object() {"Alamo Story", "Alamo Story with Battleground Tour", "Mission Trail Deluxe Tour"})
        Me.cboTour.Location = New System.Drawing.Point(369, 111)
        Me.cboTour.Name = "cboTour"
        Me.cboTour.Size = New System.Drawing.Size(257, 21)
        Me.cboTour.TabIndex = 1
        Me.cboTour.Text = "Select Tour"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.BackColor = System.Drawing.Color.Transparent
        Me.lblTickets.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(329, 165)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(234, 25)
        Me.lblTickets.TabIndex = 2
        Me.lblTickets.Text = "Enter Number of Tickets:"
        Me.lblTickets.Visible = False
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(581, 157)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(37, 33)
        Me.txtTickets.TabIndex = 3
        Me.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTickets.Visible = False
        '
        'btnCalculateCost
        '
        Me.btnCalculateCost.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculateCost.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateCost.Location = New System.Drawing.Point(523, 227)
        Me.btnCalculateCost.Name = "btnCalculateCost"
        Me.btnCalculateCost.Size = New System.Drawing.Size(155, 68)
        Me.btnCalculateCost.TabIndex = 5
        Me.btnCalculateCost.Text = "Calculate Cost"
        Me.btnCalculateCost.UseVisualStyleBackColor = False
        Me.btnCalculateCost.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(334, 316)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(103, 25)
        Me.lblSubTotal.TabIndex = 6
        Me.lblSubTotal.Text = "Sub Total:"
        Me.lblSubTotal.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(334, 341)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(51, 25)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "Tax:"
        Me.lblTax.Visible = False
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFinal.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(334, 366)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(114, 25)
        Me.lblFinal.TabIndex = 8
        Me.lblFinal.Text = "Final Total:"
        Me.lblFinal.Visible = False
        '
        'lblSubTotalAmount
        '
        Me.lblSubTotalAmount.AutoSize = True
        Me.lblSubTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotalAmount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalAmount.Location = New System.Drawing.Point(538, 316)
        Me.lblSubTotalAmount.Name = "lblSubTotalAmount"
        Me.lblSubTotalAmount.Size = New System.Drawing.Size(73, 25)
        Me.lblSubTotalAmount.TabIndex = 9
        Me.lblSubTotalAmount.Text = "888.88"
        Me.lblSubTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSubTotalAmount.Visible = False
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTaxAmount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmount.Location = New System.Drawing.Point(538, 341)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(73, 25)
        Me.lblTaxAmount.TabIndex = 10
        Me.lblTaxAmount.Text = "888.88"
        Me.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTaxAmount.Visible = False
        '
        'lblFinalTotalAmount
        '
        Me.lblFinalTotalAmount.AutoSize = True
        Me.lblFinalTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalTotalAmount.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTotalAmount.Location = New System.Drawing.Point(538, 366)
        Me.lblFinalTotalAmount.Name = "lblFinalTotalAmount"
        Me.lblFinalTotalAmount.Size = New System.Drawing.Size(73, 25)
        Me.lblFinalTotalAmount.TabIndex = 11
        Me.lblFinalTotalAmount.Text = "888.88"
        Me.lblFinalTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalTotalAmount.Visible = False
        '
        'radWeekend
        '
        Me.radWeekend.AutoSize = True
        Me.radWeekend.BackColor = System.Drawing.Color.Transparent
        Me.radWeekend.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWeekend.Location = New System.Drawing.Point(360, 227)
        Me.radWeekend.Name = "radWeekend"
        Me.radWeekend.Size = New System.Drawing.Size(102, 27)
        Me.radWeekend.TabIndex = 0
        Me.radWeekend.TabStop = True
        Me.radWeekend.Text = "Weekend"
        Me.radWeekend.UseVisualStyleBackColor = False
        Me.radWeekend.Visible = False
        '
        'radWeekday
        '
        Me.radWeekday.AutoSize = True
        Me.radWeekday.BackColor = System.Drawing.Color.Transparent
        Me.radWeekday.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWeekday.Location = New System.Drawing.Point(360, 268)
        Me.radWeekday.Name = "radWeekday"
        Me.radWeekday.Size = New System.Drawing.Size(99, 27)
        Me.radWeekday.TabIndex = 1
        Me.radWeekday.TabStop = True
        Me.radWeekday.Text = "Weekday"
        Me.radWeekday.UseVisualStyleBackColor = False
        Me.radWeekday.Visible = False
        '
        'frmTours
        '
        Me.AcceptButton = Me.btnCalculateCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AlamoTour.My.Resources.Resources.Alamo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 406)
        Me.Controls.Add(Me.radWeekday)
        Me.Controls.Add(Me.lblFinalTotalAmount)
        Me.Controls.Add(Me.radWeekend)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.lblSubTotalAmount)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnCalculateCost)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.cboTour)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTours"
        Me.Text = "Tickets for the Alamo Tour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cboTour As ComboBox
    Friend WithEvents lblTickets As Label
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents btnCalculateCost As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblSubTotalAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblFinalTotalAmount As Label
    Friend WithEvents radWeekend As RadioButton
    Friend WithEvents radWeekday As RadioButton
End Class
