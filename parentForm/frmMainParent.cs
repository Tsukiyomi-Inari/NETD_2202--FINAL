/**   frmMainParent.cs
 *  @Author: Russel Waring & Katherine Bellman
 *  @Program: Emergency Infection Tool
 *  @Description: MDI application with some previous labs called in as child forms within it
 *
 * @date: August 10th 2021
 * 
 * 
 * @ Last changed on: 
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
    public partial class frmMainParent : Form
    {
        public frmMainParent()
        {
            InitializeComponent();
        }
        #region "CHILD FORMS"
        private void menuWindowOpenAverageCases_Click(object sender, EventArgs e)
        {
            RegionAverageWeeklyUnitsForm frm = RegionAverageWeeklyUnitsForm.Instance;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        #endregion
        #region "EVENT HANDLERS"
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            //open new instance of text editor child form
            frmBasicTextEditor frm = new frmBasicTextEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {

        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            frmBasicTextEditor frm = new frmBasicTextEditor();
            frm.MdiParent = this;
            frm.Close();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {

        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {

        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {

        }

        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Cascade windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        /// <summary>
        /// Tile windows horizontally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        /// <summary>
        ///   Tile windows vertically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        /// <summary>
        /// Opens the frmAbout as a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
           /* frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();*/
        }
        #endregion

        #region "CUSTOM METHODS"

        
        #endregion

    }
}
