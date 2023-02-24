using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2_Menu
{
    public partial class Menu : Form
    {
        List<string> list_base = new List<string>();
        List<string> list_ingredients = new List<string>();
        List<int> list_basePrice = new List<int>();
        List<int> list_ingredientsPrice = new List<int>();
        List<string> list_sauce = new List<string>();
        List<string> list_sugar = new List<string>();
        List<string> list_size = new List<string>();

        int selectedBowl;
        int selectedBasePrice;
        int selectedIngredientsPrice;
        int selectedTotalPrice;
        string selectedBase;
        string selectedIngredients;
        string selectedSugar;
        string selectedSize;
        string selectedSauce;
        


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {   
            //基底
            //key
            list_base.Add("牛奶雪花冰");
            list_base.Add("抹茶雪花冰");
            list_base.Add("巧克力雪花冰");
            list_base.Add("剉冰");
            //value
            list_basePrice.Add(40);
            list_basePrice.Add(50);
            list_basePrice.Add(60);
            list_basePrice.Add(70);

            for(int i = 0; i < list_basePrice.Count; i++)
            {
                string strBasePrice = list_base[i] + "     " + list_basePrice[i] + "元";
                listBox_base.Items.Add(strBasePrice);
            }

            /*foreach(string baseItem in list_base)
            {
                listBox_base.Items.Add(baseItem);
            }*/

            //配料
            //key
            list_ingredients.Add("紅豆");
            list_ingredients.Add("綠豆");
            list_ingredients.Add("花生");
            list_ingredients.Add("真男人不加料");
            //value
            list_ingredientsPrice.Add(30);
            list_ingredientsPrice.Add(40);
            list_ingredientsPrice.Add(50);
            list_ingredientsPrice.Add( 0);

            for (int j = 0; j < list_ingredientsPrice.Count; j++)
            {
                string strIngredientsPrice = list_ingredients[j] + "     " + list_ingredientsPrice[j] + "元";
                listBox_ingredients.Items.Add(strIngredientsPrice);
            }

            /*foreach (string ingredientsItem in list_ingredients)
            {
                listBox_ingredients.Items.Add(ingredientsItem);
            }*/

            //醬汁            
            list_sauce.Add("黑糖");
            list_sauce.Add("煉乳");
            list_sauce.Add("蜂蜜");
            
            foreach(string sauceItem in list_sauce)
            {
                comboBox_sauce.Items.Add(sauceItem);
            }

            //糖度
            list_sugar.Add("螞蟻人加爆");
            list_sugar.Add("正常就好");
            list_sugar.Add("我糖尿病");

            foreach(string sugarQty in list_sugar)
            {
                comboBox_sugar.Items.Add(sugarQty);
            }

            //份量
            list_size.Add("用臉盆裝");
            list_size.Add("用碗公裝");
            list_size.Add("用布丁盒裝");

            foreach(string bowlSize in list_size)
            {
                comboBox_size.Items.Add(bowlSize);
            }

            //listBox預設值
            txt_bowl.Text = "1";
            selectedBowl = 1;
            comboBox_sauce.SelectedIndex = 0;
            comboBox_size.SelectedIndex = 0;
            comboBox_sugar.SelectedIndex = 0;

            //電話欄
            txt_phoneNum.ShortcutsEnabled = false;  // 不啟用快速鍵
             //int numbers = 0;
        }


        private void listBox_base_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_base.SelectedIndex > -1)
            {
                selectedBase = list_base[listBox_base.SelectedIndex];
                selectedBasePrice = list_basePrice[listBox_base.SelectedIndex];
            }

            lbl_unitPrice.Text = selectedBasePrice.ToString();

            countTotalPrice();
        }

        private void listBox_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ingredients.SelectedIndex > -1)
            {
                selectedIngredients = list_ingredients[listBox_ingredients.SelectedIndex];
                selectedIngredientsPrice = list_ingredientsPrice[listBox_ingredients.SelectedIndex];
            }

            lbl_unitPrice.Text = (selectedBasePrice + selectedIngredientsPrice).ToString();

            countTotalPrice();
        }



        private void comboBox_sauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSauce = list_sauce[comboBox_sauce.SelectedIndex];
        }

        private void comboBox_sugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSugar = list_sugar[comboBox_sugar.SelectedIndex];
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSize = list_size[comboBox_size.SelectedIndex];
        }


        private void txt_bowl_TextChanged(object sender, EventArgs e)
        {
            if (txt_bowl.Text.Length > 0)
            {
                selectedBowl = Convert.ToInt32(txt_bowl.Text); //欄位檢查(try catch/try parse)
                countTotalPrice();
            }
        }

        void countTotalPrice()
        {
            
            selectedTotalPrice = (selectedIngredientsPrice + selectedBasePrice) * selectedBowl;
            lbl_totalPrice.Text = string.Format("{0}元", selectedTotalPrice);
            
        }


        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            if (txt_buyer.Text != "" && txt_phoneNum.Text != "" )
            {

                ArrayList orderItemInfo = new ArrayList();
                orderItemInfo.Add(selectedBase);
                orderItemInfo.Add(selectedIngredients);
                orderItemInfo.Add(selectedBasePrice + selectedIngredientsPrice);
                //orderItemInfo.Add(selectedIngredients);
                //orderItemInfo.Add(selectedIngredientsPrice);
                orderItemInfo.Add(selectedBowl);
                orderItemInfo.Add(selectedTotalPrice);
                orderItemInfo.Add(selectedSauce);
                orderItemInfo.Add(selectedSugar);
                orderItemInfo.Add(selectedSize);

                /*string strBuyerInfo = txt_buyer.Text;

                if (chbox_plasticBag.Checked == true)
                {
                    strBuyerInfo += " 買塑膠袋";
                    MessageBox.Show("地球表示:X!");
                }

                if (chbox_tableware.Checked == true)
                {
                    strBuyerInfo += " 附餐具";
                    MessageBox.Show("自己洗碗很難?");
                }

                if (radio_forHere.Checked == true)
                { //內用
                    strBuyerInfo += " 內用";
                }
                else
                { 
                    if(radio_toGo.Checked == true)
                    {
                        strBuyerInfo += " 外帶";
                    }
                    else
                    {
                        if(radio_delivery.Checked == true)
                        {
                            strBuyerInfo += " 外送";
                        }
                    }                    
                }*/

                //GlobalVar.BuyerInfo = strBuyerInfo;
                methods();
                check();
                GlobalVar.OrderItemList.Add(orderItemInfo);
                MessageBox.Show("幫你加了，多吃一點");
            }
            else
            {
                MessageBox.Show("訂購人跟電話都不填是要拿去普渡?");
                
            }

            
        }

        private void btn_checkOrder_Click(object sender, EventArgs e)
        {

            FormOrderList formOrder = new FormOrderList();
            formOrder.ShowDialog();
        }

        private void txt_buyer_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BuyerName = txt_buyer.Text;
        }

        private void txt_phoneNum_TextChanged(object sender, EventArgs e)
        {
            txt_phoneNum.MaxLength = 10;           
            GlobalVar.BuyerPhone = txt_phoneNum.Text;
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BuyerAddress = txt_address.Text;
        }


        private void radio_delivery_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radio_delivery.Checked)
            {
                MessageBox.Show("記得填地址!");
            }*/

            if (txt_address.Text == string.Empty && radio_delivery.Checked)
            {
                MessageBox.Show("沒地址我只能燒給你了<3");
            }

        }

        void methods()
        {
            string methods = "";

            if (chbox_plasticBag.Checked == true)
            {
                methods += " 買塑膠袋";
                MessageBox.Show("地球表示:X!");
            }

            if (chbox_tableware.Checked == true)
            {
                methods += " 附餐具";
                MessageBox.Show("自己洗碗很難?");
            }

            if (radio_forHere.Checked == true)
            { //內用
                methods += " 內用";
            }
            else
            {
                if (radio_toGo.Checked == true)
                {
                    methods += " 外帶";
                }
                else
                {
                    if (radio_delivery.Checked == true)
                    {
                        methods += " 外送";
                    }
                }
            }
            GlobalVar.methods = methods;
        }

        public void plasticbags()
        {
            if(chbox_plasticBag.Checked == true)
            {
                GlobalVar.plasticbags = GlobalVar.plasticbags + 30;
            }
        }

        public void tableware()
        {
            if (chbox_tableware.Checked == true)
            {
                GlobalVar.tableware = GlobalVar.tableware + 30;
            }
        }

        public void check()
        {
            if (Convert.ToInt32(txt_bowl.Text) <= 0)
            {
                MessageBox.Show("你這碗數是來亂的?");
                Application.Exit();
            }

        }

    }
}
