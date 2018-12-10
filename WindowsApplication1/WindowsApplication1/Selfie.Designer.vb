<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelfies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelfies))
        Me.picConnect = New System.Windows.Forms.PictureBox()
        Me.picCheer = New System.Windows.Forms.PictureBox()
        Me.btnCheer = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picConnect
        '
        Me.picConnect.Image = CType(resources.GetObject("picConnect.Image"), System.Drawing.Image)
        Me.picConnect.Location = New System.Drawing.Point(277, 112)
        Me.picConnect.Name = "picConnect"
        Me.picConnect.Size = New System.Drawing.Size(200, 200)
        Me.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConnect.TabIndex = 0
        Me.picConnect.TabStop = False
        Me.picConnect.Visible = False
        '
        'picCheer
        '
        Me.picCheer.Image = CType(resources.GetObject("picCheer.Image"), System.Drawing.Image)
        Me.picCheer.Location = New System.Drawing.Point(29, 112)
        Me.picCheer.Name = "picCheer"
        Me.picCheer.Size = New System.Drawing.Size(200, 200)
        Me.picCheer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheer.TabIndex = 0
        Me.picCheer.TabStop = False
        Me.picCheer.Visible = False
        '
        'btnCheer
        '
        Me.btnCheer.Location = New System.Drawing.Point(75, 70)
        Me.btnCheer.Name = "btnCheer"
        Me.btnCheer.Size = New System.Drawing.Size(109, 23)
        Me.btnCheer.TabIndex = 1
        Me.btnCheer.Text = "Finalist ""Cheer"""
        Me.btnCheer.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(310, 70)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(134, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Finalist ""Connect"""
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(204, 329)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(98, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Selfie"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(86, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(335, 25)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Vote for the best campus selfie"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(37, 359)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(432, 19)
        Me.lblInstructions.TabIndex = 4
        Me.lblInstructions.Text = "Choose the best selfie and then click the Select Selfie button"
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblThanks.Location = New System.Drawing.Point(184, 387)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(138, 19)
        Me.lblThanks.TabIndex = 5
        Me.lblThanks.Text = "Thanks for voting!"
        Me.lblThanks.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(207, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'frmSelfies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(507, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnCheer)
        Me.Controls.Add(Me.picCheer)
        Me.Controls.Add(Me.picConnect)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSelfies"
        Me.Text = "Vote For The Best Campus Selfie Finalist Pictures"
        CType(Me.picConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picConnect As PictureBox
    Friend WithEvents picCheer As PictureBox
    Friend WithEvents btnCheer As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblThanks As Label
    Friend WithEvents btnExit As Button
End Class
