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
    public partial class FormOrderList : Form
    {
        List<string> list_payMethod = new List<string>(); 
       
        
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {           

            //付款方式
            list_payMethod.Add("魔法小卡");
            list_payMethod.Add("馬斯克的擦手紙");
            list_payMethod.Add("腎");
            list_payMethod.Add("眼角膜");
            foreach (string payMethod in list_payMethod)
            {
                comboBox_payMethod.Items.Add(payMethod);
            }

            lbl_methods.Text = GlobalVar.methods;

            //購買者資訊
            lbl_buyerName.Text = GlobalVar.BuyerName;
            lbl_buyerPhone.Text = GlobalVar.BuyerPhone;
            lbl_buyerAddress.Text = GlobalVar.BuyerAddress;

            foreach (ArrayList OrderItem in GlobalVar.OrderItemList)
            {
                string Item = (string)OrderItem[0];
                string Ingredients = (string)OrderItem[1];
                int UnitPrice = (int)OrderItem[2];
                int Bowls = (int)OrderItem[3];
                int ItemTotalPrice = (int)OrderItem[4];
                string Sauce = (string)OrderItem[5];
                string Sugar = (string)OrderItem[6];
                string Size = (string)OrderItem[7];

                string strItemInfo = string.Format("{0}配{1}, 單價:{2}元, {3}碗, 品項總價:{4}元\n糖水:{5}, 甜度:{6}, {7}\n" + "\n", Item, Ingredients, UnitPrice, Bowls, ItemTotalPrice, Sauce, Sugar, Size);

                listBox_orderList.Items.Add(strItemInfo);
            }
             
            CountTotalPrice();
        }

        private void btn_cancelThis_Click(object sender, EventArgs e)
        {
            if (listBox_orderList.SelectedIndex > -1)
            {

                int selIndex = listBox_orderList.SelectedIndex;

                GlobalVar.OrderItemList.RemoveAt(selIndex);
                listBox_orderList.Items.RemoveAt(selIndex);

                CountTotalPrice();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            listBox_orderList.Items.Clear();           
            GlobalVar.OrderItemList.Clear();
            GlobalVar.BuyerName = "";
            GlobalVar.BuyerPhone = "";
            GlobalVar.BuyerAddress = "";
            CountTotalPrice();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            /*int month = DateTime.Now.Month;
            if (txt_discount.Text == month.ToString()) ;
            {
                lbl_orderTotalPrice.Text = (0.8 * Convert.ToInt32(lbl_orderTotalPrice.Text)).ToString();
            }*/
        }

        void CountTotalPrice()
        {
            int OrderTotalPrice = 0;

            foreach (ArrayList OrderItem in GlobalVar.OrderItemList)
            {
                string Item = (string)OrderItem[0];
                string Ingredients = (string)OrderItem[1];
                int UnitPrice = (int)OrderItem[2];
                int Bowls = (int)OrderItem[3];
                int ItemTotalPrice = (int)OrderItem[4];
                string Sauce = (string)OrderItem[5];
                string Sugar = (string)OrderItem[6];
                string Size = (string)OrderItem[7];

                OrderTotalPrice += ItemTotalPrice;
                
            }

           // if(chb)
          
            lbl_orderTotalPrice.Text = String.Format("訂單總價: {0}元", OrderTotalPrice);
        }

    }
}
