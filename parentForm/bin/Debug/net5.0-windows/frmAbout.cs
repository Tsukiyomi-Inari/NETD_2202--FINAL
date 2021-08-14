/*
 * Author:      Katherine Bellman, Russell Waring
 * Date:        July 30, 2021
 * Revision:    August 13, 2021
 * Title:       Lab 6: Text Editor
 * Sub-title:   About Dialog
 * Description:
 *          This form works connects the frmMainParent to the frmAbout to 
 *          display documentation related to application.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6MDI
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        /// <summary>
        /// "OK" button to close frmAbout 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
