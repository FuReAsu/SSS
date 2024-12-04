using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Avoid : Form
    {
        int counter = 0;
        public Avoid()
        {
            InitializeComponent();
            DialogueBox.Text = "You wanted to take a step forward but you succumbed to safety.";
            txt_TheEnd.Hide();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                DialogueBox.Text = "You couldn’t do it. As you were always a coward. ";
            }
            else
            {
                DialoguePanel.Hide();
                txt_TheEnd.Show();
            }
        }

        private void end_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void end_panel_MouseClick(object sender, MouseEventArgs e)
        {
            string TryAgain = "1";
            File.WriteAllText(@"..\..\..\DATA\TryAgain.txt", TryAgain);
            Start ST = new();
            this.Hide();
            ST.ShowDialog();
            this.Close();


        }
    }
}
