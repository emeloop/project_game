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
    public partial class gameControl : UserControl
    {
        public gameControl()
        {
            InitializeComponent();
            
        }

        private void gameSceneControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.gameControl.Visible = false;
            Form1.mainControl.Visible = true;
            Form1.mainControl.Dock = DockStyle.Fill;
        }

        private void testString_Click(object sender, EventArgs e)
        {

        }

        private void backGroundPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
