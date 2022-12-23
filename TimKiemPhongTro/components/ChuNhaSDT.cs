using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKiemPhongTro.components
{
    public partial class ChuNhaSDT : UserControl
    {
        public ChuNhaSDT()
        {
            InitializeComponent();
        }

        private void btnZalo_Click(object sender, EventArgs e)
        {

        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {

        }

        private void ptbZalo_Click(object sender, EventArgs e)
        {
            btnZalo_Click(sender, e);
        }

        private void ptbTim_Click(object sender, EventArgs e)
        {
            btnYeuThich_Click(sender, e);
        }
    }
}
