using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class ГрафическийРедактор: Form
    {
        Bitmap pic;
        Graphics g;
        Pen p;
        SolidBrush brush;
        int x1,y1;

        private void Draw(int x1,int y1,int x2, int y2)
        {
            brush = new SolidBrush(p.Color);
            switch (tool_comboBox.SelectedIndex)
            {
                case 0:g.DrawLine(p, x1, y1, x2, y2);break;
                case 1: g.DrawRectangle(p, x1, y1,x2-x1,y2-y1);g.FillRectangle(brush, x1, y1, x2 - x1, y2 - y1); break;
                case 2: g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1); ; g.FillEllipse(brush, x1, y1, x2 - x1, y2 - y1); break;
                    case 3:g.DrawLine(p,x1, y1, x2, y2); break;
            }
        } 

        public ГрафическийРедактор()
        {
            pic = new Bitmap(1000,1000);
            InitializeComponent();
            tool_comboBox.SelectedIndex = 0;
            toolColor_comboBox.SelectedIndex = 0;
            thickness_numericUpDown.Value = 1;
            backgroundColor_comboBox.SelectedIndex = 0;
            g = Graphics.FromImage(pic);
            pictureBox1.BackColor=Color.White;
            pictureBox1.Image = pic;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(Color.FromName(toolColor_comboBox.SelectedItem.ToString()), Convert.ToUInt16(Math.Truncate(thickness_numericUpDown.Value)));
            if (e.Button == MouseButtons.Left&&tool_comboBox.SelectedIndex==0)
            {
                Draw( x1,y1,e.X,e.Y);
                pictureBox1.Image = pic;
                x1 = e.X;
                y1 = e.Y;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Transparent);
            pictureBox1.Image = pic;
        }

        private void backgroundColor_button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox1.BackColor = Color.FromName(backgroundColor_comboBox.SelectedItem.ToString());
            pictureBox1.Image = pic;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
                x1 = e.X;
                y1 = e.Y;
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool_comboBox.SelectedIndex != 0)
            {
                Draw(x1, y1, e.X, e.Y);
                pictureBox1.Image = pic;
            }
        }
    }
}
