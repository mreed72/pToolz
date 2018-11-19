Public Class FimgViewer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub FimgViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Set the forms text to be empty and the controlbox to false
    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result.ToInt32 = HTCLIENT Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub



End Class