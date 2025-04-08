using DevExpress.UIAutomation;
using DevExpress.Utils.VisualEffects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        public int pipesLocation;
        Random rand = new Random();
        PictureBox pipedown = new PictureBox();
        PictureBox pipeup = new PictureBox();
        bool birdown = true;
        int bird;
        bool spawned = true;
        



        public Form1( )
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            pipeMove(4);
            
            if (birdown)
            {
                BirdDown();

            }
            else
            {
                bird = pictureBox_Bird.Location.Y;
                while (bird - 60 <= pictureBox_Bird.Location.Y)
                {

                    BirdUp();

                    birdown = true;
                    

                }
            }

            if (checkPipeOut()) { pipesRespawn(); }

            

        }
        private void isEnd( )
        {
            if (birdCollide()) { timer1.Stop(); 
            
            button1.Enabled = true;
            button1.Visible = true;
            
            }
        }

        private bool checkPipeOut( )
        {
            if (pipeup.Location.X <= -100) { return true; }
            else { return false; }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gameStart();
            simpleButton1.Visible = false;
            simpleButton1.Enabled = false;
            

        }
        private void gameStart( )
        {
            pictureBox_Bird.Location = new Point(100,300);
            pipesSpawn();
            timer1.Start();
        }


        private void orignalPipeMove( int a )
        {
            pictureBox_pipeDown.Location = new Point(pictureBox_pipeUp.Location.X -a,pictureBox_pipeDown.Location.Y);
            pictureBox_pipeUp.Location = new Point(pictureBox_pipeUp.Location.X - a,pictureBox_pipeUp.Location.Y);

        }

        private void pictureBox_pipeUp_Click(object sender, EventArgs e)
        {

        }
        private void pipesSpawn( )
        {
            Point location = new Point(700, rand.Next(100, 410));
            pipesLocation = location.X;




            pipeup.Location = new Point(location.X - (pictureBox_pipeUp.Size.Width / 2), location.Y + pictureBox_Bird.Size.Height * 2);
            pipeup.Size = new Size(pictureBox_pipeUp.Size.Width, pictureBox_pipeUp.Size.Height);
            pipeup.Image = Image.FromFile("C:\\Users\\eyup\\source\\repos\\FlappyBird\\FlappyBird\\Resources\\imgbin_mario-pipe-png.png");
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pipeup);




            pipedown.Size = new Size(pictureBox_pipeDown.Size.Width, pictureBox_pipeDown.Size.Height);
            pipedown.Location = new Point(location.X - (pictureBox_pipeDown.Size.Width / 2), location.Y - (pictureBox_pipeDown.Size.Height + pictureBox_Bird.Size.Height * 2));
            pipedown.Image = Image.FromFile("C:\\Users\\eyup\\source\\repos\\FlappyBird\\FlappyBird\\Resources\\imgbin_mario-pipe-upsidedown-png.png");
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pipedown);
            spawned = true;

        }
        private void pipesRespawn( )
        {
            Point location = new Point(700, rand.Next(100, 410));

            pipeup.Location = new Point(location.X - (pictureBox_pipeUp.Size.Width / 2), location.Y + pictureBox_Bird.Size.Height * 2);
            pipedown.Location = new Point(location.X - (pictureBox_pipeDown.Size.Width / 2), location.Y - (pictureBox_pipeDown.Size.Height + pictureBox_Bird.Size.Height * 2));

        }
        private void pipesDespawn( )
        {
            this.Controls.Remove( pipeup );
            this.Controls.Remove(pipedown);
        }

        private void pipeMove(int a )
        {
            pipeup.Location = new Point(pipeup.Location.X - a , pipeup.Location.Y);
            pipedown.Location = new Point(pipeup.Location.X - a, pipedown.Location.Y);


        }
        private void BirdDown( )
        {
            pictureBox_Bird.Location = new Point(pictureBox_Bird.Location.X, pictureBox_Bird.Location.Y + 3);
            isEnd();
        }
        private void BirdUp( )
        {

            pictureBox_Bird.Location = new Point(pictureBox_Bird.Location.X, pictureBox_Bird.Location.Y - 3);
            isEnd();


        }

        private void simpleButton1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pipesDespawn();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            birdown = false;
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool birdCollide( )
        {   
            bool Flag = false;

            if(pictureBox_Bird.Location.Y + pictureBox_Bird.Size.Height >= pictureBox_Ground.Location.Y) { Flag = true; }
            if(pictureBox_Bird.Location.X+pictureBox_Bird.Size.Width >= pipedown.Location.X && pictureBox_Bird.Location.Y  <=  pipedown.Location.Y + pipedown.Size.Height && pipedown.Location.X + pipedown.Size.Width >= pictureBox_Bird.Location.X) Flag = true;
            if(pictureBox_Bird.Location.X+pictureBox_Bird.Size.Width >= pipeup.Location.X && pictureBox_Bird.Location.Y + pictureBox_Bird.Size.Height >= pipeup.Location.Y && pipeup.Location.X+pipeup.Size.Width >= pictureBox_Bird.Location.X) Flag = true;


            return Flag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            gameStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameStart();
            button1.Enabled = false;
            button1.Visible = false;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            birdown = false;
        }
    }
}
