using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_W
{
    public partial class Anasayfa : Form
    {
        bool sidebarExpend;

        public Anasayfa()
        {
            InitializeComponent();
           
        }
        
        private void sidebartimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpend)
            {
                siderbar.Width -= 10;
                if (siderbar.Width == siderbar.MinimumSize.Width)

                {
                    sidebarExpend = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                siderbar.Width += 10;
                if (siderbar.Width == siderbar.MaximumSize.Width)
                {
                    sidebarExpend = true;
                    sidebartimer.Stop();
                }
            }

        }

        private void menubutonu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }





        private void siderbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            Arabalar frm = new Arabalar();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt frm = new Kayıt();
            frm.ShowDialog();
        }

        private void siderbar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hakkımızda frm = new Hakkımızda();
            frm.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            İletisim frm = new İletisim();
            frm.ShowDialog();
        }

        private void hometimer_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ayarlar frm = new Ayarlar();
            frm.ShowDialog();
        }
    }

}


