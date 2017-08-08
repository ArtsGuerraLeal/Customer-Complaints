namespace TeamProject
{
    partial class Email
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultFiltered = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTestCustomers = new System.Windows.Forms.DataGridView();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmailType = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(189)))), ((int)(((byte)(156)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(486, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(189)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.lblResultFiltered);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtSearchLastName);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvTestCustomers);
            this.panel1.Location = new System.Drawing.Point(630, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 317);
            this.panel1.TabIndex = 65;
            // 
            // lblResultFiltered
            // 
            this.lblResultFiltered.AutoSize = true;
            this.lblResultFiltered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(189)))), ((int)(((byte)(156)))));
            this.lblResultFiltered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultFiltered.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultFiltered.Location = new System.Drawing.Point(26, 87);
            this.lblResultFiltered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultFiltered.Name = "lblResultFiltered";
            this.lblResultFiltered.Size = new System.Drawing.Size(65, 18);
            this.lblResultFiltered.TabIndex = 52;
            this.lblResultFiltered.Text = "Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(189)))), ((int)(((byte)(156)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Last Name:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnClear.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(164, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(126, 59);
            this.txtSearchLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(135, 20);
            this.txtSearchLastName.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(3, 270);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer Search";
            // 
            // dgvTestCustomers
            // 
            this.dgvTestCustomers.AllowUserToOrderColumns = true;
            this.dgvTestCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestCustomers.Location = new System.Drawing.Point(29, 121);
            this.dgvTestCustomers.Name = "dgvTestCustomers";
            this.dgvTestCustomers.Size = new System.Drawing.Size(241, 125);
            this.dgvTestCustomers.TabIndex = 53;
            this.dgvTestCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestCustomers_CellContentClick);
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.lblCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCustId.Location = new System.Drawing.Point(627, 23);
            this.lblCustId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(108, 18);
            this.lblCustId.TabIndex = 64;
            this.lblCustId.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(739, 21);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(175, 20);
            this.txtCustomerID.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(639, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(739, 91);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(175, 20);
            this.txtLastName.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(639, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(739, 56);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(175, 20);
            this.txtFirstName.TabIndex = 59;
            // 
            // lblEmailType
            // 
            this.lblEmailType.AutoSize = true;
            this.lblEmailType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.lblEmailType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmailType.Location = new System.Drawing.Point(268, 54);
            this.lblEmailType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(71, 18);
            this.lblEmailType.TabIndex = 58;
            this.lblEmailType.Text = "Reason:";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "Coupon",
            "Apology",
            "Thank You",
            "Newsletter",
            "Order Update",
            "Custom"});
            this.cmbTypes.Location = new System.Drawing.Point(344, 54);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbTypes.TabIndex = 57;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged_1);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(189)))), ((int)(((byte)(156)))));
            this.btnSendEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendEmail.Location = new System.Drawing.Point(344, 218);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(109, 38);
            this.btnSendEmail.TabIndex = 56;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(306, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "To:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(344, 121);
            this.txtBody.Margin = new System.Windows.Forms.Padding(2);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size(226, 79);
            this.txtBody.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(270, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(288, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Body:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(344, 88);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(211, 20);
            this.txtSubject.TabIndex = 51;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(344, 21);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(211, 20);
            this.txtTo.TabIndex = 50;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(384, 13);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(939, 476);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblEmailType);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultFiltered;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTestCustomers;
        private System.Windows.Forms.Label lblCustId;
        public System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmailType;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubject;
        public System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblResults;
    }
}