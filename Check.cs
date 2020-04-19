using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Check : helloworld.Form_orig
    {
        public Check()
        {
            InitializeComponent();
            label2.Text="合計　" + total.ToString() + "　円";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 商品選択へ
            Menu menu = new Menu();
            for (int i = 0; i < ItemList.Count; i++)
            {
                menu.checkedListBox1.Items.Add(ItemList[i].name);
            }
            menu.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            // 購入完了へ
            End end = new End();
            end.Show();
            this.Dispose();
        }


    }
}
