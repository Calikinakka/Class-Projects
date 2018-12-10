<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBikes
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfBikes = New System.Windows.Forms.Label()
        Me.txtNumberOfBikes = New System.Windows.Forms.TextBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picBikes = New System.Windows.Forms.PictureBox()
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblHeading.Location = New System.Drawing.Point(91, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(226, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "City Bike Rentals"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(99, 60)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(210, 20)
        Me.lblCostHeading.TabIndex = 1
        Me.lblCostHeading.Text = "$X.XX Per Bike for 24 Hours"
        '
        'lblNumberOfBikes
        '
        Me.lblNumberOfBikes.AutoSize = True
        Me.lblNumberOfBikes.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.lblNumberOfBikes.Location = New System.Drawing.Point(71, 97)
        Me.lblNumberOfBikes.Name = "lblNumberOfBikes"
        Me.lblNumberOfBikes.Size = New System.Drawing.Size(177, 20)
        Me.lblNumberOfBikes.TabIndex = 2
        Me.lblNumberOfBikes.Text = "Number of bike rentals:"
        '
        'txtNumberOfBikes
        '
        Me.txtNumberOfBikes.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfBikes.Location = New System.Drawing.Point(276, 91)
        Me.txtNumberOfBikes.Name = "txtNumberOfBikes"
        Me.txtNumberOfBikes.Size = New System.Drawing.Size(33, 26)
        Me.txtNumberOfBikes.TabIndex = 3
        Me.txtNumberOfBikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(71, 139)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(199, 20)
        Me.lblTotalCostLabel.TabIndex = 4
        Me.lblTotalCostLabel.Text = "Total Cost of Bikes Rented:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(272, 139)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(45, 20)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "$0.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCalculate.Location = New System.Drawing.Point(51, 199)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.Location = New System.Drawing.Point(160, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.Location = New System.Drawing.Point(269, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picBikes
        '
        Me.picBikes.Image = Global.BikeRentals.My.Resources.Resources.Bikes
        Me.picBikes.Location = New System.Drawing.Point(1, 284)
        Me.picBikes.Name = "picBikes"
        Me.picBikes.Size = New System.Drawing.Size(407, 175)
        Me.picBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBikes.TabIndex = 7
        Me.picBikes.TabStop = False
        '
        'frmBikes
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(409, 461)
        Me.Controls.Add(Me.picBikes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.txtNumberOfBikes)
        Me.Controls.Add(Me.lblNumberOfBikes)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBikes"
        Me.Text = "City Bike Rentals"
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumberOfBikes As Label
    Friend WithEvents txtNumberOfBikes As TextBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picBikes As PictureBox
End Class
