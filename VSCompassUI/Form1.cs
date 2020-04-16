using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSCompassUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            compass.northPositionX = Convert.ToInt32(textBox1.Text);
            compass.northPositionY = Convert.ToInt32(textBox2.Text);
            compass.RotateNeedle();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            compass.targetPositionX = Convert.ToInt32(textBox1.Text);
            compass.targetPositionY = Convert.ToInt32(textBox2.Text);
            compass.RotateRose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "Wybierz igłę",
                Filter = "Png files (*.png)|*.png",
                Title = "Open png file"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bp = (Bitmap)Image.FromFile(ofd.FileName);
                    compass.needleBitmap = bp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "Wybierz różę",
                Filter = "Png files (*.png)|*.png",
                Title = "Open png file"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bp = (Bitmap)Image.FromFile(ofd.FileName);
                    compass.roseBitmap = bp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
