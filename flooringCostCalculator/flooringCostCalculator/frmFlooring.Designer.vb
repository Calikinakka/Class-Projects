<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlooringCost
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
        Me.lblSquareFeet = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.grpFlooringType = New System.Windows.Forms.GroupBox()
        Me.radHardwood = New System.Windows.Forms.RadioButton()
        Me.radCarpet = New System.Windows.Forms.RadioButton()
        Me.radTile = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picFlooring = New System.Windows.Forms.PictureBox()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.grpFlooringType.SuspendLayout()
        CType(Me.picFlooring, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(58, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(288, 32)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Flooring Cost Calculator"
        '
        'lblSquareFeet
        '
        Me.lblSquareFeet.AutoSize = True
        Me.lblSquareFeet.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFeet.Location = New System.Drawing.Point(101, 98)
        Me.lblSquareFeet.Name = "lblSquareFeet"
        Me.lblSquareFeet.Size = New System.Drawing.Size(149, 25)
        Me.lblSquareFeet.TabIndex = 1
        Me.lblSquareFeet.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Location = New System.Drawing.Point(271, 103)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(33, 20)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpFlooringType
        '
        Me.grpFlooringType.Controls.Add(Me.radHardwood)
        Me.grpFlooringType.Controls.Add(Me.radCarpet)
        Me.grpFlooringType.Controls.Add(Me.radTile)
        Me.grpFlooringType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFlooringType.Location = New System.Drawing.Point(115, 146)
        Me.grpFlooringType.Name = "grpFlooringType"
        Me.grpFlooringType.Size = New System.Drawing.Size(175, 105)
        Me.grpFlooringType.TabIndex = 3
        Me.grpFlooringType.TabStop = False
        Me.grpFlooringType.Text = "Flooring Type"
        '
        'radHardwood
        '
        Me.radHardwood.AutoSize = True
        Me.radHardwood.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHardwood.Location = New System.Drawing.Point(36, 68)
        Me.radHardwood.Name = "radHardwood"
        Me.radHardwood.Size = New System.Drawing.Size(110, 27)
        Me.radHardwood.TabIndex = 2
        Me.radHardwood.Text = "Hardwood"
        Me.radHardwood.UseVisualStyleBackColor = True
        '
        'radCarpet
        '
        Me.radCarpet.AutoSize = True
        Me.radCarpet.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCarpet.Location = New System.Drawing.Point(36, 44)
        Me.radCarpet.Name = "radCarpet"
        Me.radCarpet.Size = New System.Drawing.Size(80, 27)
        Me.radCarpet.TabIndex = 1
        Me.radCarpet.Text = "Carpet"
        Me.radCarpet.UseVisualStyleBackColor = True
        '
        'radTile
        '
        Me.radTile.AutoSize = True
        Me.radTile.Checked = True
        Me.radTile.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTile.Location = New System.Drawing.Point(36, 20)
        Me.radTile.Name = "radTile"
        Me.radTile.Size = New System.Drawing.Size(58, 27)
        Me.radTile.TabIndex = 0
        Me.radTile.TabStop = True
        Me.radTile.Text = "Tile"
        Me.radTile.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(83, 279)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(136, 25)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost Estimate:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(71, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 30)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(218, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 30)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'picFlooring
        '
        Me.picFlooring.Image = Global.flooringCostCalculator.My.Resources.Resources.Flooring
        Me.picFlooring.Location = New System.Drawing.Point(2, 370)
        Me.picFlooring.Name = "picFlooring"
        Me.picFlooring.Size = New System.Drawing.Size(400, 150)
        Me.picFlooring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlooring.TabIndex = 7
        Me.picFlooring.TabStop = False
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.Location = New System.Drawing.Point(225, 279)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(94, 25)
        Me.lblCostEstimate.TabIndex = 8
        Me.lblCostEstimate.Text = "$0000.00"
        '
        'frmFlooringCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(404, 521)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.picFlooring)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpFlooringType)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblSquareFeet)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFlooringCost"
        Me.Text = "Flooring Cost"
        Me.grpFlooringType.ResumeLayout(False)
        Me.grpFlooringType.PerformLayout()
        CType(Me.picFlooring, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFeet As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents grpFlooringType As GroupBox
    Friend WithEvents radHardwood As RadioButton
    Friend WithEvents radCarpet As RadioButton
    Friend WithEvents radTile As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picFlooring As PictureBox
    Friend WithEvents lblCostEstimate As Label
End Class
