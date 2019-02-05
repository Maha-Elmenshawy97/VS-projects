using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brille_code
{
    public partial class Form1 : Form
    {
        Graphics draw;

        public Form1()
        {
            InitializeComponent();
            draw = Area.CreateGraphics();
            
        }

        private void click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            //int x, y;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a'||input[i]=='1')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);        
                }
                if (input[i] == 'b' || input[i] == '2')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'c' || input[i] == '3')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'd' || input[i] == '4')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);

                }
                if (input[i] == 'e' || input[i] == '5')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'f' || input[i] == '6')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'g' || input[i] == '7')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'h' || input[i] == '8')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'i' || input[i] == '9')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'j' || input[i] == '0')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'k')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'l')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'm')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'n')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'o')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'p')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'q')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'r')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 's')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 't')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'u')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'v')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'w')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);

                }
                if (input[i] == 'x')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'y')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'z')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'A')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'B')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'C')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'D')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'E')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'F')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'G')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'H')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);

                }
                if (input[i] == 'I')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'J')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'K')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'L')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'M')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'N')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'O')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'P')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'Q')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'R')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'S')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                }
                if (input[i] == 'T')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == 'U')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'V')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'W')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);

                }
                if (input[i] == 'X')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'Y')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == 'Z')
                {
                    draw.FillPie(Brushes.Black, 15 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == '.')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == '@')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == ';')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == '!')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == '?')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
                if (input[i] == ':')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == ',')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 20, 10, 10, 0, 360);
                }
                if (input[i] == '#')
                {
                    draw.FillPie(Brushes.Black, 50 + i * 35, 30, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 10, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 20, 10, 10, 0, 360);
                    draw.FillPie(Brushes.Black, 65 + i * 35, 30, 10, 10, 0, 360);
                }
            }
        }
    }
}
