<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayRestaurants
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
        Me.lstRestaurantAndCost = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRestaurantAndCost
        '
        Me.lstRestaurantAndCost.FormattingEnabled = True
        Me.lstRestaurantAndCost.Location = New System.Drawing.Point(26, 25)
        Me.lstRestaurantAndCost.Name = "lstRestaurantAndCost"
        Me.lstRestaurantAndCost.Size = New System.Drawing.Size(355, 212)
        Me.lstRestaurantAndCost.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.DimGray
        Me.btnReturn.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturn.Location = New System.Drawing.Point(106, 290)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(195, 56)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return to Selection"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'frmDisplayRestaurants
        '
        Me.AcceptButton = Me.btnReturn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 420)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstRestaurantAndCost)
        Me.Name = "frmDisplayRestaurants"
        Me.Text = "frmDisplayRestaurants"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRestaurantAndCost As ListBox
    Friend WithEvents btnReturn As Button
End Class
