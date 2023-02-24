namespace Homework_2_Menu
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_delivery = new System.Windows.Forms.RadioButton();
            this.radio_toGo = new System.Windows.Forms.RadioButton();
            this.radio_forHere = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_buyer = new System.Windows.Forms.TextBox();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_base = new System.Windows.Forms.ListBox();
            this.listBox_ingredients = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_sugar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chbox_plasticBag = new System.Windows.Forms.CheckBox();
            this.chbox_tableware = new System.Windows.Forms.CheckBox();
            this.txt_bowl = new System.Windows.Forms.TextBox();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_checkOrder = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_sauce = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(280, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "iSpan冰品店訂購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(53, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "連絡電話";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Controls.Add(this.radio_delivery);
            this.groupBox1.Controls.Add(this.radio_toGo);
            this.groupBox1.Controls.Add(this.radio_forHere);
            this.groupBox1.Location = new System.Drawing.Point(482, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radio_delivery
            // 
            this.radio_delivery.AutoSize = true;
            this.radio_delivery.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_delivery.Location = new System.Drawing.Point(174, 19);
            this.radio_delivery.Name = "radio_delivery";
            this.radio_delivery.Size = new System.Drawing.Size(139, 20);
            this.radio_delivery.TabIndex = 2;
            this.radio_delivery.TabStop = true;
            this.radio_delivery.Text = "外送(請填地址)";
            this.radio_delivery.UseVisualStyleBackColor = true;
            this.radio_delivery.CheckedChanged += new System.EventHandler(this.radio_delivery_CheckedChanged);
            // 
            // radio_toGo
            // 
            this.radio_toGo.AutoSize = true;
            this.radio_toGo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_toGo.Location = new System.Drawing.Point(95, 19);
            this.radio_toGo.Name = "radio_toGo";
            this.radio_toGo.Size = new System.Drawing.Size(59, 20);
            this.radio_toGo.TabIndex = 1;
            this.radio_toGo.TabStop = true;
            this.radio_toGo.Text = "外帶";
            this.radio_toGo.UseVisualStyleBackColor = true;
            // 
            // radio_forHere
            // 
            this.radio_forHere.AutoSize = true;
            this.radio_forHere.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio_forHere.Location = new System.Drawing.Point(15, 19);
            this.radio_forHere.Name = "radio_forHere";
            this.radio_forHere.Size = new System.Drawing.Size(59, 20);
            this.radio_forHere.TabIndex = 0;
            this.radio_forHere.TabStop = true;
            this.radio_forHere.Text = "內用";
            this.radio_forHere.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(53, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "地址(請寫詳細)";
            // 
            // txt_buyer
            // 
            this.txt_buyer.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_buyer.Location = new System.Drawing.Point(172, 91);
            this.txt_buyer.Name = "txt_buyer";
            this.txt_buyer.Size = new System.Drawing.Size(197, 33);
            this.txt_buyer.TabIndex = 5;
            this.txt_buyer.TextChanged += new System.EventHandler(this.txt_buyer_TextChanged);
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phoneNum.Location = new System.Drawing.Point(172, 141);
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(197, 33);
            this.txt_phoneNum.TabIndex = 6;
            this.txt_phoneNum.TextChanged += new System.EventHandler(this.txt_phoneNum_TextChanged);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.Location = new System.Drawing.Point(219, 191);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(582, 33);
            this.txt_address.TabIndex = 7;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(53, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "菜單的部分";
            // 
            // listBox_base
            // 
            this.listBox_base.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_base.FormattingEnabled = true;
            this.listBox_base.ItemHeight = 16;
            this.listBox_base.Location = new System.Drawing.Point(57, 311);
            this.listBox_base.Name = "listBox_base";
            this.listBox_base.Size = new System.Drawing.Size(226, 228);
            this.listBox_base.TabIndex = 9;
            this.listBox_base.SelectedIndexChanged += new System.EventHandler(this.listBox_base_SelectedIndexChanged);
            // 
            // listBox_ingredients
            // 
            this.listBox_ingredients.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_ingredients.FormattingEnabled = true;
            this.listBox_ingredients.ItemHeight = 16;
            this.listBox_ingredients.Location = new System.Drawing.Point(329, 311);
            this.listBox_ingredients.Name = "listBox_ingredients";
            this.listBox_ingredients.Size = new System.Drawing.Size(226, 228);
            this.listBox_ingredients.TabIndex = 10;
            this.listBox_ingredients.SelectedIndexChanged += new System.EventHandler(this.listBox_ingredients_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(56, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "先選基底";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(326, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "再選配料";
            // 
            // comboBox_sugar
            // 
            this.comboBox_sugar.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_sugar.FormattingEnabled = true;
            this.comboBox_sugar.Location = new System.Drawing.Point(611, 397);
            this.comboBox_sugar.Name = "comboBox_sugar";
            this.comboBox_sugar.Size = new System.Drawing.Size(168, 29);
            this.comboBox_sugar.TabIndex = 15;
            this.comboBox_sugar.SelectedIndexChanged += new System.EventHandler(this.comboBox_sugar_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(608, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "選糖水";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(608, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "甜度";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(608, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "份量";
            // 
            // comboBox_size
            // 
            this.comboBox_size.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(611, 469);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(168, 29);
            this.comboBox_size.TabIndex = 18;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aquamarine;
            this.label12.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(53, 569);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "數量";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Aquamarine;
            this.label13.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(231, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "單價";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Aquamarine;
            this.label14.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(421, 569);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "品項總價";
            // 
            // chbox_plasticBag
            // 
            this.chbox_plasticBag.AutoSize = true;
            this.chbox_plasticBag.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chbox_plasticBag.Location = new System.Drawing.Point(611, 525);
            this.chbox_plasticBag.Name = "chbox_plasticBag";
            this.chbox_plasticBag.Size = new System.Drawing.Size(154, 25);
            this.chbox_plasticBag.TabIndex = 23;
            this.chbox_plasticBag.Text = "買塑膠袋+$30";
            this.chbox_plasticBag.UseVisualStyleBackColor = true;
            // 
            // chbox_tableware
            // 
            this.chbox_tableware.AutoSize = true;
            this.chbox_tableware.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chbox_tableware.Location = new System.Drawing.Point(611, 568);
            this.chbox_tableware.Name = "chbox_tableware";
            this.chbox_tableware.Size = new System.Drawing.Size(133, 25);
            this.chbox_tableware.TabIndex = 24;
            this.chbox_tableware.Text = "附餐具+$30";
            this.chbox_tableware.UseVisualStyleBackColor = true;
            // 
            // txt_bowl
            // 
            this.txt_bowl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_bowl.Location = new System.Drawing.Point(52, 603);
            this.txt_bowl.Name = "txt_bowl";
            this.txt_bowl.Size = new System.Drawing.Size(72, 33);
            this.txt_bowl.TabIndex = 25;
            this.txt_bowl.TextChanged += new System.EventHandler(this.txt_bowl_TextChanged);
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.BackColor = System.Drawing.Color.Orange;
            this.lbl_unitPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_unitPrice.Location = new System.Drawing.Point(231, 608);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(78, 24);
            this.lbl_unitPrice.TabIndex = 26;
            this.lbl_unitPrice.Text = "xxxx元";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.BackColor = System.Drawing.Color.Orange;
            this.lbl_totalPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(425, 607);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(78, 24);
            this.lbl_totalPrice.TabIndex = 27;
            this.lbl_totalPrice.Text = "xxxx元";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addOrder.Location = new System.Drawing.Point(193, 681);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(176, 40);
            this.btn_addOrder.TabIndex = 28;
            this.btn_addOrder.Text = "加入訂購單";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_checkOrder
            // 
            this.btn_checkOrder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_checkOrder.Location = new System.Drawing.Point(475, 679);
            this.btn_checkOrder.Name = "btn_checkOrder";
            this.btn_checkOrder.Size = new System.Drawing.Size(172, 42);
            this.btn_checkOrder.TabIndex = 29;
            this.btn_checkOrder.Text = "查看訂購單";
            this.btn_checkOrder.UseVisualStyleBackColor = true;
            this.btn_checkOrder.Click += new System.EventHandler(this.btn_checkOrder_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(133, 615);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 21);
            this.label17.TabIndex = 30;
            this.label17.Text = "碗";
            // 
            // comboBox_sauce
            // 
            this.comboBox_sauce.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_sauce.FormattingEnabled = true;
            this.comboBox_sauce.Location = new System.Drawing.Point(611, 320);
            this.comboBox_sauce.Name = "comboBox_sauce";
            this.comboBox_sauce.Size = new System.Drawing.Size(168, 29);
            this.comboBox_sauce.TabIndex = 31;
            this.comboBox_sauce.SelectedIndexChanged += new System.EventHandler(this.comboBox_sauce_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(483, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "一張單選一種!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(860, 753);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_sauce);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_checkOrder);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_unitPrice);
            this.Controls.Add(this.txt_bowl);
            this.Controls.Add(this.chbox_tableware);
            this.Controls.Add(this.chbox_plasticBag);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_sugar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_ingredients);
            this.Controls.Add(this.listBox_base);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNum);
            this.Controls.Add(this.txt_buyer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "訂購單菜單";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_delivery;
        private System.Windows.Forms.RadioButton radio_toGo;
        private System.Windows.Forms.RadioButton radio_forHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_buyer;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_base;
        private System.Windows.Forms.ListBox listBox_ingredients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_sugar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chbox_plasticBag;
        private System.Windows.Forms.CheckBox chbox_tableware;
        private System.Windows.Forms.TextBox txt_bowl;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button btn_checkOrder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_sauce;
        private System.Windows.Forms.Label label8;
    }
}

