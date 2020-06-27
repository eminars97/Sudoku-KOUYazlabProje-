namespace Yazlab1_Proje2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Kayitbox = new System.Windows.Forms.RichTextBox();
            this.anasayfa = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.coz = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Kayitbox2 = new System.Windows.Forms.RichTextBox();
            this.Kayitbox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 48);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exit
            // 
            this.exit.Image = global::Yazlab1_Proje2.Properties.Resources.if_Cancel_1493282;
            this.exit.Location = new System.Drawing.Point(1252, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(46, 46);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 388);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(504, 85);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(370, 388);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // Kayitbox
            // 
            this.Kayitbox.BackColor = System.Drawing.Color.DarkGray;
            this.Kayitbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitbox.Location = new System.Drawing.Point(49, 350);
            this.Kayitbox.Name = "Kayitbox";
            this.Kayitbox.ReadOnly = true;
            this.Kayitbox.Size = new System.Drawing.Size(90, 106);
            this.Kayitbox.TabIndex = 14;
            this.Kayitbox.Text = "";
            this.Kayitbox.Visible = false;
            // 
            // anasayfa
            // 
            this.anasayfa.AutoSize = true;
            this.anasayfa.BackColor = System.Drawing.Color.DarkBlue;
            this.anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfa.ForeColor = System.Drawing.Color.DarkBlue;
            this.anasayfa.Image = global::Yazlab1_Proje2.Properties.Resources.Home_64;
            this.anasayfa.Location = new System.Drawing.Point(405, 122);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(78, 78);
            this.anasayfa.TabIndex = 13;
            this.toolTip3.SetToolTip(this.anasayfa, "Anasayfa");
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // kaydet
            // 
            this.kaydet.AutoSize = true;
            this.kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydet.ForeColor = System.Drawing.Color.DarkBlue;
            this.kaydet.Image = global::Yazlab1_Proje2.Properties.Resources.if_save_173091__1_;
            this.kaydet.Location = new System.Drawing.Point(405, 335);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(78, 78);
            this.kaydet.TabIndex = 12;
            this.toolTip1.SetToolTip(this.kaydet, "Kaydet");
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // coz
            // 
            this.coz.AutoSize = true;
            this.coz.BackColor = System.Drawing.Color.DarkBlue;
            this.coz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coz.ForeColor = System.Drawing.Color.DarkBlue;
            this.coz.Image = global::Yazlab1_Proje2.Properties.Resources.if_sudoku5_39888;
            this.coz.Location = new System.Drawing.Point(405, 223);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(78, 78);
            this.coz.TabIndex = 9;
            this.toolTip2.SetToolTip(this.coz, "Sudoku Çöz");
            this.coz.UseVisualStyleBackColor = false;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(721, 501);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "THREAD1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(868, 501);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "THREAD2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(1036, 501);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "THREAD3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Kayitbox2
            // 
            this.Kayitbox2.BackColor = System.Drawing.Color.DarkGray;
            this.Kayitbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitbox2.Location = new System.Drawing.Point(157, 350);
            this.Kayitbox2.Name = "Kayitbox2";
            this.Kayitbox2.ReadOnly = true;
            this.Kayitbox2.Size = new System.Drawing.Size(90, 106);
            this.Kayitbox2.TabIndex = 18;
            this.Kayitbox2.Text = "";
            this.Kayitbox2.Visible = false;
            // 
            // Kayitbox3
            // 
            this.Kayitbox3.BackColor = System.Drawing.Color.DarkGray;
            this.Kayitbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitbox3.Location = new System.Drawing.Point(282, 350);
            this.Kayitbox3.Name = "Kayitbox3";
            this.Kayitbox3.ReadOnly = true;
            this.Kayitbox3.Size = new System.Drawing.Size(90, 106);
            this.Kayitbox3.TabIndex = 19;
            this.Kayitbox3.Text = "";
            this.Kayitbox3.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox3.Location = new System.Drawing.Point(503, 85);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(370, 388);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox4.Location = new System.Drawing.Point(504, 85);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(370, 388);
            this.richTextBox4.TabIndex = 21;
            this.richTextBox4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1094, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(937, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(353, 388);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(937, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(353, 388);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(937, 85);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(353, 388);
            this.textBox3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1060, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "HIZ:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1302, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Kayitbox3);
            this.Controls.Add(this.Kayitbox2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Kayitbox);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button coz;
        public System.Windows.Forms.Button kaydet;
        public System.Windows.Forms.Button anasayfa;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.RichTextBox Kayitbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RichTextBox Kayitbox2;
        private System.Windows.Forms.RichTextBox Kayitbox3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}