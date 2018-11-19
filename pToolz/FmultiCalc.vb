'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================



Imports xFuels

Public Class FmultiCalc
    Private x As New xFuels.ClassFuels

    Public Property X1 As ClassFuels
        Get
            Return x
        End Get
        Set(value As ClassFuels)
            x = value
        End Set
    End Property

    Private Sub FmultiCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class