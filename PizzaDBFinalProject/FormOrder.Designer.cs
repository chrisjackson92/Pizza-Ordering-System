namespace PizzaDBFinalProject
{
    partial class FormOrder
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
            this.dgvAddOrder = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderToppingsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkToppings = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkCustID = new System.Windows.Forms.CheckBox();
            this.dgvEditOrder = new System.Windows.Forms.DataGridView();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.txtEditCustID = new System.Windows.Forms.TextBox();
            this.txtEditSize = new System.Windows.Forms.TextBox();
            this.txtEditIToppingID = new System.Windows.Forms.TextBox();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPrice = new System.Windows.Forms.CheckBox();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOrder)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOrder)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOrderPrice);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgvAddOrder);
            this.tabPage1.Controls.Add(this.btnCreateOrder);
            this.tabPage1.Controls.Add(this.txtCustID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtOrderSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtOrderToppingsID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNewOrderID);
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
            // dgvAddOrder
            // 
            this.dgvAddOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddOrder.Location = new System.Drawing.Point(345, 76);
            this.dgvAddOrder.Name = "dgvAddOrder";
            this.dgvAddOrder.RowHeadersWidth = 82;
            this.dgvAddOrder.RowTemplate.Height = 33;
            this.dgvAddOrder.Size = new System.Drawing.Size(827, 400);
            this.dgvAddOrder.TabIndex = 10;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(46, 349);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(157, 69);
            this.btnCreateOrder.TabIndex = 9;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(154, 119);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(140, 31);
            this.txtCustID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer ID:";
            // 
            // txtOrderSize
            // 
            this.txtOrderSize.Location = new System.Drawing.Point(154, 175);
            this.txtOrderSize.Name = "txtOrderSize";
            this.txtOrderSize.Size = new System.Drawing.Size(140, 31);
            this.txtOrderSize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size:";
            // 
            // txtOrderToppingsID
            // 
            this.txtOrderToppingsID.Location = new System.Drawing.Point(154, 225);
            this.txtOrderToppingsID.Name = "txtOrderToppingsID";
            this.txtOrderToppingsID.Size = new System.Drawing.Size(140, 31);
            this.txtOrderToppingsID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toppings ID:";
            // 
            // txtNewOrderID
            // 
            this.txtNewOrderID.Location = new System.Drawing.Point(154, 73);
            this.txtNewOrderID.Name = "txtNewOrderID";
            this.txtNewOrderID.Size = new System.Drawing.Size(140, 31);
            this.txtNewOrderID.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Order";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkPrice);
            this.tabPage2.Controls.Add(this.txtEditPrice);
            this.tabPage2.Controls.Add(this.chkToppings);
            this.tabPage2.Controls.Add(this.chkSize);
            this.tabPage2.Controls.Add(this.chkCustID);
            this.tabPage2.Controls.Add(this.dgvEditOrder);
            this.tabPage2.Controls.Add(this.btnEditCust);
            this.tabPage2.Controls.Add(this.txtEditCustID);
            this.tabPage2.Controls.Add(this.txtEditSize);
            this.tabPage2.Controls.Add(this.txtEditIToppingID);
            this.tabPage2.Controls.Add(this.txtEditID);
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
            // chkToppings
            // 
            this.chkToppings.AutoSize = true;
            this.chkToppings.Location = new System.Drawing.Point(22, 244);
            this.chkToppings.Name = "chkToppings";
            this.chkToppings.Size = new System.Drawing.Size(154, 29);
            this.chkToppings.TabIndex = 24;
            this.chkToppings.Text = "Topping ID:";
            this.chkToppings.UseVisualStyleBackColor = true;
            this.chkToppings.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(22, 194);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(92, 29);
            this.chkSize.TabIndex = 23;
            this.chkSize.Text = "Size:";
            this.chkSize.UseVisualStyleBackColor = true;
            this.chkSize.CheckedChanged += new System.EventHandler(this.chkSize_CheckedChanged);
            // 
            // chkCustID
            // 
            this.chkCustID.AutoSize = true;
            this.chkCustID.Location = new System.Drawing.Point(22, 138);
            this.chkCustID.Name = "chkCustID";
            this.chkCustID.Size = new System.Drawing.Size(168, 29);
            this.chkCustID.TabIndex = 22;
            this.chkCustID.Text = "Customer ID:";
            this.chkCustID.UseVisualStyleBackColor = true;
            this.chkCustID.CheckedChanged += new System.EventHandler(this.chkCustID_CheckedChanged);
            // 
            // dgvEditOrder
            // 
            this.dgvEditOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditOrder.Location = new System.Drawing.Point(354, 93);
            this.dgvEditOrder.Name = "dgvEditOrder";
            this.dgvEditOrder.RowHeadersWidth = 82;
            this.dgvEditOrder.RowTemplate.Height = 33;
            this.dgvEditOrder.Size = new System.Drawing.Size(846, 400);
            this.dgvEditOrder.TabIndex = 21;
            // 
            // btnEditCust
            // 
            this.btnEditCust.Location = new System.Drawing.Point(41, 411);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(157, 69);
            this.btnEditCust.TabIndex = 20;
            this.btnEditCust.Text = "Edit Customer";
            this.btnEditCust.UseVisualStyleBackColor = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // txtEditCustID
            // 
            this.txtEditCustID.Location = new System.Drawing.Point(194, 136);
            this.txtEditCustID.Name = "txtEditCustID";
            this.txtEditCustID.ReadOnly = true;
            this.txtEditCustID.Size = new System.Drawing.Size(140, 31);
            this.txtEditCustID.TabIndex = 19;
            // 
            // txtEditSize
            // 
            this.txtEditSize.Location = new System.Drawing.Point(194, 192);
            this.txtEditSize.Name = "txtEditSize";
            this.txtEditSize.ReadOnly = true;
            this.txtEditSize.Size = new System.Drawing.Size(140, 31);
            this.txtEditSize.TabIndex = 17;
            // 
            // txtEditIToppingID
            // 
            this.txtEditIToppingID.Location = new System.Drawing.Point(194, 242);
            this.txtEditIToppingID.Name = "txtEditIToppingID";
            this.txtEditIToppingID.ReadOnly = true;
            this.txtEditIToppingID.Size = new System.Drawing.Size(140, 31);
            this.txtEditIToppingID.TabIndex = 15;
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(194, 90);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(140, 31);
            this.txtEditID.TabIndex = 13;
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
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(154, 276);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(140, 31);
            this.txtOrderPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price:";
            // 
            // chkPrice
            // 
            this.chkPrice.AutoSize = true;
            this.chkPrice.Location = new System.Drawing.Point(22, 296);
            this.chkPrice.Name = "chkPrice";
            this.chkPrice.Size = new System.Drawing.Size(99, 29);
            this.chkPrice.TabIndex = 26;
            this.chkPrice.Text = "Price:";
            this.chkPrice.UseVisualStyleBackColor = true;
            this.chkPrice.CheckedChanged += new System.EventHandler(this.chkPrice_CheckedChanged);
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(194, 294);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.ReadOnly = true;
            this.txtEditPrice.Size = new System.Drawing.Size(140, 31);
            this.txtEditPrice.TabIndex = 25;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddOrder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAddOrder;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderToppingsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkToppings;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkCustID;
        private System.Windows.Forms.DataGridView dgvEditOrder;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.TextBox txtEditCustID;
        private System.Windows.Forms.TextBox txtEditSize;
        private System.Windows.Forms.TextBox txtEditIToppingID;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPrice;
        private System.Windows.Forms.TextBox txtEditPrice;
    }
}