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
                if (-units > units)
                {
                    this.pictureBox1.Image = NumimageList.Images[Math.Abs(tenths)];
                    this.pictureBox2.Image = NumimageList.Images[-units];

                }
                else
                {
                    this.pictureBox1.Image = NumimageList.Images[tenths];
                    this.pictureBox2.Image = NumimageList.Images[units];
                }
                this.DetailText.Text = a.data.ganmao;
                //                this.chart1.ChartAreas[0].AxisX.
                var b = a.data.yesterday.high.Substring(3);
                this.chart1.Series[0].Points[0].SetValueXY("昨天", double.Parse(b.Substring(0, b.Length - 1)));
                this.chart1.Series[0].Points[0].YValues[0] = double.Parse(b.Substring(0, b.Length - 1));
                b = a.data.yesterday.low.Substring(3);
                this.chart1.Series[0].Points[0].SetValueXY("昨天", double.Parse(b.Substring(0, b.Length - 1)));
                this.chart1.Series[1].Points[0].YValues[0] = double.Parse(b.Substring(0, b.Length - 1));
                for (int i = 0; i < 5; i++)
                {
                    var d = a.data.forecast[i].high.Substring(3);
                    this.chart1.Series[0].Points[i + 1].SetValueXY(a.data.forecast[i].date, 0);
                    this.chart1.Series[0].Points[i + 1].YValues[0] = double.Parse(d.Substring(0, d.Length - 1));
                    d = a.data.forecast[i].low.Substring(3);
                    this.chart1.Series[1].Points[i + 1].SetValueXY(a.data.forecast[i].date, 0);
                    this.chart1.Series[1].Points[i + 1].YValues[0] = double.Parse(d.Substring(0, d.Length - 1));

                }
            }
            else
                MessageBox.Show("您输入查找的城市有误！", "ERROR!");
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

        private void minSize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (this.search_txtbox.Text != "")
            {
                updateWeather(httptest.getWeather(search_txtbox.Text));
            }
            else
                MessageBox.Show("未联网或输入城市有误", "Error");
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
