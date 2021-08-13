/*
 * Author: Russell Waring
 * Date: July 30th
 * Revision: August 4th
 * Title: Lab 5: Text Editor
 * Description:
 *          This lab demonstrates the use of FileStream and StreamWriter to save and open files in the presentation
 *          and function of a basic text editor.
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace Lab6MDI
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS

        public string FileNameCurrent { get; set; }

        #endregion

        #region Singleton Pattern
        // Singleton Pattern
        private static frmTextEditor textFileInstance;
        public static frmTextEditor Instance
        {
            get
            {
                if (textFileInstance == null)
                {
                    textFileInstance = new frmTextEditor();
                }
                return textFileInstance;
            }
        }
        #endregion

        #region EVENT HANDLERS

        private void frmTextEditor_Load(object sender, EventArgs e)
        {
            //CurrentDocument.Text = rtbCanvas.Text;

            //.Filter = "Text Documents (*.txt)|*.txt";
            // openFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            Document.TextFile.Text = rtbCanvas.Text;
            Instance.FileNameCurrent = Document.TextFile.FileName;
            SetFileName();
            //SetChangeStatus(false);
        }

        #region Change Event
        /// <summary>
        /// Keeps track of changes in the textbox and counts the characters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbCanvas_TextChanged(object sender, EventArgs e)
        {
            Document.TextFile.Text = rtbCanvas.Text;
            SetChangeStatus(true);
            int chars = rtbCanvas.Text.Length;
            statusCharacterCount.Text = chars.ToString();
        }
        #endregion

        #endregion

        #region CUSTOM METHODS
        /// <summary>
        /// Indicates anytime a change has occured after a new file, open file, or save file.
        /// </summary>
        /// <param name="change"></param>
        public void SetChangeStatus(Boolean change)
        {
            statusChange.Text = change.ToString();
        }

        public void UpdateForm()
        {
            rtbCanvas.Text = Document.TextFile.Text;
            Instance.FileNameCurrent = Document.TextFile.FileName;
            frmMainParent frm = (frmMainParent)this.MdiParent;
            SetFileName();
            SetChangeStatus(false);
        }


        /// <summary>
        /// Sets the file name on the text property of the form.
        /// </summary>
        /// <param name="str"></param>
        private void SetFileName()
        {
            if(Instance.FileNameCurrent == string.Empty)
            {
                this.Text = "Untitled - Text Editor";
            }
            else
            {
                //FilePath = openFileDialog.FileName;
                string thisText = null;
                thisText = Path.GetFileName(FileNameCurrent);
                this.Text = thisText + " - Text Editor";
            }
        }

        #endregion

        private void frmClosed(object sender, FormClosedEventArgs e)
        {
            textFileInstance = null;
        }
    }
}
