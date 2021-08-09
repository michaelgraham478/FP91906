using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP91906
{
    public partial class Form1 : Form
    {
        int treeSpeed = 4;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pinecone.Top += gravity;
        }
        private void treeTimerEvent(object sender, EventArgs e)
        {

        }
        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
    }
}
