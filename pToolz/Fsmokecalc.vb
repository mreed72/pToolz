'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Fsmokecalc
    Dim x As New xFuels.ClassFuels
    Dim sADJ, sNEW As Integer

    Private Sub Fsmokecalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.cbLogSession = True Then
            pb1.Image = My.Resources.weIMAGE124
            k7.Text = "Log Enabled!"
        Else
            pb1.Image = My.Resources.weIMAGE118
            k7.Text = "Log Disabled!"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

#Region "Move the Form Click anywhere"
    Private _location As Point

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        _location = e.Location

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Location = Point.Add(Location, MSize)

        End If
    End Sub


#End Region

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            'CLEAR
            txBurnSize.Clear()
            txCatDay.Clear()
            txDistance.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1
            txResults.Clear()
            txAvFuels.Text = 0
            txTotalTons.Text = 0
            txAllowed.Text = 0
            sADJ = 0
            sNEW = 0
            txResults.BackColor = Color.FromArgb(238, 242, 245)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txCatDay_Leave(sender As Object, e As EventArgs) Handles txCatDay.Leave
        If txCatDay.Text < 1 Or txCatDay.Text > 5 Then
            txCatDay.BackColor = Color.Yellow
            txCatDay.Clear()
            txCatDay.Focus()
        Else
            txCatDay.BackColor = Color.FromArgb(238, 242, 245)
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click


        If txBurnSize.Text = "" Then
            txBurnSize.BackColor = Drawing.Color.Yellow
            txBurnSize.Focus()
            Exit Sub
        Else
            txBurnSize.BackColor = Color.FromArgb(238, 242, 245)
        End If

        If txCatDay.Text = "" Then
            txCatDay.BackColor = Drawing.Color.Yellow
            txCatDay.Focus()
            Exit Sub
        Else
            txCatDay.BackColor = Color.FromArgb(238, 242, 245)
        End If

        If txDistance.Text = "" Then
            txDistance.BackColor = Drawing.Color.Yellow
            txDistance.Focus()
            Exit Sub
        Else
            txDistance.BackColor = Color.FromArgb(238, 242, 245)
        End If

        If txFtype.SelectedIndex = -1 Then
            txFtype.BackColor = Color.Yellow
            Exit Sub
        Else
            txFtype.BackColor = Color.FromArgb(238, 242, 245)
        End If

        If txFload.SelectedIndex = -1 Then
            txFload.BackColor = Color.Yellow
            Exit Sub
        Else
            txFload.BackColor = Color.FromArgb(238, 242, 245)
        End If
        Try
            txAvFuels.Text = x.GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
            txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
            sADJ = x.smpCalc(txCatDay.Text, txDistance.Text)
            txAllowed.Text = sADJ
            sNEW = sADJ / Val(txAvFuels.Text) - 3
            If txTotalTons.Text > sADJ Then
                txResults.Text = "YOUR BURN WILL EXCEED THE GUIDELINES."
                txResults.BackColor = Color.LightPink
                txRecSize.Text = sNEW
            Else
                txResults.Text = "Your burn WILL NOT exceed the guidelines."
                txResults.BackColor = Color.FromArgb(238, 242, 245)
                txRecSize.Text = 0
            End If
        Catch ex As Exception

        End Try

        'SESSION LOG
        If My.Settings.cbLogSession = False Then
            Exit Sub
        Else
            Dim bs, tt, cd, at, rec As Integer
            Dim td, av As Double
            Dim ft, fl, res As String

            bs = txBurnSize.Text
            tt = txTotalTons.Text
            cd = txCatDay.Text
            at = txAllowed.Text
            td = txDistance.Text
            av = txAvFuels.Text
            ft = txFtype.SelectedItem
            fl = txFload.SelectedItem
            res = txResults.Text
            rec = txRecSize.Text

            x.SESLog("Smoke Calculator", "Burn Size: " & bs & vbCrLf & "Category Day: " & cd & vbCrLf & "Target Distance: " & td & vbCrLf & "Allowed Tonnage: " & at & vbCrLf & "Total Tons: " & tt _
                     & vbCrLf & "Available Fuels: " & av & vbCrLf & "Fuel Type: " & ft & vbCrLf & "Fuel Load: " & fl & vbCrLf & "Results: " & res & vbCrLf & "Recommend Size: " & rec)







        End If











    End Sub


End Class