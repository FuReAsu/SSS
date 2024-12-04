namespace SSS
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            btn_start = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_exit = new Button();
            btn_tryagain = new Button();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Cyan;
            btn_start.Font = new Font("Pretendard Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_start.ForeColor = Color.Teal;
            btn_start.Location = new Point(963, 165);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(197, 59);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            btn_start.MouseLeave += btn_start_MouseLeave;
            btn_start.MouseHover += btn_start_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(538, 75);
            label1.Name = "label1";
            label1.Size = new Size(622, 54);
            label1.TabIndex = 2;
            label1.Text = "Slime Slaying Simulator (demo)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Chirp Medium", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1054, 640);
            label2.Name = "label2";
            label2.Size = new Size(196, 24);
            label2.TabIndex = 3;
            label2.Text = "by Saw Myint Myat";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Cyan;
            btn_exit.Font = new Font("Pretendard Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.Teal;
            btn_exit.Location = new Point(963, 251);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(197, 59);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            btn_exit.MouseHover += btn_exit_MouseHover;
            // 
            // btn_tryagain
            // 
            btn_tryagain.BackColor = Color.Cyan;
            btn_tryagain.Font = new Font("Pretendard Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tryagain.ForeColor = Color.Teal;
            btn_tryagain.Location = new Point(963, 338);
            btn_tryagain.Name = "btn_tryagain";
            btn_tryagain.Size = new Size(197, 59);
            btn_tryagain.TabIndex = 5;
            btn_tryagain.Text = "Try Again";
            btn_tryagain.UseVisualStyleBackColor = false;
            btn_tryagain.Click += btn_tryagain_Click;
            btn_tryagain.MouseLeave += btn_tryagain_MouseLeave;
            btn_tryagain.MouseHover += btn_tryagain_MouseHover;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.StartScreen;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_tryagain);
            Controls.Add(btn_exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSS";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btn_start;
        private Label label1;
        private Label label2;
        private Button btn_exit;
        private Button btn_tryagain;
    }
}