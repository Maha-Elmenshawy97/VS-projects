using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze
{
    public partial class Form1 : Form
    {
        int[,] maze ={{1,1,1,1,1,1,1,1,1,1},
                      {1,0,0,0,0,0,0,0,0,1},
                      {1,0,1,1,1,1,1,1,1,1},
                      {1,0,0,0,1,0,0,0,0,1},
                      {1,0,1,0,1,0,1,1,1,1},
                      {1,0,1,0,1,0,0,1,0,1},
                      {1,0,1,0,0,0,0,1,0,1},
                      {1,0,1,1,1,1,0,1,0,1},
                      {1,0,1,0,0,0,0,0,0,1},
                      {1,1,1,1,1,1,1,1,9,1}
                       }; //the target node(9) at position x=8 , y=9 : maze[8,9]//

        private List<int> path = new List<int>();
        public Form1()
        {
            InitializeComponent();

            //start position at x=8 , y=1 : maze[8,1]//
            DFS.searshpath(maze,8, 1, path);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    switch (maze[row, col])
                    {
                        case 1: e.Graphics.FillRectangle(Brushes.Black, 50 * col, 50 * row, 50, 50); break;
                        case 9: e.Graphics.FillRectangle(Brushes.DarkRed, 50 * col, 50 * row, 50, 50); break;
                        default: e.Graphics.FillRectangle(Brushes.White, 50 * col, 50 * row, 50, 50); break;
                    }
                }
            }
            for (int p = 0; p < path.Count; p += 2)
            {
                int pathx = path[p];
                int pathy = path[p + 1];
                e.Graphics.FillRectangle(Brushes.BurlyWood, 50 * pathx, 50 * pathy, 50, 50);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
    }
}
