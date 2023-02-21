Imports System.Globalization

Class MainWindow
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Loaded
        lblECoS.Content = ""
        txtNights.Clear()
        txtNights.Focus()

    End Sub

    Private Sub txtNights_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtNights.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        lblECoS.Content = ""
        txtNights.Clear()
        txtNights.Focus()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As RoutedEventArgs) Handles btnCost.Click
        Const cdecCostPerNight As Decimal = 79D
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal

        strNumNights = txtNights.Text
        Try
            intNumNights = Convert.ToInt32(strNumNights)
            decTotalCost = intNumNights * cdecCostPerNight
            lblECoS.Content = decTotalCost.ToString("C", New CultureInfo("en-US"))
        Catch ex As FormatException
            lblECoS.Content = "NaN"
            txtNights.Clear()
            txtNights.Focus()

        End Try
    End Sub
End Class
