﻿'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018-2024 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================

Imports System.IO
Imports System.Text

Public Class ClassFuels

    ''' <summary>
    ''' Available Fuels
    ''' </summary>
    ''' <param name="cTypx">Fuel Type</param>
    ''' <param name="cLoad">Fuel Load</param>
    ''' <returns>DOUBLE: value represents the available fuels for a burn.</returns>
    Public Function GetAvFuels(ByVal cTypx As String, ByVal cLoad As String)
        Select Case cTypx
            Case "1-Shortleaf Pine with Oak"
                Select Case cLoad
                    Case Is = "Low"
                        Return 3.0
                    Case Is = "Moderate"
                        Return 4.0
                    Case Is = "Heavy"
                        Return 4.4
                    Case Else
                        Exit Select
                End Select
            Case "2-Shortleaf Pine Regeneration"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.6
                    Case Is = "Moderate"
                        Return 3.8
                    Case Is = "Heavy"
                        Return 5.1
                    Case Else
                        Exit Select
                End Select
            Case "3-Loblolly Pine with Oak"
                Select Case cLoad
                    Case Is = "Low"
                        Return 6.4
                    Case Is = "Moderate"
                        Return 6.8
                    Case Is = "Heavy"
                        Return 7.9
                    Case Else
                        Exit Select
                End Select
            Case "4-Loblolly Pine Regeneration"
                Select Case cLoad
                    Case Is = "Low"
                        Return 4.4
                    Case Is = "Moderate"
                        Return 7.6
                    Case Is = "Heavy"
                        Return 8.5
                    Case Else
                        Exit Select
                End Select
            Case "5-Hardwood Leaf Litter"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.8
                    Case Is = "Moderate"
                        Return 1.5
                    Case Is = "Heavy"
                        Return 2.5
                    Case Else
                        Exit Select
                End Select
            Case "6-Grass or Brush"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.0
                    Case Is = "Moderate"
                        Return 3.0
                    Case Is = "Heavy"
                        Return 5.0
                    Case Else
                        Exit Select
                End Select
            Case "7-Dispersed Slash"
                Select Case cLoad
                    Case Is = "Low"
                        Return 4.0
                    Case Is = "Moderate"
                        Return 6.0
                    Case Is = "Heavy"
                        Return 8.0
                    Case Else
                        Exit Select
                End Select
            Case "8-Piled Debris"
                Select Case cLoad
                    Case Is = "Low"
                        Return 5.0
                    Case Is = "Moderate"
                        Return 7.5
                    Case Is = "Heavy"
                        Return 10.0
                    Case Else
                        Exit Select
                End Select
            Case "9-Shortleaf Loblolly with Grass"
                Select Case cLoad
                    Case Is = "Low"
                        Return 1.5
                    Case Is = "Moderate"
                        Return 3.8
                    Case Is = "Heavy"
                        Return 5.9
                    Case Else
                        Exit Select
                End Select
            Case "10-Corn"
                Select Case cLoad
                    Case Is = "Low"
                        Return 3.1
                    Case Is = "Moderate"
                        Return 4.7
                    Case Is = "Heavy"
                        Return 6.2
                    Case Else
                        Exit Select
                End Select
            Case "11-Cotton"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.8
                    Case Is = "Moderate"
                        Return 1.1
                    Case Is = "Heavy"
                        Return 1.5
                    Case Else
                        Exit Select
                End Select
            Case "12-Rice"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.5
                    Case Is = "Moderate"
                        Return 3.7
                    Case Is = "Heavy"
                        Return 4.9
                    Case Else
                        Exit Select
                End Select
            Case "13-Soybean"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.9
                    Case Is = "Moderate"
                        Return 4.3
                    Case Is = "Heavy"
                        Return 5.7
                    Case Else
                        Exit Select
                End Select
            Case "14-Wheat"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.9
                    Case Is = "Moderate"
                        Return 1.4
                    Case Is = "Heavy"
                        Return 1.9
                    Case Else
                        Exit Select
                End Select
            Case Else
                Exit Select
        End Select
    End Function

    ''' <summary>
    ''' Get Available Fuels (Refined Version)
    ''' </summary>
    ''' <param name="cTypx">Fuel Type</param>
    ''' <param name="cLoad">Fuel Load</param>
    ''' <returns>DOUBLE: value represents the available fuels for a burn.</returns>
    Public Function GetFuels(ByVal cTypx As String, ByVal cLoad As String) As Double
        Dim fuelValues As New Dictionary(Of String, Dictionary(Of String, Double)) From {
        {"1-Shortleaf Pine with Oak", New Dictionary(Of String, Double) From {{"Low", 3.0}, {"Moderate", 4.0}, {"Heavy", 4.4}}},
        {"2-Shortleaf Pine Regeneration", New Dictionary(Of String, Double) From {{"Low", 2.6}, {"Moderate", 3.8}, {"Heavy", 5.1}}},
        {"3-Loblolly Pine with Oak", New Dictionary(Of String, Double) From {{"Low", 6.4}, {"Moderate", 6.8}, {"Heavy", 7.9}}},
        {"4-Loblolly Pine Regeneration", New Dictionary(Of String, Double) From {{"Low", 4.4}, {"Moderate", 7.6}, {"Heavy", 8.5}}},
        {"5-Hardwood Leaf Litter", New Dictionary(Of String, Double) From {{"Low", 0.8}, {"Moderate", 1.5}, {"Heavy", 2.5}}},
        {"6-Grass or Brush", New Dictionary(Of String, Double) From {{"Low", 2.0}, {"Moderate", 3.0}, {"Heavy", 5.0}}},
        {"7-Dispersed Slash", New Dictionary(Of String, Double) From {{"Low", 4.0}, {"Moderate", 6.0}, {"Heavy", 8.0}}},
        {"8-Piled Debris", New Dictionary(Of String, Double) From {{"Low", 5.0}, {"Moderate", 7.5}, {"Heavy", 10.0}}},
        {"9-Shortleaf Loblolly with Grass", New Dictionary(Of String, Double) From {{"Low", 1.5}, {"Moderate", 3.8}, {"Heavy", 5.9}}},
        {"10-Corn", New Dictionary(Of String, Double) From {{"Low", 3.1}, {"Moderate", 4.7}, {"Heavy", 6.2}}},
        {"11-Cotton", New Dictionary(Of String, Double) From {{"Low", 0.8}, {"Moderate", 1.1}, {"Heavy", 1.5}}},
        {"12-Rice", New Dictionary(Of String, Double) From {{"Low", 2.5}, {"Moderate", 3.7}, {"Heavy", 4.9}}},
        {"13-Soybean", New Dictionary(Of String, Double) From {{"Low", 2.9}, {"Moderate", 4.3}, {"Heavy", 5.7}}},
        {"14-Wheat", New Dictionary(Of String, Double) From {{"Low", 0.9}, {"Moderate", 1.4}, {"Heavy", 1.9}}}
    }

        If fuelValues.ContainsKey(cTypx) AndAlso fuelValues(cTypx).ContainsKey(cLoad) Then
            Return fuelValues(cTypx)(cLoad)
        Else
            Return 0 ' or some default value or action in case of an unknown cTypx/cLoad
        End If
    End Function


    ''' <summary>
    ''' Main Smoke Guidelines Calculation Code
    ''' </summary>
    ''' <param name="xCatDay">INTEGER: 1-5, Category Day</param>
    ''' <param name="xDistance">DOUBLE: Distance to Target</param>
    ''' <returns>INTEGER: represents the total tons allowed for an airshed.</returns>
    Public Function smpCalc(ByRef xCatDay As Integer, ByRef xDistance As Double)
        Select Case xCatDay
            Case 1
                Return 0
            Case 2
                Select Case xDistance
                    Case 0 To 0.19
                        Return 0
                    Case 0.2 To 4.9
                        Return 488
                    Case 5 To 9.9
                        Return 1000
                    Case 10 To 19.9
                        Return 1840
                    Case > 20
                        Return 2880
                    Case Else
                        Exit Select
                End Select
            Case 3
                Select Case xDistance
                    Case 0 To 0.19
                        Return 0
                    Case 0.2 To 4.9
                        Return 560
                    Case 5 To 9.9
                        Return 1200
                    Case 10 To 19.9
                        Return 2240
                    Case > 20
                        Return 3280
                    Case Else
                        Exit Select
                End Select
            Case 4
                Select Case xDistance
                    Case 0 To 0.19
                        Return 0
                    Case 0.2 To 4.9
                        Return 720
                    Case 5 To 9.9
                        Return 1840
                    Case 10 To 19.9
                        Return 4200
                    Case > 20
                        Return 6400
                    Case Else
                        Exit Select
                End Select
            Case 5
                Select Case xDistance
                    Case 0 To 0.19
                        Return 0
                    Case 0.2 To 4.9
                        Return 1280
                    Case 5 To 9.9
                        Return 3200
                    Case 10 To 19.9
                        Return 7200
                    Case > 20
                        Return 11600
                    Case Else
                        Exit Select
                End Select
            Case Else
                Exit Select
        End Select
    End Function

    ''' <summary>
    ''' Check Logfile directory and file locations
    ''' </summary>
    ''' <returns>NA</returns>
    Public Function ChkLocations() As Boolean
        Dim DirName As String
        DirName = "C:\SMTOOLZ\"

        Try
            Dim f As Boolean
            f = My.Computer.FileSystem.DirectoryExists(DirName)
            If f = False Then
                My.Computer.FileSystem.CreateDirectory(DirName)
                My.Computer.FileSystem.WriteAllText(DirName & "\elog.txt", "", False)
                My.Computer.FileSystem.WriteAllText(DirName & "\slog.txt", "", False)
                My.Computer.FileSystem.CreateDirectory(DirName & "\Sessions\")
            End If
            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try


        Try
            Dim e, s, a As Boolean
            e = My.Computer.FileSystem.FileExists(DirName & "\elog.txt")
            s = My.Computer.FileSystem.FileExists(DirName & "\slog.txt")
            a = My.Computer.FileSystem.DirectoryExists(DirName & "\Sessions\")

            If e = False Then
                My.Computer.FileSystem.WriteAllText(DirName & "\elog.txt", "", False)
            End If
            If s = False Then
                My.Computer.FileSystem.WriteAllText(DirName & "\slog.txt", "", False)
            End If
            If a = False Then
                My.Computer.FileSystem.CreateDirectory(DirName & "\Sessions\")
            End If
            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try


    End Function

    ''' <summary>
    ''' Probability of Ignition Calculator
    ''' </summary>
    ''' <param name="xshad">Shading as a percentage</param>
    ''' <param name="xdry">Dry Bulb Temperature</param>
    ''' <param name="xfdfm">Fine Dead Fuel Moisture or 1hr FM</param>
    ''' <returns>INTEGER: as a percentage</returns>
    Public Function ProIgnCalc(ByVal xshad As Integer, ByVal xdry As Integer, ByVal xfdfm As Integer)
        Select Case xshad
            Case 1 To 10
                Select Case xdry
                    Case 1 To 39
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 40 To 49
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 50 To 59
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 60 To 69
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 70 To 79
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 80 To 89
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 90 To 99
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 100 To 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 60
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 40
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case Is > 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 100
                            Case 4
                                Return 90
                            Case 5
                                Return 80
                            Case 6
                                Return 70
                            Case 7
                                Return 60
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 40
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 30
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 20
                            Case 17
                                Return 10
                        End Select
                End Select
            Case 11 To 50
                Select Case xdry
                    Case 1 To 39
                        Select Case xfdfm
                            Case 2
                                Return 80
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 50
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 30
                            Case 9
                                Return 30
                            Case 10
                                Return 20
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 10
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 40 To 49
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 50 To 59
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 60 To 69
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 70 To 79
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 80 To 89
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 90 To 99
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 100 To 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 40
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case Is > 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 100
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 60
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 40
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 20
                            Case 17
                                Return 10
                        End Select
                End Select
            Case 51 To 90
                Select Case xdry
                    Case 1 To 39
                        Select Case xfdfm
                            Case 2
                                Return 80
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 50
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 30
                            Case 9
                                Return 30
                            Case 10
                                Return 20
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 10
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 40 To 49
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 50
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 30
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 50 To 59
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 60 To 69
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 70 To 79
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 80 To 89
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 90 To 99
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 100 To 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case Is > 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 40
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                End Select
            Case Is > 90
                Select Case xdry
                    Case 1 To 39
                        Select Case xfdfm
                            Case 2
                                Return 80
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 50
                            Case 6
                                Return 40
                            Case 7
                                Return 40
                            Case 8
                                Return 30
                            Case 9
                                Return 30
                            Case 10
                                Return 20
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 10
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 40 To 49
                        Select Case xfdfm
                            Case 2
                                Return 80
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 50
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 30
                            Case 9
                                Return 30
                            Case 10
                                Return 20
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 10
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 50 To 59
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 70
                            Case 4
                                Return 60
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 60 To 69
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 70 To 79
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 40
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 20
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 10
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 80 To 89
                        Select Case xfdfm
                            Case 2
                                Return 90
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 50
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 30
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 90 To 99
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 80
                            Case 4
                                Return 70
                            Case 5
                                Return 60
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 10
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case 100 To 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 40
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 20
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                    Case Is > 109
                        Select Case xfdfm
                            Case 2
                                Return 100
                            Case 3
                                Return 90
                            Case 4
                                Return 80
                            Case 5
                                Return 70
                            Case 6
                                Return 60
                            Case 7
                                Return 50
                            Case 8
                                Return 50
                            Case 9
                                Return 40
                            Case 10
                                Return 30
                            Case 11
                                Return 30
                            Case 12
                                Return 30
                            Case 13
                                Return 20
                            Case 14
                                Return 20
                            Case 15
                                Return 20
                            Case 16
                                Return 10
                            Case 17
                                Return 10
                        End Select
                End Select
        End Select
    End Function

    ''' <summary>
    ''' Retrieves Registry Key Value
    ''' </summary>
    ''' <param name="keyValue">Key Value STRING</param>
    ''' <returns>Registry Key Value</returns>
    Public Function GetMyKey(keyValue As String)
        Dim readValue As String
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SMTOOLZ\", keyValue, Nothing)
        Return readValue
    End Function

    ''' <summary>
    ''' Sets Registry Key Value
    ''' </summary>
    ''' <param name="keySub">SubKey name STRING</param>
    ''' <param name="keyValue">Key Value STRING</param>
    ''' <returns>NA</returns>
    Public Function SetMyKey(keySub As String, keyValue As String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SMTOOLZ\", keySub, keyValue)
    End Function

    ''' <summary>
    ''' Generates a random string of characters
    ''' </summary>
    ''' <param name="length">INTEGER: length of characters to generate</param>
    ''' <returns>a random string of characters</returns>
    Public Function grs(ByRef length As Integer) As String
        Randomize()
        Dim ac As String
        ac = "123456789"
        Dim i As Integer
        For i = 1 To length
            grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
        Next
        Return grs
    End Function

    ''' <summary>
    ''' Session Log
    ''' </summary>
    ''' <param name="TTL">Title of section</param>
    ''' <param name="MSG">Message to write into log file</param>
    ''' <returns>NA</returns>
    Public Function SESLog(TTL As String, MSG As String)
        Dim LC As String = GetMyKey("CurSes")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(LC, True)
        file.WriteLine(Date.Now & "===" & TTL & "===" & vbCrLf & MSG & vbCrLf)
        file.Close()
    End Function

    ''' <summary>
    ''' Error Log
    ''' </summary>
    ''' <param name="MSG">Message to write into log file</param>
    ''' <param name="code">Unique ID</param>
    ''' <returns>NA</returns>
    Public Function ERRlog(code As String, MSG As String)
        Dim LC As String = GetMyKey("ELOG")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(LC, True)
        file.WriteLine(Date.Now & "===" & code & "===" & vbCrLf & MSG & vbCrLf)
        file.Close()
    End Function

    ''' <summary>
    ''' Low Visibility Occurence Risk Index
    ''' </summary>
    ''' <param name="xRelativeHumidity">Relative Humidity</param>
    ''' <param name="xDispersionIndex">Dispersion Index</param>
    ''' <returns>INTEGER: 1-10 that depicts the LVORI value.</returns>
    Public Function LVORI_day(xRelativeHumidity As Integer, xDispersionIndex As Integer)
        Select Case xRelativeHumidity
            Case 0 To 55
                Select Case xDispersionIndex
                    Case 1 To 30
                        Return 2
                    Case Is > 30
                        Return 1
                End Select
            Case 56 To 59
                Select Case xDispersionIndex
                    Case 1 To 8
                        Return 3
                    Case 9 To 30
                        Return 2
                    Case Is > 31
                        Return 1
                End Select
            Case 60 To 64
                Select Case xDispersionIndex
                    Case 1 To 10
                        Return 3
                    Case 11 To 30
                        Return 2
                    Case Is > 31
                        Return 1
                End Select
            Case 65 To 69
                Select Case xDispersionIndex
                    Case 1
                        Return 4
                    Case 2 To 40
                        Return 2
                    Case Is > 41
                        Return 1
                End Select
            Case 70 To 74
                Select Case xDispersionIndex
                    Case 1
                        Return 4
                    Case Is > 2
                        Return 3
                End Select
            Case 75 To 79
                Select Case xDispersionIndex
                    Case 1 To 16
                        Return 4
                    Case Is > 17
                        Return 3
                End Select
            Case 80 To 82
                Select Case xDispersionIndex
                    Case 1
                        Return 6
                    Case 2 To 4
                        Return 5
                    Case 5 To 16
                        Return 4
                    Case Is > 17
                        Return 3
                End Select
            Case 83 To 85
                Select Case xDispersionIndex
                    Case 1
                        Return 6
                    Case 2 To 6
                        Return 5
                    Case Is > 7
                        Return 4
                End Select
            Case 86 To 88
                Select Case xDispersionIndex
                    Case 1 To 4
                        Return 6
                    Case 5 To 12
                        Return 5
                    Case Is > 13
                        Return 4
                End Select
            Case 89 To 91
                Select Case xDispersionIndex
                    Case 1 To 2
                        Return 7
                    Case 3 To 6
                        Return 6
                    Case 7 To 16
                        Return 5
                    Case Is > 17
                        Return 4
                End Select
            Case 92 To 94
                Select Case xDispersionIndex
                    Case 1
                        Return 8
                    Case 2
                        Return 7
                    Case 3 To 10
                        Return 6
                    Case 11 To 25
                        Return 5
                    Case Is > 26
                        Return 4
                End Select
            Case 95 To 97
                Select Case xDispersionIndex
                    Case 1
                        Return 9
                    Case 2 To 4
                        Return 8
                    Case 5 To 6
                        Return 7
                    Case 7 To 12
                        Return 6
                    Case 13 To 25
                        Return 5
                    Case Is > 26
                        Return 4
                End Select
            Case Is > 97
                Select Case xDispersionIndex
                    Case 1 To 2
                        Return 10
                    Case 3 To 6
                        Return 9
                    Case 7 To 10
                        Return 8
                    Case 11 To 12
                        Return 7
                    Case 13 To 25
                        Return 5
                    Case Is > 26
                        Return 4
                End Select
        End Select
    End Function

    ''' <summary>
    ''' Counts the number of files in the session log directory
    ''' </summary>
    ''' <returns>INTEGER</returns>
    Public Function CTFD()
        Dim sld As String = GetMyKey("SESS")
        Dim d As New System.IO.DirectoryInfo(sld)
        Dim intFiles As Integer
        intFiles = d.GetFiles.GetUpperBound(0) + 1
        Dim CountyString As Integer
        CountyString = intFiles + 1
        Return CountyString
    End Function

    ''' <summary>
    ''' Returns the size of the file (in bytes) converts to proper form
    ''' </summary>
    ''' <param name="lgt">length of byte to convert</param>
    ''' <returns>STRING that shows the proper length (1024 bytes > 1 MB)</returns>
    Public Function finSize(lgt As Long)
        Dim sizetype As String
        If lgt < 1000 Then
            sizetype = " Bytes"
        Else
            If lgt < 1000000000 Then
                If lgt < 1000000 Then
                    sizetype = " KBytes"
                    lgt = lgt / 1000
                Else
                    sizetype = " MBytes"
                    lgt = lgt / 1000000
                End If
            Else
                sizetype = " GBytes"
            End If
        End If
        Return lgt & sizetype
    End Function

    ''' <summary>
    ''' Gets the size of a folder (all files in folder)
    ''' </summary>
    ''' <param name="DirPath">Directory Path</param>
    ''' <param name="IncludeSubFolders">Boolean</param>
    ''' <returns>LONG</returns>
    Public Function GetFolderSize(ByVal DirPath As String, Optional IncludeSubFolders As Boolean = True) As Long
        Try
            Dim lngDirSize As Long
            Dim objFileInfo As FileInfo
            Dim objDir As DirectoryInfo = New DirectoryInfo(DirPath)
            Dim objSubFolder As DirectoryInfo

            For Each objFileInfo In objDir.GetFiles()
                lngDirSize += objFileInfo.Length
            Next

            If IncludeSubFolders Then
                For Each objSubFolder In objDir.GetDirectories()
                    lngDirSize += GetFolderSize(objSubFolder.FullName)
                Next
            End If

            Return lngDirSize
        Catch ex As Exception
            ERRlog("1XKI8X17", ex.Message) ' ERROR LOG CODE
        End Try
    End Function

    ''' <summary>
    ''' Merge all the text files in a directory
    ''' </summary>
    ''' <param name="xPath">Path to all the text files</param>
    ''' <param name="xFileName">file name</param>
    ''' <returns>NA</returns>
    Public Function MergeAllTextFiles(xPath As String, xFileName As String)
        Dim Paths() As String = Directory.GetFiles(xPath, "*.txt")
        For Each Path As String In Paths
            File.AppendAllText(xFileName, File.ReadAllText(Path), Encoding.Default)
        Next
    End Function


    Public Function CountyToDistrict(CountyString As String)

        If CountyString.Contains("Ashley") Or CountyString.Contains("Bradley") Or CountyString.Contains("Calhoun") Or CountyString.Contains("Chicot") _
            Or CountyString.Contains("Cleveland") Or CountyString.Contains("Desha") Or CountyString.Contains("Drew") Or CountyString.Contains("Jefferson") _
            Or CountyString.Contains("Lincoln") Then
            Return 1
        ElseIf CountyString.Contains("Howard") Or CountyString.Contains("Little River") Or CountyString.Contains("Montgomery") Or CountyString.Contains("Pike") _
            Or CountyString.Contains("Polk") Or CountyString.Contains("Scott") Or CountyString.Contains("Sevier") Or CountyString.Contains("Yell") Then
            Return 2
        ElseIf CountyString.Contains("Arkansas") Or CountyString.Contains("Clay") Or CountyString.Contains("Craighead") Or CountyString.Contains("Crittenden") _
            Or CountyString.Contains("Cross") Or CountyString.Contains("Greene") Or CountyString.Contains("Jackson") Or CountyString.Contains("Lee") _
            Or CountyString.Contains("Lonoke") Or CountyString.Contains("Mississippi") Or CountyString.Contains("Monroe") Or CountyString.Contains("Phillips") _
            Or CountyString.Contains("Poinsett") Or CountyString.Contains("Prairie") Or CountyString.Contains("St Francis") Or CountyString.Contains("Woodruff") Then
            Return 3
        ElseIf CountyString.Contains("Columbia") Or CountyString.Contains("Hempstead") Or CountyString.Contains("Lafayette") Or CountyString.Contains("Miller") _
            Or CountyString.Contains("Nevada") Or CountyString.Contains("Ouachita") Or CountyString.Contains("Union") Then
            Return 4
        ElseIf CountyString.Contains("Clark") Or CountyString.Contains("Dallas") Or CountyString.Contains("Garland") Or CountyString.Contains("Grant") _
            Or CountyString.Contains("Hot Spring") Or CountyString.Contains("Saline") Then
            Return 5
        ElseIf CountyString.Contains("Benton") Or CountyString.Contains("Boone") Or CountyString.Contains("Carroll") Or CountyString.Contains("Crawford") _
            Or CountyString.Contains("Franklin") Or CountyString.Contains("Johnson") Or CountyString.Contains("Logan") Or CountyString.Contains("Madison") _
            Or CountyString.Contains("Newton") Or CountyString.Contains("Pope") Or CountyString.Contains("Sebastian") Or CountyString.Contains("Washington") Then
            Return 6
        ElseIf CountyString.Contains("Cleburne") Or CountyString.Contains("Conway") Or CountyString.Contains("Faulkner") Or CountyString.Contains("Perry") _
            Or CountyString.Contains("Pulaski") Or CountyString.Contains("Van Buren") Or CountyString.Contains("White") Then
            Return 7
        ElseIf CountyString.Contains("Baxter") Or CountyString.Contains("Fulton") Or CountyString.Contains("Independence") Or CountyString.Contains("Izard") _
            Or CountyString.Contains("Lawrence") Or CountyString.Contains("Marion") Or CountyString.Contains("Randolph") Or CountyString.Contains("Searcy") _
            Or CountyString.Contains("Sharp") Or CountyString.Contains("Stone") Then
            Return 8
        Else
            Return 0
        End If


    End Function


    ''' <summary>
    ''' Copy an ACCDB file and log the event
    ''' </summary>
    ''' <param name="StartFolder">The folder that contains the file you want to COPY FROM!</param>
    ''' <param name="ArchiveFolder">The folder that you want to copy the file to.</param>
    ''' <param name="mnFile">the name of the file in the StartFolder that will be copied.</param>
    ''' <param name="Dname">The PREFIX of the new file name (Prefix)_YYYY_MM_DD.accdb</param>
    ''' <returns></returns>
    Function CopyFile(StartFolder As String, ArchiveFolder As String, mnFile As String, Dname As String)
        Dim logFileName As String = "CopyLog.txt" ' Log file name
        Dim logFilePath As String = Path.Combine(ArchiveFolder, logFileName)
        ' Create the full path for the source and destination files
        Dim sourceFilePath As String = Path.Combine(StartFolder, mnFile)
        ' Get the current date in the desired format (Year, Month, Day)
        Dim currentDate As DateTime = DateTime.Now
        Dim destinationFileName As String = Dname & "_" & currentDate.Year & "_" &
                                            currentDate.Month.ToString("D2") & "_" &
                                            currentDate.Day.ToString("D2") & ".accdb"
        Dim destinationFilePath As String = Path.Combine(ArchiveFolder, destinationFileName)
        Try
            ' Copy the file to the archive folder with the new name
            File.Copy(sourceFilePath, destinationFilePath, True) ' True to overwrite if it already exists
            Console.WriteLine("File copied and renamed successfully to: " & destinationFileName)

            ' Log the date, time, and filename to the log file
            Dim logEntry As String = DateTime.Now.ToString() & ": Copied '" & mnFile & "' to '" & destinationFileName & "'"
            File.AppendAllText(logFilePath, logEntry & Environment.NewLine)


        Catch ex As Exception

        End Try
    End Function



    ''' <summary>
    ''' Validate and format a date string
    ''' </summary>
    ''' <param name="dateString"></param>
    ''' <returns></returns>
    Private Function ValidateAndFormatDate(dateString As String) As String
        Dim parsedDate As DateTime

        ' Try to parse the input date string
        If DateTime.TryParse(dateString, parsedDate) Then
            ' If successful, format it to the desired format (e.g., "MM/dd/yyyy")
            Return parsedDate.ToString("MM/dd/yyyy")
        Else
            ' If parsing fails, return an empty string or a specific message
            'MessageBox.Show("Please enter a valid date in the format MM/dd/yyyy.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End If
    End Function





End Class
