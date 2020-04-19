﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class insertMoney : helloworld.Form_orig
    {
        public insertMoney()
        {
            InitializeComponent();
        }

        private void inputMoney(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            Button btn = (Button)sender;
            money += int.Parse(btn.Text);
            textBox1.Text = money.ToString();
        }
        
        private void insertMoney_Load(object sender, EventArgs e)
        {
            textBox1.Text = money.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            money = 0;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            if (money <= 0) return;

            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);

            if (item_name != null)
            {
                if (item_name.Length > 0) item_name = item_name.Remove(0);
            }
            End end = new End();
            end.Show();
            this.Dispose();
        }
    }
}
