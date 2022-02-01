using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2_kolackasimon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool JePrvocislo(int cislo)
        {
            int pomocne;
            if (cislo <= 1) { return false; }
            if (cislo == 2) { return true; }
            if (cislo % 2 == 0) { return false; }   
            for (pomocne = 3; pomocne < cislo / 2; pomocne += 2)
            {
                if (cislo % pomocne == 0) { return false; }
            }
            return true;
        }

        public void Prepis(int[] vsechnycisla)
        {
            foreach (int k in vsechnycisla)
            {
                if (JePrvocislo(k)) { listBox1.Items.Add(k); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear();
            int vstup = int.Parse(textBoxVstup.Text);
            int[] vsechnycisla = new int[vstup];
            for (int i = 0; i < vstup; i++)
            {
                vsechnycisla[i] = rnd.Next(2, 16);
                listBox2.Items.Add(vsechnycisla[i]);
            }
            Prepis(vsechnycisla);
        }
    }
}
