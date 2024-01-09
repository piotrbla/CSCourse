namespace ThreadForms
{
    partial class frmTimer
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
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(12, 114);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(209, 101);
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
            lblTime.Size = new Size(454, 82);
            lblTime.TabIndex = 1;
            lblTime.Text = "23:59:59:99";
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Consolas", 22F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(257, 114);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(209, 101);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // frmTimer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 245);
            ControlBox = false;
            Controls.Add(btnStop);
            Controls.Add(lblTime);
            Controls.Add(btnStart);
            Name = "frmTimer";
            Text = "Timer";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Label lblTime;
        private Button btnStop;
    }
}
