using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water;

namespace ParoplavProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool type = true;
        List<Reservoir> reservoirList;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_start_Click(object sender, EventArgs e)
        {
            ReservoirCreator classCreator = type ? new Water.LakeCreator(): (ReservoirCreator)(new Water.PondCreator());
            var obj = classCreator.reservoir();
            
            if (obj.GetType().ToString() == "Water.Lake")
            {

                Lake lake = new Lake();
                lake.Name = txt_name.Text;
                lake.Square = int.Parse(txt_sq.Text);
                lake.Number = int.Parse(txt_river.Text);
                lake.WeightWater = int.Parse(txt_weight.Text);
                lake.MaxDepth = int.Parse(txt_.Text);
                reservoirList.Add(lake);

            }

            else if (obj.GetType().ToString() == "Water.Pond")
            {
                Pond lake = new Pond();
                lake.Name = txt_name.Text;
                lake.Square = int.Parse(txt_sq.Text);
                lake.Number = int.Parse(txt_river.Text);
                lake.WeightWater = int.Parse(txt_weight.Text);
                lake.MaxDepth = int.Parse(txt_.Text);
                reservoirList.Add(lake);
            }

            lbl_see.Visible = true;
         
        }

     
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm f1 = new MenuForm();
            this.Hide();
            f1.Show();
        }

        private void lbl_next_Click(object sender, EventArgs e)
        {
            Database f = new Database();
            this.Hide();
            f.Show();
        }

        private void rb_lake_CheckedChanged(object sender, EventArgs e)
        {
        
            type = true;
        }

        private void rb_pond_CheckedChanged(object sender, EventArgs e)
        {
         
            type = false;
        }

        private void lbl_add_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            reservoirList = new List<Reservoir>();
        }

        private void lbl_n_Click(object sender, EventArgs e)
        {
            if (type)
            {
                lbl_berths.Visible = true;
                lbl_intake.Visible = true;
                lbl_level.Visible = true;
                lbl_salt.Visible = true;
                lbl_in.Visible = true;
                txt_intake.Visible = true;
                txt_berths.Visible = true;
                txt_salt.Visible = true;
                txt_level.Visible = true;
                //lbl_header.Text += " нового озера";
            }
            else {
                lbl_places.Visible = true;
                lbl_dust.Visible = true;
                txt_colvo.Visible = true;
                txt_dust.Visible = true;
            }

            txt_river.Visible = false;
            txt_sq.Visible = false;
            txt_weight.Visible = false;
            txt_.Visible = false;
            txt_name.Visible = false;
            lbl_name.Visible = false;
            lbl_w.Visible = false;
            lbl_max.Visible = false;
            lbl_depth.Visible = false;
            lbl_sq.Visible = false;
            lbl_rivers.Visible = false;
            rb_pond.Visible = false;
            rb_lake.Visible = false;
            lbl_type.Visible = false;

            
            lbl_start.Visible = true;
            lbl_n.Visible = false;
            lbl_back.Visible = true;
            
        }

        private void lbl_database_Click(object sender, EventArgs e)
        {

           
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            txt_river.Visible = true;
            txt_sq.Visible = true;
            txt_weight.Visible = true;
            txt_.Visible = true;
            txt_name.Visible = true;
            lbl_name.Visible = true;
            lbl_w.Visible = true;
            lbl_max.Visible = true;
            lbl_depth.Visible = true;
            lbl_sq.Visible = true;
            lbl_rivers.Visible = true;
            rb_pond.Visible = true;
            rb_lake.Visible = true;
            lbl_type.Visible = true;


            lbl_start.Visible = false;
            lbl_n.Visible = true;
            lbl_back.Visible = false;
            lst_depth.Visible = false;
            lst_names.Visible = false;
            lst_square.Visible = false;
            lbl_start.Visible = false;
            lbl_depth_head.Visible = false;
            lbl_name_head.Visible = false;
            lbl_sq_head.Visible = false;

            lbl_places.Visible = false;
            lbl_dust.Visible = false;
            txt_colvo.Visible = false;
            txt_dust.Visible = false;

            lbl_n.Visible = true;
            lbl_see.Visible = false;
        }

        private void lbl_see_Click(object sender, EventArgs e)
        {
            lbl_start.Visible = false;
            lst_names.Visible = true;
            lst_depth.Visible = true;
            lst_square.Visible = true;
            lbl_depth_head.Visible = true;
            lbl_name_head.Visible = true;
            lbl_sq_head.Visible = true;
            lst_names.Items.Clear();
            lst_square.Items.Clear();
            lst_depth.Items.Clear();
            for (int j = 0; j < reservoirList.Count - 1; j++)
            {
                for (int i = 0; i < reservoirList.Count - j - 1; i++)
                    if ((new Reservoir()).compareBySquare(reservoirList[i], reservoirList[i + 1]) == 1)
                    {
                        Reservoir temp = reservoirList[i];
                        reservoirList[i] = reservoirList[i + 1];
                        reservoirList[i + 1] = temp;
                    }
            }
            for (int j = 0; j < reservoirList.Count - 1; j++)
            {
                for (int i = 0; i < reservoirList.Count - j - 1; i++)
                    if ((new Reservoir()).compareByName(reservoirList[i], reservoirList[i + 1]) == 1)
                    {
                        Reservoir temp = reservoirList[i];
                        reservoirList[i] = reservoirList[i + 1];
                        reservoirList[i + 1] = temp;
                    }
            }
            for (int i = 0; i < reservoirList.Count; i++)
            {
                lst_names.Items.Add(reservoirList[i].Name);
                lst_square.Items.Add(reservoirList[i].Square);
                lst_depth.Items.Add(reservoirList[i].MaxDepth);
            }

            if (type)
            {
                lbl_berths.Visible = false;
                lbl_intake.Visible = false;
                lbl_level.Visible = false;
                lbl_salt.Visible = false;
                lbl_in.Visible = false;
                txt_intake.Visible = false;
                txt_berths.Visible = false;
                txt_salt.Visible = false;
                txt_level.Visible = false;
            }
            else
            {
                lbl_places.Visible = false;
                lbl_dust.Visible = false;
                txt_colvo.Visible = false;
                txt_dust.Visible = false;
            }
        }
    }
}
