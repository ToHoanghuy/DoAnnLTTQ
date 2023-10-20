using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Imaging;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        Point EmptyPoint;
        ArrayList images = new ArrayList(); 
        public Form1()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;
            Image original = Image.FromFile(@"C:\Users\Admin\Pictures\camiphone\IMG_E0565.JPG");

            cropImageTomages(original, 270, 270);

            AddImagesToButtons(images);


        }

        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            arr = suffle(arr);
               
            foreach (Button b in panel1.Controls)
            {
                if(i<arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr =arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void cropImageTomages(Image original, int v1, int v2)
        {
            Bitmap bmp = new Bitmap(v1, v2);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(original, 0, 0,v1,v2);
            graphic.Dispose();

            int movr = 0, movd = 0;
            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++) 
                    for (int j=0;j<90;j++)
                        piece.SetPixel(i,j,bmp.GetPixel(i+movr,j+movd));
                images.Add(piece);

                movr += 90;
                if(movr== 270)
                {
                    movr = 0;
                    movd += 90; 
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }
        private void MoveButton(Button btn)
        {
            if(((btn.Location.X==EmptyPoint.X-90||btn.Location.X==EmptyPoint.X+90)&&btn.Location.Y==EmptyPoint.Y)||
              ((btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90) && btn.Location.X == EmptyPoint.X))
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint= swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
                MessageBox.Show("You Win<3333");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}