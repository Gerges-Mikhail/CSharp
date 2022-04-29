using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]

        public static extern void mouse_event(int duflags, int x, int y, int cbtn, int dext);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) {
                label1.BackColor = Color.Teal;
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 20);
            }
            if (e.KeyCode == Keys.S)
            {
                label4.BackColor = Color.Teal;
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 20);
            }
            if (e.KeyCode == Keys.A)
            {
                label2.BackColor = Color.Teal;
                Cursor.Position = new Point(Cursor.Position.X - 20, Cursor.Position.Y);
            }
            if (e.KeyCode == Keys.D)
            {
                label3.BackColor = Color.Teal;
                Cursor.Position = new Point(Cursor.Position.X + 20, Cursor.Position.Y);
            }
            if (e.KeyCode == Keys.G)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                label1.BackColor = Color.Transparent;
            }
            if (e.KeyCode == Keys.S)
            {
                label4.BackColor = Color.Transparent;
            }
            if (e.KeyCode == Keys.A)
            {
                label2.BackColor = Color.Transparent;
            }
            if (e.KeyCode == Keys.D)
            {
                label3.BackColor = Color.Transparent;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
