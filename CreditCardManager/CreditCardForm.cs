using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using CreditCardManager.Properties;
using Genghis.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CreditCardManager
{
    public partial class CreditCardForm : Form
    {
        //PUBLIC EVENTS
        public delegate void DoneEventHandler(CreditCard creditCard);
        public event DoneEventHandler Done = delegate { };

        //PRIVATE FIELDS
        private CustomerService service;
        private Customer customer;
        private List<CreditCard> creditCards;
        private CreditCard selectedCard;
        private List<CreditCardType> cardTypes;
        private LookUpService luService;
        private CreditCard cachedCard;

        private bool loading;
        private Module module;
        private bool isDirty;
        private int custKey;

        public CreditCardForm()
        {
            InitializeComponent();
        }




        //PUBLIC FUNCTIONS
        public void Initialize(int _custKey, Module _module)
        {
            service = new CustomerService();
            luService = new LookUpService();
            cardTypes = luService.GetAllCreditCardTypes();
            customer = service.LoadCustomer(_custKey);
            creditCards = service.LoadCreditCardsByCustKey(_custKey);
            selectedCard = creditCards.Count > 0 ? creditCards.FirstOrDefault(c => c.Preferred == -1) : new CreditCard();
            module = _module;
            custKey = _custKey;
            SelectPreferredCard();
        }







        //LOAD
        private void CreditCardForm_Load(object sender, EventArgs e)
        {
            loading = true;
            UnsubscribeToStateChangedEvents();

            cboCardType.ValueMember = "CrCardTypeKey";
            cboCardType.DisplayMember = "CrCardTypeName";
            cboCardType.DataSource = cardTypes;

            SetDataGrid();
            SelectPreferredCardDGV();
            CacheSelectedCardValues();
            if(selectedCard.CCKey != 0)
                SetFormControlValuesFromSelectedCard();

            lblCustID.Text = customer.Id;
            lblCustName.Text = customer.Name;

            SubscribeToStateChangedEvents();
            loading = false;

            containerValidator.Validate();
        }

        private void SelectPreferredCard()
        {
            var preferredCard = creditCards.FirstOrDefault(c => c.Preferred == -1);
            if (creditCards.Count > 0)
                selectedCard = preferredCard == null ? creditCards[0] : preferredCard;
            else
                selectedCard = new CreditCard();
        }

        private void SelectPreferredCardDGV()
        {
            var index = creditCards.FindIndex(c => c.Preferred == -1);
            if (index != -1)
                dgvCreditCard.Rows[index].Selected = true;
        }

        private void SetDataGrid()
        {
            dgvCreditCard.DataSource = null;
            dgvCreditCard.DataSource = creditCards;

            foreach (DataGridViewRow row in dgvCreditCard.Rows)
            {
                var cc = (CreditCard)row.DataBoundItem;
                row.Cells["PreferredCard"].Value = cc.Preferred == -1 ? Resources.singlecheck16x16 : Resources.blankimage;
            }

            dgvCreditCard.Columns["CrCardNoDecrypted"].Visible = module == Module.AR;
            dgvCreditCard.Columns["CrCardNo"].Visible = !(module == Module.AR);
        }

        private void SetFormControlValuesFromSelectedCard()
        {
            if (selectedCard == null) return;
            txtExpDate.Text = selectedCard.CrCardExp;
            txtCardNumber.Mask = cardTypes.First(c => c.Key == selectedCard.CrCardTypeKey).CrCardTypeMask;
            txtCardNumber.Text = module == Module.AR ? selectedCard.CrCardNoDecrypted : selectedCard.CrCardNo;
            txtCardName.Text = selectedCard.CardHolderName;
            txtStreetNo.Text = selectedCard.CrCardStreetNbrZip;
            txtZipCode.Text = selectedCard.CrCardZipCode;
            chkPref.Checked = selectedCard.Preferred == -1;
            cboCardType.SelectedItem = cardTypes.First(c => c.Key == selectedCard.CrCardTypeKey);
        }









        //SELECTION CHANGED
        private void dgvCreditCard_SelectionChanged(object sender, EventArgs e)
        {
            if (loading) return;
            if (dgvCreditCard.SelectedRows.Count == 0) return;

            var proceed = NotifyUserIfDirty();
            if (proceed)
            {
                UnsubscribeToStateChangedEvents();
                loading = true;
                selectedCard = (CreditCard)dgvCreditCard.SelectedRows[0].DataBoundItem;
                txtExpDate.Text = selectedCard.CrCardExp;
                txtCardNumber.Mask = cardTypes.First(c => c.Key == selectedCard.CrCardTypeKey).CrCardTypeMask;
                txtCardNumber.Text = module == Module.AR ? selectedCard.CrCardNoDecrypted : selectedCard.CrCardNo;
                txtCardName.Text = selectedCard.CardHolderName;
                txtStreetNo.Text = selectedCard.CrCardStreetNbrZip;
                txtZipCode.Text = selectedCard.CrCardZipCode;
                chkPref.Checked = selectedCard.Preferred == -1;
                cboCardType.SelectedItem = cardTypes.First(c => c.Key == selectedCard.CrCardTypeKey);
                loading = false;
                SubscribeToStateChangedEvents();


                CacheSelectedCardValues();
                containerValidator.Validate();
            }
        }

        private void CacheSelectedCardValues()
        {
            if (selectedCard != null)
            {
                cachedCard = new CreditCard();
                cachedCard.CrCardTypeKey = selectedCard.CrCardTypeKey;
                cachedCard.CrCardExp = selectedCard.CrCardExp;
                cachedCard.CrCardNoDecrypted = selectedCard.CrCardNoDecrypted;
                cachedCard.CrCardNo = selectedCard.CrCardNo;
                cachedCard.CardHolderName = selectedCard.CardHolderName;
                cachedCard.CrCardStreetNbrZip = selectedCard.CrCardStreetNbrZip;
                cachedCard.CrCardZipCode = selectedCard.CrCardZipCode;
                cachedCard.Preferred = selectedCard.Preferred;
            }
        }

        private void RestoreCreditCardProperties()
        {
            if (cachedCard != null)
            {
                selectedCard.CrCardTypeKey = cachedCard.CrCardTypeKey;
                selectedCard.CrCardExp = cachedCard.CrCardExp;
                selectedCard.CrCardNoDecrypted = cachedCard.CrCardNoDecrypted;
                selectedCard.CrCardNo = cachedCard.CrCardNo;
                selectedCard.CardHolderName = cachedCard.CardHolderName;
                selectedCard.CrCardStreetNbrZip = cachedCard.CrCardStreetNbrZip;
                selectedCard.CrCardZipCode = cachedCard.CrCardZipCode;
                selectedCard.Preferred = cachedCard.Preferred;
            }
        }






        //NEW
        private void btnNew_Click(object sender, EventArgs e)
        {
            var proceed = NotifyUserIfDirty();

            if (proceed)
            {
                selectedCard = new CreditCard();

                UnsubscribeToStateChangedEvents();

                txtCardName.Clear();
                cboCardType.SelectedIndex = 0;
                txtCardNumber.Mask = "aaaa-aaaa-aaaa-aaaa";
                txtExpDate.Clear();
                txtCardNumber.Clear();
                txtStreetNo.Text = "877 Monterey Pass Rd";
                txtZipCode.Text = "91754";
                chkPref.Checked = false;

                SubscribeToStateChangedEvents();

                containerValidator.Validate();
                //cvCardNumber.Validate(); //doesn't validate - have to force
                cboCardType.Focus();
            }
        }







        //SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, a) => { statusLabel.Text = ""; timer.Stop(); };

            //set defaults if not set
            selectedCard.Preferred = selectedCard.Preferred == null ? 0 : selectedCard.Preferred;
            selectedCard.Status = selectedCard.Status == null ? 1 : selectedCard.Status;
            selectedCard.CodedCCNo = string.IsNullOrEmpty(selectedCard.CodedCCNo.TrimEnd()) ? selectedCard.CrCardNoDecrypted.TrimEnd() : selectedCard.CodedCCNo.TrimEnd();
            selectedCard.CrCardNo = "************" + selectedCard.CodedCCNo.TrimEnd().Substring(selectedCard.CodedCCNo.TrimEnd().Length - 4, 4);
            selectedCard.CrCardStreetNbrZip = string.IsNullOrEmpty(selectedCard.CrCardStreetNbrZip) ? "877 Monterey Pass Rd" : selectedCard.CrCardStreetNbrZip;
            selectedCard.CrCardZipCode = string.IsNullOrEmpty(selectedCard.CrCardZipCode) ? "91754" : selectedCard.CrCardZipCode;

            var visaCardType = cardTypes.First(c => c.CrCardTypeName.Contains("Visa"));
            selectedCard.CrCardTypeKey = selectedCard.CrCardTypeKey == null ? visaCardType.Key : selectedCard.CrCardTypeKey;

            //update old preferred card
            var oldPrefCard = creditCards.FirstOrDefault(c => c.Preferred == -1 && c.CCKey != selectedCard.CCKey);
            bool selectedCardIsPreferred = selectedCard.Preferred == -1;

            if ((selectedCardIsPreferred) && (oldPrefCard != null))
            {
                oldPrefCard.CodedCCNo = oldPrefCard.CrCardNoDecrypted.TrimEnd();
                oldPrefCard.CrCardNo = "************" + oldPrefCard.CodedCCNo.TrimEnd().Substring(oldPrefCard.CodedCCNo.TrimEnd().Length - 4, 4);
                oldPrefCard.Preferred = 0;
                service.UpdateCreditCard(oldPrefCard);
            }

            //add or update selected card
            if (selectedCard.CCKey == 0)
            {
                service.AddNewCreditCard(selectedCard, customer.Key);
                statusLabel.Text = "Credit card was saved successfully.";
                timer.Start();
            }
            else
            {
                service.UpdateCreditCard(selectedCard);
                statusLabel.Text = "Credit card was updated successfully.";
                timer.Start();
            }

            //refresh cards
            creditCards = service.LoadCreditCardsByCustKey(custKey);


            //set UI
            loading = true;
            UnsubscribeToStateChangedEvents();

            SetDataGrid();

            if (selectedCard.CCKey != 0)
            {
                SelectCurrentCard();
                SelectCurrentCardDGV();
            }
            else
            {
                SelectPreferredCard();
                SelectPreferredCardDGV();
            }

            SetFormControlValuesFromSelectedCard();
            btnSave.Enabled = false;
            isDirty = false;

            SubscribeToStateChangedEvents();
            loading = false;

            dgvCreditCard.Focus();
        }

        private void SelectCurrentCard()
        {
            selectedCard = creditCards.FirstOrDefault(c => c.CCKey == selectedCard.CCKey);
            if (selectedCard == null && creditCards.Count > 0)
                selectedCard = creditCards[0];
        }

        private void SelectCurrentCardDGV()
        {
            var index = creditCards.FindIndex(c => c.CCKey == selectedCard.CCKey);
            if (index != -1)
                dgvCreditCard.Rows[index].Selected = true;
        }







        //DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCard.Preferred == -1)
            {
                MessageBox.Show("Cannot delete the preferred card. First select another card as preferred");
                return;
            }

            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, a) => { statusLabel.Text = ""; timer.Stop(); };

            service.UpdateCreditCardStatusToInActive(selectedCard.CCKey);
            statusLabel.Text = "Credit card was deleted successfully.";
            timer.Start();

            creditCards = service.LoadCreditCardsByCustKey(custKey);

            SelectPreferredCard();
            SetDataGrid();
            SelectPreferredCardDGV();
            SetFormControlValuesFromSelectedCard();

            btnSave.Enabled = false;
            isDirty = false;

            dgvCreditCard.Focus();
        }






        //FINISHED
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Done(selectedCard);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var proceed = NotifyUserIfDirty();
            if (proceed)
            {
                Close();
            }
        }

        private bool NotifyUserIfDirty()
        {
            if (isDirty)
            {
                var result = MessageBox.Show("Current credit card has been modified, would you like to save changes before moving on?", "Warning", MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        if (containerValidator.IsValid())
                        {
                            btnSave.PerformClick();
                            return true;
                        }
                        else
                        {
                            statusLabel.Text = "Current credit card is invalid, please fix errors before saving";
                            containerValidator.Validate();
                            return false;
                        }

                    case DialogResult.No:
                        if (selectedCard.CCKey != 0)
                            RestoreCreditCardProperties();
                        isDirty = false;
                        btnSave.Enabled = false;
                        return true;
                }
            }

            return true;
        }







        #region CONTROL STATE CHANGED
        private void UnsubscribeToStateChangedEvents()
        {
            cboCardType.SelectedIndexChanged -= cboCardType_SelectedIndexChanged;
            txtCardNumber.TextChanged -= txtCardNumber_TextChanged;
            txtExpDate.TextChanged -= txtExpDate_TextChanged;
            txtCardName.TextChanged -= txtCardName_TextChanged;
            txtStreetNo.TextChanged -= txtStreetNo_TextChanged;
            txtZipCode.TextChanged -= txtZipCode_TextChanged;
            chkPref.CheckedChanged -= chkPref_CheckedChanged;
        }

        private void SubscribeToStateChangedEvents()
        {
            cboCardType.SelectedIndexChanged += cboCardType_SelectedIndexChanged;
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
            txtExpDate.TextChanged += txtExpDate_TextChanged;
            txtCardName.TextChanged += txtCardName_TextChanged;
            txtStreetNo.TextChanged += txtStreetNo_TextChanged;
            txtZipCode.TextChanged += txtZipCode_TextChanged;
            chkPref.CheckedChanged += chkPref_CheckedChanged;
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            selectedCard.CodedCCNo = txtCardNumber.Text;
            cvCardNumber.Validate();
            btnSave.Enabled = containerValidator.IsValid();
            isDirty = true;
        }


        private void cboCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCardType = (CreditCardType)cboCardType.SelectedItem;
            txtCardNumber.Mask = selectedCardType.CrCardTypeMask;
            selectedCard.CrCardTypeKey = selectedCardType.Key;
            btnSave.Enabled = containerValidator.IsValid();
            isDirty = true;
        }

        private void txtExpDate_TextChanged(object sender, EventArgs e)
        {
            selectedCard.CrCardExp = txtExpDate.Text.Replace("-", "");
            cvExpDate.Validate();
            btnSave.Enabled = containerValidator.IsValid();
            isDirty = true;
        }

        private void txtCardName_TextChanged(object sender, EventArgs e)
        {
            selectedCard.CardHolderName = txtCardName.Text;
            rfvCardHolderName.Validate();
            btnSave.Enabled = containerValidator.IsValid();
            isDirty = true;
        }

        private void txtStreetNo_TextChanged(object sender, EventArgs e)
        {
            selectedCard.CrCardStreetNbrZip = txtStreetNo.Text;
            rfvStreetNbr.Validate();
            btnSave.Enabled = containerValidator.IsValid();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            selectedCard.CrCardZipCode = txtZipCode.Text;
            regexZipCode.Validate();
            btnSave.Enabled = containerValidator.IsValid();
            isDirty = true;
        }

        private void chkPref_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPref.Checked) //if being checked set property
            {
                selectedCard.Preferred = -1;
                isDirty = true;
                btnSave.Enabled = containerValidator.IsValid();
            }
            else //if being unchecked - make sure theres another card as preferred
            {
                if (selectedCard.Preferred == -1 && selectedCard.CCKey != 0) //preferred and not new
                {
                    var noOtherPreferredCardInList = creditCards.FirstOrDefault(c => c.Preferred == -1 && c.CCKey != selectedCard.CCKey) == null;
                    if (noOtherPreferredCardInList)
                    {
                        chkPref.CheckedChanged -= chkPref_CheckedChanged;
                        chkPref.Checked = true;
                        chkPref.CheckedChanged += chkPref_CheckedChanged;
                        MessageBox.Show("Please select another credit card as preferred.");
                    }
                    else
                    {
                        selectedCard.Preferred = 0;
                        isDirty = true;
                        btnSave.Enabled = containerValidator.IsValid();

                    }
                }
                else //if this is a new card and unchecked allow
                {
                    selectedCard.Preferred = 0;
                    isDirty = true;
                    btnSave.Enabled = containerValidator.IsValid();
                }
            }
        }

        #endregion







        #region VALIDATION
        private void cvCardNumber_Validating(object sender, CustomValidator.ValidationCancelEventArgs e)
        {
            if (loading) return;
            if (selectedCard.CodedCCNo.Length >= 15)
            {
                bool numberIsValid = false;
                switch (cboCardType.Text.TrimEnd())
                {
                    case "Visa":
                        numberIsValid = CreditCardValidator.ValidateCCNumber(txtCardNumber.Text, CardType.Visa);
                        break;

                    case "MasterCard":
                        numberIsValid = CreditCardValidator.ValidateCCNumber(txtCardNumber.Text, CardType.Mastercard);
                        break;

                    case "Discover":
                        numberIsValid = CreditCardValidator.ValidateCCNumber(txtCardNumber.Text, CardType.Discover);
                        break;

                    case "Amex":
                        numberIsValid = CreditCardValidator.ValidateCCNumber(txtCardNumber.Text, CardType.Amex);
                        break;
                }

                var duplicateCard = creditCards.FirstOrDefault(c => (c.CrCardNoDecrypted.TrimEnd() == selectedCard.CodedCCNo) &&
                                                                    (c.CCKey != selectedCard.CCKey));

                e.Valid = (duplicateCard == null) && (numberIsValid);
                //cvCardNumber.ErrorMessage = "";

                if (!numberIsValid)
                {
                    cvCardNumber.ErrorMessage = "Invalid credit card number. Confirm and reenter";
                }

                if (duplicateCard != null)
                {
                    cvCardNumber.ErrorMessage = "This credit card already exists. Cannot save a duplicate.";
                }
            }
            else
            {
                e.Valid = false;
                cvCardNumber.ErrorMessage = "Invalid credit card number. Confirm and reenter";
            }
        }

        private void cvExpDate_Validating(object sender, CustomValidator.ValidationCancelEventArgs e)
        {
            if (loading) return;
            var success = DateTime.TryParse(txtExpDate.Text, out DateTime expDateTimeObj);
            if (success)
            {
                var input = txtExpDate.Text.Replace(" ", "").Replace("-", "");
                e.Valid = expDateTimeObj > DateTime.Now && input.Length == 6;
            }
            else
            {
                e.Valid = false;
            }
        }
        #endregion

    }

    public enum Module
    {
        AR,
        SO
    }

}
