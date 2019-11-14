using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParoplavProject
{
    public partial class Database : Form
    {
        DataSet ds;
        DataView dv1, dv2;
        public static string nameXMLfile = "Set.xml";
        public static int currentRow = 0;
        bool isChangesSaved = true;
        string s;
        public Database()
        {
            InitializeComponent();
        }
        void LoadXmlFile()
        {
            ds = new DataSet();
            FileStream fsReadXml = new FileStream(nameXMLfile, FileMode.Open);
            ds.ReadXml(fsReadXml, XmlReadMode.InferTypedSchema);
            fsReadXml.Close();
            dv1 = new DataView(ds.Tables[0]);
            dataGridView1.DataSource = dv1;
            string s = dataGridView1.Rows[0].Cells[0].Value.ToString();
            dv2 = new DataView(ds.Tables[1]);
            //   dv2.RowFilter = "Номер = '" + s + "'";
            dataGridView3.DataSource = dv2;

            dataGridView1.DataSource = dv1;
            //dataGridView1.Columns[5].HeaderText = "Як доїхати";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 110;
            //dataGridView1.Columns[5].Width = 100;
            //taGridView1.Columns[6].Width = 70;
            dataGridView3.Columns[0].Width = 100;
            dataGridView3.Columns[1].Width = 220;
            //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill; 
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Файлы XML (*.xml)|*.xml";
            openFileDialog1.FileName = "Set.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameXMLfile = openFileDialog1.FileName;
                LoadXmlFile();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXmlFile();
        }
        void SaveXmlFile()
        {
            FileStream fswritexml = new FileStream(nameXMLfile, FileMode.Create);
            ds.WriteXml(fswritexml);
            fswritexml.Close();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsChangesSaved = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Sets_.xml";
            sfd.Filter = "XML Files(*.xml) | *.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                FileStream fsWriteDB = new FileStream(sfd.FileName, FileMode.Create);
                ds.WriteXml(fsWriteDB);
                fsWriteDB.Close();
                IsChangesSaved = true;
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXmlFile();
        }

        private void подробнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dv1.AddNew();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;
            int i;
            i = currentRow;
            s = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (MessageBox.Show("Ви действительно хотите удалить этого клиента " + s + "?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                isChangesSaved = false;
                dv1.Delete(currentRow);
            }
        }

        private void cортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbSort.Visible = true;
            // gbFilter.Visible = false;
        }

        private void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbFilter.Visible = true;
            gbSort.Visible = false;
        }
        string Filter = "";

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Database_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Файлы XML (*.xml)|*.xml";
            openFileDialog1.FileName = "Set.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nameXMLfile = openFileDialog1.FileName;
                LoadXmlFile();
            }
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveXmlFile();
        }

        private void сохранитьКакToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool IsChangesSaved = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Sets_.xml";
            sfd.Filter = "XML Files(*.xml) | *.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                FileStream fsWriteDB = new FileStream(sfd.FileName, FileMode.Create);
                ds.WriteXml(fsWriteDB);
                fsWriteDB.Close();
                IsChangesSaved = true;
            }
        }

        private void обновитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadXmlFile();
        }

        private void добавитьЗаписьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dv1.AddNew();
        }

        private void удалитьЗаписьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string s;
            int i;
            i = currentRow;
            s = dataGridView1.Rows[i].Cells[0].Value.ToString();
            if (MessageBox.Show("Ви действительно хотите удалить этого клиента " + s + "?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                isChangesSaved = false;
                dv1.Delete(currentRow);
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            string s;
            int i = e.RowIndex;
            currentRow = i;
            if (!dataGridView1.Rows[i].Cells[1].Value.Equals(DBNull.Value))
            {

                lblsetname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                //string spict = dataGridView1.Rows[i].Cells[0].Value.ToString() + ".jpg";
                //if (spict != "Нет" && spict != "")
                //{
                //    pict.Load("Images\\" + spict);
                //}
                //else
                //{
                //    pict.Load("Images\\1.jpg");
                //}
                //s = dataGridView1.Rows[i].Cells[0].Value.ToString();

                //dataGridView2.DataSource = dv2;
            }
        }

        private void фильтрацияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gbFilter.Visible = true;
            gbSort.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                textBox4.Enabled = true;
                textBox5.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dv1.RowFilter = "";
            string sFilter0 = Filter;
            if (textBox1.Text != "") sFilter0 += " And Фамилия Like '%" + textBox1.Text + "%'";
            if (textBox2.Text != "") sFilter0 += " And Код_клиента >= " + textBox2.Text;
            if (textBox3.Text != "") sFilter0 += " And Код_клиента <= " + textBox3.Text;
            sFilter0.Trim();
            if (sFilter0.StartsWith(" And"))
                sFilter0 = sFilter0.Remove(0, 4);
            dv1.RowFilter = sFilter0;
            if (checkBox3.Checked)
            {
                if (textBox4.Text != "") sFilter0 += " And Код_тренера >= " + textBox4.Text;
                if (textBox5.Text != "") sFilter0 += " And Код_тренера <= " + textBox5.Text;
                dv1.RowFilter = sFilter0;
                sFilter0 = "";
            }
            Filter = sFilter0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dv1.RowFilter = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dv1.RowFilter = "Фамилия Like '%" + textBox1.Text + "%'";
                if (checkBox2.Checked)
                {
                    if (textBox2.Text != "") dv1.RowFilter += " And Код_клиента >= " + textBox2.Text;
                    if (textBox3.Text != "") dv1.RowFilter += " And Код_клиента <= " + textBox3.Text;
                }
                if (checkBox3.Checked)
                    if (textBox4.Text != "") dv1.RowFilter += " And Код_тренера >= " + textBox4.Text;
                if (textBox5.Text != "") dv1.RowFilter += " And Код_тренера <= " + textBox5.Text;
                Filter = dv1.RowFilter;
            }
        }

        private void Database_Load(object sender, EventArgs e)
        {
            nameXMLfile = "Set.xml";
            LoadXmlFile();
        }
    }
}
