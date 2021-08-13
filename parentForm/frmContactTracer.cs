/*
 * Author: Katherine Bellman, Russell Waring
 * Date: July 15, 2021
 * Revision: August 13, 2021
 * Title: Lab 6: MDI
 * Sub-title: Contact Tracer Form
 * Description:
 *      Contact Tracer form, child form of the frmMainParent. Works with the Contact.cs class.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab6MDI
{
    public partial class frmContactTracer : Form
    {
        public frmContactTracer()
        {
            InitializeComponent();
        }

        #region Singleton Pattern
        // Singleton Pattern
        private static frmContactTracer contactTracerInstance;
        public static frmContactTracer Instance
        {
            get
            {
                if (contactTracerInstance == null)
                {
                    contactTracerInstance = new frmContactTracer();
                }
                return contactTracerInstance;
            }
        }
        #endregion

        #region GLOBAL VARS
        /// <summary>
        /// Declaration for array of object Contacts.
        /// </summary>
        List<Contact> Contacts = new List<Contact>();

        Boolean DGVSelectionOn = false;

        #endregion

        #region EVENT HANDLERS

        private void frmContactTracer_Load(object sender, EventArgs e)
        {
            Contacts = Contact.GenerateTestContacts();
            UpdateDataGrid();
            //dgvContacts.ClearSelection();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            // Add data validation
            Boolean valid = false;
            valid = ValidInput();
            if(valid == true)
            {
                try
                {
                    Contact contact = new Contact();
                    contact.ContactStatus = chkContactStatus.Checked;
                    contact.FirstName = txtFirstName.Text.Trim();
                    contact.LastName = txtLastName.Text.Trim();
                    contact.Date = GetDate();
                    contact.Email = txtEmail.Text.Trim();
                    contact.Phone = mtbPhone.Text.Trim();

                    // determine if edit or add mode
                    if (txtFirstName.Enabled && txtLastName.Enabled && !Contact.AlreadyExists(Contacts, contact.FirstName, contact.LastName))
                    {
                        Contacts.Add(contact);
                    }
                    else if (txtFirstName.Enabled && txtLastName.Enabled)
                    {
                        MessageBox.Show("This contact already exists!");
                    }
                    else // txtFirstName.Enabled = false && txtLastName.Enabled = false (edit mode), remove and add new (changed).
                    {
                        // can use GetContactFromPhone to remove
                        Contacts.Remove(Contact.GetContactFromName(Contacts, contact.FirstName, contact.LastName));
                        Contacts.Add(contact);
                    }
                    UpdateDataGrid();
                    SetDefaults();
                }
                catch { };
            }
            else
            {
                // do nothing
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvSelectionChange(object sender, EventArgs e)
        {
            if (DGVSelectionOn && dgvContacts.SelectedRows.Count > 0)
            {

                Contact contact = new Contact();
                contact = Contact.GetContactFromName(Contacts, Convert.ToString(dgvContacts.SelectedRows[0].Cells[1].Value), Convert.ToString(dgvContacts.SelectedRows[0].Cells[2].Value));
                PopulateContact(contact);
            }
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            contactTracerInstance = null;
        }
        #endregion

        #region CUSTOM METHODS

        private void UpdateDataGrid()
        {
            DGVSelectionOn = false;
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = Contacts;
            dgvContacts.ClearSelection();
            DGVSelectionOn = true;
        }

        private void SetDefaults()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            chkContactStatus.Checked = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            mtbPhone.Clear();
            txtOutput.Clear();
            txtFirstName.Focus();
        }

        private DateTime GetDate()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            return dt;
        }

        private void PopulateContact(Contact contact)
        {
            try
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                mtbPhone.Text = contact.Phone;
                chkContactStatus.Checked = contact.ContactStatus;
                txtFirstName.Text = contact.FirstName;
                txtLastName.Text = contact.LastName;
                txtEmail.Text = contact.Email;
            }
            catch
            {
                MessageBox.Show("An error occured loading the contact, try again later!", "Loading Error", MessageBoxButtons.OK);
            }
        }

        private bool ValidInput()
        {
            Boolean isvalid = false;
            while (isvalid == false)
            {
                if (txtFirstName.Text.Trim() == String.Empty)
                {
                    txtOutput.Text += "\nFirst name is a required field. ";
                }
                if (txtLastName.Text.Trim() == String.Empty)
                {
                    txtOutput.Text += "\nLast name is a required field. ";
                }
                if (mtbPhone is null || txtEmail.Text.Trim() == String.Empty)
                {
                    txtOutput.Text += "\nContact must have an email address or phone number.";
                    break;
                }
                else if (!Regex.IsMatch(txtEmail.Text.Trim(), "[A-Z0-9a-z._%+-]+@[A-Z0-9a-z0-9.-]+\\.[A-Za-z]{2,64}"))
                {
                    txtOutput.Text += "\n Email is not in a valid format. \n";
                    break;
                }
                isvalid = true;
            }
            return isvalid;
        }
        #endregion

    }
}
