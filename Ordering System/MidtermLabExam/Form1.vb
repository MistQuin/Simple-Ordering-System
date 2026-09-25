Public Class Form1
    Dim chicken As Integer
    Dim duck As Integer
    Dim turkey As Integer
    Dim basePrice As Integer
    Dim seniorDiscount As Integer
    Dim promoDiscount As Integer
    Dim totalPrice As Integer
    Dim payment As Integer
    Dim change As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.Text = "Restaurant System"
        SplitContainer1.Panel2.Enabled = False
        txtPayment.Text = 0
        btnPay.Enabled = False
        txtPayment.Enabled = False
        SplitContainer1.Panel1.BackColor = Color.FromArgb(236, 227, 210)
        txtChickenAmount.Text = 0
        txtDuckAmount.Text = 0
        txtTurkeyAmount.Text = 0
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtName.Text.Trim = "" AndAlso txtAge.Text.Trim = "" AndAlso txtCivilStatus.Text.Trim = "" Then
            MessageBox.Show("Please enter the customer's name, age and civil status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAge.Text.Trim = "" AndAlso txtCivilStatus.Text.Trim = "" Then
            MessageBox.Show("Please enter the customer's age or civil status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtName.Text.Trim = "" Then
            MessageBox.Show("Please enter the customer's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtAge.Text.Trim = "" OrElse Not IsNumeric(txtAge.Text) Then
            MessageBox.Show("Please enter the valid customer's age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtCivilStatus.Text.Trim = "" Then
            MessageBox.Show("Please enter the customer's civil status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            txtDisplayName.Text = txtName.Text
            txtDisplayAge.Text = txtAge.Text
            txtDisplayCivilStatus.Text = txtCivilStatus.Text
            SplitContainer1.Panel1.Enabled = False
            SplitContainer1.Panel2.Enabled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAge.Clear()
        txtCivilStatus.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        chicken = Val(txtChickenAmount.Text) * 350
        duck = Val(txtDuckAmount.Text) * 400
        turkey = Val(txtTurkeyAmount.Text) * 500
        basePrice = chicken + duck + turkey
        seniorDiscount = basePrice * 0.12
        promoDiscount = 200

        If Val(txtChickenAmount.Text) = 0 AndAlso Val(txtDuckAmount.Text) = 0 AndAlso Val(txtTurkeyAmount.Text) = 0 OrElse Not IsNumeric(txtChickenAmount.Text) OrElse Not IsNumeric(txtDuckAmount.Text) OrElse Not IsNumeric(txtTurkeyAmount.Text) Then
            MessageBox.Show("Please put atleast one amount on the following menu or valid number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChickenAmount.Text = 0
            txtDuckAmount.Text = 0
            txtTurkeyAmount.Text = 0
        Else
            Dim Senior As Boolean = Val(txtAge.Text) >= 60
            Dim Promo As Boolean = basePrice > 1000
            If Senior And Promo Then
                If seniorDiscount > promoDiscount Then
                    txtBasePrice.Text = basePrice.ToString("C")
                    txtSeniorDiscount.Text = seniorDiscount.ToString("C")
                    txtPromoDiscount.Text = 0.ToString("C")
                    totalPrice = basePrice - seniorDiscount
                    txtTotalPrice.Text = totalPrice.ToString("C")
                    btnPay.Enabled = True
                    txtPayment.Enabled = True
                Else
                    txtBasePrice.Text = basePrice.ToString("C")
                    txtSeniorDiscount.Text = 0.ToString("C")
                    txtPromoDiscount.Text = promoDiscount.ToString("C")
                    totalPrice = basePrice - promoDiscount
                    txtTotalPrice.Text = totalPrice.ToString("C")
                    btnPay.Enabled = True
                    txtPayment.Enabled = True
                End If
            ElseIf Senior Then
                txtBasePrice.Text = basePrice.ToString("C")
                txtSeniorDiscount.Text = seniorDiscount.ToString("C")
                txtPromoDiscount.Text = 0.ToString("C")
                totalPrice = basePrice - seniorDiscount
                txtTotalPrice.Text = totalPrice.ToString("C")
                btnPay.Enabled = True
                txtPayment.Enabled = True
            ElseIf Promo Then
                txtBasePrice.Text = basePrice.ToString("C")
                txtSeniorDiscount.Text = 0.ToString("C")
                txtPromoDiscount.Text = promoDiscount.ToString("C")
                totalPrice = basePrice - promoDiscount
                txtTotalPrice.Text = totalPrice.ToString("C")
                btnPay.Enabled = True
                txtPayment.Enabled = True
            Else
                txtBasePrice.Text = basePrice.ToString("C")
                txtSeniorDiscount.Text = 0.ToString("C")
                txtPromoDiscount.Text = 0.ToString("C")
                totalPrice = basePrice
                txtTotalPrice.Text = totalPrice.ToString("C")
                btnPay.Enabled = True
                txtPayment.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SplitContainer1.Panel1.Enabled = True
        txtName.Clear()
        txtAge.Clear()
        txtCivilStatus.Clear()
        SplitContainer1.Panel2.Enabled = False
        txtDisplayName.Clear()
        txtDisplayAge.Clear()
        txtDisplayCivilStatus.Clear()
        txtChickenAmount.Clear()
        txtDuckAmount.Clear()
        txtTurkeyAmount.Clear()
        txtBasePrice.Clear()
        txtSeniorDiscount.Clear()
        txtPromoDiscount.Clear()
        txtTotalPrice.Clear()
        txtPayment.Clear()
        txtChickenAmount.Text = 0
        txtDuckAmount.Text = 0
        txtTurkeyAmount.Text = 0
        txtPayment.Text = 0
        txtPayment.Enabled = False
        btnPay.Enabled = False
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        payment = Val(txtPayment.Text)
        If payment = 0 OrElse Not IsNumeric(txtPayment.Text) Then
            MessageBox.Show("The entered amount is 0 or invalid number", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            txtPayment.Text = 0
        ElseIf payment < totalPrice Then
            MessageBox.Show("Money is not enough for the payment", "Alert", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            txtPayment.Text = 0
        Else
            change = payment - totalPrice
            MessageBox.Show("Successful Payment " & change.ToString("C"), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
