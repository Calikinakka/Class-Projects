﻿Public Class frmSelfies
    Private Sub frmSelfies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCheer_Click(sender As Object, e As EventArgs) Handles btnCheer.Click
        picCheer.Visible = True
        btnSelect.Enabled = True
        picCheer.Visible = False
        'shows the Cheer selfie, hides the connect selfie and enables the select button

    End Sub

    Private Sub picConnect_Click(sender As Object, e As EventArgs) Handles picConnect.Click
        picCheer.Visible = False
        picConnect.Visible = True
        btnSelect.Enabled = True
        'shows the Connect selfie, hides the cheer selfie and enables the select button

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnCheer.Enabled = False
        btnConnect.Enabled = False
        btnExit.Enabled = True
        btnExit.Visible = True
        lblInstructions.Visible = False
        lblThanks.Visible = True
        'disables the selfie buttons, disables the select button, enables the exit button
        'hides the instructions and shows the thanks lable.
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
        'closes the window

    End Sub
End Class
