using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using System.IO;



namespace CycloneV4
{
    


    public partial class Form1 : Form
    {
        ExploitAPI module = new ExploitAPI();


        public Form1()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
            fastColoredTextBox1.Text = "-- CycloneV4 By FortNbreak#8146, Any Code Modification Is Strictly Prohibited.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Red;
            panel1.BackColor = Color.Gray;
            fastColoredTextBox1.BackColor = Color.White;
            fastColoredTextBox1.ForeColor = Color.Red;


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            this.BackColor = Color.DarkGray;
            fastColoredTextBox1.BackColor = Color.Black;
            frm1.ForeColor = Color.Red;
            fastColoredTextBox1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;



        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.Blue;
            this.ForeColor = Color.Blue;
            panel1.ForeColor = Color.Blue;
            label1.ForeColor = Color.Blue;
            fastColoredTextBox1.LineNumberColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            label3.ForeColor = Color.Blue;
            label4.ForeColor = Color.Blue;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.Green;
            this.ForeColor = Color.Green;
            panel1.ForeColor = Color.Green;
            label1.ForeColor = Color.Green;
            fastColoredTextBox1.LineNumberColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label4.ForeColor = Color.Green;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.Red;
            this.ForeColor = Color.Red;
            panel1.ForeColor = Color.Red;
            label1.ForeColor = Color.Red;
            fastColoredTextBox1.LineNumberColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.Yellow;
            this.ForeColor = Color.Yellow;
            panel1.ForeColor = Color.Yellow;
            label1.ForeColor = Color.Yellow;
            fastColoredTextBox1.LineNumberColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label3.ForeColor = Color.Yellow;
            label4.ForeColor = Color.Yellow;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.Magenta;
            this.ForeColor = Color.Magenta;
            panel1.ForeColor = Color.Magenta;
            label1.ForeColor = Color.Magenta;
            fastColoredTextBox1.LineNumberColor = Color.Magenta;
            label2.ForeColor = Color.Magenta;
            label3.ForeColor = Color.Magenta;
            label4.ForeColor = Color.Magenta;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ForeColor = Color.White;
            this.ForeColor = Color.White;
            panel1.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            fastColoredTextBox1.LineNumberColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 60);
            panel1.BackColor = Color.FromArgb(0, 0, 100);
            fastColoredTextBox1.BackColor = Color.FromArgb(0, 0, 90);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
            panel1.BackColor = Color.Red;
            fastColoredTextBox1.BackColor = Color.Red;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
            panel1.BackColor = Color.Green;
            fastColoredTextBox1.BackColor = Color.Green;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            panel1.BackColor = Color.Blue;
            fastColoredTextBox1.BackColor = Color.Blue;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            panel1.BackColor = Color.LightYellow;
            fastColoredTextBox1.BackColor = Color.LightYellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.BackColor = Color.Gray;
            fastColoredTextBox1.BackColor = Color.Gray;
        }
    }
}
