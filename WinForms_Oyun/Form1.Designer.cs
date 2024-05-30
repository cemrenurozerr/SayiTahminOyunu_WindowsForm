namespace WinForms_Oyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnBasla = new Button();
            lblSonuc = new Label();
            nudSayi = new NumericUpDown();
            btnTahmin = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHakaret = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSayi).BeginInit();
            SuspendLayout();
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(214, 22);
            btnBasla.Margin = new Padding(3, 2, 3, 2);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(278, 35);
            btnBasla.TabIndex = 0;
            btnBasla.Text = "OYUNU BAŞLAT";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.BackColor = SystemColors.ActiveCaption;
            lblSonuc.Location = new Point(214, 167);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(278, 38);
            lblSonuc.TabIndex = 1;
            // 
            // nudSayi
            // 
            nudSayi.Location = new Point(320, 76);
            nudSayi.Margin = new Padding(3, 2, 3, 2);
            nudSayi.Name = "nudSayi";
            nudSayi.Size = new Size(172, 23);
            nudSayi.TabIndex = 2;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(214, 112);
            btnTahmin.Margin = new Padding(3, 2, 3, 2);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(278, 34);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "TAHMİN ET";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 76);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Bir Sayı Giriniz:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(214, 222);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(278, 33);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 60000;
            // 
            // lblHakaret
            // 
            lblHakaret.BackColor = SystemColors.ActiveCaption;
            lblHakaret.Location = new Point(214, 278);
            lblHakaret.Name = "lblHakaret";
            lblHakaret.Size = new Size(278, 38);
            lblHakaret.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblHakaret);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(btnTahmin);
            Controls.Add(nudSayi);
            Controls.Add(lblSonuc);
            Controls.Add(btnBasla);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSayi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBasla;
        private Label lblSonuc;
        private NumericUpDown nudSayi;
        private Button btnTahmin;
        private Label label2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lblHakaret;
    }
}