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
    public partial class settingControlPanel : UserControl
    {
        public settingControlPanel()
        {
            InitializeComponent();

            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.settingControl.Visible = false;
            Form1.mainControl.Visible = true;
            Form1.mainControl.Dock = DockStyle.Fill;
        }
    }
}
