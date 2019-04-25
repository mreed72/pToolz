Public Class FrmSafeChecklist
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PageSetupDialog1.Document = PrintDocument1

        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintForm1.PrinterSettings = PageSetupDialog1.PrinterSettings
            If PrintForm1.PrinterSettings.IsValid Then
                PrintForm1.Print()
            End If
        End If
    End Sub
End Class