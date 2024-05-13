namespace AdoNetDemo
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxGroupboxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.groupboxupdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxGroupboxAdd.SuspendLayout();
            this.groupboxupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(57, 65);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 72;
            this.dgwProducts.RowTemplate.Height = 31;
            this.dgwProducts.Size = new System.Drawing.Size(1837, 425);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(53, 54);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(64, 25);
            this.lblNameAdd.TabIndex = 1;
            this.lblNameAdd.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(200, 51);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(181, 29);
            this.tbxName.TabIndex = 2;
            // 
            // gbxGroupboxAdd
            // 
            this.gbxGroupboxAdd.Controls.Add(this.btnAdd);
            this.gbxGroupboxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxGroupboxAdd.Controls.Add(this.lblStockAdd);
            this.gbxGroupboxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxGroupboxAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxGroupboxAdd.Controls.Add(this.tbxName);
            this.gbxGroupboxAdd.Controls.Add(this.lblNameAdd);
            this.gbxGroupboxAdd.Location = new System.Drawing.Point(123, 524);
            this.gbxGroupboxAdd.Name = "gbxGroupboxAdd";
            this.gbxGroupboxAdd.Size = new System.Drawing.Size(441, 343);
            this.gbxGroupboxAdd.TabIndex = 3;
            this.gbxGroupboxAdd.TabStop = false;
            this.gbxGroupboxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAdd.Location = new System.Drawing.Point(241, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(200, 161);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(181, 29);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.AutoSize = true;
            this.lblStockAdd.Location = new System.Drawing.Point(53, 161);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(135, 25);
            this.lblStockAdd.TabIndex = 5;
            this.lblStockAdd.Text = "Stock Amount";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(200, 102);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(181, 29);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(53, 102);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(95, 25);
            this.lblUnitPriceAdd.TabIndex = 3;
            this.lblUnitPriceAdd.Text = "Unit Price";
            // 
            // groupboxupdate
            // 
            this.groupboxupdate.Controls.Add(this.btnUpdate);
            this.groupboxupdate.Controls.Add(this.tbxStockAmountUpdate);
            this.groupboxupdate.Controls.Add(this.lblStockUpdate);
            this.groupboxupdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.groupboxupdate.Controls.Add(this.lblUnitPriceUpdate);
            this.groupboxupdate.Controls.Add(this.tbxNameUpdate);
            this.groupboxupdate.Controls.Add(this.lblNameUpdate);
            this.groupboxupdate.Location = new System.Drawing.Point(741, 524);
            this.groupboxupdate.Name = "groupboxupdate";
            this.groupboxupdate.Size = new System.Drawing.Size(441, 343);
            this.groupboxupdate.TabIndex = 4;
            this.groupboxupdate.TabStop = false;
            this.groupboxupdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(245, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 49);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(200, 161);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(181, 29);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(51, 161);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(135, 25);
            this.lblStockUpdate.TabIndex = 5;
            this.lblStockUpdate.Text = "Stock Amount";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(200, 102);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(181, 29);
            this.tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(51, 105);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(95, 25);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(200, 54);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(181, 29);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(51, 51);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(64, 25);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1447, 741);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(170, 49);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 859);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupboxupdate);
            this.Controls.Add(this.gbxGroupboxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxGroupboxAdd.ResumeLayout(false);
            this.gbxGroupboxAdd.PerformLayout();
            this.groupboxupdate.ResumeLayout(false);
            this.groupboxupdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxGroupboxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.GroupBox groupboxupdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

