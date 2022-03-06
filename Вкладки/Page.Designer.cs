
namespace Вкладки
{
    partial class form1
    {
       


        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Fam = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.butSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butDownload = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.RichTextBox();
            this.Etc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.butSelDel = new System.Windows.Forms.Button();
            this.butDelite = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.Fam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Fam);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 578);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // Fam
            // 
            this.Fam.BackColor = System.Drawing.Color.PeachPuff;
            this.Fam.Controls.Add(this.linkLabel1);
            this.Fam.Controls.Add(this.butSettings);
            this.Fam.Controls.Add(this.label4);
            this.Fam.Controls.Add(this.groupBox1);
            this.Fam.Location = new System.Drawing.Point(4, 25);
            this.Fam.Name = "Fam";
            this.Fam.Padding = new System.Windows.Forms.Padding(3);
            this.Fam.Size = new System.Drawing.Size(1063, 549);
            this.Fam.TabIndex = 0;
            this.Fam.Text = "Page1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(214, 471);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(247, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Zinnatullina-Regina";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // butSettings
            // 
            this.butSettings.BackColor = System.Drawing.Color.SandyBrown;
            this.butSettings.Location = new System.Drawing.Point(775, 469);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(249, 46);
            this.butSettings.TabIndex = 3;
            this.butSettings.Text = "Настройки";
            this.butSettings.UseVisualStyleBackColor = false;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ссылка на гит: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.butDownload);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Etc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // butDownload
            // 
            this.butDownload.BackColor = System.Drawing.Color.SandyBrown;
            this.butDownload.ForeColor = System.Drawing.Color.Black;
            this.butDownload.Location = new System.Drawing.Point(547, 359);
            this.butDownload.Name = "butDownload";
            this.butDownload.Size = new System.Drawing.Size(190, 48);
            this.butDownload.TabIndex = 6;
            this.butDownload.Text = "Сохранить";
            this.butDownload.UseVisualStyleBackColor = false;
            this.butDownload.Click += new System.EventHandler(this.butDownload_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(151, 117);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(559, 42);
            this.Name.TabIndex = 5;
            this.Name.Text = "";
            // 
            // Etc
            // 
            this.Etc.Location = new System.Drawing.Point(151, 192);
            this.Etc.Name = "Etc";
            this.Etc.Size = new System.Drawing.Size(561, 144);
            this.Etc.TabIndex = 3;
            this.Etc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.butSelDel);
            this.tabPage2.Controls.Add(this.butDelite);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(7, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1050, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butSelDel
            // 
            this.butSelDel.BackColor = System.Drawing.Color.LightCoral;
            this.butSelDel.Location = new System.Drawing.Point(547, 463);
            this.butSelDel.Name = "butSelDel";
            this.butSelDel.Size = new System.Drawing.Size(510, 30);
            this.butSelDel.TabIndex = 2;
            this.butSelDel.Text = "Удалить выделенное";
            this.butSelDel.UseVisualStyleBackColor = false;
            this.butSelDel.Click += new System.EventHandler(this.butSelDel_Click);
            // 
            // butDelite
            // 
            this.butDelite.BackColor = System.Drawing.Color.LightCoral;
            this.butDelite.ForeColor = System.Drawing.Color.Black;
            this.butDelite.Location = new System.Drawing.Point(3, 463);
            this.butDelite.Name = "butDelite";
            this.butDelite.Size = new System.Drawing.Size(533, 31);
            this.butDelite.TabIndex = 1;
            this.butDelite.Text = "Очистить таблицу";
            this.butDelite.UseVisualStyleBackColor = false;
            this.butDelite.Click += new System.EventHandler(this.butDelite_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 333;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 333;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Описание";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 333;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1063, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "+";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(149, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(561, 47);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 578);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
         
            this.Text = "Вкладки";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabControl1.ResumeLayout(false);
            this.Fam.ResumeLayout(false);
            this.Fam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button butDownload;
        public System.Windows.Forms.RichTextBox Name;
        public System.Windows.Forms.RichTextBox Etc;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button butDelite;
        private System.Windows.Forms.Button butSelDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TabPage Fam;
    }
}

