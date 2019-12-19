using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveWata
{
    public partial class Form1 : Form
    {
        public static mainControlPanel mainControl;
        public static settingControlPanel settingControl;
        public static gameControl gameControl;
          

        public Form1()
        {
            InitializeComponent();

            mainControl = new mainControlPanel();
            settingControl = new settingControlPanel();
            gameControl = new gameControl();

            panel1.Controls.Add(mainControl);
            panel1.Controls.Add(settingControl);
            panel1.Controls.Add(gameControl);

            mainControl.Visible = true;
            settingControl.Visible = false;
            gameControl.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
