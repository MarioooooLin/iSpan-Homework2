namespace Homework_2_Menu
{
    partial class FormOrderList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_orderTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_cancelThis = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.comboBox_payMethod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_buyerName = new System.Windows.Forms.Label();
            this.lbl_buyerPhone = new System.Windows.Forms.Label();
            this.lbl_buyerAddress = new System.Windows.Forms.Label();
            this.listBox_orderList = new System.Windows.Forms.ListBox();
            this.lbl_methods = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(280, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購品項列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(73, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂購人資料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(207, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(207, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "電話";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(207, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "地址";
            // 
            // lbl_orderTotalPrice
            // 
            this.lbl_orderTotalPrice.AutoSize = true;
            this.lbl_orderTotalPrice.BackColor = System.Drawing.Color.Yellow;
            this.lbl_orderTotalPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderTotalPrice.Location = new System.Drawing.Point(537, 611);
            this.lbl_orderTotalPrice.Name = "lbl_orderTotalPrice";
            this.lbl_orderTotalPrice.Size = new System.Drawing.Size(197, 24);
            this.lbl_orderTotalPrice.TabIndex = 10;
            this.lbl_orderTotalPrice.Text = "訂單總價 xxxx 元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(79, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "輸入折扣碼";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_discount.Location = new System.Drawing.Point(177, 608);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(186, 30);
            this.txt_discount.TabIndex = 12;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(379, 611);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(44, 24);
            this.btn_discount.TabIndex = 13;
            this.btn_discount.Text = "確認";
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_cancelThis
            // 
            this.btn_cancelThis.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancelThis.Location = new System.Drawing.Point(277, 666);
            this.btn_cancelThis.Name = "btn_cancelThis";
            this.btn_cancelThis.Size = new System.Drawing.Size(153, 42);
            this.btn_cancelThis.TabIndex = 29;
            this.btn_cancelThis.Text = "移除所選品項";
            this.btn_cancelThis.UseVisualStyleBackColor = true;
            this.btn_cancelThis.Click += new System.EventHandler(this.btn_cancelThis_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_deleteAll.Location = new System.Drawing.Point(447, 666);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(150, 42);
            this.btn_deleteAll.TabIndex = 30;
            this.btn_deleteAll.Text = "清除所有品項";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_checkout.Location = new System.Drawing.Point(613, 666);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(125, 42);
            this.btn_checkout.TabIndex = 31;
            this.btn_checkout.Text = "結帳去";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // comboBox_payMethod
            // 
            this.comboBox_payMethod.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_payMethod.FormattingEnabled = true;
            this.comboBox_payMethod.Location = new System.Drawing.Point(79, 680);
            this.comboBox_payMethod.Name = "comboBox_payMethod";
            this.comboBox_payMethod.Size = new System.Drawing.Size(121, 24);
            this.comboBox_payMethod.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(79, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "付款方式";
            // 
            // lbl_buyerName
            // 
            this.lbl_buyerName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_buyerName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_buyerName.Location = new System.Drawing.Point(279, 90);
            this.lbl_buyerName.Name = "lbl_buyerName";
            this.lbl_buyerName.Size = new System.Drawing.Size(181, 28);
            this.lbl_buyerName.TabIndex = 34;
            this.lbl_buyerName.Text = "XXX";
            // 
            // lbl_buyerPhone
            // 
            this.lbl_buyerPhone.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_buyerPhone.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_buyerPhone.Location = new System.Drawing.Point(279, 127);
            this.lbl_buyerPhone.Name = "lbl_buyerPhone";
            this.lbl_buyerPhone.Size = new System.Drawing.Size(181, 28);
            this.lbl_buyerPhone.TabIndex = 35;
            this.lbl_buyerPhone.Text = "XXX";
            // 
            // lbl_buyerAddress
            // 
            this.lbl_buyerAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_buyerAddress.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_buyerAddress.Location = new System.Drawing.Point(279, 164);
            this.lbl_buyerAddress.Name = "lbl_buyerAddress";
            this.lbl_buyerAddress.Size = new System.Drawing.Size(463, 28);
            this.lbl_buyerAddress.TabIndex = 36;
            this.lbl_buyerAddress.Text = "XXX";
            // 
            // listBox_orderList
            // 
            this.listBox_orderList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_orderList.FormattingEnabled = true;
            this.listBox_orderList.ItemHeight = 15;
            this.listBox_orderList.Location = new System.Drawing.Point(59, 204);
            this.listBox_orderList.Name = "listBox_orderList";
            this.listBox_orderList.Size = new System.Drawing.Size(700, 394);
            this.listBox_orderList.TabIndex = 38;
            // 
            // lbl_methods
            // 
            this.lbl_methods.BackColor = System.Drawing.Color.SpringGreen;
            this.lbl_methods.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_methods.ForeColor = System.Drawing.Color.Red;
            this.lbl_methods.Location = new System.Drawing.Point(516, 96);
            this.lbl_methods.Name = "lbl_methods";
            this.lbl_methods.Padding = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.lbl_methods.Size = new System.Drawing.Size(243, 42);
            this.lbl_methods.TabIndex = 39;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(816, 738);
            this.Controls.Add(this.lbl_methods);
            this.Controls.Add(this.listBox_orderList);
            this.Controls.Add(this.lbl_buyerAddress);
            this.Controls.Add(this.lbl_buyerPhone);
            this.Controls.Add(this.lbl_buyerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_payMethod);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_deleteAll);
            this.Controls.Add(this.btn_cancelThis);
            this.Controls.Add(this.btn_discount);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_orderTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderList";
            this.Text = "訂購單列表";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_orderTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_cancelThis;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ComboBox comboBox_payMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_buyerName;
        private System.Windows.Forms.Label lbl_buyerPhone;
        private System.Windows.Forms.Label lbl_buyerAddress;
        private System.Windows.Forms.ListBox listBox_orderList;
        private System.Windows.Forms.Label lbl_methods;
    }
}