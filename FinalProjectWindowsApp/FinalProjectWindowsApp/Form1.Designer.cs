namespace FinalProjectWindowsApp
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
            this.tabAdd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbItemIMDB = new System.Windows.Forms.TextBox();
            this.tbItemType = new System.Windows.Forms.TextBox();
            this.tbItemQty = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.tbItemImage = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdateDelete = new System.Windows.Forms.TabPage();
            this.lblItemID = new System.Windows.Forms.Label();
            this.comboOrderId = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.tbShipQty = new System.Windows.Forms.TextBox();
            this.tbItemId = new System.Windows.Forms.TextBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAdd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.tabPage1);
            this.tabAdd.Controls.Add(this.tabUpdateDelete);
            this.tabAdd.Location = new System.Drawing.Point(13, 37);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.SelectedIndex = 0;
            this.tabAdd.Size = new System.Drawing.Size(544, 311);
            this.tabAdd.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.tbItemIMDB);
            this.tabPage1.Controls.Add(this.tbItemType);
            this.tabPage1.Controls.Add(this.tbItemQty);
            this.tabPage1.Controls.Add(this.tbItemPrice);
            this.tabPage1.Controls.Add(this.tbItemImage);
            this.tabPage1.Controls.Add(this.tbItemName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbItemIMDB
            // 
            this.tbItemIMDB.Location = new System.Drawing.Point(72, 179);
            this.tbItemIMDB.Name = "tbItemIMDB";
            this.tbItemIMDB.Size = new System.Drawing.Size(215, 20);
            this.tbItemIMDB.TabIndex = 11;
            // 
            // tbItemType
            // 
            this.tbItemType.Location = new System.Drawing.Point(72, 146);
            this.tbItemType.Name = "tbItemType";
            this.tbItemType.Size = new System.Drawing.Size(215, 20);
            this.tbItemType.TabIndex = 10;
            // 
            // tbItemQty
            // 
            this.tbItemQty.Location = new System.Drawing.Point(72, 111);
            this.tbItemQty.Name = "tbItemQty";
            this.tbItemQty.Size = new System.Drawing.Size(215, 20);
            this.tbItemQty.TabIndex = 9;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(72, 83);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(215, 20);
            this.tbItemPrice.TabIndex = 8;
            // 
            // tbItemImage
            // 
            this.tbItemImage.Location = new System.Drawing.Point(72, 52);
            this.tbItemImage.Name = "tbItemImage";
            this.tbItemImage.Size = new System.Drawing.Size(215, 20);
            this.tbItemImage.TabIndex = 7;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(72, 15);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(215, 20);
            this.tbItemName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imdb ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // tabUpdateDelete
            // 
            this.tabUpdateDelete.Controls.Add(this.lblItemID);
            this.tabUpdateDelete.Controls.Add(this.comboOrderId);
            this.tabUpdateDelete.Controls.Add(this.btnDelete);
            this.tabUpdateDelete.Controls.Add(this.tbShipAddress);
            this.tabUpdateDelete.Controls.Add(this.tbShipQty);
            this.tabUpdateDelete.Controls.Add(this.tbItemId);
            this.tabUpdateDelete.Controls.Add(this.tbUserId);
            this.tabUpdateDelete.Controls.Add(this.label9);
            this.tabUpdateDelete.Controls.Add(this.label10);
            this.tabUpdateDelete.Controls.Add(this.label11);
            this.tabUpdateDelete.Controls.Add(this.label12);
            this.tabUpdateDelete.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateDelete.Name = "tabUpdateDelete";
            this.tabUpdateDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdateDelete.Size = new System.Drawing.Size(536, 285);
            this.tabUpdateDelete.TabIndex = 1;
            this.tabUpdateDelete.Text = "Orders";
            this.tabUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(15, 20);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(47, 13);
            this.lblItemID.TabIndex = 28;
            this.lblItemID.Text = "Order ID";
            // 
            // comboOrderId
            // 
            this.comboOrderId.FormattingEnabled = true;
            this.comboOrderId.Location = new System.Drawing.Point(80, 12);
            this.comboOrderId.Name = "comboOrderId";
            this.comboOrderId.Size = new System.Drawing.Size(121, 21);
            this.comboOrderId.TabIndex = 27;
            this.comboOrderId.SelectedIndexChanged += new System.EventHandler(this.comboOrderId_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(80, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(215, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Enabled = false;
            this.tbShipAddress.Location = new System.Drawing.Point(80, 139);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(321, 20);
            this.tbShipAddress.TabIndex = 22;
            // 
            // tbShipQty
            // 
            this.tbShipQty.Enabled = false;
            this.tbShipQty.Location = new System.Drawing.Point(80, 111);
            this.tbShipQty.Name = "tbShipQty";
            this.tbShipQty.Size = new System.Drawing.Size(321, 20);
            this.tbShipQty.TabIndex = 21;
            // 
            // tbItemId
            // 
            this.tbItemId.Enabled = false;
            this.tbItemId.Location = new System.Drawing.Point(80, 80);
            this.tbItemId.Name = "tbItemId";
            this.tbItemId.Size = new System.Drawing.Size(321, 20);
            this.tbItemId.TabIndex = 20;
            // 
            // tbUserId
            // 
            this.tbUserId.Enabled = false;
            this.tbUserId.Location = new System.Drawing.Point(80, 43);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(321, 20);
            this.tbUserId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Item Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Item ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "User ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 360);
            this.Controls.Add(this.tabAdd);
            this.Name = "Form1";
            this.Text = "ABC Online Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAdd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabUpdateDelete.ResumeLayout(false);
            this.tabUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbItemIMDB;
        private System.Windows.Forms.TextBox tbItemType;
        private System.Windows.Forms.TextBox tbItemQty;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.TextBox tbItemImage;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabUpdateDelete;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox comboOrderId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.TextBox tbShipQty;
        private System.Windows.Forms.TextBox tbItemId;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

