/* 
 *Author: Katherine Bellman
 *Date: July 6th 2021
 *Title: Week 8 ICE for NETD2202
 *Sub-Title: Main File for form
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6MDI
{
    public partial class frmFelineOverlords : Form
    {
        public frmFelineOverlords()
        {
            InitializeComponent();
        }
        #region Singleton Pattern
        // Singleton Pattern
        private static frmFelineOverlords felineOverlordsInstance;
        public static frmFelineOverlords Instance
        {
            get
            {
                if (felineOverlordsInstance == null)
                {
                    felineOverlordsInstance = new frmFelineOverlords();
                }
                return felineOverlordsInstance;
            }
        }
        #endregion
        #region GLOBAL VARIABLES

        List<Cat> FelineOverLords = new List<Cat>();

        String felineOverlordSex;

        Boolean sexRadioSelected;

        Boolean DGVSelectionOn = false;

        #endregion
        #region EVENT HANDLERS
            
        /// <summary>
        private void frmFelineOverlords_Load(object sender, EventArgs e)
        {
            FelineOverLords = Cat.GenerateFelineOverLords();
            UpdateDataGrid();
        }
        /// Set colouring of feline overlord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetColoring_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblPickColoring.BackColor = colorDialog1.Color;
        }
        
        /// <summary>
        /// Collect data and populate DataGridView if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                //Grab state of radio button for class method use
                ReturnSex();

                Cat overLord = new Cat();
                overLord.Name = txbName.Text.Trim();
                overLord.Sex = Cat.SexToString(sexRadioSelected, felineOverlordSex);
                overLord.Coloring = lblPickColoring.BackColor;
                overLord.Breed = txbBreed.Text.Trim();
                overLord.IsFixed = chkFixed.Checked;

                FelineOverLords.Add(overLord);
                UpdateDataGrid();
            }
            catch { };
        }

        /// <summary>
        /// Event handler to set all to default by calling the SetDefaults() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Method to set current instance of form to Null when closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            felineOverlordsInstance = null;
        }

        #endregion
        #region CUSTOM METHODS (FUCNTIONS)
        /// <summary>
        /// Method to set defaults for form
        /// </summary>
        private void SetDefaults() 
        {
            txbName.Clear();
            txbBreed.Clear();
            lblPickColoring.BackColor = Color.Gray;
            rbtSexMale.Checked = false;
            rbtSexFemale.Checked = false;
            chkFixed.Checked = false;
            
        }
        /// <summary>
        /// Method to update data grid when called
        /// </summary>
        private void UpdateDataGrid() 
        {
            DGVSelectionOn = false;
            dgvFelineOverlords.DataSource = null;
            dgvFelineOverlords.DataSource = FelineOverLords;
            dgvFelineOverlords.ClearSelection();
            DGVSelectionOn = true;
        }
        /// <summary>
        /// Returns the selected radio box or error message if null
        /// </summary>
        private void ReturnSex() 
        {
            if(rbtSexMale.Checked == false)
            {
                sexRadioSelected = false;
            }
            else if(true) 
            {
                sexRadioSelected = true;
            }
            else 
            {
                MessageBox.Show("A selection of \"sex\" for feline must be made.", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion
    }
}
