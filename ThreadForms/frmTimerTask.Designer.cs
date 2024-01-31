namespace ThreadForms
{
    partial class frmTimerTask
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            lblTime = new Label();
            btnStop = new Button();
            btnRun = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(12, 114);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(156, 101);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTime
            // 
            lblTime.BorderStyle = BorderStyle.FixedSingle;
            lblTime.Font = new Font("Consolas", 34F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(12, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(479, 82);
            lblTime.TabIndex = 1;
            lblTime.Text = "23:59:59:99";
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(174, 114);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(130, 101);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnRun.Location = new Point(310, 114);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(181, 101);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 213);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(505, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(56, 25);
            toolStripStatusLabel1.Text = "00:00";
            // 
            // frmTimerTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 245);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(btnRun);
            Controls.Add(btnStop);
            Controls.Add(lblTime);
            Controls.Add(btnStart);
            Name = "frmTimerTask";
            Text = "Timer";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblTime;
        private Button btnStop;
        private Button btnRun;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
