
namespace Lab6MDI
{
    partial class frmContactTracer
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblContacted = new System.Windows.Forms.Label();
            this.chkContactStatus = new System.Windows.Forms.CheckBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colContactStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(118, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(207, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 27);
            this.txtFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFirstName, "Enter the contacts first name");
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(118, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(207, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 27);
            this.txtLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLastName, "Enter the contacts last name");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 81);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 27);
            this.txtEmail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter the contacts email");
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(90, 114);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(207, 111);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(197, 27);
            this.mtbPhone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.mtbPhone, "Enter the contacts phone number.");
            // 
            // lblContacted
            // 
            this.lblContacted.AutoSize = true;
            this.lblContacted.Location = new System.Drawing.Point(116, 141);
            this.lblContacted.Name = "lblContacted";
            this.lblContacted.Size = new System.Drawing.Size(84, 20);
            this.lblContacted.TabIndex = 8;
            this.lblContacted.Text = "Contacted?";
            this.lblContacted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkContactStatus
            // 
            this.chkContactStatus.AutoSize = true;
            this.chkContactStatus.Location = new System.Drawing.Point(207, 144);
            this.chkContactStatus.Name = "chkContactStatus";
            this.chkContactStatus.Size = new System.Drawing.Size(18, 17);
            this.chkContactStatus.TabIndex = 9;
            this.toolTip1.SetToolTip(this.chkContactStatus, "A checkbox for whether the contact has been contacted.");
            this.chkContactStatus.UseVisualStyleBackColor = true;
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContacts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContacts.ColumnHeadersHeight = 29;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactStatus,
            this.colFirst,
            this.colLast,
            this.colDate,
            this.colEmail});
            this.dgvContacts.Location = new System.Drawing.Point(12, 182);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContacts.RowTemplate.Height = 29;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.ShowEditingIcon = false;
            this.dgvContacts.Size = new System.Drawing.Size(508, 174);
            this.dgvContacts.TabIndex = 10;
            this.dgvContacts.VirtualMode = true;
            this.dgvContacts.SelectionChanged += new System.EventHandler(this.dgvSelectionChange);
            // 
            // colContactStatus
            // 
            this.colContactStatus.DataPropertyName = "ContactStatus";
            this.colContactStatus.HeaderText = "Co...";
            this.colContactStatus.MinimumWidth = 6;
            this.colContactStatus.Name = "colContactStatus";
            this.colContactStatus.ReadOnly = true;
            this.colContactStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContactStatus.Width = 42;
            // 
            // colFirst
            // 
            this.colFirst.DataPropertyName = "FirstName";
            this.colFirst.HeaderText = "First Name";
            this.colFirst.MinimumWidth = 6;
            this.colFirst.Name = "colFirst";
            this.colFirst.ReadOnly = true;
            this.colFirst.Width = 109;
            // 
            // colLast
            // 
            this.colLast.DataPropertyName = "LastName";
            this.colLast.HeaderText = "Last Name";
            this.colLast.MinimumWidth = 6;
            this.colLast.Name = "colLast";
            this.colLast.ReadOnly = true;
            this.colLast.Width = 108;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 70;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 75;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOutput.Location = new System.Drawing.Point(12, 362);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(508, 92);
            this.txtOutput.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtOutput, "Output based on the current selected contact will appear here. For legibility pur" +
        "poses");
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(226, 470);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(94, 29);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Press to input a new contact or update an existing contact");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(326, 470);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset the controls to the default state");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(426, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmContactTracer
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(532, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.chkContactStatus);
            this.Controls.Add(this.lblContacted);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 558);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 558);
            this.Name = "frmContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClosed);
            this.Load += new System.EventHandler(this.frmContactTracer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblContacted;
        private System.Windows.Forms.CheckBox chkContactStatus;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colContactStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}

