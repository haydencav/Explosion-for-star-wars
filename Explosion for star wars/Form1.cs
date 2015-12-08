using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explosion_for_star_wars
{
    public partial class Form1 : Form

    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        public void Explosion(float x, float y, float pixels)
        {
            Pen pencil = new Pen(Color.White, 1);
            //g.DrawRectangle(pencil, x, y, pixels, pixels);
            g.DrawLine(pencil, x + pixels / 10, y + pixels / 10, x + pixels * 9 / 10, y + pixels * 9 / 10);
            g.DrawLine(pencil, x + pixels / 10, y + pixels *9 / 10, x + pixels *9 / 10, y + pixels / 10);
            g.DrawLine(pencil, x + pixels / 10, y + pixels / 2, x + pixels * 9 / 10, y + pixels / 2);
            g.DrawLine(pencil, x + pixels / 2, y + pixels / 10, x + pixels / 2, y + pixels * 9 / 10);
            g.DrawEllipse(pencil, x, y, pixels, pixels);
            g.DrawEllipse(pencil, x + pixels / 8, y + pixels / 8, pixels * 3 / 4, pixels * 3 / 4);
            g.DrawEllipse(pencil, x + pixels / 4, y + pixels / 4, pixels / 2, pixels / 2);
            g.DrawEllipse(pencil, x + pixels * 3 / 8, y + pixels * 3 / 8, pixels / 4, pixels / 4);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Explosion(10, 20, 200);            
        }
    }
}
