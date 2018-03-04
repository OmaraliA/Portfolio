using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.DirectInput;
using Microsoft.DirectX;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace NewGame
{   
    public partial class Form1 : Form
    {
        List<Characters> ch = new List<Characters>();
        SoundPlayer soundPlayer1, soundPlayer2, soundPlayer3, soundPlayer4, soundPlayer5;
        Microsoft.DirectX.Direct3D.Device device;
        Microsoft.DirectX.Direct3D.Font font;

        Texture texture_background, texture_cat,
                texture_milk, texture_snake,
                texture_menu,texture_score,
                texture_blood,texture_bird;
       
        float x2 = 700, y2 = 350;
        float h1 = 150, w1 = 150;
        float h2 = 200, w2 = 200;
        static int level = 1;
        static int hits = 0;
        static int score = 0;

        public Form1()
        {
            InitializeComponent();
            ChangeCursor();
            InitDevice();
            InitFont();
            LoadTexture();
            LoadTexture_Blood();
            Render();
            label6.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            label7.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            Point pt = new Point(pictureBox1.Right - 130, 16);
            Point pt1 = new Point(pictureBox1.Right - 135, 66);
            Point pt2 = new Point(pictureBox1.Right - 130, 126);
            Point pt3 = new Point(pictureBox1.Right - 145, 42);
            Point pt4 = new Point(pictureBox1.Right - 145, 96);
            Point pt5 = new Point(pictureBox1.Right - 150, 16);
            pt.Offset(-pictureBox1.Left, -pictureBox1.Top);
            pt1.Offset(-pictureBox1.Left, -pictureBox1.Top);
            pt2.Offset(-pictureBox1.Left, -pictureBox1.Top);
            pt3.Offset(-pictureBox1.Left, -pictureBox1.Top);
            pt4.Offset(-pictureBox1.Left, -pictureBox1.Top);
            pt5.Offset(-pictureBox1.Left, -pictureBox1.Top);
            label7.Location = pt;
            label1.Location = pt1;
            label2.Location = pt2;
            label3.Location = pt3;
            label4.Location = pt4;
            label5.Location = pt5;
            pictureBox1.Controls.Add(label7);
            label7.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            label8.Visible = false;
            textBox_Hits.Visible = false;
            textBox_Score.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void ChangeCursor()
        {
            Bitmap b = new Bitmap(Properties.Resources.shoot);
            Cursor c = new Cursor(b.GetHicon());
            this.Cursor = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            label6.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            ch.Clear();
            timer1.Start();
            timer2.Start();
        }
      
        private void newLevel(int level)
        {
            level_tb.Text = (int.Parse(level_tb.Text) + level).ToString();
        }

        private void newHit()
        {
            hits_tb.Text = (++hits).ToString();
        }

        private void newScore(int score)
        {
             score_tb.Text = (int.Parse(score_tb.Text) + score).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            label6.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ch.Add(new Characters());
            timer1.Start();
            timer2.Start();
            label6.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ch.Clear();
            timer1.Stop();
            timer2.Stop();
            label6.Visible = false;

            DialogResult dialog = MessageBox.Show("Are you sure to exit?", "Quit Form", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LoadTexture()
        {
            texture_background = TextureLoader.FromFile(device, "image.jpg",device.Viewport.Width,device.Viewport.Height,1,0,Format.A8R8G8B8,Pool.Managed,Filter.Point,Filter.Point,Color.Transparent.ToArgb());
            texture_cat = TextureLoader.FromFile(device, "image2.png", 200,200 , 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
            texture_milk = TextureLoader.FromFile(device, "bucket.png", 200,200, 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
            texture_score = TextureLoader.FromFile(device, "score.png", 200, 200, 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
            texture_bird = TextureLoader.FromFile(device, "bird.png", 200, 200, 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
            texture_snake = TextureLoader.FromFile(device, "snake.png", 200, 200, 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
        }

        private void LoadTexture_Blood()
        {
            texture_blood = TextureLoader.FromFile(device, "splat.png", 200,200, 1, 0, Format.A8R8G8B8, Pool.Managed, Filter.Point, Filter.Point, Color.Transparent.ToArgb());
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ch.Add(new Characters());
            if (true){
                using ( soundPlayer1 = new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\cat.wav"))
                {
                    soundPlayer1.Play(); 
                }
            }
            if (hits > 5)
            {
                ch.Add(new Characters(1));
                using ( soundPlayer2 = new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\Bird.wav"))
                {
                    soundPlayer2.Play(); 
                }
            }
            if (hits > 10)
            {
                ch.Add(new Characters(2));
                using ( soundPlayer3 = new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\snake.wav"))
                {
                    soundPlayer3.Play(); 
                }
                timer2.Interval = 2000;
            }
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            device.Clear(ClearFlags.Target, Color.CornflowerBlue, 0, 1);
            device.BeginScene();
            using (Sprite s = new Sprite(device))
            {
                s.Begin(SpriteFlags.AlphaBlend);
                s.Draw2D(texture_blood, new Rectangle(0,0,200,200), new Rectangle(0, 0, 0, 0), new Point(0, 0), 0f, new Point(e.X-100, e.Y-100), Color.White);
                s.End();
            }
            device.EndScene();
            device.Present();
            int toDel = -1;
            for(int i = 0; i < ch.Count; i++)
            {
                Characters cat = ch[i];
                if ((e.X >= cat.CharacterCoordinates.X && e.X <= cat.CharacterCoordinates.X + 150)
                    && (e.Y >= cat.CharacterCoordinates.Y && e.Y <= cat.CharacterCoordinates.Y + 150))
                {
                    using ( soundPlayer4 = new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\Gun.wav"))
                    {
                        soundPlayer4.Play(); 
                    }
                    toDel = i;
                    newHit();
                    newScore(50);     
                    break;
                }
                if (hits % 5 == 0)
                {
                   // newLevel(1);   
                }
            }

            if(toDel != -1)
            {
                ch.Remove(ch[toDel]);
            }
       }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow; 
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ChangeCursor();
        }

        int currentLeveledHit = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (hits % 5 == 0 && hits != currentLeveledHit)
            {
                newLevel(1);
                currentLeveledHit = hits;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Hashtable deserilizePeople;
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                deserilizePeople = (Hashtable)formatter.Deserialize(fs);  
            }        
            int score = (int.Parse(score_tb.Text));
            string name = textBox1.Text;
            if (deserilizePeople.Contains(name))
            {
                deserilizePeople[name] = score;
            }
            else deserilizePeople.Add(name, score);
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, deserilizePeople);  
            }
            ResultsForm rf = new ResultsForm();
            rf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundPlayer2.Stop();
            soundPlayer3.Stop();
            soundPlayer4.Stop();
            soundPlayer5.Stop();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            ch.Clear();
            hits = 0;
            score = 0;
            level = 1;
            score_tb.Text = "0";
            hits_tb.Text = "0";
            level_tb.Text = "1";
            label6.Visible = false;
            textBox_Hits.Visible = false;
            textBox_Score.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ch.Add(new Characters());
            using ( soundPlayer5 =new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\cat.wav"))
            {
                soundPlayer5.Play(); 
            }
            timer1.Start();
            timer2.Start();
            label7.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            level_tb.Text = "1";
        }

        private void InitDevice()
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            device = new Microsoft.DirectX.Direct3D.Device(0, Microsoft.DirectX.Direct3D.DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing, pp);
        }

        private void InitFont()
        {
            System.Drawing.Font f = new System.Drawing.Font("Arial", 16f, FontStyle.Regular);
            font = new Microsoft.DirectX.Direct3D.Font(device, f);
        }

        private void Render()
        {
            device.Clear(ClearFlags.Target, Color.CornflowerBlue, 0, 1);
            device.BeginScene();
            using (Sprite s = new Sprite(device))
            {
                s.Begin(SpriteFlags.AlphaBlend);        
                s.Draw2D(texture_background, new Rectangle(0, 0, 0, 0), new Rectangle(0,0,device.Viewport.Width,device.Viewport.Height),new Point(0,0),0f,new Point(0,0),Color.White);
                s.Draw2D(texture_score, new Rectangle(0, 0, 0, 0), new Rectangle(0, 0, 200, 200), new Point(0, 0), 0f, new Point(45, -30), Color.White);
                font.DrawText(s, "Level ", new Point(100,60), Color.Black);
                font.DrawText(s, "Hits ", new Point(100,90 ), Color.Black);
                font.DrawText(s, "Score ", new Point(100, 120), Color.Black);
                foreach (Characters c in ch)
                {
                    if (c.type == 0)
                        s.Draw2D(texture_cat, new Rectangle(0, 0, 0, 0), new Rectangle(0, 0, 200, 200), new Point(0, 0), 0f, new Point((int)(c.CharacterCoordinates.X), (int)c.CharacterCoordinates.Y), Color.White);
                    if (c.type == 1)
                        s.Draw2D(texture_bird, new Rectangle(0, 0, 0, 0), new Rectangle(0, 0, 200, 200), new Point(0, 0), 0f, new Point((int)(c.CharacterCoordinates.X+(int)(0.2)), (int)c.CharacterCoordinates.Y+ (int)(0.2)), Color.White);
                    if (c.type == 2)
                        s.Draw2D(texture_snake, new Rectangle(0, 0, 0, 0), new Rectangle(0, 0, 200, 200), new Point(0, 0), 0f, new Point((int)(c.CharacterCoordinates.X + (int)(0.8)), (int)c.CharacterCoordinates.Y + (int)(0.8)), Color.White);
                }
                s.Draw2D(texture_milk, new Rectangle(0, 0, 0, 0), new Rectangle(0, 0, 200, 200), new Point(0, 0), 0f, new Point((int)x2, (int)y2), Color.White);
                s.End();
            } 
            device.EndScene();
            device.Present();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        private void Form1_MouseClick(Object sender, MouseEventArgs e)
        {
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.AutoScroll = false;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ch.Count == 0)
                ch.Add(new Characters());
            Render();
            List<Characters> forDelete = new List<Characters>();
            foreach (Characters c in ch)
            {
                c.move();
                c.move_bird();
                c.move_snake();
                    
                if ((c.CharacterCoordinates.Y < (Characters.MilkCoordinate.Y + h2)) && ((c.CharacterCoordinates.Y + h1) > y2) &&
                    (c.CharacterCoordinates.X < (x2 + w2)) && ((c.CharacterCoordinates.X + w1) > Characters.MilkCoordinate.X))
                { 
                    forDelete.Add(c);
                    label6.Text = "Game Over!";
                    using (SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\андрей\Documents\Visual Studio 2015\Projects\NewGame\NewGame\bin\Debug\GameOver.wav"))
                    {
                        soundPlayer.Play();
                    }
                    textBox_Hits.Visible = true;
                    textBox_Score.Visible = true;
                    label8.Visible = true;
                    textBox_Hits.Text = "Total hits: " + hits;
                    textBox_Score.Text = "Score: " + score_tb.Text;
                    label6.Visible = true;
                    label9.Visible = true;
                    textBox1.Visible = true;
                    button1.Visible = true;
                    timer1.Stop();
                    timer2.Stop();
                }
            }    
            foreach (Characters delc in forDelete)
            {
                ch.Remove(delc);
                ch.Add(new Characters());
                ch.Add(new Characters(1));
                ch.Add(new Characters(2));
            }
        }
    }
}
