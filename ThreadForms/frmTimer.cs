namespace ThreadForms
{
    public partial class frmTimer : Form
    {
        private OwnThread? _ownThread;
        private Thread? _timerThread;
        private static readonly ManualResetEvent _resetEvent
            = new ManualResetEvent(false);
        private bool _keepRunning = true;
        private void DoWork()
        {
            while (!_resetEvent.WaitOne(1000))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
                });
            }
        }
        private void DoWorkBool()
        {
            while (_keepRunning)
            {
                Thread.Sleep(1000);
                this.Invoke((MethodInvoker)delegate
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
                });
            }
        }
        private void DoWorkEvent()
        {
            while (true)
            {
                Thread.Sleep(100);
                this.Invoke((MethodInvoker)delegate
                {
                    lblTime.Text = DateTime.Now.ToString("HH:mm:ss:ff");
                });
                if (_resetEvent.WaitOne(0))
                {
                    break;
                }
            }
        }

        public frmTimer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            _keepRunning = true;
            _ownThread = new OwnThread((s) => lblTime.Text = s);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _keepRunning = true;
            _resetEvent.Reset();
            _timerThread = new Thread(DoWork);
            _timerThread.IsBackground = true;
            _timerThread.Start();
            //_ownThread?.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _keepRunning = false;
            _resetEvent.Set();
            //_ownThread?.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }

    public class OwnThread
    {
        public OwnThread(Action<string> callback)
        {
            _callback = callback;

        }
        private void DoWork()
        {
            while(!_resetEvent.WaitOne(1000))
            {
                _callback(DateTime.Now.ToString("HH:mm:ss:ff"));
            }
        }

        public void Start()
        {
            _keepRunning = true;
            _resetEvent.Reset();
            _thread = new Thread(DoWork);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Stop()
        {
            _keepRunning = false;
            _resetEvent.Set();
        }

        private Thread? _thread;
        private bool _keepRunning = true;
        private Action<string> _callback;
        private static readonly ManualResetEvent _resetEvent
            = new ManualResetEvent(false);
    }
}
