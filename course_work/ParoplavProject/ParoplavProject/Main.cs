using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParoplavProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_start_Click(object sender, EventArgs e)
        {
            
            Reservoir res = new Reservoir();
            res.Square = int.Parse(txt_sq.Text);
            res.Number = int.Parse(txt_river.Text);
            res.MaxDepth = double.Parse(txt_.Text);
            res.WeightWater = double.Parse(txt_weight.Text);

            lbl_d.Text = res.AverageDepth().ToString();
            if (res.WaterAnalise())
               lbl_w.Text="Маса води бiльша нiж 1000(кг)";
            else
                lbl_w.Text="Маса води менша нiж 1000(кг)";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_next_Click(object sender, EventArgs e)
        {
            Database f = new Database();
            this.Hide();
            f.Show();
        }
    }
}
