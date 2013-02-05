namespace Recepta
{
    partial class Form1
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
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpPacjent = new System.Windows.Forms.GroupBox();
            this.cmbUprawnienia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPESEL = new System.Windows.Forms.Label();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.txtPacjent = new System.Windows.Forms.TextBox();
            this.grpRecepta = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datOdDnia = new System.Windows.Forms.DateTimePicker();
            this.cmbNFZ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnDrukuj = new System.Windows.Forms.Button();
            this.grpRp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOdpl5 = new System.Windows.Forms.ComboBox();
            this.cmbOdpl4 = new System.Windows.Forms.ComboBox();
            this.cmbOdpl3 = new System.Windows.Forms.ComboBox();
            this.cmbOdpl2 = new System.Windows.Forms.ComboBox();
            this.cmbOdpl1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOp5 = new System.Windows.Forms.TextBox();
            this.txtOp4 = new System.Windows.Forms.TextBox();
            this.txtOp3 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtLek5 = new System.Windows.Forms.TextBox();
            this.txtLek4 = new System.Windows.Forms.TextBox();
            this.txtLek3 = new System.Windows.Forms.TextBox();
            this.txtLek2 = new System.Windows.Forms.TextBox();
            this.txtLek1 = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.grpSearch.SuspendLayout();
            this.grpPacjent.SuspendLayout();
            this.grpRecepta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpRp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSearch
            // 
            this.lstSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.Location = new System.Drawing.Point(6, 45);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(829, 225);
            this.lstSearch.TabIndex = 0;
            this.lstSearch.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstSearch.DoubleClick += new System.EventHandler(this.lstSearch_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(829, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lstSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 301);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(860, 298);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Wyszukiwarka Leków";
            // 
            // grpPacjent
            // 
            this.grpPacjent.Controls.Add(this.cmbUprawnienia);
            this.grpPacjent.Controls.Add(this.label5);
            this.grpPacjent.Controls.Add(this.lblPESEL);
            this.grpPacjent.Controls.Add(this.txtPESEL);
            this.grpPacjent.Controls.Add(this.txtPacjent);
            this.grpPacjent.Location = new System.Drawing.Point(6, 81);
            this.grpPacjent.Name = "grpPacjent";
            this.grpPacjent.Size = new System.Drawing.Size(250, 197);
            this.grpPacjent.TabIndex = 3;
            this.grpPacjent.TabStop = false;
            this.grpPacjent.Text = "Dane Pacjenta";
            // 
            // cmbUprawnienia
            // 
            this.cmbUprawnienia.FormattingEnabled = true;
            this.cmbUprawnienia.Items.AddRange(new object[] {
            "IB",
            "IW",
            "ZK",
            "AZ",
            "WP",
            "PO",
            "CN",
            "DN",
            "IN"});
            this.cmbUprawnienia.Location = new System.Drawing.Point(102, 167);
            this.cmbUprawnienia.Name = "cmbUprawnienia";
            this.cmbUprawnienia.Size = new System.Drawing.Size(142, 21);
            this.cmbUprawnienia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Uprawnienia dod.";
            // 
            // lblPESEL
            // 
            this.lblPESEL.AutoSize = true;
            this.lblPESEL.Location = new System.Drawing.Point(52, 144);
            this.lblPESEL.Name = "lblPESEL";
            this.lblPESEL.Size = new System.Drawing.Size(44, 13);
            this.lblPESEL.TabIndex = 2;
            this.lblPESEL.Text = "PESEL:";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Location = new System.Drawing.Point(102, 141);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(142, 20);
            this.txtPESEL.TabIndex = 1;
            // 
            // txtPacjent
            // 
            this.txtPacjent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacjent.Location = new System.Drawing.Point(6, 19);
            this.txtPacjent.Multiline = true;
            this.txtPacjent.Name = "txtPacjent";
            this.txtPacjent.Size = new System.Drawing.Size(238, 116);
            this.txtPacjent.TabIndex = 0;
            // 
            // grpRecepta
            // 
            this.grpRecepta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecepta.Controls.Add(this.groupBox1);
            this.grpRecepta.Controls.Add(this.btnWyczysc);
            this.grpRecepta.Controls.Add(this.btnDrukuj);
            this.grpRecepta.Controls.Add(this.grpRp);
            this.grpRecepta.Controls.Add(this.grpPacjent);
            this.grpRecepta.Location = new System.Drawing.Point(12, 12);
            this.grpRecepta.Name = "grpRecepta";
            this.grpRecepta.Size = new System.Drawing.Size(860, 283);
            this.grpRecepta.TabIndex = 4;
            this.grpRecepta.TabStop = false;
            this.grpRecepta.Text = "Recepta";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.datOdDnia);
            this.groupBox1.Controls.Add(this.cmbNFZ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(262, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozostale dane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data realizacji \"od dnia\":";
            // 
            // datOdDnia
            // 
            this.datOdDnia.Location = new System.Drawing.Point(136, 44);
            this.datOdDnia.Name = "datOdDnia";
            this.datOdDnia.Size = new System.Drawing.Size(200, 20);
            this.datOdDnia.TabIndex = 2;
            this.datOdDnia.ValueChanged += new System.EventHandler(this.datOdDnia_ValueChanged);
            // 
            // cmbNFZ
            // 
            this.cmbNFZ.FormattingEnabled = true;
            this.cmbNFZ.Items.AddRange(new object[] {
            "01 Dolnośląski Oddział Narodowego Funduszu Zdrowia we Wrocławiu",
            "02 Kujawsko-Pomorski Oddział Narodowego Funduszu Zdrowia w Bydgoszczy",
            "03 Lubelski Oddział Narodowego Funduszu Zdrowia w Lublinie",
            "04 Lubuski Oddział Narodowego Funduszu Zdrowia w Zielonej Górze",
            "05 Łódzki Oddział Narodowego Funduszu Zdrowia w Łodzi",
            "06 Małopolski Oddział Narodowego Funduszu Zdrowia w Krakowie",
            "07 Mazowiecki Oddział Narodowego Funduszu Zdrowia w Warszawie",
            "08 Opolski Oddział Narodowego Funduszu Zdrowia w Opolu",
            "09 Podkarpacki Oddział Narodowego Funduszu Zdrowia w Rzeszowie",
            "10 Podlaski Oddział Narodowego Funduszu Zdrowia w Białymstoku",
            "11 Pomorski Oddział Narodowego Funduszu Zdrowia w Gdańsku",
            "12 Śląski Oddział Narodowego Funduszu Zdrowia w Katowicach",
            "13 Świętokrzyski Oddział Narodowego Funduszu Zdrowia w Kielcach",
            "14 Warmińsko-Mazurski Oddział Narodowego Funduszu Zdrowia w Olsztynie",
            "15 Wielkopolski Oddział Narodowego Funduszu Zdrowia w Poznaniu",
            "16 Zachodniopomorski Oddział Narodowego Funduszu Zdrowia w Szczecinie"});
            this.cmbNFZ.Location = new System.Drawing.Point(136, 18);
            this.cmbNFZ.Name = "cmbNFZ";
            this.cmbNFZ.Size = new System.Drawing.Size(388, 21);
            this.cmbNFZ.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oddział NFZ";
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(12, 50);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(244, 25);
            this.btnWyczysc.TabIndex = 2;
            this.btnWyczysc.Text = "Wyczyść receptę";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Location = new System.Drawing.Point(12, 18);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(244, 26);
            this.btnDrukuj.TabIndex = 2;
            this.btnDrukuj.Text = "Drukuj receptę";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            this.btnDrukuj.Click += new System.EventHandler(this.btnDrukuj_Click);
            // 
            // grpRp
            // 
            this.grpRp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRp.Controls.Add(this.label3);
            this.grpRp.Controls.Add(this.cmbOdpl5);
            this.grpRp.Controls.Add(this.cmbOdpl4);
            this.grpRp.Controls.Add(this.cmbOdpl3);
            this.grpRp.Controls.Add(this.cmbOdpl2);
            this.grpRp.Controls.Add(this.cmbOdpl1);
            this.grpRp.Controls.Add(this.button5);
            this.grpRp.Controls.Add(this.button4);
            this.grpRp.Controls.Add(this.button3);
            this.grpRp.Controls.Add(this.button2);
            this.grpRp.Controls.Add(this.button1);
            this.grpRp.Controls.Add(this.label2);
            this.grpRp.Controls.Add(this.label1);
            this.grpRp.Controls.Add(this.txtOp5);
            this.grpRp.Controls.Add(this.txtOp4);
            this.grpRp.Controls.Add(this.txtOp3);
            this.grpRp.Controls.Add(this.txtOp2);
            this.grpRp.Controls.Add(this.txtOp1);
            this.grpRp.Controls.Add(this.txtLek5);
            this.grpRp.Controls.Add(this.txtLek4);
            this.grpRp.Controls.Add(this.txtLek3);
            this.grpRp.Controls.Add(this.txtLek2);
            this.grpRp.Controls.Add(this.txtLek1);
            this.grpRp.Location = new System.Drawing.Point(262, 19);
            this.grpRp.Name = "grpRp";
            this.grpRp.Size = new System.Drawing.Size(592, 168);
            this.grpRp.TabIndex = 4;
            this.grpRp.TabStop = false;
            this.grpRp.Text = "Rp";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Odplatnosc:";
            // 
            // cmbOdpl5
            // 
            this.cmbOdpl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdpl5.FormattingEnabled = true;
            this.cmbOdpl5.Location = new System.Drawing.Point(460, 140);
            this.cmbOdpl5.Name = "cmbOdpl5";
            this.cmbOdpl5.Size = new System.Drawing.Size(82, 21);
            this.cmbOdpl5.TabIndex = 23;
            // 
            // cmbOdpl4
            // 
            this.cmbOdpl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdpl4.FormattingEnabled = true;
            this.cmbOdpl4.Location = new System.Drawing.Point(460, 114);
            this.cmbOdpl4.Name = "cmbOdpl4";
            this.cmbOdpl4.Size = new System.Drawing.Size(82, 21);
            this.cmbOdpl4.TabIndex = 22;
            // 
            // cmbOdpl3
            // 
            this.cmbOdpl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdpl3.FormattingEnabled = true;
            this.cmbOdpl3.Location = new System.Drawing.Point(461, 88);
            this.cmbOdpl3.Name = "cmbOdpl3";
            this.cmbOdpl3.Size = new System.Drawing.Size(82, 21);
            this.cmbOdpl3.TabIndex = 21;
            // 
            // cmbOdpl2
            // 
            this.cmbOdpl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdpl2.FormattingEnabled = true;
            this.cmbOdpl2.Location = new System.Drawing.Point(460, 62);
            this.cmbOdpl2.Name = "cmbOdpl2";
            this.cmbOdpl2.Size = new System.Drawing.Size(82, 21);
            this.cmbOdpl2.TabIndex = 20;
            // 
            // cmbOdpl1
            // 
            this.cmbOdpl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOdpl1.FormattingEnabled = true;
            this.cmbOdpl1.Location = new System.Drawing.Point(460, 36);
            this.cmbOdpl1.Name = "cmbOdpl1";
            this.cmbOdpl1.Size = new System.Drawing.Size(82, 21);
            this.cmbOdpl1.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(549, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(549, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(549, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(549, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(549, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Op.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Leki:";
            // 
            // txtOp5
            // 
            this.txtOp5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOp5.Location = new System.Drawing.Point(420, 140);
            this.txtOp5.Name = "txtOp5";
            this.txtOp5.Size = new System.Drawing.Size(34, 20);
            this.txtOp5.TabIndex = 11;
            // 
            // txtOp4
            // 
            this.txtOp4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOp4.Location = new System.Drawing.Point(420, 114);
            this.txtOp4.Name = "txtOp4";
            this.txtOp4.Size = new System.Drawing.Size(34, 20);
            this.txtOp4.TabIndex = 10;
            // 
            // txtOp3
            // 
            this.txtOp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOp3.Location = new System.Drawing.Point(420, 88);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(34, 20);
            this.txtOp3.TabIndex = 9;
            // 
            // txtOp2
            // 
            this.txtOp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOp2.Location = new System.Drawing.Point(420, 62);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(34, 20);
            this.txtOp2.TabIndex = 8;
            // 
            // txtOp1
            // 
            this.txtOp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOp1.Location = new System.Drawing.Point(420, 36);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(34, 20);
            this.txtOp1.TabIndex = 7;
            // 
            // txtLek5
            // 
            this.txtLek5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLek5.Location = new System.Drawing.Point(12, 140);
            this.txtLek5.Name = "txtLek5";
            this.txtLek5.Size = new System.Drawing.Size(402, 20);
            this.txtLek5.TabIndex = 6;
            this.txtLek5.TextChanged += new System.EventHandler(this.txtLek5_TextChanged);
            this.txtLek5.Click += new System.EventHandler(this.txtLek5_Click);
            // 
            // txtLek4
            // 
            this.txtLek4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLek4.Location = new System.Drawing.Point(12, 114);
            this.txtLek4.Name = "txtLek4";
            this.txtLek4.Size = new System.Drawing.Size(402, 20);
            this.txtLek4.TabIndex = 5;
            this.txtLek4.TextChanged += new System.EventHandler(this.txtLek4_TextChanged);
            this.txtLek4.Click += new System.EventHandler(this.txtLek4_Click);
            // 
            // txtLek3
            // 
            this.txtLek3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLek3.Location = new System.Drawing.Point(12, 88);
            this.txtLek3.Name = "txtLek3";
            this.txtLek3.Size = new System.Drawing.Size(402, 20);
            this.txtLek3.TabIndex = 4;
            this.txtLek3.TextChanged += new System.EventHandler(this.txtLek3_TextChanged);
            this.txtLek3.Click += new System.EventHandler(this.txtLek3_Click);
            // 
            // txtLek2
            // 
            this.txtLek2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLek2.Location = new System.Drawing.Point(12, 62);
            this.txtLek2.Name = "txtLek2";
            this.txtLek2.Size = new System.Drawing.Size(402, 20);
            this.txtLek2.TabIndex = 3;
            this.txtLek2.TextChanged += new System.EventHandler(this.txtLek2_TextChanged);
            this.txtLek2.Click += new System.EventHandler(this.txtLek2_Click);
            // 
            // txtLek1
            // 
            this.txtLek1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLek1.Location = new System.Drawing.Point(12, 36);
            this.txtLek1.Name = "txtLek1";
            this.txtLek1.Size = new System.Drawing.Size(402, 20);
            this.txtLek1.TabIndex = 2;
            this.txtLek1.TextChanged += new System.EventHandler(this.txtLek1_TextChanged);
            this.txtLek1.Click += new System.EventHandler(this.txtLek1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.grpRecepta);
            this.Controls.Add(this.grpSearch);
            this.Name = "Form1";
            this.Text = "Recepta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpPacjent.ResumeLayout(false);
            this.grpPacjent.PerformLayout();
            this.grpRecepta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpRp.ResumeLayout(false);
            this.grpRp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpPacjent;
        private System.Windows.Forms.GroupBox grpRecepta;
        private System.Windows.Forms.GroupBox grpRp;
        private System.Windows.Forms.TextBox txtPacjent;
        private System.Windows.Forms.Button btnDrukuj;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.TextBox txtOp5;
        private System.Windows.Forms.TextBox txtOp4;
        private System.Windows.Forms.TextBox txtOp3;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtLek5;
        private System.Windows.Forms.TextBox txtLek4;
        private System.Windows.Forms.TextBox txtLek3;
        private System.Windows.Forms.TextBox txtLek2;
        private System.Windows.Forms.TextBox txtLek1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox cmbOdpl5;
        private System.Windows.Forms.ComboBox cmbOdpl4;
        private System.Windows.Forms.ComboBox cmbOdpl3;
        private System.Windows.Forms.ComboBox cmbOdpl2;
        private System.Windows.Forms.ComboBox cmbOdpl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPESEL;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNFZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUprawnienia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datOdDnia;
    }
}

