'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Imports System


Public Class FcalDistant
    Dim x As New xFuels.ClassFuels

    Private Sub FcalDistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        txResult.Text = Math.Round(distance(lat1.Text, long1.Text, lat2.Text, long2.Text, "M"), 1) & " miles."
        txResult2.Text = Math.Round(distance(lat1.Text, long1.Text, lat2.Text, long2.Text, "K"), 1) & " kilometers."

    End Sub


#Region "Distance Calculation Functions"

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    ':::                                                                         :::
    ':::  This routine calculates the distance between two points (given the     :::
    ':::  latitude/longitude of those points). It is being used to calculate     :::
    ':::  the distance between two locations using GeoDataSource (TM) prodducts  :::
    ':::                                                                         :::
    ':::  Definitions:                                                           :::
    ':::    South latitudes are negative, east longitudes are positive           :::
    ':::                                                                         :::
    ':::  Passed to function:                                                    :::
    ':::    lat1, lon1 = Latitude and Longitude of point 1 (in decimal degrees)  :::
    ':::    lat2, lon2 = Latitude and Longitude of point 2 (in decimal degrees)  :::
    ':::    unit = the unit you desire for results                               :::
    ':::           where: 'M' is statute miles (default)                         :::
    ':::                  'K' is kilometers                                      :::
    ':::                  'N' is nautical miles                                  :::
    ':::                                                                         :::
    ':::  Worldwide cities and other features databases with latitude longitude  :::
    ':::  are available at https://www.geodatasource.com                         :::
    ':::                                                                         :::
    ':::  For enquiries, please contact sales@geodatasource.com                  :::
    ':::                                                                         :::
    ':::  Official Web site: https://www.geodatasource.com                       :::
    ':::                                                                         :::
    ':::              GeoDataSource.com (C) All Rights Reserved 2018             :::
    ':::      source: https://www.geodatasource.com/developers/vb-dot-net        :::
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Public Function distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double, ByVal unit As Char) As Double
        Try
            If lat1 = lat2 And lon1 = lon2 Then
                Return 0
            Else
                Dim theta As Double = lon1 - lon2
                Dim dist As Double = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
                dist = Math.Acos(dist)
                dist = rad2deg(dist)
                dist = dist * 60 * 1.1515
                If unit = "K" Then
                    dist = dist * 1.609344
                ElseIf unit = "N" Then
                    dist = dist * 0.8684
                End If
                Return dist
            End If
        Catch ex As Exception
            x.ERRlog("1XDU417H", ex.Message)
        End Try
    End Function

    Private Function deg2rad(ByVal deg As Double) As Double
        Return (deg * Math.PI / 180.0)
    End Function

    Private Function rad2deg(ByVal rad As Double) As Double
        Return rad / Math.PI * 180.0
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Diagnostics.Process.Start("https://www.geodatasource.com")
        Catch ex As Exception
            x.ERRlog("1XP08MYF", ex.Message)
        End Try

    End Sub




#End Region

End Class