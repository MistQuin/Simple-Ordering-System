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
        SplitContainer1 = New SplitContainer()
        txtCivilStatus = New TextBox()
        txtAge = New TextBox()
        btnClear = New Button()
        btnExit = New Button()
        btnConfirm = New Button()
        txtName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        btnBack = New Button()
        btnPay = New Button()
        Label17 = New Label()
        txtPayment = New TextBox()
        pnlPricing = New Panel()
        txtTotalPrice = New TextBox()
        Label16 = New Label()
        txtPromoDiscount = New TextBox()
        txtBasePrice = New TextBox()
        txtSeniorDiscount = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        btnCompute = New Button()
        pnlMenu = New Panel()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        txtTurkeyAmount = New TextBox()
        txtDuckAmount = New TextBox()
        txtChickenAmount = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        pnlCustomerInformation = New Panel()
        Label5 = New Label()
        txtDisplayCivilStatus = New TextBox()
        txtDisplayName = New TextBox()
        txtDisplayAge = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        pnlPricing.SuspendLayout()
        pnlMenu.SuspendLayout()
        pnlCustomerInformation.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.FromArgb(CByte(236), CByte(227), CByte(210))
        SplitContainer1.Panel1.Controls.Add(PictureBox3)
        SplitContainer1.Panel1.Controls.Add(PictureBox2)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(txtCivilStatus)
        SplitContainer1.Panel1.Controls.Add(txtAge)
        SplitContainer1.Panel1.Controls.Add(btnClear)
        SplitContainer1.Panel1.Controls.Add(btnExit)
        SplitContainer1.Panel1.Controls.Add(btnConfirm)
        SplitContainer1.Panel1.Controls.Add(txtName)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.FromArgb(CByte(236), CByte(227), CByte(210))
        SplitContainer1.Panel2.Controls.Add(btnBack)
        SplitContainer1.Panel2.Controls.Add(btnPay)
        SplitContainer1.Panel2.Controls.Add(Label17)
        SplitContainer1.Panel2.Controls.Add(txtPayment)
        SplitContainer1.Panel2.Controls.Add(pnlPricing)
        SplitContainer1.Panel2.Controls.Add(btnCompute)
        SplitContainer1.Panel2.Controls.Add(pnlMenu)
        SplitContainer1.Panel2.Controls.Add(pnlCustomerInformation)
        SplitContainer1.Size = New Size(753, 667)
        SplitContainer1.SplitterDistance = 353
        SplitContainer1.TabIndex = 0
        ' 
        ' txtCivilStatus
        ' 
        txtCivilStatus.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtCivilStatus.Location = New Point(26, 285)
        txtCivilStatus.Name = "txtCivilStatus"
        txtCivilStatus.Size = New Size(283, 23)
        txtCivilStatus.TabIndex = 11
        ' 
        ' txtAge
        ' 
        txtAge.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtAge.Location = New Point(26, 226)
        txtAge.MaxLength = 3
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(283, 23)
        txtAge.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(62), CByte(124), CByte(177))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnClear.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnClear.Location = New Point(67, 479)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(195, 50)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(229), CByte(57), CByte(53))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnExit.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnExit.Location = New Point(67, 535)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(195, 50)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnConfirm.Location = New Point(67, 376)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(195, 97)
        btnConfirm.TabIndex = 7
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' txtName
        ' 
        txtName.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtName.Location = New Point(26, 169)
        txtName.Name = "txtName"
        txtName.Size = New Size(283, 23)
        txtName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label4.Location = New Point(55, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 3
        Label4.Text = "Civil Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label3.Location = New Point(55, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 21)
        Label3.TabIndex = 2
        Label3.Text = "Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label2.Location = New Point(54, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 21)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(181), CByte(101), CByte(47))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(351, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        Label1.Location = New Point(18, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(319, 32)
        Label1.TabIndex = 0
        Label1.Text = "CUSTOMER INFORMATION"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(229), CByte(57), CByte(53))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnBack.Location = New Point(24, 621)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(347, 34)
        btnBack.TabIndex = 24
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnPay.FlatStyle = FlatStyle.Flat
        btnPay.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnPay.Location = New Point(24, 560)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(347, 55)
        btnPay.TabIndex = 23
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label17.Location = New Point(25, 500)
        Label17.Name = "Label17"
        Label17.Size = New Size(65, 17)
        Label17.TabIndex = 22
        Label17.Text = "Payment:"
        ' 
        ' txtPayment
        ' 
        txtPayment.Location = New Point(25, 520)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(340, 23)
        txtPayment.TabIndex = 21
        ' 
        ' pnlPricing
        ' 
        pnlPricing.BackColor = Color.DarkSalmon
        pnlPricing.Controls.Add(PictureBox5)
        pnlPricing.Controls.Add(txtTotalPrice)
        pnlPricing.Controls.Add(Label16)
        pnlPricing.Controls.Add(txtPromoDiscount)
        pnlPricing.Controls.Add(txtBasePrice)
        pnlPricing.Controls.Add(txtSeniorDiscount)
        pnlPricing.Controls.Add(Label12)
        pnlPricing.Controls.Add(Label13)
        pnlPricing.Controls.Add(Label14)
        pnlPricing.Controls.Add(Label15)
        pnlPricing.Location = New Point(13, 345)
        pnlPricing.Name = "pnlPricing"
        pnlPricing.Size = New Size(370, 143)
        pnlPricing.TabIndex = 20
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Font = New Font("Segoe UI", 9.75F)
        txtTotalPrice.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtTotalPrice.Location = New Point(185, 108)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(173, 25)
        txtTotalPrice.TabIndex = 8
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label16.Location = New Point(27, 111)
        Label16.Name = "Label16"
        Label16.Size = New Size(70, 17)
        Label16.TabIndex = 7
        Label16.Text = "Total Price"
        ' 
        ' txtPromoDiscount
        ' 
        txtPromoDiscount.Font = New Font("Segoe UI", 9.75F)
        txtPromoDiscount.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtPromoDiscount.Location = New Point(185, 81)
        txtPromoDiscount.Name = "txtPromoDiscount"
        txtPromoDiscount.ReadOnly = True
        txtPromoDiscount.Size = New Size(173, 25)
        txtPromoDiscount.TabIndex = 6
        ' 
        ' txtBasePrice
        ' 
        txtBasePrice.Font = New Font("Segoe UI", 9.75F)
        txtBasePrice.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtBasePrice.Location = New Point(185, 26)
        txtBasePrice.Name = "txtBasePrice"
        txtBasePrice.ReadOnly = True
        txtBasePrice.Size = New Size(173, 25)
        txtBasePrice.TabIndex = 4
        ' 
        ' txtSeniorDiscount
        ' 
        txtSeniorDiscount.Font = New Font("Segoe UI", 9.75F)
        txtSeniorDiscount.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        txtSeniorDiscount.Location = New Point(185, 54)
        txtSeniorDiscount.Name = "txtSeniorDiscount"
        txtSeniorDiscount.ReadOnly = True
        txtSeniorDiscount.Size = New Size(173, 25)
        txtSeniorDiscount.TabIndex = 5
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label12.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label12.Location = New Point(27, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 17)
        Label12.TabIndex = 3
        Label12.Text = "Promo Discount"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label13.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label13.Location = New Point(27, 57)
        Label13.Name = "Label13"
        Label13.Size = New Size(103, 17)
        Label13.TabIndex = 2
        Label13.Text = "Senior Discount"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label14.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label14.Location = New Point(27, 34)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 17)
        Label14.TabIndex = 1
        Label14.Text = "Base Price"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label15.Location = New Point(31, 8)
        Label15.Name = "Label15"
        Label15.Size = New Size(64, 21)
        Label15.TabIndex = 0
        Label15.Text = "Pricing"
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.FromArgb(CByte(255), CByte(253), CByte(248))
        btnCompute.FlatStyle = FlatStyle.Flat
        btnCompute.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompute.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        btnCompute.Location = New Point(14, 304)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(370, 35)
        btnCompute.TabIndex = 20
        btnCompute.Text = "Compute"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = Color.BurlyWood
        pnlMenu.Controls.Add(PictureBox4)
        pnlMenu.Controls.Add(Label20)
        pnlMenu.Controls.Add(Label19)
        pnlMenu.Controls.Add(Label18)
        pnlMenu.Controls.Add(txtTurkeyAmount)
        pnlMenu.Controls.Add(txtDuckAmount)
        pnlMenu.Controls.Add(txtChickenAmount)
        pnlMenu.Controls.Add(Label11)
        pnlMenu.Controls.Add(Label8)
        pnlMenu.Controls.Add(Label10)
        pnlMenu.Controls.Add(Label9)
        pnlMenu.Location = New Point(14, 158)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(370, 140)
        pnlMenu.TabIndex = 19
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label20.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label20.Location = New Point(165, 98)
        Label20.Name = "Label20"
        Label20.Size = New Size(37, 17)
        Label20.TabIndex = 9
        Label20.Text = "P500"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label19.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label19.Location = New Point(165, 72)
        Label19.Name = "Label19"
        Label19.Size = New Size(37, 17)
        Label19.TabIndex = 8
        Label19.Text = "P400"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label18.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label18.Location = New Point(165, 47)
        Label18.Name = "Label18"
        Label18.Size = New Size(37, 17)
        Label18.TabIndex = 7
        Label18.Text = "P350"
        ' 
        ' txtTurkeyAmount
        ' 
        txtTurkeyAmount.Location = New Point(243, 97)
        txtTurkeyAmount.Name = "txtTurkeyAmount"
        txtTurkeyAmount.Size = New Size(114, 23)
        txtTurkeyAmount.TabIndex = 6
        ' 
        ' txtDuckAmount
        ' 
        txtDuckAmount.Location = New Point(243, 68)
        txtDuckAmount.Name = "txtDuckAmount"
        txtDuckAmount.Size = New Size(114, 23)
        txtDuckAmount.TabIndex = 5
        ' 
        ' txtChickenAmount
        ' 
        txtChickenAmount.Location = New Point(243, 42)
        txtChickenAmount.Name = "txtChickenAmount"
        txtChickenAmount.Size = New Size(114, 23)
        txtChickenAmount.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label11.Location = New Point(21, 99)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 17)
        Label11.TabIndex = 3
        Label11.Text = "Turkey "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label10.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label10.Location = New Point(21, 72)
        Label10.Name = "Label10"
        Label10.Size = New Size(38, 17)
        Label10.TabIndex = 2
        Label10.Text = "Duck"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label9.Location = New Point(21, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 17)
        Label9.TabIndex = 1
        Label9.Text = "Chicken"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(44), CByte(44), CByte(44))
        Label8.Location = New Point(31, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 21)
        Label8.TabIndex = 0
        Label8.Text = "Menu"
        ' 
        ' pnlCustomerInformation
        ' 
        pnlCustomerInformation.BackColor = Color.PeachPuff
        pnlCustomerInformation.Controls.Add(Label5)
        pnlCustomerInformation.Controls.Add(txtDisplayCivilStatus)
        pnlCustomerInformation.Controls.Add(txtDisplayName)
        pnlCustomerInformation.Controls.Add(txtDisplayAge)
        pnlCustomerInformation.Controls.Add(Label7)
        pnlCustomerInformation.Controls.Add(Label6)
        pnlCustomerInformation.Location = New Point(13, 12)
        pnlCustomerInformation.Name = "pnlCustomerInformation"
        pnlCustomerInformation.Size = New Size(370, 140)
        pnlCustomerInformation.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(11, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 10
        Label5.Text = "Name"
        ' 
        ' txtDisplayCivilStatus
        ' 
        txtDisplayCivilStatus.Location = New Point(104, 91)
        txtDisplayCivilStatus.Name = "txtDisplayCivilStatus"
        txtDisplayCivilStatus.ReadOnly = True
        txtDisplayCivilStatus.Size = New Size(252, 23)
        txtDisplayCivilStatus.TabIndex = 17
        ' 
        ' txtDisplayName
        ' 
        txtDisplayName.Location = New Point(104, 15)
        txtDisplayName.Name = "txtDisplayName"
        txtDisplayName.ReadOnly = True
        txtDisplayName.Size = New Size(254, 23)
        txtDisplayName.TabIndex = 11
        ' 
        ' txtDisplayAge
        ' 
        txtDisplayAge.Location = New Point(104, 54)
        txtDisplayAge.Name = "txtDisplayAge"
        txtDisplayAge.ReadOnly = True
        txtDisplayAge.Size = New Size(254, 23)
        txtDisplayAge.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(11, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 13
        Label7.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(11, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 20)
        Label6.TabIndex = 14
        Label6.Text = "Civil Status"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 138)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 198)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(26, 256)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(5, 9)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(25, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(6, 6)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(25, 25)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(753, 667)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "Form1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlPricing.ResumeLayout(False)
        pnlPricing.PerformLayout()
        pnlMenu.ResumeLayout(False)
        pnlMenu.PerformLayout()
        pnlCustomerInformation.ResumeLayout(False)
        pnlCustomerInformation.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDisplayCivilStatus As TextBox
    Friend WithEvents txtDisplayAge As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlPricing As Panel
    Friend WithEvents txtPromoDiscount As TextBox
    Friend WithEvents txtSeniorDiscount As TextBox
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents txtTurkeyAmount As TextBox
    Friend WithEvents txtDuckAmount As TextBox
    Friend WithEvents txtChickenAmount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlCustomerInformation As Panel
    Friend WithEvents txtCivilStatus As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
