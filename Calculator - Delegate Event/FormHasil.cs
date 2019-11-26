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
    public partial class FormHasil : Form
    {
        public FormHasil()
        {
            InitializeComponent();
        }

        private void b_hitung_Click(object sender, EventArgs e)
        {
            FormHitung frmHitung = new FormHitung();
            frmHitung.OnHitung += FormHitung_OnHitung;
            frmHitung.Show();
        }

        void FormHitung_OnHitung(String displayHasil){
            lv_hasil.View = View.List;
            ListViewItem item = new ListViewItem();
            item.Text = displayHasil;
            lv_hasil.Items.Add(item);
        }

    }
}
