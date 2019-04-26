Public Class Form2
    Dim sADJ, sNEW As Integer
    Dim x As New xFuels.ClassFuels

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        sADJ = 0
        sNEW = 0

        If CheckFields() = False Then
            Exit Sub
        End If

        txAvFuels.Text = x.GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
        txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
        sADJ = x.smpCalc(txCatDay.Text, txDistance.Text)
        txAllowed.Text = sADJ
        If txTotalTons.Text > sADJ Then
            txResults.Text = "Your burn will EXCEED the guidelines."
            txResults.BackColor = Color.LightPink
            sNEW = sADJ / txAvFuels.Text - 3
            txRecommend.Text = "Recommend a total burn size of: " & sNEW & " acres."
        Else
            txResults.Text = "Your burn will not exceed the guidelines."
            txResults.BackColor = Color.White
            txRecommend.Text = "R:"
        End If





    End Sub

    Function CheckFields() As Boolean
        If txBurnSize.Text = String.Empty Then
            txBurnSize.BackColor = Color.Yellow
            txBurnSize.Focus()
            Return False
        Else
            txBurnSize.BackColor = Color.White
            Return True
        End If

        If txDistance.Text = String.Empty Then
            txDistance.BackColor = Color.Yellow
            txDistance.Focus()
            Return False
        Else
            txDistance.BackColor = Color.White
            Return True
        End If

        If txCatDay.Text = String.Empty Then
            txCatDay.BackColor = Color.Yellow
            txCatDay.Focus()
            Return False
        Else
            txCatDay.BackColor = Color.White
            Return True
        End If

        If txCatDay.Text < 1 Or txCatDay.Text > 5 Then
            txCatDay.BackColor = Color.Yellow
            Return False
        Else
            txCatDay.BackColor = Color.White
            Return True
        End If

        If txFtype.SelectedIndex = -1 Then
            txFtype.BackColor = Color.Yellow
            Return False
        Else
            txFtype.BackColor = Color.White
            Return True
        End If

        If txFload.SelectedIndex = -1 Then
            txFload.BackColor = Color.Yellow
            Return False
        Else
            txFload.BackColor = Color.White
            Return True
        End If








    End Function




End Class