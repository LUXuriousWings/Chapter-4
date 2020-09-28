Public Class YMCA_Calculator

    Private Sub YMCA_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total.Visible = False
    End Sub

    Private Sub Btn_calculate_Click(sender As Object, e As EventArgs) Handles Btn_calculate.Click
        'Declaration
        Dim strName As String
        Dim intTotalDay As Integer
        Dim intTotalWeeks As Integer
        Dim intTotalMonth As Integer
        Dim intTotalYear As Integer
        Dim intTotalHours As Integer
        'Intialization
        strName = Name_tb.Text
        intTotalYear = ((C_year.Text - B_year.Text) * 365)
        intTotalMonth = (30 * (C_month.Text - B_month.Text))
        intTotalDay = (C_day.Text - B_day.Text)
        intTotalWeeks = ((intTotalYear + intTotalMonth + intTotalDay) / 7)
        intTotalHours = intTotalWeeks * 3

        'Total.Text = intTotalYear
        Total.Text = strName & " " & intTotalHours & " Hours"
        Total.Visible = True
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        'Clears the textboxes
        Name_tb.Clear()
        B_day.Clear()
        B_month.Clear()
        B_year.Clear()
        C_day.Clear()
        C_month.Clear()
        C_year.Clear()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click
        'Closes the program
        Me.Close()
    End Sub

End Class
