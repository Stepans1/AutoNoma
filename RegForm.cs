using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoNoma
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.RegFormBoxPassword.AutoSize = false;
            this.RegFormBoxPassword.Size = new Size(this.RegFormBoxPassword.Size.Width, 30);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Point lastPoint;

        private void RegFormButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegFormButtonBack_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

      
    }
}
