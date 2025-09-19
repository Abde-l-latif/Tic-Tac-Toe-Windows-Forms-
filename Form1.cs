using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        enum en_players { player1 , player2 }

        struct status_game
        {
            public en_players move;
            public byte Steps;
            public string game_winner;
        }

        status_game StatusGame;

        public Form1()
        {
            InitializeComponent();
        }

        //CUSTOM FUNCTIONS 

        private void game_start()
        {
            StatusGame.move = en_players.player1;
            StatusGame.Steps= 1;

        }

        private void game_over()
        {
            lb_win.Text = StatusGame.game_winner;
            lb_player.Text = "GAME OVER";
            panel1.Enabled = false; 
        }

        private void PlayMove(object my_pec)
        {
            PictureBox pic = (PictureBox)my_pec;

            if (StatusGame.Steps % 2 != 0) 
            {
                pic.Image = Properties.Resources.x;
                pic.Tag = "X"; 

                if(StatusGame.Steps == 9)
                {
                    StatusGame.game_winner = "Draw";
                    game_over();
                    return;
                }
                StatusGame.move = en_players.player2;
                lb_player.Text = StatusGame.move.ToString();
            }
            else
            {
                pic.Image = Properties.Resources.o;
                pic.Tag = "O";
                StatusGame.move = en_players.player1;
                lb_player.Text = StatusGame.move.ToString();
            }

            StatusGame.Steps++;
        }
        private bool check_if_already_clicked(object sender)
        {
            return (((PictureBox)sender).Tag.ToString() == "X" || ((PictureBox)sender).Tag.ToString() == "O");
        }
        private void restart_game()
        {
            StatusGame.Steps = 1;

            StatusGame.game_winner = "in proccess";

            panel1.Enabled = true;
   
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = pictureBox7.Image =
                 pictureBox8.Image = pic_1.Image = Properties.Resources.question;

            pictureBox1.Tag = '?';
            pictureBox2.Tag = '?';
            pictureBox3.Tag = '?';
            pictureBox4.Tag = '?';
            pictureBox5.Tag = '?';
            pictureBox6.Tag = '?';
            pictureBox7.Tag = '?';
            pictureBox8.Tag = '?';
            pic_1.Tag = '?';

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pic_1.BackColor = Color.Transparent;

            lb_player.Text = en_players.player1.ToString();

            lb_win.Text = StatusGame.game_winner;

        }
        private void CheckWin(PictureBox a, PictureBox b, PictureBox c)
        {
            if (a.Tag.ToString() != "?" && b.Tag == a.Tag && c.Tag == b.Tag)
            {
                a.BackColor = b.BackColor = c.BackColor = Color.Azure;
                
                if(a.Tag.ToString() == "X")
                {
                    StatusGame.game_winner = en_players.player1.ToString();
                    game_over();
                    return; 
                }

                if (a.Tag.ToString() == "O")
                {
                    StatusGame.game_winner = en_players.player2.ToString();
                    game_over();
                    return;
                }

                return;
            }
        }
        private void winner()
        {
            // Rows
            CheckWin(pic_1, pictureBox1, pictureBox2);
            CheckWin(pictureBox5, pictureBox4, pictureBox3);
            CheckWin(pictureBox8, pictureBox7, pictureBox6);

            // Columns
            CheckWin(pic_1, pictureBox5, pictureBox8);
            CheckWin(pictureBox1, pictureBox4, pictureBox7);
            CheckWin(pictureBox2, pictureBox3, pictureBox6);

            CheckWin(pic_1, pictureBox4, pictureBox6);
            CheckWin(pictureBox2, pictureBox4, pictureBox8);
        }



        //EVENTS
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 6);

            e.Graphics.DrawLine(pen, 50, 190, 520, 190);
            e.Graphics.DrawLine(pen, 50, 290, 520, 290);
            e.Graphics.DrawLine(pen, 200, 100, 200, 390);
            e.Graphics.DrawLine(pen, 370, 100, 370, 390);

        }
        private void pic_Click(object sender, EventArgs e)
        {
            if (check_if_already_clicked(sender) == true)
            {
                MessageBox.Show("this button Already clicked!", "caption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlayMove(sender);
            winner();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restart_game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game_start();
        }
    }
}
