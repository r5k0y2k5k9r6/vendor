namespace helloworld
{
    partial class Form1
    {
        /// <summary>
        /// �K�v�ȃf�U�C�i�ϐ��ł��B
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// �g�p���̃��\�[�X�����ׂăN���[���A�b�v���܂��B
        /// </summary>
        /// <param name="disposing">�}�l�[�W ���\�[�X���j�������ꍇ true�A�j������Ȃ��ꍇ�� false �ł��B</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h

        /// <summary>
        /// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
        /// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(203, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(600, 450);
            this.button2.TabIndex = 1;
            this.button2.Text = "�������J�n����";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "�����J�n";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
    }
}
