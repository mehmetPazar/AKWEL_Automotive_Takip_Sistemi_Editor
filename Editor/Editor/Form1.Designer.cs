namespace Editor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SirketAraciG = new System.Windows.Forms.Button();
            this.MudurG = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cikti = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TakipSistemi = new System.Windows.Forms.Label();
            this.Mudur = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MudurSilll = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MudurSil = new System.Windows.Forms.Button();
            this.Mudurgiris = new System.Windows.Forms.GroupBox();
            this.MudurEklee = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.MudurEkle = new System.Windows.Forms.Button();
            this.Plaka = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PlakaSilll = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlakaSil = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PlakaEklee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PlakaEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.Mudur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Mudurgiris.SuspendLayout();
            this.Plaka.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.SirketAraciG);
            this.panel1.Controls.Add(this.MudurG);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Cikti);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 354);
            this.panel1.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(136)))), ((int)(((byte)(158)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 186);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 55);
            this.SidePanel.TabIndex = 14;
            // 
            // SirketAraciG
            // 
            this.SirketAraciG.FlatAppearance.BorderSize = 0;
            this.SirketAraciG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SirketAraciG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SirketAraciG.ForeColor = System.Drawing.Color.White;
            this.SirketAraciG.Image = ((System.Drawing.Image)(resources.GetObject("SirketAraciG.Image")));
            this.SirketAraciG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SirketAraciG.Location = new System.Drawing.Point(12, 186);
            this.SirketAraciG.Name = "SirketAraciG";
            this.SirketAraciG.Size = new System.Drawing.Size(197, 55);
            this.SirketAraciG.TabIndex = 7;
            this.SirketAraciG.TabStop = false;
            this.SirketAraciG.Text = "       Şirket Araci";
            this.SirketAraciG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SirketAraciG.UseVisualStyleBackColor = true;
            this.SirketAraciG.Click += new System.EventHandler(this.SirketAraciG_Click);
            // 
            // MudurG
            // 
            this.MudurG.FlatAppearance.BorderSize = 0;
            this.MudurG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MudurG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MudurG.ForeColor = System.Drawing.Color.White;
            this.MudurG.Image = ((System.Drawing.Image)(resources.GetObject("MudurG.Image")));
            this.MudurG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MudurG.Location = new System.Drawing.Point(12, 247);
            this.MudurG.Name = "MudurG";
            this.MudurG.Size = new System.Drawing.Size(197, 55);
            this.MudurG.TabIndex = 6;
            this.MudurG.TabStop = false;
            this.MudurG.Text = "       Müdür";
            this.MudurG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MudurG.UseVisualStyleBackColor = true;
            this.MudurG.Click += new System.EventHandler(this.MudurG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Cikti
            // 
            this.Cikti.FlatAppearance.BorderSize = 0;
            this.Cikti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikti.ForeColor = System.Drawing.Color.White;
            this.Cikti.Image = ((System.Drawing.Image)(resources.GetObject("Cikti.Image")));
            this.Cikti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikti.Location = new System.Drawing.Point(12, 486);
            this.Cikti.Name = "Cikti";
            this.Cikti.Size = new System.Drawing.Size(197, 55);
            this.Cikti.TabIndex = 5;
            this.Cikti.TabStop = false;
            this.Cikti.Text = "       Çıktı";
            this.Cikti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cikti.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 158);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Automotive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "AKWEL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel6.Location = new System.Drawing.Point(209, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(24, 68);
            this.panel6.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.TakipSistemi);
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 68);
            this.panel2.TabIndex = 18;
            // 
            // TakipSistemi
            // 
            this.TakipSistemi.AutoSize = true;
            this.TakipSistemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TakipSistemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakipSistemi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TakipSistemi.Location = new System.Drawing.Point(28, 22);
            this.TakipSistemi.Name = "TakipSistemi";
            this.TakipSistemi.Size = new System.Drawing.Size(413, 25);
            this.TakipSistemi.TabIndex = 19;
            this.TakipSistemi.Text = "ZİYARETÇİ TAKİP SİSTEMİ EDİTORU ";
            // 
            // Mudur
            // 
            this.Mudur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mudur.Controls.Add(this.groupBox1);
            this.Mudur.Controls.Add(this.Mudurgiris);
            this.Mudur.Location = new System.Drawing.Point(236, 270);
            this.Mudur.Name = "Mudur";
            this.Mudur.Size = new System.Drawing.Size(594, 105);
            this.Mudur.TabIndex = 27;
            this.Mudur.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
            this.groupBox1.Controls.Add(this.MudurSilll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MudurSil);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(305, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // MudurSilll
            // 
            this.MudurSilll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MudurSilll.FormattingEnabled = true;
            this.MudurSilll.Location = new System.Drawing.Point(132, 18);
            this.MudurSilll.Name = "MudurSilll";
            this.MudurSilll.Size = new System.Drawing.Size(121, 21);
            this.MudurSilll.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÜDÜR ADI:";
            // 
            // MudurSil
            // 
            this.MudurSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MudurSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MudurSil.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.MudurSil.ForeColor = System.Drawing.Color.White;
            this.MudurSil.Location = new System.Drawing.Point(75, 47);
            this.MudurSil.Name = "MudurSil";
            this.MudurSil.Size = new System.Drawing.Size(138, 28);
            this.MudurSil.TabIndex = 10;
            this.MudurSil.TabStop = false;
            this.MudurSil.Text = "SİL";
            this.MudurSil.UseVisualStyleBackColor = false;
            this.MudurSil.Click += new System.EventHandler(this.MudurSil_Click);
            // 
            // Mudurgiris
            // 
            this.Mudurgiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
            this.Mudurgiris.Controls.Add(this.MudurEklee);
            this.Mudurgiris.Controls.Add(this.label21);
            this.Mudurgiris.Controls.Add(this.MudurEkle);
            this.Mudurgiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mudurgiris.Location = new System.Drawing.Point(6, 8);
            this.Mudurgiris.Name = "Mudurgiris";
            this.Mudurgiris.Size = new System.Drawing.Size(283, 88);
            this.Mudurgiris.TabIndex = 15;
            this.Mudurgiris.TabStop = false;
            // 
            // MudurEklee
            // 
            this.MudurEklee.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MudurEklee.Location = new System.Drawing.Point(122, 15);
            this.MudurEklee.Name = "MudurEklee";
            this.MudurEklee.Size = new System.Drawing.Size(155, 24);
            this.MudurEklee.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(6, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 22);
            this.label21.TabIndex = 1;
            this.label21.Text = "MÜDÜR ADI:";
            // 
            // MudurEkle
            // 
            this.MudurEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MudurEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MudurEkle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.MudurEkle.ForeColor = System.Drawing.Color.White;
            this.MudurEkle.Location = new System.Drawing.Point(75, 47);
            this.MudurEkle.Name = "MudurEkle";
            this.MudurEkle.Size = new System.Drawing.Size(138, 28);
            this.MudurEkle.TabIndex = 10;
            this.MudurEkle.TabStop = false;
            this.MudurEkle.Text = "EKLE";
            this.MudurEkle.UseVisualStyleBackColor = false;
            this.MudurEkle.Click += new System.EventHandler(this.MudurEkle_Click);
            // 
            // Plaka
            // 
            this.Plaka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plaka.Controls.Add(this.groupBox3);
            this.Plaka.Controls.Add(this.groupBox4);
            this.Plaka.Location = new System.Drawing.Point(218, 159);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(594, 105);
            this.Plaka.TabIndex = 28;
            this.Plaka.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
            this.groupBox3.Controls.Add(this.PlakaSilll);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PlakaSil);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(305, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 88);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // PlakaSilll
            // 
            this.PlakaSilll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlakaSilll.FormattingEnabled = true;
            this.PlakaSilll.Location = new System.Drawing.Point(137, 18);
            this.PlakaSilll.Name = "PlakaSilll";
            this.PlakaSilll.Size = new System.Drawing.Size(121, 21);
            this.PlakaSilll.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "ARAÇ PLAKA:";
            // 
            // PlakaSil
            // 
            this.PlakaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PlakaSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlakaSil.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlakaSil.ForeColor = System.Drawing.Color.White;
            this.PlakaSil.Location = new System.Drawing.Point(75, 47);
            this.PlakaSil.Name = "PlakaSil";
            this.PlakaSil.Size = new System.Drawing.Size(138, 28);
            this.PlakaSil.TabIndex = 10;
            this.PlakaSil.TabStop = false;
            this.PlakaSil.Text = "SİL";
            this.PlakaSil.UseVisualStyleBackColor = false;
            this.PlakaSil.Click += new System.EventHandler(this.PlakaSil_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
            this.groupBox4.Controls.Add(this.PlakaEklee);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.PlakaEkle);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(6, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 88);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // PlakaEklee
            // 
            this.PlakaEklee.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlakaEklee.Location = new System.Drawing.Point(138, 15);
            this.PlakaEklee.Name = "PlakaEklee";
            this.PlakaEklee.Size = new System.Drawing.Size(139, 24);
            this.PlakaEklee.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "ARAÇ PLAKA:";
            // 
            // PlakaEkle
            // 
            this.PlakaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.PlakaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlakaEkle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlakaEkle.ForeColor = System.Drawing.Color.White;
            this.PlakaEkle.Location = new System.Drawing.Point(75, 47);
            this.PlakaEkle.Name = "PlakaEkle";
            this.PlakaEkle.Size = new System.Drawing.Size(138, 28);
            this.PlakaEkle.TabIndex = 10;
            this.PlakaEkle.TabStop = false;
            this.PlakaEkle.Text = "EKLE";
            this.PlakaEkle.UseVisualStyleBackColor = false;
            this.PlakaEkle.Click += new System.EventHandler(this.PlakaEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(168)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(830, 354);
            this.Controls.Add(this.Plaka);
            this.Controls.Add(this.Mudur);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Mudur.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Mudurgiris.ResumeLayout(false);
            this.Mudurgiris.PerformLayout();
            this.Plaka.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cikti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TakipSistemi;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button SirketAraciG;
        private System.Windows.Forms.Button MudurG;
        private System.Windows.Forms.GroupBox Mudur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PlakaSill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MudurSil;
        private System.Windows.Forms.GroupBox Mudurgiris;
        private System.Windows.Forms.TextBox MudurEklee;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button MudurEkle;
        private System.Windows.Forms.GroupBox Plaka;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PlakaSil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PlakaEklee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PlakaEkle;
        private System.Windows.Forms.ComboBox PlakaSilll;
        private System.Windows.Forms.ComboBox MudurSilll;
    }
}

