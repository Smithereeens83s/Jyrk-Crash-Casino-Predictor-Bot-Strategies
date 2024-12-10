using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crash_Hack
{
    public partial class Login : Form
    {

        private Timer Timer;
        private double targetOpacity = 1.0;
        private const double opacityIncrement = 0.05;
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            Timer = new Timer();
            Timer.Interval = 50;
            Timer.Tick += timer_Tick;
            Timer.Start();

            this.Opacity = 0;
        }

        private void loginbtn_ClickAsync(object sender, EventArgs e)
        {
            if (UsernameTB.Text != "CrashPredictor" || PasswordTB.Text != "CrashPredictor")
            {
                MessageBox.Show("Invalid username or password. Please enter the correct information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CrashGame form2 = new CrashGame();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
        }

        private void lb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: CrashPredictor\nPassword: CrashPredictor", "Information",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
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
    }
}
