Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFicaNum.Text = ""
        lblFedNum.Text = ""
        lblStateNum.Text = ""
        lblNetPaycheckNum.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFicaNum.Text = ""
        lblFedNum.Text = ""
        lblStateNum.Text = ""
        lblNetPaycheckNum.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String = txtGrossPay.Text
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Dim cdecFica As Decimal = 0.0765D
        Dim cdecFed As Decimal = 0.22D
        Dim cdecState As Decimal = 0.04D

        If IsNumeric(strIncome) Then

            decIncome = Convert.ToDecimal(strIncome)

            decFica = (decIncome * cdecFica)
            decFederal = (decIncome * cdecFed)
            decState = (decIncome * cdecState)

            decNet = decIncome - decFica - decFederal - decState

            lblFicaNum.Text = decFica.ToString("C")
            lblFedNum.Text = decFederal.ToString("C")
            lblStateNum.Text = decState.ToString("C")

            lblNetPaycheckNum.Text = decNet.ToString("C")

        Else

            MsgBox("Please enter a positive decimal", , "Invalid Entry Error")

        End If

    End Sub
End Class
