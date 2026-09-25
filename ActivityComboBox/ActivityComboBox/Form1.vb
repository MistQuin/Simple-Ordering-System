Public Class Form1
    Dim price As Integer
    Dim discount As Double
    Dim saleTax As Double
    Dim priceWithTax As Double
    Dim discountedAmount As Double
    Dim finalPrice As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Playtime App"
        Me.BackColor = Color.FromArgb(243, 239, 230)
        lblResult.Text = String.Empty
        lblPrice.Text = String.Empty
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAddress.Clear()
        txtZipCode.Clear()
        cmbCity.SelectedIndex = -1
        cmbMunicipality.SelectedIndex = -1
        nudBluePhones.Value = 0
        nudPinkPhones.Value = 0
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
        lblPrice.Text = String.Empty
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim blueqty As Integer = nudBluePhones.Value
        Dim pinkqty As Integer = nudPinkPhones.Value
        Dim blueprize As Integer = 1000
        Dim pinkprize As Integer = 1200

        Dim totalqty = blueqty + pinkqty
        lblTotal.Text = totalqty.ToString

        price = (blueqty * blueprize) + (pinkqty * pinkprize)
        lblPrice.Text = "PHP " & price.ToString("N2")

        If totalqty >= 500 Then
            discount = 0.1
            lblDiscount.Text = "10%"
        ElseIf totalqty >= 100 Then
            discount = 0.05
            lblDiscount.Text = "5%"
        Else
            discount = 0.02
            lblDiscount.Text = "2%"
        End If

        saleTax = (price * 0.12)
        priceWithTax = price + saleTax
        discountedAmount = priceWithTax * discount
        finalPrice = priceWithTax - discountedAmount

    End Sub

    Private Sub nudBluePhones_ValueChanged(sender As Object, e As EventArgs) Handles nudBluePhones.ValueChanged
        nudBluePhones.Maximum = Decimal.MaxValue
        nudBluePhones.Minimum = 0
    End Sub

    Private Sub nudPinkPhones_ValueChanged(sender As Object, e As EventArgs) Handles nudPinkPhones.ValueChanged
        nudPinkPhones.Maximum = Decimal.MaxValue
        nudPinkPhones.Minimum = 0
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        lblResult.Text = "Total Price (TAX Excluded): " & lblPrice.Text & vbNewLine &
                         "The sale tax was PHP " & saleTax.ToString("N2") & vbNewLine &
                         "Discount to Apply: " & lblDiscount.Text & vbNewLine &
                         "___________________________________________" & vbNewLine &
                         "Total Price (TAX INCLUDED): PHP " & priceWithTax.ToString("N2") & vbNewLine &
                         "Total Price (DISCOUNT APPLIED): PHP " & finalPrice.ToString("N2") & vbNewLine &
                         "Total Discount : PHP " & discountedAmount.ToString("N2") & vbNewLine &
                         "Customer Name: " & txtName.Text & vbNewLine &
                         "City: " & cmbCity.Text & vbNewLine &
                         "Municipality: " & cmbMunicipality.Text & vbNewLine &
                         "Zip Code: " & txtZipCode.Text & vbNewLine &
                         "___________________________________________" & vbNewLine & vbNewLine &
                         "AMOUNT TO PAY: PHP " & finalPrice.ToString("N2") & vbNewLine &
                         "___________________________________________"
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
        cmbMunicipality.Items.Clear()
        Select Case cmbCity.Text
            Case "Aurora"
                cmbMunicipality.Items.AddRange("Baler", "Casiguran", "Dilasag", "Dinalungan", "Dingalan", "Dipaculao", "Maria Aurora", "San Luis")
            Case "Bataan"
                cmbMunicipality.Items.AddRange("Abucay", "Bagac", "Balanga City", "Dinalupihan", "Hermosa", "Limay", "Mariveles", "Morong", "Orani", "Orion",
                                               "Pilar", "Samal")
            Case "Bulacan"
                cmbMunicipality.Items.AddRange("Angat", "Balagtas", "Baliwag City", "Bocaue", "Bulakan", "Bustos", "Calumpit", "Doña Remedios Trinidad", "Guiguinto",
                                               "Hagonoy", "Malolos City", "Marilao", "Meycauayan City", "Norzagaray", "Obando", "Pandi", "Paombong", "Plaridel", "Pulilan",
                                               "San Ildefonso", "San Jose del Monte City", "San Miguel", "San Rafael", "Santa Maria")
            Case "Nueva Ecija"
                cmbMunicipality.Items.AddRange("Aliaga", "Bongabon", "Cabanatuan City", "Cabiao", "Carranglan", "Cuyapo", "Gabaldon", "Gapan City", "General Mamerto Natividad",
                                               "General Tinio", "Guimba", "Jaen", "Laur", "Licab", "Llanera", "Lupao", "Nampicuan", "Palayan City", "Pantabangan", "Peñaranda", "Quezon",
                                               "Rizal", "San Antonio", "San Isidro", "San Jose City", "San Leonardo", "Santa Rosa", "Santo Domingo", "Science City of Muñoz", "Talavera",
                                               "Talugtug", "Zaragoza")
            Case "Pampanga"
                cmbMunicipality.Items.AddRange("Angeles City", "Apalit", "Arayat", "Bacolor", "Candaba", "City of San Fernando", "Floridablanca", "Guagua", "Lubao", "Mabalacat City", "Magalang",
                                               "Masantol", "Mexico", "Minalin", "Porac", "San Luis", "San Simon", "Santa Ana", "Santa Rita", "Santo Tomas", "Sasmuan")
            Case "Tarlac"
                cmbMunicipality.Items.AddRange("Anao", "Bamban", "Camiling", "Capas", "Concepcion", "Gerona", "La Paz", "Mayantoc",
                                               "Moncada", "Paniqui", "Pura", "Ramos", "San Clemente", "San Jose", "San Manuel", "Santa Ignacia",
                                               "Tarlac City", "Victoria")
            Case "Zambales"
                cmbMunicipality.Items.AddRange("Botolan", "Cabangan", "Candelaria", "Castillejos", "Iba", "Masinloc", "Olongapo City", "Palauig", "San Antonio", "San Felipe", "San Marcelino", "San Narciso",
                                               "Santa Cruz", "Subic")
        End Select
    End Sub
End Class
