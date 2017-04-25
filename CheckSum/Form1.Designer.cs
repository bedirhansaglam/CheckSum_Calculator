namespace CheckSum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_veriekleme = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_altmisdort = new System.Windows.Forms.RadioButton();
            this.rb_onalti = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_veri_gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_check = new System.Windows.Forms.TextBox();
            this.btn_veriekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_veriler = new System.Windows.Forms.ListBox();
            this.tb_veri = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_gonderilen = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_veriekleme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_veriekleme
            // 
            this.gb_veriekleme.Controls.Add(this.label6);
            this.gb_veriekleme.Controls.Add(this.label5);
            this.gb_veriekleme.Controls.Add(this.label3);
            this.gb_veriekleme.Controls.Add(this.groupBox1);
            this.gb_veriekleme.Controls.Add(this.label4);
            this.gb_veriekleme.Controls.Add(this.checkBox1);
            this.gb_veriekleme.Controls.Add(this.btn_veri_gonder);
            this.gb_veriekleme.Controls.Add(this.label2);
            this.gb_veriekleme.Controls.Add(this.tb_check);
            this.gb_veriekleme.Controls.Add(this.btn_veriekle);
            this.gb_veriekleme.Controls.Add(this.label1);
            this.gb_veriekleme.Controls.Add(this.lb_veriler);
            this.gb_veriekleme.Controls.Add(this.tb_veri);
            this.gb_veriekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_veriekleme.Location = new System.Drawing.Point(12, 12);
            this.gb_veriekleme.Name = "gb_veriekleme";
            this.gb_veriekleme.Size = new System.Drawing.Size(734, 753);
            this.gb_veriekleme.TabIndex = 0;
            this.gb_veriekleme.TabStop = false;
            this.gb_veriekleme.Text = "Veri Ekleme Bölümü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "BIN ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_altmisdort);
            this.groupBox1.Controls.Add(this.rb_onalti);
            this.groupBox1.Location = new System.Drawing.Point(282, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rb_altmisdort
            // 
            this.rb_altmisdort.AutoSize = true;
            this.rb_altmisdort.Location = new System.Drawing.Point(122, 11);
            this.rb_altmisdort.Name = "rb_altmisdort";
            this.rb_altmisdort.Size = new System.Drawing.Size(101, 35);
            this.rb_altmisdort.TabIndex = 7;
            this.rb_altmisdort.TabStop = true;
            this.rb_altmisdort.Text = "16 bit";
            this.rb_altmisdort.UseVisualStyleBackColor = true;
            this.rb_altmisdort.CheckedChanged += new System.EventHandler(this.rb_altmisdort_CheckedChanged);
            // 
            // rb_onalti
            // 
            this.rb_onalti.AutoSize = true;
            this.rb_onalti.Location = new System.Drawing.Point(6, 10);
            this.rb_onalti.Name = "rb_onalti";
            this.rb_onalti.Size = new System.Drawing.Size(86, 35);
            this.rb_onalti.TabIndex = 1;
            this.rb_onalti.TabStop = true;
            this.rb_onalti.Text = "8 bit";
            this.rb_onalti.UseVisualStyleBackColor = true;
            this.rb_onalti.CheckedChanged += new System.EventHandler(this.rb_onalti_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bit Sayısı :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(551, 468);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 35);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Aç/Kapa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_veri_gonder
            // 
            this.btn_veri_gonder.Location = new System.Drawing.Point(377, 670);
            this.btn_veri_gonder.Name = "btn_veri_gonder";
            this.btn_veri_gonder.Size = new System.Drawing.Size(313, 77);
            this.btn_veri_gonder.TabIndex = 5;
            this.btn_veri_gonder.Text = "Verileri Gönder";
            this.btn_veri_gonder.UseVisualStyleBackColor = true;
            this.btn_veri_gonder.Click += new System.EventHandler(this.btn_veri_gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "CheckSum:";
            // 
            // tb_check
            // 
            this.tb_check.Enabled = false;
            this.tb_check.Location = new System.Drawing.Point(193, 425);
            this.tb_check.Name = "tb_check";
            this.tb_check.Size = new System.Drawing.Size(517, 38);
            this.tb_check.TabIndex = 1;
            // 
            // btn_veriekle
            // 
            this.btn_veriekle.Location = new System.Drawing.Point(567, 157);
            this.btn_veriekle.Name = "btn_veriekle";
            this.btn_veriekle.Size = new System.Drawing.Size(123, 39);
            this.btn_veriekle.TabIndex = 3;
            this.btn_veriekle.Text = "EKLE";
            this.btn_veriekle.UseVisualStyleBackColor = true;
            this.btn_veriekle.Click += new System.EventHandler(this.btn_veriekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veri Ekle(HEX):";
            // 
            // lb_veriler
            // 
            this.lb_veriler.FormattingEnabled = true;
            this.lb_veriler.ItemHeight = 31;
            this.lb_veriler.Location = new System.Drawing.Point(282, 193);
            this.lb_veriler.Name = "lb_veriler";
            this.lb_veriler.Size = new System.Drawing.Size(223, 190);
            this.lb_veriler.TabIndex = 1;
            // 
            // tb_veri
            // 
            this.tb_veri.Location = new System.Drawing.Point(282, 113);
            this.tb_veri.Name = "tb_veri";
            this.tb_veri.Size = new System.Drawing.Size(408, 38);
            this.tb_veri.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Bedirhan\\Documents\\Visual Studio 2015\\Projects\\CheckSum\\CheckSum\\bin\\Deb" +
    "ug\\datatransfer.png";
            this.pictureBox1.Location = new System.Drawing.Point(685, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 151);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lb_gonderilen
            // 
            this.lb_gonderilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gonderilen.FormattingEnabled = true;
            this.lb_gonderilen.ItemHeight = 29;
            this.lb_gonderilen.Location = new System.Drawing.Point(917, 205);
            this.lb_gonderilen.Name = "lb_gonderilen";
            this.lb_gonderilen.Size = new System.Drawing.Size(221, 178);
            this.lb_gonderilen.TabIndex = 2;
            this.lb_gonderilen.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(768, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Veri Gönderme İşlemi Başarılı";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 777);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_gonderilen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_veriekleme);
            this.Name = "Form1";
            this.Text = "Check Sum Kontrolü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_veriekleme.ResumeLayout(false);
            this.gb_veriekleme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_veriekleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_check;
        private System.Windows.Forms.Button btn_veriekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_veriler;
        private System.Windows.Forms.TextBox tb_veri;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_veri_gonder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_altmisdort;
        private System.Windows.Forms.RadioButton rb_onalti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lb_gonderilen;
        private System.Windows.Forms.Label label7;
    }
}

