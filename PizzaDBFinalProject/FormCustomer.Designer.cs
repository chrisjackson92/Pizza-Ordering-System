namespace PizzaDBFinalProject
{
    partial class FormCustomer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAddCust = new System.Windows.Forms.DataGridView();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.txtCNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPHONE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCEMAIL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.dgvEditCust = new System.Windows.Forms.DataGridView();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.txtAddNAME = new System.Windows.Forms.TextBox();
            this.txtAddPHONE = new System.Windows.Forms.TextBox();
            this.txtAddEMAIL = new System.Windows.Forms.TextBox();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCust)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCust)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 569);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.VisibleChanged += new System.EventHandler(this.FormCustomer_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAddCust);
            this.tabPage1.Controls.Add(this.btnAddCust);
            this.tabPage1.Controls.Add(this.txtCNAME);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCPHONE);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCEMAIL);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCustID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAddCust
            // 
            this.dgvAddCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddCust.Location = new System.Drawing.Point(345, 76);
            this.dgvAddCust.Name = "dgvAddCust";
            this.dgvAddCust.RowHeadersWidth = 82;
            this.dgvAddCust.RowTemplate.Height = 33;
            this.dgvAddCust.Size = new System.Drawing.Size(827, 400);
            this.dgvAddCust.TabIndex = 10;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(46, 331);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(157, 69);
            this.btnAddCust.TabIndex = 9;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // txtCNAME
            // 
            this.txtCNAME.Location = new System.Drawing.Point(154, 119);
            this.txtCNAME.Name = "txtCNAME";
            this.txtCNAME.Size = new System.Drawing.Size(140, 31);
            this.txtCNAME.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // txtCPHONE
            // 
            this.txtCPHONE.Location = new System.Drawing.Point(154, 175);
            this.txtCPHONE.Name = "txtCPHONE";
            this.txtCPHONE.Size = new System.Drawing.Size(140, 31);
            this.txtCPHONE.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No:";
            // 
            // txtCEMAIL
            // 
            this.txtCEMAIL.Location = new System.Drawing.Point(154, 225);
            this.txtCEMAIL.Name = "txtCEMAIL";
            this.txtCEMAIL.Size = new System.Drawing.Size(140, 31);
            this.txtCEMAIL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(154, 73);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(140, 31);
            this.txtCustID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Customer";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkEmail);
            this.tabPage2.Controls.Add(this.chkPhone);
            this.tabPage2.Controls.Add(this.chkName);
            this.tabPage2.Controls.Add(this.dgvEditCust);
            this.tabPage2.Controls.Add(this.btnEditCust);
            this.tabPage2.Controls.Add(this.txtAddNAME);
            this.tabPage2.Controls.Add(this.txtAddPHONE);
            this.tabPage2.Controls.Add(this.txtAddEMAIL);
            this.tabPage2.Controls.Add(this.txtAddID);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1230, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(22, 244);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(104, 29);
            this.chkEmail.TabIndex = 24;
            this.chkEmail.Text = "E-mail";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // chkPhone
            // 
            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(22, 194);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.Size = new System.Drawing.Size(106, 29);
            this.chkPhone.TabIndex = 23;
            this.chkPhone.Text = "Phone";
            this.chkPhone.UseVisualStyleBackColor = true;
            this.chkPhone.CheckedChanged += new System.EventHandler(this.chkPhone_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(22, 138);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(100, 29);
            this.chkName.TabIndex = 22;
            this.chkName.Text = "Name";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // dgvEditCust
            // 
            this.dgvEditCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCust.Location = new System.Drawing.Point(354, 93);
            this.dgvEditCust.Name = "dgvEditCust";
            this.dgvEditCust.RowHeadersWidth = 82;
            this.dgvEditCust.RowTemplate.Height = 33;
            this.dgvEditCust.Size = new System.Drawing.Size(846, 400);
            this.dgvEditCust.TabIndex = 21;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(45, 348);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(157, 69);
            this.btnEditCust.TabIndex = 20;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddNAME
            // 
            this.txtAddNAME.Location = new System.Drawing.Point(134, 136);
            this.txtAddNAME.Name = "txtAddNAME";
            this.txtAddNAME.ReadOnly = true;
            this.txtAddNAME.Size = new System.Drawing.Size(140, 31);
            this.txtAddNAME.TabIndex = 19;
            // 
            // txtAddPHONE
            // 
            this.txtAddPHONE.Location = new System.Drawing.Point(134, 192);
            this.txtAddPHONE.Name = "txtAddPHONE";
            this.txtAddPHONE.ReadOnly = true;
            this.txtAddPHONE.Size = new System.Drawing.Size(140, 31);
            this.txtAddPHONE.TabIndex = 17;
            // 
            // txtAddEMAIL
            // 
            this.txtAddEMAIL.Location = new System.Drawing.Point(134, 242);
            this.txtAddEMAIL.Name = "txtAddEMAIL";
            this.txtAddEMAIL.ReadOnly = true;
            this.txtAddEMAIL.Size = new System.Drawing.Size(140, 31);
            this.txtAddEMAIL.TabIndex = 15;
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(134, 90);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(140, 31);
            this.txtAddID.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(359, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 39);
            this.label10.TabIndex = 11;
            this.label10.Text = "Edit Customer";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddCust)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPHONE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCEMAIL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAddCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.DataGridView dgvEditCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TextBox txtAddNAME;
        private System.Windows.Forms.TextBox txtAddPHONE;
        private System.Windows.Forms.TextBox txtAddEMAIL;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}