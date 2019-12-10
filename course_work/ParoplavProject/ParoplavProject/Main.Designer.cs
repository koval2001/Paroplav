namespace ParoplavProject
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sq = new System.Windows.Forms.Label();
            this.lbl_rivers = new System.Windows.Forms.Label();
            this.lbl_w = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_sq = new System.Windows.Forms.TextBox();
            this.txt_river = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_start = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.TextBox();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_next = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.rb_lake = new System.Windows.Forms.RadioButton();
            this.rb_pond = new System.Windows.Forms.RadioButton();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.txt_salt = new System.Windows.Forms.TextBox();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.txt_berths = new System.Windows.Forms.TextBox();
            this.lbl_intake = new System.Windows.Forms.Label();
            this.lbl_salt = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_berths = new System.Windows.Forms.Label();
            this.lst_names = new System.Windows.Forms.ListBox();
            this.lbl_n = new System.Windows.Forms.Label();
            this.txt_intake = new System.Windows.Forms.TextBox();
            this.lbl_in = new System.Windows.Forms.Label();
            this.lbl_back = new System.Windows.Forms.Label();
            this.lst_square = new System.Windows.Forms.ListBox();
            this.lst_depth = new System.Windows.Forms.ListBox();
            this.lbl_see = new System.Windows.Forms.Label();
            this.txt_colvo = new System.Windows.Forms.TextBox();
            this.lbl_places = new System.Windows.Forms.Label();
            this.lbl_dust = new System.Windows.Forms.Label();
            this.txt_dust = new System.Windows.Forms.TextBox();
            this.lbl_sq_head = new System.Windows.Forms.Label();
            this.lbl_depth_head = new System.Windows.Forms.Label();
            this.lbl_name_head = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(91, 142);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(209, 30);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Назва водоймища:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sq
            // 
            this.lbl_sq.AutoSize = true;
            this.lbl_sq.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sq.Location = new System.Drawing.Point(91, 189);
            this.lbl_sq.Name = "lbl_sq";
            this.lbl_sq.Size = new System.Drawing.Size(224, 30);
            this.lbl_sq.TabIndex = 1;
            this.lbl_sq.Text = "Площа водоймища:";
            // 
            // lbl_rivers
            // 
            this.lbl_rivers.AutoSize = true;
            this.lbl_rivers.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rivers.Location = new System.Drawing.Point(91, 239);
            this.lbl_rivers.Name = "lbl_rivers";
            this.lbl_rivers.Size = new System.Drawing.Size(174, 60);
            this.lbl_rivers.TabIndex = 2;
            this.lbl_rivers.Text = "Кількість річок,\r\nщо впадають:";
            // 
            // lbl_w
            // 
            this.lbl_w.AutoSize = true;
            this.lbl_w.BackColor = System.Drawing.Color.Transparent;
            this.lbl_w.Location = new System.Drawing.Point(91, 317);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(174, 30);
            this.lbl_w.TabIndex = 3;
            this.lbl_w.Text = "Маса води (кг):";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(91, 20);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(249, 38);
            this.lbl_header.TabIndex = 4;
            this.lbl_header.Text = "Вхідні параметри";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(425, 139);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(229, 37);
            this.txt_name.TabIndex = 5;
            this.txt_name.Text = "Новое";
            // 
            // txt_sq
            // 
            this.txt_sq.Location = new System.Drawing.Point(425, 189);
            this.txt_sq.Name = "txt_sq";
            this.txt_sq.Size = new System.Drawing.Size(229, 37);
            this.txt_sq.TabIndex = 6;
            this.txt_sq.Text = "100";
            // 
            // txt_river
            // 
            this.txt_river.Location = new System.Drawing.Point(425, 262);
            this.txt_river.Name = "txt_river";
            this.txt_river.Size = new System.Drawing.Size(229, 37);
            this.txt_river.TabIndex = 7;
            this.txt_river.Text = "5";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(425, 317);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(229, 37);
            this.txt_weight.TabIndex = 8;
            this.txt_weight.Text = "4500";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_start.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_start.ForeColor = System.Drawing.Color.White;
            this.lbl_start.Location = new System.Drawing.Point(87, 470);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(311, 49);
            this.lbl_start.TabIndex = 9;
            this.lbl_start.Text = "Додати водойму";
            this.lbl_start.Visible = false;
            this.lbl_start.Click += new System.EventHandler(this.lbl_start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(91, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Середня глибина водоймища:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.BackColor = System.Drawing.Color.Transparent;
            this.lbl_weight.Location = new System.Drawing.Point(93, 602);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(27, 30);
            this.lbl_weight.TabIndex = 11;
            this.lbl_weight.Text = "_";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.BackColor = System.Drawing.Color.Transparent;
            this.lbl_depth.Location = new System.Drawing.Point(577, 557);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(27, 30);
            this.lbl_depth.TabIndex = 12;
            this.lbl_depth.Text = "_";
            // 
            // txt_
            // 
            this.txt_.Location = new System.Drawing.Point(444, 396);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(210, 37);
            this.txt_.TabIndex = 14;
            this.txt_.Text = "3600";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max.Location = new System.Drawing.Point(93, 373);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(236, 60);
            this.lbl_max.TabIndex = 13;
            this.lbl_max.Text = "Максимальна\r\nглибина водоймища:";
            // 
            // lbl_next
            // 
            this.lbl_next.AutoSize = true;
            this.lbl_next.BackColor = System.Drawing.Color.Transparent;
            this.lbl_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_next.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_next.ForeColor = System.Drawing.Color.White;
            this.lbl_next.Location = new System.Drawing.Point(745, 479);
            this.lbl_next.Name = "lbl_next";
            this.lbl_next.Size = new System.Drawing.Size(0, 49);
            this.lbl_next.TabIndex = 18;
            this.lbl_next.Click += new System.EventHandler(this.lbl_next_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type.Location = new System.Drawing.Point(93, 72);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(192, 30);
            this.lbl_type.TabIndex = 19;
            this.lbl_type.Text = "Тип водоймища:";
            // 
            // rb_lake
            // 
            this.rb_lake.AutoSize = true;
            this.rb_lake.BackColor = System.Drawing.Color.Transparent;
            this.rb_lake.Checked = true;
            this.rb_lake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_lake.Location = new System.Drawing.Point(425, 49);
            this.rb_lake.Name = "rb_lake";
            this.rb_lake.Size = new System.Drawing.Size(96, 34);
            this.rb_lake.TabIndex = 20;
            this.rb_lake.TabStop = true;
            this.rb_lake.Text = "Озеро";
            this.rb_lake.UseVisualStyleBackColor = false;
            this.rb_lake.CheckedChanged += new System.EventHandler(this.rb_lake_CheckedChanged);
            // 
            // rb_pond
            // 
            this.rb_pond.AutoSize = true;
            this.rb_pond.BackColor = System.Drawing.Color.Transparent;
            this.rb_pond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_pond.Location = new System.Drawing.Point(425, 89);
            this.rb_pond.Name = "rb_pond";
            this.rb_pond.Size = new System.Drawing.Size(100, 34);
            this.rb_pond.TabIndex = 21;
            this.rb_pond.Text = "Ставок";
            this.rb_pond.UseVisualStyleBackColor = false;
            this.rb_pond.CheckedChanged += new System.EventHandler(this.rb_pond_CheckedChanged);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_exit.ForeColor = System.Drawing.Color.Black;
            this.lbl_exit.Location = new System.Drawing.Point(669, 412);
            this.lbl_exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(0, 49);
            this.lbl_exit.TabIndex = 25;
            // 
            // txt_salt
            // 
            this.txt_salt.Location = new System.Drawing.Point(425, 196);
            this.txt_salt.Name = "txt_salt";
            this.txt_salt.Size = new System.Drawing.Size(229, 37);
            this.txt_salt.TabIndex = 32;
            this.txt_salt.Text = "5";
            this.txt_salt.Visible = false;
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(425, 153);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(229, 37);
            this.txt_level.TabIndex = 31;
            this.txt_level.Text = "100";
            this.txt_level.Visible = false;
            // 
            // txt_berths
            // 
            this.txt_berths.Location = new System.Drawing.Point(425, 103);
            this.txt_berths.Name = "txt_berths";
            this.txt_berths.Size = new System.Drawing.Size(229, 37);
            this.txt_berths.TabIndex = 30;
            this.txt_berths.Text = "4";
            this.txt_berths.Visible = false;
            // 
            // lbl_intake
            // 
            this.lbl_intake.AutoSize = true;
            this.lbl_intake.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intake.Location = new System.Drawing.Point(91, 281);
            this.lbl_intake.Name = "lbl_intake";
            this.lbl_intake.Size = new System.Drawing.Size(0, 30);
            this.lbl_intake.TabIndex = 29;
            // 
            // lbl_salt
            // 
            this.lbl_salt.AutoSize = true;
            this.lbl_salt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salt.Location = new System.Drawing.Point(91, 203);
            this.lbl_salt.Name = "lbl_salt";
            this.lbl_salt.Size = new System.Drawing.Size(193, 30);
            this.lbl_salt.TabIndex = 28;
            this.lbl_salt.Text = "Рівень солоності:";
            this.lbl_salt.Visible = false;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.BackColor = System.Drawing.Color.Transparent;
            this.lbl_level.Location = new System.Drawing.Point(91, 153);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(239, 30);
            this.lbl_level.TabIndex = 27;
            this.lbl_level.Text = "Рівень заболоченості:";
            this.lbl_level.Visible = false;
            // 
            // lbl_berths
            // 
            this.lbl_berths.AutoSize = true;
            this.lbl_berths.BackColor = System.Drawing.Color.Transparent;
            this.lbl_berths.Location = new System.Drawing.Point(91, 106);
            this.lbl_berths.Name = "lbl_berths";
            this.lbl_berths.Size = new System.Drawing.Size(224, 30);
            this.lbl_berths.TabIndex = 26;
            this.lbl_berths.Text = "Кiлькiсть пристаней";
            this.lbl_berths.Visible = false;
            // 
            // lst_names
            // 
            this.lst_names.FormattingEnabled = true;
            this.lst_names.ItemHeight = 29;
            this.lst_names.Location = new System.Drawing.Point(109, 175);
            this.lst_names.Name = "lst_names";
            this.lst_names.Size = new System.Drawing.Size(204, 236);
            this.lst_names.TabIndex = 34;
            this.lst_names.Visible = false;
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.BackColor = System.Drawing.Color.Transparent;
            this.lbl_n.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_n.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_n.ForeColor = System.Drawing.Color.White;
            this.lbl_n.Location = new System.Drawing.Point(697, 470);
            this.lbl_n.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(101, 49);
            this.lbl_n.TabIndex = 35;
            this.lbl_n.Text = "Далі";
            this.lbl_n.Click += new System.EventHandler(this.lbl_n_Click);
            // 
            // txt_intake
            // 
            this.txt_intake.Location = new System.Drawing.Point(425, 251);
            this.txt_intake.Name = "txt_intake";
            this.txt_intake.Size = new System.Drawing.Size(229, 37);
            this.txt_intake.TabIndex = 37;
            this.txt_intake.Text = "5";
            this.txt_intake.Visible = false;
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.BackColor = System.Drawing.Color.Transparent;
            this.lbl_in.Location = new System.Drawing.Point(91, 258);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(246, 30);
            this.lbl_in.TabIndex = 36;
            this.lbl_in.Text = "Кількість водозаборів:";
            this.lbl_in.Visible = false;
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.BackColor = System.Drawing.Color.Transparent;
            this.lbl_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_back.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_back.ForeColor = System.Drawing.Color.Black;
            this.lbl_back.Location = new System.Drawing.Point(659, 20);
            this.lbl_back.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(123, 49);
            this.lbl_back.TabIndex = 38;
            this.lbl_back.Text = "Назад";
            this.lbl_back.Visible = false;
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // lst_square
            // 
            this.lst_square.FormattingEnabled = true;
            this.lst_square.ItemHeight = 29;
            this.lst_square.Location = new System.Drawing.Point(386, 173);
            this.lst_square.Name = "lst_square";
            this.lst_square.Size = new System.Drawing.Size(204, 236);
            this.lst_square.TabIndex = 39;
            this.lst_square.Visible = false;
            // 
            // lst_depth
            // 
            this.lst_depth.FormattingEnabled = true;
            this.lst_depth.ItemHeight = 29;
            this.lst_depth.Location = new System.Drawing.Point(660, 173);
            this.lst_depth.Name = "lst_depth";
            this.lst_depth.Size = new System.Drawing.Size(204, 236);
            this.lst_depth.TabIndex = 40;
            this.lst_depth.Visible = false;
            // 
            // lbl_see
            // 
            this.lbl_see.AutoSize = true;
            this.lbl_see.BackColor = System.Drawing.Color.Transparent;
            this.lbl_see.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_see.Font = new System.Drawing.Font("Comic Sans MS", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_see.ForeColor = System.Drawing.Color.White;
            this.lbl_see.Location = new System.Drawing.Point(422, 475);
            this.lbl_see.Name = "lbl_see";
            this.lbl_see.Size = new System.Drawing.Size(450, 44);
            this.lbl_see.TabIndex = 41;
            this.lbl_see.Text = "Подивитись список водойм";
            this.lbl_see.Visible = false;
            this.lbl_see.Click += new System.EventHandler(this.lbl_see_Click);
            // 
            // txt_colvo
            // 
            this.txt_colvo.Location = new System.Drawing.Point(425, 99);
            this.txt_colvo.Name = "txt_colvo";
            this.txt_colvo.Size = new System.Drawing.Size(229, 37);
            this.txt_colvo.TabIndex = 43;
            this.txt_colvo.Text = "4";
            this.txt_colvo.Visible = false;
            // 
            // lbl_places
            // 
            this.lbl_places.AutoSize = true;
            this.lbl_places.BackColor = System.Drawing.Color.Transparent;
            this.lbl_places.Location = new System.Drawing.Point(91, 102);
            this.lbl_places.Name = "lbl_places";
            this.lbl_places.Size = new System.Drawing.Size(172, 60);
            this.lbl_places.TabIndex = 42;
            this.lbl_places.Text = "Кiлькiсть мiсць\r\nна пляжi:";
            this.lbl_places.Visible = false;
            // 
            // lbl_dust
            // 
            this.lbl_dust.AutoSize = true;
            this.lbl_dust.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dust.Location = new System.Drawing.Point(93, 173);
            this.lbl_dust.Name = "lbl_dust";
            this.lbl_dust.Size = new System.Drawing.Size(240, 30);
            this.lbl_dust.TabIndex = 44;
            this.lbl_dust.Text = "Рiвень забрудненiсть: ";
            this.lbl_dust.Visible = false;
            // 
            // txt_dust
            // 
            this.txt_dust.Location = new System.Drawing.Point(425, 170);
            this.txt_dust.Name = "txt_dust";
            this.txt_dust.Size = new System.Drawing.Size(229, 37);
            this.txt_dust.TabIndex = 45;
            this.txt_dust.Text = "100";
            this.txt_dust.Visible = false;
            // 
            // lbl_sq_head
            // 
            this.lbl_sq_head.AutoSize = true;
            this.lbl_sq_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sq_head.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sq_head.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sq_head.ForeColor = System.Drawing.Color.Black;
            this.lbl_sq_head.Location = new System.Drawing.Point(416, 118);
            this.lbl_sq_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sq_head.Name = "lbl_sq_head";
            this.lbl_sq_head.Size = new System.Drawing.Size(145, 49);
            this.lbl_sq_head.TabIndex = 46;
            this.lbl_sq_head.Text = "Площа";
            this.lbl_sq_head.Visible = false;
            // 
            // lbl_depth_head
            // 
            this.lbl_depth_head.AutoSize = true;
            this.lbl_depth_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_depth_head.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_depth_head.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_depth_head.ForeColor = System.Drawing.Color.Black;
            this.lbl_depth_head.Location = new System.Drawing.Point(681, 118);
            this.lbl_depth_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_depth_head.Name = "lbl_depth_head";
            this.lbl_depth_head.Size = new System.Drawing.Size(162, 49);
            this.lbl_depth_head.TabIndex = 47;
            this.lbl_depth_head.Text = "Глубина";
            this.lbl_depth_head.Visible = false;
            // 
            // lbl_name_head
            // 
            this.lbl_name_head.AutoSize = true;
            this.lbl_name_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_head.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_name_head.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name_head.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_head.Location = new System.Drawing.Point(151, 123);
            this.lbl_name_head.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name_head.Name = "lbl_name_head";
            this.lbl_name_head.Size = new System.Drawing.Size(120, 49);
            this.lbl_name_head.TabIndex = 48;
            this.lbl_name_head.Text = "Назва";
            this.lbl_name_head.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbl_name_head);
            this.Controls.Add(this.lbl_depth_head);
            this.Controls.Add(this.lbl_sq_head);
            this.Controls.Add(this.txt_dust);
            this.Controls.Add(this.lbl_dust);
            this.Controls.Add(this.txt_colvo);
            this.Controls.Add(this.lbl_places);
            this.Controls.Add(this.lbl_see);
            this.Controls.Add(this.lst_depth);
            this.Controls.Add(this.lst_square);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.txt_intake);
            this.Controls.Add(this.lbl_in);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.lst_names);
            this.Controls.Add(this.txt_salt);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.txt_berths);
            this.Controls.Add(this.lbl_intake);
            this.Controls.Add(this.lbl_salt);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.lbl_berths);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.rb_pond);
            this.Controls.Add(this.rb_lake);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_next);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_depth);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_river);
            this.Controls.Add(this.txt_sq);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_w);
            this.Controls.Add(this.lbl_rivers);
            this.Controls.Add(this.lbl_sq);
            this.Controls.Add(this.lbl_name);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водоймище";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sq;
        private System.Windows.Forms.Label lbl_rivers;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_sq;
        private System.Windows.Forms.TextBox txt_river;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_depth;
        private System.Windows.Forms.TextBox txt_;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.Label lbl_next;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.RadioButton rb_lake;
        private System.Windows.Forms.RadioButton rb_pond;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.TextBox txt_salt;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.TextBox txt_berths;
        private System.Windows.Forms.Label lbl_intake;
        private System.Windows.Forms.Label lbl_salt;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_berths;
        private System.Windows.Forms.ListBox lst_names;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txt_intake;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.ListBox lst_square;
        private System.Windows.Forms.ListBox lst_depth;
        private System.Windows.Forms.Label lbl_see;
        private System.Windows.Forms.TextBox txt_colvo;
        private System.Windows.Forms.Label lbl_places;
        private System.Windows.Forms.Label lbl_dust;
        private System.Windows.Forms.TextBox txt_dust;
        private System.Windows.Forms.Label lbl_sq_head;
        private System.Windows.Forms.Label lbl_depth_head;
        private System.Windows.Forms.Label lbl_name_head;
    }
}