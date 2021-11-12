using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekilisProgrami
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtxtAdaylar_TextChanged(object sender, EventArgs e)
        {
            lblSayi.Text = rtxtAdaylar.Lines.Count().ToString();
            if (rtxtAdaylar.Lines.Count()>0)
            {
                nMiktar.Maximum = rtxtAdaylar.Lines.Count();

            }
            else
            {
                nMiktar.Maximum = 1;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgList.ColumnCount = 2;
            dtgList.Columns[0].Name = "sıra no";
            dtgList.Columns[1].Name = "Ad Soyad";

        }
        int cekilissay = 1;
        private void btnCekilis_Click(object sender, EventArgs e)
        {
            
            int cekilissayisi = Convert.ToInt32(nMiktar.Text);
            List<string> Adaylar = new List<string>(rtxtAdaylar.Text.Split('\n'));
            if (rtxtAdaylar.Text == "")
            {
                MessageBox.Show("adayları giriniz");
            }
            else
            {
                Random uret = new Random();
                for (int i = 0; i < cekilissayisi; i++)
                {
                    int kazananaday = uret.Next(0, Adaylar.Count);
                    dtgList.Rows.Add(cekilissay++, Adaylar[kazananaday]);
                    Adaylar.Remove(Adaylar[kazananaday]);


                }
            }
        }

        private void btnYeniCekilis_Click(object sender, EventArgs e)
        {
            rtxtAdaylar.Clear();
            dtgList.Rows.Clear();
            cekilissay = 1;
            nMiktar.Value = 1;
        }

        private void nMiktar_ValueChanged(object sender, EventArgs e)
        {
            nMiktar.Maximum = rtxtAdaylar.Lines.Count();

        }
    }
}
