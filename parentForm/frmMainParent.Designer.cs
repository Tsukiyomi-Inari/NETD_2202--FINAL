
namespace Lab6MDI
{
    partial class frmMainParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuWindowOpenContactTracer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowOpenAverageCases = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowFelineOverlords = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.editToolStripMenuItem,
            this.menuWindow,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            this.menuFile.ToolTipText = "File menu options";
            // 
            // menuFileNew
            // 
            this.menuFileNew.AccessibleDescription = "&New";
            this.menuFileNew.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_Files_Txt;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(184, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "Start new document";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_Very_Basic_Opened_Folder;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(184, 26);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Open a saved file ";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(184, 26);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Save current open file";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(184, 26);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.ToolTipText = "Save document as";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(184, 26);
            this.menuFileClose.Text = "Close";
            this.menuFileClose.ToolTipText = "Close current window";
            this.menuFileClose.Click += new System.EventHandler(this.menuFileClose_Click);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(184, 26);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.ToolTipText = "Exit application";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.menuEditSelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.ToolTipText = "Edit menu option";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_Editing_Cut_Filled;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(184, 26);
            this.menuEditCut.Text = "Cut";
            this.menuEditCut.ToolTipText = "Cut selected text";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_Very_Basic_Copy;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(184, 26);
            this.menuEditCopy.Text = "Copy";
            this.menuEditCopy.ToolTipText = "Copy currently selected text";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Image = global::MidiFormParentFinal.Properties.Resources.Custom_Icon_Design_Mini_Paste;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(184, 26);
            this.menuEditPaste.Text = "Paste";
            this.menuEditPaste.ToolTipText = "Paste current text from clipboard";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
            // 
            // menuEditSelectAll
            // 
            this.menuEditSelectAll.Name = "menuEditSelectAll";
            this.menuEditSelectAll.Size = new System.Drawing.Size(184, 26);
            this.menuEditSelectAll.Text = "Select All";
            this.menuEditSelectAll.ToolTipText = "Select all text";
            this.menuEditSelectAll.Click += new System.EventHandler(this.menuEditSelectAll_Click);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowCascade,
            this.menuWindowTileHorizontal,
            this.menuWindowTileVertical,
            this.toolStripSeparator1,
            this.menuWindowOpenContactTracer,
            this.menuWindowOpenAverageCases,
            this.menuWindowFelineOverlords});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(63, 20);
            this.menuWindow.Text = "Window";
            this.menuWindow.ToolTipText = "Window menu options";
            // 
            // menuWindowCascade
            // 
            this.menuWindowCascade.Name = "menuWindowCascade";
            this.menuWindowCascade.Size = new System.Drawing.Size(186, 26);
            this.menuWindowCascade.Text = "Cascade";
            this.menuWindowCascade.ToolTipText = "Cascade open windows";
            this.menuWindowCascade.Click += new System.EventHandler(this.menuWindowCascade_Click);
            // 
            // menuWindowTileHorizontal
            // 
            this.menuWindowTileHorizontal.Name = "menuWindowTileHorizontal";
            this.menuWindowTileHorizontal.Size = new System.Drawing.Size(186, 26);
            this.menuWindowTileHorizontal.Text = "Tile Horizontal";
            this.menuWindowTileHorizontal.ToolTipText = "Tile horizontally open windows";
            this.menuWindowTileHorizontal.Click += new System.EventHandler(this.menuWindowTileHorizontal_Click);
            // 
            // menuWindowTileVertical
            // 
            this.menuWindowTileVertical.Name = "menuWindowTileVertical";
            this.menuWindowTileVertical.Size = new System.Drawing.Size(186, 26);
            this.menuWindowTileVertical.Text = "Tile Vertical";
            this.menuWindowTileVertical.ToolTipText = "Tile open windows vertically";
            this.menuWindowTileVertical.Click += new System.EventHandler(this.menuWindowTileVertical_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuWindowOpenContactTracer
            // 
            this.menuWindowOpenContactTracer.Image = global::MidiFormParentFinal.Properties.Resources.disease_prevention__1_;
            this.menuWindowOpenContactTracer.Name = "menuWindowOpenContactTracer";
            this.menuWindowOpenContactTracer.Size = new System.Drawing.Size(186, 26);
            this.menuWindowOpenContactTracer.Text = "Open Contact Tracer";
            this.menuWindowOpenContactTracer.ToolTipText = "Open contact tracer window";
            this.menuWindowOpenContactTracer.Click += new System.EventHandler(this.menuWindowOpenContactTracer_Click);
            // 
            // menuWindowOpenAverageCases
            // 
            this.menuWindowOpenAverageCases.Image = global::MidiFormParentFinal.Properties.Resources.disease_prevention__1_;
            this.menuWindowOpenAverageCases.Name = "menuWindowOpenAverageCases";
            this.menuWindowOpenAverageCases.Size = new System.Drawing.Size(186, 26);
            this.menuWindowOpenAverageCases.Text = "Open Average Cases";
            this.menuWindowOpenAverageCases.ToolTipText = "Open average cases window";
            this.menuWindowOpenAverageCases.Click += new System.EventHandler(this.menuWindowOpenAverageCases_Click);
            // 
            // menuWindowFelineOverlords
            // 
            this.menuWindowFelineOverlords.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Windows_8_Holidays_Black_Cat;
            this.menuWindowFelineOverlords.Name = "menuWindowFelineOverlords";
            this.menuWindowFelineOverlords.Size = new System.Drawing.Size(186, 26);
            this.menuWindowFelineOverlords.Text = "Feline Overlords ";
            this.menuWindowFelineOverlords.Click += new System.EventHandler(this.menuWindowFelineOverlords_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            this.menuHelp.ToolTipText = "Help menu options";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Image = global::MidiFormParentFinal.Properties.Resources.Icons8_Ios7_Very_Basic_Help_Filled;
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(184, 26);
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.ToolTipText = "Open information about application window";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMainParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 637);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Infection Tool Kit";
            this.Load += new System.EventHandler(this.frmMainParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem menuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuWindowTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenContactTracer;
        private System.Windows.Forms.ToolStripMenuItem menuWindowOpenAverageCases;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem menuWindowFelineOverlords;
    }
}

