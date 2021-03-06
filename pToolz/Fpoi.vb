﻿'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Fpoi
    Private x1 As New xFuels.ClassFuels

    Private Sub Fpoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            txShading.Maximum = 100
            txDryBulb.Maximum = 125
            txFDFM.Maximum = 17
        Catch ex As Exception
            X1.ERRlog("1X330YT4", ex.Message) ' ERROR LOG CODE
        End Try



    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            Dim a1, a2, a3, a4 As Integer
            a1 = txShading.Value
            a2 = txDryBulb.Value
            a3 = txFDFM.Value
            a4 = X1.ProIgnCalc(a1, a2, a3)

            If a4 >= 80 Then
                txResult.BackColor = Color.LightPink
            Else
                txResult.BackColor = DefaultBackColor
            End If
            txResult.Text = a4 & "%"

            X1.SESLog("Probability of Ignition", "Shading: " & a1 & vbCrLf & "Dry Bulb Temp: " & a2 & vbCrLf & "Fuel Moisture: " & a3 & vbCrLf & "Result: " & a4 & "%")

            If My.Settings.CurrentSessionID = String.Empty Then
                Form1.myicon.ShowBalloonTip(2000, "POI", "NO SESSION LOG CREATED!", ToolTipIcon.Info)
            Else
                Form1.myicon.ShowBalloonTip(2000, "POI", "Session log has been saved!", ToolTipIcon.Info)
            End If

        Catch ex As Exception
            X1.ERRlog("1XP5K2FA", ex.Message) ' ERROR LOG CODE
        End Try




    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            txShading.Value = 1
            txDryBulb.Value = 1
            txFDFM.Value = 1
            txResult.Clear()
            txResult.BackColor = DefaultBackColor
        Catch ex As Exception
            X1.ERRlog("1X6F1M6K", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub lkb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkb.LinkClicked
        MessageBox.Show("The chance that a firebrand will cause an ignition when it lands on receptive fuels.", "POI", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class