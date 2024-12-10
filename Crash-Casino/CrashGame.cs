using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crash_Hack
{
    public partial class CrashGame : Form
    {

        private Timer Timer;
        private double targetOpacity = 1.0;
        private const double opacityIncrement = 0.05;

        Dictionary<string, string> previousData = new Dictionary<string, string>();


        public CrashGame()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            startBtn.Enabled = false;

            Timer = new Timer();
            Timer.Interval = 50;
            Timer.Tick += TimerTick_Tick;
            Timer.Start();

            this.Opacity = 0;
        }

        private async void chkInfo_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(LGSText.Text) || string.IsNullOrWhiteSpace(PNText.Text) || string.IsNullOrWhiteSpace(CGText.Text))
            {
                MessageBox.Show("Please fill in the specified fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!LGSText.Text.StartsWith("0"))
            { 
                MessageBox.Show("Please Enter Valid Seed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await ShowLoadingAnimation();

            

            ShowSuccessMessage();
            startBtn.Enabled = true;
        }

        private async Task ShowLoadingAnimation()
        {
            const int animationDuration = 500;
            const int maxDots = 4;
            const string loadingText = "Checking Data";

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < maxDots; i++)
                {
                    chkInfo.Text = loadingText + new string('.', i);
                    await Task.Delay(animationDuration);
                }
                chkInfo.Text = loadingText;
                await Task.Delay(animationDuration);
            }
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Data Checked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearStatus();
        }

        private void ClearStatus()
        {
            chkInfo.Text = "Check Information";
        }

        private void TimerTick_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                Timer.Stop();
                return;
            }

            if (this.Opacity < targetOpacity)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                Timer.Stop();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            string lgm = LGSText.Text.Trim();
            string eilg = PNText.Text.Trim();
            string cslg = CGText.Text.Trim();

            if (string.IsNullOrEmpty(lgm) || string.IsNullOrEmpty(eilg) || string.IsNullOrEmpty(cslg))// || string.IsNullOrEmpty(ss))
            {
                MessageBox.Show("Please fill in the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dataKey = $"{lgm}-{eilg}-{cslg}";
            if (previousData.ContainsKey(dataKey))
            {
                MessageBox.Show("Bet Prediction Already Made.\nPlease enter the information of the most recent game.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                previousData[dataKey] = "Crash";
            }


            Random random = new Random();
            double randomNumber = random.NextDouble() * (100 - 85) + 85;

            double minMultiplier = 1.0;
            double maxMultiplier = 10.0;
            double probabilityThreshold = 0.05;

            double multiplier = GenerateMultiplier(random, minMultiplier, maxMultiplier, probabilityThreshold);

            double result = Math.Round(multiplier, 2);

            label11.Text = $"{result}X";
            chnglbl.Text = $"{randomNumber:F2}%";
            startBtn.Enabled = false;

        }

        static double GenerateMultiplier(Random random, double minMultiplier, double maxMultiplier, double probabilityThreshold)
        {
            double multiplier;

            if (random.NextDouble() < probabilityThreshold)
            {
                multiplier = NormalDistribution(random, minMultiplier, maxMultiplier);
            }
            else
            {
                multiplier = random.NextDouble() * (maxMultiplier - minMultiplier) + minMultiplier;
            }

            return multiplier;
        }


        static double NormalDistribution(Random random, double min, double max)
        {
            double mean = (min + max) / 2.0;
            double standardDeviation = (max - min) / 6.0;

            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

            double randNormal = mean + standardDeviation * randStdNormal;

            if (randNormal < min)
                randNormal = min;
            else if (randNormal > max)
                randNormal = max;

            return randNormal;
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            Process.Start("https://stake.com/tr/casino/games/crash");
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the Seed Information of the Last Game.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void info2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the Last Game's Hash Information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void info3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the ID of the Last Game.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
