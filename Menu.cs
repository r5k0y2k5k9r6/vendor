using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Menu : helloworld.Form_orig
    {
        private void CanMenu()
        {
            Button[] btnlist = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                                 button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                                 button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                                 button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
                                 button41, button42, button43, button44, button45, button46, button47, button48, button49, button50,
                                 button51, button52, button53, button54, button55, button56, button57, button58, button59, button60,
                                 button61, button62, button63, button64, button65, button66, button67, button68, button69, button70,button71,button72 };
            
            for (int i = 0; i < btnlist.Length; i++)
            {
                item_name = btnlist[i].Text;
                if ((i >= 0 && i <= 9) || i == 36 || i == 40 || (i >= 47 && i <= 49))
                {
                    item_name += "（" + size_str[S] + "）";
                }
                if (i == 10)
                {
                    item_name += "（" + size_str[SS] + "）";
                }

                if (!canBuy(item_name))
                {
                    btnlist[i].Enabled = false;
                    btnlist[i].BackColor = SystemColors.ButtonFace;
                }
                else
                {
                    btnlist[i].Enabled = true;
                    btnlist[i].BackColor = Color.Cornsilk;
                }
            }
        }

        public Menu()
        {
            InitializeComponent();
            RicePanel.Visible = true;
            NoodlePanel.Visible = false;
            DishPanel.Visible = false;
            SubPanel.Visible = false;
            DessertPanel.Visible = false;
        }

        private void NoodleBtn_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            RicePanel.Visible = false;
            NoodlePanel.Visible = true;
            DishPanel.Visible = false;
            SubPanel.Visible = false;
            DessertPanel.Visible = false;
        }

        private void DishBtn_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            RicePanel.Visible = false;
            NoodlePanel.Visible = false;
            DishPanel.Visible = true;
            SubPanel.Visible = false;
            DessertPanel.Visible = false;
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            RicePanel.Visible = false;
            NoodlePanel.Visible = false;
            DishPanel.Visible = false;
            SubPanel.Visible = true;
            DessertPanel.Visible = false;
        }

        private void DessertBtn_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            RicePanel.Visible = false;
            NoodlePanel.Visible = false;
            DishPanel.Visible = false;
            SubPanel.Visible = false;
            DessertPanel.Visible = true;
        }

        private void RiceBtn_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            RicePanel.Visible = true;
            NoodlePanel.Visible = false;
            DishPanel.Visible = false;
            SubPanel.Visible = false;
            DessertPanel.Visible = false;
        }

        private void SelectSize(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            Button btn = (Button)sender;
            item_name = btn.Text.Replace("\r\n", "");
            Size size = new Size();
            size.Show();
            this.Dispose();
        }     

        private void BuyTicket(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            int tempMoney = money;
            Button btn = (Button)sender;
            item_name = btn.Text.Replace("\r\n", "");
            buy_ticket(item_name);

            label2.Text = money.ToString() + "　円";
            checkedListBox1.Items.Add(item_name);
            
            Item temp;// 商品名の構造体
            for (int i = 0; i < ItemList.Count; i++)
            {
                temp = ItemList[i];
                // 以下で、一度押した商品の場合は数を増やす
                if (temp.name == item_name)
                {
                    temp.qty++;
                    ItemList[i] = temp;
                    return;
                }
            }

            // ここからは、はじめて押した場合の処理 
            // 新しくItemの構造体を作って、商品名などを格納
            temp = new Item();
            temp.name = item_name;
            temp.price = get_price(item_name);
            temp.qty = 1;
            // 購入リストに追加する
            ItemList.Add(temp);

            CanMenu();

        }

        private void GoInsert_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
           this.log(this, sender, e);

            //リスト消去
            ItemList.Clear();
            // 金銭投入へ
           insertMoney insert = new insertMoney();
           insert.Show();
            this.Dispose();
        }

        private void GoCheck_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            // 購入確認へ
            Check check = new Check();
            for (int i = 0; i < ItemList.Count; i++)
            {
                check.richTextBox1.Text += ItemList[i].name +" × " + ItemList[i].qty.ToString() + "個\n";
            }
            check.Show();
            this.Dispose();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text = money.ToString() + "　円";
            CanMenu();
        }

        private void AllCheck_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void ClearCheck_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void DeleteList_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            do
            {
                item_name = checkedListBox1.CheckedItems[0].ToString();
                Item temp;// 商品名の構造体
                for (int i = 0; i < ItemList.Count; i++)
                {
                    temp = ItemList[i];
                    // 以下で、一度押した商品の場合は数を増やす
                    if (temp.name == item_name)
                    {
                        temp.qty--;
                        ItemList[i] = temp;
                        if(temp.qty == 0)
                        {
                            ItemList.RemoveAt(i);
                        }
                    }
                }
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                money += get_price(item_name);
                total -= get_price(item_name);                                
            } while (checkedListBox1.CheckedItems.Count > 0);
           CanMenu();
            label2.Text = money.ToString() + "　円";
            

        }
    }
}
