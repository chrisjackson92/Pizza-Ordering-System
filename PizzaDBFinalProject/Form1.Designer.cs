namespace PizzaDBFinalProject
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOrdersByCR = new System.Windows.Forms.Button();
            this.btnOpenOrders = new System.Windows.Forms.Button();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.btnOrdersOver10 = new System.Windows.Forms.Button();
            this.btnViewMeatLvrs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(711, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOrdersByCR
            // 
            this.btnOrdersByCR.Location = new System.Drawing.Point(35, 58);
            this.btnOrdersByCR.Name = "btnOrdersByCR";
            this.btnOrdersByCR.Size = new System.Drawing.Size(200, 76);
            this.btnOrdersByCR.TabIndex = 1;
            this.btnOrdersByCR.Text = "Orders By Chris Rock";
            this.btnOrdersByCR.UseVisualStyleBackColor = true;
            this.btnOrdersByCR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenOrders
            // 
            this.btnOpenOrders.Location = new System.Drawing.Point(35, 441);
            this.btnOpenOrders.Name = "btnOpenOrders";
            this.btnOpenOrders.Size = new System.Drawing.Size(161, 81);
            this.btnOpenOrders.TabIndex = 2;
            this.btnOpenOrders.Text = "Create/Edit Order";
            this.btnOpenOrders.UseVisualStyleBackColor = true;
            this.btnOpenOrders.Click += new System.EventHandler(this.btnOpenOrders_Click);
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.Location = new System.Drawing.Point(35, 338);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(161, 83);
            this.btnOpenCustomer.TabIndex = 3;
            this.btnOpenCustomer.Text = "Create/Edit Customer";
            this.btnOpenCustomer.UseVisualStyleBackColor = true;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // btnOrdersOver10
            // 
            this.btnOrdersOver10.Location = new System.Drawing.Point(35, 150);
            this.btnOrdersOver10.Name = "btnOrdersOver10";
            this.btnOrdersOver10.Size = new System.Drawing.Size(200, 61);
            this.btnOrdersOver10.TabIndex = 4;
            this.btnOrdersOver10.Text = "Orders Over $12";
            this.btnOrdersOver10.UseVisualStyleBackColor = true;
            this.btnOrdersOver10.Click += new System.EventHandler(this.btnOrdersOver10_Click);
            // 
            // btnViewMeatLvrs
            // 
            this.btnViewMeatLvrs.Location = new System.Drawing.Point(35, 229);
            this.btnViewMeatLvrs.Name = "btnViewMeatLvrs";
            this.btnViewMeatLvrs.Size = new System.Drawing.Size(200, 61);
            this.btnViewMeatLvrs.TabIndex = 5;
            this.btnViewMeatLvrs.Text = "View Meat Lovers Orders";
            this.btnViewMeatLvrs.UseVisualStyleBackColor = true;
            this.btnViewMeatLvrs.Click += new System.EventHandler(this.btnViewMeatLvrs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 541);
            this.Controls.Add(this.btnViewMeatLvrs);
            this.Controls.Add(this.btnOrdersOver10);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenOrders);
            this.Controls.Add(this.btnOrdersByCR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOrdersByCR;
        private System.Windows.Forms.Button btnOpenOrders;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Button btnOrdersOver10;
        private System.Windows.Forms.Button btnViewMeatLvrs;
    }
}

