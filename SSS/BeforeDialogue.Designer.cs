namespace SSS
{
    partial class BeforeDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeforeDialogue));
            DialogueBox = new Label();
            DialoguePanel = new Panel();
            btn_next = new Button();
            GetPlayerNamePanel = new Panel();
            btn_namesave = new Button();
            GetPlayerName = new TextBox();
            label1 = new Label();
            DialoguePanel.SuspendLayout();
            GetPlayerNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // DialogueBox
            // 
            DialogueBox.AutoSize = true;
            DialogueBox.Font = new Font("Pretendard SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DialogueBox.Location = new Point(12, 15);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(30, 27);
            DialogueBox.TabIndex = 1;
            DialogueBox.Text = "...";
            // 
            // DialoguePanel
            // 
            DialoguePanel.BackColor = Color.Transparent;
            DialoguePanel.BackgroundImage = Properties.Resources.panelOverLay;
            DialoguePanel.Controls.Add(btn_next);
            DialoguePanel.Controls.Add(DialogueBox);
            DialoguePanel.Dock = DockStyle.Bottom;
            DialoguePanel.ForeColor = Color.FromArgb(255, 255, 128);
            DialoguePanel.Location = new Point(0, 502);
            DialoguePanel.Name = "DialoguePanel";
            DialoguePanel.Size = new Size(1262, 171);
            DialoguePanel.TabIndex = 2;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Khaki;
            btn_next.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next.ForeColor = Color.Black;
            btn_next.Location = new Point(1133, 127);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(126, 41);
            btn_next.TabIndex = 2;
            btn_next.Text = ">>>";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // GetPlayerNamePanel
            // 
            GetPlayerNamePanel.BackColor = Color.Transparent;
            GetPlayerNamePanel.BackgroundImage = Properties.Resources.panelOverLay;
            GetPlayerNamePanel.Controls.Add(btn_namesave);
            GetPlayerNamePanel.Controls.Add(GetPlayerName);
            GetPlayerNamePanel.Controls.Add(label1);
            GetPlayerNamePanel.Location = new Point(241, 111);
            GetPlayerNamePanel.Name = "GetPlayerNamePanel";
            GetPlayerNamePanel.Size = new Size(741, 193);
            GetPlayerNamePanel.TabIndex = 3;
            // 
            // btn_namesave
            // 
            btn_namesave.BackColor = Color.White;
            btn_namesave.Font = new Font("Chirp Heavy", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_namesave.ForeColor = Color.Black;
            btn_namesave.Location = new Point(397, 133);
            btn_namesave.Name = "btn_namesave";
            btn_namesave.Size = new Size(143, 38);
            btn_namesave.TabIndex = 2;
            btn_namesave.Text = "Save";
            btn_namesave.UseVisualStyleBackColor = false;
            btn_namesave.Click += btn_namesave_Click;
            // 
            // GetPlayerName
            // 
            GetPlayerName.Font = new Font("Chirp Heavy", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GetPlayerName.Location = new Point(303, 73);
            GetPlayerName.Name = "GetPlayerName";
            GetPlayerName.Size = new Size(333, 35);
            GetPlayerName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Chirp Heavy", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(89, 81);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TheForest;
            ClientSize = new Size(1262, 673);
            Controls.Add(GetPlayerNamePanel);
            Controls.Add(DialoguePanel);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSS";
            Load += Form2_Load;
            DialoguePanel.ResumeLayout(false);
            DialoguePanel.PerformLayout();
            GetPlayerNamePanel.ResumeLayout(false);
            GetPlayerNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label DialogueBox;
        private Panel DialoguePanel;
        private Button btn_next;
        private Panel GetPlayerNamePanel;
        private Button btn_namesave;
        private TextBox GetPlayerName;
        private Label label1;
    }
}