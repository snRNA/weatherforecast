using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WeatherForecast
{
    public partial class MainForm : Form
    {
        private Point ptMouseNowPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;
        private PictureBox[] ptb = null;
        private HTTP httptest = null;
        public MainForm()
        { 
            InitializeComponent();
            httptest = new HTTP();
            ptb = new PictureBox[2];
            ptb[0] = pictureBox1;
            ptb[1] = pictureBox2;
            String temp = httptest.getWeather("北京");
            updateWeather(temp);
        }
        private void updateWeather(String temp)
        {
            WeatherData a = JsonConvert.DeserializeObject<WeatherData>(temp);
            if (a.desc == "OK")
            {
                this.CityNum.Text = a.data.city;
                int t = int.Parse(a.data.wendu);
                int tenths = t / 10;
                int units = t % 10;
                this.pictureBox1.Image = NumimageList.Images[tenths];
                this.pictureBox2.Image = NumimageList.Images[units];
                this.DetailText.Text = a.data.ganmao;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.8)
            {
                this.Opacity += 0.05;
            }
            else
                timer1.Stop();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnMouseDown)
            {
                //Get the current position of the mouse in the screen
                ptMouseNewPos = Control.MousePosition;
                //Set window position
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseNowPos.X + ptFormPos.X;
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseNowPos.Y + ptFormPos.Y;
                //Save window position
                Location = ptFormNewPos;
                ptFormPos = ptFormNewPos;
                //Save mouse position
                ptMouseNowPos = ptMouseNewPos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //Return back signal
                blnMouseDown = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                blnMouseDown = true;
                // Save window position and mouse position
                ptMouseNowPos = Control.MousePosition;
                ptFormPos = Location;
            }
        }


    }
}
