using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_War
{
    public partial class Wind : Form
    {
        PictureBox[] stars;
        int backgroundSpeed;
        Random rand;
        int sS_Loc_X;
        int sS_Loc_Y;
        PictureBox spaceShip;
        PictureBox[] munition;
        int munitionSpeed;
        SoundPlayer gameMedia;
        SoundPlayer shootMedia;
        PictureBox[] enemy;
        int enemySpeed;
        int backgroundSpeedMinus = 2;
        PictureBox[] EnemyMunition;
        int enemiesMunitionSpeed;
        int score;
        bool pause;
        bool gameOver;
        Label label1;


        public Wind()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            pause = false;
            gameOver = false;
            label1 = new Label();
            label1.Visible = false;
            this.Icon = new Icon("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/icon.ico");
            this.Text = "Space War";
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 10; // 1 seconde
            timer.Tick += Timer_Tick;
            sS_Loc_X = this.Width / 2 - 50;
            sS_Loc_Y = this.Height - 130;

            spaceShip = new PictureBox();
            spaceShip.Image = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/player.png");
            spaceShip.Location = new Point(sS_Loc_X, sS_Loc_Y);
            spaceShip.SizeMode = PictureBoxSizeMode.StretchImage;
            spaceShip.Size = new Size(50, 50);
            spaceShip.BackColor = Color.Transparent;
            Controls.Add(spaceShip);

            gameMedia = new SoundPlayer("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/songs/GameSong_1.wav");

            gameMedia.PlayLooping();

            int backgroundSpeedMinus = 2;
            backgroundSpeed = 4;
            munitionSpeed = 100;
            stars = new PictureBox[20];
            munition = new PictureBox[3];
            rand = new Random();


            enemySpeed = 2;
            enemiesMunitionSpeed = 3;

            enemy = new PictureBox[10];
            EnemyMunition = new PictureBox[5];

            

            Image Boss1 = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/Boss1.png");
            Image Boss2 = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/Boss2.png");
            Image E1 = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/E1.png");
            Image E2 = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/E2.png");
            Image E3 = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/E3.png");


            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = new PictureBox();
                enemy[i].Size = new Size(40, 40);
                enemy[i].BackColor = Color.Transparent;
                enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemy[i].Visible = false;
                enemy[i].Location = new Point((i + 1) * 50, -50);
                Controls.Add(enemy[i]);
            }

            enemy[0].Image = Boss1;
            enemy[1].Image = Boss2;
            enemy[2].Image = E1;
            enemy[3].Image = E2;
            enemy[4].Image = E3;
            enemy[5].Image = E1;
            


            for (int i = 0; i < EnemyMunition.Length; i++)
            {
                EnemyMunition[i] = new PictureBox();
                EnemyMunition[i].Size = new Size(2, 15); // Taille réduite
                EnemyMunition[i].BackColor = Color.Yellow; // Couleur rouge pour mieux voir
                EnemyMunition[i].Visible = false;
                int x = rand.Next(0, 9);
                EnemyMunition[i].Location = new Point(enemy[x].Location.X, enemy[x].Location.Y - 20);
                Controls.Add(EnemyMunition[i]);
            }

            for (int i = 0; i < munition.Length; i++)
            {
                munition[i] = new PictureBox();
                munition[i].Image = Image.FromFile("C:/Users/uncle/OneDrive/Pictures/Documents/Space war/Space_War/Space_War/asserts/munition.png"); ;
                munition[i].SizeMode = PictureBoxSizeMode.StretchImage;
                munition[i].Size = new Size(20, 20);
                munition[i].Location = new Point(spaceShip.Top, spaceShip.Top - 20);
                Controls.Add(munition[i]);
            }


            this.BackColor = Color.Blue;
            this.MaximumSize = new Size(600, 600);
            this.MinimumSize = new Size(600, 600);
            for (int i = 0; i < stars.Length - 1; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rand.Next(20, this.Width), rand.Next(20, this.Height));
                stars[i].Size = new Size(3, 3);
                stars[i].BackColor = Color.White;
                Controls.Add(stars[i]);
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundSpeed;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }

            }

            for (int i = stars.Length / 2; i < stars.Length - 1; i++)
            {
                stars[i].Top += backgroundSpeed - backgroundSpeedMinus;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }

            }
        }



        private void Wind_KeyDown(object sender, KeyEventArgs e)
        {
            if (pause == false)
            {
                if (e.KeyCode == Keys.D)
                {

                    if (spaceShip.Right + 13 < this.Width)
                    {
                        sS_Loc_X += 15;
                        spaceShip.Location = new Point(sS_Loc_X, sS_Loc_Y);
                    }

                }

                if (e.KeyCode == Keys.A)
                {
                    if (spaceShip.Left > 0)
                    {
                        sS_Loc_X -= 15;
                        spaceShip.Location = new Point(sS_Loc_X, sS_Loc_Y);
                    }

                }

                if (e.KeyCode == Keys.W)
                {
                    if (spaceShip.Top > 4)
                    {
                        sS_Loc_Y -= 15;
                        spaceShip.Location = new Point(sS_Loc_X, sS_Loc_Y);
                    }
                    
                }



                if (e.KeyCode == Keys.S)
                {
                    if (spaceShip.Top + spaceShip.Height + 30 < this.Height)
                    {
                        sS_Loc_Y += 15;
                        spaceShip.Location = new Point(sS_Loc_X, sS_Loc_Y);
                    }
                    else
                    {
                    }

                }

            }
        }

        private void MouveMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < munition.Length; i++)
            {

                munition[i].Top -= munitionSpeed;
                if (munition[i].Top <= -5)
                {
                    munition[i].Top = spaceShip.Top - 20;
                    munition[i].Left = spaceShip.Left + (spaceShip.Width / 2) - (munition[i].Width / 2);
                    
                }
                Collision();
            }
        }

        private void MouveEnemisTimer_Tick(object sender, EventArgs e)
        {
            MouveEnemies(enemy, enemySpeed);
        }

        private void MouveEnemies(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    enemy[i].Location = new Point((i + 1) * 50, -50);
                }
            }
        }

        private void Collision()
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                if (munition[0].Bounds.IntersectsWith(enemy[i].Bounds) 
                    || munition[1].Bounds.IntersectsWith(enemy[i].Bounds) 
                    || munition[2].Bounds.IntersectsWith(enemy[i].Bounds)) {
                    enemy[i].Visible = false;
                    enemy[i].Location = new Point((i + 1) * 50, -50);
                }

                if (spaceShip.Bounds.IntersectsWith(enemy[i].Bounds)) {
                    spaceShip.Visible = false;
                    GameOver("");
                }
            }
        }


        private void StopTimers()
        {
            MouveEnemisTimer.Stop();
            MouveMunitionTimer.Stop();
            enemiesMun.Stop(); // Arrêter le timer des balles ennemies
            backgroundSpeed = 0;
            backgroundSpeedMinus = 0;
        }

        private void StartTimers()
        {
            MouveEnemisTimer.Start();
            MouveMunitionTimer.Start();
            enemiesMun.Start(); // Démarrer le timer des balles ennemies
            backgroundSpeed = 4;
            backgroundSpeedMinus = 2;
        }

        private void GameOver(string message)
        {
            StopTimers();
            gameMedia.Stop();
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
            label3.Visible = true;
        }

        private void enemiesMun_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(e);
            for (int i = 0; i < EnemyMunition.Length; i++)
            {
                EnemyMunition[i].Visible = true; // Rendre visible
                EnemyMunition[i].Top += enemiesMunitionSpeed;
                
                if (EnemyMunition[i].Top >= this.Height)
                {
                    // Reset la position quand elle sort de l'écran
                    int x = rand.Next(0, 9);
                    EnemyMunition[i].Location = new Point(enemy[x].Location.X, enemy[x].Location.Y + 20);
                }
                
                if (EnemyMunition[i].Bounds.IntersectsWith(spaceShip.Bounds))
                {
                    spaceShip.Visible = false;
                    GameOver(""); // Game over quand touché par balle ennemie
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Wind_KeyUp(object sender, KeyEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(sender, e);
        }
    }
}