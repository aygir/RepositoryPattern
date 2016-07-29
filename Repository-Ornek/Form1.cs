using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  tablo1 veri = new tablo1() { id = 2, var1 = "adasd", var2 = "adsasd" };
            // TESTDB._tablo1.ADD(veri); 

            dataGridView1.DataSource = TESTDB._tablo1.List.ToList();
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = TESTDB._tablo2.List.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablo1 veri = new tablo1();
            veri.id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
            TESTDB._tablo1.DELETE(veri);
        }

        public void foo()
        {
            var biryüz = Enumerable.Range(1, 100);
            var tekler = biryüz.Where(x => x % 2 == 1);
            MessageBox.Show(tekler.Average().ToString());
            tekler.Average();
            tekler.Max();
            tekler.Min(); 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foo();
        }
    }
}
