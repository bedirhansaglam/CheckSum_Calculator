using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CheckSum
{
    public partial class VeriGonder : Form
    {
        public VeriGonder()
        {
            InitializeComponent();
        }

        private void VeriGonder_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_veri.Value != 100 )
            {
                pb_veri.Value += 1;
                label2.Text = "%" + pb_veri.Value;
            }
            if (pb_veri.Value == 100)
            {
                this.Hide();
            }

        }
    }
}
