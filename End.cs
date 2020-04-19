using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class End : helloworld.Form_orig
    {
        public End()
        {
            InitializeComponent();
            label3.Text = money.ToString() + "　円";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ボタンを押したときのログを取る
            this.log(this, sender, e);
            
            this.Close();
        }
    }
}
