using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elevator
{
    public partial class MainForm : Form
    {
        int minimumFloor = 1;
        int maximumFLoor = 10;
        int maximumPayload = 1000;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.Height < maximumFLoor - minimumFloor * 80)
                tableLayoutPanel.Height = this.Height;
            else
                tableLayoutPanel.Height = (maximumFLoor - minimumFloor-1) * 80;
            
            Console.WriteLine(minimumFloor + "  " + maximumFLoor + "  ");
            for(int i=minimumFloor;i<=maximumFLoor;i++)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
