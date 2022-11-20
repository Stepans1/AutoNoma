

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace AutoNoma
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.paswordBox.AutoSize = false;
            this.paswordBox.Size = new Size(this.paswordBox.Size.Width, 43);
        }

        private void CloseButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButon_MouseEnter(object sender, EventArgs e)
        {
            CloseButon.BackColor = Color.Red;
        }

        private void CloseButon_MouseLeave(object sender, EventArgs e)
        {
            CloseButon.BackColor = Color.Turquoise;
        }

        private void LoginText_Paint(object sender, PaintEventArgs e)
        {

        }

        Point lastPoint;
        private void LoginForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginFormButtonReg_Click(object sender, EventArgs e)
        {
            RegForm rg = new RegForm();
            
            
            rg.Show();
            this.Hide();
        }
        private SqlConnection SqlConnection = null;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["KeyDB"].ConnectionString);
            SqlConnection.Open();
            if (SqlConnection.State==ConnectionState.Open)
            {
                MessageBox.Show("Conekt est");
            }
        }
    }
}
