using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mazegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 50; int y = 50; int t,z; 
        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            e.Graphics.FillRectangle(Brushes.DarkRed, x+350, y, 50, 50);
            
            e.Graphics.FillRectangle(Brushes.White, x+350, y+100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 350, y + 200, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 350, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 350, y + 300, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 350, y + 350, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 350, y + 400, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 50, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 200, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 300, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x, y + 350, 50, 50);
           
            e.Graphics.FillRectangle(Brushes.White, x + 50, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 50, y + 100, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x + 100, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 100, y + 100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 100, y + 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 100, y + 200, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 100, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 100, y + 350, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x + 150, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 150, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 150, y + 350, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x + 200, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 200, y + 100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 200, y + 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 200, y + 200, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 200, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 200, y + 350, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x + 250, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 250, y + 100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 250, y + 200, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 250, y + 250, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 250, y + 300, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 250, y + 350, 50, 50);

            e.Graphics.FillRectangle(Brushes.White, x + 300, y, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 300, y + 100, 50, 50);
            e.Graphics.FillRectangle(Brushes.White, x + 300, y + 350, 50, 50);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            ////right
            //if ((y == 150) && (x >= -300) && (x < -200))
            //{
            //    z = x + 50;
            //    y = 150; t = x; x = z; z = t;
            //}
            //else if ((y == 300) && (x >= -200) && (x < -50))
            //{
            //    z = x + 50;
            //    y = 300; t = x; x = z; z = t;
            //}
            //else if ((y == 400) && (x >= -200) && (x < 50))
            //{
            //    z = x + 50;
            //    y = 400; t = x; x = z; z = t;
            //}
            ////down
            //else if ((x == -300) && (y >= 50) && (y < 400))
            //{
            //    z = y + 50;
            //    x = -300; t = y; y = z; z = t;
            //}
            //else if ((x == -200) && (y >= 150) && (y < 400) && (y < 300))
            //{
            //    z = y + 50;
            //    x = -200; t = y; y = z; z = t;
            //}
            //else if ((x == -50) && (y >= 250) && (y < 400))
            //{
            //    z = y + 50;
            //    x = -50; t = y; y = z; z = t;
            //}
            //else if ((x == 50) && (y >= 250) && (y < 450))
            //{
            //    z = y + 50;
            //    x = 50; t = y; y = z; z = t;
            //}
            ////left
            //else if ((y == 50) && (x <= 400) && (x > -300))
            //{
            //    z = x - 50;
            //    y = 50; t = x; x = z; z = t;
            //}     
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                down();
            }
            if (e.KeyData == Keys.Up)
            {
                up();
            }
            if (e.KeyData == Keys.Right)
            {
                right();
            }
            if (e.KeyData == Keys.Left)
            {
                left();
            }

            if ((x == 50) && (y == 450))
            {
                MessageBox.Show("you win!!");
            }
        }
        private void down()
        {
            if ((x ==-300) && (y >= 50) && (y < 400))
            {
                z = y + 50;
                x = -300; t = y; y = z; z = t;
            }
            else if ((x == -200) && (y >= 150) && (y < 400) && (y < 300))
            {
                z = y + 50;
                x = -200; t = y; y = z; z = t;
            }
            else if ((x == -100) && (y >= 150) /*&& (y < 400) && (y < 300)*/)
            {
                z = y + 50;
                x = -100; t = y; y = z; z = t;
            }
            else if ((x == -50) && (y >= 250) && (y < 400))
            {
                z = y + 50;
                x = -50; t = y; y = z; z = t;
            }
            else if ((x == 50) && (y >= 250) && (y < 450))
            {
                z = y + 50;
                x =50; t = y; y = z; z = t;
            }
        }
        private void up()
        {
            if ((x ==-200) && ((y > 50) && (y <= 300) && (y > 150)))
            {
                z = y - 50;
                x =-200; t = y; y = z; z = t;
            }
            else if ((x ==-50) && ((y > 50) && (y <= 400) && (y > 250)))
            {
                z = y - 50;
                x = -50; t = y; y = z; z = t;
            }
            else if ((x ==-100) && ((y > 50) && (y <= 300) && (y > 150)))
            {
                z = y - 50;
                x = -100; t = y; y = z; z = t;
            }
            else if ((x == 400) && ((y > 50) && (y <= 400) && (y > 250)))////
            {
                z = y - 50;
                x = 400; t = y; y = z; z = t;
            }
            else if ((x == -300) && (y > 50) && (y <= 400))
            {
                z = y - 50;
                x = -300; t = y; y = z; z = t;
            }
            else if ((x == 50) && ((y > 250) && (y <= 450)))
            {
                z = y - 50;
                x = 50; t = y; y = z; z = t;
            }
        }
        private void right()
        {
            if ((y == 50) && (x >= -300) && (x <50))
            {
                z = x + 50;
                y = 50; t = x; x = z; z = t;
            }
            else if ((y == 150) && (x >= -300) && (x <-200))
            {
                z = x + 50;
                y = 150; t = x; x = z; z = t;
            }
            else if ((y == 300) && (x >= -200) && (x < -50))
            {
                z = x + 50;
                y = 300; t = x; x = z; z = t;
            }
            else if ((y == 250) && (x >= -100) && (x < -50))
            {
                z = x + 50;
                y = 250; t = x; x = z; z = t;
            }
            else if ((y == 150) && (x >= -100) && (x < 50))
            {
                z = x + 50;
                y = 150; t = x; x = z; z = t;
            }
            else if ((y == 400) && (x >= -200) && (x < 50))
            {
                z = x + 50;
                y = 400; t = x; x = z; z = t;
            }
        }
        private void left()
        {
            if ((y == 50) && (x <= 50) && (x >-300))
            {
                z = x - 50;
                y = 50; t = x; x = z; z = t;
            }
            else if ((y == 150) && (x <= 50) && (x > -100))
            {
                z = x - 50;
                y = 150; t = x; x = z; z = t;
            }
            else if ((y == 300) && (x <= -50) && (x > -200))
            {
                z = x - 50;
                y = 300; t = x; x = z; z = t;
            }
            else if ((y == 250) && (x >= -50))
            {
                z = x - 50;
                y = 250; t = x; x = z; z = t;
            }
            else if ((y == 150) && (x <= -200) && (x > -300))
            {
                z = x - 50;
                y = 150; t = x; x = z; z = t;
            }
            else if ((y == 400) && (x <= 50) && (x > -200))
            {
                z = x - 50;
                y = 400; t = x; x = z; z = t;
            }
        }


    

   

     

       

       

        
    }
}
