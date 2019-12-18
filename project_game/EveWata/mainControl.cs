using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveWata
{
    public partial class mainControlPanel : UserControl
    {
        public mainControlPanel()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.mainControl.Visible = false;
            Form1.settingControl.Visible = true;
            Form1.settingControl.Dock = DockStyle.Fill;
        }

        private void mainControl_Load(object sender, EventArgs e)
        {

        }
    }
}
