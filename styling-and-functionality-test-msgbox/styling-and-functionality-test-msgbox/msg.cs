using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace styling_and_functionality_test_msgbox
{
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
            this.Icon = styling_and_functionality_test_msgbox.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg2_1 m21 = new msg2_1();
            m21.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msg2 m2 = new msg2();
            m2.Show();
            Hide();
        }

        private void msg_Load(object sender, EventArgs e)
        {

        }
    }
}
