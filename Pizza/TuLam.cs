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
    public partial class TuLam : UserControl
    {
        public TuLam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bánh quý khách đã đặt bao gồm :\nSốt cà chua,\n Vỏ bánh : Dòn\n Kích thước : Trung \n\nQuý khách vui lòng thanh toán ở mục THANH TOÁN", "ĐẶT BÁNH THÀNH CÔNG");
        }
    }
}
