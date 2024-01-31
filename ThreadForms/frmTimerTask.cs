namespace ThreadForms
{
    public partial class frmTimerTask : Form
    {
        private Task? _timerTask;
        private bool _keepRunning = true;
        private int runCount = 1;
        private void DoWork()
        {
            while (_keepRunning)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
                });
            }
        }

        private string DoWorkRun()
        {
            for (int i = 0; i < 50; i++)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
                });
                Thread.Sleep(100);
            }
            return DateTime.Now.ToString("HH:mm:ss:ff");
        }

        public frmTimerTask()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _timerTask = new Task(DoWork);
            _timerTask.Start();
            _keepRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            _keepRunning = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            var finishTime = await Task.Run(DoWorkRun);
            btnRun.Text = $"Done {runCount}";
            runCount+=1;
            btnRun.Enabled = true;
            toolStripStatusLabel1.Text = finishTime;
        }
    }

}
