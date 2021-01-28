using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyp1
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void aDMINGIRISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yöneticigirişi ag = new Yöneticigirişi();
            ag.Text = "admin giriş paneli:";   
            ag.Show();
        }

        private void uYEGIRISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            üyegirişi ug = new üyegirişi();
            ug.Text = "uye giriş paneli";
            ug.Show();
        }

        private void uYEOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kayıtol uo = new Kayıtol();
            uo.Text = "uye olma paneli";
            uo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gIRISYAPINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yöneticigirişi ag = new Yöneticigirişi();
            ag.Text = "admin giriş paneli:";
            ag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyegirişi ug = new üyegirişi();
            ug.Text = "uye giriş paneli";
            ug.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıtol uo = new Kayıtol();
            uo.Text = "uye olma paneli";
            uo.Show();

        }
    }
}
