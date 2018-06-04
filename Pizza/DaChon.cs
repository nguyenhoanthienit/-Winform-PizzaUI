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
    public partial class DaChon : UserControl
    {
        public DaChon()
        {
            InitializeComponent();
            choDoi1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choDoi1.BringToFront();
            timer1.Start();
        }
    }
}
