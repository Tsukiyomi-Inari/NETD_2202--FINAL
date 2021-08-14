/**   frmMainParent.cs
 *  @Author: Russel Waring & Katherine Bellman
 *  @Program: Emergency Infection Tool
 *  @Description: MDI application with some previous labs called in as child forms within it
 *
 * @date: August 10th 2021
 * 
 * 
 * @ Last changed on: August 13th 2021
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
using System.IO;

namespace Lab6MDI
{
    public partial class frmMainParent : Form
    {
        public frmMainParent()
        {
            InitializeComponent();
        }

        #region "EVENT HANDLERS"
        private void frmMainParent_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt";
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt";
        }

        #region "Menu Events"
        // Tabs for the menuStrip1:
        #region "File Tab"
        /// <summary>
        /// Opens a new Text Editor and/ or begins a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            Document.TextFile.Text = string.Empty;
            Document.TextFile.FileName = string.Empty;
            frmTextEditor frm = frmTextEditor.Instance;
            frm.MdiParent = this;
            // when loading the list of troops, force the update form (it is a public method) before show/focus
            frm.UpdateForm();
            frm.Show();
            frm.Focus();
        }
        /// <summary>
        /// Calls OpenFile() method to open a file in Text Editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        /// <summary>
        /// Calls SaveFile() method to save current open file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        /// <summary>
        /// Calls SaveAsFile() method to create a current savedfile from document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
        /// <summary>
        /// Closes Text editor child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileClose_Click(object sender, EventArgs e)
        {
            frmTextEditor frm = new frmTextEditor();
            frm.MdiParent = this;
            frm.Close();
        }
        /// <summary>
        /// Exits parent application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        #endregion
        #region "Edit Tab"
        private void menuEditCut_Click(object sender, EventArgs e)
        {
            frmTextEditor.Instance.CutText();
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            frmTextEditor.Instance.CopyText();
        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            frmTextEditor.Instance.PasteText();
        }

        private void menuEditSelectAll_Click(object sender, EventArgs e)
        {
            frmTextEditor.Instance.SelectAllText();
        }
        #endregion
        #region "Window Tab"
        /// <summary>
        /// Cascades all open windows inside parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }
        /// <summary>
        /// Tile all open windows horizontally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }
        /// <summary>
        ///   Tile all open windows vertically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        /// <summary>
        /// Opens child form "Contact Tracer" within parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowOpenContactTracer_Click(object sender, EventArgs e)
        {
            frmContactTracer frm = frmContactTracer.Instance;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        /// <summary>
        /// Opens child form "Average Cases" within parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowOpenAverageCases_Click(object sender, EventArgs e)
        {
            RegionAverageWeeklyUnitsForm frm = RegionAverageWeeklyUnitsForm.Instance;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        /// <summary>
        /// Opens child form "Feline Overlords" within parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuWindowFelineOverlords_Click(object sender, EventArgs e)
        {
            frmFelineOverlords frm = frmFelineOverlords.Instance;
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        #endregion
        #region "Help Tab"
        /// <summary>
        /// Opens the frmAbout as a dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        #endregion

        #endregion

        #endregion

        #region "CUSTOM METHODS"
       /// <summary>
       /// Opens save file dialog, writes it to file for current instance of Text Editor
       /// </summary>
        private void SaveAsFile()
        {
            String fileName = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                Document.TextFile.FileName = fileName;
                // save the information
                Document.FileWrite(Document.TextFile, Document.TextFile.FileName);
                MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
                frmTextEditor.Instance.UpdateForm();
                //filename = Path.GetFileName(filename);
            };
        }

        /// <summary>
        /// Prompts for SaveAsFile if there is no FileName.
        /// </summary>
        private void SaveFile()
        {
            if (frmTextEditor.Instance.FileNameCurrent == string.Empty || frmTextEditor.Instance.FileNameCurrent == "Untitled - Text Editor")
            {
                SaveAsFile();
            }
            else // if the current file is not empty use the current filename in memory / global variable
            {
                string fileName = frmTextEditor.Instance.FileNameCurrent;
                Document.FileWrite(Document.TextFile, fileName);
                MessageBox.Show("Save was Complete", "Save Confirmation", MessageBoxButtons.OK);
                frmTextEditor.Instance.SetChangeStatus(false);
            }
        }

        #region Menu Options
        /// <summary>
        /// Calls for the LoadFile method from the document class.
        /// </summary>
        private void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load from a file, have to show dialog first
                Document.LoadFile(openFileDialog1.FileName);
                frmTextEditor frm = frmTextEditor.Instance;
                frm.MdiParent = this;
                // when loading the list of troops, force the update form (it is a public method) before show/focus
                frm.UpdateForm();
                frm.Show();
                frm.Focus();
                //Instance.FileNameCurrent.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Adios!
        /// </summary>
        private void ExitApplication()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
        /// <summary>
        /// Method to close all open child forms
        /// </summary>
        public void DisposeAll()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Dispose();
                return;
            }
        }


        #endregion


    }
}
