'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Imports xFuels

Public Class Fsmokecalc
    Private sADJ, sNEW As Integer

    Private x1 As New xFuels.ClassFuels


    Public Property SADJ1 As Integer
        Get
            Return sADJ
        End Get
        Set(value As Integer)
            sADJ = value
        End Set
    End Property

    Public Property SNEW1 As Integer
        Get
            Return sNEW
        End Get
        Set(value As Integer)
            sNEW = value
        End Set
    End Property

    Private Sub Fsmokecalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

#Region "Click Anywhere and move form (Un-Comment to enable)"
    'Private _location As Point

    'Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
    '    _location = e.Location

    'End Sub

    'Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

    '        Dim MSize As New Size(_location)
    '        MSize.Width = e.X - _location.X
    '        MSize.Height = e.Y - _location.Y
    '        Location = Point.Add(Location, MSize)

    '    End If
    'End Sub
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
            SADJ1 = 0
            SNEW1 = 0
            txResults.BackColor = Color.FromArgb(238, 242, 245)
        Catch ex As Exception
            X1.ERRlog("1XB7DV1N", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub txCatDay_Leave(sender As Object, e As EventArgs) Handles txCatDay.Leave
        Try
            If txCatDay.Text < 1 Or txCatDay.Text > 5 Then
                txCatDay.BackColor = Color.Yellow
                txCatDay.Clear()
                txCatDay.Focus()
            Else
                txCatDay.BackColor = Color.FromArgb(238, 242, 245)
            End If
        Catch ex As Exception
            X1.ERRlog("1X8SXMUD", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

#Region "Quick Error Check"
        Try
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
        Catch ex As Exception
            X1.ERRlog("1XFLQ6GC", ex.Message) ' ERROR LOG CODE
        End Try

#End Region

        'Calculation Process
        Try
            txAvFuels.Text = X1.GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
            txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
            SADJ1 = X1.smpCalc(txCatDay.Text, txDistance.Text)
            txAllowed.Text = SADJ1
            SNEW1 = SADJ1 / Val(txAvFuels.Text) - 3
            If txTotalTons.Text > SADJ1 Then
                txResults.Text = "YOUR BURN WILL EXCEED THE GUIDELINES."
                txResults.BackColor = Color.LightPink
                txRecSize.Text = SNEW1
            Else
                txResults.Text = "Your burn WILL NOT exceed the guidelines."
                txResults.BackColor = Color.FromArgb(238, 242, 245)
                txRecSize.Text = 0
            End If
        Catch ex As Exception
            X1.ERRlog("1XF0ZD0S", ex.Message) ' ERROR LOG CODE
        End Try

        'SESSION LOG
        Try

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
            X1.SESLog("Smoke Calculator", "Burn Size: " & bs & vbCrLf & "Category Day: " & cd & vbCrLf & "Target Distance: " & td & vbCrLf & "Allowed Tonnage: " & at & vbCrLf & "Total Tons: " & tt _
                     & vbCrLf & "Available Fuels: " & av & vbCrLf & "Fuel Type: " & ft & vbCrLf & "Fuel Load: " & fl & vbCrLf & "Results: " & res & vbCrLf & "Recommend Size: " & rec)
            If My.Settings.CurrentSessionID = String.Empty Then
                Form1.myicon.ShowBalloonTip(2000, "Smoke Calculator", "NO SESSION LOG CREATED!", ToolTipIcon.Info)
            Else
                Form1.myicon.ShowBalloonTip(2000, "Smoke Calculator", "Session log has been saved!", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            X1.ERRlog("1XYNZOS9", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub


End Class