using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Size : helloworld.Form_orig
    {
        private string temp_name = item_name;

        public Size()
        {
            InitializeComponent();
            label1.Text = item_name;
        }

        
        private void GoMenu_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 商品選択へ
            Menu menu = new Menu();
			buy_ticket(item_name);

            Item temp;// 商品名の構造体
     
            for (int i = 0; i < ItemList.Count; i++)
            {
                temp = ItemList[i];
                // 以下で、一度押した商品の場合は数を増やす
                if (temp.name == item_name)
                {
                    temp.qty++;
                    ItemList[i] = temp;
                    for ( int a = 0; a < ItemList.Count; a++)
                    {
                        menu.checkedListBox1.Items.Add(ItemList[a].name);
                    }
                    menu.Show();
                    this.Dispose();
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
            for (int a = 0; a < ItemList.Count; a++)
            {
                menu.checkedListBox1.Items.Add(ItemList[a].name);
            }
            menu.Show();
            this.Dispose();
           
        }

        private void GoCheck_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 購入確認へ
            Check check = new Check();
            buy_ticket(item_name);
			check.label2.Text = "合計　" + total.ToString() + "　円";

            Item temp;// 商品名の構造体
            for (int s = 0; s < ItemList.Count; s++)
            {
                temp = ItemList[s];
                // 以下で、一度押した商品の場合は数を増やす
                if (temp.name == item_name)
                {
                    temp.qty++;
                    ItemList[s] = temp;
                    for (int t = 0; t < ItemList.Count; t++)
                    {
                        check.richTextBox1.Text += ItemList[t].name + " × " + ItemList[t].qty.ToString() + "個\n";
                    }
                    check.Show();
                    this.Dispose();
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
            for (int i = 0; i < ItemList.Count; i++)
            {
                check.richTextBox1.Text += ItemList[i].name + " × " + ItemList[i].qty.ToString() + "個\n";
            }
            check.Show();
            this.Dispose();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            item_name = temp_name + "（" + size_str[SS] + "）";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            item_name = temp_name + "（" + size_str[S] + "）";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            item_name = temp_name + "（" + size_str[M] + "）";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            item_name = temp_name + "（" + size_str[L] + "）";
			
			
        }

        private void Size_Load(object sender, EventArgs e)
        {
            RadioButton[] rdbtnlist = { radioButton1, radioButton2, radioButton3, radioButton4 };
            
            if (get_price(temp_name,0) == 0)
            {
                rdbtnlist[0].Enabled = false;
                rdbtnlist[0].BackColor = SystemColors.ButtonFace;
            }
            if (get_price(temp_name,3) == 0)
            {
                rdbtnlist[3].Enabled = false;
                rdbtnlist[3].BackColor = SystemColors.ButtonFace;
            }
            for (int i = 0; i < rdbtnlist.Length; i++)
            {
                if (!canBuy(temp_name + "（" + size_str[i] + "）"))
                {
                    rdbtnlist[i].Enabled = false;
                    rdbtnlist[i].BackColor = SystemColors.ButtonFace;
                }
            }


        }
    }
}
