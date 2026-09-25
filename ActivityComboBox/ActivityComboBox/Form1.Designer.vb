<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        cmbMunicipality = New ComboBox()
        cmbCity = New ComboBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        lblDiscount = New Label()
        lblTotal = New Label()
        lblPrice = New Label()
        lblResult = New Label()
        nudBluePhones = New NumericUpDown()
        nudPinkPhones = New NumericUpDown()
        btnReceipt = New Button()
        pnlCustomerInformation = New Panel()
        Label11 = New Label()
        txtZipCode = New TextBox()
        pnlOrderDetails = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Label12 = New Label()
        pnlResult = New Panel()
        Label13 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        CType(nudBluePhones, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPinkPhones, ComponentModel.ISupportInitialize).BeginInit()
        pnlCustomerInformation.SuspendLayout()
        pnlOrderDetails.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        pnlResult.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label1.Location = New Point(40, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 19)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label2.Location = New Point(40, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 19)
        Label2.TabIndex = 1
        Label2.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label3.Location = New Point(40, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 19)
        Label3.TabIndex = 2
        Label3.Text = "City"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label4.Location = New Point(40, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 19)
        Label4.TabIndex = 3
        Label4.Text = "Municipality"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label5.Location = New Point(24, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 19)
        Label5.TabIndex = 4
        Label5.Text = "Blue Phones Ordered"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label6.Location = New Point(309, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 19)
        Label6.TabIndex = 5
        Label6.Text = "Pink Phones Ordered"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(74), CByte(59), CByte(42))
        Label7.Location = New Point(39, 14)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 19)
        Label7.TabIndex = 6
        Label7.Text = "Discount:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(74), CByte(59), CByte(42))
        Label8.Location = New Point(23, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 19)
        Label8.TabIndex = 7
        Label8.Text = "Total Phones"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(74), CByte(59), CByte(42))
        Label9.Location = New Point(37, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 19)
        Label9.TabIndex = 8
        Label9.Text = "Total Price"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label10.Location = New Point(40, 204)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 19)
        Label10.TabIndex = 9
        Label10.Text = "Zip Code"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(181), CByte(101), CByte(47))
        btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(CByte(181), CByte(101), CByte(47))
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        btnCalculate.Location = New Point(793, 419)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(137, 58)
        btnCalculate.TabIndex = 10
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(140), CByte(122), CByte(92))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.FromArgb(CByte(140), CByte(122), CByte(92))
        btnClear.Location = New Point(644, 420)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(137, 57)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(140), CByte(122), CByte(92))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(140), CByte(122), CByte(92))
        btnExit.Location = New Point(943, 537)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(137, 65)
        btnExit.TabIndex = 12
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' cmbMunicipality
        ' 
        cmbMunicipality.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbMunicipality.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbMunicipality.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMunicipality.Font = New Font("Century Gothic", 9.75F)
        cmbMunicipality.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        cmbMunicipality.FormattingEnabled = True
        cmbMunicipality.Location = New Point(166, 164)
        cmbMunicipality.Name = "cmbMunicipality"
        cmbMunicipality.Size = New Size(408, 25)
        cmbMunicipality.TabIndex = 13
        ' 
        ' cmbCity
        ' 
        cmbCity.AutoCompleteMode = AutoCompleteMode.Suggest
        cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbCity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCity.Font = New Font("Century Gothic", 9.75F)
        cmbCity.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        cmbCity.FormattingEnabled = True
        cmbCity.Items.AddRange(New Object() {"Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Pampanga", "Tarlac", "Zambales"})
        cmbCity.Location = New Point(166, 129)
        cmbCity.Name = "cmbCity"
        cmbCity.Size = New Size(408, 25)
        cmbCity.TabIndex = 14
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Century Gothic", 9.75F)
        txtName.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        txtName.Location = New Point(166, 60)
        txtName.Name = "txtName"
        txtName.Size = New Size(408, 23)
        txtName.TabIndex = 15
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Century Gothic", 9.75F)
        txtAddress.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        txtAddress.Location = New Point(166, 95)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(408, 23)
        txtAddress.TabIndex = 16
        ' 
        ' lblDiscount
        ' 
        lblDiscount.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblDiscount.ForeColor = Color.FromArgb(CByte(122), CByte(106), CByte(84))
        lblDiscount.Location = New Point(3, 60)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(150, 19)
        lblDiscount.TabIndex = 20
        lblDiscount.Text = "2%"
        lblDiscount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(122), CByte(106), CByte(84))
        lblTotal.Location = New Point(3, 60)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(143, 19)
        lblTotal.TabIndex = 21
        lblTotal.Text = "4"
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPrice
        ' 
        lblPrice.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblPrice.ForeColor = Color.FromArgb(CByte(122), CByte(106), CByte(84))
        lblPrice.Location = New Point(10, 50)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(142, 38)
        lblPrice.TabIndex = 22
        lblPrice.Text = "10000"
        lblPrice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResult.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        lblResult.Location = New Point(45, 61)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(85, 20)
        lblResult.TabIndex = 23
        lblResult.Text = "RESULT ALL"
        ' 
        ' nudBluePhones
        ' 
        nudBluePhones.Font = New Font("Century Gothic", 9.75F)
        nudBluePhones.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        nudBluePhones.Location = New Point(24, 98)
        nudBluePhones.Name = "nudBluePhones"
        nudBluePhones.Size = New Size(254, 23)
        nudBluePhones.TabIndex = 24
        ' 
        ' nudPinkPhones
        ' 
        nudPinkPhones.Font = New Font("Century Gothic", 9.75F)
        nudPinkPhones.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        nudPinkPhones.Location = New Point(309, 98)
        nudPinkPhones.Name = "nudPinkPhones"
        nudPinkPhones.Size = New Size(245, 23)
        nudPinkPhones.TabIndex = 25
        ' 
        ' btnReceipt
        ' 
        btnReceipt.BackColor = Color.FromArgb(CByte(181), CByte(101), CByte(47))
        btnReceipt.FlatAppearance.BorderColor = Color.FromArgb(CByte(181), CByte(101), CByte(47))
        btnReceipt.FlatStyle = FlatStyle.Flat
        btnReceipt.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReceipt.ForeColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        btnReceipt.Location = New Point(943, 419)
        btnReceipt.Name = "btnReceipt"
        btnReceipt.Size = New Size(137, 58)
        btnReceipt.TabIndex = 26
        btnReceipt.Text = "Print Receipt"
        btnReceipt.UseVisualStyleBackColor = False
        ' 
        ' pnlCustomerInformation
        ' 
        pnlCustomerInformation.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        pnlCustomerInformation.BorderStyle = BorderStyle.FixedSingle
        pnlCustomerInformation.Controls.Add(Label11)
        pnlCustomerInformation.Controls.Add(txtZipCode)
        pnlCustomerInformation.Controls.Add(txtAddress)
        pnlCustomerInformation.Controls.Add(Label1)
        pnlCustomerInformation.Controls.Add(Label2)
        pnlCustomerInformation.Controls.Add(Label3)
        pnlCustomerInformation.Controls.Add(Label4)
        pnlCustomerInformation.Controls.Add(txtName)
        pnlCustomerInformation.Controls.Add(Label10)
        pnlCustomerInformation.Controls.Add(cmbCity)
        pnlCustomerInformation.Controls.Add(cmbMunicipality)
        pnlCustomerInformation.Location = New Point(32, 12)
        pnlCustomerInformation.Name = "pnlCustomerInformation"
        pnlCustomerInformation.Size = New Size(598, 250)
        pnlCustomerInformation.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(62), CByte(46), CByte(34))
        Label11.Image = CType(resources.GetObject("Label11.Image"), Image)
        Label11.ImageAlign = ContentAlignment.MiddleLeft
        Label11.Location = New Point(11, 13)
        Label11.Name = "Label11"
        Label11.Size = New Size(298, 28)
        Label11.TabIndex = 28
        Label11.Text = "     Customer Information"
        ' 
        ' txtZipCode
        ' 
        txtZipCode.Font = New Font("Century Gothic", 9.75F)
        txtZipCode.ForeColor = Color.FromArgb(CByte(92), CByte(78), CByte(63))
        txtZipCode.Location = New Point(166, 200)
        txtZipCode.Name = "txtZipCode"
        txtZipCode.Size = New Size(112, 23)
        txtZipCode.TabIndex = 27
        ' 
        ' pnlOrderDetails
        ' 
        pnlOrderDetails.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        pnlOrderDetails.BorderStyle = BorderStyle.FixedSingle
        pnlOrderDetails.Controls.Add(Label15)
        pnlOrderDetails.Controls.Add(Label14)
        pnlOrderDetails.Controls.Add(Panel5)
        pnlOrderDetails.Controls.Add(Panel4)
        pnlOrderDetails.Controls.Add(Panel3)
        pnlOrderDetails.Controls.Add(Label12)
        pnlOrderDetails.Controls.Add(Label5)
        pnlOrderDetails.Controls.Add(Label6)
        pnlOrderDetails.Controls.Add(nudPinkPhones)
        pnlOrderDetails.Controls.Add(nudBluePhones)
        pnlOrderDetails.Location = New Point(32, 278)
        pnlOrderDetails.Name = "pnlOrderDetails"
        pnlOrderDetails.Size = New Size(598, 324)
        pnlOrderDetails.TabIndex = 28
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold)
        Label15.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label15.Location = New Point(-21, 258)
        Label15.Name = "Label15"
        Label15.Size = New Size(628, 15)
        Label15.TabIndex = 30
        Label15.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label14.Location = New Point(11, 282)
        Label14.Name = "Label14"
        Label14.Size = New Size(578, 30)
        Label14.TabIndex = 33
        Label14.Text = "Discount applies based on quantity ordered — 2% below 99 units, 5% at 100 units, 10% at 500 units." & vbCrLf & "12% VAT is applied to the total price."
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(236), CByte(227), CByte(210))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(lblDiscount)
        Panel5.Location = New Point(396, 146)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(158, 100)
        Panel5.TabIndex = 32
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(236), CByte(227), CByte(210))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(lblTotal)
        Panel4.Location = New Point(224, 146)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(151, 100)
        Panel4.TabIndex = 31
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(236), CByte(227), CByte(210))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblPrice)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(37, 146)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(164, 100)
        Panel3.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(62), CByte(46), CByte(34))
        Label12.Image = CType(resources.GetObject("Label12.Image"), Image)
        Label12.ImageAlign = ContentAlignment.MiddleLeft
        Label12.Location = New Point(11, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(199, 28)
        Label12.TabIndex = 29
        Label12.Text = "     Order Details"
        ' 
        ' pnlResult
        ' 
        pnlResult.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        pnlResult.BorderStyle = BorderStyle.FixedSingle
        pnlResult.Controls.Add(Label13)
        pnlResult.Controls.Add(lblResult)
        pnlResult.Location = New Point(644, 12)
        pnlResult.Name = "pnlResult"
        pnlResult.Size = New Size(436, 393)
        pnlResult.TabIndex = 29
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(62), CByte(46), CByte(34))
        Label13.Image = CType(resources.GetObject("Label13.Image"), Image)
        Label13.ImageAlign = ContentAlignment.MiddleLeft
        Label13.Location = New Point(14, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(135, 28)
        Label13.TabIndex = 29
        Label13.Text = "     Receipt"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(62), CByte(46), CByte(34))
        Label16.Image = CType(resources.GetObject("Label16.Image"), Image)
        Label16.ImageAlign = ContentAlignment.MiddleLeft
        Label16.Location = New Point(644, 537)
        Label16.Name = "Label16"
        Label16.Size = New Size(207, 28)
        Label16.TabIndex = 30
        Label16.Text = "     PlayTime App"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold)
        Label17.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label17.Location = New Point(644, 519)
        Label17.Name = "Label17"
        Label17.Size = New Size(444, 15)
        Label17.TabIndex = 34
        Label17.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label18.Location = New Point(652, 572)
        Label18.Name = "Label18"
        Label18.Size = New Size(154, 16)
        Label18.TabIndex = 34
        Label18.Text = "playtimeapp@gmail.com"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.FromArgb(CByte(110), CByte(90), CByte(69))
        Label19.Location = New Point(652, 589)
        Label19.Name = "Label19"
        Label19.Size = New Size(98, 16)
        Label19.TabIndex = 35
        Label19.Text = "+639123456789"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1115, 614)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label16)
        Controls.Add(pnlResult)
        Controls.Add(pnlOrderDetails)
        Controls.Add(pnlCustomerInformation)
        Controls.Add(btnReceipt)
        Controls.Add(btnCalculate)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(Label17)
        Name = "Form1"
        Text = "Form1"
        CType(nudBluePhones, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPinkPhones, ComponentModel.ISupportInitialize).EndInit()
        pnlCustomerInformation.ResumeLayout(False)
        pnlCustomerInformation.PerformLayout()
        pnlOrderDetails.ResumeLayout(False)
        pnlOrderDetails.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        pnlResult.ResumeLayout(False)
        pnlResult.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbMunicipality As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents nudBluePhones As NumericUpDown
    Friend WithEvents nudPinkPhones As NumericUpDown
    Friend WithEvents btnReceipt As Button
    Friend WithEvents pnlCustomerInformation As Panel
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents pnlOrderDetails As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlResult As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label

End Class
