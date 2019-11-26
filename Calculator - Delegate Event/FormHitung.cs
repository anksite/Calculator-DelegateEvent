using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator___Delegate_Event
{
    public partial class FormHitung : Form
    {
        public delegate void EventHandlerHitung(String displayHasil);
        public event EventHandlerHitung OnHitung;

        public FormHitung()
        {
            InitializeComponent();
        }

        private void b_hitung_Click(object sender, EventArgs e)
        {
            int pilih = cb_operasi.SelectedIndex;
            Console.WriteLine("" + pilih);

            int a = Convert.ToInt32(tb_a.Text);
            int b = Convert.ToInt32(tb_b.Text);

            switch (pilih) {
                case 0: OnHitung(tambah(a, b)); break;
                case 1: OnHitung(kurang(a, b)); break;
                case 2: OnHitung(bagi(a, b));   break;
                case 3: OnHitung(kali(a, b));   break;
            }
        }

        string tambah(int a, int b) {
            return "Hasil Penambahan " + a + " + " + b + " = " + (a + b);
        }

        string kurang(int a, int b)
        {
            return "Hasil Pengurangan " + a + " - " + b + " = " + (a - b);
        }

        string kali(int a, int b)
        {
            return "Hasil Perkalian " + a + " X " + b + " = " + (a * b);
        }

        string bagi(int a, int b)
        {
            return "Hasil Pembagian " + a + " : " + b + " = " + (a / b);
        }
    }
}
