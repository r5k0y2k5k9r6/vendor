using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    public partial class Form2 : helloworld.Form_orig
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �{�^�����������Ƃ��̃��O�����
            this.log(this, sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �{�^�����������Ƃ��̃��O�����
            this.log(this, sender, e);

            // ���̉�ʂɈړ�����
            Form3 newform = new Form3();    // �����Ŏ��ɕ\������t�H�[���𐶐����Ă���
            newform.Show();
            this.Dispose();
        }
    }
}

