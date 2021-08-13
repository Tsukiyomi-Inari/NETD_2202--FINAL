
namespace Lab6MDI
{
    partial class frmTextEditor
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
            this.rtbCanvas = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusCharacterCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharacterCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSplitter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusChangeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusChange = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbCanvas
            // 
            this.rtbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCanvas.Location = new System.Drawing.Point(0, 0);
            this.rtbCanvas.Name = "rtbCanvas";
            this.rtbCanvas.Size = new System.Drawing.Size(482, 324);
            this.rtbCanvas.TabIndex = 1;
            this.rtbCanvas.Text = "";
            this.rtbCanvas.TextChanged += new System.EventHandler(this.rtbCanvas_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCharacterCountLabel,
            this.statusCharacterCount,
            this.statusSplitter,
            this.statusChangeLabel,
            this.statusChange});
            this.statusStrip.Location = new System.Drawing.Point(0, 327);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(482, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusCharacterCountLabel
            // 
            this.statusCharacterCountLabel.Name = "statusCharacterCountLabel";
            this.statusCharacterCountLabel.Size = new System.Drawing.Size(46, 20);
            this.statusCharacterCountLabel.Text = "chars:";
            // 
            // statusCharacterCount
            // 
            this.statusCharacterCount.AutoSize = false;
            this.statusCharacterCount.Name = "statusCharacterCount";
            this.statusCharacterCount.Size = new System.Drawing.Size(300, 20);
            this.statusCharacterCount.Text = "0";
            this.statusCharacterCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusCharacterCount.ToolTipText = "Displays the number of characters in the file";
            // 
            // statusSplitter
            // 
            this.statusSplitter.Name = "statusSplitter";
            this.statusSplitter.Size = new System.Drawing.Size(13, 20);
            this.statusSplitter.Text = "|";
            // 
            // statusChangeLabel
            // 
            this.statusChangeLabel.Name = "statusChangeLabel";
            this.statusChangeLabel.Size = new System.Drawing.Size(62, 20);
            this.statusChangeLabel.Text = "Change:";
            // 
            // statusChange
            // 
            this.statusChange.Name = "statusChange";
            this.statusChange.Size = new System.Drawing.Size(41, 20);
            this.statusChange.Text = "False";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.rtbCanvas);
            this.Name = "frmTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled - Text Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClosed);
            this.Load += new System.EventHandler(this.frmTextEditor_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbCanvas;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusCharacterCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusCharacterCount;
        private System.Windows.Forms.ToolStripStatusLabel statusSplitter;
        private System.Windows.Forms.ToolStripStatusLabel statusChangeLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

