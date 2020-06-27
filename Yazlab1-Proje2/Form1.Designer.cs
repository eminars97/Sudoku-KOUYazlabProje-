namespace Yazlab1_Proje2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Hakkinda = new System.Windows.Forms.Button();
            this.Baslat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 48);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Yazlab1_Proje2.Properties.Resources.if_Cancel_1493282;
            this.pictureBox2.Location = new System.Drawing.Point(295, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Hakkinda
            // 
            this.Hakkinda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hakkinda.ForeColor = System.Drawing.Color.DarkBlue;
            this.Hakkinda.Image = global::Yazlab1_Proje2.Properties.Resources._127___Information_32;
            this.Hakkinda.Location = new System.Drawing.Point(183, 312);
            this.Hakkinda.Name = "Hakkinda";
            this.Hakkinda.Size = new System.Drawing.Size(60, 53);
            this.Hakkinda.TabIndex = 3;
            this.toolTip3.SetToolTip(this.Hakkinda, "Hakkımda");
            this.Hakkinda.UseVisualStyleBackColor = true;
            this.Hakkinda.Click += new System.EventHandler(this.Hakkinda_Click);
            // 
            // Baslat
            // 
            this.Baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Baslat.ForeColor = System.Drawing.Color.DarkBlue;
            this.Baslat.Image = global::Yazlab1_Proje2.Properties.Resources.if_open_file_85334;
            this.Baslat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Baslat.Location = new System.Drawing.Point(100, 312);
            this.Baslat.Name = "Baslat";
            this.Baslat.Size = new System.Drawing.Size(60, 53);
            this.Baslat.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Baslat, "Dosya Aç");
            this.Baslat.UseVisualStyleBackColor = true;
            this.Baslat.Click += new System.EventHandler(this.Baslat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yazlab1_Proje2.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(57, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(342, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hakkinda);
            this.Controls.Add(this.Baslat);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Baslat;
        private System.Windows.Forms.Button Hakkinda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

