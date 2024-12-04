using System.ComponentModel;
using System.Resources;

namespace SSS
{
    public partial class Start : Form
    {
        public Start()
        {
            string TryAgain;
            InitializeComponent();
            btn_tryagain.Hide();
            bool check = File.Exists(@"..\..\..\DATA\TryAgain.txt");
            if (check == false)
            {
                File.Create(@"..\..\..\DATA\TryAgain.txt");
            }
            TryAgain = File.ReadAllText(@"..\..\..\DATA\TryAgain.txt");
            if (TryAgain == "1")
            {
                btn_tryagain.Show();
            }

            TryAgain = "0";
            File.WriteAllText(@"..\..\..\DATA\TryAgain.txt", TryAgain);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            BeforeDialogue F2 = new();
            this.Hide();
            F2.ShowDialog();
            //this.WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void btn_tryagain_Click(object sender, EventArgs e)
        {
            Battle B = new();
            this.Hide();
            B.ShowDialog();
            this.Close();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.FromArgb(29, 146, 242);
            btn_start.ForeColor = Color.White;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.Cyan;
            btn_start.ForeColor = Color.Teal;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {

            btn_exit.BackColor = Color.FromArgb(30, 146, 242);
            btn_exit.ForeColor = Color.White;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.Cyan;
            btn_exit.ForeColor = Color.Teal;
        }

        private void btn_tryagain_MouseHover(object sender, EventArgs e)
        {

            btn_tryagain.BackColor = Color.FromArgb(29, 146, 242);
            btn_tryagain.ForeColor = Color.White;
        }

        private void btn_tryagain_MouseLeave(object sender, EventArgs e)
        {
            btn_tryagain.BackColor = Color.Cyan;
            btn_tryagain.ForeColor = Color.Teal;
        }
    }
}