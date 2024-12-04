namespace SSS
{
    partial class MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            btn_ok = new Button();
            Message = new Label();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.BackColor = SystemColors.ActiveCaption;
            btn_ok.Font = new Font("Chirp Heavy", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ok.ForeColor = Color.FromArgb(0, 64, 64);
            btn_ok.Location = new Point(243, 90);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(85, 36);
            btn_ok.TabIndex = 0;
            btn_ok.Text = "ok";
            btn_ok.UseVisualStyleBackColor = false;
            btn_ok.Click += btn_ok_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Chirp Medium", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            Message.Location = new Point(66, 38);
            Message.Name = "Message";
            Message.Size = new Size(474, 32);
            Message.TabIndex = 1;
            Message.Text = "You don't have any items right now.";
            // 
            // MessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 147);
            Controls.Add(Message);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private Label Message;
    }
}