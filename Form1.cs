using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Project.Properties;

namespace Tic_Tac_Toe_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Disable_pb()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;
        }
        void Change_Image(object sender)
        {
            ((PictureBox)sender).Enabled = false;
            if (lblTurn.Text == "Player 1")
            {
                ((PictureBox)sender).Image = Resources.Screenshot_2026_04_02_124301;
                ((PictureBox)sender).Tag = "X";
                lblTurn.Text = "Player 2";
                lblTurn.ForeColor = Color.FromArgb(250, 105, 120);
                Check_Winner();
            }
            else
            {
                ((PictureBox)sender).Image = Resources.Screenshot_2026_04_02_124342;
                ((PictureBox)sender).Tag = "O";
                lblTurn.Text = "Player 1";
                lblTurn.ForeColor = Color.FromArgb(84, 200, 248);
                Check_Winner();

            }
        }
        bool Check_Value(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if(pb1.Tag != "?" && (pb1.Tag == pb2.Tag && pb2.Tag == pb3.Tag))
            {
                pb1.BackColor = Color.FromArgb(45, 212, 191);
                pb2.BackColor = Color.FromArgb(45, 212, 191);
                pb3.BackColor = Color.FromArgb(45, 212, 191);
                lblTurn.Text = "Game Over";
                lblTurn.ForeColor = Color.FromArgb(45, 212, 191);

                if (pb1.Tag == "X")
                {
                    lblWinner.Text = "Player 1";
                    MessageBox.Show("Congratulation Player 1", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable_pb();
                    return true;
                }
                else
                {
                    lblWinner.Text = "Player 2";
                    MessageBox.Show("Congratulation Player 2", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disable_pb();
                    return true;
                }
            }
            return false;
        }
        void Check_Winner()
        {
            //Check row1
            if (Check_Value(pb1, pb2, pb3))
                return;

            //Check row2
            if (Check_Value(pb4, pb5, pb6))
                return;

            //Check row3
            if (Check_Value(pb7, pb8, pb9))
                return;

            //Check col1
            if (Check_Value(pb1, pb4, pb7))
                return;

            //Check col2
            if (Check_Value(pb2, pb5, pb8))
                return;

            //Check col3
            if (Check_Value(pb3, pb6, pb9))
                return;

            //Check Diagonal1
            if (Check_Value(pb1, pb5, pb9))
                return;

            //Check Diagonal2
            if (Check_Value(pb3, pb5, pb7))
                return;


            else if (!(pb1.Enabled || pb2.Enabled || pb3.Enabled || pb4.Enabled || pb5.Enabled || pb6.Enabled || pb7.Enabled || pb8.Enabled || pb9.Enabled))
            {
                lblTurn.Text = "Game Over";
                lblTurn.ForeColor = Color.FromArgb(45, 212, 191);
                lblWinner.Text = "Draw";
                MessageBox.Show("Draw", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           // this.Text = $"X = {e.X}, Y = {e.Y}";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color,12);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 320, 230, 850, 230);
            e.Graphics.DrawLine(pen, 320, 370, 850, 370);
            e.Graphics.DrawLine(pen, 490, 110, 490, 515);
            e.Graphics.DrawLine(pen, 665, 110, 665, 515);
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(71, 85, 105);
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            Change_Image(sender);
        }

        void Reset_Button(object sender)
        {
            ((PictureBox)sender).Enabled = true;
            ((PictureBox)sender).Tag = "?";
            ((PictureBox)sender).Image = Resources.Screenshot_2026_04_02_124355;
            ((PictureBox)sender).BackColor = Color.Transparent;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset_Button(pb1);
            Reset_Button(pb2);
            Reset_Button(pb3);
            Reset_Button(pb4);
            Reset_Button(pb5);
            Reset_Button(pb5);
            Reset_Button(pb6);
            Reset_Button(pb7);
            Reset_Button(pb8);
            Reset_Button(pb9);
            lblTurn.Text = "Player 1";
            lblTurn.ForeColor = Color.FromArgb(84, 200, 248);
            lblWinner.Text = "In Progress";
        }
    }
}
