'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================

Imports System.IO
Imports System.Text

Public Class ClassFuels

    Public Function GetAvFuels(ByVal cTypx As String, ByVal cLoad As String)
        Select Case cTypx
            Case "Shortleaf Pine with Oak"
                Select Case cLoad
                    Case Is = "Low"
                        Return 3.0
                    Case Is = "Moderate"
                        Return 4.0
                    Case Is = "Heavy"
                        Return 4.4
                    Case Else
                        Return 0
                End Select
            Case "Shortleaf Pine Regeneration"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.6
                    Case Is = "Moderate"
                        Return 3.8
                    Case Is = "Heavy"
                        Return 5.1
                    Case Else
                        Return 0
                End Select
            Case "Loblolly Pine with Oak"
                Select Case cLoad
                    Case Is = "Low"
                        Return 6.4
                    Case Is = "Moderate"
                        Return 6.8
                    Case Is = "Heavy"
                        Return 7.9
                    Case Else
                        Return 0
                End Select
            Case "Loblolly Pine Regeneration"
                Select Case cLoad
                    Case Is = "Low"
                        Return 4.4
                    Case Is = "Moderate"
                        Return 7.6
                    Case Is = "Heavy"
                        Return 8.5
                    Case Else
                        Return 0
                End Select
            Case "Hardwood Leaf Litter"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.8
                    Case Is = "Moderate"
                        Return 1.5
                    Case Is = "Heavy"
                        Return 2.5
                    Case Else
                        Return 0
                End Select
            Case "Grass or Brush"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.0
                    Case Is = "Moderate"
                        Return 3.0
                    Case Is = "Heavy"
                        Return 5.0
                    Case Else
                        Return 0
                End Select
            Case "Dispersed Slash"
                Select Case cLoad
                    Case Is = "Low"
                        Return 4.0
                    Case Is = "Moderate"
                        Return 6.0
                    Case Is = "Heavy"
                        Return 8.0
                    Case Else
                        Return 0
                End Select
            Case "Piled Debris"
                Select Case cLoad
                    Case Is = "Low"
                        Return 5.0
                    Case Is = "Moderate"
                        Return 7.5
                    Case Is = "Heavy"
                        Return 10.0
                    Case Else
                        Return 0
                End Select
            Case "Shortleaf Loblolly with Grass"
                Select Case cLoad
                    Case Is = "Low"
                        Return 1.5
                    Case Is = "Moderate"
                        Return 3.8
                    Case Is = "Heavy"
                        Return 5.9
                    Case Else
                        Return 0
                End Select
            Case "Corn"
                Select Case cLoad
                    Case Is = "Low"
                        Return 3.1
                    Case Is = "Moderate"
                        Return 4.7
                    Case Is = "Heavy"
                        Return 6.2
                    Case Else
                        Return 0
                End Select
            Case "Cotton"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.8
                    Case Is = "Moderate"
                        Return 1.1
                    Case Is = "Heavy"
                        Return 1.5
                    Case Else
                        Return 0
                End Select
            Case "Rice"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.5
                    Case Is = "Moderate"
                        Return 3.7
                    Case Is = "Heavy"
                        Return 4.9
                    Case Else
                        Return 0
                End Select
            Case "Soybean"
                Select Case cLoad
                    Case Is = "Low"
                        Return 2.9
                    Case Is = "Moderate"
                        Return 4.3
                    Case Is = "Heavy"
                        Return 5.7
                    Case Else
                        Return 0
                End Select
            Case "Wheat"
                Select Case cLoad
                    Case Is = "Low"
                        Return 0.9
                    Case Is = "Moderate"
                        Return 1.4
                    Case Is = "Heavy"
                        Return 1.9
                    Case Else
                        Return 0
                End Select
            Case Else
                Return 0
        End Select
    End Function

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
                        Return 0
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
                        Return 0
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
                        Return 0
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
                        Return 0
                End Select
            Case Else
                Return 0
        End Select
    End Function

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

    Public Function GetMyKey(keyValue As String)
        Dim readValue As String
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SMTOOLZ\", keyValue, Nothing)
        Return readValue

    End Function

    Public Function SetMyKey(keySub As String, keyValue As String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SMTOOLZ\", keySub, keyValue)
    End Function

    Public Function grs(ByRef length As Integer) As String
        Randomize()
        Dim ac As String
        ac = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim i As Integer
        For i = 1 To length
            grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
        Next
    End Function

    Public Function SESLog(TTL As String, MSG As String)
        Dim LC As String = GetMyKey("SLOG")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(LC, True)
        file.WriteLine(Date.Now & "===" & TTL & "===" & vbCrLf & MSG & vbCrLf)
        file.Close()
    End Function

    Public Function ERRlog(MSG As String, code As String)
        Dim LC As String = GetMyKey("ELOG")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(LC, True)
        file.WriteLine(Date.Now & "===" & code & "===" & vbCrLf & MSG & vbCrLf)
        file.Close()
    End Function

    Public Function LVORI_day(xRelativeHumidity As Integer, xDispersionIndex As Integer)
        Select Case xRelativeHumidity
            Case 0 To 55
                Select Case xDispersionIndex
                    Case 1 To 30
                        Return 2
                    Case Is > 30
                        Return 1
                    Case Else
                        Return 0
                End Select
            Case 56 To 59
                Select Case xDispersionIndex
                    Case 1 To 8
                        Return 3
                    Case 9 To 30
                        Return 2
                    Case Is > 31
                        Return 1
                    Case Else
                        Return 0
                End Select
            Case 60 To 64
                Select Case xDispersionIndex
                    Case 1 To 10
                        Return 3
                    Case 11 To 30
                        Return 2
                    Case Is > 31
                        Return 1
                    Case Else
                        Return 0
                End Select
            Case 65 To 69
                Select Case xDispersionIndex
                    Case 1
                        Return 4
                    Case 2 To 40
                        Return 2
                    Case Is > 41
                        Return 1
                    Case Else
                        Return 0
                End Select
            Case 70 To 74
                Select Case xDispersionIndex
                    Case 1
                        Return 4
                    Case Is > 2
                        Return 3
                    Case Else
                        Return 0
                End Select
            Case 75 To 79
                Select Case xDispersionIndex
                    Case 1 To 16
                        Return 4
                    Case Is > 17
                        Return 3
                    Case Else
                        Return 0
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
                    Case Else
                        Return 0
                End Select
            Case 83 To 85
                Select Case xDispersionIndex
                    Case 1
                        Return 6
                    Case 2 To 6
                        Return 5
                    Case Is > 7
                        Return 4
                    Case Else
                        Return 0
                End Select
            Case 86 To 88
                Select Case xDispersionIndex
                    Case 1 To 4
                        Return 6
                    Case 5 To 12
                        Return 5
                    Case Is > 13
                        Return 4
                    Case Else
                        Return 0
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
                    Case Else
                        Return 0
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
                    Case Else
                        Return 0
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
                    Case Else
                        Return 0
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
                    Case Else
                        Return 0
                End Select
            Case Else
                Return 0
        End Select
    End Function

    Public Function CTFD()
        Dim sld As String = GetMyKey("SESS")
        Dim d As New System.IO.DirectoryInfo(sld)
        Dim intFiles As Integer
        intFiles = d.GetFiles.GetUpperBound(0) + 1
        Dim cnt As Integer
        cnt = intFiles + 1
        Return cnt
    End Function

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
            ERRlog(ex.Message, "8x89XZ7") ' ERROR LOG CODE
        End Try


    End Function

    Function MergeAllTextFiles(xPath As String, xFileName As String)
        Dim Paths() As String = Directory.GetFiles(xPath, "*.txt")
        For Each Path As String In Paths
            File.AppendAllText(xFileName, File.ReadAllText(Path), Encoding.Default)
        Next
    End Function

End Class
