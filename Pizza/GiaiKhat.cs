using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class GiaiKhat : UserControl
    {
        public GiaiKhat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quý khách vui lòng thanh toán ở mục THANH TOÁN", "ĐẶT NƯỚC THÀNH CÔNG");
        }
    }
}
