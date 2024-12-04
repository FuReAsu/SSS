namespace SSS
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            pictureBox1 = new PictureBox();
            btn_next2 = new Button();
            DialogueBox = new Label();
            panel1 = new Panel();
            btn_atk = new Button();
            btn_run = new Button();
            ActionBtnPanel = new Panel();
            btn_heal = new Button();
            comboBox1 = new ComboBox();
            PlayerMPDisplay = new Label();
            PlayerNameDisplay = new Label();
            PlayerHPDisplay = new Label();
            SlimePanel = new Panel();
            SlimeHP = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ActionBtnPanel.SuspendLayout();
            SlimePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Slime360p;
            pictureBox1.Location = new Point(51, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 300);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_next2
            // 
            btn_next2.BackColor = Color.Khaki;
            btn_next2.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_next2.ForeColor = Color.Black;
            btn_next2.Location = new Point(1133, 104);
            btn_next2.Name = "btn_next2";
            btn_next2.Size = new Size(126, 41);
            btn_next2.TabIndex = 3;
            btn_next2.Text = ">>>";
            btn_next2.UseVisualStyleBackColor = false;
            btn_next2.Click += btn_next2_Click;
            // 
            // DialogueBox
            // 
            DialogueBox.AutoSize = true;
            DialogueBox.Font = new Font("Pretendard SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DialogueBox.ForeColor = Color.Yellow;
            DialogueBox.Location = new Point(35, 12);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(30, 27);
            DialogueBox.TabIndex = 4;
            DialogueBox.Text = "...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.panelOverLay;
            panel1.Controls.Add(DialogueBox);
            panel1.Controls.Add(btn_next2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 528);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 145);
            panel1.TabIndex = 5;
            // 
            // btn_atk
            // 
            btn_atk.BackColor = Color.IndianRed;
            btn_atk.BackgroundImageLayout = ImageLayout.None;
            btn_atk.Font = new Font("Chirp", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_atk.ForeColor = Color.WhiteSmoke;
            btn_atk.Location = new Point(12, 33);
            btn_atk.Name = "btn_atk";
            btn_atk.Size = new Size(113, 34);
            btn_atk.TabIndex = 6;
            btn_atk.Text = "Attack";
            btn_atk.UseVisualStyleBackColor = false;
            btn_atk.Click += btn_atk_Click;
            // 
            // btn_run
            // 
            btn_run.BackColor = Color.Purple;
            btn_run.Font = new Font("Chirp", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_run.ForeColor = Color.WhiteSmoke;
            btn_run.Location = new Point(463, 32);
            btn_run.Name = "btn_run";
            btn_run.Size = new Size(113, 34);
            btn_run.TabIndex = 10;
            btn_run.Text = "RUN";
            btn_run.UseVisualStyleBackColor = false;
            btn_run.Click += btn_run_Click;
            // 
            // ActionBtnPanel
            // 
            ActionBtnPanel.BackColor = Color.Transparent;
            ActionBtnPanel.Controls.Add(btn_heal);
            ActionBtnPanel.Controls.Add(comboBox1);
            ActionBtnPanel.Controls.Add(PlayerMPDisplay);
            ActionBtnPanel.Controls.Add(btn_run);
            ActionBtnPanel.Controls.Add(PlayerNameDisplay);
            ActionBtnPanel.Controls.Add(PlayerHPDisplay);
            ActionBtnPanel.Controls.Add(btn_atk);
            ActionBtnPanel.Location = new Point(0, 452);
            ActionBtnPanel.Name = "ActionBtnPanel";
            ActionBtnPanel.Size = new Size(1259, 85);
            ActionBtnPanel.TabIndex = 11;
            // 
            // btn_heal
            // 
            btn_heal.BackColor = Color.Green;
            btn_heal.Font = new Font("Chirp", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_heal.ForeColor = Color.WhiteSmoke;
            btn_heal.Location = new Point(148, 33);
            btn_heal.Name = "btn_heal";
            btn_heal.Size = new Size(113, 34);
            btn_heal.TabIndex = 17;
            btn_heal.Text = "Heal";
            btn_heal.UseVisualStyleBackColor = false;
            btn_heal.Click += btn_heal_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(192, 192, 0);
            comboBox1.Font = new Font("Pretendard", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.WhiteSmoke;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(285, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 35);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "ITEMS";
            comboBox1.MouseClick += comboBox1_MouseClick;
            // 
            // PlayerMPDisplay
            // 
            PlayerMPDisplay.AutoSize = true;
            PlayerMPDisplay.BackColor = Color.SteelBlue;
            PlayerMPDisplay.Font = new Font("Pretendard", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerMPDisplay.ForeColor = Color.WhiteSmoke;
            PlayerMPDisplay.Location = new Point(1052, 40);
            PlayerMPDisplay.Name = "PlayerMPDisplay";
            PlayerMPDisplay.Size = new Size(145, 27);
            PlayerMPDisplay.TabIndex = 16;
            PlayerMPDisplay.Text = "MP<80/80>";
            // 
            // PlayerNameDisplay
            // 
            PlayerNameDisplay.AutoSize = true;
            PlayerNameDisplay.BackColor = Color.White;
            PlayerNameDisplay.Font = new Font("Pretendard", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerNameDisplay.ForeColor = Color.Black;
            PlayerNameDisplay.Location = new Point(952, 0);
            PlayerNameDisplay.Name = "PlayerNameDisplay";
            PlayerNameDisplay.Size = new Size(174, 33);
            PlayerNameDisplay.TabIndex = 15;
            PlayerNameDisplay.Text = "PlayerName";
            // 
            // PlayerHPDisplay
            // 
            PlayerHPDisplay.AutoSize = true;
            PlayerHPDisplay.BackColor = Color.Lime;
            PlayerHPDisplay.Font = new Font("Pretendard", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerHPDisplay.ForeColor = Color.WhiteSmoke;
            PlayerHPDisplay.Location = new Point(870, 40);
            PlayerHPDisplay.Name = "PlayerHPDisplay";
            PlayerHPDisplay.Size = new Size(164, 27);
            PlayerHPDisplay.TabIndex = 14;
            PlayerHPDisplay.Text = "HP<100/100>";
            // 
            // SlimePanel
            // 
            SlimePanel.BackColor = Color.Transparent;
            SlimePanel.Controls.Add(SlimeHP);
            SlimePanel.Controls.Add(pictureBox1);
            SlimePanel.Location = new Point(463, 12);
            SlimePanel.Name = "SlimePanel";
            SlimePanel.Size = new Size(387, 384);
            SlimePanel.TabIndex = 13;
            // 
            // SlimeHP
            // 
            SlimeHP.AutoSize = true;
            SlimeHP.BackColor = Color.FromArgb(0, 192, 192);
            SlimeHP.Font = new Font("Pretendard", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SlimeHP.Location = new Point(139, 101);
            SlimeHP.Name = "SlimeHP";
            SlimeHP.Size = new Size(170, 27);
            SlimeHP.TabIndex = 1;
            SlimeHP.Text = "HP<200/200>";
            // 
            // Battle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.TheForest;
            ClientSize = new Size(1262, 673);
            Controls.Add(SlimePanel);
            Controls.Add(panel1);
            Controls.Add(ActionBtnPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Battle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSS";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ActionBtnPanel.ResumeLayout(false);
            ActionBtnPanel.PerformLayout();
            SlimePanel.ResumeLayout(false);
            SlimePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_next2;
        private Label DialogueBox;
        private Panel panel1;
        private Button btn_atk;
        private Button btn_run;
        private Panel ActionBtnPanel;
        private Panel SlimePanel;
        private Label SlimeHP;
        private Label PlayerMPDisplay;
        private Label PlayerNameDisplay;
        private Label PlayerHPDisplay;
        protected ComboBox comboBox1;
        private Button btn_heal;
    }
}