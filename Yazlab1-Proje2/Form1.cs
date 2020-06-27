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

namespace Yazlab1_Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        public static string Metin;
        public static int[,] matris = new int[9, 9];
        public static int[,] matris2 = new int[9, 9];
        public static int[,] matris3 = new int[9, 9];
        public static int[,] matris4 = new int[9, 9];
        public static void matrisOlustur()
        {
            for (int j = 0; j < 9; j++)
            {
                if (Metin[j] == '*')
                {
                    matris[0, j] = 0;
                }
                else
                {
                    matris[0, j] = Convert.ToInt32(Metin[j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[11 + j] == '*')
                {
                    matris[1, j] = 0;
                }
                else
                {
                    matris[1, j] = Convert.ToInt32(Metin[11 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[22 + j] == '*')
                {
                    matris[2, j] = 0;
                }
                else
                {
                    matris[2, j] = Convert.ToInt32(Metin[22 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[33 + j] == '*')
                {
                    matris[3, j] = 0;
                }
                else
                {
                    matris[3, j] = Convert.ToInt32(Metin[33 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[44 + j] == '*')
                {
                    matris[4, j] = 0;
                }
                else
                {
                    matris[4, j] = Convert.ToInt32(Metin[44 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[55 + j] == '*')
                {
                    matris[5, j] = 0;
                }
                else
                {
                    matris[5, j] = Convert.ToInt32(Metin[55 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[66 + j] == '*')
                {
                    matris[6, j] = 0;
                }
                else
                {
                    matris[6, j] = Convert.ToInt32(Metin[66 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[77 + j] == '*')
                {
                    matris[7, j] = 0;
                }
                else
                {
                    matris[7, j] = Convert.ToInt32(Metin[77 + j]) - 48;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                if (Metin[88 + j] == '*')
                {
                    matris[8, j] = 0;
                }
                else
                {
                    matris[8, j] = Convert.ToInt32(Metin[88 + j]) - 48;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris2[j, i] = matris[j, i];
                    matris3[j, i] = matris[j, i];
                    matris4[j, i] = matris[j, i];
                }
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void Hakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mehmet Emin ARSLAN-150201127\nOğuz KOÇAK-150201", "Hazırlayanlar");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Baslat_Click(object sender, EventArgs e)
        {
            Form2 basla = new Form2();
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.Filter = "Metin Dosyaları (*.txt) |*.txt|Tüm Dosyalar |*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string DosyaKonumu = openFileDialog1.FileName;
                StreamReader DosyaOkuyucu = new StreamReader(DosyaKonumu);
                Metin = DosyaOkuyucu.ReadToEnd();
                matrisOlustur();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (matris[i, j] != 0)
                        {
                            basla.richTextBox1.Text += matris[i, j] + " | ";
                        }
                        else
                            basla.richTextBox1.Text += "  " + " | ";
                    }
                    basla.richTextBox1.Text += Environment.NewLine;
                    if ((i + 1) % 3 == 0)
                    {
                        basla.richTextBox1.Text += "-------------------------------------" + Environment.NewLine;
                    }
                }
                this.Visible = false;
                basla.Visible = true;
                basla.Width = 495;
                basla.kaydet.Visible = false;
                basla.panel1.Width = 494;
                basla.exit.Location = new Point(445, 0);
            }
        }

        private void Yardim_Click(object sender, EventArgs e)
        {

        }
    }
}
