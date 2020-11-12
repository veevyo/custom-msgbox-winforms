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
    public partial class msg2_1 : Form
    {
        public msg2_1()
        {
            InitializeComponent();
            this.Icon = styling_and_functionality_test_msgbox.Properties.Resources.icon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
