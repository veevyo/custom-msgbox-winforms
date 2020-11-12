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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            this.Icon = styling_and_functionality_test_msgbox.Properties.Resources.icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg m = new msg();
            m.Show();
            Hide();
        }
    }
}
