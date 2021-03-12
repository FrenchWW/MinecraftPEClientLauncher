using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Message;

namespace LifeLuncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            Initialize();
            Update();
          
        }

       public DiscordRpcClient client;
        

        void Initialize()
        {
            client = new DiscordRpcClient("803726762445242458");
        
            client.Initialize();
          
            
   
            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "In The Menus",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {

                    LargeImageKey = "life",
                    LargeImageText = "Dev Mode",
                    SmallImageKey = "image_small"
                }
            });; 
        }

        void InGame()
        {
            client = new DiscordRpcClient("803726762445242458");

            client.Initialize();
            client.Invoke();

            client.SetPresence(new RichPresence()
            {
                Details = "",
                State = "Playing Minecraft",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {

                    LargeImageKey = "life",
                    LargeImageText = "Dev Mode",
                    SmallImageKey = "image_small"
                }
            }); ;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Lite Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }
 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Life client started !");
            System.Diagnostics.Process.Start("minecraft://");
            InGame();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServerPage f2 = new ServerPage();
            f2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to join lbsg ?", "Lite Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("minecraft://versai.pro:19132");
            }
            else
            { }
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingPage f2 = new SettingPage();
            f2.Show();
        }
    }
}
