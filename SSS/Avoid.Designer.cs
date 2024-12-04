﻿namespace SSS
{
    partial class Avoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avoid));
            DialoguePanel = new Panel();
            btn_next = new Button();
            DialogueBox = new Label();
            txt_TheEnd = new Label();
            end_panel = new Panel();
            DialoguePanel.SuspendLayout();
            SuspendLayout();
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
            DialoguePanel.TabIndex = 3;
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
            // txt_TheEnd
            // 
            txt_TheEnd.AutoSize = true;
            txt_TheEnd.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TheEnd.ForeColor = Color.FromArgb(128, 255, 255);
            txt_TheEnd.Location = new Point(490, 248);
            txt_TheEnd.Name = "txt_TheEnd";
            txt_TheEnd.Size = new Size(282, 71);
            txt_TheEnd.TabIndex = 3;
            txt_TheEnd.Text = "THE END";
            // 
            // end_panel
            // 
            end_panel.Location = new Point(0, 0);
            end_panel.Name = "end_panel";
            end_panel.Size = new Size(1262, 670);
            end_panel.TabIndex = 4;
            end_panel.Paint += end_panel_Paint;
            end_panel.MouseClick += end_panel_MouseClick;
            // 
            // Avoid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1262, 673);
            Controls.Add(txt_TheEnd);
            Controls.Add(DialoguePanel);
            Controls.Add(end_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Avoid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SSS";
            DialoguePanel.ResumeLayout(false);
            DialoguePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DialoguePanel;
        private Button btn_next;
        private Label DialogueBox;
        private Label txt_TheEnd;
        private Panel end_panel;
    }
}