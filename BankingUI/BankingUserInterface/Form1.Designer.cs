namespace BankingUserInterface
{
    partial class Banking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTabBar = new System.Windows.Forms.TabControl();
            this.newAccountFirstPage = new System.Windows.Forms.TabPage();
            this.detailsTabBar = new System.Windows.Forms.TabControl();
            this.personalDetailsTab = new System.Windows.Forms.TabPage();
            this.PersonalDetailsContinueButton = new System.Windows.Forms.Button();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.AccountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirthSelector = new System.Windows.Forms.DateTimePicker();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.namePrefix = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.addressFieldTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.AddressLine2TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.PostcodeTextbox = new System.Windows.Forms.TextBox();
            this.CountyTextBox = new System.Windows.Forms.TextBox();
            this.AddressLine1TextBox = new System.Windows.Forms.TextBox();
            this.addressLine1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressLine2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityOrTown = new System.Windows.Forms.Label();
            this.AccountTransactions = new System.Windows.Forms.TabPage();
            this.AccountHolderNumberName = new System.Windows.Forms.Label();
            this.AccountHolderLabel = new System.Windows.Forms.Label();
            this.FindAccountButton = new System.Windows.Forms.Button();
            this.AccountBalanceTotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountBalanceLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.TransactionTabsBox = new System.Windows.Forms.TabControl();
            this.DepositTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.PoundSterlingDepositLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.DepositAmountPhrase = new System.Windows.Forms.Label();
            this.WithdrawTab = new System.Windows.Forms.TabPage();
            this.TransferTab = new System.Windows.Forms.TabPage();
            this.menuTabBar.SuspendLayout();
            this.newAccountFirstPage.SuspendLayout();
            this.detailsTabBar.SuspendLayout();
            this.personalDetailsTab.SuspendLayout();
            this.addressFieldTab.SuspendLayout();
            this.AccountTransactions.SuspendLayout();
            this.TransactionTabsBox.SuspendLayout();
            this.DepositTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabBar
            // 
            this.menuTabBar.Controls.Add(this.newAccountFirstPage);
            this.menuTabBar.Controls.Add(this.AccountTransactions);
            this.menuTabBar.Location = new System.Drawing.Point(0, 76);
            this.menuTabBar.Name = "menuTabBar";
            this.menuTabBar.SelectedIndex = 0;
            this.menuTabBar.Size = new System.Drawing.Size(638, 344);
            this.menuTabBar.TabIndex = 0;
            // 
            // newAccountFirstPage
            // 
            this.newAccountFirstPage.Controls.Add(this.detailsTabBar);
            this.newAccountFirstPage.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountFirstPage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.newAccountFirstPage.Location = new System.Drawing.Point(4, 22);
            this.newAccountFirstPage.Name = "newAccountFirstPage";
            this.newAccountFirstPage.Padding = new System.Windows.Forms.Padding(3);
            this.newAccountFirstPage.Size = new System.Drawing.Size(630, 318);
            this.newAccountFirstPage.TabIndex = 0;
            this.newAccountFirstPage.Text = "New Account";
            this.newAccountFirstPage.UseVisualStyleBackColor = true;
            // 
            // detailsTabBar
            // 
            this.detailsTabBar.Controls.Add(this.personalDetailsTab);
            this.detailsTabBar.Controls.Add(this.addressFieldTab);
            this.detailsTabBar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTabBar.Location = new System.Drawing.Point(0, 3);
            this.detailsTabBar.Name = "detailsTabBar";
            this.detailsTabBar.SelectedIndex = 0;
            this.detailsTabBar.Size = new System.Drawing.Size(630, 312);
            this.detailsTabBar.TabIndex = 12;
            // 
            // personalDetailsTab
            // 
            this.personalDetailsTab.BackColor = System.Drawing.Color.White;
            this.personalDetailsTab.Controls.Add(this.PersonalDetailsContinueButton);
            this.personalDetailsTab.Controls.Add(this.accountTypeLabel);
            this.personalDetailsTab.Controls.Add(this.AccountTypeComboBox);
            this.personalDetailsTab.Controls.Add(this.DateOfBirthSelector);
            this.personalDetailsTab.Controls.Add(this.LastNameTextBox);
            this.personalDetailsTab.Controls.Add(this.dateOfBirth);
            this.personalDetailsTab.Controls.Add(this.TitleTextBox);
            this.personalDetailsTab.Controls.Add(this.namePrefix);
            this.personalDetailsTab.Controls.Add(this.firstName);
            this.personalDetailsTab.Controls.Add(this.middleName);
            this.personalDetailsTab.Controls.Add(this.lastName);
            this.personalDetailsTab.Controls.Add(this.FirstNameTextBox);
            this.personalDetailsTab.Controls.Add(this.MiddleNameTextBox);
            this.personalDetailsTab.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalDetailsTab.Location = new System.Drawing.Point(4, 24);
            this.personalDetailsTab.Name = "personalDetailsTab";
            this.personalDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalDetailsTab.Size = new System.Drawing.Size(622, 284);
            this.personalDetailsTab.TabIndex = 0;
            this.personalDetailsTab.Text = "Personal Details";
            // 
            // PersonalDetailsContinueButton
            // 
            this.PersonalDetailsContinueButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.PersonalDetailsContinueButton.ForeColor = System.Drawing.Color.White;
            this.PersonalDetailsContinueButton.Location = new System.Drawing.Point(307, 247);
            this.PersonalDetailsContinueButton.Name = "PersonalDetailsContinueButton";
            this.PersonalDetailsContinueButton.Size = new System.Drawing.Size(78, 30);
            this.PersonalDetailsContinueButton.TabIndex = 13;
            this.PersonalDetailsContinueButton.Text = "Continue";
            this.PersonalDetailsContinueButton.UseVisualStyleBackColor = false;
            this.PersonalDetailsContinueButton.Click += new System.EventHandler(this.PersonalDetailsContinueButton_Click);
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(138, 221);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(92, 15);
            this.accountTypeLabel.TabIndex = 11;
            this.accountTypeLabel.Text = "Account type";
            // 
            // AccountTypeComboBox
            // 
            this.AccountTypeComboBox.FormattingEnabled = true;
            this.AccountTypeComboBox.Items.AddRange(new object[] {
            "Credit Account",
            "Current Account",
            "Forex Account",
            "ISA Savings Account",
            "Savings Account"});
            this.AccountTypeComboBox.Location = new System.Drawing.Point(232, 218);
            this.AccountTypeComboBox.Name = "AccountTypeComboBox";
            this.AccountTypeComboBox.Size = new System.Drawing.Size(221, 23);
            this.AccountTypeComboBox.TabIndex = 10;
            // 
            // DateOfBirthSelector
            // 
            this.DateOfBirthSelector.Location = new System.Drawing.Point(125, 174);
            this.DateOfBirthSelector.Name = "DateOfBirthSelector";
            this.DateOfBirthSelector.Size = new System.Drawing.Size(171, 22);
            this.DateOfBirthSelector.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(125, 137);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(16, 174);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(98, 15);
            this.dateOfBirth.TabIndex = 7;
            this.dateOfBirth.Text = "* Date of birth";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(125, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(171, 22);
            this.TitleTextBox.TabIndex = 3;
            // 
            // namePrefix
            // 
            this.namePrefix.AutoSize = true;
            this.namePrefix.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePrefix.ForeColor = System.Drawing.Color.RoyalBlue;
            this.namePrefix.Location = new System.Drawing.Point(16, 12);
            this.namePrefix.Name = "namePrefix";
            this.namePrefix.Size = new System.Drawing.Size(33, 15);
            this.namePrefix.TabIndex = 6;
            this.namePrefix.Text = "Title";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.firstName.Location = new System.Drawing.Point(6, 53);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(83, 15);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "* First name";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.middleName.Location = new System.Drawing.Point(6, 95);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(101, 15);
            this.middleName.TabIndex = 1;
            this.middleName.Text = "Middle name(s)";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lastName.Location = new System.Drawing.Point(16, 133);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(82, 15);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "* Last name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(125, 53);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(125, 92);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.MiddleNameTextBox.TabIndex = 4;
            // 
            // addressFieldTab
            // 
            this.addressFieldTab.Controls.Add(this.button3);
            this.addressFieldTab.Controls.Add(this.AddressLine2TextBox);
            this.addressFieldTab.Controls.Add(this.CityTextBox);
            this.addressFieldTab.Controls.Add(this.PostcodeTextbox);
            this.addressFieldTab.Controls.Add(this.CountyTextBox);
            this.addressFieldTab.Controls.Add(this.AddressLine1TextBox);
            this.addressFieldTab.Controls.Add(this.addressLine1);
            this.addressFieldTab.Controls.Add(this.label2);
            this.addressFieldTab.Controls.Add(this.addressLine2);
            this.addressFieldTab.Controls.Add(this.label1);
            this.addressFieldTab.Controls.Add(this.cityOrTown);
            this.addressFieldTab.Location = new System.Drawing.Point(4, 24);
            this.addressFieldTab.Name = "addressFieldTab";
            this.addressFieldTab.Padding = new System.Windows.Forms.Padding(3);
            this.addressFieldTab.Size = new System.Drawing.Size(622, 284);
            this.addressFieldTab.TabIndex = 1;
            this.addressFieldTab.Text = "Address Fields";
            this.addressFieldTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(216, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "Create Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.FindAccountButton_Click);
            // 
            // AddressLine2TextBox
            // 
            this.AddressLine2TextBox.Location = new System.Drawing.Point(133, 53);
            this.AddressLine2TextBox.Name = "AddressLine2TextBox";
            this.AddressLine2TextBox.Size = new System.Drawing.Size(152, 22);
            this.AddressLine2TextBox.TabIndex = 16;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(133, 89);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(152, 22);
            this.CityTextBox.TabIndex = 15;
            // 
            // PostcodeTextbox
            // 
            this.PostcodeTextbox.Location = new System.Drawing.Point(133, 152);
            this.PostcodeTextbox.Name = "PostcodeTextbox";
            this.PostcodeTextbox.Size = new System.Drawing.Size(152, 22);
            this.PostcodeTextbox.TabIndex = 14;
            // 
            // CountyTextBox
            // 
            this.CountyTextBox.Location = new System.Drawing.Point(133, 120);
            this.CountyTextBox.Name = "CountyTextBox";
            this.CountyTextBox.Size = new System.Drawing.Size(152, 22);
            this.CountyTextBox.TabIndex = 13;
            // 
            // AddressLine1TextBox
            // 
            this.AddressLine1TextBox.Location = new System.Drawing.Point(133, 16);
            this.AddressLine1TextBox.Name = "AddressLine1TextBox";
            this.AddressLine1TextBox.Size = new System.Drawing.Size(152, 22);
            this.AddressLine1TextBox.TabIndex = 12;
            // 
            // addressLine1
            // 
            this.addressLine1.AutoSize = true;
            this.addressLine1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLine1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addressLine1.Location = new System.Drawing.Point(6, 16);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(108, 15);
            this.addressLine1.TabIndex = 7;
            this.addressLine1.Text = "* Address line 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "* Postcode";
            // 
            // addressLine2
            // 
            this.addressLine2.AutoSize = true;
            this.addressLine2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLine2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addressLine2.Location = new System.Drawing.Point(17, 56);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(97, 15);
            this.addressLine2.TabIndex = 8;
            this.addressLine2.Text = "Address line 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "* County";
            // 
            // cityOrTown
            // 
            this.cityOrTown.AutoSize = true;
            this.cityOrTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOrTown.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cityOrTown.Location = new System.Drawing.Point(39, 89);
            this.cityOrTown.Name = "cityOrTown";
            this.cityOrTown.Size = new System.Drawing.Size(75, 16);
            this.cityOrTown.TabIndex = 9;
            this.cityOrTown.Text = "* City/Town";
            // 
            // AccountTransactions
            // 
            this.AccountTransactions.Controls.Add(this.AccountHolderNumberName);
            this.AccountTransactions.Controls.Add(this.AccountHolderLabel);
            this.AccountTransactions.Controls.Add(this.FindAccountButton);
            this.AccountTransactions.Controls.Add(this.AccountBalanceTotalLabel);
            this.AccountTransactions.Controls.Add(this.label3);
            this.AccountTransactions.Controls.Add(this.AccountBalanceLabel);
            this.AccountTransactions.Controls.Add(this.accountNumberTextBox);
            this.AccountTransactions.Controls.Add(this.AccountNumberLabel);
            this.AccountTransactions.Controls.Add(this.TransactionTabsBox);
            this.AccountTransactions.Location = new System.Drawing.Point(4, 22);
            this.AccountTransactions.Name = "AccountTransactions";
            this.AccountTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.AccountTransactions.Size = new System.Drawing.Size(630, 318);
            this.AccountTransactions.TabIndex = 1;
            this.AccountTransactions.Text = "Account Transactions";
            this.AccountTransactions.UseVisualStyleBackColor = true;
            // 
            // AccountHolderNumberName
            // 
            this.AccountHolderNumberName.AutoSize = true;
            this.AccountHolderNumberName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountHolderNumberName.Location = new System.Drawing.Point(135, 55);
            this.AccountHolderNumberName.Name = "AccountHolderNumberName";
            this.AccountHolderNumberName.Size = new System.Drawing.Size(152, 15);
            this.AccountHolderNumberName.TabIndex = 1;
            this.AccountHolderNumberName.Text = "Account holder name";
            // 
            // AccountHolderLabel
            // 
            this.AccountHolderLabel.AutoSize = true;
            this.AccountHolderLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountHolderLabel.Location = new System.Drawing.Point(18, 54);
            this.AccountHolderLabel.Name = "AccountHolderLabel";
            this.AccountHolderLabel.Size = new System.Drawing.Size(110, 15);
            this.AccountHolderLabel.TabIndex = 7;
            this.AccountHolderLabel.Text = "Account Holder:";
            this.AccountHolderLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // FindAccountButton
            // 
            this.FindAccountButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.FindAccountButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAccountButton.ForeColor = System.Drawing.Color.White;
            this.FindAccountButton.Location = new System.Drawing.Point(498, 8);
            this.FindAccountButton.Name = "FindAccountButton";
            this.FindAccountButton.Size = new System.Drawing.Size(115, 31);
            this.FindAccountButton.TabIndex = 6;
            this.FindAccountButton.Text = "Find Account";
            this.FindAccountButton.UseVisualStyleBackColor = false;
            this.FindAccountButton.Click += new System.EventHandler(this.PersonalDetailsContinueButton_Click);
            // 
            // AccountBalanceTotalLabel
            // 
            this.AccountBalanceTotalLabel.AutoSize = true;
            this.AccountBalanceTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountBalanceTotalLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalanceTotalLabel.Location = new System.Drawing.Point(541, 55);
            this.AccountBalanceTotalLabel.Name = "AccountBalanceTotalLabel";
            this.AccountBalanceTotalLabel.Size = new System.Drawing.Size(37, 17);
            this.AccountBalanceTotalLabel.TabIndex = 5;
            this.AccountBalanceTotalLabel.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 4;
            // 
            // AccountBalanceLabel
            // 
            this.AccountBalanceLabel.AutoSize = true;
            this.AccountBalanceLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalanceLabel.Location = new System.Drawing.Point(388, 55);
            this.AccountBalanceLabel.Name = "AccountBalanceLabel";
            this.AccountBalanceLabel.Size = new System.Drawing.Size(112, 15);
            this.AccountBalanceLabel.TabIndex = 3;
            this.AccountBalanceLabel.Text = "Account Balance";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(197, 14);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(253, 20);
            this.accountNumberTextBox.TabIndex = 2;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberLabel.Location = new System.Drawing.Point(57, 16);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(113, 15);
            this.AccountNumberLabel.TabIndex = 1;
            this.AccountNumberLabel.Text = "Account Number";
            // 
            // TransactionTabsBox
            // 
            this.TransactionTabsBox.Controls.Add(this.DepositTab);
            this.TransactionTabsBox.Controls.Add(this.WithdrawTab);
            this.TransactionTabsBox.Controls.Add(this.TransferTab);
            this.TransactionTabsBox.Location = new System.Drawing.Point(3, 89);
            this.TransactionTabsBox.Name = "TransactionTabsBox";
            this.TransactionTabsBox.SelectedIndex = 0;
            this.TransactionTabsBox.Size = new System.Drawing.Size(624, 226);
            this.TransactionTabsBox.TabIndex = 0;
            // 
            // DepositTab
            // 
            this.DepositTab.Controls.Add(this.label4);
            this.DepositTab.Controls.Add(this.PoundSterlingDepositLabel);
            this.DepositTab.Controls.Add(this.textBox6);
            this.DepositTab.Controls.Add(this.DepositAmountPhrase);
            this.DepositTab.Location = new System.Drawing.Point(4, 22);
            this.DepositTab.Name = "DepositTab";
            this.DepositTab.Padding = new System.Windows.Forms.Padding(3);
            this.DepositTab.Size = new System.Drawing.Size(616, 200);
            this.DepositTab.TabIndex = 0;
            this.DepositTab.Text = "Deposit";
            this.DepositTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // PoundSterlingDepositLabel
            // 
            this.PoundSterlingDepositLabel.AutoSize = true;
            this.PoundSterlingDepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundSterlingDepositLabel.Location = new System.Drawing.Point(412, 33);
            this.PoundSterlingDepositLabel.Name = "PoundSterlingDepositLabel";
            this.PoundSterlingDepositLabel.Size = new System.Drawing.Size(19, 20);
            this.PoundSterlingDepositLabel.TabIndex = 2;
            this.PoundSterlingDepositLabel.Text = "£";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(437, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 20);
            this.textBox6.TabIndex = 1;
            // 
            // DepositAmountPhrase
            // 
            this.DepositAmountPhrase.AutoSize = true;
            this.DepositAmountPhrase.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmountPhrase.Location = new System.Drawing.Point(6, 35);
            this.DepositAmountPhrase.Name = "DepositAmountPhrase";
            this.DepositAmountPhrase.Size = new System.Drawing.Size(391, 15);
            this.DepositAmountPhrase.TabIndex = 0;
            this.DepositAmountPhrase.Text = "Please enter the amount that you would like to deposit:";
            // 
            // WithdrawTab
            // 
            this.WithdrawTab.Location = new System.Drawing.Point(4, 22);
            this.WithdrawTab.Name = "WithdrawTab";
            this.WithdrawTab.Padding = new System.Windows.Forms.Padding(3);
            this.WithdrawTab.Size = new System.Drawing.Size(616, 200);
            this.WithdrawTab.TabIndex = 1;
            this.WithdrawTab.Text = "Withdraw";
            this.WithdrawTab.UseVisualStyleBackColor = true;
            // 
            // TransferTab
            // 
            this.TransferTab.Location = new System.Drawing.Point(4, 22);
            this.TransferTab.Name = "TransferTab";
            this.TransferTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransferTab.Size = new System.Drawing.Size(616, 200);
            this.TransferTab.TabIndex = 2;
            this.TransferTab.Text = "Transfer";
            this.TransferTab.UseVisualStyleBackColor = true;
            // 
            // Banking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuTabBar);
            this.Name = "Banking";
            this.Text = "Acme Banking Corporation";
            this.menuTabBar.ResumeLayout(false);
            this.newAccountFirstPage.ResumeLayout(false);
            this.detailsTabBar.ResumeLayout(false);
            this.personalDetailsTab.ResumeLayout(false);
            this.personalDetailsTab.PerformLayout();
            this.addressFieldTab.ResumeLayout(false);
            this.addressFieldTab.PerformLayout();
            this.AccountTransactions.ResumeLayout(false);
            this.AccountTransactions.PerformLayout();
            this.TransactionTabsBox.ResumeLayout(false);
            this.DepositTab.ResumeLayout(false);
            this.DepositTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabBar;
        private System.Windows.Forms.TabPage newAccountFirstPage;
        private System.Windows.Forms.TabPage AccountTransactions;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label cityOrTown;
        private System.Windows.Forms.Label addressLine2;
        private System.Windows.Forms.Label addressLine1;
        private System.Windows.Forms.Label namePrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl detailsTabBar;
        private System.Windows.Forms.TabPage personalDetailsTab;
        private System.Windows.Forms.TabPage addressFieldTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.TextBox AddressLine2TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox PostcodeTextbox;
        private System.Windows.Forms.TextBox CountyTextBox;
        private System.Windows.Forms.TextBox AddressLine1TextBox;
        private System.Windows.Forms.Button PersonalDetailsContinueButton;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.ComboBox AccountTypeComboBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthSelector;
        private System.Windows.Forms.TabControl TransactionTabsBox;
        private System.Windows.Forms.TabPage DepositTab;
        private System.Windows.Forms.TabPage WithdrawTab;
        private System.Windows.Forms.TabPage TransferTab;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.Label AccountBalanceLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AccountBalanceTotalLabel;
        private System.Windows.Forms.Button FindAccountButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label AccountHolderLabel;
        private System.Windows.Forms.Label AccountHolderNumberName;
        private System.Windows.Forms.Label PoundSterlingDepositLabel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label DepositAmountPhrase;
        private System.Windows.Forms.Label label4;
    }
}

