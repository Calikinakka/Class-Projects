<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedicalWeightConversionCalculator
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
        Me.picScale = New System.Windows.Forms.PictureBox()
        Me.lblHeadingPound = New System.Windows.Forms.Label()
        Me.lblEnterWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.grpConvertWeight = New System.Windows.Forms.GroupBox()
        Me.radPounds = New System.Windows.Forms.RadioButton()
        Me.radKilograms = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWeightHeader = New System.Windows.Forms.Label()
        Me.lblConvertedWeight = New System.Windows.Forms.Label()
        CType(Me.picScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConvertWeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'picScale
        '
        Me.picScale.Image = Global.MedicalWeightConversionCalculator.My.Resources.Resources.Scale
        Me.picScale.Location = New System.Drawing.Point(0, -1)
        Me.picScale.Name = "picScale"
        Me.picScale.Size = New System.Drawing.Size(155, 117)
        Me.picScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScale.TabIndex = 0
        Me.picScale.TabStop = False
        '
        'lblHeadingPound
        '
        Me.lblHeadingPound.AutoSize = True
        Me.lblHeadingPound.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingPound.Location = New System.Drawing.Point(179, 41)
        Me.lblHeadingPound.Name = "lblHeadingPound"
        Me.lblHeadingPound.Size = New System.Drawing.Size(338, 28)
        Me.lblHeadingPound.TabIndex = 1
        Me.lblHeadingPound.Text = "Pound and Kilogram Conversion"
        '
        'lblEnterWeight
        '
        Me.lblEnterWeight.AutoSize = True
        Me.lblEnterWeight.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWeight.Location = New System.Drawing.Point(190, 89)
        Me.lblEnterWeight.Name = "lblEnterWeight"
        Me.lblEnterWeight.Size = New System.Drawing.Size(135, 25)
        Me.lblEnterWeight.TabIndex = 2
        Me.lblEnterWeight.Text = "Enter Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(377, 94)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(44, 20)
        Me.txtWeight.TabIndex = 3
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConvertWeight
        '
        Me.grpConvertWeight.BackColor = System.Drawing.Color.Gold
        Me.grpConvertWeight.Controls.Add(Me.radKilograms)
        Me.grpConvertWeight.Controls.Add(Me.radPounds)
        Me.grpConvertWeight.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConvertWeight.Location = New System.Drawing.Point(167, 157)
        Me.grpConvertWeight.Name = "grpConvertWeight"
        Me.grpConvertWeight.Size = New System.Drawing.Size(200, 90)
        Me.grpConvertWeight.TabIndex = 4
        Me.grpConvertWeight.TabStop = False
        Me.grpConvertWeight.Text = "Convert Weight"
        '
        'radPounds
        '
        Me.radPounds.AutoSize = True
        Me.radPounds.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPounds.Location = New System.Drawing.Point(6, 29)
        Me.radPounds.Name = "radPounds"
        Me.radPounds.Size = New System.Drawing.Size(133, 20)
        Me.radPounds.TabIndex = 0
        Me.radPounds.TabStop = True
        Me.radPounds.Text = "Pounds to Kilograms"
        Me.radPounds.UseVisualStyleBackColor = True
        '
        'radKilograms
        '
        Me.radKilograms.AutoSize = True
        Me.radKilograms.Font = New System.Drawing.Font("Goudy Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radKilograms.Location = New System.Drawing.Point(6, 55)
        Me.radKilograms.Name = "radKilograms"
        Me.radKilograms.Size = New System.Drawing.Size(133, 20)
        Me.radKilograms.TabIndex = 1
        Me.radKilograms.TabStop = True
        Me.radKilograms.Text = "Kilograms to Pounds"
        Me.radKilograms.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDisplay.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(102, 328)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(144, 33)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display Weight"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(288, 328)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(144, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblWeightHeader
        '
        Me.lblWeightHeader.AutoSize = True
        Me.lblWeightHeader.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightHeader.Location = New System.Drawing.Point(78, 280)
        Me.lblWeightHeader.Name = "lblWeightHeader"
        Me.lblWeightHeader.Size = New System.Drawing.Size(229, 23)
        Me.lblWeightHeader.TabIndex = 7
        Me.lblWeightHeader.Text = "The Weight of the Patient is "
        '
        'lblConvertedWeight
        '
        Me.lblConvertedWeight.AutoSize = True
        Me.lblConvertedWeight.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedWeight.Location = New System.Drawing.Point(299, 280)
        Me.lblConvertedWeight.Name = "lblConvertedWeight"
        Me.lblConvertedWeight.Size = New System.Drawing.Size(158, 23)
        Me.lblConvertedWeight.TabIndex = 8
        Me.lblConvertedWeight.Text = "888.888 kilograms."
        '
        'FrmMedicalWeightConversionCalculator
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(534, 391)
        Me.Controls.Add(Me.lblConvertedWeight)
        Me.Controls.Add(Me.lblWeightHeader)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.grpConvertWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblEnterWeight)
        Me.Controls.Add(Me.lblHeadingPound)
        Me.Controls.Add(Me.picScale)
        Me.Name = "FrmMedicalWeightConversionCalculator"
        Me.Text = "Medical Weight Conversion Calculator"
        CType(Me.picScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConvertWeight.ResumeLayout(False)
        Me.grpConvertWeight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picScale As PictureBox
    Friend WithEvents lblHeadingPound As Label
    Friend WithEvents lblEnterWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents grpConvertWeight As GroupBox
    Friend WithEvents radKilograms As RadioButton
    Friend WithEvents radPounds As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblWeightHeader As Label
    Friend WithEvents lblConvertedWeight As Label
End Class
