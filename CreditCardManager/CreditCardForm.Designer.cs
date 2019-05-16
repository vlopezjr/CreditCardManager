namespace CreditCardManager
{
    partial class CreditCardForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardForm));
            this.dgvCreditCard = new System.Windows.Forms.DataGridView();
            this.cCKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreferredCard = new System.Windows.Forms.DataGridViewImageColumn();
            this.crCardTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCardNoDecrypted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCardExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardHolderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCardStreetNbrZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crCardZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCCForm = new System.Windows.Forms.Panel();
            this.txtExpDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.chkPref = new System.Windows.Forms.CheckBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rfvCardHolderName = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.rfvStreetNbr = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.regexZipCode = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.cvCardNumber = new Genghis.Windows.Forms.CustomValidator();
            this.cvExpDate = new Genghis.Windows.Forms.CustomValidator();
            this.containerValidator = new Genghis.Windows.Forms.ContainerValidator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardBindingSource)).BeginInit();
            this.panelCCForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCardHolderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvStreetNbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvCardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCreditCard
            // 
            this.dgvCreditCard.AllowUserToAddRows = false;
            this.dgvCreditCard.AllowUserToDeleteRows = false;
            this.dgvCreditCard.AllowUserToResizeRows = false;
            this.dgvCreditCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCreditCard.AutoGenerateColumns = false;
            this.dgvCreditCard.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCKeyDataGridViewTextBoxColumn,
            this.PreferredCard,
            this.crCardTypeNameDataGridViewTextBoxColumn,
            this.CrCardNoDecrypted,
            this.CrCardNo,
            this.crCardExpDataGridViewTextBoxColumn,
            this.cardHolderNameDataGridViewTextBoxColumn,
            this.crCardStreetNbrZipDataGridViewTextBoxColumn,
            this.crCardZipCodeDataGridViewTextBoxColumn});
            this.dgvCreditCard.DataSource = this.creditCardBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreditCard.Location = new System.Drawing.Point(8, 39);
            this.dgvCreditCard.MultiSelect = false;
            this.dgvCreditCard.Name = "dgvCreditCard";
            this.dgvCreditCard.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditCard.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreditCard.RowHeadersVisible = false;
            this.dgvCreditCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCard.Size = new System.Drawing.Size(602, 172);
            this.dgvCreditCard.TabIndex = 0;
            this.dgvCreditCard.SelectionChanged += new System.EventHandler(this.dgvCreditCard_SelectionChanged);
            // 
            // cCKeyDataGridViewTextBoxColumn
            // 
            this.cCKeyDataGridViewTextBoxColumn.DataPropertyName = "CCKey";
            this.cCKeyDataGridViewTextBoxColumn.HeaderText = "CCKey";
            this.cCKeyDataGridViewTextBoxColumn.Name = "cCKeyDataGridViewTextBoxColumn";
            this.cCKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCKeyDataGridViewTextBoxColumn.Visible = false;
            this.cCKeyDataGridViewTextBoxColumn.Width = 45;
            // 
            // PreferredCard
            // 
            this.PreferredCard.HeaderText = "";
            this.PreferredCard.Name = "PreferredCard";
            this.PreferredCard.ReadOnly = true;
            this.PreferredCard.Width = 35;
            // 
            // crCardTypeNameDataGridViewTextBoxColumn
            // 
            this.crCardTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CrCardTypeName";
            this.crCardTypeNameDataGridViewTextBoxColumn.HeaderText = "Type";
            this.crCardTypeNameDataGridViewTextBoxColumn.Name = "crCardTypeNameDataGridViewTextBoxColumn";
            this.crCardTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.crCardTypeNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // CrCardNoDecrypted
            // 
            this.CrCardNoDecrypted.DataPropertyName = "CrCardNoDecrypted";
            this.CrCardNoDecrypted.HeaderText = "Card Number";
            this.CrCardNoDecrypted.Name = "CrCardNoDecrypted";
            this.CrCardNoDecrypted.ReadOnly = true;
            this.CrCardNoDecrypted.Visible = false;
            this.CrCardNoDecrypted.Width = 120;
            // 
            // CrCardNo
            // 
            this.CrCardNo.DataPropertyName = "CrCardNo";
            this.CrCardNo.HeaderText = "Card No";
            this.CrCardNo.Name = "CrCardNo";
            this.CrCardNo.ReadOnly = true;
            this.CrCardNo.Visible = false;
            this.CrCardNo.Width = 120;
            // 
            // crCardExpDataGridViewTextBoxColumn
            // 
            this.crCardExpDataGridViewTextBoxColumn.DataPropertyName = "CrCardExp";
            this.crCardExpDataGridViewTextBoxColumn.HeaderText = "Exp";
            this.crCardExpDataGridViewTextBoxColumn.Name = "crCardExpDataGridViewTextBoxColumn";
            this.crCardExpDataGridViewTextBoxColumn.ReadOnly = true;
            this.crCardExpDataGridViewTextBoxColumn.Width = 60;
            // 
            // cardHolderNameDataGridViewTextBoxColumn
            // 
            this.cardHolderNameDataGridViewTextBoxColumn.DataPropertyName = "CardHolderName";
            this.cardHolderNameDataGridViewTextBoxColumn.HeaderText = "Card Holder Name";
            this.cardHolderNameDataGridViewTextBoxColumn.Name = "cardHolderNameDataGridViewTextBoxColumn";
            this.cardHolderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardHolderNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // crCardStreetNbrZipDataGridViewTextBoxColumn
            // 
            this.crCardStreetNbrZipDataGridViewTextBoxColumn.DataPropertyName = "CrCardStreetNbrZip";
            this.crCardStreetNbrZipDataGridViewTextBoxColumn.HeaderText = "Street Nbr";
            this.crCardStreetNbrZipDataGridViewTextBoxColumn.Name = "crCardStreetNbrZipDataGridViewTextBoxColumn";
            this.crCardStreetNbrZipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crCardZipCodeDataGridViewTextBoxColumn
            // 
            this.crCardZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CrCardZipCode";
            this.crCardZipCodeDataGridViewTextBoxColumn.HeaderText = "Zip Code";
            this.crCardZipCodeDataGridViewTextBoxColumn.Name = "crCardZipCodeDataGridViewTextBoxColumn";
            this.crCardZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.crCardZipCodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // creditCardBindingSource
            // 
            this.creditCardBindingSource.DataSource = typeof(CreateCustomer.API.Entities.CreditCard);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Exp Date";
            // 
            // cboCardType
            // 
            this.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Location = new System.Drawing.Point(65, 10);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(86, 21);
            this.cboCardType.TabIndex = 1;
            this.cboCardType.SelectedIndexChanged += new System.EventHandler(this.cboCardType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Type";
            // 
            // panelCCForm
            // 
            this.panelCCForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCCForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCCForm.Controls.Add(this.txtExpDate);
            this.panelCCForm.Controls.Add(this.txtCardNumber);
            this.panelCCForm.Controls.Add(this.chkPref);
            this.panelCCForm.Controls.Add(this.txtZipCode);
            this.panelCCForm.Controls.Add(this.label6);
            this.panelCCForm.Controls.Add(this.txtStreetNo);
            this.panelCCForm.Controls.Add(this.label5);
            this.panelCCForm.Controls.Add(this.txtCardName);
            this.panelCCForm.Controls.Add(this.label4);
            this.panelCCForm.Controls.Add(this.label3);
            this.panelCCForm.Controls.Add(this.label2);
            this.panelCCForm.Controls.Add(this.label1);
            this.panelCCForm.Controls.Add(this.cboCardType);
            this.panelCCForm.Location = new System.Drawing.Point(8, 217);
            this.panelCCForm.Name = "panelCCForm";
            this.panelCCForm.Size = new System.Drawing.Size(602, 88);
            this.panelCCForm.TabIndex = 6;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(65, 36);
            this.txtExpDate.Mask = "00-0000";
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(86, 20);
            this.txtExpDate.TabIndex = 3;
            this.txtExpDate.TextChanged += new System.EventHandler(this.txtExpDate_TextChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(272, 8);
            this.txtCardNumber.Mask = "aaaa-aaaa-aaaa-aaaa";
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(132, 20);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // chkPref
            // 
            this.chkPref.AutoSize = true;
            this.chkPref.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPref.Location = new System.Drawing.Point(10, 66);
            this.chkPref.Name = "chkPref";
            this.chkPref.Size = new System.Drawing.Size(94, 17);
            this.chkPref.TabIndex = 7;
            this.chkPref.Text = "Preferred Card";
            this.chkPref.UseVisualStyleBackColor = true;
            this.chkPref.CheckedChanged += new System.EventHandler(this.chkPref_CheckedChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(484, 36);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(95, 20);
            this.txtZipCode.TabIndex = 6;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zip Code";
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(484, 10);
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(95, 20);
            this.txtStreetNo.TabIndex = 5;
            this.txtStreetNo.TextChanged += new System.EventHandler(this.txtStreetNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street Nbr";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(272, 36);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(132, 20);
            this.txtCardName.TabIndex = 4;
            this.txtCardName.TextChanged += new System.EventHandler(this.txtCardName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Card Holder Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Card Number";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(12, 6);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(0, 24);
            this.lblCustName.TabIndex = 14;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(459, 6);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(0, 24);
            this.lblCustID.TabIndex = 15;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnSelect);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnNew);
            this.panelButtons.Location = new System.Drawing.Point(8, 311);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(602, 52);
            this.panelButtons.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(514, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(434, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 31);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "S&elect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(98, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 31);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rfvCardHolderName
            // 
            this.rfvCardHolderName.ControlToValidate = this.txtCardName;
            this.rfvCardHolderName.ErrorMessage = "Card holder name requires a value.";
            this.rfvCardHolderName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvCardHolderName.Icon")));
            // 
            // rfvStreetNbr
            // 
            this.rfvStreetNbr.ControlToValidate = this.txtStreetNo;
            this.rfvStreetNbr.ErrorMessage = "Street Number requires a value.";
            this.rfvStreetNbr.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvStreetNbr.Icon")));
            // 
            // regexZipCode
            // 
            this.regexZipCode.ControlToValidate = this.txtZipCode;
            this.regexZipCode.ErrorMessage = "Must have a valid 5 digit zip code.";
            this.regexZipCode.Icon = ((System.Drawing.Icon)(resources.GetObject("regexZipCode.Icon")));
            this.regexZipCode.ValidationExpression = "^\\d{5}$";
            // 
            // cvCardNumber
            // 
            this.cvCardNumber.ControlToValidate = this.txtCardNumber;
            this.cvCardNumber.ErrorMessage = "Invalid credit card number. Confirm and reenter.";
            this.cvCardNumber.Icon = ((System.Drawing.Icon)(resources.GetObject("cvCardNumber.Icon")));
            this.cvCardNumber.Validating += new Genghis.Windows.Forms.CustomValidator.ValidatingEventHandler(this.cvCardNumber_Validating);
            // 
            // cvExpDate
            // 
            this.cvExpDate.ControlToValidate = this.txtExpDate;
            this.cvExpDate.ErrorMessage = "Expiration date must be a valid date in the future.";
            this.cvExpDate.Icon = ((System.Drawing.Icon)(resources.GetObject("cvExpDate.Icon")));
            this.cvExpDate.Validating += new Genghis.Windows.Forms.CustomValidator.ValidatingEventHandler(this.cvExpDate_Validating);
            // 
            // containerValidator
            // 
            this.containerValidator.ContainerToValidate = this;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 370);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(620, 25);
            this.toolStrip.TabIndex = 17;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // CreditCardForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(620, 395);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.panelCCForm);
            this.Controls.Add(this.dgvCreditCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditCardForm";
            this.ShowIcon = false;
            this.Text = "Credit Card Selection";
            this.Load += new System.EventHandler(this.CreditCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardBindingSource)).EndInit();
            this.panelCCForm.ResumeLayout(false);
            this.panelCCForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rfvCardHolderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvStreetNbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvCardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCCForm;
        private System.Windows.Forms.CheckBox chkPref;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MaskedTextBox txtCardNumber;
        private System.Windows.Forms.BindingSource creditCardBindingSource;
        private System.Windows.Forms.MaskedTextBox txtExpDate;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvCardHolderName;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvStreetNbr;
        private Genghis.Windows.Forms.RegularExpressionValidator regexZipCode;
        private Genghis.Windows.Forms.CustomValidator cvCardNumber;
        private Genghis.Windows.Forms.CustomValidator cvExpDate;
        private Genghis.Windows.Forms.ContainerValidator containerValidator;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn PreferredCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCardTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCardNoDecrypted;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCardExpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardHolderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCardStreetNbrZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crCardZipCodeDataGridViewTextBoxColumn;
    }
}

