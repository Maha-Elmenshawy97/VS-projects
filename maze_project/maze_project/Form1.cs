using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //start point & moves.....
        private void move()
        {
            Point start = panel1.Location;
            start.Offset(380,50);
            Cursor.Position = PointToScreen(start);
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            move();
        }
        //end point.....
        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation you win!!");
        }
    }
}
