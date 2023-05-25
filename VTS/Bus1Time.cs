using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTS
{
    public partial class Bus1Time : Form
    {
        private System.Windows.Forms.Timer countdownTimer;
        private TimeSpan targetTime;
        public Bus1Time()
        {
            InitializeComponent();

            targetTime = TimeSpan.FromMinutes(1);

            // Create and configure the countdown Timer
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
        }
        private void Bus1Time_Load(object sender, EventArgs e)
        {
            csa.Text = "Bus departed";
            StartCountdown(1);
        }

        private void StartCountdown(int t)
        {
            targetTime = TimeSpan.FromMinutes(t);
            // Set the initial value of the countdown
            TimeSpan remainingTime = targetTime;

            // Display the initial countdown value in the TextBox
            UpdateCountdownTextBox(remainingTime);

            // Start the countdown Timer
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Update the remaining time by subtracting 1 second
            TimeSpan remainingTime = targetTime.Subtract(TimeSpan.FromSeconds(1));

            if (remainingTime.TotalSeconds <= 0)
            {
                // Countdown has reached 0, stop the timer
                countdownTimer.Stop();
                molto.Text = "The bus has passed this bus-stop"; fella.Text = "The bus has passed this bus-stop";
                kiler.Text = "The bus has passed this bus-stop"; belca.Text = "The bus has passed this bus-stop";
                kol.Text = "The bus has passed this bus-stop"; san.Text = "The bus has passed this bus-stop";
                yay.Text = "The bus has passed this bus-stop"; fua.Text = "The bus has passed this bus-stop";
                arcelik.Text = "The bus has passed this bus-stop";
            }
            else
            {
                // Update the countdown value in the TextBox
                UpdateCountdownTextBox(remainingTime);

                // Update the target time for the next tick
                targetTime = remainingTime;
            }
        }

        private void UpdateCountdownTextBox(TimeSpan remainingTime)
        {
            // Format the remaining time as a string in the format "mm:ss"
            string formattedTime = remainingTime.ToString("mm\\:ss");
            String display = "The bus arrives in : ";
            // Display the formatted time in the TextBox
            molto.Text = display + formattedTime; fella.Text = display + formattedTime; belca.Text = display + formattedTime;
            kiler.Text = display + formattedTime; kol.Text = display + formattedTime; fua.Text = display + formattedTime;
            san.Text = display + formattedTime; yay.Text = display + formattedTime; arcelik.Text = display + formattedTime;

        }

        private void back_Click(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;

            Buses bus = new Buses();
            bus.StartPosition = FormStartPosition.Manual;
            bus.Location = new System.Drawing.Point(centerX - bus.Width / 2, centerY - bus.Height / 2);
            bus.Show();

            this.Hide();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int centerX = screenWidth / 2;
            int centerY = screenHeight / 2;
            LoginPage login = new LoginPage();
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new System.Drawing.Point(centerX - login.Width / 2, centerY - login.Height / 2);
            login.Show();
            this.Hide();
        }
    }
}
