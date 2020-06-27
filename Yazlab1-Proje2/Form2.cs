using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab1_Proje2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        int Move;
        int Mouse_X;
        int Mouse_Y;
        int kontlrl = 0;
        int[,] yedekMatris2 = new int[9, 9];
        int[,] yedekMatris3 = new int[9, 9];
        int[,] yedekMatris4 = new int[9, 9];
        public static Thread sudoku1 = null;
        public static Thread sudoku2 = null;
        public static Thread sudoku3 = null;
        Stopwatch watch1 = new Stopwatch();
        Stopwatch watch2 = new Stopwatch();
        Stopwatch watch3 = new Stopwatch();

        static bool satirkontrolu(int satir, int deger, int[,] dizi)
        {
            for (int i = 0; i < 9; i++)
            {
                if (dizi[i, satir] == deger)
                {
                    return false;
                }
            }
            return true;
        }
        static bool sutunkontrolu(int sutun, int deger, int[,] dizi)
        {
            for (int i = 0; i < 9; i++)
            {
                if (dizi[sutun, i] == deger)
                {
                    return false;
                }
            }
            return true;
        }
        static bool kareKontrol(int satir, int sutun, int deger, int[,] dizi)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dizi[sutun - (sutun % 3) + i, satir - (satir % 3) + j] == deger)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static bool chkMove(int satir, int sutun, int deger, int[,] dizi)
        {
            if (!satirkontrolu(satir, deger, dizi))
            {
                return false;
            }
            if (!sutunkontrolu(sutun, deger, dizi))
            {
                return false;
            }
            if (!kareKontrol(satir, sutun, deger, dizi))
            {
                return false;
            }
            return true;
        }
        bool girdimi = false; bool girdimi2 = false; bool girdimi3 = false;
        public int[,] sudokuCoz(int deger, int px, int py, int[,] matris)
        {
            watch1.Start();
            int[,] yedekMatris = new int[9, 9];
            if (!girdimi)
            {
                
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris[j, i] = matris[j, i];
                    }
                }
                yedekMatris[px, py] = deger;
                yedekMatris2[px, py] = deger;
                Kayitbox.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                textBox1.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (yedekMatris[x, y] == 0)
                        {
                            for (int val = 1; val <= 9; val++)
                            {
                                if (chkMove(y, x, val, yedekMatris))
                                {
                                    sudokuCoz(val, x, y, yedekMatris);
                                }
                            }
                            return null;
                        }
                    }
                }                
                radioButton1.Checked = true;
                richTextBox2.Visible = true;
                richTextBox4.Visible = false;
                richTextBox3.Visible = false;
                girdimi = true;
                Kayitbox.Text += Environment.NewLine;
                Kayitbox.Text += Environment.NewLine;
                watch1.Stop();
                //sudoku1.Suspend();
                sudoku2.Suspend();
                sudoku3.Suspend();
                return yedekMatris;
            }
           return yedekMatris;
        }
        public int[,] sudokuCoz2(int deger, int px, int py, int[,] matris)
        {
            watch2.Start();
            int[,] yedekMatris = new int[9, 9];
            if (!girdimi2)
            {
                
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris[j, i] = matris[j, i];
                    }
                }
                yedekMatris[px, py] = deger;
                yedekMatris3[px, py] = deger;
                Kayitbox2.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                textBox2.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (yedekMatris[x, y] == 0)
                        {
                            for (int val = 1; val <= 9; val++)
                            {
                                if (chkMove(y, x, val, yedekMatris))
                                {
                                    sudokuCoz2(val, x, y, yedekMatris);
                                }
                            }
                            return null;
                        }
                    }
                }
                radioButton2.Checked = true;
                richTextBox3.Visible = true;
                richTextBox2.Visible = false;
                richTextBox4.Visible = false;
                girdimi2 = true;
                Kayitbox2.Text += Environment.NewLine;
                Kayitbox2.Text += Environment.NewLine;
                watch2.Stop();
                sudoku1.Suspend();
                //sudoku2.Suspend();
                sudoku3.Suspend();
                return yedekMatris;
            }
            
            
            return yedekMatris;
        }
        public int[,] sudokuCoz3(int deger, int px, int py, int[,] matris)
        {
            watch3.Start();
            int[,] yedekMatris = new int[9, 9];
            if (!girdimi3)
            {                
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris[j, i] = matris[j, i];
                    }
                }
                yedekMatris[px, py] = deger;
                yedekMatris4[px, py] = deger;
                Kayitbox3.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                textBox3.Text += "[" + px + "," + py + "]. Bölgeye " + yedekMatris[px, py] + " koyuldu." + Environment.NewLine;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (yedekMatris[x, y] == 0)
                        {
                            for (int val = 1; val <= 9; val++)
                            {
                                if (chkMove(y, x, val, yedekMatris))
                                {
                                    sudokuCoz3(val, x, y, yedekMatris);
                                }
                            }
                            return null;
                        }
                    }
                }
                radioButton3.Checked = true;
                richTextBox4.Visible = true;
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;
                girdimi3 = true;
                Kayitbox3.Text += Environment.NewLine;
                Kayitbox3.Text += Environment.NewLine;
                watch3.Stop();
                sudoku1.Suspend();
                sudoku2.Suspend();
                //sudoku3.Suspend();
                return yedekMatris;
            }
            
            
            return yedekMatris;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void anasayfa_Click(object sender, EventArgs e)
        {
            kontlrl = 0;
            Form1 anasayfaform = new Form1();
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.richTextBox3.Clear();
            this.richTextBox4.Clear();
            this.Kayitbox.Clear();
            this.Kayitbox2.Clear();
            this.Kayitbox3.Clear();
            this.Visible = false;
            anasayfaform.Visible = true;
        }

        private void coz_Click(object sender, EventArgs e)
        {
            if(kontlrl == 0)
            {
                textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.Width = 1302;
                this.kaydet.Visible = true;
                this.panel1.Width = 1301;
                this.exit.Location = new Point(1252, 0);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris2[j, i] = Form1.matris2[j, i];
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris3[j, i] = Form1.matris3[j, i];
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        yedekMatris4[j, i] = Form1.matris4[j, i];
                    }
                }
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                richTextBox2.Visible = false;
                richTextBox4.Visible = false;
                richTextBox3.Visible = false;
                Control.CheckForIllegalCrossThreadCalls = false;
                sudoku1 = new Thread(() => sudokuCoz(0, 0, 0, Form1.matris2));
                sudoku2 = new Thread(() => sudokuCoz2(0, 5, 0, Form1.matris3));
                sudoku3 = new Thread(() => sudokuCoz3(0, 8, 8, Form1.matris4));
                sudoku1.Start();
                sudoku2.Start();
                sudoku3.Start();                
                for(int i=0;i<40000;i++)
                {
                    Console.WriteLine(i);
                }
                MessageBox.Show("Lütfen Gri Kutuları Bekleyiniz.", "Bildirim");
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (yedekMatris2[i, j] != 0)
                        {
                            richTextBox2.Text += yedekMatris2[i, j] + " | ";
                            Kayitbox.Text += yedekMatris2[i, j] + " | ";
                        }
                        else
                        {
                            richTextBox2.Text += "  " + " | ";
                            Kayitbox.Text += " " + " | ";
                        }
                            
                    }
                    richTextBox2.Text += Environment.NewLine;
                    Kayitbox.Text += Environment.NewLine;
                    if ((i + 1) % 3 == 0)
                    {
                        richTextBox2.Text += "-------------------------------------" + Environment.NewLine;
                        Kayitbox.Text += "-------------------------------------" + Environment.NewLine;
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (yedekMatris3[i, j] != 0)
                        {
                            richTextBox3.Text += yedekMatris3[i, j] + " | ";
                            Kayitbox2.Text += yedekMatris3[i, j] + " | ";
                        }
                        else
                        {
                            richTextBox3.Text += "  " + " | ";
                            Kayitbox2.Text += " " + " | ";
                        }                            
                    }
                    richTextBox3.Text += Environment.NewLine;
                    Kayitbox2.Text += Environment.NewLine;
                    if ((i + 1) % 3 == 0)
                    {
                        richTextBox3.Text += "-------------------------------------" + Environment.NewLine;
                        Kayitbox2.Text += "-------------------------------------" + Environment.NewLine;
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (yedekMatris4[i, j] != 0)
                        {
                            richTextBox4.Text += yedekMatris4[i, j] + " | ";
                            Kayitbox3.Text += yedekMatris4[i, j] + " | ";
                        }
                        else
                        {
                            richTextBox4.Text += "  " + " | ";
                            Kayitbox3.Text += " " + " | ";
                        }
                    }
                    richTextBox4.Text += Environment.NewLine;
                    Kayitbox3.Text += Environment.NewLine;
                    if ((i + 1) % 3 == 0)
                    {
                        richTextBox4.Text += "-------------------------------------" + Environment.NewLine;
                        Kayitbox3.Text += "-------------------------------------" + Environment.NewLine;
                    }
                }
                label1.Text = Convert.ToString(watch1.ElapsedMilliseconds);
                label1.Text = Convert.ToString(watch2.ElapsedMilliseconds);
                label1.Text = Convert.ToString(watch3.ElapsedMilliseconds);
               /* if (watch1.ElapsedMilliseconds < watch2.ElapsedMilliseconds)
                {
                    if (watch1.ElapsedMilliseconds < watch3.ElapsedMilliseconds)
                    {
                        label1.Text = Convert.ToString(watch1.ElapsedMilliseconds);
                    }
                }
                else if (watch2.ElapsedMilliseconds < watch1.ElapsedMilliseconds)
                {
                    if (watch2.ElapsedMilliseconds < watch3.ElapsedMilliseconds)
                    {
                        label1.Text = Convert.ToString(watch2.ElapsedMilliseconds);
                    }
                }
                else if (watch3.ElapsedMilliseconds < watch1.ElapsedMilliseconds)
                {
                    if (watch3.ElapsedMilliseconds < watch2.ElapsedMilliseconds)
                    {
                        label1.Text = Convert.ToString(watch3.ElapsedMilliseconds);
                    }
                }*/
                kontlrl = 1;
            }
            else if(kontlrl == 1)
            {
                MessageBox.Show("Zaten Çözüldü.", "Bildirim");
            }
            
        }
        private void sifirla_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.richTextBox3.Clear();
            this.richTextBox4.Clear();
            this.Kayitbox.Clear();
            this.Kayitbox2.Clear();
            this.Kayitbox3.Clear();
            //Form1.Metin = new String[];
            kontlrl = 0;            
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.Filter = "Metin Dosyaları (*.txt) |*.txt|Tüm Dosyalar |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string DosyaKonumu = openFileDialog1.FileName;
                StreamReader DosyaOkuyucu = new StreamReader(DosyaKonumu);
                Form1.Metin = DosyaOkuyucu.ReadToEnd();
                Form1.matrisOlustur();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (Form1.matris[i, j] != 0)
                        {
                            this.richTextBox1.Text += Form1.matris[i, j] + " | ";
                        }
                        else
                            this.richTextBox1.Text += "  "+" | ";
                    }
                    this.richTextBox1.Text += Environment.NewLine;
                    if ((i + 1) % 3 == 0)
                    {
                        this.richTextBox1.Text += "-------------------------------------" + Environment.NewLine;
                    }
                }
                this.Width = 495;
                this.kaydet.Visible = false;
                this.panel1.Width = 494;
                this.exit.Location = new Point(445, 0);
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

        private void kaydet_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                saveFileDialog1.Title = "Kayıt yerini seçiniz";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kayit = new StreamWriter(saveFileDialog1.FileName);
                kayit.WriteLine(Kayitbox.Text);
                kayit.Close();
                MessageBox.Show("Dosya başarılı bir şekilde kaydedildi.", "Bildirim");
            }
            else if (radioButton2.Checked == true)
            {
                saveFileDialog1.Title = "Kayıt yerini seçiniz";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kayit = new StreamWriter(saveFileDialog1.FileName);
                kayit.WriteLine(Kayitbox2.Text);
                kayit.Close();
                MessageBox.Show("Dosya başarılı bir şekilde kaydedildi.", "Bildirim");
            }
            else if (radioButton3.Checked == true)
            {
                saveFileDialog1.Title = "Kayıt yerini seçiniz";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kayit = new StreamWriter(saveFileDialog1.FileName);
                kayit.WriteLine(Kayitbox3.Text);
                kayit.Close();
                MessageBox.Show("Dosya başarılı bir şekilde kaydedildi.", "Bildirim");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox4.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
            richTextBox3.Visible = true;
            richTextBox2.Visible = false;
            richTextBox4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = false;
            label1.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox4.Visible = true;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
            label1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
