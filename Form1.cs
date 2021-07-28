using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PlayTimeTicker
{
    /*
     * PlayTimeTicker
     * Skapad av Oscar Freij / OffTheGridCG
     * 2021-07-28
     */

    public partial class Form1 : Form
    {

        public static TimeSpan timeToBrick = new TimeSpan(6, 0, 0);
        public static TimeSpan timePerPlayer = new TimeSpan(0, 40, 0);
        public static TimeSpan currentPlayerTime = new TimeSpan();
        public static bool clockRunning = false;
        public static bool lockdown = false;

        public List<Player> players;

        public Thread clockThread;
        public Thread killThread;

        public Form1()
        {
            InitializeComponent();
            clockThread = new Thread(clockFunction);
            killThread = new Thread(killFunction);
            killThread.Start();
            players = new List<Player>();
        }

        public void killFunction()
        {
            DateTime start = DateTime.Now;

            while (true)
            {
                if (timeToBrick <= (DateTime.Now.Subtract(start)))
                {
                    lockdown = true;
                    clockRunning = false;

                    DialogResult res = MessageBox.Show("Nu stänger spelhörnan!", "Notis!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        // Do Nothing!
                    }
                    killThread.Abort();
                }
            }
        }

        public async void clockFunction()
        {
            DateTime start = DateTime.Now;

            TimeSpan currentTimeDiff = new TimeSpan();

            while (clockRunning)
            {
                currentTimeDiff = (DateTime.Now.Subtract(start));

                SetText((timePerPlayer - (currentPlayerTime + currentTimeDiff)));

                if ((currentPlayerTime.TotalSeconds + currentTimeDiff.TotalSeconds) >= timePerPlayer.TotalSeconds)
                {
                    Player currentPlayer = players[0];
                    players.Remove(currentPlayer);
                    players.Add(currentPlayer);
                    currentPlayer.Tick();

                    if (players.Count() != 0)
                    {
                        currentPlayerTime = new TimeSpan();
                        start = DateTime.Now;
                    }
                    else
                    {
                        SetText(new TimeSpan(0,0,0));
                        clockRunning = false;
                        clockThread.Abort();
                        this.progressBar.MarqueeAnimationSpeed = 0;
                        this.clockStartStopBtn.Text = "Starta";
                        this.clockStartStopBtn.BackColor = Color.Orange;

                        return;
                    }
                    UpdateList();

                }
                await Task.Delay(1000);
            }

            currentPlayerTime = currentPlayerTime + currentTimeDiff;
            clockThread.Abort();
        }

        delegate void LockdownCallback();
        public void Lockdown()
        {
            if (this.addNameBtn.InvokeRequired)
            {
                LockdownCallback d = new LockdownCallback(Lockdown);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.BackColor = Color.DarkGray;
                this.addNameBtn.Enabled = false;
                this.clockStartStopBtn.Enabled = false;
            }
        }

        delegate void UpdateListCallback();
        public void UpdateList()
        {
            if (playerList.InvokeRequired)
            {
                UpdateListCallback d = new UpdateListCallback(UpdateList);
                this.Invoke(d, new object[] { });
            }
            else
            {
                playerList.Items.Clear();

                foreach (var player in players)
                {
                    playerList.Items.Add(player.GetListViewItem());
                }

                playerList.Update();
            }
        }

        private void addNameBtn_Click(object sender, EventArgs e)
        {
            if (!lockdown)
            {
                string data = nameInputBox.Text;
                players.Add(new Player(data));

                UpdateList();
                nameInputBox.Clear();
            }
        }

        private void clockStartStopBtn_Click(object sender, EventArgs e)
        {
            if (!lockdown)
            {
                if (!clockRunning && players.Count > 0)
                {
                    clockRunning = true;
                    clockThread = new Thread(clockFunction);
                    clockThread.Start();
                    this.progressBar.MarqueeAnimationSpeed = 500;
                    this.clockStartStopBtn.Text = "Pausa";
                    this.clockStartStopBtn.BackColor = Color.LimeGreen;
                }
                else
                {
                    clockRunning = false;
                    clockThread.Abort();
                    this.progressBar.MarqueeAnimationSpeed = 0;
                    this.clockStartStopBtn.Text = "Starta";
                    this.clockStartStopBtn.BackColor = Color.Orange;
                }
            }
        }

        delegate void SetTextCallback(TimeSpan ts);

        private void SetText(TimeSpan ts)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.clock.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { ts });
            }
            else
            {
                int percentLeft = (int)((ts.TotalSeconds / timePerPlayer.TotalSeconds) * 100);
                if ( percentLeft >= 0)
                {
                    this.progressBar.Value = percentLeft;
                }

                this.clock.Text = $"{ts.Minutes}:{ts.Seconds}";

                if (ts.Seconds < 5)
                {   
                    this.progressBar.SetState(2);
                }
                else if (ts.Seconds < 15)
                {
                    this.progressBar.SetState(3);
                }
                else
                {
                    this.progressBar.SetState(1);
                }
            }
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }

    public class Player
    {
        public string name;
        public int cycleTime;
        public DateTime lastPlayed;
        public Player(string name)
        {
            this.name = name;
            this.cycleTime = 0;
        }

        public void Tick()
        {
            cycleTime++;
            lastPlayed = DateTime.Now;
        }

        public ListViewItem GetListViewItem()
        {
            string lPData = "-----";

            if (lastPlayed != new DateTime())
            {
                lPData = lastPlayed.ToString();
            }
            string[] data = { cycleTime.ToString(), name, lPData };
            return new ListViewItem(data);
        }
    }
}
