using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckSum
{
    public partial class Form1 : Form
    {
        int timer_sayac = 0;

        int sayi_tabani=16;

        Int64 toplam_altmisdort;
        Int64 checksum_altmisdort;

        int checksum_onalti;
        int toplam_onalti;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_veriekle_Click(object sender, EventArgs e)
        {
           

            if (tb_veri.Text == "")
            {
                MessageBox.Show("Lütfen bir değer ekleyiniz...");
            }
            else
            {
                    if (rb_onalti.Checked)
                    {
                        int sayi_onalti = 0;
                        
                        sayi_onalti = Convert.ToInt32(tb_veri.Text, sayi_tabani); //Hexadecimal değerler alınıyor
                        lb_veriler.Items.Add(Convert.ToString(sayi_onalti,sayi_tabani));
                        toplam_onalti += sayi_onalti;

                        if (toplam_onalti > 255)//16 bit sınırı aşılırsa modunu alarak işlem yapılır
                        {
                            toplam_onalti = toplam_onalti % 255;
                        }

                        checksum_onalti = 255 - toplam_onalti; //2 ye tümleyeni alınıyor 
                      
                        tb_check.Text = Convert.ToString(checksum_onalti, 2); //CheckSum Binary karşılığı
                        label5.Text = "HEX : " + Convert.ToString(checksum_onalti, 16);//CheckSum Hexadecimal karşılığı
                        label3.Text = "DEC : " + checksum_onalti.ToString();//CheckSum decimal karşılığı

                }
                    else if (rb_altmisdort.Checked)
                    {
                        Int64 sayi_altmisdort = 0;
                        sayi_altmisdort = Convert.ToInt32(tb_veri.Text, sayi_tabani);

                        lb_veriler.Items.Add(Convert.ToString(sayi_altmisdort,sayi_tabani));
                        toplam_altmisdort += sayi_altmisdort;

                        if (toplam_altmisdort > 65535) //64 bit sınırı aşılırsa modunu alarak işlem yapılıyor
                        {
                            toplam_altmisdort = toplam_altmisdort % 65535;
                        }
                        checksum_altmisdort = 65535 - toplam_altmisdort; //2'ye tümleyeni alınıyor. 65535=FFFF
                       
                        tb_check.Text = Convert.ToString(checksum_altmisdort, 2);//CheckSum Binary karşılığı
                    label5.Text="HEX : "+ Convert.ToString(checksum_altmisdort, 16);//CheckSum Hexadecimal karşılığı
                    label3.Text = "DEC : " + checksum_altmisdort.ToString();//CheckSum decimal karşılığı

                }

                    else {
                        MessageBox.Show("Kaç bit sayı girmek istiyorsunuz lütfen belirtin");
                    }
                  
                tb_veri.Clear();
                tb_veri.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tb_check.Enabled = true;
            else
                tb_check.Enabled = false;
           
        }

        private void btn_veri_gonder_Click(object sender, EventArgs e)
        { 
           int  checksumkontrol = 0;
           long cskontrol = 0;

            if (rb_onalti.Checked)
            {

                checksumkontrol = Convert.ToInt32(tb_check.Text, 2) + toplam_onalti + 1;
                if (checksumkontrol == 256)
                {
                    checksumkontrol = checksumkontrol % 256;
                    MessageBox.Show("Checksum Değeri:"+ Convert.ToString(checksumkontrol, 2) + " 'a eşit , Veri iletimini başlatmak için Tamam'a basınız...");
                    VeriGonder v1 = new VeriGonder();
                    v1.Show();
                    timer1.Start();

                }
                else
                {
                    checksumkontrol = checksumkontrol % 256;
                    MessageBox.Show("Checksum Değerinde Değişiklik Yapılmış \n Checksum Değeri :" + Convert.ToString(checksumkontrol, 2), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else if (rb_altmisdort.Checked)
            {
                cskontrol = Convert.ToInt64(tb_check.Text,2)+ toplam_altmisdort + 1;
                if (cskontrol == 65536)
                {
                    cskontrol = cskontrol % 65536;
                    MessageBox.Show("Checksum Değeri:" + Convert.ToString(cskontrol, 2)+" 'a eşit , Veri iletimini başlatmak için Tamam'a basınız...");
                    VeriGonder v1 = new VeriGonder();
                    v1.Show();
                    timer1.Start();
                    
                }
                else
                {
                    cskontrol = cskontrol % 65536;
                    MessageBox.Show("Checksum Değerinde Değişiklik Yapılmış \n Checksum Değeri :" + Convert.ToString(cskontrol, 2),"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }

        }

        private void rb_onalti_CheckedChanged(object sender, EventArgs e)
        {
            tb_veri.MaxLength = 2;
            rb_altmisdort.Enabled = false;
        }

        private void rb_altmisdort_CheckedChanged(object sender, EventArgs e)
        {
            tb_veri.MaxLength = 4;
            rb_onalti.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            info();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer_sayac == 0)
            {
                this.Width = 950;
                pictureBox1.Visible = true;
            }
            else if (timer_sayac == 1)
            {
                this.Width = 1200;
                lb_gonderilen.Visible = true;
            }
            else if (timer_sayac == 3)
            {
                for (int i = 0; i < lb_veriler.Items.Count; i++)
                {
                    lb_gonderilen.Items.Add(lb_veriler.Items[i].ToString());
                }
            }
            else if (timer_sayac == 5)
            {
                label7.Visible = true;
                gb_veriekleme.Enabled = false;
                timer1.Stop();
            }
            timer_sayac++;
        }

        void info()
        {
            MessageBox.Show(" CheckSum Kontroller \n\t Bedirhan Sağlam Tarafından Geliştirildi \n\t\t bedirhansaglam.com", "Uygulama Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
