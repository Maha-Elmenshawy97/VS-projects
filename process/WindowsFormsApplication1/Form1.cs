using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.Start();
            Console.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process notepadplus = new Process();
            notepadplus.StartInfo.FileName = "notepad++.exe";
            notepadplus.Start();
            Console.Read();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process brackets = new Process();
            brackets.StartInfo.FileName = "brackets.exe";
            brackets.Start();
            Console.Read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process chrome = new Process();
            chrome.StartInfo.FileName = "chrome.exe";
            chrome.Start();
            Console.Read();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process media_player = new Process();
            media_player.StartInfo.FileName = "wmplayer.exe";
            media_player.Start();
            Console.Read();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process adobe = new Process();
            adobe.StartInfo.FileName = "AcroRd32.exe";
            adobe.Start();
            Console.Read();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        
    }
}
