using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace helloworld
{
    // ���̃t�H�[���͎����̂��߂̃f�[�^���擾���邽�߂ɕK�v�ł��D
    // �f�U�C���͕ύX���Ă����܂��܂���i�����ɉe���͂Ȃ��j���C�폜������
    // �i�悭�킩��Ȃ��܂܁j�C�x���g�n���h����ύX���Ȃ����ƁD
    //                                      by kuramoto (20080414)

    public partial class Form1 : helloworld.Form_orig
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1 �����ꂽ�Ƃ��ɏ��߂ă��O�t�@�C�����쐬����B
            // ���̃R�[�h�i�ƃC�x���g�n���h���j�͕ύX���Ă͂Ȃ�Ȃ��B
            this.start_log();
			this.create_menulist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // �{�^�����������Ƃ��̃��O�����
            this.log(this, sender, e);

            // ���̉�ʂɈړ�����
            insertMoney newform = new insertMoney();
            newform.Show();
            this.Hide();    // ���̃R�[�h��Form1�Ƒ��̃t�H�[���ňႤ�̂Œ���
        }


    }
}

