using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water;

namespace ParoplavProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_add_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            this.Hide();
            f.Show();
        }

        private void lbl_database_Click(object sender, EventArgs e)
        {
            Database f1 = new Database();
            this.Hide();
            f1.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }
    }
}
