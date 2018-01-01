using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MediaSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElementHost ctrlHost = new ElementHost();
            patternPlayer.CustomPlayer customPlayer = new patternPlayer.CustomPlayer();

            ctrlHost.Height = 250;
            ctrlHost.Width = 350;

            customPlayer.InitializeComponent();

            ctrlHost.Child = customPlayer;
          
            this.panel1.Controls.Add(ctrlHost);

            customPlayer.loadSource("");
        }
    }
}
