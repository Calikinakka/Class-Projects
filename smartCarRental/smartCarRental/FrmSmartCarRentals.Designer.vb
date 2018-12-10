<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentASmartCar
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
        Me.picSmartCar = New System.Windows.Forms.PictureBox()
        Me.lblHeaderSmartCarRentals = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.lblNumberofMiles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblHeadingTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayFare = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picSmartCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSmartCar
        '
        Me.picSmartCar.Image = Global.smartCarRental.My.Resources.Resources.Car_Rental
        Me.picSmartCar.Location = New System.Drawing.Point(-1, 0)
        Me.picSmartCar.Name = "picSmartCar"
        Me.picSmartCar.Size = New System.Drawing.Size(384, 179)
        Me.picSmartCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmartCar.TabIndex = 0
        Me.picSmartCar.TabStop = False
        Me.picSmartCar.UseWaitCursor = True
        '
        'lblHeaderSmartCarRentals
        '
        Me.lblHeaderSmartCarRentals.AutoSize = True
        Me.lblHeaderSmartCarRentals.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderSmartCarRentals.Location = New System.Drawing.Point(90, 182)
        Me.lblHeaderSmartCarRentals.Name = "lblHeaderSmartCarRentals"
        Me.lblHeaderSmartCarRentals.Size = New System.Drawing.Size(205, 24)
        Me.lblHeaderSmartCarRentals.TabIndex = 1
        Me.lblHeaderSmartCarRentals.Text = "Smart Car Rentals"
        Me.lblHeaderSmartCarRentals.UseWaitCursor = True
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(102, 244)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(123, 20)
        Me.lblNumberOfDays.TabIndex = 2
        Me.lblNumberOfDays.Text = "Number of Days"
        Me.lblNumberOfDays.UseWaitCursor = True
        '
        'lblNumberofMiles
        '
        Me.lblNumberofMiles.AutoSize = True
        Me.lblNumberofMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofMiles.Location = New System.Drawing.Point(102, 270)
        Me.lblNumberofMiles.Name = "lblNumberofMiles"
        Me.lblNumberofMiles.Size = New System.Drawing.Size(123, 20)
        Me.lblNumberofMiles.TabIndex = 3
        Me.lblNumberofMiles.Text = "Number of Miles"
        Me.lblNumberofMiles.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Only $29.99 Per Day Plus $0.39 Per Mile"
        Me.Label1.UseWaitCursor = True
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(252, 244)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(28, 20)
        Me.txtDays.TabIndex = 5
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDays.UseWaitCursor = True
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(252, 270)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(28, 20)
        Me.txtMiles.TabIndex = 6
        Me.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMiles.UseWaitCursor = True
        '
        'lblHeadingTotalCost
        '
        Me.lblHeadingTotalCost.AutoSize = True
        Me.lblHeadingTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingTotalCost.Location = New System.Drawing.Point(102, 309)
        Me.lblHeadingTotalCost.Name = "lblHeadingTotalCost"
        Me.lblHeadingTotalCost.Size = New System.Drawing.Size(148, 18)
        Me.lblHeadingTotalCost.TabIndex = 7
        Me.lblHeadingTotalCost.Text = "Total Cost of Rental: "
        Me.lblHeadingTotalCost.UseWaitCursor = True
        '
        'btnDisplayFare
        '
        Me.btnDisplayFare.Location = New System.Drawing.Point(40, 360)
        Me.btnDisplayFare.Name = "btnDisplayFare"
        Me.btnDisplayFare.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayFare.TabIndex = 8
        Me.btnDisplayFare.Text = "Display Fare"
        Me.btnDisplayFare.UseVisualStyleBackColor = True
        Me.btnDisplayFare.UseWaitCursor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(153, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.UseWaitCursor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.UseWaitCursor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(249, 309)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(70, 18)
        Me.lblTotalCost.TabIndex = 11
        Me.lblTotalCost.Text = "$XXX.XX"
        Me.lblTotalCost.UseWaitCursor = True
        '
        'frmRentASmartCar
        '
        Me.AcceptButton = Me.btnDisplayFare
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFare)
        Me.Controls.Add(Me.lblHeadingTotalCost)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumberofMiles)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.lblHeaderSmartCarRentals)
        Me.Controls.Add(Me.picSmartCar)
        Me.Name = "frmRentASmartCar"
        Me.Text = "Rent a Smart Car"
        Me.UseWaitCursor = True
        CType(Me.picSmartCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSmartCar As PictureBox
    Friend WithEvents lblHeaderSmartCarRentals As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents lblNumberofMiles As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblHeadingTotalCost As Label
    Friend WithEvents btnDisplayFare As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As Label
End Class
